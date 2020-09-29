using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class MasterJurusan
    {
        public MasterJurusan()
        {
            MasterProgramStudi = new HashSet<MasterProgramStudi>();
            Members = new HashSet<Members>();
        }

        public int Id { get; set; }
        public int? IdFakultas { get; set; }
        public string Nama { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual MasterFakultas IdFakultasNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<MasterProgramStudi> MasterProgramStudi { get; set; }
        public virtual ICollection<Members> Members { get; set; }
    }
}
