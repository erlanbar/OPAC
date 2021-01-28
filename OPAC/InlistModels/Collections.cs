using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Collections
    {
        public Collections()
        {
            Bacaditempat = new HashSet<Bacaditempat>();
            Collectionloanextends = new HashSet<Collectionloanextends>();
            Collectionloanitems = new HashSet<Collectionloanitems>();
            DjknData = new HashSet<DjknData>();
            KeranjangKoleksi = new HashSet<KeranjangKoleksi>();
            Pelanggaran = new HashSet<Pelanggaran>();
            Pengiriman = new HashSet<Pengiriman>();
            Stockopnamedetail = new HashSet<Stockopnamedetail>();
            SumbanganKoleksi = new HashSet<SumbanganKoleksi>();
        }

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

        public virtual Branchs Branch { get; set; }
        public virtual Catalogs Catalog { get; set; }
        public virtual Collectioncategorys Category { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Currency CurrencyNavigation { get; set; }
        public virtual Users JilidcreatebyNavigation { get; set; }
        public virtual Locations Location { get; set; }
        public virtual LocationLibrary LocationLibrary { get; set; }
        public virtual Collectionmedias Media { get; set; }
        public virtual Partners Partner { get; set; }
        public virtual Users QuarantinedbyNavigation { get; set; }
        public virtual Collectionrules Rule { get; set; }
        public virtual Collectionsources Source { get; set; }
        public virtual Collectionstatus Status { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Bacaditempat> Bacaditempat { get; set; }
        public virtual ICollection<Collectionloanextends> Collectionloanextends { get; set; }
        public virtual ICollection<Collectionloanitems> Collectionloanitems { get; set; }
        public virtual ICollection<DjknData> DjknData { get; set; }
        public virtual ICollection<KeranjangKoleksi> KeranjangKoleksi { get; set; }
        public virtual ICollection<Pelanggaran> Pelanggaran { get; set; }
        public virtual ICollection<Pengiriman> Pengiriman { get; set; }
        public virtual ICollection<Stockopnamedetail> Stockopnamedetail { get; set; }
        public virtual ICollection<SumbanganKoleksi> SumbanganKoleksi { get; set; }
    }
}
