using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Collectioncategorysdefault
    {
        public int Id { get; set; }
        public int? CollectionCategoryId { get; set; }
        public int JenisAnggotaId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Collectioncategorys CollectionCategory { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual JenisAnggota JenisAnggota { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
