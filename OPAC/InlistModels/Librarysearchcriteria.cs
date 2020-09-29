using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Librarysearchcriteria
    {
        public int Id { get; set; }
        public int Libraryid { get; set; }
        public string Criterianame { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Library Library { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
