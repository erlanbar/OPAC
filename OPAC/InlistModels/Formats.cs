using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Formats
    {
        public Formats()
        {
            Fields = new HashSet<Fields>();
            Refferences = new HashSet<Refferences>();
            Worksheets = new HashSet<Worksheets>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Fields> Fields { get; set; }
        public virtual ICollection<Refferences> Refferences { get; set; }
        public virtual ICollection<Worksheets> Worksheets { get; set; }
    }
}
