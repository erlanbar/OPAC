using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Library
    {
        public Library()
        {
            Librarysearchcriteria = new HashSet<Librarysearchcriteria>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Port { get; set; }
        public string Databasename { get; set; }
        public string Recordsyntax { get; set; }
        public string Fullname { get; set; }
        public string Protocol { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Librarysearchcriteria> Librarysearchcriteria { get; set; }
    }
}
