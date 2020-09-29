using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class KeranjangKatalog
    {
        public int Id { get; set; }
        public double CatalogId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Catalogs Catalog { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
