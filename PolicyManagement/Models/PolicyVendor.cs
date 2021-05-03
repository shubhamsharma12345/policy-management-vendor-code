using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PolicyManagement.Models
{
    public class PolicyVendor
    {
        
      

        [Required(ErrorMessage = "Please enter your  Name")]
        [MaxLength(100)]
        [MinLength(4)]
        [Display(Name = " Name")]
        
        public string VendorName { get; set; }


        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please enter your Date of Birth")]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        
        [Required(ErrorMessage = "Please enter Policy Vendor Reg No")]
        [MaxLength(100)]
        [MinLength(4)]
        [Display(Name = "Policy Vendor Reg No")]
        [Key]
        public string PolicyVendorRegNo { get; set; }

        [Required(ErrorMessage = "Please enter Policy Type")]
        //[MaxLength(100)]
        //[MinLength(4)]
        [Display(Name = "Policy Type")]
        public string PolicyType{ get; set; }

        [Display(Name = " Address")]
        public string Address { get; set; }


        [Display(Name = "Country")]
        public string Country { get; set; }


        [Display(Name = "State")]
        public string State { get; set; }

        
        [Display(Name = "Zip")]
        public string Zip{ get; set; }



        [Required(ErrorMessage = "Please enter email id in the format : (numbers/character/alphabet)@[a-z].[a-z]")]
        [RegularExpression(@"(^[a-z0-9\S]{3,}@[a-z]{1,}.[a-z]{2,}$)")]
        [Display(Name = "Email Id")]
        public string EmailId { get; set; }



        [Required(ErrorMessage = "Please mention your Contact Number")]
        //[RegularExpression(@"(^[987]{1}[0-9]{9}$)")]
        [Display(Name = "Contact Number")]
        [DataType(DataType.PhoneNumber)]
        public long ContactNumber { get; set; }

        [Display(Name = "Please Enter Website")]
        public string VendorWebsite { get; set; }


        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please enter Certificate issued Date")]
        [Display(Name = "CertificateIssuedDate")]
        public DateTime CertificateIssuedDate { get; set; }


        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please enter certificate validity date")]
        [Display(Name = "Certtificate Validity date")]
        public DateTime CertificateValidityDate { get; set; }


        [Display(Name = "Year Of Establishment")]
         public int YearofEstablishment { get; set; }

        public Nullable<int> VendorStatus { get; set; }


        [Required(ErrorMessage = "Please enter password")]
        //[DataType(DataType.Password)]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Invalid Password.")]
        public string Password { get; set; }


    }
}