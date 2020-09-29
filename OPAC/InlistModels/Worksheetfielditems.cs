using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Worksheetfielditems
    {
        public int WorksheetFieldId { get; set; }
        public string Name { get; set; }
        public string RefferenceMode { get; set; }
        public int? StartPosition { get; set; }
        public int? Length { get; set; }
        public string DefaultValue { get; set; }
        public string IdemTag { get; set; }
        public int? IdemStartPosition { get; set; }
        public int? RefferenceId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Refferences Refference { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual Worksheetfields WorksheetField { get; set; }
    }
}
