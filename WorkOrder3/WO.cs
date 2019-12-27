using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkOrder3
{
    class WO
    {
        public string work_order_string = "";
        public string customer_site = "";
        public string address = "";
        public string PO = "";
        public string contact_name="";
        public string contact_phone = "";
        public string contact_email = "";
        public List<string> report_data = new List<string>();
        public bool uploaded = false;


        public DateTime check_in_time = new DateTime();
        public DateTime check_out_time = new DateTime();

        public WO(string input_work_order_string)
        {
            this.work_order_string = input_work_order_string;
        }

        public void ExportToFile()
        {
            var writer = new StreamWriter(Form1.SAVED_DIRECTORY + this.work_order_string);
            writer.WriteLine("WO|"+this.work_order_string);
            writer.WriteLine("CUSTOMER_SITE|"+this.customer_site);
            writer.WriteLine("ADDRESS|"+this.address);
            writer.WriteLine("PO|"+this.PO);
            writer.WriteLine("CONTACT_NAME|"+this.contact_name);
            writer.WriteLine("CONTACT_PHONE|"+this.contact_phone);
            writer.WriteLine("CONTACT_EMAIL"+this.contact_email);
            writer.WriteLine("CHECK_IN_TIME|"+this.check_in_time.ToString("yyyy/MM/dd HH:mm"));
            writer.WriteLine("CHECK_OUT_TIME|"+this.check_out_time.ToString("yyyy/MM/dd HH:mm"));
            writer.WriteLine("UPLOADED|" + this.uploaded);

            foreach(string S in this.report_data)
            {
                writer.WriteLine("REPORT|" + S.Replace(Environment.NewLine,"`"));
            }
            writer.Close();
        }

        public static WO WorkOrderFromFile(string filename)
        {
            
            var reader = new StreamReader(filename);
            WO W = new WO(reader.ReadLine());
            
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                List<string> values = line.Split('|').ToList();
                
                if (values[0] == "REPORT")
                {
                    values.RemoveAt(0);
                    W.report_data.Add(String.Join("|", values));
                }
                else if (values[0] == "UPLOADED")
                {
                    W.uploaded = Boolean.Parse(values[1]);
                }
                else if (values[0] == "CUSTOMER_SITE")
                {
                    W.customer_site = values[1];
                }
                else if (values[0] == "ADDRESS")
                {
                    W.address = values[1];
                }
                else if (values[0] == "PO")
                {
                    W.PO = values[1];
                }
                else if (values[0] == "CONTACT_NAME")
                {
                    W.contact_name = values[1];
                }
                else if (values[0]== "CONTACT_PHONE")
                {
                    W.contact_phone = values[1];
                }
                else if (values[0] == "CONTACT_EMAIL")
                {
                    W.contact_email = values[1];
                }
                else if (values[0] == "CHECK_IN_TIME")
                {
                    W.check_in_time = DateTime.Parse(values[1]);
                }
                else if (values[0] == "CHECK_OUT_TIME")
                {
                    W.check_out_time = DateTime.Parse(values[1]);
                }
                
            }

            reader.Close();

            return W;
        }
    }
}
