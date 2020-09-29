using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Roles
    {
        public Roles()
        {
            Rolemodule = new HashSet<Rolemodule>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short? IsActive { get; set; }
        public int ApplicationId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Applications Application { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Rolemodule> Rolemodule { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
