using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Penduduk
    {
        public int Id { get; set; }
        public string Nik { get; set; }
        public string Nama { get; set; }
        public string TempatLahir { get; set; }
        public string Provinsi { get; set; }
        public string KabupatenKota { get; set; }
        public string Kecamatan { get; set; }
        public string KelurahanDesa { get; set; }
        public string Tps { get; set; }
    }
}
