using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class MasterLoker
    {
        public MasterLoker()
        {
            Lockers = new HashSet<Lockers>();
        }

        public int Id { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public int? LocationsId { get; set; }
        public string Status { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Locations Locations { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Lockers> Lockers { get; set; }
    }
}
