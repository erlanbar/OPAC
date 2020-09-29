using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPAC.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int AuthorID { get; set; }
        public string Cover { get; set; }
        #nullable enable
        public string? Note { get; set; }
        #nullable disable
        public bool IsPublished { get; set; }
        [Required]
        public int Flag { get; set; }
        [Required]
        public int PreviewedPages { get; set; }
        [Required]
        public string FileURL { get; set; }
        #nullable enable
        public int? InlistID { get; set; }
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

        public Book () {
            Flag = 1;
            PreviewedPages = 5;
        }
    }
}