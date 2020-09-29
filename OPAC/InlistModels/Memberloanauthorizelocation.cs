using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Memberloanauthorizelocation
    {
        public long DataId { get; set; }
        public double MemberId { get; set; }
        public int LocationLoanId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual LocationLibrary LocationLoan { get; set; }
        public virtual Members Member { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
