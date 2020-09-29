using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Worksheetfields
    {
        public int Id { get; set; }
        public int? FieldId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public int? WorksheetId { get; set; }
        public short? IsAkuisisi { get; set; }
        public short? Isdeposit { get; set; }
        public short? IsdetailkoleksiPengolahan { get; set; }
        public short? IsdetailkoleksiAkuisisi { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Fields Field { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual Worksheets Worksheet { get; set; }
    }
}
