using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Mailserver
    {
        public int Id { get; set; }
        public string Modul { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string CredentialMail { get; set; }
        public string CredentialPassword { get; set; }
        public short? EnableSsl { get; set; }
        public string MailFrom { get; set; }
        public string MailDisplayName { get; set; }
        public short? IsActive { get; set; }
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
