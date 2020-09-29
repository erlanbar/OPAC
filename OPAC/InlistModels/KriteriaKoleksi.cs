using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class KriteriaKoleksi
    {
        public int Id { get; set; }
        public string JnsKriteria { get; set; }
        public double? CatalogId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AlamatImage { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public string PublishYear { get; set; }
        public int? Jumlah { get; set; }
        public string WorksheetName { get; set; }
        public string IsLkd { get; set; }

        public virtual Catalogs Catalog { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
