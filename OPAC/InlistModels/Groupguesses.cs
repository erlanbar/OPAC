using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Groupguesses
    {
        public int Id { get; set; }
        public string NamaKetua { get; set; }
        public string NomerTelponKetua { get; set; }
        public string AsalInstansi { get; set; }
        public string AlamatInstansi { get; set; }
        public int? CountPersonel { get; set; }
        public int? CountPns { get; set; }
        public int? CountPswasta { get; set; }
        public int? CountPeneliti { get; set; }
        public int? CountGuru { get; set; }
        public int? CountDosen { get; set; }
        public int? CountPensiunan { get; set; }
        public int? CountTni { get; set; }
        public int? CountWiraswasta { get; set; }
        public int? CountPelajar { get; set; }
        public int? CountMahasiswa { get; set; }
        public int? CountLainnya { get; set; }
        public int? CountSd { get; set; }
        public int? CountSmp { get; set; }
        public int? CountSma { get; set; }
        public int? CountD1 { get; set; }
        public int? CountD2 { get; set; }
        public int? CountD3 { get; set; }
        public int? CountS1 { get; set; }
        public int? CountS2 { get; set; }
        public int? CountS3 { get; set; }
        public int? CountLaki { get; set; }
        public int? CountPerempuan { get; set; }
        public int? TujuanKunjunganId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public int? LocationLoansId { get; set; }
        public int? LocationId { get; set; }
        public string TeleponInstansi { get; set; }
        public string EmailInstansi { get; set; }
        public string Information { get; set; }
        public string NoPengunjung { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Locations Location { get; set; }
        public virtual LocationLibrary LocationLoans { get; set; }
        public virtual TujuanKunjungan TujuanKunjungan { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
