using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Modelhistory
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string Table { get; set; }
        public string FieldName { get; set; }
        public string FieldId { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public short Type { get; set; }
        public string UserId { get; set; }
    }
}
