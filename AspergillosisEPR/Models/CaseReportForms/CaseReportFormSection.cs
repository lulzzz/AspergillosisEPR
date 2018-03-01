﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspergillosisEPR.Models.CaseReportForms
{
    public class CaseReportFormSection
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IEnumerable<CaseReportFormField> CaseReportFormResultFields { get; set; }

    }
}