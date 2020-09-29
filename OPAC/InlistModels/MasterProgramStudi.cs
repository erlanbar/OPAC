using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class MasterProgramStudi
    {
        public MasterProgramStudi()
        {
            Members = new HashSet<Members>();
        }

        public int Id { get; set; }
        public int? IdJurusan { get; set; }
        public string Nama { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual MasterJurusan IdJurusanNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Members> Members { get; set; }
    }
}
