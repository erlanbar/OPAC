using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Sentitems
    {
        public DateTimeOffset UpdatedInDb { get; set; }
        public DateTimeOffset InsertIntoDb { get; set; }
        public DateTimeOffset SendingDateTime { get; set; }
        public DateTimeOffset? DeliveryDateTime { get; set; }
        public string Text { get; set; }
        public string DestinationNumber { get; set; }
        public string Coding { get; set; }
        public string Udh { get; set; }
        public string Smscnumber { get; set; }
        public int Class { get; set; }
        public string TextDecoded { get; set; }
        public int Id { get; set; }
        public string SenderId { get; set; }
        public int SequencePosition { get; set; }
        public string Status { get; set; }
        public int StatusError { get; set; }
        public int Tpmr { get; set; }
        public int RelativeValidity { get; set; }
        public string CreatorId { get; set; }
        public double? CollectionLoanItemId { get; set; }

        public virtual Collectionloanitems CollectionLoanItem { get; set; }
    }
}
