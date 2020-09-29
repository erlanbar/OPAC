using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Smslogs
    {
        public int Id { get; set; }
        public double? RecieverId { get; set; }
        public string PhoneNumber { get; set; }
        public string Text { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
    }
}
