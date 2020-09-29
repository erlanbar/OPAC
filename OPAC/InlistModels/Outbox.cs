using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Outbox
    {
        public DateTimeOffset UpdatedInDb { get; set; }
        public DateTimeOffset InsertIntoDb { get; set; }
        public DateTimeOffset SendingDateTime { get; set; }
        public TimeSpan SendBefore { get; set; }
        public TimeSpan SendAfter { get; set; }
        public string Text { get; set; }
        public string DestinationNumber { get; set; }
        public string Coding { get; set; }
        public string Udh { get; set; }
        public int? Class { get; set; }
        public string TextDecoded { get; set; }
        public int Id { get; set; }
        public string MultiPart { get; set; }
        public int? RelativeValidity { get; set; }
        public string SenderId { get; set; }
        public DateTimeOffset? SendingTimeOut { get; set; }
        public string DeliveryReport { get; set; }
        public string CreatorId { get; set; }
    }
}
