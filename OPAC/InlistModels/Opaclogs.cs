using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Opaclogs
    {
        public Opaclogs()
        {
            OpaclogsKeyword = new HashSet<OpaclogsKeyword>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string Ip { get; set; }
        public string JenisPencarian { get; set; }
        public string Keyword { get; set; }
        public string JenisBahan { get; set; }
        public DateTime? Waktu { get; set; }
        public string Url { get; set; }
        public bool IsLkd { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public string TargetPembaca { get; set; }
        public string Bahasa { get; set; }
        public string BentukKarya { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<OpaclogsKeyword> OpaclogsKeyword { get; set; }
    }
}
