using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace OPAC.ViewModels
{
    public class ForgotPasswordViewModel
    {

        [Required]
        [DataType(DataType.Text)]
        public string NIP { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
    }
}