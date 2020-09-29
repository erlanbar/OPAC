using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Colloclib
    {
        public double ColId { get; set; }
        public int LocLibId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Collections Col { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual LocationLibrary LocLib { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
