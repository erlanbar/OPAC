using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class BacaditempatLocations
    {
        public int Id { get; set; }
        public string IpPc { get; set; }
        public int? LocationId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
    }
}
