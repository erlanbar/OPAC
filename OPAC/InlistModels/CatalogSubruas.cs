using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class CatalogSubruas
    {
        public double Id { get; set; }
        public double RuasId { get; set; }
        public string SubRuas { get; set; }
        public string Value { get; set; }
        public int Sequence { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual CatalogRuas Ruas { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
