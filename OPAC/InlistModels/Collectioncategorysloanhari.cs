using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Collectioncategorysloanhari
    {
        public int DataId { get; set; }
        public int? CategoryId { get; set; }
        public int? PeminjamanHariId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Collectioncategorys Category { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual PeraturanPeminjamanHari PeminjamanHari { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
