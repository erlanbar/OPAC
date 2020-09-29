using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class MasterPelanggaranLocker
    {
        public MasterPelanggaranLocker()
        {
            Lockers = new HashSet<Lockers>();
        }

        public int Id { get; set; }
        public string JenisPelanggaran { get; set; }
        public decimal? Denda { get; set; }
        public string Deskripsi { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual ICollection<Lockers> Lockers { get; set; }
    }
}
