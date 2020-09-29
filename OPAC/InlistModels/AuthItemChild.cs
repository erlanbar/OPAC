using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class AuthItemChild
    {
        public string Parent { get; set; }
        public string Child { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual AuthItem ChildNavigation { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual AuthItem ParentNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
