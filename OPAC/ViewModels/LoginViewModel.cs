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
        public bool IsFromSocmed { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string SocmedToken { get; set; }
        
        public LoginViewModel() {
            IsFromSocmed = false;
        }
    }
}