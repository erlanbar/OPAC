using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPAC.Models
{
    public class Application
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Description { get; set; }
        #nullable enable
        public string? Note { get; set; }
        public int? Type { get; set; }
        public string? Version { get; set; }
        #nullable disable
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