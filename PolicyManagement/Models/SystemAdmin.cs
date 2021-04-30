using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolicyManagement.Models
{
    public class SystemAdmin
    {
        [Key]
        [Required(ErrorMessage ="*User ID Required")]
        [Display(Name ="User ID")]
        public string UserId { get; set; }


        [Required(ErrorMessage =" *Password Required")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Invalid Password.")]
        public string Password { get; set; }
    }
}