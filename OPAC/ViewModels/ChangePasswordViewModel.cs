using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace OPAC.ViewModels
{
    public class ChangePasswordViewModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "{0} must have {2} character", MinimumLength = 8)]
        // [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,}$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Please enter new password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "{0} must have {2} character", MinimumLength = 8)]
        // [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,}$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Please confirm new password")]
        [Compare("NewPassword", ErrorMessage = "Confirm password doesn't match")]
        [DataType(DataType.Password)]
        public string ConfirmNewPassword { get; set; }
        
    }
}