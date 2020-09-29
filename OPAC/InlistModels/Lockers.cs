using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Lockers
    {
        public int Id { get; set; }
        public string NoPinjaman { get; set; }
        public string NoMember { get; set; }
        public string NoIdentitas { get; set; }
        public string JenisJaminan { get; set; }
        public int? IdJaminIdt { get; set; }
        public int? IdJaminUang { get; set; }
        public int? LokerId { get; set; }
        public DateTime? TanggalPinjam { get; set; }
        public DateTime? TanggalKembali { get; set; }
        public int? IdPelanggaranLocker { get; set; }
        public int? Denda { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual MasterJenisIdentitas IdJaminIdtNavigation { get; set; }
        public virtual MasterUangJaminan IdJaminUangNavigation { get; set; }
        public virtual MasterPelanggaranLocker IdPelanggaranLockerNavigation { get; set; }
        public virtual MasterLoker Loker { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
