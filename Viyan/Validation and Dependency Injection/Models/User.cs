using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Task_1.Models{
    public class User{
        [Required]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Username should minimum of 3 characters and maximum of 50 characters" )]
        public string? Username{get;set;}
        [Required(ErrorMessage ="Please enter password")]
        [RegularExpression(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$",ErrorMessage = "Your Password is not valid.")]
        public string? Password{get;set;}
        [Required]  
        [Compare("Password",ErrorMessage ="Confirm Password should match Password")]
        [ScaffoldColumn(false)]
        public string? Confirmpassword{get;set;}
        [Required]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [CustomDOJ(ErrorMessage ="DOJ must not be Future date")]
        public DateTime DOJ{get;set;}
        public string? Role{get;set;}
        [Required]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Username should minimum of 3 characters and maximum of 50 characters" )]
        public string? Name{get;set;}
        [Required]
        [Range(18,60,ErrorMessage ="Age must between 18 and 60")]
        public int age{get;set;}
        [Required]
        public string? Designation{get;set;}
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? EmailID{get;set;}
        [Required]
        [DataType(DataType.PhoneNumber)]
        public double Phoneno{get;set;}
        
    }
    public class CustomDOJAttribute:ValidationAttribute{
    public override bool IsValid(object value){

        DateTime dateTime = Convert.ToDateTime(value);
        return dateTime <= DateTime.Now;
    }
   }
}