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
    public partial class TechNameWindow : Form
    {
        Form1 myform = Application.OpenForms.OfType<WorkOrder3.Form1>().First();
        Random R = new Random();

        public TechNameWindow()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Contains(" "))
            {
                try
                {
                    var values = txtName.Text.Split(' ');

                    StringBuilder sb = new StringBuilder();
                    sb.Append(values[0][0]);
                    sb.Append(values[1]);

                    txtUser.Text = sb.ToString().ToUpper();
                    
                }
                catch
                {
                    txtUser.Text = "";
                }
            }
            else
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Length > 5)
            {
                lblWOExample.Text = "WO# " + txtUser.Text.ToUpper().Substring(0, 6) + R.Next(10000).ToString();
            }
            else
            {
                lblWOExample.Text = "WO# " + txtUser.Text.ToUpper() + R.Next(10000).ToString();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a first and last name.");
                return;
            }

            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            var writer = new StreamWriter(Form1.USER_FILENAME);
            writer.WriteLine(txtName.Text);
            writer.WriteLine(txtUser.Text);
            writer.Close();

            myform.InitializeFiles();
            myform.LoadUserAndWorkOrder();
            this.Close();
        }

        private void TechNameWindow_Load(object sender, EventArgs e)
        {

        }

        private void TechNameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            myform.WindowState = FormWindowState.Normal;
        }
    }
}
