using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class LocationLibraryDefault
    {
        public int Id { get; set; }
        public int? LocationLibraryId { get; set; }
        public int? JenisAnggotaId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTeminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual JenisAnggota JenisAnggota { get; set; }
        public virtual LocationLibrary LocationLibrary { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
