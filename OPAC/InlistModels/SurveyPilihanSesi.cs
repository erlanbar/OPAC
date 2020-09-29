using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class SurveyPilihanSesi
    {
        public int Id { get; set; }
        public int? SurveyPilihanId { get; set; }
        public string MemberNo { get; set; }
        public string Sesi { get; set; }

        public virtual SurveyPilihan SurveyPilihan { get; set; }
    }
}
