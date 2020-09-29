using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Collectionloans
    {
        public Collectionloans()
        {
            Collectionloanextends = new HashSet<Collectionloanextends>();
            Collectionloanitems = new HashSet<Collectionloanitems>();
            Pelanggaran = new HashSet<Pelanggaran>();
        }

        public string Id { get; set; }
        public int? CollectionCount { get; set; }
        public int? LateCount { get; set; }
        public int? ExtendCount { get; set; }
        public int? LoanCount { get; set; }
        public int? ReturnCount { get; set; }
        public double MemberId { get; set; }
        public int? BranchId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public DateTime? KiilastUploadDate { get; set; }
        public int? LocationLibraryId { get; set; }

        public virtual Branchs Branch { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual LocationLibrary LocationLibrary { get; set; }
        public virtual Members Member { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Collectionloanextends> Collectionloanextends { get; set; }
        public virtual ICollection<Collectionloanitems> Collectionloanitems { get; set; }
        public virtual ICollection<Pelanggaran> Pelanggaran { get; set; }
    }
}
