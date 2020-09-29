using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class MembersFormList
    {
        public int Id { get; set; }
        public int? MemberFieldId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public int? JenisPerpustakaanId { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual JenisPerpustakaan JenisPerpustakaan { get; set; }
        public virtual MemberFields MemberField { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
