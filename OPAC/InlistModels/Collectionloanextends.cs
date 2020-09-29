using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Collectionloanextends
    {
        public int Id { get; set; }
        public string CollectionLoanId { get; set; }
        public double CollectionLoanItemId { get; set; }
        public double CollectionId { get; set; }
        public double MemberId { get; set; }
        public DateTime DateExtend { get; set; }
        public DateTime DueDateExtend { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Collections Collection { get; set; }
        public virtual Collectionloans CollectionLoan { get; set; }
        public virtual Collectionloanitems CollectionLoanItem { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Members Member { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
