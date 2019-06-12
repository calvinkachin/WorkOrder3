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
    public partial class Customer_Preset : Form
    {
        Customer current_customer = null;

        public Customer_Preset()
        {
            InitializeComponent();
        }

        private void Customer_Preset_Load(object sender, EventArgs e)
        {
            lstCustomers.Items.Clear();

            var reader = new StreamReader(Form1.CUSTOMERS_FILENAME);
            while (!reader.EndOfStream)
            {
                Customer C = Customer.CustomerFromLine(reader.ReadLine());

                lstCustomers.Items.Add(C);
            }
            reader.Close();

            lstCustomers.DisplayMember = "preset_name";
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex > -1)
            {
                this.current_customer = lstCustomers.SelectedItem as Customer;

                txtPresetName.Text = current_customer.preset_name;
                txtCustomerSite.Text = current_customer.customer_site;
                txtAddress.Text = current_customer.address;
                txtContactName.Text = current_customer.contact_name;
                txtContactPhone.Text = current_customer.phone;
                txtContactEmail.Text = current_customer.email;
                txtUnitList.Text = current_customer.units_list_filename;

                lblSaved.Visible = false;
            }
        }

        private void SaveChanges()
        {
            var writer = new StreamWriter(Form1.CUSTOMERS_FILENAME);
            foreach(Customer C in lstCustomers.Items)
            {
                writer.WriteLine(C.ExportToLine());
            }
            writer.Close();

            lblSaved.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtPresetName.Text == "")
            {
                MessageBox.Show("Please enter a preset name.");
                return;
            }
            else if (txtCustomerSite.Text == "")
            {
                MessageBox.Show("Please enter a customer site.");
                return;
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Please enter an address.");
                return;
            }

            if (current_customer != null)
            {
                current_customer.preset_name = txtPresetName.Text;
                current_customer.customer_site = txtCustomerSite.Text;
                current_customer.address = txtAddress.Text;
                current_customer.contact_name = txtContactName.Text;
                current_customer.phone = txtContactPhone.Text;
                current_customer.email = txtContactEmail.Text;
                current_customer.units_list_filename = txtUnitList.Text;

                SaveChanges();
            }
        }

        private void txtPresetName_TextChanged(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
        }

        private void txtCustomerSite_TextChanged(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
        }

        private void txtContactName_TextChanged(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
        }

        private void txtContactPhone_TextChanged(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
        }

        private void txtContactEmail_TextChanged(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
        }

        private void txtUnitList_TextChanged(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach(TextBox T in this.Controls.OfType<TextBox>())
            {
                T.Clear();
            }

            current_customer = new Customer();
            txtPresetName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (current_customer != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this preset?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lstCustomers.Items.Remove(current_customer);
                    SaveChanges();
                }
            }
        }
    }
}
