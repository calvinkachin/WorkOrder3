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

            Hey Calvin, you have to find all the columns that have the uploadable status.

            if (File.Exists(UPLOAD_PATH))
            {
                var r = new StreamReader(UPLOAD_PATH);
                txtUploadPath.Text = r.ReadLine();
                r.Close();
            }

            foreach (string dir in Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\Saved\\"))
            {
                var values = dir.Split('\\');
                string wo_string = values[values.Length - 1];

                WO workorder = WO.WorkOrderFromFile(dir + "\\" + wo_string);

                string[] line = new string[] { wo_string, workorder.report_data.Count.ToString(), workorder.report_data.Count.ToString() };

                dgvWorkOrders.Rows.Add(line);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dgvr in dgvWorkOrders.Rows)
            {
                DataGridViewCheckBoxCell chk = dgvr.Cells[dgvWorkOrders.Columns.IndexOf(colCheck)] as DataGridViewCheckBoxCell;

                if (chk.Value == chk.TrueValue)
                {
                    MessageBox.Show(dgvr.Cells[0].Value.ToString());
                }
            }
        }
    }
}
