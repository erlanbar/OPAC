using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class JenisPerpustakaan
    {
        public JenisPerpustakaan()
        {
            MembersForm = new HashSet<MembersForm>();
            MembersFormList = new HashSet<MembersFormList>();
            MembersInfoForm = new HashSet<MembersInfoForm>();
            MembersLoanForm = new HashSet<MembersLoanForm>();
            MembersLoanreturnForm = new HashSet<MembersLoanreturnForm>();
            MembersOnlineForm = new HashSet<MembersOnlineForm>();
            MembersOnlineFormEdit = new HashSet<MembersOnlineFormEdit>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<MembersForm> MembersForm { get; set; }
        public virtual ICollection<MembersFormList> MembersFormList { get; set; }
        public virtual ICollection<MembersInfoForm> MembersInfoForm { get; set; }
        public virtual ICollection<MembersLoanForm> MembersLoanForm { get; set; }
        public virtual ICollection<MembersLoanreturnForm> MembersLoanreturnForm { get; set; }
        public virtual ICollection<MembersOnlineForm> MembersOnlineForm { get; set; }
        public virtual ICollection<MembersOnlineFormEdit> MembersOnlineFormEdit { get; set; }
    }
}
