using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolicyManagement.Models
{
    public class PolicyAdmin
    {
     


        [Required(ErrorMessage = "Please enter your First Name")]
        //[MaxLength(50)]
        //[MinLength(4)]
        //[Display(Name = "First Name")]
      // [RegularExpression(@"(^[a-zA-Z]$)", ErrorMessage = "Invalid Format")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        //[RegularExpression(@"(^[a-zA-Z]$)", ErrorMessage = "Invalid Format")]
        public string LastName { get; set; }


        //[DataType(DataType.DateTime)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please enter your Date of Birth")]
        [Display(Name ="Date Of Birth")]
        public DateTime DateOfBirth { get; set; }


        [Required(ErrorMessage = "Please choose your Gender")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Please mention your Contact Number")]
        //[RegularExpression(@"(^[987]{1}[0-9]{9}$)")]
        //[Display(Name = "Contact Number")]
        //[DataType(DataType.PhoneNumber)]
        public long ContactNumber { get; set; }


        [Required(ErrorMessage = "Please enter email id in the format : (numbers/character/alphabet)@[a-z].[a-z]")]
        //[RegularExpression(@"(^[a-z0-9\S]{3,}@[a-z]{1,}.[a-z]{2,}$)")]
        //[Display(Name = "Email Id")]
        public string EmailId { get; set; }
        [Key]
        [Display(Name = "User ID")]
       public string UserId { get; set; }


        [Required(ErrorMessage = "Please enter password")]
        //[DataType(DataType.Password)]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Invalid Password.")]
        public string Password { get; set; }


       





    }
}