using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class TujuanKunjungan
    {
        public TujuanKunjungan()
        {
            Groupguesses = new HashSet<Groupguesses>();
            Memberguesses = new HashSet<Memberguesses>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string TujuanKunjungan1 { get; set; }
        public bool Member { get; set; }
        public bool NonMember { get; set; }
        public bool Rombongan { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Groupguesses> Groupguesses { get; set; }
        public virtual ICollection<Memberguesses> Memberguesses { get; set; }
    }
}
