﻿using AspergillosisEPR.Lib.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspergillosisEPR.Models
{
    public class DiagnosisType : ISearchable
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string ShortName { get; set; }

        public ICollection<PatientDiagnosis> PatientDiagnoses { get; set; }

        public string KlassName => typeof(DiagnosisType).Name;

        public Dictionary<string, string> SearchableFields()
        {
            return new Dictionary<string, string>()
            {
                { "Diagnosis Name", "DiagnosisType.Name" },
                { "Diagnosis Category", "DiagnosisCategory.CategoryName" }
            };
        }
    }
}