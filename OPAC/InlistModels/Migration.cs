using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Migration
    {
        public string Version { get; set; }
        public int? ApplyTime { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public string UpdateTerminal { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
