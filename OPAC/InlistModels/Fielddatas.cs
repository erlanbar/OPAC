using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Fielddatas
    {
        public int FieldId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Delimiter { get; set; }
        public int? SortNo { get; set; }
        public short? Repeatable { get; set; }
        public short? IsShow { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Fields Field { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
