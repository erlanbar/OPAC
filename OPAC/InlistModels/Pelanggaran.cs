using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Pelanggaran
    {
        public int Id { get; set; }
        public string CollectionLoanId { get; set; }
        public double? CollectionLoanItemId { get; set; }
        public int? JenisPelanggaranId { get; set; }
        public int? JenisDendaId { get; set; }
        public decimal? JumlahDenda { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public int? JumlahSuspend { get; set; }
        public short? Paid { get; set; }
        public double? MemberId { get; set; }
        public double? CollectionId { get; set; }

        public virtual Collections Collection { get; set; }
        public virtual Collectionloans CollectionLoan { get; set; }
        public virtual Collectionloanitems CollectionLoanItem { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual JenisDenda JenisDenda { get; set; }
        public virtual JenisPelanggaran JenisPelanggaran { get; set; }
        public virtual Members Member { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
