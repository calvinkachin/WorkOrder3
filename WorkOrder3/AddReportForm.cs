using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkOrder3
{
    public partial class AddReportForm : Form
    {
        WorkOrder3.Form1 myform = Application.OpenForms.OfType<WorkOrder3.Form1>().First();

        List<GroupBox> groupbox_list = new List<GroupBox>();

        public AddReportForm()
        {
            InitializeComponent();

            
            groupbox_list.Add(grpInfo);
            groupbox_list.Add(grpShockValues);
            groupbox_list.Add(grpFailureEvent);
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

                        chkFailedPM.Checked = false;
                    }

                    if (cmbWorkType.Text == "PM")
                    {

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
                    string shock_values = "";

                    if (cmbWorkType.Text == "PM")
                    {
                        foreach (DataGridViewRow dgvr in dgvShockValues.Rows)
                        {
                            sb.Append(dgvr.Cells[0].Value.ToString() + ":" + dgvr.Cells[1].Value.ToString() + "`");
                        }
                        sb = sb.Remove(sb.Length - 1, 1);
                        shock_values = sb.ToString();
                    }
                    else
                    {
                        shock_values = "N/A";
                        tested_functions = "N/A";
                    }

                    myform.AddToReport(txtSerial.Text, shock_values, tested_functions, worktype,  txtComplaint.Text, txtTechReport.Text, cmbRFU.Text, failuremode, additional_qa.Replace(Environment.NewLine, "`"));
                    ClearReporting();

                    txtSerial.Focus();
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
        }

        private void txtSerial_Leave_1(object sender, EventArgs e)
        {
            cmbModel.Text = Unit.ModelFromSerial(txtSerial.Text);
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbModel.Text== "Other...")
            {
                grpOtherWorkType.Visible = true;
            }
            else
            {
                grpOtherWorkType.Visible = false;
            }

            PopulateShockValues();
        }

        private void PopulateShockValues()
        {
            dgvShockValues.Rows.Clear();
            dgvTestedFunctions.Rows.Clear();

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

                if (cmbModel.Text.ToUpper().Contains("X-SERIES"))
                {
                    dgvTestedFunctions.Rows.Add(new string[] { "SpO2" });
                }
            }
        }
    }
}
