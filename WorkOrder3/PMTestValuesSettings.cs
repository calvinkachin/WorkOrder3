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
    public partial class PMTestValuesSettings : Form
    {
        public PMTestValuesSettings()
        {
            InitializeComponent();
        }

        private void PMTestValuesSettings_Load(object sender, EventArgs e)
        {

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            var w = new StreamWriter(Form1.TEMPLATES_DIRECTORY + cmbModel.Text + "_additional_testing.txt");
            foreach(DataGridViewRow dgvr in dgvTestedFunctions.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {
                    if (dgvr.Cells[0].Value.ToString() != "")
                    {
                        w.WriteLine(dgvr.Cells[0].Value.ToString().Replace(':',';').Replace('`','\''));
                    }
                }
            }
            w.Close();
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvTestedFunctions.Rows.Clear();

                var r = new StreamReader(Form1.TEMPLATES_DIRECTORY + cmbModel.Text + "_additional_testing.txt");
                while (!r.EndOfStream)
                {
                    dgvTestedFunctions.Rows.Add(r.ReadLine());
                }
                r.Close();
            }
            catch
            {
                dgvTestedFunctions.Rows.Clear();
            }
        }
    }
}
