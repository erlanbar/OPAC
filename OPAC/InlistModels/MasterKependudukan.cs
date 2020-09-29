using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class MasterKependudukan
    {
        public int Id { get; set; }
        public string Nomorkk { get; set; }
        public string Nik { get; set; }
        public string Namalengkap { get; set; }
        public string NamaIbu { get; set; }
        public string Al1 { get; set; }
        public string Rt { get; set; }
        public string Rw { get; set; }
        public string Kodekec { get; set; }
        public string Kodekel { get; set; }
        public string NamaKec { get; set; }
        public string NamaKel { get; set; }
        public string NamaKab { get; set; }
        public string NamaProv { get; set; }
        public string Alamat { get; set; }
        public string Lhrtempat { get; set; }
        public string Lhrtanggal { get; set; }
        public string Ttl { get; set; }
        public string Umur { get; set; }
        public int? Jk { get; set; }
        public string Jenis { get; set; }
        public int? Status { get; set; }
        public string Sts { get; set; }
        public string Hub { get; set; }
        public int? Agama { get; set; }
        public string Agm { get; set; }
        public string Pendidikan { get; set; }
        public string Pekerjaan { get; set; }
        public string KlainFisik { get; set; }
        public string Aktalhr { get; set; }
        public string Aktakawin { get; set; }
        public string Aktacerai { get; set; }
        public string Nocacat { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
    }
}
