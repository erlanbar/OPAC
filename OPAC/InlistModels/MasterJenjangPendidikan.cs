using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class MasterJenjangPendidikan
    {
        public MasterJenjangPendidikan()
        {
            Members = new HashSet<Members>();
        }

        public int Id { get; set; }
        public string JenjangPendidikan { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual ICollection<Members> Members { get; set; }
    }
}
