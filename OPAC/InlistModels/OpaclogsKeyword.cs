using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class OpaclogsKeyword
    {
        public int Id { get; set; }
        public int OpaclogsId { get; set; }
        public string Field { get; set; }
        public string Keyword { get; set; }

        public virtual Opaclogs Opaclogs { get; set; }
    }
}
