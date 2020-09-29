using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class SerialArticles
    {
        public SerialArticles()
        {
            SerialArticlefiles = new HashSet<SerialArticlefiles>();
            SerialArticlesRepeatable = new HashSet<SerialArticlesRepeatable>();
        }

        public double Id { get; set; }
        public string ArticleType { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Creator { get; set; }
        public string Contributor { get; set; }
        public int? StartPage { get; set; }
        public int? Pages { get; set; }
        public string Subject { get; set; }
        public string Ddc { get; set; }
        public string CallNumber { get; set; }
        public string Edisiserial { get; set; }
        public DateTime? TanggalTerbitEdisiSerial { get; set; }
        public double? CatalogId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public short? Isopac { get; set; }
        public string Abstract { get; set; }

        public virtual Catalogs Catalog { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<SerialArticlefiles> SerialArticlefiles { get; set; }
        public virtual ICollection<SerialArticlesRepeatable> SerialArticlesRepeatable { get; set; }
    }
}
