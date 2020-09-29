using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Modules
    {
        public Modules()
        {
            InverseParent = new HashSet<Modules>();
            Rolemodule = new HashSet<Rolemodule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int? SortNo { get; set; }
        public short? IsPublish { get; set; }
        public string ClassName { get; set; }
        public short? IsHeader { get; set; }
        public int? ModuleLevel { get; set; }
        public int ApplicationId { get; set; }
        public int? ParentId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Applications Application { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Modules Parent { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Modules> InverseParent { get; set; }
        public virtual ICollection<Rolemodule> Rolemodule { get; set; }
    }
}
