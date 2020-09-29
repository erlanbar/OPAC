using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class LogsdownloadArticle
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string Ip { get; set; }
        public int? ArticlefilesId { get; set; }
        public DateTime? Waktu { get; set; }

        public virtual SerialArticlefiles Articlefiles { get; set; }
    }
}
