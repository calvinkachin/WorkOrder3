﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WorkOrder3
{
    public partial class UploadForm : Form
    {
        public static string UPLOAD_PATH = "UPLOAD_PATH";

        public UploadForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Kanban Executable (.exe)|";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = ofd.FileName;
                var values = path.Split('\\');

                values[values.Length - 1] = "";

                path = String.Join("\\", values);

                if (Directory.Exists(path + "Folders\\"))
                {
                    txtUploadPath.Text = path;

                    var w = new StreamWriter(UPLOAD_PATH);
                    w.WriteLine(path);
                    w.Close();
                }
                else
                {
                    MessageBox.Show("Could not find the Folders directory in the selected path. Make sure you select the Kanban .exe");
                    return;
                }

            }
        }

        private void UploadForm_Load(object sender, EventArgs e)
        {
            dgvWorkOrders.Rows.Clear();
            cmbDestinationColumn.Items.Clear();

            string kanban_path = "";

            //Check if the upload path is already entered
            if (File.Exists(UPLOAD_PATH))
            {
                var r = new StreamReader(UPLOAD_PATH);
                kanban_path = r.ReadLine();
                txtUploadPath.Text = kanban_path;
                r.Close();

                //Gets a list of column names that allow for upload
                List<string> column_names_list = new List<string>();

                try
                {
                    //Find all the column names
                    var env_reader = new StreamReader(kanban_path + "env_settings.txt");
                    while (!env_reader.EndOfStream)
                    {
                        var values = env_reader.ReadLine().Split('|');

                        if (values[0].ToUpper() == "COL")
                        {
                            column_names_list.Add(values[1] + "." + values[2]);
                        }
                    }
                    env_reader.Close();

                    //Go through each column file and find if it is uploadable
                    foreach (string col in column_names_list)
                    {
                        bool uploadable = false;

                        var col_reader = new StreamReader(kanban_path + "\\Office\\" + col + ".txt");
                        while (!col_reader.EndOfStream)
                        {
                            var values = col_reader.ReadLine().Split('|');

                            if (values[0].ToUpper() == "UPLOADABLE" && values[1].ToUpper() == "TRUE")
                            {
                                uploadable = true;
                                break;
                            }
                        }
                        col_reader.Close();

                        //If uploadable, add their ID to the combo box
                        if (uploadable)
                        {
                            cmbDestinationColumn.Items.Add(col);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Could not find column names!");
                    return;
                }
            }

            //Add all saved Work Orders to the list to be uploaded
            LoadSavedWorkOrders();
        }

        private void LoadSavedWorkOrders()
        {
            dgvWorkOrders.Rows.Clear();

            foreach (string dir in Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\Saved\\"))
            {
                var values = dir.Split('\\');
                string wo_string = values[values.Length - 1];

                if (File.Exists(dir + "\\" + wo_string))
                {
                    WO workorder = WO.WorkOrderFromFile(dir + "\\" + wo_string);

                    int failed_pms = 0;
                    int passed_pms = 0;
                    int others = 0;

                    foreach (ReportEntry RE in workorder.report_data)
                    {
                        
                        if (RE.work_type == "PM")
                        {
                            if (RE.tech_report.ToUpper().Contains("[FAILED PM]"))
                            {
                                failed_pms++;
                            }
                            else
                            {
                                if (passed_pms == 0)
                                {
                                    passed_pms = 1;
                                }
                            }
                        }
                        else
                        {
                            others++;
                        }
                    }

                    string sum = (passed_pms + failed_pms + others).ToString();
                    if (passed_pms > 0)
                    {
                        sum = "Approx. " + sum;
                    }

                    string[] line = new string[] { wo_string, workorder.customer_site, workorder.check_out_time.ToString("dd/MMM/yyyy"), workorder.report_data.Count.ToString(), sum };

                    dgvWorkOrders.Rows.Add(line);
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            /*
            //Check if the upload path is good
            if(txtUploadPath.Text=="" && !Directory.Exists(txtUploadPath.Text))
            {
                MessageBox.Show("Invalid upload path! Please make sure a connection to the upload path exists.");
                return;
            }

            //Make sure there is an upload column
            if (cmbDestinationColumn.Text == "")
            {
                MessageBox.Show("Please select a Column ID to upload your work orders to!");
                return;
            }

            //Initialize
            string tab = cmbDestinationColumn.Text.Split('.')[0];
            string col = cmbDestinationColumn.Text.Split('.')[1];
            string kb_path = txtUploadPath.Text;
            
            int upload_count = 0;

            //For every Work Order that is checked off...
            foreach(DataGridViewRow dgvr in dgvWorkOrders.Rows)
            {
                DataGridViewCheckBoxCell chk = dgvr.Cells[dgvWorkOrders.Columns.IndexOf(colCheck)] as DataGridViewCheckBoxCell;

                if (chk.Value == chk.TrueValue)
                {
                    upload_count++;
                    string wo = dgvr.Cells["colWorkOrder"].Value.ToString();
                    string wo_directory = Form1.SAVED_DIRECTORY + wo + "\\";

                    List<PassedPMBatch> passed_PMs = new List<PassedPMBatch>();

                    WO order = WO.WorkOrderFromFile(wo_directory + wo);

                    //For each report line from the work order..
                    foreach(ReportEntry RE in order.report_data)
                    {
                        string folder_directory = kb_path + "\\Folders\\" + wo + "_" + RE.serial + "\\";

                        if (RE.work_type.ToUpper() == "PM" && !RE.tech_report.ToUpper().Contains("[FAILED PM]"))
                        {
                            bool found = false;
                            foreach(PassedPMBatch PPMB in passed_PMs)
                            {
                                if (PPMB.model == RE.model)
                                {
                                    found = true;
                                    
                                    PPMB.report_lines.Add(line);
                                }
                            }

                            if (found == false)
                            {
                                PassedPMBatch PPMB = new PassedPMBatch(RE.model);
                                PPMB.report_lines.Add(line);
                                passed_PMs.Add(PPMB);
                            }
                        }
                        else
                        {
                            DoTheUpload(wo, order, line, tab, col);
                        }
                    }
                    
                    //For all the passed PM's, add them to one single Task based on model
                    foreach (PassedPMBatch PPMB in passed_PMs)
                    {
                        string line = PPMB.report_lines[0];
                        var values = line.Split('|');
                        string first_serial = values[0];

                        values[0] = "";

                        foreach(string entry in PPMB.report_lines)
                        {
                            values[0] = values[0] + "," + entry.Split('|')[0];
                        }
                        values[0]=values[0].Remove(0, 1);

                        string out_line = String.Join("|", values);
                        DoTheUpload(wo, order, out_line, tab, col);
                    }
                    
                    if (!order.TransferToArchive())
                    {
                        MessageBox.Show("Transfer unsuccessful.");
                    }
                    order.uploaded = true;
                    order.ExportToFile();
                    
                }
            }
            
            if (upload_count == 0)
            {
                MessageBox.Show("Please select at least one Work Order to upload!");
                return;
            }
            else
            {
                MessageBox.Show("Upload Successful! Work Orders uploaded: " + upload_count);
            }

            LoadSavedWorkOrders();
            */
        }

        private void DoTheUpload(string wo, WO order, string line, string tab, string col)
        {
            var values = line.Split('|');

            string first_serial = "";
            if (values[0].Contains(','))
            {
                first_serial = values[0].Split(',')[0];
            }
            else
            {
                first_serial = values[0];
            }
            
            string kb_path = txtUploadPath.Text;
            string wo_directory = Form1.SAVED_DIRECTORY + wo + "\\";
            string folder_directory = kb_path + "\\Folders\\" + wo + "_" + first_serial + "\\";

            string kanban_entry = GetKanbanEntry(wo, order.customer_site, line, tab, col);

            try
            {
                var w = new StreamWriter(kb_path + "\\Tabs\\" + tab + ".txt", true);
                w.WriteLine(kanban_entry);
                w.Close();
            }
            catch
            {
                MessageBox.Show("Could not upload: " + order.work_order_string);
                return;
            }

            //Create the new folder
            if (!Directory.Exists(folder_directory))
            {
                Directory.CreateDirectory(folder_directory);
            }

            //Write the data of this work order line to the !data file
            try
            {
                var writer = new StreamWriter(folder_directory + "!data");
                writer.WriteLine("SR|" + wo + "_" + values[0].Split(',')[0]);
                writer.WriteLine("SERIAL|" + values[0]);
                writer.WriteLine("PARTNUM|");
                writer.WriteLine("MODEL|" + values[1]);
                writer.WriteLine("CUSTOMER|" + order.customer_site);
                writer.WriteLine("CONTACT NAME|" + order.contact_name);
                writer.WriteLine("EMAIL|" + order.contact_email);
                writer.WriteLine("SHIPPING ADDRESS|" + order.address);
                writer.WriteLine("CREATED|" + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                writer.Close();
            }
            catch
            {

            }

            //Write any problems to the Kanban's Problem/Repair system
            try
            {
                var repair = new StreamWriter(folder_directory + "!repair");

                if (values[4].ToUpper().Contains("[FAILED PM]"))
                {
                    repair.WriteLine("Problem|1|" + values[4] + "|N/A|");
                }
                else
                {
                    repair.WriteLine("Problem|1|" + values[3] + "|N/A|");
                }

                repair.Close();
            }
            catch
            {

            }

            //Upload any files related to the folder
            foreach (string filename in Directory.GetFiles(Form1.SAVED_DIRECTORY+wo+"\\"))
            {
                if (!values[0].Contains(","))
                {
                    if (filename.ToUpper().Contains(values[0].ToUpper()) || filename.ToUpper().Contains("!WO"))
                    {
                        var f_values = filename.Split('\\');
                        string filename_nopath = f_values[f_values.Length - 1];

                        if (!File.Exists(folder_directory + "\\" + filename_nopath))
                        {
                            File.Copy(filename, folder_directory + "\\" + filename_nopath);
                        }
                    }
                }
                else
                {
                    var serials = values[0].Split(',');

                    foreach(string s in serials)
                    {
                        if (filename.ToUpper().Contains(s.ToUpper()) || filename.ToUpper().Contains("!WO"))
                        {
                            var f_values = filename.Split('\\');
                            string filename_nopath = f_values[f_values.Length - 1];

                            if (!File.Exists(folder_directory + "\\" + filename_nopath))
                            {
                                File.Copy(filename, folder_directory + "\\" + filename_nopath);
                            }
                        }
                    }
                }


            }
        }
        
        private string GetKanbanEntry(string work_order_number, string customer_site, string report_line,string tab_name, string column_name)
        {
            var values = report_line.Split('|');
            DateTime DEFAULT_DATE = new DateTime(2000, 1, 1, 0, 0, 0);
            StringBuilder sb = new StringBuilder();

            string status = "";

            string first_serial = "";
            if (values[0].Contains(","))
            {
                first_serial = values[0].Split(',')[0];
            }
            else
            {
                first_serial = values[0];
            }

            if (report_line.Contains("PM"))
            {
                if(report_line.Contains("[FAILED PM]"))
                {
                    status = "/FAILED_PM";
                }
                else
                {
                    status = "/PASSED_PM";
                }
            }

            sb.Append(work_order_number + "_" + first_serial);
            sb.Append("|");
            sb.Append(values[0]);
            sb.Append("|");
            sb.Append(values[1]);
            sb.Append("|");
            sb.Append(column_name);
            sb.Append("|");
            sb.Append("UNASSIGNED");
            sb.Append("|");
            sb.Append(customer_site);
            sb.Append("|");
            sb.Append("Work_Order_Upload"+status);
            sb.Append("|");
            sb.Append(values[4]);
            sb.Append("|");
            sb.Append(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            sb.Append("|");
            sb.Append(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            sb.Append("|");
            sb.Append(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            sb.Append("|");
            sb.Append(DEFAULT_DATE.ToString("dd/MM/yyyy HH:mm"));
            sb.Append("|");
            sb.Append(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

            return sb.ToString();
        }

        private void cmbDestinationColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtUploadPath.Text != "")
            {
                string path = txtUploadPath.Text + "Tabs\\" + cmbDestinationColumn.Text.Split('.')[0]+".txt";

                try
                {
                    var r = new StreamReader(path);
                    r.Close();

                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "Destination Status: READY";
                }
                catch
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Destination Status: NOT AVAILABLE";
                }
            }else
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Destination Status: KANBAN PATH NOT SPECIFIED";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgvWorkOrders.Rows)
            {
                DataGridViewCheckBoxCell chk = dgvr.Cells[dgvWorkOrders.Columns.IndexOf(colCheck)] as DataGridViewCheckBoxCell;

                if (chk.Value == chk.TrueValue)
                {
                    string wo = dgvr.Cells["colWorkOrder"].Value.ToString();
                    string wo_directory = Form1.SAVED_DIRECTORY + wo + "\\";
                    
                    WO order = WO.WorkOrderFromFile(wo_directory + wo);

                    if (!order.TransferToArchive())
                    {
                        MessageBox.Show("Archiving unsuccessful for WO " + wo);
                    }
                    order.uploaded = true;
                    order.ExportToFile();
                }
            }

            MessageBox.Show("Archiving finished.");

            LoadSavedWorkOrders();

        }
    }
}
