using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Membersonline
    {
        public int Id { get; set; }
        public string NoAnggota { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int? BranchId { get; set; }
        public int? LocationLoanId { get; set; }
        public string Status { get; set; }
        public string ActivationCode { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public string AuthKey { get; set; }

        public virtual Branchs Branch { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual LocationLibrary LocationLoan { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
