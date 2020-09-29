using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Rolemodule
    {
        public int RoleId { get; set; }
        public short? IsView { get; set; }
        public short? IsAdd { get; set; }
        public short? IsEdit { get; set; }
        public short? IsDelete { get; set; }
        public short? IsPrint { get; set; }
        public int ModuleId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Modules Module { get; set; }
        public virtual Roles Role { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
