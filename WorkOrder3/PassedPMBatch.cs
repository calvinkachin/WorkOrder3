﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrder3
{
    public class PassedPMBatch
    {
        public string model = "";
        public List<ReportEntry> report_lines = new List<ReportEntry>();

        public PassedPMBatch(string in_model)
        {
            this.model = in_model;
        }
    }
}
