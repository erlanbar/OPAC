using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class MemberPerpanjangan
    {
        public double Id { get; set; }
        public double? MemberId { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal? Biaya { get; set; }
        public short? IsLunas { get; set; }
        public string Keterangan { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Members Member { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
