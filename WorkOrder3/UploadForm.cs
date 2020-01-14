using System;
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

                    foreach (string data in workorder.report_data)
                    {
                        var report_values = data.Split('|');

                        if (report_values[2].ToUpper() == "PM")
                        {
                            if (report_values[4].ToUpper().Contains("[FAILED PM]"))
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

                    string[] line = new string[] { wo_string, workorder.customer_site, workorder.check_out_time.ToString("dd/MMM/yyyy"), workorder.report_data.Count.ToString(), (passed_pms + failed_pms + others).ToString() };

                    dgvWorkOrders.Rows.Add(line);
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if(txtUploadPath.Text=="" && !Directory.Exists(txtUploadPath.Text))
            {
                MessageBox.Show("Invalid upload path! Please make sure a connection to the upload path exists.");
                return;
            }

            if (cmbDestinationColumn.Text == "")
            {
                MessageBox.Show("Please select a Column ID to upload your work orders to!");
                return;
            }

            string tab = cmbDestinationColumn.Text.Split('.')[0];
            string col = cmbDestinationColumn.Text.Split('.')[1];
            string kb_path = txtUploadPath.Text;
            
            int upload_count = 0;

            foreach(DataGridViewRow dgvr in dgvWorkOrders.Rows)
            {
                DataGridViewCheckBoxCell chk = dgvr.Cells[dgvWorkOrders.Columns.IndexOf(colCheck)] as DataGridViewCheckBoxCell;

                if (chk.Value == chk.TrueValue)
                {
                    upload_count++;
                    string wo = dgvr.Cells["colWorkOrder"].Value.ToString();
                    string wo_directory = Form1.SAVED_DIRECTORY + wo + "\\";
                    
                    List<string> passed_PMs = new List<string>();

                    WO order = WO.WorkOrderFromFile(wo_directory + wo);

                    foreach(string line in order.report_data)
                    {
                        var values = line.Split('|');
                        string folder_directory = kb_path + "\\Folders\\" + wo + "_" + values[0] + "\\";

                        if (values[2].ToUpper() == "PM" && !values[4].ToUpper().Contains("[FAILED PM]"))
                        {
                            passed_PMs.Add(line);
                        }
                        else
                        {
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

                            if (!Directory.Exists(folder_directory))
                            {
                                Directory.CreateDirectory(folder_directory);
                            }

                            try
                            {
                                var writer = new StreamWriter(folder_directory + "!data");
                                writer.WriteLine("SR|" + wo + "_" + values[0]);
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
                                //do nothing for now
                            }

                            try
                            {
                                var repair = new StreamWriter(folder_directory + "!repair");
                                
                                if(values[4].ToUpper().Contains("[FAILED PM]"))
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
                                //do nothing for now
                            }
                        }
                    }
                    //Each of these also need the Kanban folder to be created and files uploaded.
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
        }

        private void CreateKanbanFolderAndFiles(WO workorder)
        {

        }

        private string GetKanbanEntry(string work_order_number, string customer_site, string report_line,string tab_name, string column_name)
        {
            var values = report_line.Split('|');
            DateTime DEFAULT_DATE = new DateTime(2000, 1, 1, 0, 0, 0);
            StringBuilder sb = new StringBuilder();

            sb.Append(work_order_number + "_" + values[0]);
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
            sb.Append("Work Order Upload");
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
    }
}
