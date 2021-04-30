using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrder3
{
    public class ReportEntry
    {
        public enum RFU { None,Ready_For_Use,Not_Ready,Unknown};

        public string serial = "";
        public string model = "";
        public string work_type = "";
        public string complaint = "";
        public string tech_report = "";
        public string rfu_indicator = "None";
        public List<RepairPart> repair_parts_list = new List<RepairPart>();
        public double repair_cost = 0;
        public string shock_values = "";
        public string tested_functions = "";
        public string additional_testing = "";
        public string failure_mode = "";
        public string additional_information = "";
        public string photo_path = "";

        public ReportEntry()
        {

        }

        public static ReportEntry ReportEntryFromLine(string line)
        {
            ReportEntry RE = new ReportEntry();

            var values = line.Split('|');

            try
            {
                RE.serial = values[1];
                RE.model = values[2];
                RE.work_type = values[3];
                RE.complaint = values[4];
                RE.tech_report = values[5];
                RE.rfu_indicator = values[6];
                RE.repair_cost = Double.Parse(values[7]);
                RE.shock_values = values[8];
                RE.tested_functions = values[9];
                RE.additional_testing = values[10];
                RE.failure_mode = values[11];
                RE.additional_information = values[12];
                RE.photo_path = values[13];
            }
            catch
            {
                //do nothing
            }

            return RE;
                
        }

        public string ExportToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("REPORT");
            sb.Append("|");
            sb.Append(serial);
            sb.Append("|");
            sb.Append(model);
            sb.Append("|");
            sb.Append(work_type.ToString());
            sb.Append("|");
            sb.Append(complaint);
            sb.Append("|");
            sb.Append(tech_report);
            sb.Append("|");
            sb.Append(rfu_indicator.ToString());
            sb.Append("|");
            sb.Append(repair_cost.ToString("0.00"));
            sb.Append("|");
            sb.Append(shock_values);
            sb.Append("|");
            sb.Append(tested_functions);
            sb.Append("|");
            sb.Append(additional_testing);
            sb.Append("|");
            sb.Append(failure_mode);
            sb.Append("|");
            sb.Append(additional_information);
            sb.Append("|");
            sb.Append(photo_path);
            sb.Append("|");

            return sb.ToString();
        }

    }
}
