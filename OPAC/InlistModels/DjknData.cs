using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class DjknData
    {
        public int Id { get; set; }
        public double? CollectionId { get; set; }
        public string Cover { get; set; }
        public string FinishingCover { get; set; }
        public string FinishingHardCover { get; set; }
        public string Binding { get; set; }
        public string TotalPage { get; set; }
        public string PaperType { get; set; }
        public string BookSize { get; set; }
        public string ConditionBook { get; set; }
        public string ConditionsOutdated { get; set; }
        public string FullColor { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Collections Collection { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
