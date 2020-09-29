using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class LocationLibrary
    {
        public LocationLibrary()
        {
            Collectionloans = new HashSet<Collectionloans>();
            Collections = new HashSet<Collections>();
            Groupguesses = new HashSet<Groupguesses>();
            LocationLibraryDefault = new HashSet<LocationLibraryDefault>();
            Locations = new HashSet<Locations>();
            Memberguesses = new HashSet<Memberguesses>();
            Memberloanauthorizelocation = new HashSet<Memberloanauthorizelocation>();
            Membersonline = new HashSet<Membersonline>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Collectionloans> Collectionloans { get; set; }
        public virtual ICollection<Collections> Collections { get; set; }
        public virtual ICollection<Groupguesses> Groupguesses { get; set; }
        public virtual ICollection<LocationLibraryDefault> LocationLibraryDefault { get; set; }
        public virtual ICollection<Locations> Locations { get; set; }
        public virtual ICollection<Memberguesses> Memberguesses { get; set; }
        public virtual ICollection<Memberloanauthorizelocation> Memberloanauthorizelocation { get; set; }
        public virtual ICollection<Membersonline> Membersonline { get; set; }
    }
}
