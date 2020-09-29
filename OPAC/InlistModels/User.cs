using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string AuthKey { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordResetToken { get; set; }
        public string Email { get; set; }
        public short Status { get; set; }
        public int CreatedAt { get; set; }
        public int UpdatedAt { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
