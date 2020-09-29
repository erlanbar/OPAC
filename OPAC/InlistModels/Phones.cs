using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Phones
    {
        public string Id { get; set; }
        public DateTimeOffset UpdatedInDb { get; set; }
        public DateTimeOffset InsertIntoDb { get; set; }
        public DateTimeOffset TimeOut { get; set; }
        public string Send { get; set; }
        public string Receive { get; set; }
        public string Imei { get; set; }
        public string Client { get; set; }
        public int Battery { get; set; }
        public int Signal { get; set; }
        public int Sent { get; set; }
        public int Received { get; set; }
    }
}
