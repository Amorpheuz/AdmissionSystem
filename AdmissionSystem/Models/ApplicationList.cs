﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AdmissionSystem.Models
{
    public class ApplicationList
    {
        public int ApplicationListID { get; set; }

        [Display(Name = "Application Category")]
        [Required(ErrorMessage = "Please Specify a category to apply from")]
        public string ApplicationCategory { get; set; }

        [Required]
        public string Status { get; set; }
        public string PrioAreaOfResearch { get; set; }

        public Student Student { get; set; }
        public AcademicYear AcademicYear { get; set; }

    }
}
