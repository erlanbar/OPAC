using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OPAC.Models;

namespace OPAC.ViewModels
{
    public class RegisterViewModel
    {

        public AccountViewModel account { get; set; }
        public UserRole userRole { get; set; }
    }
}