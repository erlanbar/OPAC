using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class CatalogRuas
    {
        public CatalogRuas()
        {
            CatalogSubruas = new HashSet<CatalogSubruas>();
        }

        public double Id { get; set; }
        public double CatalogId { get; set; }
        public string Tag { get; set; }
        public string Indicator1 { get; set; }
        public string Indicator2 { get; set; }
        public string Value { get; set; }
        public int Sequence { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Catalogs Catalog { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<CatalogSubruas> CatalogSubruas { get; set; }
    }
}
