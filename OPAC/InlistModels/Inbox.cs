using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Inbox
    {
        public DateTimeOffset UpdatedInDb { get; set; }
        public DateTimeOffset ReceivingDateTime { get; set; }
        public string Text { get; set; }
        public string SenderNumber { get; set; }
        public string Coding { get; set; }
        public string Udh { get; set; }
        public string Smscnumber { get; set; }
        public int Class { get; set; }
        public string TextDecoded { get; set; }
        public int Id { get; set; }
        public string RecipientId { get; set; }
        public string Processed { get; set; }
    }
}
