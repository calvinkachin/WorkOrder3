using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Xceed.Document.NET;
using Xceed.Words.NET;


namespace WorkOrder3
{
    public partial class AddReportForm : Form
    {
        WorkOrder3.Form1 myform = Application.OpenForms.OfType<WorkOrder3.Form1>().First();

        List<GroupBox> groupbox_list = new List<GroupBox>();
        //VideoCapture capture;
        //Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;

        // Declare required methods
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {
            /*
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {

                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                    pictureBox1.Image = image;
                }
            }*/
        }

        public AddReportForm()
        {
            InitializeComponent();
            
            groupbox_list.Add(grpInfo);
            groupbox_list.Add(grpShockValues);
            groupbox_list.Add(grpFailureEvent);
            groupbox_list.Add(grpPicture);
            groupbox_list.Add(grpFinish);

            ArrangeBoxes();
            
        }

        private void ArrangeBoxes()
        {
            int y = 8;
            foreach(GroupBox G in groupbox_list)
            {
                if (G.Visible)
                {
                    G.Top = y;
                    y = y+ G.Height + 8;
                }
            }
        }

        public void ClearReporting()
        {
            txtSerial.Clear();
            cmbRFU.SelectedIndex = -1;
            txtComplaint.Clear();
            txtTechReport.Clear();
            cmbFailureEvent.SelectedIndex = -1;
            txtPatient.Clear();
            cmbModel.SelectedIndex = -1;
            txtPicturePath.Clear();
            txtPatient.Visible = false;
        }

        private void cmbWorkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWorkType.Text == "Other...")
            {
                grpOtherWorkType.Visible = true;
            }
            else
            {
                grpOtherWorkType.Visible = false;
            }

            if (cmbWorkType.Text == "Defib Evaluation")
            {
                grpFailureEvent.Visible = true;
            }
            else
            {
                grpFailureEvent.Visible = false;
            }

            if (cmbWorkType.Text == "PM")
            {
                chkFailedPM.Visible = true;
                txtComplaint.Text = "PM Requested.";
                grpShockValues.Visible = true;
            }
            else
            {
                chkFailedPM.Visible = false;
                grpShockValues.Visible = false;

                if(txtComplaint.Text=="PM Requested.")
                {
                    txtComplaint.Text = "";
                }
            }

