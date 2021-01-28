using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPAC.InlistModels
{
    public partial class Logsdownload
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string Ip { get; set; }
        public int? CatalogfilesId { get; set; }
        public bool IsLkd { get; set; }
        public DateTime? Waktu { get; set; }

        public virtual Catalogfiles Catalogfiles { get; set; }
    }
}
