using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Applications
    {
        public Applications()
        {
            Modules = new HashSet<Modules>();
            Roles = new HashSet<Roles>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string WhenDownMessageError { get; set; }
        public short? IsPublish { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Modules> Modules { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }
    }
}
