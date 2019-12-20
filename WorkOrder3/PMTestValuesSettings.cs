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
    public partial class PMTestValuesSettings : Form
    {
        public PMTestValuesSettings()
        {
            InitializeComponent();
        }

        private void PMTestValuesSettings_Load(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();

            foreach(Form1.MODELS m in Enum.GetValues(typeof(Form1.MODELS)))
            {
                cmbModel.Items.Add(m.ToString());
            }
        }
    }
}
