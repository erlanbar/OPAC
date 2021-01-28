using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Catalogfiles
    {
        public Catalogfiles()
        {
            Logsdownload = new HashSet<Logsdownload>();
        }

        public int Id { get; set; }
        public double CatalogId { get; set; }
        public string FileUrl { get; set; }
        public string FileFlash { get; set; }
        public bool IsPublish { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public short? IsFromMember { get; set; }
        public double? MemberId { get; set; }

        public virtual Catalogs Catalog { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Members Member { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Logsdownload> Logsdownload { get; set; }
    }
}
