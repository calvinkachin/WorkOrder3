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
    public partial class RepairPartsForm : Form
    {
        private int line_number = 0;

        //private List<RepairPart> repair_parts_list = new List<RepairPart>();

        public RepairPartsForm(string input_problem,string input_resolutions, int input_line_number)
        {
            InitializeComponent();

            this.line_number = input_line_number;
            lblProblemOf.Text = "For the problem of " + input_problem.ToUpper() + " the following parts were replaced:";

            if (input_resolutions != "")
            {
                var resolutions = input_resolutions.Split('|');

                foreach(string s in resolutions)
                {
                    string[] line = StringArrayFromResolution(s);
                    dgvSolution.Rows.Add(line);
                }
            }

            /*
            try
            {
                var r=new StreamReader("INVENTORY.txt");
                while (!r.EndOfStream)
                {
                    string line = r.ReadLine();
                    RepairPart RP = RepairPart.RepairPartFromString(line);

                    repair_parts_list.Add(RP);
                }
                r.Close();
            }
            catch
            {
                //do nothing
            }*/
        }

        private void RepairPartsForm_Load(object sender, EventArgs e)
        {

        }

        private string[] StringArrayFromResolution(string input)
        {
            string part_name = "";
            string part_num = "";
            string old_sn = "";
            string old_rev = "";
            string new_sn = "";
            string new_rev = "";

            part_name = input.Substring(0, input.IndexOf("(PN:"));

            StringBuilder sb = new StringBuilder();

            int i = input.IndexOf("(PN: ") + 5;
            while (!(input[i] == ',' || input[i]==')'))
            {
                sb.Append(input[i]);
                i++;
            }
            part_num = sb.ToString();

            if (input.Contains("Old SN:"))
            {
                sb.Clear();
                i = input.IndexOf("Old SN: ") + 8;
                while (!(input[i] == ',' || input[i] == ')'))
                {
                    sb.Append(input[i]);
                    i++;
                }
                old_sn = sb.ToString();
            }

            if (input.Contains("Old Rev:"))
            {
                sb.Clear();
                i = input.IndexOf("Old Rev: ") + 9;
                while (!(input[i] == ',' || input[i] == ')'))
                {
                    sb.Append(input[i]);
                    i++;
                }
                old_rev = sb.ToString();
            }

            if (input.Contains("New SN:"))
            {
                sb.Clear();
                i = input.IndexOf("New SN: ") + 8;
                while (!(input[i] == ',' || input[i] == ')'))
                {
                    sb.Append(input[i]);
                    i++;
                }
                new_sn = sb.ToString();
            }

            if (input.Contains("New Rev:"))
            {
                sb.Clear();
                i = input.IndexOf("New Rev: ") + 9;
                while (!(input[i] == ',' || input[i] == ')'))
                {
                    sb.Append(input[i]);
                    i++;
                }
                new_rev = sb.ToString();
            }

            string[] line = new string[] { part_num, part_name, old_sn, old_rev, new_sn, new_rev, "Remove" };
            return line;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvPartsSearch.Rows.Clear();
                txtSearch.Text = txtSearch.Text.Trim();

                List<string> search_terms = txtSearch.Text.Split(' ').ToList();

                var r = new StreamReader("INVENTORY.txt");
                while (!r.EndOfStream)
                {
                    bool found = true;
                    string line = r.ReadLine();

                    foreach (string term in search_terms)
                    {
                        if (!line.ToUpper().Contains(term.ToUpper()))
                        {
                            found = false;
                            break;
                        }
                    }

                    if (found)
                    {
                        var values = line.Split('|');

                        if (!values[2].ToUpper().Contains("OBSOLETE"))
                        {
                            dgvPartsSearch.Rows.Add(new string[] { values[0], values[2], values[1], "Use Part" });

                            if (lblStep1.BackColor != Color.WhiteSmoke)
                            {
                                lblStep1.BackColor = Color.WhiteSmoke;
                            }
                        }
                    }
                }
                r.Close();
            }
        }

        private void dgvPartsSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPartsSearch.Columns.IndexOf(colUse))
            {
                string part_num = dgvPartsSearch.Rows[e.RowIndex].Cells[dgvPartsSearch.Columns.IndexOf(colSearchPartNum)].Value.ToString();
                string part_name = dgvPartsSearch.Rows[e.RowIndex].Cells[dgvPartsSearch.Columns.IndexOf(colSearchPartName)].Value.ToString();

                string[] line = new string[] { part_num, part_name, "", "", "", "", "Remove" };
                dgvSolution.Rows.Add(line);
            }
        }

        private void dgvSolution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSolution.Columns.IndexOf(colRemove))
            {
                dgvSolution.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (DataGridViewRow dgvr in dgvSolution.Rows)
            {
                if (dgvr.Cells[0].Value != null) 
                {
                    string part_num = dgvr.Cells[dgvSolution.Columns.IndexOf(colPartNum)].Value.ToString().Trim();
                    string part_name = dgvr.Cells[dgvSolution.Columns.IndexOf(colPartName)].Value.ToString().Trim();
                    string old_sn = dgvr.Cells[dgvSolution.Columns.IndexOf(colOldSN)].Value.ToString().Trim();
                    string old_rev = dgvr.Cells[dgvSolution.Columns.IndexOf(colOldRev)].Value.ToString().Trim();
                    string new_sn = dgvr.Cells[dgvSolution.Columns.IndexOf(colNewSN)].Value.ToString().Trim();
                    string new_rev = dgvr.Cells[dgvSolution.Columns.IndexOf(colNewRev)].Value.ToString().Trim();

                    sb.Append(part_name);
                    sb.Append(" (PN: ");
                    sb.Append(part_num);
                    sb.Append(",");

                    if (old_sn != "")
                    {
                        sb.Append(" Old SN: ");
                        sb.Append(old_sn);
                        sb.Append(",");
                    }

                    if (old_rev != "")
                    {
                        sb.Append(" Old Rev: ");
                        sb.Append(old_rev);
                        sb.Append(",");
                    }

                    if (new_sn != "")
                    {
                        sb.Append(" New SN: ");
                        sb.Append(new_sn);
                        sb.Append(",");
                    }

                    if (new_rev != "")
                    {
                        sb.Append(" New Rev: ");
                        sb.Append(new_rev);
                        sb.Append(",");
                    }

                    sb.Remove(sb.Length - 1, 1);

                    sb.Append(")");

                    sb.Append("|");
                }

            }

            sb.Remove(sb.Length - 1, 1);

            WorkOrder3.AddReportForm ARF = Application.OpenForms.OfType<WorkOrder3.AddReportForm>().First();

            ARF.AddResolution(this.line_number, sb.ToString());
            this.Close();
        }
    }
}
