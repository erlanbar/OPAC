using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using OPAC.Models;

namespace OPAC.ViewModels
{
    public class AccountViewModel
    {
        public User user { get; set; }
        public UserViewModel userViewModel { get; set; }
        public ChangePasswordViewModel changePasswordViewModel { get; set; }
    }
}