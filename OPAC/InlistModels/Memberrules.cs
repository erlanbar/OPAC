using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Memberrules
    {
        public int Id { get; set; }
        public string NameCategory { get; set; }
        public string Contents { get; set; }
        public short? IsPublish { get; set; }
        public int? SortNum { get; set; }
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
