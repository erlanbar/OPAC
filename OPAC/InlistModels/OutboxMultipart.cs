using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class OutboxMultipart
    {
        public string Text { get; set; }
        public string Coding { get; set; }
        public string Udh { get; set; }
        public int? Class { get; set; }
        public string TextDecoded { get; set; }
        public int Id { get; set; }
        public int SequencePosition { get; set; }
    }
}
