using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Readinlocation
    {
        public double Id { get; set; }
        public string MemberNo { get; set; }
        public string Nama { get; set; }
        public string Status { get; set; }
        public string Profesi { get; set; }
        public string Pendidikan { get; set; }
        public string JenisKelamin { get; set; }
        public string Alamat { get; set; }
        public string TypeIdCard { get; set; }
        public string NoIdCard { get; set; }
        public string NoBarcode { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ControlNumber { get; set; }
        public int LocationId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Locations Location { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
