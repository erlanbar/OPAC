using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class AuthAssignment
    {
        public string ItemName { get; set; }
        public string UserId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual AuthItem ItemNameNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
