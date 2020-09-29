using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Collectionloanitems
    {
        public Collectionloanitems()
        {
            Collectionloanextends = new HashSet<Collectionloanextends>();
            Pelanggaran = new HashSet<Pelanggaran>();
            Sentitems = new HashSet<Sentitems>();
        }

        public double Id { get; set; }
        public string CollectionLoanId { get; set; }
        public DateTime? LoanDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ActualReturn { get; set; }
        public int? LateDays { get; set; }
        public string LoanStatus { get; set; }
        public double CollectionId { get; set; }
        public double MemberId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Collections Collection { get; set; }
        public virtual Collectionloans CollectionLoan { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Members Member { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Collectionloanextends> Collectionloanextends { get; set; }
        public virtual ICollection<Pelanggaran> Pelanggaran { get; set; }
        public virtual ICollection<Sentitems> Sentitems { get; set; }
    }
}
