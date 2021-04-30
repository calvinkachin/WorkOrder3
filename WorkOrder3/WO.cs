using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WorkOrder3
{
    public class WO
    {
        public static DateTime DEFAULT_DATETIME = new DateTime(2000, 1, 1);

        public string work_order_string = "";
        public string customer_site = "";
        public string address = "";
        public string city = "";
        public string province = "";
        public string country = "";
        public string zip_code = "";

        public string PO = "";
        public string contact_name="";
        public string contact_phone = "";
        public string contact_email = "";

        public string labour_hours = "";
        public string labour_cost = "";
        public string travel_hours = "";
        public string travel_cost = "";
        public string repair_cost = "";
        public string misc_cost = "";

        public string total_cost = "";

        public List<ReportEntry> report_data = new List<ReportEntry>();
        public bool uploaded = false;
       
        public DateTime check_in_time = new DateTime();
        public DateTime check_out_time = new DateTime();
        public DateTime upload_time = new DateTime();

        public WO(string input_work_order_string)
        {
            this.work_order_string = input_work_order_string;
        }

        public bool TransferToArchive()
        {
            try
            {
                string source_path = Form1.SAVED_DIRECTORY + this.work_order_string + "\\";
                string dest_path = Form1.ARCHIVE_DIRECTORY + this.work_order_string + "\\";

                Directory.Move(source_path, dest_path);

                return true;
            }
            catch
            {
                return false;
            }

            return false;
        }

        public void ExportToFile()
        {
            string path = Form1.SAVED_DIRECTORY;
            if (this.uploaded)
            {
                path = Form1.ARCHIVE_DIRECTORY;
            }

            if (!Directory.Exists(path + this.work_order_string + "\\"))
            {
                Directory.CreateDirectory(path + this.work_order_string + "\\");
            }
            
            var writer = new StreamWriter(path+this.work_order_string+"\\"+this.work_order_string);
            writer.WriteLine("WO|"+this.work_order_string);
            writer.WriteLine("CUSTOMER_SITE|"+this.customer_site);
            writer.WriteLine("ADDRESS|"+this.address);
            writer.WriteLine("CITY|" + this.city);
            writer.WriteLine("PROVINCE|" + this.province);
            writer.WriteLine("COUNTRY|" + this.country);
            writer.WriteLine("ZIPCODE|" + this.zip_code);
            writer.WriteLine("PO|"+this.PO);
            writer.WriteLine("CONTACT_NAME|"+this.contact_name);
            writer.WriteLine("CONTACT_PHONE|"+this.contact_phone);
            writer.WriteLine("CONTACT_EMAIL|"+this.contact_email);
            writer.WriteLine("CHECK_IN_TIME|"+this.check_in_time.ToString("yyyy/MM/dd HH:mm"));
            writer.WriteLine("CHECK_OUT_TIME|"+this.check_out_time.ToString("yyyy/MM/dd HH:mm"));
            writer.WriteLine("UPLOAD_TIME|" + this.upload_time.ToString("yyyy/MM/dd HH:mm"));
            writer.WriteLine("UPLOADED|" + this.uploaded);
            writer.WriteLine("LABOUR COST|" + this.labour_cost);
            writer.WriteLine("LABOUR HOURS|" + this.labour_hours);
            writer.WriteLine("TRAVEL COST|" + this.travel_cost);
            writer.WriteLine("TRAVEL HOURS|" + this.travel_hours);
            writer.WriteLine("REPAIR COST|" + this.repair_cost);
            writer.WriteLine("MISC COSTS|" + this.misc_cost);
            writer.WriteLine("TOTAL COSTS|" + this.total_cost);

            foreach(ReportEntry RE in this.report_data)
            {
                writer.WriteLine(RE.ExportToString());
            }
            writer.Close();
            
        }

        public static WO WorkOrderFromFile(string filename)
        {
            var reader = new StreamReader(filename);
            WO W = new WO(reader.ReadLine().Split('|')[1]);
            
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                List<string> values = line.Split('|').ToList();
                
                if (values[0] == "REPORT")
                {
                    ReportEntry RE = ReportEntry.ReportEntryFromLine(line);

                    W.report_data.Add(RE);
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
                else if (values[0] == "UPLOAD_TIME")
                {
                    W.upload_time = DateTime.Parse(values[1]);
                }
                else if (values[0] == "CITY")
                {
                    W.city = values[1];
                }
                else if (values[0] == "PROVINCE")
                {
                    W.province = values[1];
                }
                else if (values[0] == "COUNTRY")
                {
                    W.country = values[1];
                }
                else if (values[0] == "ZIPCODE")
                {
                    W.zip_code = values[1];
                }
                else if (values[0] == "LABOUR COST")
                {
                    W.labour_cost = values[1];
                }
                else if (values[0] == "LABOUR HOURS")
                {
                    W.labour_hours = values[1];
                }
                else if (values[0] == "TRAVEL COST")
                {
                    W.travel_cost = values[1];
                }
                else if (values[0] == "TRAVEL HOURS")
                {
                    W.travel_hours = values[1];
                }
                else if (values[0] == "REPAIR COST")
                {
                    W.repair_cost = values[1];
                }
                else if (values[0] == "MISC COSTS")
                {
                    W.misc_cost = values[1];
                }
                else if (values[0] == "TOTAL COSTS")
                {
                    W.total_cost = values[1];
                }
            }

            reader.Close();

            return W;
        }
    }
}
