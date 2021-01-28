using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class SerialArticlefiles
    {
        public SerialArticlefiles()
        {
            LogsdownloadArticle = new HashSet<LogsdownloadArticle>();
        }

        public int Id { get; set; }
        public double ArticlesId { get; set; }
        public string FileUrl { get; set; }
        public string FileFlash { get; set; }
        public string SizeFile { get; set; }
        public bool IsPublish { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public short? IsFromMember { get; set; }
        public double? MemberId { get; set; }

        public virtual SerialArticles Articles { get; set; }
        public virtual ICollection<LogsdownloadArticle> LogsdownloadArticle { get; set; }
    }
}
