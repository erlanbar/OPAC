using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Catalogstaging
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publishment { get; set; }
        public string Edition { get; set; }
        public string MarcLoc { get; set; }
        public int? WorksheetId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
