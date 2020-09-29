using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Members
    {
        public Members()
        {
            Bacaditempat = new HashSet<Bacaditempat>();
            Catalogfiles = new HashSet<Catalogfiles>();
            Catalogs = new HashSet<Catalogs>();
            Collectionloanextends = new HashSet<Collectionloanextends>();
            Collectionloanitems = new HashSet<Collectionloanitems>();
            Collectionloans = new HashSet<Collectionloans>();
            Historydata = new HashSet<Historydata>();
            KeranjangAnggota = new HashSet<KeranjangAnggota>();
            MemberPerpanjangan = new HashSet<MemberPerpanjangan>();
            Memberloanauthorizecategory = new HashSet<Memberloanauthorizecategory>();
            Memberloanauthorizelocation = new HashSet<Memberloanauthorizelocation>();
            Pelanggaran = new HashSet<Pelanggaran>();
            QuarantinedCatalogs = new HashSet<QuarantinedCatalogs>();
            Requestcatalog = new HashSet<Requestcatalog>();
            Sumbangan = new HashSet<Sumbangan>();
        }

        public double Id { get; set; }
        public string MemberNo { get; set; }
        public string Fullname { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string AddressNow { get; set; }
        public string Phone { get; set; }
        public string InstitutionName { get; set; }
        public string InstitutionAddress { get; set; }
        public string InstitutionPhone { get; set; }
        public int? IdentityTypeId { get; set; }
        public string IdentityNo { get; set; }
        public int? EducationLevelId { get; set; }
        public int? SexId { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? JobId { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string MotherMaidenName { get; set; }
        public string Email { get; set; }
        public int? JenisPermohonanId { get; set; }
        public int? JenisAnggotaId { get; set; }
        public int? StatusAnggotaId { get; set; }
        public int? LoanReturnLateCount { get; set; }
        public int? BranchId { get; set; }
        public string PhotoUrl { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public string NoHp { get; set; }
        public string NamaDarurat { get; set; }
        public string TelpDarurat { get; set; }
        public string AlamatDarurat { get; set; }
        public string StatusHubunganDarurat { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string CityNow { get; set; }
        public string ProvinceNow { get; set; }
        public string Kecamatan { get; set; }
        public string Kelurahan { get; set; }
        public string Rt { get; set; }
        public string Rw { get; set; }
        public string KecamatanNow { get; set; }
        public string KelurahanNow { get; set; }
        public string Rtnow { get; set; }
        public string Rwnow { get; set; }
        public int? KelasId { get; set; }
        public string TahunAjaran { get; set; }
        public int? AgamaId { get; set; }
        public int? FakultasId { get; set; }
        public int? JurusanId { get; set; }
        public int? ProgramStudiId { get; set; }
        public int? JenjangPendidikanId { get; set; }
        public int? UnitKerjaId { get; set; }
        public string KeteranganLain { get; set; }
        public short? IsLunasBiayaPendaftaran { get; set; }
        public decimal? BiayaPendaftaran { get; set; }
        public DateTime? TanggalBebasPustaka { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Agama Agama { get; set; }
        public virtual Branchs Branch { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual MasterPendidikan EducationLevel { get; set; }
        public virtual MasterFakultas Fakultas { get; set; }
        public virtual MasterJenisIdentitas IdentityType { get; set; }
        public virtual JenisAnggota JenisAnggota { get; set; }
        public virtual JenisPermohonan JenisPermohonan { get; set; }
        public virtual MasterJenjangPendidikan JenjangPendidikan { get; set; }
        public virtual MasterPekerjaan Job { get; set; }
        public virtual MasterJurusan Jurusan { get; set; }
        public virtual KelasSiswa Kelas { get; set; }
        public virtual MasterStatusPerkawinan MaritalStatus { get; set; }
        public virtual MasterProgramStudi ProgramStudi { get; set; }
        public virtual JenisKelamin Sex { get; set; }
        public virtual StatusAnggota StatusAnggota { get; set; }
        public virtual Departments UnitKerja { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Bacaditempat> Bacaditempat { get; set; }
        public virtual ICollection<Catalogfiles> Catalogfiles { get; set; }
        public virtual ICollection<Catalogs> Catalogs { get; set; }
        public virtual ICollection<Collectionloanextends> Collectionloanextends { get; set; }
        public virtual ICollection<Collectionloanitems> Collectionloanitems { get; set; }
        public virtual ICollection<Collectionloans> Collectionloans { get; set; }
        public virtual ICollection<Historydata> Historydata { get; set; }
        public virtual ICollection<KeranjangAnggota> KeranjangAnggota { get; set; }
        public virtual ICollection<MemberPerpanjangan> MemberPerpanjangan { get; set; }
        public virtual ICollection<Memberloanauthorizecategory> Memberloanauthorizecategory { get; set; }
        public virtual ICollection<Memberloanauthorizelocation> Memberloanauthorizelocation { get; set; }
        public virtual ICollection<Pelanggaran> Pelanggaran { get; set; }
        public virtual ICollection<QuarantinedCatalogs> QuarantinedCatalogs { get; set; }
        public virtual ICollection<Requestcatalog> Requestcatalog { get; set; }
        public virtual ICollection<Sumbangan> Sumbangan { get; set; }
    }
}
