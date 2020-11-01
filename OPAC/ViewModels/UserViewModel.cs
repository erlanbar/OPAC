using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace OPAC.ViewModels
{
    public class UserViewModel
    {

        public const int SessionKeyUserID = 0;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public IFormFile Photo { get; set; }
        public string PhotoBase64 { get; set; }

    }
}