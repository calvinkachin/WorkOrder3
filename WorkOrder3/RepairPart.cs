using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrder3
{
    public class RepairPart
    {
        public string Name = "";
        public string Parameters = "";
        public string Part_Number = "";

        public RepairPart()
        {

        }

        public static RepairPart RepairPartFromString(string input_string)
        {
            var values = input_string.Split('|');

            RepairPart RP = new RepairPart();

            try
            {
                RP.Part_Number = values[0];
                RP.Name = values[1];
                RP.Part_Number = values[2];
            }
            catch
            {
                //do nothing
            }

            return RP;
        }
    }
}
