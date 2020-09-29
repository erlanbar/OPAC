using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Branchs
    {
        public Branchs()
        {
            Catalogs = new HashSet<Catalogs>();
            Collectionloans = new HashSet<Collectionloans>();
            Collections = new HashSet<Collections>();
            Members = new HashSet<Members>();
            Membersonline = new HashSet<Membersonline>();
            Users = new HashSet<Users>();
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

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Catalogs> Catalogs { get; set; }
        public virtual ICollection<Collectionloans> Collectionloans { get; set; }
        public virtual ICollection<Collections> Collections { get; set; }
        public virtual ICollection<Members> Members { get; set; }
        public virtual ICollection<Membersonline> Membersonline { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
