using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class SurveyPilihan
    {
        public SurveyPilihan()
        {
            SurveyPilihanSesi = new HashSet<SurveyPilihanSesi>();
        }

        public int Id { get; set; }
        public int? SurveyPertanyaanId { get; set; }
        public string Pilihan { get; set; }
        public int? ChoosenCount { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual SurveyPertanyaan SurveyPertanyaan { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<SurveyPilihanSesi> SurveyPilihanSesi { get; set; }
    }
}
