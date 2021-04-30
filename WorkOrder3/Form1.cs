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
        public string tech_name = "";
        string username = "";
        List<Customer> customer_list = new List<Customer>();
        public List<Unit> units_list = new List<Unit>();
        public List<ReportEntry> report_list = new List<ReportEntry>();

        public static Color SHADE_COLOUR = Color.LightGray;

        public static string WO_NUMBER_FILENAME = "WO";
        public static string USER_FILENAME = "user";
        public static string CUSTOMERS_FILENAME = "customers";
        public static string ARCHIVE_DIRECTORY = "Archive\\";
        public static string TEMPLATES_DIRECTORY = "Templates\\";
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
                this.WO_string= this.username.ToUpper().Substring(0, 6) + this.WO.ToString("0000#");
                lblWorkOrderNumber.Text = "WO# " + this.WO_string;
            }
            else
            {
                
                this.WO_string = this.username.ToUpper() + this.WO.ToString("0000#");
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
                        txtStreetAddress.Text = C.street_address;
                        txtCity.Text = C.city;
                        txtProvince.Text = C.province;
                        txtCountry.Text = C.country;
                        txtZipCode.Text = C.zip_code;
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
        

        public void AddToReport(ReportEntry RE)
        {
            this.report_list.Add(RE);

            string[] line = { RE.serial, RE.model, RE.work_type.ToString(), RE.complaint, RE.tech_report, RE.repair_cost.ToString("0.00"), RE.rfu_indicator.ToString(), RE.shock_values, RE.tested_functions, RE.additional_testing, RE.failure_mode, RE.additional_information, RE.photo_path, "Edit","Remove" };
            
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
                //return;
            }

            #region Customer copy
            DocX doc = DocX.Load(Form1.TEMPLATES_DIRECTORY+"template.docx");

            doc.ReplaceText("#WO#", this.WO_string);
            doc.ReplaceText("#DATE#", dtpCheckIn.Value.ToString("yyyy/MM/dd"));
            doc.ReplaceText("#CUSTOMER#", txtCustomerSite.Text);
            doc.ReplaceText("#TIME_IN#", dtpCheckIn.Value.ToString("hh:mm"));
            doc.ReplaceText("#TIME_OUT#", dtpCheckOut.Value.ToString("hh:mm"));
            doc.ReplaceText("#PO#", txtPO.Text);
            doc.ReplaceText("#STREET_ADDRESS#", txtStreetAddress.Text);
            doc.ReplaceText("#CITY#", txtCity.Text);
            doc.ReplaceText("#PROVINCE#", txtProvince.Text);
            doc.ReplaceText("#STATE#", txtProvince.Text);
            doc.ReplaceText("#COUNTRY#", txtCountry.Text);
            doc.ReplaceText("#ZIP_CODE#", txtZipCode.Text);

            if (chkWarranty.Checked)
            {
                doc.ReplaceText("#WARRANTY#", "Covered under warranty");
            }
            else
            {
                doc.ReplaceText("#WARRANTY#", "");
            }

            doc.ReplaceText("#TECH_NAME#", this.tech_name);

            doc.ReplaceText("#CONTACT_NAME#", txtContactName.Text);
            doc.ReplaceText("#CONTACT_PHONE#", txtContactPhone.Text);
            doc.ReplaceText("#CONTACT_EMAIL#", txtContactEmail.Text);

            doc.ReplaceText("#LABOR_COST#", "$"+txtLabourCost.Text);
            doc.ReplaceText("#LABOR_HOURS#", txtLabourHours.Text);
            doc.ReplaceText("#LABOUR_COST#", "$" + txtLabourCost.Text);
            doc.ReplaceText("#LABOUR_HOURS#", txtLabourHours.Text);

            doc.ReplaceText("#TRAVEL_COST#", "$" + txtTravelCost.Text);
            doc.ReplaceText("#TRAVEL_HOURS#", txtTravelHours.Text);

            doc.ReplaceText("#REPAIR_COST#", "$" + txtRepairCost.Text);
            doc.ReplaceText("#MISC_COSTS#", "$" + txtMiscCost.Text);

            doc.ReplaceText("#TOTAL_COSTS#", "$" + lblTotalCost.Text);

            Xceed.Document.NET.Table T = doc.AddTable(dgvReport.Rows.Count+1, 3);

            T.Rows[0].Cells[0].Paragraphs.First().Append("     Serial Number     ");
            T.Rows[0].Cells[1].Paragraphs.First().Append("     Complaint Report     ");
            T.Rows[0].Cells[2].Paragraphs.First().Append("     Technician Report     ");
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
                p.AppendLine("Signed by ZOLL Technician: ");
                
                p.Append(this.tech_name);
                p.AppendLine();
                p.AppendPicture(Image);
                
            }

            if (chkSignature.Checked)
            {
                picSignature.Image.Save("Signature.png");
                
                var logo = doc.AddImage("Signature.png");
                Picture Image = logo.CreatePicture(100, 250);
                Paragraph p = doc.InsertParagraph("");
                p.AppendLine("Customer Signature: ");
                p.Append(txtContactName.Text);
                p.AppendLine();
                p.AppendPicture(Image);
            }

            doc.SaveAs(Form1.SAVED_DIRECTORY+"\\"+this.WO_string+"\\!WO -"+this.WO_string+" - "+txtCustomerSite.Text+".docx");
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

            doc.SaveAs(Form1.SAVED_DIRECTORY + "\\" + this.WO_string + "\\!WO - " + this.WO_string + " - OFFICE - " + txtCustomerSite.Text + ".docx");
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
                    pm_letter.ReplaceText("#address#", txtStreetAddress.Text);
                    pm_letter.ReplaceText("#phone#", txtContactPhone.Text);
                    pm_letter.ReplaceText("#email#", txtContactEmail.Text);
                    pm_letter.ReplaceText("#serial#", dgvr.Cells["colSerialNumber"].Value.ToString());
                    pm_letter.ReplaceText("#model#", dgvr.Cells["colModel"].Value.ToString());
                    pm_letter.ReplaceText("#techname#", this.tech_name);
                    pm_letter.ReplaceText("#nextdate#", dtpCheckIn.Value.AddYears(1).ToString("dd/MMM/yyyy"));

                    pm_letter.SaveAs(Form1.SAVED_DIRECTORY + "\\" + this.WO_string + "\\"+this.WO_string + " - " + dgvr.Cells["colSerialNumber"].Value.ToString() + " - PM Letter.docx");
                    pm_letter.Dispose();
                }
            }
            #endregion

            MessageBox.Show("Work Order generated!");

            try
            {
                File.Delete("Signature.png");
                File.Delete("TechSignature.png");
            }
            catch
            {

            }

            SaveWorkOrder();

            try
            {
                Process.Start(Directory.GetCurrentDirectory() + "\\Saved\\" + WO_string + "\\");
            }
            catch
            {

            }
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

        public void SaveWorkOrder()
        {
            WO W = new WorkOrder3.WO(this.WO_string);
            W.customer_site = txtCustomerSite.Text;
            W.address = txtStreetAddress.Text;
            W.city = txtCity.Text;
            W.province = txtProvince.Text;
            W.country = txtCountry.Text;
            W.zip_code = txtZipCode.Text;

            W.PO = txtPO.Text;
            W.contact_name = txtContactName.Text;
            W.contact_phone = txtContactPhone.Text;
            W.contact_email = txtContactEmail.Text;
            W.check_in_time = dtpCheckIn.Value;
            W.check_out_time = dtpCheckOut.Value;

            W.labour_cost = txtLabourCost.Text;
            W.labour_hours = txtLabourHours.Text;
            W.travel_cost = txtTravelCost.Text;
            W.travel_hours = txtTravelHours.Text;
            W.repair_cost = txtRepairCost.Text;
            W.misc_cost = txtMiscCost.Text;

            W.total_cost = lblTotalCost.Text;

            foreach (ReportEntry RE in this.report_list) 
            {
                W.report_data.Add(RE);
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
            ofd.InitialDirectory = Directory.GetCurrentDirectory()+"\\"+Form1.SAVED_DIRECTORY;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WO W = WorkOrder3.WO.WorkOrderFromFile(ofd.FileName);
                
                lblWorkOrderNumber.Text = "WO# " + W.work_order_string;
                this.WO_string = W.work_order_string;

                txtCustomerSite.Text = W.customer_site;
                txtStreetAddress.Text = W.address;
                txtCity.Text = W.city;
                txtProvince.Text = W.province;
                txtCountry.Text = W.country;
                txtZipCode.Text = W.zip_code;

                txtPO.Text = W.PO;
                txtContactName.Text = W.contact_name;
                txtContactPhone.Text = W.contact_phone;
                txtContactEmail.Text = W.contact_email;

                dtpCheckIn.Value = W.check_in_time;
                dtpCheckOut.Value = W.check_out_time;

                txtLabourCost.Text = W.labour_cost;
                txtLabourHours.Text = W.labour_hours;
                txtTravelCost.Text = W.travel_cost;
                txtTravelHours.Text = W.travel_hours;
                txtRepairCost.Text = W.repair_cost;
                txtMiscCost.Text = W.misc_cost;

                dtpCheckIn.Enabled = false;
                dtpCheckOut.Enabled = false;

                dgvReport.Rows.Clear();

                foreach(ReportEntry RE in W.report_data)
                {
                    AddToReport(RE);
                }

                chkAutoUpdateCheckOut.Checked = false;
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

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCheckOut.Value > dtpCheckIn.Value)
            {
                txtLabourHours.Text = (dtpCheckOut.Value - dtpCheckIn.Value).TotalHours.ToString("0.0");
            }
        }

        private void CalculateTotalCost()
        {
            double labour_hours = 0;
            double labour_cost = 0;
            double travel_hours = 0;
            double travel_cost = 0;
            double repair_cost = 0;
            double misc_cost = 0;

            double total_cost = 0;

            bool valid = true;

            if (!Double.TryParse(txtLabourHours.Text, out labour_hours))
            {
                valid = false;
            }

            if (!Double.TryParse(txtLabourCost.Text, out labour_cost))
            {
                valid = false;
            }

            if (!Double.TryParse(txtTravelHours.Text, out travel_hours))
            {
                valid = false;
            }

            if (!Double.TryParse(txtTravelCost.Text, out travel_cost))
            {
                valid = false;
            }

            if (!Double.TryParse(txtRepairCost.Text, out repair_cost))
            {
                valid = false;
            }

            if (!Double.TryParse(txtMiscCost.Text, out misc_cost))
            {
                valid = false;
            }

            if (valid)
            {
                if (chkWarranty.Checked == false)
                {
                    total_cost = labour_cost * labour_hours + travel_hours * travel_cost + repair_cost + misc_cost;

                    lblTotalCost.Text = total_cost.ToString("0.00");
                }
                else
                {
                    lblTotalCost.Text = "0.00";
                }
            }
            else
            {
                lblTotalCost.Text = "ERROR";
            }

        }

        private void txtLabourHours_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtLabourCost_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtTravelHours_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtTravelCost_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtRepairCost_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtMiscCost_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }


        private void chkAutoUpdateCheckOut_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoUpdateCheckOut.Checked)
            {
                dtpCheckOut.Value = DateTime.Now;
                dtpCheckOut.Enabled = false;
                tmrCheckOut.Start();
            }
            else
            {
                tmrCheckOut.Stop();
                dtpCheckOut.Enabled = true;
            }
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chkWarranty_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotalCost();
        }
    }
}