            ArrangeBoxes();
        }

        private bool CheckIfReportFilled()
        {
            if (cmbWorkType.Text == "")
            {
                MessageBox.Show("Please select a Work Type.");
                return false;
            }
            else if (cmbWorkType.Text == "Other..." && txtOtherWorkType.Text == "")
            {
                MessageBox.Show("Please enter a Work Type in the 'Other Work Type' field.");
                return false;
            }
            else if (txtSerial.Text == "")
            {
                MessageBox.Show("Please enter a serial number.");
                return false;
            }
            else if (cmbRFU.Text == "")
            {
                MessageBox.Show("Please select an RFU status.");
                return false;
            }
            else if (txtComplaint.Text == "")
            {
                MessageBox.Show("Please enter a complaint.");
                return false;
            }
            else if (txtTechReport.Text == "")
            {
                MessageBox.Show("Please enter a report (what you did on this unit).");
                return false;
            }
            else if (cmbWorkType.Text == "Defib Evaluation" && cmbFailureEvent.Text == "")
            {
                MessageBox.Show("Please select a failure event for this unit.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtSerial_Leave(object sender, EventArgs e)
        {
            if (txtSerial.Text.Length > 2)
            {
                if (txtSerial.Text[0] == 'T' || txtSerial.Text.Substring(0, 2) == "AB")
                {
                    cmbRFU.Text = "None";
                }
                else
                {
                    cmbRFU.Select();
                }
            }


            foreach (Unit U in myform.units_list)
            {
                if (txtSerial.Text == U.serial)
                {
                    cmbModel.Text = U.model;
                    return;
                }
            }
            
        }

        public void SetPatientInfo(string input)
        {
            txtPatient.Visible = true;
            txtPatient.Text = input;
        }

        private void btnAddToReport_Click(object sender, EventArgs e)
        {
            if (CheckIfReportFilled())
            {
                if (cmbWorkType.Text == "Defib Evaluation" && cmbFailureEvent.Text== "During patient treatment" && txtPatient.Text == "")
                {
                    AdditionalQA AQ = new AdditionalQA();
                    AQ.Show();
                }
                else
                {

                    if (cmbWorkType.Text == "PM" && chkFailedPM.Checked)
                    {
                        txtTechReport.Text = "[FAILED PM] " + txtTechReport.Text;

                        
                    }
                    
                    string worktype = cmbWorkType.Text;

                    if (cmbWorkType.Text == "Other...")
                    {
                        worktype = txtOtherWorkType.Text;
                    }

                    string failuremode = "N/A";
                    if (cmbWorkType.Text == "Defib Evaluation")
                    {
                        failuremode = cmbFailureEvent.Text;
                    }

                    string additional_qa = "N/A";
                    if (txtPatient.Text != "" && cmbWorkType.Text == "Defib Evaluation" && cmbFailureEvent.Text.Contains("patient"))
                    {
                        additional_qa = txtPatient.Text;
                    }

                    string tested_functions = "";
                    StringBuilder sb = new StringBuilder();
                    StringBuilder sb_additonal = new StringBuilder();
                    string shock_values = "";
                    string additional_testing = "";

                    if (cmbWorkType.Text == "PM")
                    {
                        if (dgvShockValues.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow dgvr in dgvShockValues.Rows)
                            {
                                sb.Append(dgvr.Cells[0].Value.ToString() + ":" + dgvr.Cells[1].Value.ToString() + "`");
                            }
                            sb = sb.Remove(sb.Length - 1, 1);
                            shock_values = sb.ToString();
                        }

                        StringBuilder func_sb = new StringBuilder();
                        foreach (DataGridViewRow dgvr in dgvTestedFunctions.Rows)
                        {
                            DataGridViewCheckBoxCell C = dgvr.Cells[1] as DataGridViewCheckBoxCell;

                            if (C.Value == colTested.TrueValue)
                            {
                                func_sb.Append(dgvr.Cells[0].Value.ToString()+",");   
                            }
                        }
                        if (func_sb.Length > 1)
                        {
                            func_sb = func_sb.Remove(func_sb.Length - 1, 1);
                            tested_functions = func_sb.ToString();
                        }
                        else
                        {
                            tested_functions = "N/A";
                        }

                        if (dgvAdditionalTesting.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow dgvr in dgvAdditionalTesting.Rows)
                            {
                                if (dgvr.Cells[1].Value != null)
                                {
                                    sb_additonal.Append(dgvr.Cells[0].Value.ToString() + ":" + dgvr.Cells[1].Value.ToString() + "`");
                                }
                            }
                            if (sb_additonal.Length > 1)
                            {
                                sb_additonal = sb_additonal.Remove(sb_additonal.Length - 1, 1);
                            }
                            additional_testing = sb_additonal.ToString();
                        }

                        //Create the PM sheet
                        #region Create the PM Sheet
                        if (chkFailedPM.Checked == false)
                        {
                            try
                            {
                                DocX doc = DocX.Load(Directory.GetCurrentDirectory() + "\\" + Form1.TEMPLATES_DIRECTORY + cmbModel.Text + "_maintenance_template.docx");

                                doc.ReplaceText("#SERIAL#", txtSerial.Text);
                                doc.ReplaceText("#USERNAME#", Environment.UserName);
                                doc.ReplaceText("#NAME#", myform.tech_name);
                                doc.ReplaceText("#DATE#", DateTime.Now.ToString());

                                //Replace placeholders with shock values
                                foreach (DataGridViewRow dgvr in dgvShockValues.Rows)
                                {
                                    if (dgvr.Cells[1].Value != null)
                                    {
                                        doc.ReplaceText("#" + dgvr.Cells[0].Value.ToString().ToUpper() + "#", dgvr.Cells[1].Value.ToString());
                                    }
                                }

                                //Replace placeholders with tested functions
                                foreach (DataGridViewRow dgvr in dgvTestedFunctions.Rows)
                                {
                                    DataGridViewCheckBoxCell c = dgvr.Cells[1] as DataGridViewCheckBoxCell;

                                    if (c.Value == colTested.TrueValue)
                                    {
                                        doc.ReplaceText("#" + dgvr.Cells[0].Value.ToString().ToUpper() + "_PASS#", "X");
                                        doc.ReplaceText("#" + dgvr.Cells[0].Value.ToString().ToUpper() + "_N/A#", "");
                                    }
                                    else
                                    {
                                        doc.ReplaceText("#" + dgvr.Cells[0].Value.ToString().ToUpper() + "_PASS#", "");
                                        doc.ReplaceText("#" + dgvr.Cells[0].Value.ToString().ToUpper() + "_N/A#", "X");
                                    }
                                }

                                //Add a table for additional testing, if there are any
                                if (dgvAdditionalTesting.Rows.Count > 0)
                                {
                                    Xceed.Document.NET.Table T = doc.AddTable(dgvAdditionalTesting.Rows.Count + 1, 2);

                                    T.Rows[0].Cells[0].Paragraphs.First().Append("     Test Value     ");
                                    T.Rows[0].Cells[1].Paragraphs.First().Append("     Measured Value     ");
                                    T.Rows[0].Cells[0].Shading = Color.Gray;
                                    T.Rows[0].Cells[1].Shading = Color.Gray;

                                    //Adding info to the table
                                    for (int i = 0; i < dgvAdditionalTesting.Rows.Count; i++)
                                    {
                                        if (dgvAdditionalTesting.Rows[i].Cells[1].Value != null)
                                        {
                                            if (dgvAdditionalTesting.Rows[i].Cells[1].Value.ToString() != "")
                                            {
                                                T.Rows[i + 1].Cells[0].Paragraphs.First().Append(dgvAdditionalTesting.Rows[i].Cells[0].Value.ToString());
                                                T.Rows[i + 1].Cells[1].Paragraphs.First().Append(dgvAdditionalTesting.Rows[i].Cells[1].Value.ToString());
                                            }
                                        }

                                    }

                                    T.AutoFit = AutoFit.Contents;
                                    doc.InsertTable(T);
                                }

                                if (!Directory.Exists(Directory.GetCurrentDirectory() + "//" + Form1.SAVED_DIRECTORY + myform.WO_string + "//"))
                                {
                                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "//" + Form1.SAVED_DIRECTORY + myform.WO_string + "//");
                                }

                                doc.SaveAs(Directory.GetCurrentDirectory() + "//" + Form1.SAVED_DIRECTORY + myform.WO_string + "//Maintenance - " + txtSerial.Text + ".docx");
                                #endregion
                            }
                            catch
                            {
                                MessageBox.Show("Could not find the template for " + cmbModel.Text);
                                return;
                            }
                        }
                    }
                    else
                    {
                        shock_values = "N/A";
                        tested_functions = "N/A";
                        additional_testing = "N/A";
                    }
                    
                    string photo_path = "N/A";
                    if (txtPicturePath.Text.Trim() != "" && File.Exists(txtPicturePath.Text))
                    {
                        photo_path = txtPicturePath.Text;
                        var val = photo_path.Split('.');
                        string ext = val[val.Length - 1];

                        string folder_directory = Form1.SAVED_DIRECTORY + myform.WO_string;
                        
                        File.Copy(photo_path, folder_directory + "\\" + txtSerial.Text+"."+ext);
                    }

                    myform.AddToReport(txtSerial.Text,cmbModel.Text, shock_values, tested_functions, additional_testing, worktype,  txtComplaint.Text, txtTechReport.Text, cmbRFU.Text, failuremode, photo_path, additional_qa.Replace(Environment.NewLine, "`"));
                    ClearReporting();

                    cmbWorkType.Select();
                    
                    chkFailedPM.Checked = false;
                }
            }
        }

        private void AddReportForm_Load(object sender, EventArgs e)
        {
            txtSerial.AutoCompleteCustomSource.Clear();

            foreach (Unit U in myform.units_list)
            {
                txtSerial.AutoCompleteCustomSource.Add(U.serial);
            }

            cmbWorkType.SelectedIndex = 0;
            grpInfo.Select();
        }

        private void txtSerial_Leave_1(object sender, EventArgs e)
        {
            cmbModel.Text = Unit.ModelFromSerial(txtSerial.Text);
            txtComplaint.Select();
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbModel.Text== "Other...")
            {
                grpOtherModel.Visible = true;
            }
            else
            {
                grpOtherModel.Visible = false;
            }

            PopulateShockValues();
        }

        private void PopulateShockValues()
        {
            dgvShockValues.Rows.Clear();
            dgvTestedFunctions.Rows.Clear();
            dgvAdditionalTesting.Rows.Clear();

            #region Populate all the Shock Values
            if (cmbModel.Text.ToUpper().Contains("AED"))
            {
                dgvShockValues.Rows.Add(new string[] { "Pedi Shock Levels", "" });
                dgvShockValues.Rows.Add(new string[] { "50", "" });
                dgvShockValues.Rows.Add(new string[] { "70", "" });
                dgvShockValues.Rows.Add(new string[] { "85", "" });
                dgvShockValues.Rows.Add(new string[] { "Adult Shock Levels", "" });
                dgvShockValues.Rows.Add(new string[] { "120", "" });
                dgvShockValues.Rows.Add(new string[] { "150", "" });
                dgvShockValues.Rows.Add(new string[] { "200", "" });

                dgvShockValues.Rows[0].DefaultCellStyle.BackColor = Color.Gray;
                dgvShockValues.Rows[4].DefaultCellStyle.BackColor = Color.Gray;
            }
            else if (cmbModel.Text.ToUpper() == "OTHER")
            {
                dgvShockValues.Rows.Clear();
            }
            else
            {
                dgvShockValues.Rows.Add(new string[] { "Shock Levels", "" });
                dgvShockValues.Rows.Add(new string[] { "5", "" });
                dgvShockValues.Rows.Add(new string[] { "50", "" });
                dgvShockValues.Rows.Add(new string[] { "100", "" });
                dgvShockValues.Rows.Add(new string[] { "200", "" });
                dgvShockValues.Rows.Add(new string[] { "Pacing Amps", "" });
                dgvShockValues.Rows.Add(new string[] { "Min", "" });
                dgvShockValues.Rows.Add(new string[] { "40", "" });
                dgvShockValues.Rows.Add(new string[] { "80", "" });
                dgvShockValues.Rows.Add(new string[] { "120", "" });
                dgvShockValues.Rows.Add(new string[] { "Max", "" });

                dgvShockValues.Rows[0].DefaultCellStyle.BackColor = Color.Gray;
                dgvShockValues.Rows[5].DefaultCellStyle.BackColor = Color.Gray;
            }
            #endregion

            //Enters in all functions of each unit
            if (cmbModel.Text.ToUpper().Contains("X-SERIES"))
            {
                dgvTestedFunctions.Rows.Add(new string[] { "SpO2" });
                dgvTestedFunctions.Rows.Add(new string[] { "SpCO" });
                dgvTestedFunctions.Rows.Add(new string[] { "SpMet" });
                dgvTestedFunctions.Rows.Add(new string[] { "ETCO2" });
                dgvTestedFunctions.Rows.Add(new string[] { "Pacing" });

                dgvTestedFunctions.Rows.Add(new string[] { "IBP" });
                dgvTestedFunctions.Rows.Add(new string[] { "Temperature" });

                dgvTestedFunctions.Rows.Add(new string[] { "Wifi" });
                dgvTestedFunctions.Rows.Add(new string[] { "Audio Recording" });
            }
            else if (cmbModel.Text.ToUpper().Contains("E-SERIES"))
            {
                dgvTestedFunctions.Rows.Add(new string[] { "SpO2" });
                dgvTestedFunctions.Rows.Add(new string[] { "ETCO2" });
                dgvTestedFunctions.Rows.Add(new string[] { "NIBP" });
                dgvTestedFunctions.Rows.Add(new string[] { "Pacing" });
                dgvTestedFunctions.Rows.Add(new string[] { "Bluetooth" });
                dgvTestedFunctions.Rows.Add(new string[] { "Audio Recording" });
            }
            else if (cmbModel.Text.ToUpper().Contains("AED-3"))
            {
                dgvTestedFunctions.Rows.Add(new string[] { "Wifi" });
                dgvTestedFunctions.Rows.Add(new string[] { "Audio Recording" });
            }
            else if (cmbModel.Text.ToUpper().Contains("AED-PRO"))
            {
                dgvTestedFunctions.Rows.Add(new string[] { "Audio Recording" });
            }
            else if (cmbModel.Text.ToUpper().Contains("M-SERIES"))
            {
                dgvTestedFunctions.Rows.Add(new string[] { "SpO2" });
                dgvTestedFunctions.Rows.Add(new string[] { "ETCO2" });
                dgvTestedFunctions.Rows.Add(new string[] { "NIBP" });
                dgvTestedFunctions.Rows.Add(new string[] { "Pacing" });
                dgvTestedFunctions.Rows.Add(new string[] { "IBP" });
                dgvTestedFunctions.Rows.Add(new string[] { "Temperature" });
            }
            else if (cmbModel.Text.ToUpper().Contains("PROPAQ"))
            {
                dgvTestedFunctions.Rows.Add(new string[] { "SpO2" });
                dgvTestedFunctions.Rows.Add(new string[] { "SpCO" });
                dgvTestedFunctions.Rows.Add(new string[] { "ETCO2" });
                dgvTestedFunctions.Rows.Add(new string[] { "Pacing" });

                dgvTestedFunctions.Rows.Add(new string[] { "IBP" });
                dgvTestedFunctions.Rows.Add(new string[] { "Temperature" });

                dgvTestedFunctions.Rows.Add(new string[] { "Wifi" });
                dgvTestedFunctions.Rows.Add(new string[] { "Audio Recording" });
            }
            else if (cmbModel.Text.ToUpper().Contains("R-SERIES"))
            {
                dgvTestedFunctions.Rows.Add(new string[] { "SpO2" });
                dgvTestedFunctions.Rows.Add(new string[] { "ETCO2" });
                dgvTestedFunctions.Rows.Add(new string[] { "Pacing" });
                dgvTestedFunctions.Rows.Add(new string[] { "NIBP" });
                dgvTestedFunctions.Rows.Add(new string[] { "BAROMETRIC" });
            }

            //Add lines for additional testing
            try
            {
                var r = new StreamReader(Form1.TEMPLATES_DIRECTORY + cmbModel.Text + "_additional_testing.txt");
                while (!r.EndOfStream)
                {
                    dgvAdditionalTesting.Rows.Add(r.ReadLine());
                }
                r.Close();
            }
            catch
            {
                //do nothing
            }
        }

        private void btnBrowsePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    txtPicturePath.Text = ofd.FileName;
                }
                else
                {
                    MessageBox.Show("Could not access this file.");
                    return;
                }
                
            }
        }

        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            /*
            if (btnTakePicture.Text.Equals("Start Camera"))
            {
                CaptureCamera();
                btnCapture.Enabled = true;
                btnTakePicture.Text = "Stop Camera";
                isCameraRunning = true;
                grpPicture.Height = 592;
            }
            else
            {
                capture.Release();
                btnCapture.Enabled = false; 
                btnTakePicture.Text = "Start Camera";
                isCameraRunning = false;
                grpPicture.Height = 94;
            }

            ArrangeBoxes();
            */
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            /*
            if (isCameraRunning)
            {
                // Take snapshot of the current image generate by OpenCV in the Picture Box

                string path = Directory.GetCurrentDirectory() +"\\"+ Form1.SAVED_DIRECTORY + myform.WO_string + "\\" + txtSerial.Text + ".jpg";

                pictureBox1.Image.Save(path);

                txtPicturePath.Text = path;
            }
            else
            {
                Console.WriteLine("Cannot take picture if the camera isn't capturing image!");
            }
            */
        }

        private void AddReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            if (capture != null)
            {
                capture.Release();
                isCameraRunning = false;
            }
            */
            myform.SaveWorkOrder();
        }
    }
}
