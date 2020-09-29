using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class RfidTemp
    {
        public string RfidNo { get; set; }
        public string Ip { get; set; }
        public string StatusAlarm { get; set; }
        public string SerialNumber { get; set; }
        public string ItemType { get; set; }
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
