using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Bookinglogs
    {
        public string MemberId { get; set; }
        public double? CollectionId { get; set; }
        public DateTime? BookingDate { get; set; }
        public DateTime? BookingExpired { get; set; }
    }
}
