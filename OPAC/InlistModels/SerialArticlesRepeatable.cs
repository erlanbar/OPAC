using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class SerialArticlesRepeatable
    {
        public long Id { get; set; }
        public double SerialArticleId { get; set; }
        public string ArticleField { get; set; }
        public string Value { get; set; }
        public int? CreateBy { get; set; }
        public int? UpdateBy { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual SerialArticles SerialArticle { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
