using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class JudulKoleksi
    {
        public int No { get; set; }
        public string JudulPernyataan { get; set; }
        public string EdCet { get; set; }
        public string Kota { get; set; }
        public string Penerbit { get; set; }
        public int? Tahun { get; set; }
        public string NoInduk { get; set; }
        public string NoClass { get; set; }
        public string NoPanggil { get; set; }
        public string Pengarang { get; set; }
        public string Kolasi { get; set; }
        public string Catatan { get; set; }
        public string Bibliografi { get; set; }
        public string Indeks { get; set; }
        public string Isbn { get; set; }
        public string Subjek1 { get; set; }
        public string Subjek2 { get; set; }
        public string Subjek3 { get; set; }
        public string Subjek4 { get; set; }
        public string Tet1 { get; set; }
        public string Tet2 { get; set; }
        public string Tet3 { get; set; }
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
