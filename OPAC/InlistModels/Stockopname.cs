using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Stockopname
    {
        public Stockopname()
        {
            Stockopnamedetail = new HashSet<Stockopnamedetail>();
        }

        public int Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime? TglMulai { get; set; }
        public int Tahun { get; set; }
        public string Koordinator { get; set; }
        public string Keterangan { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Stockopnamedetail> Stockopnamedetail { get; set; }
    }
}
