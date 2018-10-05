﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AdmissionSystem.Models
{
    public class AcademicRecord
    {
        public int AcademicRecordID { get; set; }

        [Required(ErrorMessage ="Please Specify Exam Name")]
        [Display(Name ="Name Of Exam")]
        [StringLength(50,ErrorMessage ="Exam name should be less than  50 characters")]
        public string ExamName { get; set; }

        [Required(ErrorMessage ="Please specify board or University for the examination")]
        [Display(Name ="Board Or University Name")]
        [StringLength(150,ErrorMessage ="Board or University Name can not be more than 150 characters long")]
        public string BoardOrUni { get; set; }

        [Required(ErrorMessage = "Please specify School or College for the examination")]
        [Display(Name = "School/College Name")]
        [StringLength(150, ErrorMessage = "School or College Name can not be more than 150 characters long")]
        public string SchoolOrCollegeName { get; set; }

        [Display(Name ="Merit Number in the exam")]
        public decimal MeritNumber { get; set; }

        [Required(ErrorMessage ="Please specify when did you pass the exam")]
        [Display(Name ="Month Or Year of Passing the exam")]
        [DataType(DataType.Date)]
        public DateTime MonthYearOfPass { get; set; }

        [Required(ErrorMessage ="Roll number can not be blank")]
        [Display(Name ="Roll Number")]
        [StringLength(60,ErrorMessage ="Roll number can not be longer than 60 characters")]
        public string RollNumber { get; set; }

        [Required(ErrorMessage = "Langauge of instruction can not be blank")]
        [Display(Name = "Language Of Instruction")]
        [StringLength(60, ErrorMessage = "Roll number can not be longer than 60 characters")]
        public string LangOfInstruction { get; set; }

        [Display(Name ="Validity of Score")]
        [DataType(DataType.Date)]
        public DateTime ScoreValidity { get; set; }

        [Display(Name ="Grade/Marks Obtained")]
        [Required(ErrorMessage = "Grade/Marks Obtained is required")]
        public string MarksObtained { get; set; }
        public int StudentID { get; set; }

        public Student Student { get; set; }
    }
}
