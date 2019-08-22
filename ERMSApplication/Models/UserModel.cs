using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERMSApplication.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "First Name is Required.")]
        [Display(Name = "First Name: ")]
        public string Firstname { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is Required.")]
        [Display(Name = "Last Name: ")]
        public string Lastname { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Address is Required.")]
        [Display(Name = "Email Address: ")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is Required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm Password is Required.")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password and Confirm Password should match")]
        [Display(Name = "Confirm Password: ")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Date of Creation: ")]
        public DateTime CreatedOn { get; set; }
        public string SuccessMessage { get; set; }
    }
}