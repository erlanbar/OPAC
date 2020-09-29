using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class SurveyPertanyaan
    {
        public SurveyPertanyaan()
        {
            SurveyIsian = new HashSet<SurveyIsian>();
            SurveyPilihan = new HashSet<SurveyPilihan>();
        }

        public int Id { get; set; }
        public int? SurveyId { get; set; }
        public string Pertanyaan { get; set; }
        public string JenisPertanyaan { get; set; }
        public string Orientation { get; set; }
        public short? IsMandatory { get; set; }
        public short? IsCanMultipleAnswer { get; set; }
        public int? NoUrut { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Survey Survey { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<SurveyIsian> SurveyIsian { get; set; }
        public virtual ICollection<SurveyPilihan> SurveyPilihan { get; set; }
    }
}
