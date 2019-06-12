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
    public partial class Form1 : Form
    {
        int WO = 0;
        string tech_name = "";
        string username = "";
        List<Customer> customer_list = new List<Customer>();

        public static string WO_NUMBER_FILENAME = "WO";
        public static string USER_FILENAME = "user";
        public static string CUSTOMERS_FILENAME = "customers";
        public static string ARCHIVE_DIRECTORY = "Archive\\";
        public static string TEMPLATES_DIRECTORY = "Templates\\";
        public static string DOCUMENTS_DIRECTORY = "Documents\\";

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(USER_FILENAME))
            {
                TechNameWindow TNW = new TechNameWindow();
                TNW.Show();

                this.WindowState = FormWindowState.Minimized;

                return;
            }
            else
            {
                LoadUserAndWorkOrder();
                LoadCustomersList();
            }
        }

        public void InitializeFiles()
        {
            List<string> var_list = this.GetType().GetFields().Select(field => field.Name + "|" + field.GetValue(this).ToString()).ToList();

            //For all the directories pointed at, make them if they don't already exist
            foreach (string S in var_list)
            {
                var values = S.Split('|');

                if (values[0].Contains("DIRECTORY"))
                {
                    if (!Directory.Exists(values[1]))
                    {
                        Directory.CreateDirectory(values[1]);
                    }
                }
                else if (values[0].Contains("FILENAME"))
                {
                    if (!File.Exists(values[1]))
                    {
                        var writer = new StreamWriter(values[1]);

                        if(values[0]== "WO_NUMBER_FILENAME")
                        {
                            writer.WriteLine("1");
                        }

                        writer.Close();
                    }
                }
            }
        }

        public void LoadUserAndWorkOrder()
        {
            var reader = new StreamReader(USER_FILENAME);
            this.tech_name = reader.ReadLine();
            this.username = reader.ReadLine();
            reader.Close();

            var woreader = new StreamReader(WO_NUMBER_FILENAME);
            this.WO = Int32.Parse(woreader.ReadLine());
            woreader.Close();

            if (this.username.Length > 5)
            {
                lblWorkOrderNumber.Text = "WO# " + this.username.ToUpper().Substring(0, 6) + this.WO;
            }
            else
            {
                lblWorkOrderNumber.Text = "WO# " + this.username.ToUpper() + this.WO;
            }
        }

        public void LoadCustomersList()
        {
            this.customer_list.Clear();

            try
            {
                var reader = new StreamReader(CUSTOMERS_FILENAME);
                while (!reader.EndOfStream)
                {
                    customer_list.Add(Customer.CustomerFromLine(reader.ReadLine()));
                }
                reader.Close();
            }
            catch
            {
                MessageBox.Show("The customer list could not be loaded.");
                return;
            }
        }

        private void changeTechNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechNameWindow TNW = new TechNameWindow();
            TNW.Show();
        }

        private void presetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Preset CP = new Customer_Preset();
            CP.Show();
        }
    }
}
