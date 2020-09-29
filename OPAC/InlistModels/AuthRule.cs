using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class AuthRule
    {
        public AuthRule()
        {
            AuthItem = new HashSet<AuthItem>();
        }

        public string Name { get; set; }
        public string Data { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<AuthItem> AuthItem { get; set; }
    }
}
