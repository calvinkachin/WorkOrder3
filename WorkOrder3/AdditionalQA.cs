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
            string additional = "Patient Age: " + txtAge.Text + " \nGender: " + cmbGender.Text + " \nTreatment: " + txtTreatment.Text + " \nEvent Date: " + datePicker.Value.ToString("dd - MM - yyyy") + " \nAction taken: " + cmbActionTaken.Text + " \nAdverse Effects: " + cmbAdverse.Text + " \nDuring: " + cmbDuring.Text + " \nSettings used: " + txtSettings.Text + " \nCould therapy still be delivered?: " + cmbTherapy.Text + " \n\nMalfunction Status: " + cmbMalStatus.Text + " \nMalfunction Duplicated?: " + cmbMalDupe.Text + " \nError Messages?: " + cmbError.Text + " \nError Messages Found: " + txtErrorMessages.Text + " \nReport Available?: " + cmbReportAvail.Text + " \nPrint-Outs Available?: " + cmbStripsAvail.Text + " \nData File Available?: " + cmbDataAvail.Text + " \nAdditional Info: " + txtAdditional.Text;

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
