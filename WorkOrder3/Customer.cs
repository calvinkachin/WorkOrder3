using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrder3
{
    class Customer
    {
        public string preset_name { get; set; } = "";
        public string customer_site = "";
        public string street_address = "";
        public string city = "";
        public string province = "";
        public string country = "";
        public string zip_code = "";
        public string contact_name = "";
        public string phone = "";
        public string email = "";
        public string units_list_filename = "";

        public Customer()
        {

        }

        public static Customer CustomerFromLine(string line)
        {
            Customer C = new Customer();

            try
            {
                var val = line.Split('|');

                C.preset_name = val[0];
                C.customer_site = val[1];
                C.street_address = val[2];
                C.city = val[3];
                C.province = val[4];
                C.country = val[5];
                C.zip_code = val[6];
                C.contact_name = val[7];
                C.phone = val[8];
                C.email = val[9];
                C.units_list_filename = val[10];

            }
            catch
            {

            }

            return C;
        }

        public string ExportToLine()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.preset_name);
            sb.Append("|");
            sb.Append(this.customer_site);
            sb.Append("|");
            sb.Append(this.street_address);
            sb.Append("|");
            sb.Append(this.city);
            sb.Append("|");
            sb.Append(this.province);
            sb.Append("|");
            sb.Append(this.country);
            sb.Append("|");
            sb.Append(this.zip_code);
            sb.Append("|");
            sb.Append(this.contact_name);
            sb.Append("|");
            sb.Append(this.phone);
            sb.Append("|");
            sb.Append(this.email);
            sb.Append("|");
            sb.Append(this.units_list_filename);

            return sb.ToString();
        }
    }
}
