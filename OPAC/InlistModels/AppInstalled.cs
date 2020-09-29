using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class AppInstalled
    {
        public int Id { get; set; }
        public string ActivationCode { get; set; }
        public string PerpustakaanName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public string Type { get; set; }
    }
}
