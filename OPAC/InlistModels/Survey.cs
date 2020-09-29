using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Survey
    {
        public Survey()
        {
            SurveyPertanyaan = new HashSet<SurveyPertanyaan>();
        }

        public int Id { get; set; }
        public string NamaSurvey { get; set; }
        public DateTime TanggalMulai { get; set; }
        public DateTime TanggalSelesai { get; set; }
        public short? IsActive { get; set; }
        public int? NomorUrut { get; set; }
        public int? TargetSurvey { get; set; }
        public int? HasilSurveyShow { get; set; }
        public string RedaksiAwal { get; set; }
        public string RedaksiAkhir { get; set; }
        public string Keterangan { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<SurveyPertanyaan> SurveyPertanyaan { get; set; }
    }
}
