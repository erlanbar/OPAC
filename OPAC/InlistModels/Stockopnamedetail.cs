using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Stockopnamedetail
    {
        public double Id { get; set; }
        public int StockOpnameId { get; set; }
        public double CollectionId { get; set; }
        public int? PrevLocationId { get; set; }
        public int? CurrentLocationId { get; set; }
        public int? PrevStatusId { get; set; }
        public int? CurrentStatusId { get; set; }
        public int? PrevCollectionRuleId { get; set; }
        public int? CurrentCollectionRuleId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Collections Collection { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Collectionrules CurrentCollectionRule { get; set; }
        public virtual Locations CurrentLocation { get; set; }
        public virtual Collectionstatus CurrentStatus { get; set; }
        public virtual Collectionrules PrevCollectionRule { get; set; }
        public virtual Locations PrevLocation { get; set; }
        public virtual Collectionstatus PrevStatus { get; set; }
        public virtual Stockopname StockOpname { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
