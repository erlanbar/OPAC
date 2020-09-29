using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class JenisAnggota
    {
        public JenisAnggota()
        {
            Collectioncategorysdefault = new HashSet<Collectioncategorysdefault>();
            LocationLibraryDefault = new HashSet<LocationLibraryDefault>();
            Members = new HashSet<Members>();
        }

        public int Id { get; set; }
        public string Jenisanggota1 { get; set; }
        public int? MasaBerlakuAnggota { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public decimal? BiayaPendaftaran { get; set; }
        public decimal? BiayaPerpanjangan { get; set; }
        public short? UploadDokumenKeanggotaanOnline { get; set; }
        public int? MaxPinjamKoleksi { get; set; }
        public int? MaxLoanDays { get; set; }
        public string DendaType { get; set; }
        public double? DendaTenorJumlah { get; set; }
        public string DendaTenorSatuan { get; set; }
        public decimal? DendaPerTenor { get; set; }
        public int? DendaTenorMultiply { get; set; }
        public short? SuspendMember { get; set; }
        public int? WarningLoanDueDay { get; set; }
        public string SuspendType { get; set; }
        public double? SuspendTenorJumlah { get; set; }
        public string SuspendTenorSatuan { get; set; }
        public int? DaySuspend { get; set; }
        public int? SuspendTenorMultiply { get; set; }
        public int? DayPerpanjang { get; set; }
        public int? CountPerpanjang { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Collectioncategorysdefault> Collectioncategorysdefault { get; set; }
        public virtual ICollection<LocationLibraryDefault> LocationLibraryDefault { get; set; }
        public virtual ICollection<Members> Members { get; set; }
    }
}
