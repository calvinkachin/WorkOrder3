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
    public partial class AdditionalQA : Form
    {
        public AdditionalQA()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string additional = "Patient Age: " + txtAge.Text + "`" +
                "Gender: " + cmbGender.Text + "`" + 
                "Treatment: " + txtTreatment.Text + "`" + 
                "Event Date: " + datePicker.Value.ToString("dd - MMM - yyyy") + "`" + 
                "Action taken: " + cmbActionTaken.Text + "`" + 
                "Adverse Effects: " + cmbAdverse.Text + "`" + 
                "During: " + cmbDuring.Text + "`" + 
                "Settings used: " + txtSettings.Text + "`" + 
                "Could therapy still be delivered?: " + cmbTherapy.Text + "`"+"`" + 
                "Malfunction Status: " + cmbMalStatus.Text + "`" + 
                "Malfunction Duplicated?: " + cmbMalDupe.Text + "`" + 
                "Error Messages?: " + cmbError.Text + "`" + 
                "Error Messages Found: " + txtErrorMessages.Text + "`" + 
                "Report Available?: " + cmbReportAvail.Text + "`" + 
                "Print -Outs Available?: " + cmbStripsAvail.Text + "`" + 
                "Data File Available?: " + cmbDataAvail.Text + "`" + 
                "Additional Info: " + txtAdditional.Text;

            Form1 myform = Application.OpenForms.OfType<WorkOrder3.Form1>().First();
            myform.SetPatientInfo(additional);

            this.Close();
            
        }

        private void cmbError_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbError.SelectedIndex > -1)
            {
                if (cmbError.Text == "Yes")
                {
                    lblError.Visible = true;
                    txtErrorMessages.Visible = true;
                }
                else
                {
                    lblError.Visible = false;
                    txtErrorMessages.Visible = false;
                }
            }
            else
            {
                lblError.Visible = false;
                txtErrorMessages.Visible = false;
            }
        }
    }
}
