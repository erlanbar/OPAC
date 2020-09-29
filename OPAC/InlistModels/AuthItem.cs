using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class AuthItem
    {
        public AuthItem()
        {
            AuthAssignment = new HashSet<AuthAssignment>();
            AuthItemChildChildNavigation = new HashSet<AuthItemChild>();
            AuthItemChildParentNavigation = new HashSet<AuthItemChild>();
        }

        public string Name { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public string RuleName { get; set; }
        public string Data { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual AuthRule RuleNameNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<AuthAssignment> AuthAssignment { get; set; }
        public virtual ICollection<AuthItemChild> AuthItemChildChildNavigation { get; set; }
        public virtual ICollection<AuthItemChild> AuthItemChildParentNavigation { get; set; }
    }
}
