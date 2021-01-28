using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class QuarantinedCollections
    {
        public double Id { get; set; }
        public string NomorBarcode { get; set; }
        public string NoInduk { get; set; }
        public string Currency { get; set; }
        public string Rfid { get; set; }
        public decimal? Price { get; set; }
        public string PriceType { get; set; }
        public DateTime? TanggalPengadaan { get; set; }
        public string CallNumber { get; set; }
        public int? BranchId { get; set; }
        public double? CatalogId { get; set; }
        public int? PartnerId { get; set; }
        public int? LocationId { get; set; }
        public int? RuleId { get; set; }
        public int? CategoryId { get; set; }
        public int? MediaId { get; set; }
        public int? SourceId { get; set; }
        public int? StatusId { get; set; }
        public int? LocationLibraryId { get; set; }
        public string KeteranganSumber { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public short? IsVerified { get; set; }
        public int? Quarantinedby { get; set; }
        public DateTime? Quarantineddate { get; set; }
        public string Quarantinedterminal { get; set; }
        public short? Isreferensi { get; set; }
        public string Edisiserial { get; set; }
        public int? Nojilid { get; set; }
        public DateTime? TanggalTerbitEdisiSerial { get; set; }
        public string BahanSertaan { get; set; }
        public string KeteranganLain { get; set; }
        public DateTime? Tglentryjilid { get; set; }
        public string Idjilid { get; set; }
        public string Nomorpanggiljilid { get; set; }
        public bool Isopac { get; set; }
        public int? Jilidcreateby { get; set; }
        public DateTime? KiilastUploadDate { get; set; }
        public string BookingMemberId { get; set; }
        public DateTime? BookingExpiredDate { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users QuarantinedbyNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
