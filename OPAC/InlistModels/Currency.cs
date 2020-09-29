using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Currency
    {
        public Currency()
        {
            Collections = new HashSet<Collections>();
        }

        public string Currency1 { get; set; }
        public string Description { get; set; }
        public int? SortId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Collections> Collections { get; set; }
    }
}
