using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrder3
{
    class Unit
    {
        public string serial = "";
        public string part_number = "";
        public string location = "";
        public string SW = "";
        public DateTime last_pm_date = new DateTime();
        public DateTime last_config_date = new DateTime();

        public Unit(string input_serial) 
        {
            this.serial = input_serial;
        }
        
        public string ExportToLine()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.serial);
            sb.Append("|");
            sb.Append(this.part_number);
            sb.Append("|");
            sb.Append(this.location);
            sb.Append("|");
            sb.Append(this.SW);
            sb.Append("|");
            sb.Append(this.last_pm_date.ToString("dd/MMM/yyyy"));
            sb.Append("|");
            sb.Append(this.last_config_date.ToString("dd/MMM/yyyy"));
            
            return sb.ToString();
        }

        public static Unit UnitFromLine(string line)
        {
            var values = line.Split('|');

            Unit U = new Unit(values[0]);

            try
            {
                U.part_number = values[1];
                U.location = values[2];
                U.SW = values[3];
                U.last_pm_date = DateTime.Parse(values[4]);
                U.last_config_date = DateTime.Parse(values[5]);
            }
            catch
            {
                //do nothing
            }

            return U;
        }

    }
}
