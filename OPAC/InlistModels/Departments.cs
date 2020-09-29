using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Departments
    {
        public Departments()
        {
            InverseParent = new HashSet<Departments>();
            Members = new HashSet<Members>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short? IsActive { get; set; }
        public int? ParentId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Departments Parent { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Departments> InverseParent { get; set; }
        public virtual ICollection<Members> Members { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
