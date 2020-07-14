using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPAC.Models
{
    public class User
    {

        public const int SessionKeyUserID = 0;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string NIP { get; set; }
        [Required]
        public string Name { get; set; }
        #nullable enable
        public DateTime? LastLogin { get; set; }
        public string? Photo { get; set; }
        public string? Note { get; set; }
        public string? Keyword { get; set; }
        #nullable disable
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public string Creator { get; set; }
        public DateTime CreatedDate { get; set; }
        #nullable enable
        public string? Modifier { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #nullable disable
    }
}