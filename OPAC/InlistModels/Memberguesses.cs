using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Memberguesses
    {
        public int Id { get; set; }
        public string NoAnggota { get; set; }
        public string Nama { get; set; }
        public int? StatusId { get; set; }
        public int? MasaBerlakuId { get; set; }
        public int? ProfesiId { get; set; }
        public int? PendidikanTerakhirId { get; set; }
        public int? JenisKelaminId { get; set; }
        public string Alamat { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public string Deskripsi { get; set; }
        public int? LocationloansId { get; set; }
        public int? LocationId { get; set; }
        public int? TujuanKunjunganId { get; set; }
        public string Information { get; set; }
        public string NoPengunjung { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual JenisKelamin JenisKelamin { get; set; }
        public virtual Locations Location { get; set; }
        public virtual LocationLibrary Locationloans { get; set; }
        public virtual MasaBerlakuAnggota MasaBerlaku { get; set; }
        public virtual MasterPendidikan PendidikanTerakhir { get; set; }
        public virtual MasterPekerjaan Profesi { get; set; }
        public virtual StatusAnggota Status { get; set; }
        public virtual TujuanKunjungan TujuanKunjungan { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
