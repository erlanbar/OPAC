using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Worksheets
    {
        public Worksheets()
        {
            AuthHeader = new HashSet<AuthHeader>();
            Catalogs = new HashSet<Catalogs>();
            Collectionmedias = new HashSet<Collectionmedias>();
            Worksheetfields = new HashSet<Worksheetfields>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FormatId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public int? NoUrut { get; set; }
        public string DepositformatCode { get; set; }
        public bool Isserial { get; set; }
        public short? Ismusik { get; set; }
        public short? Iskartografi { get; set; }
        public string Code { get; set; }
        public string Keterangan { get; set; }
        public int? MaxPinjamKoleksi { get; set; }
        public int? MaxLoanDays { get; set; }
        public string DendaType { get; set; }
        public decimal? DendaTenorJumlah { get; set; }
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

        public virtual Users CreateByNavigation { get; set; }
        public virtual Formats Format { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<AuthHeader> AuthHeader { get; set; }
        public virtual ICollection<Catalogs> Catalogs { get; set; }
        public virtual ICollection<Collectionmedias> Collectionmedias { get; set; }
        public virtual ICollection<Worksheetfields> Worksheetfields { get; set; }
    }
}
