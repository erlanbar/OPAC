using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Session
    {
        public string Id { get; set; }
        public int? Expire { get; set; }
        public byte[] Data { get; set; }
    }
}
