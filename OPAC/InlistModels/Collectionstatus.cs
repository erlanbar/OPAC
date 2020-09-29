using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Collectionstatus
    {
        public Collectionstatus()
        {
            Collections = new HashSet<Collections>();
            StockopnamedetailCurrentStatus = new HashSet<Stockopnamedetail>();
            StockopnamedetailPrevStatus = new HashSet<Stockopnamedetail>();
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
        public virtual ICollection<Stockopnamedetail> StockopnamedetailCurrentStatus { get; set; }
        public virtual ICollection<Stockopnamedetail> StockopnamedetailPrevStatus { get; set; }
    }
}
