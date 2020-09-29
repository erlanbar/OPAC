using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Refferenceitems
    {
        public int RefferenceItemsId { get; set; }
        public int RefferenceId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Refferences Refference { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
