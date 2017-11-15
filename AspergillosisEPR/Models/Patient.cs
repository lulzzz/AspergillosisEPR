﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace AspergillosisEPR.Models
{
    public class Patient
    {

        public int ID { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MMM-yyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "RM2 Number")]
        [StringLength(50)]
        [Remote("hasRMNumber", "Patients", AdditionalFields = "Id",
                ErrorMessage = "Patient RM2 Number already exists in database")]
        public string RM2Number { get; set; }      
        

        public ICollection<PatientDiagnosis> PatientDiagnoses { get; set; }
        public ICollection<PatientDrug> PatientDrugs { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }
        public static readonly List<string> Genders = new List<string>() { "male", "female" };

    }
}