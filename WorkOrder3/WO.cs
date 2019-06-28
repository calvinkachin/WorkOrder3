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

        public DateTime check_in_time = new DateTime();
        public DateTime check_out_time = new DateTime();

        public WO(string input_work_order_string)
        {
            this.work_order_string = input_work_order_string;
        }

        public void ExportToFile()
        {
            var writer = new StreamWriter(Form1.SAVED_DIRECTORY + this.work_order_string);
            writer.WriteLine(this.work_order_string);
            writer.WriteLine(this.customer_site);
            writer.WriteLine(this.address);
            writer.WriteLine(this.PO);
            writer.WriteLine(this.contact_name);
            writer.WriteLine(this.contact_phone);
            writer.WriteLine(this.contact_email);
            writer.WriteLine(this.check_in_time.ToString("yyyy/MM/dd HH:mm"));
            writer.WriteLine(this.check_out_time.ToString("yyyy/MM/dd HH:mm"));

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

            W.customer_site = reader.ReadLine();
            W.address = reader.ReadLine();
            W.PO = reader.ReadLine();
            W.contact_name = reader.ReadLine();
            W.contact_phone = reader.ReadLine();
            W.contact_email = reader.ReadLine();

            W.check_in_time = DateTime.Parse(reader.ReadLine());
            W.check_out_time = DateTime.Parse(reader.ReadLine());

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                List<string> values = line.Split('|').ToList();

                if (values[0] == "REPORT")
                {
                    values.RemoveAt(0);
                    W.report_data.Add(String.Join("|", values));
                }
            }

            reader.Close();

            return W;
        }
    }
}
