using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class SurveyIsian
    {
        public int Id { get; set; }
        public int? SurveyPertanyaanId { get; set; }
        public string Sesi { get; set; }
        public string MemberNo { get; set; }
        public string Isian { get; set; }

        public virtual SurveyPertanyaan SurveyPertanyaan { get; set; }
    }
}
