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
        public string address = "";
        public string contact_name = "";
        public string phone = "";
        public string email = "";
        public string units_list_filename = "";

        public Customer()
        {

        }

        public static Customer CustomerFromLine(string line)
        {
            try
            {
                var val = line.Split('|');

                Customer C = new Customer();

                C.preset_name = val[0];
                C.customer_site = val[1];
                C.address = val[2];
                C.contact_name = val[3];
                C.phone = val[4];
                C.email = val[5];
                C.units_list_filename = val[6];

                return C;
            }
            catch
            {
                return null;
            }
        }

        public string ExportToLine()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.preset_name);
            sb.Append("|");
            sb.Append(this.customer_site);
            sb.Append("|");
            sb.Append(this.address);
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
