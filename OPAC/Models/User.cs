using System;
using System.ComponentModel;
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
        [DisplayName("Username")]
        public string NIP { get; set; }
        [Required]
        [DisplayName("Nama Lengkap")]
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
        [DisplayName("No. Telp Aktif")]
        public string Phone { get; set; }
        [Required]
        [DisplayName("No. KTP / NIK")]
        public string NIK { get; set; }
        [Required]
        public string Pekerjaan { get; set; }
        [Required]
        public string Alamat { get; set; }
        [Required]
        [DisplayName("Pendidikan Terakhir")]
        public string PendidikanTerakhir { get; set; }
        #nullable enable
        public string? SocmedToken { get; set; }
        #nullable disable
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