using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Collectionrulesitems
    {
        public int CollectionRulesId { get; set; }
        public int StartDay { get; set; }
        public int EndDay { get; set; }
        public int? SuspendDays { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Collectionrules CollectionRules { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
