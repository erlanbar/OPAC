using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Menu
    {
        public Menu()
        {
            InverseParentNavigation = new HashSet<Menu>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Parent { get; set; }
        public string Route { get; set; }
        public int? Order { get; set; }
        public string Data { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public string UpdateTerminal { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Menu ParentNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Menu> InverseParentNavigation { get; set; }
    }
}
