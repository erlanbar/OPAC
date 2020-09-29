using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Refferences
    {
        public Refferences()
        {
            Refferenceitems = new HashSet<Refferenceitems>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FormatId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Formats Format { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Refferenceitems> Refferenceitems { get; set; }
    }
}
