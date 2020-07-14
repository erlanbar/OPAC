using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPAC.Models
{
    public class BookActivity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int BookTransID { get; set; }
        [Required]
        public int PageNumber { get; set; }
        #nullable enable
        public int? Flag { get; set; }
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