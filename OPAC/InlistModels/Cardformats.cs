using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Cardformats
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string FontName { get; set; }
        public int? FontSize { get; set; }
        public string FormatTeks { get; set; }
        public string FormatTeksNoAuthor { get; set; }
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
