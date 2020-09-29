using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Collectioncategorys
    {
        public Collectioncategorys()
        {
            Collectioncategorysdefault = new HashSet<Collectioncategorysdefault>();
            Collectioncategorysloanhari = new HashSet<Collectioncategorysloanhari>();
            Collections = new HashSet<Collections>();
            Memberloanauthorizecategory = new HashSet<Memberloanauthorizecategory>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
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
        public virtual ICollection<Collectioncategorysdefault> Collectioncategorysdefault { get; set; }
        public virtual ICollection<Collectioncategorysloanhari> Collectioncategorysloanhari { get; set; }
        public virtual ICollection<Collections> Collections { get; set; }
        public virtual ICollection<Memberloanauthorizecategory> Memberloanauthorizecategory { get; set; }
    }
}
