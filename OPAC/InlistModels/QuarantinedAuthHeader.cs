using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class QuarantinedAuthHeader
    {
        public QuarantinedAuthHeader()
        {
            QuarantinedAuthData = new HashSet<QuarantinedAuthData>();
        }

        public int Id { get; set; }
        public int? WorksheetId { get; set; }
        public string AuthId { get; set; }
        public string MarcLoc { get; set; }
        public string IstilahDigunakan { get; set; }
        public string IstilahTdkDigunakan { get; set; }
        public string IstilahTerkait { get; set; }
        public string Tanggalpembahasan { get; set; }
        public int? Quarantinedby { get; set; }
        public DateTime? Quarantineddate { get; set; }
        public string Quarantinedterminal { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<QuarantinedAuthData> QuarantinedAuthData { get; set; }
    }
}
