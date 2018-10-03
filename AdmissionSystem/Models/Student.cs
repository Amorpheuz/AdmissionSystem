﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmissionSystem.Models
{
    //public enum Gender
    //{
  //      Male, Female, Other
//    }

    //public enum Caste
    //{
      //  General,SC,ST,OBC,Other
    //}
 
    public class Student
    {

        public int StudentID { get; set; }

        [Required(ErrorMessage = "Please Specify Your Name"), StringLength(60)]
        [Display(Name = "Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Please Specify Your Address"), StringLength(500,ErrorMessage ="Such long Address! Please specify a shorter address with less that 300 characters, our database run out of space!")]
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string StudentAddress { get; set; }

        [Required(ErrorMessage = "Please Specify Your City")]
        [Display(Name = "City")]
        [StringLength(25, ErrorMessage = "City should not have more than 25 characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Specify Your Postal Code")]
        [Display(Name = "Postal Code")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Please Specify Your State")]
        [Display(Name = "State")]
        [StringLength(25, ErrorMessage = "State should not have more than 25 characters")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please Specify Your Nationality")]
        [Display(Name = "Nationality")]
        [StringLength(25, ErrorMessage = "Nationality should not have more than 25 characters")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Please Specify Your Gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; } //make combobox

        [Required,StringLength(30,ErrorMessage ="Guardian Name can not be more than 30 characters long")]
        [Display(Name = "Guardian Name")]
        public string StudentGuradianName { get; set; }

        [Required(ErrorMessage = "Please Specify Your Relation with the Guardian")]
        [Display(Name = "What's your relation with guardian you specified")]
        public string RelWithGuardian { get; set; } //make combobox

        [Required(ErrorMessage = "Please Specify Your Blood Group")]
        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; } //make combobox

        [Required(ErrorMessage = "Please Specify Your Date Of Birth")]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Residence Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string ResidencePhone { get; set; }

        [Required(ErrorMessage ="Please specify your date of birth")]
        [Display(Name ="Place Of Birth")]
        [StringLength(25,ErrorMessage ="Place Of Birth should not have more than 25 characters")]
        public string PlaceOfBirth { get; set; }

        [Display(Name ="Guardian's Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Required(ErrorMessage ="Please specify guardian's contact number")]
        public string GuardianMobileNumber { get; set; }

        [Display(Name = "Your Mobile Number(All admission related communication will be done on this Contact Number)")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Required(ErrorMessage = "Please specify your contact number")]
        [DataType(DataType.PhoneNumber)]
        public string ApplicantsMobileNumber { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name ="Family Income")]
        public decimal FamilyIncome { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name ="Upload Your Signature(as per siganture upload guidelines mentioned)")]
        [Required(ErrorMessage = "Please Upload Your Signature")]
        public string StudentSignature { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Upload Your Photo(as per photo upload guidelines mentioned)")]
        [Required(ErrorMessage = "Please Upload Your Photo")]
        public string StudentPhoto { get; set; }

        [Display(Name ="Addhar Number")]
        [RegularExpression(@"^\d{4}\s\d{4}\s\d{4}\s\d{4}$", ErrorMessage ="Not A Valid Aadhar Number")]
        public string AadharNumber { get; set; }
       
        [Display(Name ="Caste")]
        public string Caste { get; set; } //make combobox
 
        [Display(Name ="Occupation of Guardian")]
        [StringLength(20,ErrorMessage ="Just Specify Guardian Occupation, please don't describe it")]
        public string GuradianOccupation { get; set; }

        [Required(ErrorMessage ="PH Status is required")]
        [Display(Name ="PH Status")]
        public string PHStatus { get; set; } //make checkbox


        public ICollection<Documents> Documents { get; set; }
        public ICollection<AcademicRecord> AcademicRecords { get; set; }
        public ICollection<ApplicationList> ApplicationLists { get; set; }
    }
}
