using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Collectionrules
    {
        public Collectionrules()
        {
            Collections = new HashSet<Collections>();
            StockopnamedetailCurrentCollectionRule = new HashSet<Stockopnamedetail>();
            StockopnamedetailPrevCollectionRule = new HashSet<Stockopnamedetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Collections> Collections { get; set; }
        public virtual ICollection<Stockopnamedetail> StockopnamedetailCurrentCollectionRule { get; set; }
        public virtual ICollection<Stockopnamedetail> StockopnamedetailPrevCollectionRule { get; set; }
    }
}
