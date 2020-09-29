using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class MasterEdisiSerial
    {
        public double Id { get; set; }
        public DateTime? TglEdisiSerial { get; set; }
        public string NoEdisiSerial { get; set; }
        public double? CatalogId { get; set; }
        public int? CreateBy { get; set; }
        public int? UpdateBy { get; set; }

        public virtual Catalogs Catalog { get; set; }
    }
}
