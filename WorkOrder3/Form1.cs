using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace WorkOrder3
{
    public partial class Form1 : Form
    {
        int WO = 0;
        public string WO_string = "0";
        string tech_name = "";
        string username = "";
        List<Customer> customer_list = new List<Customer>();
        public List<Unit> units_list = new List<Unit>();
        
        public static Color SHADE_COLOUR = Color.LightGray;

        public static string WO_NUMBER_FILENAME = "WO";
        public static string USER_FILENAME = "user";
        public static string CUSTOMERS_FILENAME = "customers";
        public static string ARCHIVE_DIRECTORY = "Archive\\";
        public static string TEMPLATES_DIRECTORY = "Templates\\";
        public static string DOCUMENTS_DIRECTORY = "Documents\\";
        public static string SAVED_DIRECTORY = "Saved\\";
        public static string UNITS_DIRECTORY = "Units\\";

        public enum MODELS { AED_3, AED_PLUS, AED_PRO, E_SERIES, M_SERIES, PROPAQ_M, PROPAQ_MD, R_SERIES, VENTILATOR, X_SERIES};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(USER_FILENAME))
            {
                TechNameWindow TNW = new TechNameWindow();
                TNW.Show();

                this.WindowState = FormWindowState.Minimized;

                return;
            }
            else
            {
                InitializeFiles();
                LoadUserAndWorkOrder();
                LoadCustomersList();
                txtCustomerSite.Focus();
            }
        }

        public void InitializeFiles()
        {
            List<string> var_list = this.GetType().GetFields().Select(field => field.Name + "|" + field.GetValue(this).ToString()).ToList();

            //For all the directories pointed at, make them if they don't already exist
            foreach (string S in var_list)
            {
                var values = S.Split('|');

                if (values[0].Contains("DIRECTORY"))
                {
                    if (!Directory.Exists(values[1]))
                    {
                        Directory.CreateDirectory(values[1]);
                    }
                }
                else if (values[0].Contains("FILENAME"))
                {
                    if (!File.Exists(values[1]))
                    {
                        var writer = new StreamWriter(values[1]);

                        if(values[0]== "WO_NUMBER_FILENAME")
                        {
                            writer.WriteLine("1");
                        }

                        writer.Close();
                    }
                }
            }
        }

        public void NewWorkOrder()
        {
            dgvReport.Rows.Clear();
            dtpCheckIn.Enabled = true;
            dtpCheckOut.Enabled = true;
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;
            chkSignature.Checked = false;
            chkTechSignature.Checked = false;
            
            LoadUserAndWorkOrder();
        }
        
        public void LoadUserAndWorkOrder()
        {
            var reader = new StreamReader(USER_FILENAME);
            this.tech_name = reader.ReadLine();
            this.username = reader.ReadLine();
            reader.Close();

            var woreader = new StreamReader(WO_NUMBER_FILENAME);
            this.WO = Int32.Parse(woreader.ReadLine());
            woreader.Close();

            if (this.username.Length > 5)
            {
                this.WO_string= this.username.ToUpper().Substring(0, 6) + this.WO.ToString("00000#");
                lblWorkOrderNumber.Text = "WO# " + this.WO_string;
            }
            else
            {
                
                this.WO_string = this.username.ToUpper() + this.WO.ToString("00000#");
                lblWorkOrderNumber.Text = "WO# " + this.WO_string;
            }

            if (!Directory.Exists(SAVED_DIRECTORY + WO_string))
            {
                Directory.CreateDirectory(SAVED_DIRECTORY + WO_string);

                var w = new StreamWriter(SAVED_DIRECTORY + WO_string + "\\" + WO_string);
                w.WriteLine("WO|" + WO_string);
                w.Close();
            }
        }

        public void LoadCustomersList()
        {
            this.customer_list.Clear();
            cmbPreset.Items.Clear();

            try
            {
                var reader = new StreamReader(CUSTOMERS_FILENAME);
                while (!reader.EndOfStream)
                {
                    customer_list.Add(Customer.CustomerFromLine(reader.ReadLine()));
                }
                reader.Close();

                foreach(Customer C in this.customer_list)
                {
                    cmbPreset.Items.Add(C.preset_name);
                }
            }
            catch
            {
                MessageBox.Show("The customer list could not be loaded.");
                return;
            }
        }

        private void changeTechNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechNameWindow TNW = new TechNameWindow();
            TNW.Show();
        }

        private void presetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Preset CP = new Customer_Preset();
            CP.Show();
        }

        private void cmbPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPreset.SelectedIndex > -1)
            {
                foreach(Customer C in this.customer_list)
                {
                    if (C.preset_name == cmbPreset.Text)
                    {
                        txtCustomerSite.Text = C.customer_site;
                        txtAddress.Text = C.address;
                        txtContactName.Text = C.contact_name;
                        txtContactPhone.Text = C.phone;
                        txtContactEmail.Text = C.email;

                        if (C.units_list_filename != "")
                        {
                            try
                            {
                                var reader = new StreamReader(C.units_list_filename);
                                units_list.Clear();

                                while (!reader.EndOfStream)
                                {
                                    units_list.Add(Unit.UnitFromLine(reader.ReadLine()));
                                }
                                reader.Close();
                            }
                            catch
                            {

                            }
                        }
                        return;
                    }
                }
            }
        }
        

        public void AddToReport(string serial, string model, string shock_values,string tested_functions, string work_type,string complaint,string tech_report,string RFU, string failure_mode, string photo_path, string additional_qa)
        {
            string[] line = { serial, model, work_type, complaint, tech_report, RFU, shock_values, tested_functions, failure_mode, additional_qa, photo_path, "Remove" };

            dgvReport.Rows.Add(line);
        }
        

        private void btnAddToReport_Click(object sender, EventArgs e)
        {
            AddReportForm ARF = new AddReportForm();
            ARF.Show();
            
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (!chkTechSignature.Checked)
            {
                MessageBox.Show("Please include a tech signature!");
                return;
            }

            #region Customer copy
            DocX doc = DocX.Load(Form1.TEMPLATES_DIRECTORY+"template.docx");

            doc.ReplaceText("#wo#", this.WO_string);
            doc.ReplaceText("#date#", dtpCheckIn.Value.ToString("yyyy/MM/dd"));
            doc.ReplaceText("#custid#", txtCustomerSite.Text);
            doc.ReplaceText("#timein#", dtpCheckIn.Value.ToString("hh:mm"));
            doc.ReplaceText("#timeout#", dtpCheckOut.Value.ToString("hh:mm"));
            doc.ReplaceText("#po#", txtPO.Text);
            doc.ReplaceText("#address#", txtAddress.Text);
            doc.ReplaceText("#name#", this.tech_name);
            doc.ReplaceText("#contact#", txtContactName.Text);
            doc.ReplaceText("#phone#", txtContactPhone.Text);
            doc.ReplaceText("#email#", txtContactEmail.Text);
            
            Xceed.Document.NET.Table T = doc.AddTable(dgvReport.Rows.Count+1, 3);

            T.Rows[0].Cells[0].Paragraphs.First().Append("     Serial Number     ");
            T.Rows[0].Cells[1].Paragraphs.First().Append("     Complaint Report     ");
            T.Rows[0].Cells[2].Paragraphs.First().Append("     Field Technician Report     ");
            T.Rows[0].Cells[0].Shading = SHADE_COLOUR;
            T.Rows[0].Cells[1].Shading = SHADE_COLOUR;
            T.Rows[0].Cells[2].Shading = SHADE_COLOUR;

            for (int i = 0; i < dgvReport.Rows.Count; i++)
            {
                T.Rows[i+1].Cells[0].Paragraphs.First().Append(dgvReport.Rows[i].Cells["colSerialNumber"].Value.ToString());
                T.Rows[i+1].Cells[1].Paragraphs.First().Append(dgvReport.Rows[i].Cells["colComplaint"].Value.ToString());
                T.Rows[i+1].Cells[2].Paragraphs.First().Append(dgvReport.Rows[i].Cells["colTechReport"].Value.ToString());
            }
            T.AutoFit = AutoFit.Contents;
            doc.InsertTable(T);

            if (chkTechSignature.Checked)
            {
                picTechSignature.Image.Save("TechSignature.png");
                var logo = doc.AddImage("TechSignature.png");
                Picture Image = logo.CreatePicture(100, 250);
                Paragraph p = doc.InsertParagraph("");
                p.AppendLine("Technician:");
                p.AppendLine();
                p.AppendPicture(Image);
                p.AppendLine();
                p.Append(this.tech_name);
            }

            if (chkSignature.Checked)
            {
                picSignature.Image.Save("Signature.png");
                
                var logo = doc.AddImage("Signature.png");
                Picture Image = logo.CreatePicture(100, 250);
                Paragraph p = doc.InsertParagraph("");
                p.AppendLine("Signed by:");
                p.AppendLine();
                p.AppendPicture(Image);
                p.AppendLine();
                p.Append(txtContactName.Text);
            }

            doc.SaveAs(Form1.SAVED_DIRECTORY+"\\"+this.WO_string+"\\"+this.WO_string+" - "+txtCustomerSite.Text+".docx");
            #endregion

            #region Office Copy - QA information
            doc.InsertSection();

            Table QAT = doc.AddTable(dgvReport.Rows.Count + 1, 4);

            QAT.Rows[0].Cells[0].Paragraphs.First().Append("Serial Number");
            QAT.Rows[0].Cells[1].Paragraphs.First().Append("RFU Status");
            QAT.Rows[0].Cells[2].Paragraphs.First().Append("Event Occurrence");
            QAT.Rows[0].Cells[3].Paragraphs.First().Append("Additional Information for QA                 ");
            QAT.Rows[0].Cells[0].Shading = SHADE_COLOUR;
            QAT.Rows[0].Cells[1].Shading = SHADE_COLOUR;
            QAT.Rows[0].Cells[2].Shading = SHADE_COLOUR;
            QAT.Rows[0].Cells[3].Shading = SHADE_COLOUR;

            for (int i = 0; i < dgvReport.Rows.Count; i++)
            {
                QAT.Rows[i + 1].Cells[0].Paragraphs.First().Append(dgvReport.Rows[i].Cells["colSerialNumber"].Value.ToString());
                QAT.Rows[i + 1].Cells[1].Paragraphs.First().Append(dgvReport.Rows[i].Cells["colRFU"].Value.ToString());
                QAT.Rows[i + 1].Cells[2].Paragraphs.First().Append(dgvReport.Rows[i].Cells["colFailureMode"].Value.ToString());
                QAT.Rows[i + 1].Cells[3].Paragraphs.First().Append(dgvReport.Rows[i].Cells["colQAInformation"].Value.ToString().Replace("`",Environment.NewLine));
            }
            QAT.AutoFit = AutoFit.Contents;
            doc.InsertTable(QAT);

            doc.SaveAs(Form1.SAVED_DIRECTORY + "\\" + this.WO_string + "\\OFFICE - " +this.WO_string + " - " + txtCustomerSite.Text + ".docx");
            doc.Dispose();
            #endregion

            #region PM Letters
            foreach(DataGridViewRow dgvr in dgvReport.Rows)
            {
                if (dgvr.Cells["colWorkType"].Value.ToString() == "PM" && !dgvr.Cells["colTechReport"].Value.ToString().Contains("[FAILED PM]"))
                {
                    DocX pm_letter = DocX.Load(Form1.TEMPLATES_DIRECTORY + "pm_letter_template.docx");

                    pm_letter.ReplaceText("#date#", dtpCheckIn.Value.ToString("dd/MMM/yyyy"));
                    pm_letter.ReplaceText("#contact#", txtContactName.Text);
                    pm_letter.ReplaceText("#customer#", txtCustomerSite.Text);
                    pm_letter.ReplaceText("#address#", txtAddress.Text);
                    pm_letter.ReplaceText("#phone#", txtContactPhone.Text);
                    pm_letter.ReplaceText("#email#", txtContactEmail.Text);
                    pm_letter.ReplaceText("#serial#", dgvr.Cells["colSerialNumber"].Value.ToString());
                    pm_letter.ReplaceText("#techname#", this.tech_name);
                    pm_letter.ReplaceText("#nextdate#", dtpCheckIn.Value.AddYears(1).ToString("dd/MMM/yyyy"));

                    pm_letter.SaveAs(Form1.SAVED_DIRECTORY + "\\" + this.WO_string + "\\"+this.WO_string + " - " + dgvr.Cells["colSerialNumber"].Value.ToString() + " - PM Letter.docx");
                    pm_letter.Dispose();
                }
            }
            #endregion

            MessageBox.Show("Work Order generated!");

            SaveWorkOrder();
        }

        private void cmbFailureEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void chkSignature_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSignature.Checked)
            {
                Process.Start("Signature.exe");
                MessageBox.Show("Press OK after signature is entered.");

                System.Drawing.Image img;
                using (var bmpTemp = new Bitmap("Signature.png"))
                {
                    img = new Bitmap(bmpTemp);
                }

                picSignature.Image = img;
            }
            else
            {
                picSignature.Image = null;
            }
        }

        private void SaveWorkOrder()
        {
            WO W = new WorkOrder3.WO(this.WO_string);
            W.customer_site = txtCustomerSite.Text;
            W.address = txtAddress.Text;
            W.PO = txtPO.Text;
            W.contact_name = txtContactName.Text;
            W.contact_phone = txtContactPhone.Text;
            W.contact_email = txtContactEmail.Text;
            W.check_in_time = dtpCheckIn.Value;
            W.check_out_time = dtpCheckOut.Value;

            foreach (DataGridViewRow dgvr in dgvReport.Rows)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < dgvr.Cells.Count; i++)
                {
                    sb.Append(dgvr.Cells[i].Value.ToString());
                    sb.Append("|");
                }
                W.report_data.Add(sb.ToString());
            }

            var woreader = new StreamReader(WO_NUMBER_FILENAME);
            int num = Int32.Parse(woreader.ReadLine());
            woreader.Close();

            if (num == this.WO)
            {
                var wowriter = new StreamWriter(WO_NUMBER_FILENAME);
                wowriter.WriteLine((num + 1).ToString());
                wowriter.Close();
            }

            W.ExportToFile();
        }

        private void saveWorkOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveWorkOrder();     
        }

        private void loadWorkOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Directory.GetCurrentDirectory()+Form1.SAVED_DIRECTORY;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WO W = WorkOrder3.WO.WorkOrderFromFile(ofd.FileName);
                
                lblWorkOrderNumber.Text = "WO# " + W.work_order_string;
                this.WO_string = W.work_order_string;

                txtCustomerSite.Text = W.customer_site;
                txtAddress.Text = W.address;
                txtPO.Text = W.PO;
                txtContactName.Text = W.contact_name;
                txtContactPhone.Text = W.contact_phone;
                txtContactEmail.Text = W.contact_email;

                dtpCheckIn.Value = W.check_in_time;
                dtpCheckOut.Value = W.check_out_time;

                dtpCheckIn.Enabled = false;
                dtpCheckOut.Enabled = false;
                autoCheckOutTimeToolStripMenuItem.Checked = false;

                dgvReport.Rows.Clear();

                foreach(string S in W.report_data)
                {
                    dgvReport.Rows.Add(S.Split('|'));
                }
            }
        }
        
        private void chkTechSignature_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTechSignature.Checked)
            {
                chkTechSignature.ForeColor = Color.Black;
                
                    Process.Start("Signature.exe");
                    MessageBox.Show("Press OK after signature is entered.");

                    System.Drawing.Image img;
                    using (var bmpTemp = new Bitmap("Signature.png"))
                    {
                        img = new Bitmap(bmpTemp);
                    }

                    picTechSignature.Image = img;
            }
            else
            {
                chkTechSignature.ForeColor = Color.Red;
                picTechSignature.Image = null;
            }
        }

        private void pMTestValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PMTestValuesSettings PTVS = new PMTestValuesSettings();
            PTVS.Show();
        }

        private void autoCheckOutTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autoCheckOutTimeToolStripMenuItem.Checked)
            {
                dtpCheckOut.Value = DateTime.Now;
                tmrCheckOut.Start();
            }
            else
            {
                tmrCheckOut.Stop();
            }
        }

        private void tmrCheckOut_Tick(object sender, EventArgs e)
        {
            dtpCheckOut.Value = DateTime.Now;
            tmrCheckOut.Start();
        }

        private void newWorkOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to SAVE before starting a NEW work order??", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                SaveWorkOrder();
            }

            NewWorkOrder();
        }

        private void defineUploadPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadForm UF = new UploadForm();
            UF.Show();
        }
    }
}
