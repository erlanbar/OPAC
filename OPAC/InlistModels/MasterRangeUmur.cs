using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class MasterRangeUmur
    {
        public int Id { get; set; }
        public int Umur1 { get; set; }
        public int Umur2 { get; set; }
        public string Keterangan { get; set; }
        public int? NoUrut { get; set; }
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
