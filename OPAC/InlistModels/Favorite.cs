using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Favorite
    {
        public double Id { get; set; }
        public double? CatalogId { get; set; }
        public string MemberId { get; set; }
        public DateTime? Createdate { get; set; }

        public virtual Catalogs Catalog { get; set; }
    }
}
