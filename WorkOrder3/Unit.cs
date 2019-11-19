using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrder3
{
    public class Unit
    {
        public string serial = "";
        public string model = "";
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
            sb.Append(this.model);
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
                U.model = values[1];
                U.part_number = values[2];
                U.location = values[3];
                U.SW = values[4];
                U.last_pm_date = DateTime.Parse(values[5]);
                U.last_config_date = DateTime.Parse(values[6]);

                if (U.model == "")
                {
                    U.model = Unit.ModelFromSerial(U.serial);
                }
            }
            catch
            {
                //do nothing
            }

            return U;
        }

        public static string ModelFromSerial(string serial)
        {
            if (serial.Length > 3)
            {
                if (serial[0] == 'T') { return "M-SERIES"; }
                else if (serial[0] == 'X') { return "AED-PLUS"; }
                else if (serial.Substring(0, 2) == "AB") { return "E-SERIES";}
                else if (serial.Substring(0, 2) == "AR") { return "X-SERIES"; }
                else if (serial.Substring(0, 2) == "AF") { return "R-SERIES"; }
                else if (serial.Substring(0, 2) == "AX") { return "AED-3"; }
                else if (serial.Substring(0, 2) == "AA") { return "AED-PRO"; }
                else if (serial.Substring(0, 2) == "AI") { return "PROPAQ"; }

                else { return ""; }
            }
            else
            {
                return "";
            }
        }

    }
}
