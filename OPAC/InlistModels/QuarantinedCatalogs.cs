using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class QuarantinedCatalogs
    {
        public QuarantinedCatalogs()
        {
            QuarantinedCatalogRuas = new HashSet<QuarantinedCatalogRuas>();
        }

        public double Id { get; set; }
        public string ControlNumber { get; set; }
        public string Bibid { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }
        public string Publisher { get; set; }
        public string PublishLocation { get; set; }
        public string PublishYear { get; set; }
        public string Publikasi { get; set; }
        public string Subject { get; set; }
        public string PhysicalDescription { get; set; }
        public string Isbn { get; set; }
        public string CallNumber { get; set; }
        public string Note { get; set; }
        public string Languages { get; set; }
        public string DeweyNo { get; set; }
        public DateTime? ApproveDateOpac { get; set; }
        public bool IsOpac { get; set; }
        public short? IsBni { get; set; }
        public short? IsKin { get; set; }
        public short? IsRda { get; set; }
        public string CoverUrl { get; set; }
        public int? BranchId { get; set; }
        public int WorksheetId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public string MarcLoc { get; set; }
        public string PreservasiId { get; set; }
        public int? Quarantinedby { get; set; }
        public DateTime? Quarantineddate { get; set; }
        public string Quarantinedterminal { get; set; }
        public double? MemberId { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Members Member { get; set; }
        public virtual Users QuarantinedbyNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<QuarantinedCatalogRuas> QuarantinedCatalogRuas { get; set; }
    }
}
