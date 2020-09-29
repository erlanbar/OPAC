using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Requestcatalog
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Author { get; set; }
        public string PublishLocation { get; set; }
        public string PublishYear { get; set; }
        public string Publisher { get; set; }
        public string Comments { get; set; }
        public double? MemberId { get; set; }
        public string CallNumber { get; set; }
        public string ControlNumber { get; set; }
        public DateTime? DateRequest { get; set; }
        public string Status { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public int? WorksheetId { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Members Member { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
