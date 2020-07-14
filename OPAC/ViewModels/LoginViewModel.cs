using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace OPAC.ViewModels
{
    public class LoginViewModel
    {

        [Required]
        public string NIP { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
    }
}