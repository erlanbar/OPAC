using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OPAC.InlistModels;

namespace OPAC.Data
{
    public partial class InlistContext : DbContext
    {
        public InlistContext()
        {
        }

        public InlistContext(DbContextOptions<InlistContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agama> Agama { get; set; }
        public virtual DbSet<AppInstalled> AppInstalled { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<AuthAssignment> AuthAssignment { get; set; }
        public virtual DbSet<AuthData> AuthData { get; set; }
        public virtual DbSet<AuthHeader> AuthHeader { get; set; }
        public virtual DbSet<AuthItem> AuthItem { get; set; }
        public virtual DbSet<AuthItemChild> AuthItemChild { get; set; }
        public virtual DbSet<AuthRule> AuthRule { get; set; }
        public virtual DbSet<Bacaditempat> Bacaditempat { get; set; }
        public virtual DbSet<BacaditempatLocations> BacaditempatLocations { get; set; }
        public virtual DbSet<Backup> Backup { get; set; }
        public virtual DbSet<Bibidavailable> Bibidavailable { get; set; }
        public virtual DbSet<Bookinglogs> Bookinglogs { get; set; }
        public virtual DbSet<Bookmark> Bookmark { get; set; }
        public virtual DbSet<Branchs> Branchs { get; set; }
        public virtual DbSet<Cardformats> Cardformats { get; set; }
        public virtual DbSet<CatalogRuas> CatalogRuas { get; set; }
        public virtual DbSet<CatalogSubruas> CatalogSubruas { get; set; }
        public virtual DbSet<Catalogfiles> Catalogfiles { get; set; }
        public virtual DbSet<Catalogs> Catalogs { get; set; }
        public virtual DbSet<Catalogstaging> Catalogstaging { get; set; }
        public virtual DbSet<CheckpointLocations> CheckpointLocations { get; set; }
        public virtual DbSet<Collectioncategorys> Collectioncategorys { get; set; }
        public virtual DbSet<Collectioncategorysdefault> Collectioncategorysdefault { get; set; }
        public virtual DbSet<Collectioncategorysloanhari> Collectioncategorysloanhari { get; set; }
        public virtual DbSet<Collectionloanextends> Collectionloanextends { get; set; }
        public virtual DbSet<Collectionloanitems> Collectionloanitems { get; set; }
        public virtual DbSet<Collectionloans> Collectionloans { get; set; }
        public virtual DbSet<Collectionlocations> Collectionlocations { get; set; }
        public virtual DbSet<Collectionmedias> Collectionmedias { get; set; }
        public virtual DbSet<Collectionrules> Collectionrules { get; set; }
        public virtual DbSet<Collectionrulesitems> Collectionrulesitems { get; set; }
        public virtual DbSet<Collections> Collections { get; set; }
        public virtual DbSet<Collectionsources> Collectionsources { get; set; }
        public virtual DbSet<Collectionstatus> Collectionstatus { get; set; }
        public virtual DbSet<Colloclib> Colloclib { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Daemons> Daemons { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<DjknData> DjknData { get; set; }
        public virtual DbSet<Favorite> Favorite { get; set; }
        public virtual DbSet<Fielddatas> Fielddatas { get; set; }
        public virtual DbSet<Fieldgroups> Fieldgroups { get; set; }
        public virtual DbSet<Fieldindicator1s> Fieldindicator1s { get; set; }
        public virtual DbSet<Fieldindicator2s> Fieldindicator2s { get; set; }
        public virtual DbSet<Fields> Fields { get; set; }
        public virtual DbSet<Formats> Formats { get; set; }
        public virtual DbSet<Gammu> Gammu { get; set; }
        public virtual DbSet<Groupguesses> Groupguesses { get; set; }
        public virtual DbSet<Historydata> Historydata { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
        public virtual DbSet<Inbox> Inbox { get; set; }
        public virtual DbSet<JenisAnggota> JenisAnggota { get; set; }
        public virtual DbSet<JenisDenda> JenisDenda { get; set; }
        public virtual DbSet<JenisKelamin> JenisKelamin { get; set; }
        public virtual DbSet<JenisPelanggaran> JenisPelanggaran { get; set; }
        public virtual DbSet<JenisPermohonan> JenisPermohonan { get; set; }
        public virtual DbSet<JenisPerpustakaan> JenisPerpustakaan { get; set; }
        public virtual DbSet<JudulKoleksi> JudulKoleksi { get; set; }
        public virtual DbSet<Kabupaten> Kabupaten { get; set; }
        public virtual DbSet<KataSandang> KataSandang { get; set; }
        public virtual DbSet<KelasSiswa> KelasSiswa { get; set; }
        public virtual DbSet<KelompokPelanggaran> KelompokPelanggaran { get; set; }
        public virtual DbSet<KeranjangAnggota> KeranjangAnggota { get; set; }
        public virtual DbSet<KeranjangKatalog> KeranjangKatalog { get; set; }
        public virtual DbSet<KeranjangKoleksi> KeranjangKoleksi { get; set; }
        public virtual DbSet<KriteriaKoleksi> KriteriaKoleksi { get; set; }
        public virtual DbSet<Library> Library { get; set; }
        public virtual DbSet<Librarysearchcriteria> Librarysearchcriteria { get; set; }
        public virtual DbSet<LocationLibrary> LocationLibrary { get; set; }
        public virtual DbSet<LocationLibraryDefault> LocationLibraryDefault { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Lockers> Lockers { get; set; }
        public virtual DbSet<Logsdownload> Logsdownload { get; set; }
        public virtual DbSet<LogsdownloadArticle> LogsdownloadArticle { get; set; }
        public virtual DbSet<Mailserver> Mailserver { get; set; }
        public virtual DbSet<MasaBerlakuAnggota> MasaBerlakuAnggota { get; set; }
        public virtual DbSet<MasterDjkn> MasterDjkn { get; set; }
        public virtual DbSet<MasterEdisiSerial> MasterEdisiSerial { get; set; }
        public virtual DbSet<MasterFakultas> MasterFakultas { get; set; }
        public virtual DbSet<MasterJamBuka> MasterJamBuka { get; set; }
        public virtual DbSet<MasterJenisIdentitas> MasterJenisIdentitas { get; set; }
        public virtual DbSet<MasterJenjangPendidikan> MasterJenjangPendidikan { get; set; }
        public virtual DbSet<MasterJurusan> MasterJurusan { get; set; }
        public virtual DbSet<MasterKelasBesar> MasterKelasBesar { get; set; }
        public virtual DbSet<MasterKependudukan> MasterKependudukan { get; set; }
        public virtual DbSet<MasterLoker> MasterLoker { get; set; }
        public virtual DbSet<MasterPekerjaan> MasterPekerjaan { get; set; }
        public virtual DbSet<MasterPelanggaranLocker> MasterPelanggaranLocker { get; set; }
        public virtual DbSet<MasterPendidikan> MasterPendidikan { get; set; }
        public virtual DbSet<MasterProgramStudi> MasterProgramStudi { get; set; }
        public virtual DbSet<MasterRangeUmur> MasterRangeUmur { get; set; }
        public virtual DbSet<MasterStatusPerkawinan> MasterStatusPerkawinan { get; set; }
        public virtual DbSet<MasterUangJaminan> MasterUangJaminan { get; set; }
        public virtual DbSet<MemberFields> MemberFields { get; set; }
        public virtual DbSet<MemberPerpanjangan> MemberPerpanjangan { get; set; }
        public virtual DbSet<Memberguesses> Memberguesses { get; set; }
        public virtual DbSet<Memberloanauthorizecategory> Memberloanauthorizecategory { get; set; }
        public virtual DbSet<Memberloanauthorizelocation> Memberloanauthorizelocation { get; set; }
        public virtual DbSet<Memberrules> Memberrules { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<MembersForm> MembersForm { get; set; }
        public virtual DbSet<MembersFormList> MembersFormList { get; set; }
        public virtual DbSet<MembersInfoForm> MembersInfoForm { get; set; }
        public virtual DbSet<MembersLoanForm> MembersLoanForm { get; set; }
        public virtual DbSet<MembersLoanreturnForm> MembersLoanreturnForm { get; set; }
        public virtual DbSet<MembersOnlineForm> MembersOnlineForm { get; set; }
        public virtual DbSet<MembersOnlineFormEdit> MembersOnlineFormEdit { get; set; }
        public virtual DbSet<Membersonline> Membersonline { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Migration> Migration { get; set; }
        public virtual DbSet<Modelhistory> Modelhistory { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<NotifSmsGateway> NotifSmsGateway { get; set; }
        public virtual DbSet<NotifSmsGatewayHist> NotifSmsGatewayHist { get; set; }
        public virtual DbSet<Opacfields> Opacfields { get; set; }
        public virtual DbSet<Opaclogs> Opaclogs { get; set; }
        public virtual DbSet<OpaclogsKeyword> OpaclogsKeyword { get; set; }
        public virtual DbSet<Outbox> Outbox { get; set; }
        public virtual DbSet<OutboxMultipart> OutboxMultipart { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<Pbk> Pbk { get; set; }
        public virtual DbSet<PbkGroups> PbkGroups { get; set; }
        public virtual DbSet<Pelanggaran> Pelanggaran { get; set; }
        public virtual DbSet<Penduduk> Penduduk { get; set; }
        public virtual DbSet<Pengiriman> Pengiriman { get; set; }
        public virtual DbSet<PeraturanPeminjamanHari> PeraturanPeminjamanHari { get; set; }
        public virtual DbSet<PeraturanPeminjamanTanggal> PeraturanPeminjamanTanggal { get; set; }
        public virtual DbSet<Phones> Phones { get; set; }
        public virtual DbSet<Propinsi> Propinsi { get; set; }
        public virtual DbSet<Publishers> Publishers { get; set; }
        public virtual DbSet<QuarantinedAuthData> QuarantinedAuthData { get; set; }
        public virtual DbSet<QuarantinedAuthHeader> QuarantinedAuthHeader { get; set; }
        public virtual DbSet<QuarantinedCatalogRuas> QuarantinedCatalogRuas { get; set; }
        public virtual DbSet<QuarantinedCatalogSubruas> QuarantinedCatalogSubruas { get; set; }
        public virtual DbSet<QuarantinedCatalogs> QuarantinedCatalogs { get; set; }
        public virtual DbSet<QuarantinedCollections> QuarantinedCollections { get; set; }
        public virtual DbSet<QuarantinedPengiriman> QuarantinedPengiriman { get; set; }
        public virtual DbSet<Readinlocation> Readinlocation { get; set; }
        public virtual DbSet<Refferenceitems> Refferenceitems { get; set; }
        public virtual DbSet<Refferences> Refferences { get; set; }
        public virtual DbSet<Requestcatalog> Requestcatalog { get; set; }
        public virtual DbSet<RfidTemp> RfidTemp { get; set; }
        public virtual DbSet<Rolemodule> Rolemodule { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<Sentitems> Sentitems { get; set; }
        public virtual DbSet<SerialArticlefiles> SerialArticlefiles { get; set; }
        public virtual DbSet<SerialArticles> SerialArticles { get; set; }
        public virtual DbSet<SerialArticlesRepeatable> SerialArticlesRepeatable { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<Settingcatalogdetail> Settingcatalogdetail { get; set; }
        public virtual DbSet<Settingparameters> Settingparameters { get; set; }
        public virtual DbSet<Smslogs> Smslogs { get; set; }
        public virtual DbSet<StatusAnggota> StatusAnggota { get; set; }
        public virtual DbSet<Stockopname> Stockopname { get; set; }
        public virtual DbSet<Stockopnamedetail> Stockopnamedetail { get; set; }
        public virtual DbSet<Sumbangan> Sumbangan { get; set; }
        public virtual DbSet<SumbanganKoleksi> SumbanganKoleksi { get; set; }
        public virtual DbSet<Survey> Survey { get; set; }
        public virtual DbSet<SurveyIsian> SurveyIsian { get; set; }
        public virtual DbSet<SurveyPertanyaan> SurveyPertanyaan { get; set; }
        public virtual DbSet<SurveyPilihan> SurveyPilihan { get; set; }
        public virtual DbSet<SurveyPilihanSesi> SurveyPilihanSesi { get; set; }
        public virtual DbSet<Tempnoinduk> Tempnoinduk { get; set; }
        public virtual DbSet<TujuanKunjungan> TujuanKunjungan { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Userloclibforcol> Userloclibforcol { get; set; }
        public virtual DbSet<Userloclibforloan> Userloclibforloan { get; set; }
        public virtual DbSet<Userlogs> Userlogs { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Worksheetfielditems> Worksheetfielditems { get; set; }
        public virtual DbSet<Worksheetfields> Worksheetfields { get; set; }
        public virtual DbSet<Worksheets> Worksheets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Uid=root; Pwd=1234567;Server=localhost;Port=3306;Database=inlislite_v3;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agama>(entity =>
            {
                entity.ToTable("agama");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("agama_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("agama_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("agama_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("agama_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("agama_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.AgamaCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("agama_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.AgamaUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("agama_updateby");
            });

            modelBuilder.Entity<AppInstalled>(entity =>
            {
                entity.ToTable("app_installed");

                entity.HasIndex(e => e.ActivationCode)
                    .HasName("UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Applications>(entity =>
            {
                entity.ToTable("applications");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("applications_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("applications_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsPublish)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WhenDownMessageError)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.ApplicationsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("applications_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.ApplicationsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("applications_updateby");
            });

            modelBuilder.Entity<AuthAssignment>(entity =>
            {
                entity.HasKey(e => new { e.ItemName, e.UserId })
                    .HasName("PRIMARY");

                entity.ToTable("auth_assignment");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("auth_assignment_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("auth_assignment_updateby");

                entity.Property(e => e.ItemName)
                    .HasColumnName("item_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.AuthAssignmentCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auth_assignment_createby");

                entity.HasOne(d => d.ItemNameNavigation)
                    .WithMany(p => p.AuthAssignment)
                    .HasForeignKey(d => d.ItemName)
                    .HasConstraintName("auth_assignment_ibfk_1");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.AuthAssignmentUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auth_assignment_updateby");
            });

            modelBuilder.Entity<AuthData>(entity =>
            {
                entity.ToTable("auth_data");

                entity.HasIndex(e => e.AuthHeaderId)
                    .HasName("auth_data_auth_header");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("auth_data_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("auth_data_updateby");

                entity.HasIndex(e => e.Value)
                    .HasName("auth_data_IDX4");

                entity.HasIndex(e => new { e.AuthHeaderId, e.Tag })
                    .HasName("auth_data_IDX1");

                entity.HasIndex(e => new { e.Tag, e.DataItem })
                    .HasName("auth_data_IDX3");

                entity.HasIndex(e => new { e.Tag, e.Value })
                    .HasName("auth_data_IDX2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthHeaderId).HasColumnName("Auth_Header_ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataItem)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.Indicator1)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Indicator2)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.HasOne(d => d.AuthHeader)
                    .WithMany(p => p.AuthData)
                    .HasForeignKey(d => d.AuthHeaderId)
                    .HasConstraintName("auth_data_auth_header");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.AuthDataCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auth_data_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.AuthDataUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auth_data_updateby");
            });

            modelBuilder.Entity<AuthHeader>(entity =>
            {
                entity.ToTable("auth_header");

                entity.HasIndex(e => e.AuthId)
                    .HasName("auth_header_id")
                    .IsUnique();

                entity.HasIndex(e => e.CreateBy)
                    .HasName("auth_header_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("auth_header_updateby");

                entity.HasIndex(e => e.WorksheetId)
                    .HasName("auth_header_worksheet_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthId)
                    .IsRequired()
                    .HasColumnName("Auth_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IstilahDigunakan).HasColumnName("ISTILAH_DIGUNAKAN");

                entity.Property(e => e.IstilahTdkDigunakan).HasColumnName("ISTILAH_TDK_DIGUNAKAN");

                entity.Property(e => e.IstilahTerkait).HasColumnName("ISTILAH_TERKAIT");

                entity.Property(e => e.MarcLoc).HasColumnName("MARC_LOC");

                entity.Property(e => e.Quarantinedby).HasColumnName("QUARANTINEDBY");

                entity.Property(e => e.Quarantineddate).HasColumnName("QUARANTINEDDATE");

                entity.Property(e => e.Quarantinedterminal)
                    .HasColumnName("QUARANTINEDTERMINAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tanggalpembahasan)
                    .HasColumnName("TANGGALPEMBAHASAN")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorksheetId).HasColumnName("Worksheet_id");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.AuthHeaderCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auth_header_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.AuthHeaderUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auth_header_updateby");

                entity.HasOne(d => d.Worksheet)
                    .WithMany(p => p.AuthHeader)
                    .HasForeignKey(d => d.WorksheetId)
                    .HasConstraintName("auth_header_worksheet_id");
            });

            modelBuilder.Entity<AuthItem>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("auth_item");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("auth_item_createby");

                entity.HasIndex(e => e.RuleName)
                    .HasName("rule_name");

                entity.HasIndex(e => e.Type)
                    .HasName("idx-auth_item-type");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("auth_item_updateby");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.RuleName)
                    .HasColumnName("rule_name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.AuthItemCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auth_item_createby");

                entity.HasOne(d => d.RuleNameNavigation)
                    .WithMany(p => p.AuthItem)
                    .HasForeignKey(d => d.RuleName)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auth_item_ibfk_1");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.AuthItemUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auth_item_updateby");
            });

            modelBuilder.Entity<AuthItemChild>(entity =>
            {
                entity.HasKey(e => new { e.Parent, e.Child })
                    .HasName("PRIMARY");

                entity.ToTable("auth_item_child");

                entity.HasIndex(e => e.Child)
                    .HasName("child");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("auth_item_child_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("auth_item_child_updateby");

                entity.Property(e => e.Parent)
                    .HasColumnName("parent")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Child)
                    .HasColumnName("child")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ChildNavigation)
                    .WithMany(p => p.AuthItemChildChildNavigation)
                    .HasForeignKey(d => d.Child)
                    .HasConstraintName("auth_item_child_ibfk_2");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.AuthItemChildCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auth_item_child_createby");

                entity.HasOne(d => d.ParentNavigation)
                    .WithMany(p => p.AuthItemChildParentNavigation)
                    .HasForeignKey(d => d.Parent)
                    .HasConstraintName("auth_item_child_ibfk_1");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.AuthItemChildUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auth_item_child_updateby");
            });

            modelBuilder.Entity<AuthRule>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("auth_rule");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("auth_rule_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("auth_rule_updateby");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.AuthRuleCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auth_rule_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.AuthRuleUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("auth_rule_updateby");
            });

            modelBuilder.Entity<Bacaditempat>(entity =>
            {
                entity.ToTable("bacaditempat");

                entity.HasIndex(e => e.CollectionId)
                    .HasName("bacaditempat_collections");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("bacaditempat_createby");

                entity.HasIndex(e => e.LocationId)
                    .HasName("bacaditempat_locations");

                entity.HasIndex(e => e.MemberId)
                    .HasName("bacaditempat_Noanggota");

                entity.HasIndex(e => e.NoPengunjung)
                    .HasName("BacaDitempat_NoPengujung");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("bacaditempat_updateby");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CollectionId).HasColumnName("collection_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsReturn)
                    .HasColumnName("Is_return")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LocationId).HasColumnName("Location_Id");

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.NoPengunjung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.Bacaditempat)
                    .HasForeignKey(d => d.CollectionId)
                    .HasConstraintName("bacaditempat_collections");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.Bacaditempat)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("bacaditempat_createby");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Bacaditempat)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("bacaditempat_locations");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Bacaditempat)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("bacaditempat_members");
            });

            modelBuilder.Entity<BacaditempatLocations>(entity =>
            {
                entity.ToTable("bacaditempat_locations");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("checkpoint_locations_createby");

                entity.HasIndex(e => e.IpPc)
                    .HasName("bacaditempat_locations_ip");

                entity.HasIndex(e => e.LocationId)
                    .HasName("FK_logincheckpoint_locations");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("checkpoint_locations_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IpPc)
                    .IsRequired()
                    .HasColumnName("IP_PC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("Location_ID");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Backup>(entity =>
            {
                entity.ToTable("backup");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("backup_createby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackupType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileSize)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bibidavailable>(entity =>
            {
                entity.HasKey(e => e.Bibid)
                    .HasName("PRIMARY");

                entity.ToTable("bibidavailable");

                entity.HasIndex(e => e.Bibid)
                    .HasName("BIBID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.CreateBy)
                    .HasName("bibidavailable_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("bibidavailable_updateby");

                entity.Property(e => e.Bibid)
                    .HasColumnName("BIBID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.BibidavailableCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("bibidavailable_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.BibidavailableUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("bibidavailable_updateby");
            });

            modelBuilder.Entity<Bookinglogs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bookinglogs");

                entity.HasIndex(e => e.MemberId)
                    .HasName("fk_bookinglogs_memberId_idx");

                entity.Property(e => e.BookingDate).HasColumnName("bookingDate");

                entity.Property(e => e.BookingExpired).HasColumnName("bookingExpired");

                entity.Property(e => e.CollectionId).HasColumnName("collectionId");

                entity.Property(e => e.MemberId)
                    .HasColumnName("memberId")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bookmark>(entity =>
            {
                entity.ToTable("bookmark");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("bookmark_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("bookmark_updateby");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sesi).IsRequired();

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.BookmarkCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("bookmark_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.BookmarkUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("bookmark_updateby");
            });

            modelBuilder.Entity<Branchs>(entity =>
            {
                entity.ToTable("branchs");

                entity.HasIndex(e => e.Code)
                    .HasName("branchs_code");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("branchs_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("branchs_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.BranchsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("branchs_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.BranchsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("branchs_updateby");
            });

            modelBuilder.Entity<Cardformats>(entity =>
            {
                entity.ToTable("cardformats");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("cardformats_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("cardformats_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FontName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Verdana'");

                entity.Property(e => e.FontSize).HasDefaultValueSql("'12'");

                entity.Property(e => e.Height).HasDefaultValueSql("'400'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Width).HasDefaultValueSql("'400'");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CardformatsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("cardformats_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CardformatsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("cardformats_updateby");
            });

            modelBuilder.Entity<CatalogRuas>(entity =>
            {
                entity.ToTable("catalog_ruas");

                entity.HasIndex(e => e.CatalogId)
                    .HasName("catalog_ruas_catalogs_idx");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("catalog_ruas_createby_idx");

                entity.HasIndex(e => e.Tag)
                    .HasName("catalog_ruas_tag");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("catalog_ruas_updateby_idx");

                entity.HasIndex(e => new { e.CatalogId, e.Tag, e.Value })
                    .HasName("catalog_ruas_IDX1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Indicator1)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Indicator2)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("text");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.CatalogRuas)
                    .HasForeignKey(d => d.CatalogId)
                    .HasConstraintName("catalog_ruas_catalogs");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CatalogRuasCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("catalog_ruas_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CatalogRuasUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("catalog_ruas_updateby");
            });

            modelBuilder.Entity<CatalogSubruas>(entity =>
            {
                entity.ToTable("catalog_subruas");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("catalog_subruas_createby");

                entity.HasIndex(e => e.SubRuas)
                    .HasName("SubRuas");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("catalog_subruas_updateby");

                entity.HasIndex(e => e.Value)
                    .HasName("Catalog_Subruas_Value");

                entity.HasIndex(e => new { e.RuasId, e.SubRuas })
                    .HasName("RuasID_SubRuas");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RuasId).HasColumnName("RuasID");

                entity.Property(e => e.SubRuas)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("text");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CatalogSubruasCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("catalog_subruas_createby");

                entity.HasOne(d => d.Ruas)
                    .WithMany(p => p.CatalogSubruas)
                    .HasForeignKey(d => d.RuasId)
                    .HasConstraintName("catalog_subruas_ruas");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CatalogSubruasUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("catalog_subruas_updateby");
            });

            modelBuilder.Entity<Catalogfiles>(entity =>
            {
                entity.ToTable("catalogfiles");

                entity.HasIndex(e => e.CatalogId)
                    .HasName("catalogfiles_catalog");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("catalogfiles_createby");

                entity.HasIndex(e => e.FileFlash)
                    .HasName("catalogfiles_fileflash");

                entity.HasIndex(e => e.FileUrl)
                    .HasName("catalogfiles_fileurl");

                entity.HasIndex(e => e.IsPublish)
                    .HasName("catalogfiles_ispublish");

                entity.HasIndex(e => e.MemberId)
                    .HasName("catalogfiles_member_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("catalogfiles_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatalogId).HasColumnName("Catalog_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileFlash)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileUrl)
                    .HasColumnName("FileURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsFromMember)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsPublish).HasDefaultValueSql("'1'");

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.Catalogfiles)
                    .HasForeignKey(d => d.CatalogId)
                    .HasConstraintName("catalogfiles_catalog");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CatalogfilesCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("catalogfiles_createby");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Catalogfiles)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("catalogfiles_member");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CatalogfilesUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("catalogfiles_updateby");
            });

            modelBuilder.Entity<Catalogs>(entity =>
            {
                entity.ToTable("catalogs");

                entity.HasIndex(e => e.Author)
                    .HasName("catalogs_author");

                entity.HasIndex(e => e.Bibid)
                    .HasName("catalogs_BIBID")
                    .IsUnique();

                entity.HasIndex(e => e.BranchId)
                    .HasName("catalogs_Branch_id");

                entity.HasIndex(e => e.CallNumber)
                    .HasName("catalogs_callnumber");

                entity.HasIndex(e => e.ControlNumber)
                    .HasName("catalogs_controlnumber");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("catalogs_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("catalogs_createdate");

                entity.HasIndex(e => e.DeweyNo)
                    .HasName("catalogs_deweyno");

                entity.HasIndex(e => e.Edition)
                    .HasName("catalogs_edition");

                entity.HasIndex(e => e.IsOpac)
                    .HasName("catalogs_isopac");

                entity.HasIndex(e => e.Isbn)
                    .HasName("catalogs_isbn");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("catalogs_kii");

                entity.HasIndex(e => e.Languages)
                    .HasName("catalogs_languages");

                entity.HasIndex(e => e.MemberId)
                    .HasName("catalogs_member_idx");

                entity.HasIndex(e => e.PhysicalDescription)
                    .HasName("catalogs_physicaldesc");

                entity.HasIndex(e => e.Publikasi)
                    .HasName("catalogs_publikasi");

                entity.HasIndex(e => e.PublishLocation)
                    .HasName("catalogs_publishlocation");

                entity.HasIndex(e => e.PublishYear)
                    .HasName("catalogs_publishyear");

                entity.HasIndex(e => e.Publisher)
                    .HasName("catalogs_publisher");

                entity.HasIndex(e => e.Quarantinedby)
                    .HasName("catalogs_quarantinedby");

                entity.HasIndex(e => e.Subject)
                    .HasName("catalogs_subject");

                entity.HasIndex(e => e.Title)
                    .HasName("catalogs_title");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("catalogs_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("catalogs_updatedate");

                entity.HasIndex(e => e.WorksheetId)
                    .HasName("catalogs_Worksheet_id");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ApproveDateOpac).HasColumnName("ApproveDateOPAC");

                entity.Property(e => e.Author)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.Bibid)
                    .IsRequired()
                    .HasColumnName("BIBID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("Branch_id");

                entity.Property(e => e.CallNumber)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.ControlNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoverUrl)
                    .HasColumnName("CoverURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeweyNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Edition)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsBni)
                    .HasColumnName("IsBNI")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.IsKin)
                    .HasColumnName("IsKIN")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.IsOpac)
                    .HasColumnName("IsOPAC")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IsRda)
                    .HasColumnName("IsRDA")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Languages)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MarcLoc).HasColumnName("MARC_LOC");

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.PhysicalDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PreservasiId)
                    .HasColumnName("PRESERVASI_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Publikasi)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.PublishLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PublishYear)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Publisher)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Quarantinedby).HasColumnName("QUARANTINEDBY");

                entity.Property(e => e.Quarantineddate).HasColumnName("QUARANTINEDDATE");

                entity.Property(e => e.Quarantinedterminal)
                    .HasColumnName("QUARANTINEDTERMINAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorksheetId).HasColumnName("Worksheet_id");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Catalogs)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("catalogs_branch");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CatalogsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("catalogs_createby");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Catalogs)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("catalogs_member");

                entity.HasOne(d => d.QuarantinedbyNavigation)
                    .WithMany(p => p.CatalogsQuarantinedbyNavigation)
                    .HasForeignKey(d => d.Quarantinedby)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("catalogs_quarantinedby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CatalogsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("catalogs_updateby");

                entity.HasOne(d => d.Worksheet)
                    .WithMany(p => p.Catalogs)
                    .HasForeignKey(d => d.WorksheetId)
                    .HasConstraintName("catalogs_worksheet");
            });

            modelBuilder.Entity<Catalogstaging>(entity =>
            {
                entity.ToTable("catalogstaging");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("catalogstaging_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("catalogstaging_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Edition)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MarcLoc).HasColumnName("MARC_LOC");

                entity.Property(e => e.Publishment)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorksheetId)
                    .HasColumnName("Worksheet_id")
                    .HasDefaultValueSql("'1'");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CatalogstagingCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("catalogstaging_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CatalogstagingUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("catalogstaging_updateby");
            });

            modelBuilder.Entity<CheckpointLocations>(entity =>
            {
                entity.ToTable("checkpoint_locations");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("checkpoint_locations_createby");

                entity.HasIndex(e => e.IpPc)
                    .HasName("IP_PC")
                    .IsUnique();

                entity.HasIndex(e => e.LocationId)
                    .HasName("FK_logincheckpoint_locations");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("checkpoint_locations_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IpPc)
                    .IsRequired()
                    .HasColumnName("IP_PC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("Location_ID");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CheckpointLocationsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("checkpoint_locations_createby");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.CheckpointLocations)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_logincheckpoint_locations");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CheckpointLocationsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("checkpoint_locations_updateby");
            });

            modelBuilder.Entity<Collectioncategorys>(entity =>
            {
                entity.ToTable("collectioncategorys");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("collectioncategorys_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("collectioncategorys_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("collectioncategorys_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("collectioncategorys_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("collectioncategorys_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CollectioncategorysCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectioncategorys_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CollectioncategorysUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectioncategorys_updateby");
            });

            modelBuilder.Entity<Collectioncategorysdefault>(entity =>
            {
                entity.ToTable("collectioncategorysdefault");

                entity.HasIndex(e => e.CollectionCategoryId)
                    .HasName("collectioncategorysdefault_category");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("collectioncategorysdefault_createby");

                entity.HasIndex(e => e.JenisAnggotaId)
                    .HasName("collectioncategorysdefault_jenis_anggota");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("collectioncategorysdefault_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CollectionCategoryId).HasColumnName("CollectionCategory_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JenisAnggotaId).HasColumnName("JenisAnggota_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CollectionCategory)
                    .WithMany(p => p.Collectioncategorysdefault)
                    .HasForeignKey(d => d.CollectionCategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("collectioncategorysdefault_category");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CollectioncategorysdefaultCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectioncategorysdefault_createby");

                entity.HasOne(d => d.JenisAnggota)
                    .WithMany(p => p.Collectioncategorysdefault)
                    .HasForeignKey(d => d.JenisAnggotaId)
                    .HasConstraintName("collectioncategorysdefault_jenis_anggota");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CollectioncategorysdefaultUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectioncategorysdefault_updateby");
            });

            modelBuilder.Entity<Collectioncategorysloanhari>(entity =>
            {
                entity.HasKey(e => e.DataId)
                    .HasName("PRIMARY");

                entity.ToTable("collectioncategorysloanhari");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("collectioncategorysloanhari_category_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("collectioncategorysloanhari_createby");

                entity.HasIndex(e => e.PeminjamanHariId)
                    .HasName("collectioncategorysloanhari_peminjaman_hari_id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("collectioncategorysloanhari_updateby");

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PeminjamanHariId).HasColumnName("Peminjaman_hari_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Collectioncategorysloanhari)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("collectioncategorysloanhari_category_id");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CollectioncategorysloanhariCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectioncategorysloanhari_createby");

                entity.HasOne(d => d.PeminjamanHari)
                    .WithMany(p => p.Collectioncategorysloanhari)
                    .HasForeignKey(d => d.PeminjamanHariId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("collectioncategorysloanhari_peminjaman_hari_id");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CollectioncategorysloanhariUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectioncategorysloanhari_updateby");
            });

            modelBuilder.Entity<Collectionloanextends>(entity =>
            {
                entity.ToTable("collectionloanextends");

                entity.HasIndex(e => e.CollectionId)
                    .HasName("collectionloanextends_col_idx");

                entity.HasIndex(e => e.CollectionLoanId)
                    .HasName("collectionloanextends_colloan_idx");

                entity.HasIndex(e => e.CollectionLoanItemId)
                    .HasName("collectionloanextends_colloanitem_idx");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("collectionloanextends_createby_idx");

                entity.HasIndex(e => e.MemberId)
                    .HasName("collectionloanextends_member_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("collectionloanextends_updateby_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CollectionId).HasColumnName("Collection_id");

                entity.Property(e => e.CollectionLoanId)
                    .IsRequired()
                    .HasColumnName("CollectionLoan_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionLoanItemId).HasColumnName("CollectionLoanItem_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.Collectionloanextends)
                    .HasForeignKey(d => d.CollectionId)
                    .HasConstraintName("collectionloanextends_col");

                entity.HasOne(d => d.CollectionLoan)
                    .WithMany(p => p.Collectionloanextends)
                    .HasForeignKey(d => d.CollectionLoanId)
                    .HasConstraintName("collectionloanextends_colloan");

                entity.HasOne(d => d.CollectionLoanItem)
                    .WithMany(p => p.Collectionloanextends)
                    .HasForeignKey(d => d.CollectionLoanItemId)
                    .HasConstraintName("collectionloanextends_colloanitem");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CollectionloanextendsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionloanextends_createby");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Collectionloanextends)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("collectionloanextends_member");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CollectionloanextendsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionloanextends_updateby");
            });

            modelBuilder.Entity<Collectionloanitems>(entity =>
            {
                entity.ToTable("collectionloanitems");

                entity.HasIndex(e => e.ActualReturn)
                    .HasName("collectionloanitems_actualreturn");

                entity.HasIndex(e => e.CollectionId)
                    .HasName("collectionloanitems_collections");

                entity.HasIndex(e => e.CollectionLoanId)
                    .HasName("collectionloanitems_collectionloans");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("collectionloanitems_createby");

                entity.HasIndex(e => e.DueDate)
                    .HasName("collectionloanitems_duedate");

                entity.HasIndex(e => e.LoanDate)
                    .HasName("collectionloanitems_LoanDate");

                entity.HasIndex(e => e.LoanStatus)
                    .HasName("collectionloanitems_LoanStatus");

                entity.HasIndex(e => e.MemberId)
                    .HasName("collectionloanitems_members");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("collectionloanitems_updateby");

                entity.HasIndex(e => new { e.LoanDate, e.MemberId })
                    .HasName("collectionloanitems_idx1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CollectionId).HasColumnName("Collection_id");

                entity.Property(e => e.CollectionLoanId)
                    .IsRequired()
                    .HasColumnName("CollectionLoan_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.LoanStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("member_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.Collectionloanitems)
                    .HasForeignKey(d => d.CollectionId)
                    .HasConstraintName("collectionloanitems_col");

                entity.HasOne(d => d.CollectionLoan)
                    .WithMany(p => p.Collectionloanitems)
                    .HasForeignKey(d => d.CollectionLoanId)
                    .HasConstraintName("collectionloanitems_colloan");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CollectionloanitemsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionloanitems_createby");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Collectionloanitems)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("collectionloanitems_members");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CollectionloanitemsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionloanitems_updateby");
            });

            modelBuilder.Entity<Collectionloans>(entity =>
            {
                entity.ToTable("collectionloans");

                entity.HasIndex(e => e.BranchId)
                    .HasName("Branch_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("collectionloans_createby");

                entity.HasIndex(e => e.LocationLibraryId)
                    .HasName("FK_collectionloans_location_library");

                entity.HasIndex(e => e.MemberId)
                    .HasName("Member_id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("collectionloans_updateby");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("Branch_id");

                entity.Property(e => e.CollectionCount).HasDefaultValueSql("'0'");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExtendCount).HasDefaultValueSql("'0'");

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.LateCount).HasDefaultValueSql("'0'");

                entity.Property(e => e.LoanCount).HasDefaultValueSql("'0'");

                entity.Property(e => e.LocationLibraryId).HasColumnName("LocationLibrary_id");

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.ReturnCount).HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Collectionloans)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FKA5D300396ADC8006");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CollectionloansCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionloans_createby");

                entity.HasOne(d => d.LocationLibrary)
                    .WithMany(p => p.Collectionloans)
                    .HasForeignKey(d => d.LocationLibraryId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_collectionloans_location_library");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Collectionloans)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FKA5D300395DD8E7A8");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CollectionloansUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionloans_updateby");
            });

            modelBuilder.Entity<Collectionlocations>(entity =>
            {
                entity.ToTable("collectionlocations");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("collectionlocations_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("collectionlocations_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CollectionlocationsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionlocations_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CollectionlocationsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionlocations_updateby");
            });

            modelBuilder.Entity<Collectionmedias>(entity =>
            {
                entity.ToTable("collectionmedias");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("collectionmedias_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("collectionmedias_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("collectionmedias_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("collectionmedias_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("collectionmedias_updatedate");

                entity.HasIndex(e => e.WorksheetId)
                    .HasName("collectionmedias_worksheet");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorksheetId).HasColumnName("Worksheet_id");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CollectionmediasCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionmedias_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CollectionmediasUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionmedias_updateby");

                entity.HasOne(d => d.Worksheet)
                    .WithMany(p => p.Collectionmedias)
                    .HasForeignKey(d => d.WorksheetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("collectionmedias_worksheet");
            });

            modelBuilder.Entity<Collectionrules>(entity =>
            {
                entity.ToTable("collectionrules");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("collectionrules_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("collectionrules_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("collectionrules_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("collectionrules_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("collectionrules_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CollectionrulesCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionrules_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CollectionrulesUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionrules_updateby");
            });

            modelBuilder.Entity<Collectionrulesitems>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("collectionrulesitems");

                entity.HasIndex(e => e.CollectionRulesId)
                    .HasName("CollectionRules_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("collectionrulesitems_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("collectionrulesitems_updateby");

                entity.Property(e => e.CollectionRulesId).HasColumnName("CollectionRules_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SuspendDays).HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CollectionRules)
                    .WithMany()
                    .HasForeignKey(d => d.CollectionRulesId)
                    .HasConstraintName("FKA288C9A1451A301A");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionrulesitems_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionrulesitems_updateby");
            });

            modelBuilder.Entity<Collections>(entity =>
            {
                entity.ToTable("collections");

                entity.HasIndex(e => e.BranchId)
                    .HasName("Branch_id");

                entity.HasIndex(e => e.CallNumber)
                    .HasName("collections_callnumber");

                entity.HasIndex(e => e.CatalogId)
                    .HasName("Catalog_id");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("Category_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("collections_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("collections_createdate");

                entity.HasIndex(e => e.Currency)
                    .HasName("collections_currency");

                entity.HasIndex(e => e.Edisiserial)
                    .HasName("collections_edisiserial");

                entity.HasIndex(e => e.Idjilid)
                    .HasName("collections_idjilid");

                entity.HasIndex(e => e.Jilidcreateby)
                    .HasName("collections_jilidcreateby");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("collections_kii");

                entity.HasIndex(e => e.LocationId)
                    .HasName("Location_id");

                entity.HasIndex(e => e.LocationLibraryId)
                    .HasName("collections_location_library_idx");

                entity.HasIndex(e => e.MediaId)
                    .HasName("Media_id");

                entity.HasIndex(e => e.NoInduk)
                    .HasName("collections_NoInduk");

                entity.HasIndex(e => e.NomorBarcode)
                    .HasName("collections_NomorBarcode")
                    .IsUnique();

                entity.HasIndex(e => e.Nomorpanggiljilid)
                    .HasName("collections_nopanggiljilid");

                entity.HasIndex(e => e.PartnerId)
                    .HasName("Partner_id");

                entity.HasIndex(e => e.Quarantinedby)
                    .HasName("collections_quarantinedby");

                entity.HasIndex(e => e.Rfid)
                    .HasName("collections_rfid");

                entity.HasIndex(e => e.RuleId)
                    .HasName("Rule_id");

                entity.HasIndex(e => e.SourceId)
                    .HasName("Source_id");

                entity.HasIndex(e => e.StatusId)
                    .HasName("collections_status");

                entity.HasIndex(e => e.TanggalPengadaan)
                    .HasName("collections_tanggalpengadaan");

                entity.HasIndex(e => e.Tglentryjilid)
                    .HasName("collections_tglentryjilid");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("collections_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("collections_updatedate");

                entity.HasIndex(e => new { e.Idjilid, e.Nomorpanggiljilid, e.CatalogId })
                    .HasName("collections_jilid1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BahanSertaan)
                    .HasColumnName("BAHAN_SERTAAN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BookingMemberId)
                    .HasColumnName("BookingMemberID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("Branch_id");

                entity.Property(e => e.CallNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CatalogId).HasColumnName("Catalog_id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Edisiserial)
                    .HasColumnName("EDISISERIAL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idjilid)
                    .HasColumnName("IDJILID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsVerified)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Isopac)
                    .HasColumnName("ISOPAC")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Isreferensi)
                    .HasColumnName("ISREFERENSI")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Jilidcreateby).HasColumnName("JILIDCREATEBY");

                entity.Property(e => e.KeteranganLain)
                    .HasColumnName("KETERANGAN_LAIN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KeteranganSumber)
                    .HasColumnName("Keterangan_Sumber")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.LocationId).HasColumnName("Location_id");

                entity.Property(e => e.LocationLibraryId).HasColumnName("Location_Library_id");

                entity.Property(e => e.MediaId).HasColumnName("Media_id");

                entity.Property(e => e.NoInduk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nojilid).HasColumnName("NOJILID");

                entity.Property(e => e.NomorBarcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nomorpanggiljilid)
                    .HasColumnName("NOMORPANGGILJILID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerId).HasColumnName("Partner_id");

                entity.Property(e => e.Price).HasColumnType("decimal(10,0)");

                entity.Property(e => e.PriceType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Quarantinedby).HasColumnName("QUARANTINEDBY");

                entity.Property(e => e.Quarantineddate)
                    .HasColumnName("QUARANTINEDDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Quarantinedterminal)
                    .HasColumnName("QUARANTINEDTERMINAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rfid)
                    .HasColumnName("RFID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RuleId).HasColumnName("Rule_id");

                entity.Property(e => e.SourceId).HasColumnName("Source_id");

                entity.Property(e => e.StatusId)
                    .HasColumnName("Status_id")
                    .HasDefaultValueSql("'9'");

                entity.Property(e => e.TanggalTerbitEdisiSerial)
                    .HasColumnName("TANGGAL_TERBIT_EDISI_SERIAL")
                    .HasColumnType("date");

                entity.Property(e => e.Tglentryjilid)
                    .HasColumnName("TGLENTRYJILID")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("collections_branch");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("collections_catalog");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("collections_category");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CollectionsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collections_createby");

                entity.HasOne(d => d.CurrencyNavigation)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.Currency)
                    .HasConstraintName("collections_currency");

                entity.HasOne(d => d.JilidcreatebyNavigation)
                    .WithMany(p => p.CollectionsJilidcreatebyNavigation)
                    .HasForeignKey(d => d.Jilidcreateby)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collections_jilidcreateby");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("collections_location");

                entity.HasOne(d => d.LocationLibrary)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.LocationLibraryId)
                    .HasConstraintName("collections_location_library");

                entity.HasOne(d => d.Media)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.MediaId)
                    .HasConstraintName("collections_media");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("collections_partner");

                entity.HasOne(d => d.QuarantinedbyNavigation)
                    .WithMany(p => p.CollectionsQuarantinedbyNavigation)
                    .HasForeignKey(d => d.Quarantinedby)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collections_quarantinedby");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("collections_rule");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.SourceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("collections_source");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("collections_status");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CollectionsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collections_updateby");
            });

            modelBuilder.Entity<Collectionsources>(entity =>
            {
                entity.ToTable("collectionsources");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("collectionsources_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("collectionsources_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("collectionsources_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("collectionsources_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("collectionsources_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CollectionsourcesCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionsources_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CollectionsourcesUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionsources_updateby");
            });

            modelBuilder.Entity<Collectionstatus>(entity =>
            {
                entity.ToTable("collectionstatus");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("collectionstatus_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("collectionstatus_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("collectionstatus_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("collectionstatus_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("collectionstatus_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CollectionstatusCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionstatus_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CollectionstatusUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("collectionstatus_updateby");
            });

            modelBuilder.Entity<Colloclib>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("colloclib");

                entity.HasIndex(e => e.ColId)
                    .HasName("Col_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("colloclib_createby");

                entity.HasIndex(e => e.LocLibId)
                    .HasName("LocLib_id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("colloclib_updateby");

                entity.Property(e => e.ColId).HasColumnName("Col_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocLibId).HasColumnName("LocLib_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Col)
                    .WithMany()
                    .HasForeignKey(d => d.ColId)
                    .HasConstraintName("FK_colloclib_col");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("colloclib_createby");

                entity.HasOne(d => d.LocLib)
                    .WithMany()
                    .HasForeignKey(d => d.LocLibId)
                    .HasConstraintName("FK_colloclib_loclib");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("colloclib_updateby");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.Currency1)
                    .HasName("PRIMARY");

                entity.ToTable("currency");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("currency_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("currency_createdate");

                entity.HasIndex(e => e.Currency1)
                    .HasName("CURRENCY_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("currency_kii");

                entity.HasIndex(e => e.SortId)
                    .HasName("currency_sortno");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("currency_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("currency_updatedate");

                entity.Property(e => e.Currency1)
                    .HasColumnName("Currency")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.SortId)
                    .HasColumnName("Sort_ID")
                    .HasDefaultValueSql("'999'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.CurrencyCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("currency_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.CurrencyUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("currency_updateby");
            });

            modelBuilder.Entity<Daemons>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("daemons");

                entity.Property(e => e.Info).IsRequired();

                entity.Property(e => e.Start).IsRequired();
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.ToTable("departments");

                entity.HasIndex(e => e.Code)
                    .HasName("Code")
                    .IsUnique();

                entity.HasIndex(e => e.CreateBy)
                    .HasName("departments_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("departments_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("departments_kii");

                entity.HasIndex(e => e.ParentId)
                    .HasName("ParentID");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("departments_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("departments_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.DepartmentsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("departments_createby");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FKFE0DEFC7922003A1");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.DepartmentsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("departments_updateby");
            });

            modelBuilder.Entity<DjknData>(entity =>
            {
                entity.ToTable("djkn_data");

                entity.HasIndex(e => e.CollectionId)
                    .HasName("djkn_data_collection_idx");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("djkn_data_createby_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("djkn_data_updateby_idx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Binding)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BookSize)
                    .HasColumnName("Book_Size")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionId).HasColumnName("Collection_id");

                entity.Property(e => e.ConditionBook)
                    .HasColumnName("Condition_Book")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionsOutdated)
                    .HasColumnName("Conditions_Outdated")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cover)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FinishingCover)
                    .HasColumnName("Finishing_Cover")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinishingHardCover)
                    .HasColumnName("Finishing_HardCover")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullColor)
                    .HasColumnName("FULL_COLOR")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaperType)
                    .HasColumnName("Paper_Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPage)
                    .HasColumnName("Total_Page")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.DjknData)
                    .HasForeignKey(d => d.CollectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("djkn_data_collection");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.DjknDataCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("djkn_data_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.DjknDataUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("djkn_data_updateby");
            });

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.ToTable("favorite");

                entity.HasIndex(e => e.CatalogId)
                    .HasName("FK_Catalog");

                entity.HasIndex(e => e.MemberId)
                    .HasName("FK_members");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CatalogId).HasColumnName("Catalog_Id");

                entity.Property(e => e.MemberId)
                    .HasColumnName("Member_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.Favorite)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Catalog");
            });

            modelBuilder.Entity<Fielddatas>(entity =>
            {
                entity.HasKey(e => new { e.FieldId, e.Code })
                    .HasName("PRIMARY");

                entity.ToTable("fielddatas");

                entity.HasIndex(e => e.Code)
                    .HasName("fielddatas_code");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("fielddatas_createby");

                entity.HasIndex(e => e.Delimiter)
                    .HasName("fielddatas_delimiter");

                entity.HasIndex(e => e.FieldId)
                    .HasName("fielddatas_fieldid");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("fielddatas_updateby");

                entity.Property(e => e.FieldId).HasColumnName("Field_id");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Delimiter)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsShow)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Repeatable)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.SortNo).HasDefaultValueSql("'99'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.FielddatasCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fielddatas_createby");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.Fielddatas)
                    .HasForeignKey(d => d.FieldId)
                    .HasConstraintName("fielddatas_fieldid");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.FielddatasUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fielddatas_updateby");
            });

            modelBuilder.Entity<Fieldgroups>(entity =>
            {
                entity.ToTable("fieldgroups");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("fieldgroups_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("fieldgroups_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.FieldgroupsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fieldgroups_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.FieldgroupsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fieldgroups_updateby");
            });

            modelBuilder.Entity<Fieldindicator1s>(entity =>
            {
                entity.HasKey(e => new { e.FieldId, e.Code })
                    .HasName("PRIMARY");

                entity.ToTable("fieldindicator1s");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("fieldindicator1s_createby");

                entity.HasIndex(e => e.FieldId)
                    .HasName("Field_id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("fieldindicator1s_updateby");

                entity.Property(e => e.FieldId).HasColumnName("Field_id");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.Fieldindicator1sCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fieldindicator1s_createby");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.Fieldindicator1s)
                    .HasForeignKey(d => d.FieldId)
                    .HasConstraintName("FKBC43AFA166DFF9B4");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.Fieldindicator1sUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fieldindicator1s_updateby");
            });

            modelBuilder.Entity<Fieldindicator2s>(entity =>
            {
                entity.HasKey(e => new { e.FieldId, e.Code })
                    .HasName("PRIMARY");

                entity.ToTable("fieldindicator2s");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("fieldindicator2s_createby");

                entity.HasIndex(e => e.FieldId)
                    .HasName("Field_id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("fieldindicator2s_updateby");

                entity.Property(e => e.FieldId).HasColumnName("Field_id");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.Fieldindicator2sCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fieldindicator2s_createby");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.Fieldindicator2s)
                    .HasForeignKey(d => d.FieldId)
                    .HasConstraintName("FKBC43AFA066DFF9B4");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.Fieldindicator2sUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fieldindicator2s_updateby");
            });

            modelBuilder.Entity<Fields>(entity =>
            {
                entity.ToTable("fields");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("fields_createby");

                entity.HasIndex(e => e.FormatId)
                    .HasName("Format_id");

                entity.HasIndex(e => e.GroupId)
                    .HasName("Group_id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("fields_updateby");

                entity.HasIndex(e => new { e.Tag, e.FormatId })
                    .HasName("UQ_Tag")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Defaultsubtag)
                    .HasColumnName("DEFAULTSUBTAG")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'a'");

                entity.Property(e => e.Enabled).HasColumnType("bit(1)");

                entity.Property(e => e.Fixed).HasColumnType("bit(1)");

                entity.Property(e => e.FormatId).HasColumnName("Format_id");

                entity.Property(e => e.GroupId).HasColumnName("Group_id");

                entity.Property(e => e.IsCustomable).HasColumnType("bit(1)");

                entity.Property(e => e.Issubserial)
                    .HasColumnName("ISSUBSERIAL")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Mandatory).HasColumnType("bit(1)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Repeatable).HasColumnType("bit(1)");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.FieldsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fields_createby");

                entity.HasOne(d => d.Format)
                    .WithMany(p => p.Fields)
                    .HasForeignKey(d => d.FormatId)
                    .HasConstraintName("fields_format");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Fields)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("fields_fieldgroup");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.FieldsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fields_updateby");
            });

            modelBuilder.Entity<Formats>(entity =>
            {
                entity.ToTable("formats");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("formats_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("formats_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.FormatsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("formats_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.FormatsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("formats_updateby");
            });

            modelBuilder.Entity<Gammu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gammu");
            });

            modelBuilder.Entity<Groupguesses>(entity =>
            {
                entity.ToTable("groupguesses");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("groupguesses_createby");

                entity.HasIndex(e => e.LocationId)
                    .HasName("groupguesses_locations");

                entity.HasIndex(e => e.LocationLoansId)
                    .HasName("groupguesses_loclib_idx");

                entity.HasIndex(e => e.TujuanKunjunganId)
                    .HasName("groupguesses_tujuankunjungan_fk");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("groupguesses_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlamatInstansi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AsalInstansi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CountPns).HasColumnName("CountPNS");

                entity.Property(e => e.CountPswasta).HasColumnName("CountPSwasta");

                entity.Property(e => e.CountSd).HasColumnName("CountSD");

                entity.Property(e => e.CountSma).HasColumnName("CountSMA");

                entity.Property(e => e.CountSmp).HasColumnName("CountSMP");

                entity.Property(e => e.CountTni).HasColumnName("CountTNI");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailInstansi)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Information)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("Location_ID");

                entity.Property(e => e.LocationLoansId).HasColumnName("LocationLoans_ID");

                entity.Property(e => e.NamaKetua)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoPengunjung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomerTelponKetua)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TeleponInstansi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TujuanKunjunganId).HasColumnName("TujuanKunjungan_ID");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.GroupguessesCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("groupguesses_createby");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Groupguesses)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("groupguesses_locations");

                entity.HasOne(d => d.LocationLoans)
                    .WithMany(p => p.Groupguesses)
                    .HasForeignKey(d => d.LocationLoansId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("groupguesses_loclib");

                entity.HasOne(d => d.TujuanKunjungan)
                    .WithMany(p => p.Groupguesses)
                    .HasForeignKey(d => d.TujuanKunjunganId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("groupguesses_tujuankunjungan_fk");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.GroupguessesUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("groupguesses_updateby");
            });

            modelBuilder.Entity<Historydata>(entity =>
            {
                entity.ToTable("historydata");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("historydata_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("historydata_createdate");

                entity.HasIndex(e => e.MemberId)
                    .HasName("historydata_member_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("historydata_updateby");

                entity.HasIndex(e => new { e.TableName, e.Idref, e.Action })
                    .HasName("historydata_IDX1");

                entity.HasIndex(e => new { e.TableName, e.Action, e.CreateBy, e.CreateDate })
                    .HasName("historydata_IDX2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idref)
                    .IsRequired()
                    .HasColumnName("IDRef")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.HistorydataCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("historydata_createby");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Historydata)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("historydata_member");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.HistorydataUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("historydata_updateby");
            });

            modelBuilder.Entity<Holidays>(entity =>
            {
                entity.ToTable("holidays");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("holidays_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("holidays_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.HolidaysCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("holidays_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.HolidaysUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("holidays_updateby");
            });

            modelBuilder.Entity<Inbox>(entity =>
            {
                entity.ToTable("inbox");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Class).HasDefaultValueSql("'-1'");

                entity.Property(e => e.Coding)
                    .IsRequired()
                    .HasColumnType("enum('Default_No_Compression','Unicode_No_Compression','8bit','Default_Compression','Unicode_Compression')")
                    .HasDefaultValueSql("'Default_No_Compression'");

                entity.Property(e => e.Processed)
                    .IsRequired()
                    .HasColumnType("enum('false','true')")
                    .HasDefaultValueSql("'false'");

                entity.Property(e => e.ReceivingDateTime).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.RecipientId)
                    .IsRequired()
                    .HasColumnName("RecipientID");

                entity.Property(e => e.SenderNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Smscnumber)
                    .IsRequired()
                    .HasColumnName("SMSCNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.TextDecoded).IsRequired();

                entity.Property(e => e.Udh)
                    .IsRequired()
                    .HasColumnName("UDH");

                entity.Property(e => e.UpdatedInDb)
                    .HasColumnName("UpdatedInDB")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<JenisAnggota>(entity =>
            {
                entity.ToTable("jenis_anggota");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("jenis_anggota_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("jenis_anggota_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("jenis_anggota_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("jenis_anggota_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("jenis_anggota_updatedate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BiayaPendaftaran)
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BiayaPerpanjangan)
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CountPerpanjang).HasDefaultValueSql("'0'");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DayPerpanjang).HasDefaultValueSql("'0'");

                entity.Property(e => e.DaySuspend).HasDefaultValueSql("'0'");

                entity.Property(e => e.DendaPerTenor)
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DendaTenorJumlah).HasDefaultValueSql("'0'");

                entity.Property(e => e.DendaTenorMultiply).HasDefaultValueSql("'1'");

                entity.Property(e => e.DendaTenorSatuan)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Hari'");

                entity.Property(e => e.DendaType)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Konstan'");

                entity.Property(e => e.Jenisanggota1)
                    .IsRequired()
                    .HasColumnName("jenisanggota")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.MasaBerlakuAnggota).HasDefaultValueSql("'365'");

                entity.Property(e => e.MaxLoanDays).HasDefaultValueSql("'0'");

                entity.Property(e => e.MaxPinjamKoleksi).HasDefaultValueSql("'1000'");

                entity.Property(e => e.SuspendMember)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.SuspendTenorJumlah).HasDefaultValueSql("'0'");

                entity.Property(e => e.SuspendTenorMultiply).HasDefaultValueSql("'1'");

                entity.Property(e => e.SuspendTenorSatuan)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Hari'");

                entity.Property(e => e.SuspendType)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Konstan'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UploadDokumenKeanggotaanOnline)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.WarningLoanDueDay).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.JenisAnggotaCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("jenis_anggota_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.JenisAnggotaUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("jenis_anggota_updateby");
            });

            modelBuilder.Entity<JenisDenda>(entity =>
            {
                entity.ToTable("jenis_denda");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("jenis_denda_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("jenis_denda_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.JenisDendaCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("jenis_denda_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.JenisDendaUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("jenis_denda_updateby");
            });

            modelBuilder.Entity<JenisKelamin>(entity =>
            {
                entity.ToTable("jenis_kelamin");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("jenis_kelamin_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("jenis_kelamin_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.JenisKelaminCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("jenis_kelamin_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.JenisKelaminUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("jenis_kelamin_updateby");
            });

            modelBuilder.Entity<JenisPelanggaran>(entity =>
            {
                entity.ToTable("jenis_pelanggaran");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("jenis_pelanggaran_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("jenis_pelanggaran_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JenisPelanggaran1)
                    .IsRequired()
                    .HasColumnName("JenisPelanggaran")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.JenisPelanggaranCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("jenis_pelanggaran_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.JenisPelanggaranUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("jenis_pelanggaran_updateby");
            });

            modelBuilder.Entity<JenisPermohonan>(entity =>
            {
                entity.ToTable("jenis_permohonan");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("jenis_permohonan_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("jenis_permohonan_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.JenisPermohonanCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("jenis_permohonan_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.JenisPermohonanUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("jenis_permohonan_updateby");
            });

            modelBuilder.Entity<JenisPerpustakaan>(entity =>
            {
                entity.ToTable("jenis_perpustakaan");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("jenis_perpustakaan_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("jenis_perpustakaan_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.JenisPerpustakaanCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("jenis_perpustakaan_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.JenisPerpustakaanUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("jenis_perpustakaan_updateby");
            });

            modelBuilder.Entity<JudulKoleksi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("judul_koleksi");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("judul_koleksi_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("judul_koleksi_updateby");

                entity.Property(e => e.Bibliografi)
                    .HasColumnName("bibliografi")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Catatan)
                    .HasColumnName("catatan")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EdCet)
                    .HasColumnName("ed_cet")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Indeks)
                    .HasColumnName("indeks")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Isbn)
                    .HasColumnName("isbn")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JudulPernyataan)
                    .IsRequired()
                    .HasColumnName("judul_pernyataan")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Kolasi).HasColumnName("kolasi");

                entity.Property(e => e.Kota)
                    .HasColumnName("kota")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.NoClass)
                    .HasColumnName("no_class")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoInduk)
                    .HasColumnName("no_induk")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoPanggil)
                    .HasColumnName("no_panggil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Penerbit)
                    .HasColumnName("penerbit")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pengarang)
                    .HasColumnName("pengarang")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subjek1)
                    .HasColumnName("subjek1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subjek2)
                    .HasColumnName("subjek2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subjek3)
                    .HasColumnName("subjek3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subjek4)
                    .HasColumnName("subjek4")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tahun).HasColumnName("tahun");

                entity.Property(e => e.Tet1)
                    .HasColumnName("tet1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tet2)
                    .HasColumnName("tet2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tet3)
                    .HasColumnName("tet3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("judul_koleksi_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("judul_koleksi_updateby");
            });

            modelBuilder.Entity<Kabupaten>(entity =>
            {
                entity.ToTable("kabupaten");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("kabupaten_createby");

                entity.HasIndex(e => e.NamaKab)
                    .HasName("kabupaten_nama");

                entity.HasIndex(e => e.PropinsiId)
                    .HasName("kabupaten_propinsi");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("kabupaten_updateby");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamaKab)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropinsiId).HasColumnName("PropinsiID");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.KabupatenCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("kabupaten_createby");

                entity.HasOne(d => d.Propinsi)
                    .WithMany(p => p.Kabupaten)
                    .HasForeignKey(d => d.PropinsiId)
                    .HasConstraintName("kabupaten_propinsi");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.KabupatenUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("kabupaten_updateby");
            });

            modelBuilder.Entity<KataSandang>(entity =>
            {
                entity.ToTable("kata_sandang");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("kata_sandang_createby");

                entity.HasIndex(e => e.Name)
                    .HasName("kata_sandang_name");

                entity.HasIndex(e => e.Tag)
                    .HasName("kata_sandang_tag");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("kata_sandang_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JumlahKarakter).HasDefaultValueSql("'1'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.KataSandangCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("kata_sandang_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.KataSandangUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("kata_sandang_updateby");
            });

            modelBuilder.Entity<KelasSiswa>(entity =>
            {
                entity.ToTable("kelas_siswa");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("kelas_siswa_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("kelas_siswa_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("kelas_siswa_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("kelas_siswa_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("kelas_siswa_updatedate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Namakelassiswa)
                    .IsRequired()
                    .HasColumnName("namakelassiswa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.KelasSiswaCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("kelas_siswa_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.KelasSiswaUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("kelas_siswa_updateby");
            });

            modelBuilder.Entity<KelompokPelanggaran>(entity =>
            {
                entity.ToTable("kelompok_pelanggaran");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("kelompok_pelanggaran_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("kelompok_pelanggaran_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Jumlah)
                    .HasDefaultValueSql("'0'")
                    .HasComment("JumlahPelanggaran");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuspendMember)
                    .HasColumnType("tinyint unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Warna)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.KelompokPelanggaranCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("kelompok_pelanggaran_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.KelompokPelanggaranUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("kelompok_pelanggaran_updateby");
            });

            modelBuilder.Entity<KeranjangAnggota>(entity =>
            {
                entity.ToTable("keranjang_anggota");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("keranjang_anggota_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("keranjang_anggota_createdate");

                entity.HasIndex(e => e.MemberId)
                    .HasName("keranjang_anggota_member_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("keranjang_anggota_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("keranjang_anggota_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.KeranjangAnggotaCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("keranjang_anggota_createby");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.KeranjangAnggota)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("keranjang_anggota_members");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.KeranjangAnggotaUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("keranjang_anggota_updateby");
            });

            modelBuilder.Entity<KeranjangKatalog>(entity =>
            {
                entity.ToTable("keranjang_katalog");

                entity.HasIndex(e => e.CatalogId)
                    .HasName("keranjang_katalog_catalog_idx");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("keranjang_katalog_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("keranjang_katalog_createdate");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("keranjang_katalog_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("keranjang_katalog_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatalogId).HasColumnName("Catalog_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.KeranjangKatalog)
                    .HasForeignKey(d => d.CatalogId)
                    .HasConstraintName("keranjang_katalog_catalogs");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.KeranjangKatalogCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("keranjang_katalog_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.KeranjangKatalogUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("keranjang_katalog_updateby");
            });

            modelBuilder.Entity<KeranjangKoleksi>(entity =>
            {
                entity.ToTable("keranjang_koleksi");

                entity.HasIndex(e => e.CollectionId)
                    .HasName("keranjang_koleksi_collection_idx");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("keranjang_koleksi_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("keranjang_koleksi_createdate");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("keranjang_koleksi_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("keranjang_koleksi_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CollectionId).HasColumnName("Collection_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.KeranjangKoleksi)
                    .HasForeignKey(d => d.CollectionId)
                    .HasConstraintName("keranjang_koleksi_collection");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.KeranjangKoleksiCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("keranjang_koleksi_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.KeranjangKoleksiUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("keranjang_koleksi_updateby");
            });

            modelBuilder.Entity<KriteriaKoleksi>(entity =>
            {
                entity.ToTable("kriteria_koleksi");

                entity.HasIndex(e => e.CatalogId)
                    .HasName("kriteria_koleksi_idx1");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("kriteria_koleksi_createby_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("kriteria_koleksi_updateby_idx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlamatImage)
                    .HasColumnName("alamat_image")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CatalogId).HasColumnName("catalog_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsLkd)
                    .HasColumnName("isLKD")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JnsKriteria)
                    .IsRequired()
                    .HasColumnName("jns_kriteria")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PublishYear)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorksheetName)
                    .HasColumnName("worksheet_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.KriteriaKoleksi)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("kriteria_koleksi_catalogby");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.KriteriaKoleksiCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("kriteria_koleksi_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.KriteriaKoleksiUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("kriteria_koleksi_updateby");
            });

            modelBuilder.Entity<Library>(entity =>
            {
                entity.ToTable("library");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("library_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("library_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Databasename)
                    .HasColumnName("DATABASENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fullname)
                    .HasColumnName("FULLNAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Port)
                    .HasColumnName("PORT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Protocol)
                    .HasColumnName("PROTOCOL")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Recordsyntax)
                    .HasColumnName("RECORDSYNTAX")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.LibraryCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("library_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.LibraryUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("library_updateby");
            });

            modelBuilder.Entity<Librarysearchcriteria>(entity =>
            {
                entity.ToTable("librarysearchcriteria");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("librarysearchcriteria_createby");

                entity.HasIndex(e => e.Libraryid)
                    .HasName("librarysearchcriteria_library");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("librarysearchcriteria_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Criterianame)
                    .IsRequired()
                    .HasColumnName("CRITERIANAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Libraryid).HasColumnName("LIBRARYID");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.LibrarysearchcriteriaCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("librarysearchcriteria_createby");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.Librarysearchcriteria)
                    .HasForeignKey(d => d.Libraryid)
                    .HasConstraintName("librarysearchcriteria_library");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.LibrarysearchcriteriaUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("librarysearchcriteria_updateby");
            });

            modelBuilder.Entity<LocationLibrary>(entity =>
            {
                entity.ToTable("location_library");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("location_library_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("location_library_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("location_library_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("location_library_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("location_library_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.LocationLibraryCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("location_library_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.LocationLibraryUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("location_library_updateby");
            });

            modelBuilder.Entity<LocationLibraryDefault>(entity =>
            {
                entity.ToTable("location_library_default");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("location_library_default_createby");

                entity.HasIndex(e => e.JenisAnggotaId)
                    .HasName("location_library_default_jenis_anggota");

                entity.HasIndex(e => e.LocationLibraryId)
                    .HasName("location_library_default_loc");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("location_library_default_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTeminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JenisAnggotaId).HasColumnName("JenisAnggota_id");

                entity.Property(e => e.LocationLibraryId).HasColumnName("Location_Library_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.LocationLibraryDefaultCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("location_library_default_createby");

                entity.HasOne(d => d.JenisAnggota)
                    .WithMany(p => p.LocationLibraryDefault)
                    .HasForeignKey(d => d.JenisAnggotaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("location_library_default_jenis_anggota");

                entity.HasOne(d => d.LocationLibrary)
                    .WithMany(p => p.LocationLibraryDefault)
                    .HasForeignKey(d => d.LocationLibraryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("location_library_default_loc");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.LocationLibraryDefaultUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("location_library_default_updateby");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.ToTable("locations");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("locations_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("locations_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("locations_kii");

                entity.HasIndex(e => e.LocationLibraryId)
                    .HasName("locations_loclib_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("locations_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("locations_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsGenerateVisitorNumber)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsInformationSought)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsPrintBarcode)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsVisitsDestination)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Ispusteling)
                    .HasColumnName("ISPUSTELING")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.LocationLibraryId).HasColumnName("LocationLibrary_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UrlLogo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.LocationsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("locations_createby");

                entity.HasOne(d => d.LocationLibrary)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.LocationLibraryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("locations_loclib");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.LocationsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("locations_updateby");
            });

            modelBuilder.Entity<Lockers>(entity =>
            {
                entity.ToTable("lockers");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("lockers_createby_idx");

                entity.HasIndex(e => e.IdJaminIdt)
                    .HasName("lockers_jenisidentitas_idx");

                entity.HasIndex(e => e.IdJaminUang)
                    .HasName("lockers_uangjaminan_idx");

                entity.HasIndex(e => e.IdPelanggaranLocker)
                    .HasName("lockers_pelanggaran_idx");

                entity.HasIndex(e => e.JenisJaminan)
                    .HasName("lockers_jenisjaminan");

                entity.HasIndex(e => e.LokerId)
                    .HasName("fk_lockers_master_loker_idx");

                entity.HasIndex(e => e.NoIdentitas)
                    .HasName("lockers_noidentitas");

                entity.HasIndex(e => e.NoPinjaman)
                    .HasName("lockers_nopinjama");

                entity.HasIndex(e => e.TanggalKembali)
                    .HasName("lockers_tglkembali");

                entity.HasIndex(e => e.TanggalPinjam)
                    .HasName("lockers_tglpinjam");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("lockers_updateby_idx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Denda).HasColumnName("denda");

                entity.Property(e => e.IdJaminIdt).HasColumnName("id_jamin_idt");

                entity.Property(e => e.IdJaminUang).HasColumnName("id_jamin_uang");

                entity.Property(e => e.IdPelanggaranLocker).HasColumnName("id_pelanggaran_locker");

                entity.Property(e => e.JenisJaminan)
                    .HasColumnName("jenis_jaminan")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LokerId).HasColumnName("loker_id");

                entity.Property(e => e.NoIdentitas)
                    .HasColumnName("no_identitas")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoMember)
                    .HasColumnName("no_member")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NoPinjaman)
                    .IsRequired()
                    .HasColumnName("No_pinjaman")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TanggalKembali).HasColumnName("tanggal_kembali");

                entity.Property(e => e.TanggalPinjam).HasColumnName("tanggal_pinjam");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.LockersCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("lockers_createby");

                entity.HasOne(d => d.IdJaminIdtNavigation)
                    .WithMany(p => p.Lockers)
                    .HasForeignKey(d => d.IdJaminIdt)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("lockers_jenisidentitas");

                entity.HasOne(d => d.IdJaminUangNavigation)
                    .WithMany(p => p.Lockers)
                    .HasForeignKey(d => d.IdJaminUang)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("lockers_uangjaminan");

                entity.HasOne(d => d.IdPelanggaranLockerNavigation)
                    .WithMany(p => p.Lockers)
                    .HasForeignKey(d => d.IdPelanggaranLocker)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("lockers_pelanggaran");

                entity.HasOne(d => d.Loker)
                    .WithMany(p => p.Lockers)
                    .HasForeignKey(d => d.LokerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_lockers_master_loker");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.LockersUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("lockers_updateby");
            });

            modelBuilder.Entity<Logsdownload>(entity =>
            {
                entity.ToTable("logsdownload");

                entity.HasIndex(e => e.CatalogfilesId)
                    .HasName("fk_logsDownload_catalogfiles_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("fk_logsDownload_1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CatalogfilesId).HasColumnName("catalogfilesID");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IsLkd)
                    .HasColumnName("isLKD")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Waktu).HasColumnName("waktu");

                entity.HasOne(d => d.Catalogfiles)
                    .WithMany(p => p.Logsdownload)
                    .HasForeignKey(d => d.CatalogfilesId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_logsDownload_catalogfiles");
            });

            modelBuilder.Entity<LogsdownloadArticle>(entity =>
            {
                entity.ToTable("logsdownload_article");

                entity.HasIndex(e => e.ArticlefilesId)
                    .HasName("fk_logsDownload_articlefiles_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("fk_logsDownload_u_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArticlefilesId).HasColumnName("articlefilesID");

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Waktu).HasColumnName("waktu");

                entity.HasOne(d => d.Articlefiles)
                    .WithMany(p => p.LogsdownloadArticle)
                    .HasForeignKey(d => d.ArticlefilesId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_logsDownload_articlefiles");
            });

            modelBuilder.Entity<Mailserver>(entity =>
            {
                entity.ToTable("mailserver");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("mailserver_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("mailserver_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialMail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CredentialPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnableSsl)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.MailDisplayName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailFrom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modul)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MailserverCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("mailserver_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MailserverUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("mailserver_updateby");
            });

            modelBuilder.Entity<MasaBerlakuAnggota>(entity =>
            {
                entity.ToTable("masa_berlaku_anggota");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("masa_berlaku_anggota_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("masa_berlaku_anggota_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("masa_berlaku_anggota_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("masa_berlaku_anggota_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("masa_berlaku_anggota_updatedate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Jumlah).HasColumnName("jumlah");

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Satuan)
                    .IsRequired()
                    .HasColumnName("satuan")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MasaBerlakuAnggotaCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("masa_berlaku_anggota_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MasaBerlakuAnggotaUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("masa_berlaku_anggota_updateby");
            });

            modelBuilder.Entity<MasterDjkn>(entity =>
            {
                entity.ToTable("master_djkn");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("master_djkn_createby_idx");

                entity.HasIndex(e => e.OptionId)
                    .HasName("master_djkn_option");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("master_djkn_updateby_idx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OptionId)
                    .HasColumnName("Option_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OptionName)
                    .HasColumnName("Option_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MasterDjknCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_djkn_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MasterDjknUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_djkn_updateby");
            });

            modelBuilder.Entity<MasterEdisiSerial>(entity =>
            {
                entity.ToTable("master_edisi_serial");

                entity.HasIndex(e => e.CatalogId)
                    .HasName("edisiSerial_catalog");

                entity.HasIndex(e => e.NoEdisiSerial)
                    .HasName("unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CatalogId).HasColumnName("Catalog_id");

                entity.Property(e => e.NoEdisiSerial)
                    .HasColumnName("no_edisi_serial")
                    .HasMaxLength(111)
                    .IsUnicode(false);

                entity.Property(e => e.TglEdisiSerial)
                    .HasColumnName("tgl_edisi_serial")
                    .HasColumnType("date");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.MasterEdisiSerial)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("edisiSerial_catalog");
            });

            modelBuilder.Entity<MasterFakultas>(entity =>
            {
                entity.ToTable("master_fakultas");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("master_fakultas_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("master_fakultas_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("master_fakultas_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("master_fakultas_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("master_fakultas_updatedate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Nama)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MasterFakultasCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_fakultas_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MasterFakultasUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_fakultas_updateby");
            });

            modelBuilder.Entity<MasterJamBuka>(entity =>
            {
                entity.ToTable("master_jam_buka");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hari)
                    .HasColumnName("hari")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.JamBuka)
                    .HasColumnName("jam_buka")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.JamTutup)
                    .HasColumnName("jam_tutup")
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterJenisIdentitas>(entity =>
            {
                entity.ToTable("master_jenis_identitas");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("master_jenis_identitas_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("master_jenis_identitas_updateby");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsNik)
                    .HasColumnName("IsNIK")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Nama)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MasterJenisIdentitasCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_jenis_identitas_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MasterJenisIdentitasUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_jenis_identitas_updateby");
            });

            modelBuilder.Entity<MasterJenjangPendidikan>(entity =>
            {
                entity.ToTable("master_jenjang_pendidikan");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("masjer_jenjang_pendidikan_create_by");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("masjer_jenjang_pendidikan_create_date");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("masjer_jenjang_pendidikan_update_by");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("masjer_jenjang_pendidikan_update_date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JenjangPendidikan)
                    .IsRequired()
                    .HasColumnName("jenjang_pendidikan")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterJurusan>(entity =>
            {
                entity.ToTable("master_jurusan");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("master_jurusan_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("master_jurusan_createdate");

                entity.HasIndex(e => e.IdFakultas)
                    .HasName("master_jurusan_fakultas");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("master_jurusan_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("master_jurusan_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("master_jurusan_updatedate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdFakultas).HasColumnName("id_fakultas");

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Nama)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MasterJurusanCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_jurusan_createby");

                entity.HasOne(d => d.IdFakultasNavigation)
                    .WithMany(p => p.MasterJurusan)
                    .HasForeignKey(d => d.IdFakultas)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("master_jurusan_fakultas");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MasterJurusanUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_jurusan_updateby");
            });

            modelBuilder.Entity<MasterKelasBesar>(entity =>
            {
                entity.ToTable("master_kelas_besar");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("master_kelas_besar_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("master_kelas_besar_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KdKelas)
                    .IsRequired()
                    .HasColumnName("kdKelas")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Namakelas)
                    .IsRequired()
                    .HasColumnName("namakelas")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Warna)
                    .HasColumnName("warna")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MasterKelasBesarCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_kelas_besar_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MasterKelasBesarUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_kelas_besar_updateby");
            });

            modelBuilder.Entity<MasterKependudukan>(entity =>
            {
                entity.ToTable("master_kependudukan");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("master_kependudukan_createby");

                entity.HasIndex(e => e.Nik)
                    .HasName("master_kependudukan_nik");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("master_kependudukan_updateby");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Agama).HasColumnName("agama");

                entity.Property(e => e.Agm)
                    .HasColumnName("agm")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aktacerai)
                    .HasColumnName("aktacerai")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aktakawin)
                    .HasColumnName("aktakawin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Aktalhr)
                    .HasColumnName("aktalhr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Al1)
                    .HasColumnName("al1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Alamat)
                    .HasColumnName("alamat")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hub)
                    .HasColumnName("hub")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Jenis)
                    .HasColumnName("jenis")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Jk).HasColumnName("jk");

                entity.Property(e => e.KlainFisik)
                    .HasColumnName("klain_fisik")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kodekec)
                    .HasColumnName("kodekec")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kodekel)
                    .HasColumnName("kodekel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lhrtanggal)
                    .HasColumnName("lhrtanggal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lhrtempat)
                    .HasColumnName("lhrtempat")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NamaIbu)
                    .HasColumnName("nama_ibu")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamaKab)
                    .HasColumnName("nama_kab")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamaKec)
                    .HasColumnName("nama_kec")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamaKel)
                    .HasColumnName("nama_kel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamaProv)
                    .HasColumnName("nama_prov")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Namalengkap)
                    .IsRequired()
                    .HasColumnName("namalengkap")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nik)
                    .IsRequired()
                    .HasColumnName("nik")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nocacat)
                    .HasColumnName("nocacat")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nomorkk)
                    .HasColumnName("nomorkk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pekerjaan)
                    .HasColumnName("pekerjaan")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pendidikan)
                    .HasColumnName("pendidikan")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rt)
                    .HasColumnName("rt")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rw)
                    .HasColumnName("rw")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Sts)
                    .HasColumnName("sts")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Status Kawin");

                entity.Property(e => e.Ttl)
                    .HasColumnName("ttl")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Umur)
                    .HasColumnName("umur")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MasterKependudukanCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_kependudukan_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MasterKependudukanUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_kependudukan_updateby");
            });

            modelBuilder.Entity<MasterLoker>(entity =>
            {
                entity.ToTable("master_loker");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("master_loker_createby_idx");

                entity.HasIndex(e => e.LocationsId)
                    .HasName("master_loker_location_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("master_loker_updateby_idx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationsId).HasColumnName("locations_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MasterLokerCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_loker_createby");

                entity.HasOne(d => d.Locations)
                    .WithMany(p => p.MasterLoker)
                    .HasForeignKey(d => d.LocationsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("master_loker_locations");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MasterLokerUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_loker_updateby");
            });

            modelBuilder.Entity<MasterPekerjaan>(entity =>
            {
                entity.ToTable("master_pekerjaan");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("master_pekerjaan_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("master_pekerjaan_updateby");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Pekerjaan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MasterPekerjaanCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_pekerjaan_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MasterPekerjaanUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_pekerjaan_updateby");
            });

            modelBuilder.Entity<MasterPelanggaranLocker>(entity =>
            {
                entity.ToTable("master_pelanggaran_locker");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Denda)
                    .HasColumnName("denda")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Deskripsi).HasColumnName("deskripsi");

                entity.Property(e => e.JenisPelanggaran)
                    .HasColumnName("jenis_pelanggaran")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterPendidikan>(entity =>
            {
                entity.ToTable("master_pendidikan");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("master_pendidikan_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("master_pendidikan_updateby");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Nama)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MasterPendidikanCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_pendidikan_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MasterPendidikanUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_pendidikan_updateby");
            });

            modelBuilder.Entity<MasterProgramStudi>(entity =>
            {
                entity.ToTable("master_program_studi");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("master_program_studi_createby");

                entity.HasIndex(e => e.IdJurusan)
                    .HasName("master_program_studi_jurusan_idx");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("master_program_studi_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("master_program_studi_updateby");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdJurusan).HasColumnName("id_jurusan");

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Nama)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MasterProgramStudiCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_program_studi_createby");

                entity.HasOne(d => d.IdJurusanNavigation)
                    .WithMany(p => p.MasterProgramStudi)
                    .HasForeignKey(d => d.IdJurusan)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("master_program_studi_jurusan");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MasterProgramStudiUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_program_studi_updateby");
            });

            modelBuilder.Entity<MasterRangeUmur>(entity =>
            {
                entity.ToTable("master_range_umur");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("master_range_umur_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("master_range_umur_updateby");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NoUrut).HasDefaultValueSql("'99'");

                entity.Property(e => e.Umur1).HasColumnName("umur1");

                entity.Property(e => e.Umur2).HasColumnName("umur2");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MasterRangeUmurCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_range_umur_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MasterRangeUmurUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_range_umur_updateby");
            });

            modelBuilder.Entity<MasterStatusPerkawinan>(entity =>
            {
                entity.ToTable("master_status_perkawinan");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("master_status_perkawinan_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("master_status_perkawinan_updateby");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MasterStatusPerkawinanCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_status_perkawinan_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MasterStatusPerkawinanUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("master_status_perkawinan_updateby");
            });

            modelBuilder.Entity<MasterUangJaminan>(entity =>
            {
                entity.ToTable("master_uang_jaminan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MemberFields>(entity =>
            {
                entity.ToTable("member_fields");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("member_fields_createby");

                entity.HasIndex(e => e.Mandatory)
                    .HasName("member_fields_mandatory");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("member_fields_updateby");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mandatory)
                    .HasColumnName("mandatory")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MemberFieldsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("member_fields_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MemberFieldsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("member_fields_updateby");
            });

            modelBuilder.Entity<MemberPerpanjangan>(entity =>
            {
                entity.ToTable("member_perpanjangan");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("member_perpanjangan_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("member_perpanjangan_createdate");

                entity.HasIndex(e => e.MemberId)
                    .HasName("member_perpanjangan_member");

                entity.HasIndex(e => e.Tanggal)
                    .HasName("member_perpanjangan_tanggal");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("member_perpanjangan_updateby");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Biaya)
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsLunas)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MemberPerpanjanganCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("member_perpanjangan_createby");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.MemberPerpanjangan)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("member_perpanjangan_member");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MemberPerpanjanganUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("member_perpanjangan_updateby");
            });

            modelBuilder.Entity<Memberguesses>(entity =>
            {
                entity.ToTable("memberguesses");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("memberguesses_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("memberguesses_createdate");

                entity.HasIndex(e => e.JenisKelaminId)
                    .HasName("memberguesses_jeniskelamin");

                entity.HasIndex(e => e.LocationId)
                    .HasName("memberguesses_location_id");

                entity.HasIndex(e => e.LocationloansId)
                    .HasName("memberguesses_locationloans");

                entity.HasIndex(e => e.MasaBerlakuId)
                    .HasName("memberguesses_masaberlaku");

                entity.HasIndex(e => e.Nama)
                    .HasName("memberguesses_nama");

                entity.HasIndex(e => e.NoAnggota)
                    .HasName("memberguesses_noanggota");

                entity.HasIndex(e => e.NoPengunjung)
                    .HasName("Membergueeses_NoPengunjung");

                entity.HasIndex(e => e.PendidikanTerakhirId)
                    .HasName("memberguesses_pendidikan");

                entity.HasIndex(e => e.ProfesiId)
                    .HasName("memberguesses_pekerjaan");

                entity.HasIndex(e => e.StatusId)
                    .HasName("memberguesses_status");

                entity.HasIndex(e => e.TujuanKunjunganId)
                    .HasName("memberguesses_TujuanKunjungan_Id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("memberguesses_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Alamat)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Deskripsi)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Information)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.JenisKelaminId).HasColumnName("JenisKelamin_id");

                entity.Property(e => e.LocationId).HasColumnName("Location_Id");

                entity.Property(e => e.LocationloansId).HasColumnName("LOCATIONLOANS_ID");

                entity.Property(e => e.MasaBerlakuId).HasColumnName("MasaBerlaku_id");

                entity.Property(e => e.Nama)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoAnggota)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoPengunjung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PendidikanTerakhirId).HasColumnName("PendidikanTerakhir_id");

                entity.Property(e => e.ProfesiId).HasColumnName("Profesi_id");

                entity.Property(e => e.StatusId).HasColumnName("Status_id");

                entity.Property(e => e.TujuanKunjunganId).HasColumnName("TujuanKunjungan_Id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MemberguessesCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("memberguesses_createby");

                entity.HasOne(d => d.JenisKelamin)
                    .WithMany(p => p.Memberguesses)
                    .HasForeignKey(d => d.JenisKelaminId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("memberguesses_jeniskelamin");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Memberguesses)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("memberguesses_location_id");

                entity.HasOne(d => d.Locationloans)
                    .WithMany(p => p.Memberguesses)
                    .HasForeignKey(d => d.LocationloansId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("memberguesses_locationloans");

                entity.HasOne(d => d.MasaBerlaku)
                    .WithMany(p => p.Memberguesses)
                    .HasForeignKey(d => d.MasaBerlakuId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("memberguesses_masaberlaku");

                entity.HasOne(d => d.PendidikanTerakhir)
                    .WithMany(p => p.Memberguesses)
                    .HasForeignKey(d => d.PendidikanTerakhirId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("memberguesses_pendidikan");

                entity.HasOne(d => d.Profesi)
                    .WithMany(p => p.Memberguesses)
                    .HasForeignKey(d => d.ProfesiId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("memberguesses_pekerjaan");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Memberguesses)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("memberguesses_status");

                entity.HasOne(d => d.TujuanKunjungan)
                    .WithMany(p => p.Memberguesses)
                    .HasForeignKey(d => d.TujuanKunjunganId)
                    .HasConstraintName("memberguesses_TujuanKunjungan_Id");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MemberguessesUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("memberguesses_updateby");
            });

            modelBuilder.Entity<Memberloanauthorizecategory>(entity =>
            {
                entity.HasKey(e => e.DataId)
                    .HasName("PRIMARY");

                entity.ToTable("memberloanauthorizecategory");

                entity.HasIndex(e => e.CategoryLoanId)
                    .HasName("CategoryLoan_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("memberloanauthorizecategory_createby");

                entity.HasIndex(e => e.MemberId)
                    .HasName("Member_id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("memberloanauthorizecategory_updateby");

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.CategoryLoanId).HasColumnName("CategoryLoan_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CategoryLoan)
                    .WithMany(p => p.Memberloanauthorizecategory)
                    .HasForeignKey(d => d.CategoryLoanId)
                    .HasConstraintName("FKCB16B2E7A5EDFBF6");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MemberloanauthorizecategoryCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("memberloanauthorizecategory_createby");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Memberloanauthorizecategory)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FKCB16B2E75DD8E7A8");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MemberloanauthorizecategoryUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("memberloanauthorizecategory_updateby");
            });

            modelBuilder.Entity<Memberloanauthorizelocation>(entity =>
            {
                entity.HasKey(e => e.DataId)
                    .HasName("PRIMARY");

                entity.ToTable("memberloanauthorizelocation");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("memberloanauthorizelocation_createby");

                entity.HasIndex(e => e.LocationLoanId)
                    .HasName("memberloanauthorizelocation_loc_idx");

                entity.HasIndex(e => e.MemberId)
                    .HasName("memberloanauthorizelocation_member_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("memberloanauthorizelocation_updateby");

                entity.Property(e => e.DataId).HasColumnName("DataID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationLoanId).HasColumnName("LocationLoan_id");

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MemberloanauthorizelocationCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("memberloanauthorizelocation_createby");

                entity.HasOne(d => d.LocationLoan)
                    .WithMany(p => p.Memberloanauthorizelocation)
                    .HasForeignKey(d => d.LocationLoanId)
                    .HasConstraintName("memberloanauthorizelocation_loc");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Memberloanauthorizelocation)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("memberloanauthorizelocation_member");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MemberloanauthorizelocationUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("memberloanauthorizelocation_updateby");
            });

            modelBuilder.Entity<Memberrules>(entity =>
            {
                entity.ToTable("memberrules");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("memberrules_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("memberrules_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsPublish)
                    .HasColumnName("isPublish")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.NameCategory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortNum).HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MemberrulesCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("memberrules_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MemberrulesUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("memberrules_updateby");
            });

            modelBuilder.Entity<Members>(entity =>
            {
                entity.ToTable("members");

                entity.HasIndex(e => e.AgamaId)
                    .HasName("member_agama");

                entity.HasIndex(e => e.BranchId)
                    .HasName("Branch_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("members_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("members_createdate");

                entity.HasIndex(e => e.DateOfBirth)
                    .HasName("members_dateofbirth");

                entity.HasIndex(e => e.EducationLevelId)
                    .HasName("members_education");

                entity.HasIndex(e => e.FakultasId)
                    .HasName("members_fakultas");

                entity.HasIndex(e => e.IdentityTypeId)
                    .HasName("members_identitytype");

                entity.HasIndex(e => e.JenisAnggotaId)
                    .HasName("members_jenis_anggota");

                entity.HasIndex(e => e.JenisPermohonanId)
                    .HasName("members_jenispermohonan");

                entity.HasIndex(e => e.JenjangPendidikanId)
                    .HasName("members_jenjang_pendidikan");

                entity.HasIndex(e => e.JobId)
                    .HasName("member_job");

                entity.HasIndex(e => e.JurusanId)
                    .HasName("members_jurusan");

                entity.HasIndex(e => e.KelasId)
                    .HasName("members_kelassiswa");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("members_kii");

                entity.HasIndex(e => e.MaritalStatusId)
                    .HasName("members_status_perkawinan");

                entity.HasIndex(e => e.MemberNo)
                    .HasName("MemberNo");

                entity.HasIndex(e => e.ProgramStudiId)
                    .HasName("members_programstudi_idx");

                entity.HasIndex(e => e.RegisterDate)
                    .HasName("members_registerdate");

                entity.HasIndex(e => e.SexId)
                    .HasName("member_sex");

                entity.HasIndex(e => e.StatusAnggotaId)
                    .HasName("members_statusanggota");

                entity.HasIndex(e => e.UnitKerjaId)
                    .HasName("member_unit_kerja");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("members_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("members_updatedate");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressNow)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AgamaId).HasColumnName("Agama_id");

                entity.Property(e => e.AlamatDarurat)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BiayaPendaftaran)
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BranchId).HasColumnName("Branch_id");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CityNow)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EducationLevelId).HasColumnName("EducationLevel_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FakultasId).HasColumnName("Fakultas_id");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityTypeId).HasColumnName("IdentityType_id");

                entity.Property(e => e.InstitutionAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InstitutionPhone)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsLunasBiayaPendaftaran)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.JenisAnggotaId).HasColumnName("JenisAnggota_id");

                entity.Property(e => e.JenisPermohonanId).HasColumnName("JenisPermohonan_id");

                entity.Property(e => e.JenjangPendidikanId).HasColumnName("JenjangPendidikan_id");

                entity.Property(e => e.JobId).HasColumnName("Job_id");

                entity.Property(e => e.JurusanId).HasColumnName("Jurusan_id");

                entity.Property(e => e.Kecamatan)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KecamatanNow)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KelasId).HasColumnName("Kelas_id");

                entity.Property(e => e.Kelurahan)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KelurahanNow)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KeteranganLain)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.LoanReturnLateCount).HasDefaultValueSql("'0'");

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatus_id");

                entity.Property(e => e.MemberNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotherMaidenName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamaDarurat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoHp)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceOfBirth)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramStudiId).HasColumnName("ProgramStudi_id");

                entity.Property(e => e.Province)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceNow)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rt)
                    .HasColumnName("RT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rtnow)
                    .HasColumnName("RTNow")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rw)
                    .HasColumnName("RW")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rwnow)
                    .HasColumnName("RWNow")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SexId).HasColumnName("Sex_id");

                entity.Property(e => e.StatusAnggotaId).HasColumnName("StatusAnggota_id");

                entity.Property(e => e.StatusHubunganDarurat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TahunAjaran)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelpDarurat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitKerjaId).HasColumnName("UnitKerja_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Agama)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.AgamaId)
                    .HasConstraintName("member_agama");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK418999036ADC8006");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MembersCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_createby");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.EducationLevelId)
                    .HasConstraintName("members_education");

                entity.HasOne(d => d.Fakultas)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.FakultasId)
                    .HasConstraintName("members_fakultas");

                entity.HasOne(d => d.IdentityType)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.IdentityTypeId)
                    .HasConstraintName("members_identitytype");

                entity.HasOne(d => d.JenisAnggota)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.JenisAnggotaId)
                    .HasConstraintName("members_jenis_anggota");

                entity.HasOne(d => d.JenisPermohonan)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.JenisPermohonanId)
                    .HasConstraintName("members_jenispermohonan");

                entity.HasOne(d => d.JenjangPendidikan)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.JenjangPendidikanId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_jenjang_pendidikan");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("member_job");

                entity.HasOne(d => d.Jurusan)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.JurusanId)
                    .HasConstraintName("members_jurusan");

                entity.HasOne(d => d.Kelas)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.KelasId)
                    .HasConstraintName("members_kelassiswa");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("members_status_perkawinan");

                entity.HasOne(d => d.ProgramStudi)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.ProgramStudiId)
                    .HasConstraintName("members_programstudi");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.SexId)
                    .HasConstraintName("member_sex");

                entity.HasOne(d => d.StatusAnggota)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.StatusAnggotaId)
                    .HasConstraintName("members_statusanggota");

                entity.HasOne(d => d.UnitKerja)
                    .WithMany(p => p.Members)
                    .HasForeignKey(d => d.UnitKerjaId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("member_unit_kerja");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MembersUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_updateby");
            });

            modelBuilder.Entity<MembersForm>(entity =>
            {
                entity.ToTable("members_form");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("members_form_createby");

                entity.HasIndex(e => e.JenisPerpustakaanId)
                    .HasName("members_form_perpus");

                entity.HasIndex(e => e.MemberFieldId)
                    .HasName("members_form_field");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("members_form_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JenisPerpustakaanId).HasColumnName("Jenis_Perpustakaan_id");

                entity.Property(e => e.MemberFieldId).HasColumnName("Member_Field_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MembersFormCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_form_createby");

                entity.HasOne(d => d.JenisPerpustakaan)
                    .WithMany(p => p.MembersForm)
                    .HasForeignKey(d => d.JenisPerpustakaanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_form_perpus");

                entity.HasOne(d => d.MemberField)
                    .WithMany(p => p.MembersForm)
                    .HasForeignKey(d => d.MemberFieldId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_form_field");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MembersFormUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_form_updateby");
            });

            modelBuilder.Entity<MembersFormList>(entity =>
            {
                entity.ToTable("members_form_list");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("members_form_list_createby");

                entity.HasIndex(e => e.JenisPerpustakaanId)
                    .HasName("members_form_list_perpus");

                entity.HasIndex(e => e.MemberFieldId)
                    .HasName("members_form_list_field");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("members_form_list_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JenisPerpustakaanId).HasColumnName("Jenis_Perpustakaan_id");

                entity.Property(e => e.MemberFieldId).HasColumnName("Member_Field_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MembersFormListCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_form_list_createby");

                entity.HasOne(d => d.JenisPerpustakaan)
                    .WithMany(p => p.MembersFormList)
                    .HasForeignKey(d => d.JenisPerpustakaanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_form_list_perpus");

                entity.HasOne(d => d.MemberField)
                    .WithMany(p => p.MembersFormList)
                    .HasForeignKey(d => d.MemberFieldId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_form_list_field");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MembersFormListUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_form_list_updateby");
            });

            modelBuilder.Entity<MembersInfoForm>(entity =>
            {
                entity.ToTable("members_info_form");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("members_info_form_createby");

                entity.HasIndex(e => e.JenisPerpustakaanId)
                    .HasName("members_info_form_perpus");

                entity.HasIndex(e => e.MemberFieldId)
                    .HasName("members_info_form_field");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("members_info_form_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JenisPerpustakaanId).HasColumnName("Jenis_Perpustakaan_id");

                entity.Property(e => e.MemberFieldId).HasColumnName("Member_Field_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MembersInfoFormCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_info_form_createby");

                entity.HasOne(d => d.JenisPerpustakaan)
                    .WithMany(p => p.MembersInfoForm)
                    .HasForeignKey(d => d.JenisPerpustakaanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_info_form_perpus");

                entity.HasOne(d => d.MemberField)
                    .WithMany(p => p.MembersInfoForm)
                    .HasForeignKey(d => d.MemberFieldId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_info_form_field");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MembersInfoFormUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_info_form_updateby");
            });

            modelBuilder.Entity<MembersLoanForm>(entity =>
            {
                entity.ToTable("members_loan_form");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("members_loan_form_createby");

                entity.HasIndex(e => e.JenisPerpustakaanId)
                    .HasName("members_loan_form_perpus");

                entity.HasIndex(e => e.MemberFieldId)
                    .HasName("members_loan_form_field");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("members_loan_form_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JenisPerpustakaanId).HasColumnName("Jenis_Perpustakaan_id");

                entity.Property(e => e.MemberFieldId).HasColumnName("Member_Field_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MembersLoanFormCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_loan_form_createby");

                entity.HasOne(d => d.JenisPerpustakaan)
                    .WithMany(p => p.MembersLoanForm)
                    .HasForeignKey(d => d.JenisPerpustakaanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_loan_form_perpus");

                entity.HasOne(d => d.MemberField)
                    .WithMany(p => p.MembersLoanForm)
                    .HasForeignKey(d => d.MemberFieldId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_loan_form_field");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MembersLoanFormUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_loan_form_updateby");
            });

            modelBuilder.Entity<MembersLoanreturnForm>(entity =>
            {
                entity.ToTable("members_loanreturn_form");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("members_loanreturn_form_createby");

                entity.HasIndex(e => e.JenisPerpustakaanId)
                    .HasName("members_loanreturn_form_perpus");

                entity.HasIndex(e => e.MemberFieldId)
                    .HasName("members_loanreturn_form_field");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("members_loanreturn_form_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JenisPerpustakaanId).HasColumnName("Jenis_Perpustakaan_id");

                entity.Property(e => e.MemberFieldId).HasColumnName("Member_Field_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MembersLoanreturnFormCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_loanreturn_form_createby");

                entity.HasOne(d => d.JenisPerpustakaan)
                    .WithMany(p => p.MembersLoanreturnForm)
                    .HasForeignKey(d => d.JenisPerpustakaanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_loanreturn_form_perpus");

                entity.HasOne(d => d.MemberField)
                    .WithMany(p => p.MembersLoanreturnForm)
                    .HasForeignKey(d => d.MemberFieldId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_loanreturn_form_field");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MembersLoanreturnFormUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_loanreturn_form_updateby");
            });

            modelBuilder.Entity<MembersOnlineForm>(entity =>
            {
                entity.ToTable("members_online_form");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("members_online_form_createby");

                entity.HasIndex(e => e.JenisPerpustakaanId)
                    .HasName("members_online_form_perpus");

                entity.HasIndex(e => e.MemberFieldId)
                    .HasName("members_online_form_field");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("members_online_form_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JenisPerpustakaanId).HasColumnName("Jenis_Perpustakaan_id");

                entity.Property(e => e.MemberFieldId).HasColumnName("Member_Field_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MembersOnlineFormCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_online_form_createby");

                entity.HasOne(d => d.JenisPerpustakaan)
                    .WithMany(p => p.MembersOnlineForm)
                    .HasForeignKey(d => d.JenisPerpustakaanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_online_form_perpus");

                entity.HasOne(d => d.MemberField)
                    .WithMany(p => p.MembersOnlineForm)
                    .HasForeignKey(d => d.MemberFieldId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_online_form_field");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MembersOnlineFormUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_online_form_updateby");
            });

            modelBuilder.Entity<MembersOnlineFormEdit>(entity =>
            {
                entity.ToTable("members_online_form_edit");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("members_online_form_edit_createby");

                entity.HasIndex(e => e.JenisPerpustakaanId)
                    .HasName("members_online_form_edit_perpus");

                entity.HasIndex(e => e.MemberFieldId)
                    .HasName("members_online_form_edit_field");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("members_online_form_edit_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JenisPerpustakaanId).HasColumnName("Jenis_Perpustakaan_id");

                entity.Property(e => e.MemberFieldId).HasColumnName("Member_Field_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MembersOnlineFormEditCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_online_form_edit_createby");

                entity.HasOne(d => d.JenisPerpustakaan)
                    .WithMany(p => p.MembersOnlineFormEdit)
                    .HasForeignKey(d => d.JenisPerpustakaanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_online_form_edit_perpus");

                entity.HasOne(d => d.MemberField)
                    .WithMany(p => p.MembersOnlineFormEdit)
                    .HasForeignKey(d => d.MemberFieldId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("members_online_form_edit_field");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MembersOnlineFormEditUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("members_online_form_edit_updateby");
            });

            modelBuilder.Entity<Membersonline>(entity =>
            {
                entity.ToTable("membersonline");

                entity.HasIndex(e => e.BranchId)
                    .HasName("BranchId");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("membersonline_createby");

                entity.HasIndex(e => e.LocationLoanId)
                    .HasName("LocationLoanId");

                entity.HasIndex(e => e.NoAnggota)
                    .HasName("NoAnggota");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("membersonline_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationCode)
                    .HasColumnName("Activation_Code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AuthKey)
                    .HasColumnName("auth_key")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NickName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoAnggota)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Membersonline)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_branch");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MembersonlineCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("membersonline_createby");

                entity.HasOne(d => d.LocationLoan)
                    .WithMany(p => p.Membersonline)
                    .HasForeignKey(d => d.LocationLoanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_locationloan");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MembersonlineUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("membersonline_updateby");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menu");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("menu_createby");

                entity.HasIndex(e => e.Parent)
                    .HasName("parent");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("menu_updateby");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.Parent).HasColumnName("parent");

                entity.Property(e => e.Route)
                    .HasColumnName("route")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MenuCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("menu_createby");

                entity.HasOne(d => d.ParentNavigation)
                    .WithMany(p => p.InverseParentNavigation)
                    .HasForeignKey(d => d.Parent)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("menu_ibfk_1");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MenuUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("menu_updateby");
            });

            modelBuilder.Entity<Migration>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PRIMARY");

                entity.ToTable("migration");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("migration_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("migration_updateby");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.ApplyTime).HasColumnName("apply_time");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.MigrationCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("migration_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.MigrationUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("migration_updateby");
            });

            modelBuilder.Entity<Modelhistory>(entity =>
            {
                entity.ToTable("modelhistory");

                entity.HasIndex(e => e.FieldName)
                    .HasName("idx-field_name");

                entity.HasIndex(e => e.Table)
                    .HasName("idx-table");

                entity.HasIndex(e => e.Type)
                    .HasName("idx-type");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx-user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.FieldId)
                    .IsRequired()
                    .HasColumnName("field_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnName("field_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NewValue).HasColumnName("new_value");

                entity.Property(e => e.OldValue).HasColumnName("old_value");

                entity.Property(e => e.Table)
                    .IsRequired()
                    .HasColumnName("table")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Modules>(entity =>
            {
                entity.ToTable("modules");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("Application_id");

                entity.HasIndex(e => e.ClassName)
                    .HasName("modules_classname");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("modules_createby");

                entity.HasIndex(e => e.IsHeader)
                    .HasName("modules_isheader");

                entity.HasIndex(e => e.IsPublish)
                    .HasName("modules_IsPublish");

                entity.HasIndex(e => e.ModuleLevel)
                    .HasName("modules_moduleslevel");

                entity.HasIndex(e => e.Name)
                    .HasName("modules_name");

                entity.HasIndex(e => e.ParentId)
                    .HasName("ParentID");

                entity.HasIndex(e => e.SortNo)
                    .HasName("modules_sortno");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("modules_updateby");

                entity.HasIndex(e => e.Url)
                    .HasName("modules_url");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("Application_id");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsHeader)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsPublish)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SortNo).HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Modules)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK578D5FF54CBDA5AE");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.ModulesCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("modules_createby");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK578D5FF550C48F63");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.ModulesUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("modules_updateby");
            });

            modelBuilder.Entity<NotifSmsGateway>(entity =>
            {
                entity.ToTable("notif_sms_gateway");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CollectionloanitemId).HasColumnName("collectionloanitem_id");

                entity.Property(e => e.CriteriaMessage)
                    .HasColumnName("criteria_message")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("member_id");

                entity.Property(e => e.NumberHp).HasColumnName("number_HP");

                entity.Property(e => e.SendDate).HasColumnName("send_date");

                entity.Property(e => e.SendMessageText).HasColumnName("send_message_text");

                entity.Property(e => e.SendStatus)
                    .HasColumnName("send_status")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotifSmsGatewayHist>(entity =>
            {
                entity.ToTable("notif_sms_gateway_hist");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CollectionloanitemId).HasColumnName("collectionloanitem_id");

                entity.Property(e => e.CriteriaMessage)
                    .HasColumnName("criteria_message")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("member_id");

                entity.Property(e => e.NumberHp).HasColumnName("number_HP");

                entity.Property(e => e.SendDate).HasColumnName("send_date");

                entity.Property(e => e.SendMessageText).HasColumnName("send_message_text");

                entity.Property(e => e.SendStatus)
                    .HasColumnName("send_status")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Opacfields>(entity =>
            {
                entity.ToTable("opacfields");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("opacfields_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("opacfields_updateby");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Column10)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Column11)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Column12)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Column4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Column5)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Column6)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Column7)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Column8)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Column9)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("TAG")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.OpacfieldsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("opacfields_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.OpacfieldsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("opacfields_updateby");
            });

            modelBuilder.Entity<Opaclogs>(entity =>
            {
                entity.ToTable("opaclogs");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("opaclogs_createby_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("opaclogs_updateby_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("opaclogs_userid");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bahasa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BentukKarya)
                    .HasColumnName("Bentuk_Karya")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IsLkd)
                    .HasColumnName("isLKD")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.JenisBahan)
                    .HasColumnName("jenis_bahan")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JenisPencarian).HasColumnName("jenis_pencarian");

                entity.Property(e => e.Keyword).HasColumnName("keyword");

                entity.Property(e => e.TargetPembaca)
                    .HasColumnName("Target_Pembaca")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url).HasColumnName("url");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Waktu).HasColumnName("waktu");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.OpaclogsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .HasConstraintName("opaclogs_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.OpaclogsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .HasConstraintName("opaclogs_updateby");
            });

            modelBuilder.Entity<OpaclogsKeyword>(entity =>
            {
                entity.ToTable("opaclogs_keyword");

                entity.HasIndex(e => e.Field)
                    .HasName("opaclogs_keyword_field_idx");

                entity.HasIndex(e => e.Keyword)
                    .HasName("opaclogs_keyword_keyword_idx");

                entity.HasIndex(e => e.OpaclogsId)
                    .HasName("opaclogs_keyword_opaclogsid_idx");

                entity.Property(e => e.Field)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Keyword).HasColumnType("text");

                entity.HasOne(d => d.Opaclogs)
                    .WithMany(p => p.OpaclogsKeyword)
                    .HasForeignKey(d => d.OpaclogsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("opaclogs_keyword_opaclogsid");
            });

            modelBuilder.Entity<Outbox>(entity =>
            {
                entity.ToTable("outbox");

                entity.HasIndex(e => e.SenderId)
                    .HasName("outbox_sender");

                entity.HasIndex(e => new { e.SendingDateTime, e.SendingTimeOut })
                    .HasName("outbox_date");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Class).HasDefaultValueSql("'-1'");

                entity.Property(e => e.Coding)
                    .IsRequired()
                    .HasColumnType("enum('Default_No_Compression','Unicode_No_Compression','8bit','Default_Compression','Unicode_Compression')")
                    .HasDefaultValueSql("'Default_No_Compression'");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasColumnName("CreatorID");

                entity.Property(e => e.DeliveryReport)
                    .HasColumnType("enum('default','yes','no')")
                    .HasDefaultValueSql("'default'");

                entity.Property(e => e.DestinationNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.InsertIntoDb)
                    .HasColumnName("InsertIntoDB")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.MultiPart)
                    .HasColumnType("enum('false','true')")
                    .HasDefaultValueSql("'false'");

                entity.Property(e => e.RelativeValidity).HasDefaultValueSql("'-1'");

                entity.Property(e => e.SendAfter).HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.SendBefore).HasDefaultValueSql("'23:59:59'");

                entity.Property(e => e.SenderId)
                    .HasColumnName("SenderID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SendingDateTime).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.SendingTimeOut).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.TextDecoded).IsRequired();

                entity.Property(e => e.Udh).HasColumnName("UDH");

                entity.Property(e => e.UpdatedInDb)
                    .HasColumnName("UpdatedInDB")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<OutboxMultipart>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SequencePosition })
                    .HasName("PRIMARY");

                entity.ToTable("outbox_multipart");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.SequencePosition).HasDefaultValueSql("'1'");

                entity.Property(e => e.Class).HasDefaultValueSql("'-1'");

                entity.Property(e => e.Coding)
                    .IsRequired()
                    .HasColumnType("enum('Default_No_Compression','Unicode_No_Compression','8bit','Default_Compression','Unicode_Compression')")
                    .HasDefaultValueSql("'Default_No_Compression'");

                entity.Property(e => e.Udh).HasColumnName("UDH");
            });

            modelBuilder.Entity<Partners>(entity =>
            {
                entity.ToTable("partners");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("partners_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("partners_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("partners_kii");

                entity.HasIndex(e => e.Name)
                    .HasName("Partners_Name");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("partners_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("partners_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.PartnersCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("partners_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.PartnersUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("partners_updateby");
            });

            modelBuilder.Entity<Pbk>(entity =>
            {
                entity.ToTable("pbk");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Number).IsRequired();
            });

            modelBuilder.Entity<PbkGroups>(entity =>
            {
                entity.ToTable("pbk_groups");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Pelanggaran>(entity =>
            {
                entity.ToTable("pelanggaran");

                entity.HasIndex(e => e.CollectionId)
                    .HasName("pelanggaran_collection");

                entity.HasIndex(e => e.CollectionLoanId)
                    .HasName("pelanggaran_collectionloan");

                entity.HasIndex(e => e.CollectionLoanItemId)
                    .HasName("pelanggaran_cli");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("pelanggaran_createby");

                entity.HasIndex(e => e.JenisDendaId)
                    .HasName("Pelanggaran_JenisDenda");

                entity.HasIndex(e => e.JenisPelanggaranId)
                    .HasName("Pelanggaran_JenisPelanggaran");

                entity.HasIndex(e => e.JumlahDenda)
                    .HasName("Pelanggaran_JumlahDenda");

                entity.HasIndex(e => e.MemberId)
                    .HasName("pelanggaran_member");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("pelanggaran_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CollectionId).HasColumnName("Collection_id");

                entity.Property(e => e.CollectionLoanId)
                    .HasColumnName("CollectionLoan_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionLoanItemId).HasColumnName("CollectionLoanItem_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JenisDendaId).HasColumnName("JenisDenda_id");

                entity.Property(e => e.JenisPelanggaranId).HasColumnName("JenisPelanggaran_id");

                entity.Property(e => e.JumlahDenda)
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.JumlahSuspend).HasDefaultValueSql("'0'");

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.Paid)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.Pelanggaran)
                    .HasForeignKey(d => d.CollectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("pelanggaran_collection");

                entity.HasOne(d => d.CollectionLoan)
                    .WithMany(p => p.Pelanggaran)
                    .HasForeignKey(d => d.CollectionLoanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("pelanggaran_collectionloan");

                entity.HasOne(d => d.CollectionLoanItem)
                    .WithMany(p => p.Pelanggaran)
                    .HasForeignKey(d => d.CollectionLoanItemId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("pelanggaran_cli");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.PelanggaranCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pelanggaran_createby");

                entity.HasOne(d => d.JenisDenda)
                    .WithMany(p => p.Pelanggaran)
                    .HasForeignKey(d => d.JenisDendaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("pelanggaran_jenisdenda");

                entity.HasOne(d => d.JenisPelanggaran)
                    .WithMany(p => p.Pelanggaran)
                    .HasForeignKey(d => d.JenisPelanggaranId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("pelanggaran_jenispelanggaran");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Pelanggaran)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("pelanggaran_member");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.PelanggaranUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pelanggaran_updateby");
            });

            modelBuilder.Entity<Penduduk>(entity =>
            {
                entity.ToTable("penduduk");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.KabupatenKota)
                    .HasColumnName("Kabupaten_Kota")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Kecamatan)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KelurahanDesa)
                    .HasColumnName("Kelurahan_desa")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nik)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Provinsi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempatLahir)
                    .HasColumnName("Tempat_Lahir")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tps)
                    .HasColumnName("TPS")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pengiriman>(entity =>
            {
                entity.ToTable("pengiriman");

                entity.HasIndex(e => e.CollectionId)
                    .HasName("pengiriman_collection");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("pengiriman_createby");

                entity.HasIndex(e => e.TanggalKirim)
                    .HasName("TanggalKirim");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("pengiriman_updateby");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CollectionId).HasColumnName("Collection_ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TanggalKirim).HasColumnType("date");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.Pengiriman)
                    .HasForeignKey(d => d.CollectionId)
                    .HasConstraintName("pengiriman_collection");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.PengirimanCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pengiriman_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.PengirimanUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pengiriman_updateby");
            });

            modelBuilder.Entity<PeraturanPeminjamanHari>(entity =>
            {
                entity.ToTable("peraturan_peminjaman_hari");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("pp_hari_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("pp_hari_createdate");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("pp_hari_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("pp_hari_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountPerpanjang).HasDefaultValueSql("'0'");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DayIndex).HasDefaultValueSql("'0'");

                entity.Property(e => e.DayPerpanjang).HasDefaultValueSql("'0'");

                entity.Property(e => e.DaySuspend).HasDefaultValueSql("'0'");

                entity.Property(e => e.DendaPerTenor).HasColumnType("decimal(10,0)");

                entity.Property(e => e.DendaTenorJumlah).HasDefaultValueSql("'0'");

                entity.Property(e => e.DendaTenorSatuan)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Hari'");

                entity.Property(e => e.DendaType)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Konstan'");

                entity.Property(e => e.MaxLoanDays).HasDefaultValueSql("'0'");

                entity.Property(e => e.MaxPinjamKoleksi).HasDefaultValueSql("'0'");

                entity.Property(e => e.SuspendMember)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.SuspendTenorJumlah).HasDefaultValueSql("'0'");

                entity.Property(e => e.SuspendTenorMultiply).HasDefaultValueSql("'1'");

                entity.Property(e => e.SuspendTenorSatuan)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Hari'");

                entity.Property(e => e.SuspendType)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Konstan'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WarningLoanDueDay).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.PeraturanPeminjamanHariCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pp_hari_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.PeraturanPeminjamanHariUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pp_hari_updateby");
            });

            modelBuilder.Entity<PeraturanPeminjamanTanggal>(entity =>
            {
                entity.ToTable("peraturan_peminjaman_tanggal");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("pp_tanggal_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("pp_tanggal_createdate");

                entity.HasIndex(e => e.TanggalAkhir)
                    .HasName("pp_tanggalakhir");

                entity.HasIndex(e => e.TanggalAwal)
                    .HasName("pp_tanggalawal");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("pp_tanggal_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("pp_tanggal_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountPerpanjang).HasDefaultValueSql("'0'");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DayPerpanjang).HasDefaultValueSql("'0'");

                entity.Property(e => e.DaySuspend).HasDefaultValueSql("'0'");

                entity.Property(e => e.DendaPerTenor).HasColumnType("decimal(10,0)");

                entity.Property(e => e.DendaTenorJumlah).HasDefaultValueSql("'0'");

                entity.Property(e => e.DendaTenorSatuan)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Hari'");

                entity.Property(e => e.DendaType)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Konstan'");

                entity.Property(e => e.MaxLoanDays).HasDefaultValueSql("'0'");

                entity.Property(e => e.MaxPinjamKoleksi).HasDefaultValueSql("'0'");

                entity.Property(e => e.SuspendMember)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.SuspendTenorJumlah).HasDefaultValueSql("'0'");

                entity.Property(e => e.SuspendTenorMultiply).HasDefaultValueSql("'1'");

                entity.Property(e => e.SuspendTenorSatuan)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Hari'");

                entity.Property(e => e.SuspendType)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Konstan'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WarningLoanDueDay).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.PeraturanPeminjamanTanggalCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pp_tanggal_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.PeraturanPeminjamanTanggalUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("pp_tanggal_updateby");
            });

            modelBuilder.Entity<Phones>(entity =>
            {
                entity.HasKey(e => e.Imei)
                    .HasName("PRIMARY");

                entity.ToTable("phones");

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Battery).HasDefaultValueSql("'-1'");

                entity.Property(e => e.Client).IsRequired();

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("ID");

                entity.Property(e => e.InsertIntoDb)
                    .HasColumnName("InsertIntoDB")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Receive)
                    .IsRequired()
                    .HasColumnType("enum('yes','no')")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Send)
                    .IsRequired()
                    .HasColumnType("enum('yes','no')")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Signal).HasDefaultValueSql("'-1'");

                entity.Property(e => e.TimeOut).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UpdatedInDb)
                    .HasColumnName("UpdatedInDB")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Propinsi>(entity =>
            {
                entity.ToTable("propinsi");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("propinsi_createby");

                entity.HasIndex(e => e.NamaPropinsi)
                    .HasName("propinsi_nama");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("propinsi_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamaPropinsi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.PropinsiCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("propinsi_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.PropinsiUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("propinsi_updateby");
            });

            modelBuilder.Entity<Publishers>(entity =>
            {
                entity.ToTable("publishers");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("publishers_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("publishers_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.PublishersCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("publishers_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.PublishersUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("publishers_updateby");
            });

            modelBuilder.Entity<QuarantinedAuthData>(entity =>
            {
                entity.ToTable("quarantined_auth_data");

                entity.HasIndex(e => e.AuthHeaderId)
                    .HasName("quarantined_auth_data_auth_header");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("quarantined_auth_data_createby");

                entity.HasIndex(e => e.Id)
                    .HasName("quarantined_auth_data_ID");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("quarantined_auth_data_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthHeaderId).HasColumnName("Auth_Header_ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Indicator1)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Indicator2)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.AuthHeader)
                    .WithMany(p => p.QuarantinedAuthData)
                    .HasForeignKey(d => d.AuthHeaderId)
                    .HasConstraintName("quarantined_auth_data_auth_header");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.QuarantinedAuthDataCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_auth_data_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.QuarantinedAuthDataUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_auth_data_updateby");
            });

            modelBuilder.Entity<QuarantinedAuthHeader>(entity =>
            {
                entity.ToTable("quarantined_auth_header");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("quarantined_auth_header_createby");

                entity.HasIndex(e => e.Id)
                    .HasName("quarantined_auth_header_ID");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("quarantined_auth_header_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthId)
                    .HasColumnName("Auth_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IstilahDigunakan).HasColumnName("ISTILAH_DIGUNAKAN");

                entity.Property(e => e.IstilahTdkDigunakan).HasColumnName("ISTILAH_TDK_DIGUNAKAN");

                entity.Property(e => e.IstilahTerkait).HasColumnName("ISTILAH_TERKAIT");

                entity.Property(e => e.MarcLoc).HasColumnName("MARC_LOC");

                entity.Property(e => e.Quarantinedby).HasColumnName("QUARANTINEDBY");

                entity.Property(e => e.Quarantineddate).HasColumnName("QUARANTINEDDATE");

                entity.Property(e => e.Quarantinedterminal)
                    .HasColumnName("QUARANTINEDTERMINAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tanggalpembahasan)
                    .HasColumnName("TANGGALPEMBAHASAN")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorksheetId).HasColumnName("Worksheet_id");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.QuarantinedAuthHeaderCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_auth_header_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.QuarantinedAuthHeaderUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_auth_header_updateby");
            });

            modelBuilder.Entity<QuarantinedCatalogRuas>(entity =>
            {
                entity.ToTable("quarantined_catalog_ruas");

                entity.HasIndex(e => e.CatalogId)
                    .HasName("quarantined_catalog_ruas_catalogs");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("quarantined_catalog_ruas_createby");

                entity.HasIndex(e => e.Id)
                    .HasName("quarantined_catalog_ruas_ID");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("quarantined_catalog_ruas_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Indicator1)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Indicator2)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Sequence).HasDefaultValueSql("'0'");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.QuarantinedCatalogRuas)
                    .HasForeignKey(d => d.CatalogId)
                    .HasConstraintName("quarantined_catalog_ruas_catalogs");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.QuarantinedCatalogRuasCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_catalog_ruas_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.QuarantinedCatalogRuasUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_catalog_ruas_updateby");
            });

            modelBuilder.Entity<QuarantinedCatalogSubruas>(entity =>
            {
                entity.ToTable("quarantined_catalog_subruas");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("quarantined_catalog_subruas_createby");

                entity.HasIndex(e => e.RuasId)
                    .HasName("quarantined_catalog_subruas_ruas");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("quarantined_catalog_subruas_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RuasId).HasColumnName("RuasID");

                entity.Property(e => e.SubRuas)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.QuarantinedCatalogSubruasCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_catalog_subruas_createby");

                entity.HasOne(d => d.Ruas)
                    .WithMany(p => p.QuarantinedCatalogSubruas)
                    .HasForeignKey(d => d.RuasId)
                    .HasConstraintName("quarantined_catalog_subruas_ruas");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.QuarantinedCatalogSubruasUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_catalog_subruas_updateby");
            });

            modelBuilder.Entity<QuarantinedCatalogs>(entity =>
            {
                entity.ToTable("quarantined_catalogs");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("quarantined_catalogs_createby");

                entity.HasIndex(e => e.Id)
                    .HasName("quarantined_catalogs_ID");

                entity.HasIndex(e => e.MemberId)
                    .HasName("quarantined_catalogs_member_idx");

                entity.HasIndex(e => e.Quarantinedby)
                    .HasName("quarantined_catalogs_qby_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("quarantined_catalogs_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApproveDateOpac).HasColumnName("ApproveDateOPAC");

                entity.Property(e => e.Author)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.Bibid)
                    .IsRequired()
                    .HasColumnName("BIBID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("Branch_id");

                entity.Property(e => e.CallNumber)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.ControlNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoverUrl)
                    .HasColumnName("CoverURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeweyNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Edition)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsBni)
                    .HasColumnName("IsBNI")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsKin)
                    .HasColumnName("IsKIN")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsOpac)
                    .HasColumnName("IsOPAC")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsRda)
                    .HasColumnName("IsRDA")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Isbn)
                    .HasColumnName("ISBN")
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Languages)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MarcLoc).HasColumnName("MARC_LOC");

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.PhysicalDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PreservasiId)
                    .HasColumnName("PRESERVASI_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Publikasi)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.PublishLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PublishYear)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Publisher)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Quarantinedby).HasColumnName("QUARANTINEDBY");

                entity.Property(e => e.Quarantineddate).HasColumnName("QUARANTINEDDATE");

                entity.Property(e => e.Quarantinedterminal)
                    .HasColumnName("QUARANTINEDTERMINAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorksheetId).HasColumnName("Worksheet_id");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.QuarantinedCatalogsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_catalogs_createby");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.QuarantinedCatalogs)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_catalogs_member");

                entity.HasOne(d => d.QuarantinedbyNavigation)
                    .WithMany(p => p.QuarantinedCatalogsQuarantinedbyNavigation)
                    .HasForeignKey(d => d.Quarantinedby)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_catalogs_qby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.QuarantinedCatalogsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_catalogs_updateby");
            });

            modelBuilder.Entity<QuarantinedCollections>(entity =>
            {
                entity.ToTable("quarantined_collections");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("quarantined_collections_createby");

                entity.HasIndex(e => e.Id)
                    .HasName("quarantined_collections_ID");

                entity.HasIndex(e => e.Quarantinedby)
                    .HasName("quarantined_collections_qby_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("quarantined_collections_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BahanSertaan)
                    .HasColumnName("BAHAN_SERTAAN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BookingExpiredDate).HasColumnType("date");

                entity.Property(e => e.BookingMemberId)
                    .HasColumnName("BookingMemberID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("Branch_id");

                entity.Property(e => e.CallNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CatalogId).HasColumnName("Catalog_id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Edisiserial)
                    .HasColumnName("EDISISERIAL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Idjilid)
                    .HasColumnName("IDJILID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsVerified)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Isopac)
                    .HasColumnName("ISOPAC")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Isreferensi)
                    .HasColumnName("ISREFERENSI")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Jilidcreateby).HasColumnName("JILIDCREATEBY");

                entity.Property(e => e.KeteranganLain)
                    .HasColumnName("KETERANGAN_LAIN")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KeteranganSumber)
                    .HasColumnName("Keterangan_Sumber")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.LocationId).HasColumnName("Location_id");

                entity.Property(e => e.LocationLibraryId).HasColumnName("Location_Library_id");

                entity.Property(e => e.MediaId).HasColumnName("Media_id");

                entity.Property(e => e.NoInduk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nojilid).HasColumnName("NOJILID");

                entity.Property(e => e.NomorBarcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nomorpanggiljilid)
                    .HasColumnName("NOMORPANGGILJILID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerId).HasColumnName("Partner_id");

                entity.Property(e => e.Price).HasColumnType("decimal(10,0)");

                entity.Property(e => e.PriceType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Quarantinedby).HasColumnName("QUARANTINEDBY");

                entity.Property(e => e.Quarantineddate)
                    .HasColumnName("QUARANTINEDDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Quarantinedterminal)
                    .HasColumnName("QUARANTINEDTERMINAL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rfid)
                    .HasColumnName("RFID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RuleId).HasColumnName("Rule_id");

                entity.Property(e => e.SourceId).HasColumnName("Source_id");

                entity.Property(e => e.StatusId)
                    .HasColumnName("Status_id")
                    .HasDefaultValueSql("'9'");

                entity.Property(e => e.TanggalTerbitEdisiSerial)
                    .HasColumnName("TANGGAL_TERBIT_EDISI_SERIAL")
                    .HasColumnType("date");

                entity.Property(e => e.Tglentryjilid)
                    .HasColumnName("TGLENTRYJILID")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.QuarantinedCollectionsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_collections_createby");

                entity.HasOne(d => d.QuarantinedbyNavigation)
                    .WithMany(p => p.QuarantinedCollectionsQuarantinedbyNavigation)
                    .HasForeignKey(d => d.Quarantinedby)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_collections_qby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.QuarantinedCollectionsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_collections_updateby");
            });

            modelBuilder.Entity<QuarantinedPengiriman>(entity =>
            {
                entity.ToTable("quarantined_pengiriman");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("quarantined_pengiriman_createby");

                entity.HasIndex(e => e.Id)
                    .HasName("quarantined_pengiriman_ID");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("quarantined_pengiriman_updateby");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CollectionId).HasColumnName("Collection_ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TanggalKirim).HasColumnType("date");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.QuarantinedPengirimanCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_pengiriman_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.QuarantinedPengirimanUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("quarantined_pengiriman_updateby");
            });

            modelBuilder.Entity<Readinlocation>(entity =>
            {
                entity.ToTable("readinlocation");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("readinlocation_createby");

                entity.HasIndex(e => e.LocationId)
                    .HasName("readinlocation_location");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("readinlocation_updateby");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Alamat)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ControlNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JenisKelamin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoBarcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoIdCard)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pendidikan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Profesi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Publisher)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title).IsRequired();

                entity.Property(e => e.TypeIdCard)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.ReadinlocationCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("readinlocation_createby");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Readinlocation)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("readinlocation_location");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.ReadinlocationUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("readinlocation_updateby");
            });

            modelBuilder.Entity<Refferenceitems>(entity =>
            {
                entity.ToTable("refferenceitems");

                entity.HasIndex(e => e.Code)
                    .HasName("refferenceitems_code");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("refferenceitems_createby");

                entity.HasIndex(e => e.RefferenceId)
                    .HasName("Refference_id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("refferenceitems_updateby");

                entity.Property(e => e.RefferenceItemsId).HasColumnName("RefferenceItemsID");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RefferenceId).HasColumnName("Refference_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.RefferenceitemsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("refferenceitems_createby");

                entity.HasOne(d => d.Refference)
                    .WithMany(p => p.Refferenceitems)
                    .HasForeignKey(d => d.RefferenceId)
                    .HasConstraintName("FKFCF3C0CBEACE6BC0");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.RefferenceitemsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("refferenceitems_updateby");
            });

            modelBuilder.Entity<Refferences>(entity =>
            {
                entity.ToTable("refferences");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("refferences_createby");

                entity.HasIndex(e => e.FormatId)
                    .HasName("refferences_format");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("refferences_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FormatId).HasColumnName("Format_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.RefferencesCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("refferences_createby");

                entity.HasOne(d => d.Format)
                    .WithMany(p => p.Refferences)
                    .HasForeignKey(d => d.FormatId)
                    .HasConstraintName("refferences_format");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.RefferencesUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("refferences_updateby");
            });

            modelBuilder.Entity<Requestcatalog>(entity =>
            {
                entity.ToTable("requestcatalog");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("requestcatalog_createby");

                entity.HasIndex(e => e.DateRequest)
                    .HasName("requestcatalog_daterequest");

                entity.HasIndex(e => e.MemberId)
                    .HasName("requestcatalog_member_idx");

                entity.HasIndex(e => e.PublishLocation)
                    .HasName("requestcatalog_PublishLocation");

                entity.HasIndex(e => e.PublishYear)
                    .HasName("requestcatalog_PublishYear");

                entity.HasIndex(e => e.Publisher)
                    .HasName("requestcatalog_Publisher");

                entity.HasIndex(e => e.Title)
                    .HasName("requestcatalog_Title");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("requestcatalog_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Author)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CallNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.PublishLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PublishYear)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Publisher)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorksheetId).HasColumnName("WorksheetID");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.RequestcatalogCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("requestcatalog_createby");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Requestcatalog)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("requestcatalog_member");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.RequestcatalogUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("requestcatalog_updateby");
            });

            modelBuilder.Entity<RfidTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rfid_temp");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("rfid_temp_createby");

                entity.HasIndex(e => e.Ip)
                    .HasName("rfid_temp_ip");

                entity.HasIndex(e => e.ItemType)
                    .HasName("rfid_temp_itemtype");

                entity.HasIndex(e => e.RfidNo)
                    .HasName("rfid_temp_rfidno");

                entity.HasIndex(e => e.SerialNumber)
                    .HasName("rfid_temp_serialnumber");

                entity.HasIndex(e => e.StatusAlarm)
                    .HasName("rfid_temp_statusalarm");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("rfid_temp_updateby");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("ip")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemType)
                    .HasColumnName("item_type")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RfidNo)
                    .HasColumnName("rfid_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusAlarm)
                    .HasColumnName("status_alarm")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("diset null jika dari service rfid lalu jika dari website.");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("rfid_temp_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("rfid_temp_updateby");
            });

            modelBuilder.Entity<Rolemodule>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.ModuleId })
                    .HasName("PRIMARY");

                entity.ToTable("rolemodule");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("rolemodule_createby");

                entity.HasIndex(e => e.IsAdd)
                    .HasName("rolemodule_isadd");

                entity.HasIndex(e => e.IsEdit)
                    .HasName("rolemodule_isedit");

                entity.HasIndex(e => e.IsView)
                    .HasName("rolemodule_isview");

                entity.HasIndex(e => e.ModuleId)
                    .HasName("Module_id");

                entity.HasIndex(e => e.RoleId)
                    .HasName("Role_id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("rolemodule_updateby");

                entity.Property(e => e.RoleId).HasColumnName("Role_id");

                entity.Property(e => e.ModuleId).HasColumnName("Module_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsAdd)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsDelete)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsEdit)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsPrint)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsView)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.RolemoduleCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("rolemodule_createby");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Rolemodule)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK4533E5AE26BAF3EC");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Rolemodule)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK4533E5AED86F6C52");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.RolemoduleUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("rolemodule_updateby");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("Application_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("roles_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("roles_createdate");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("roles_kii");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("roles_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("roles_updatedate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("Application_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK5F7A48334CBDA5AE");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.RolesCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("roles_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.RolesUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("roles_updateby");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("route");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnName("alias")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sentitems>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SequencePosition })
                    .HasName("PRIMARY");

                entity.ToTable("sentitems");

                entity.HasIndex(e => e.CollectionLoanItemId)
                    .HasName("sentitems_cli_idx");

                entity.HasIndex(e => e.DeliveryDateTime)
                    .HasName("sentitems_date");

                entity.HasIndex(e => e.DestinationNumber)
                    .HasName("sentitems_dest");

                entity.HasIndex(e => e.SenderId)
                    .HasName("sentitems_sender");

                entity.HasIndex(e => e.Tpmr)
                    .HasName("sentitems_tpmr");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.SequencePosition).HasDefaultValueSql("'1'");

                entity.Property(e => e.Class).HasDefaultValueSql("'-1'");

                entity.Property(e => e.Coding)
                    .IsRequired()
                    .HasColumnType("enum('Default_No_Compression','Unicode_No_Compression','8bit','Default_Compression','Unicode_Compression')")
                    .HasDefaultValueSql("'Default_No_Compression'");

                entity.Property(e => e.CollectionLoanItemId).HasColumnName("CollectionLoanItem_id");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasColumnName("CreatorID");

                entity.Property(e => e.DestinationNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.InsertIntoDb)
                    .HasColumnName("InsertIntoDB")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.RelativeValidity).HasDefaultValueSql("'-1'");

                entity.Property(e => e.SenderId)
                    .IsRequired()
                    .HasColumnName("SenderID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SendingDateTime).HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Smscnumber)
                    .IsRequired()
                    .HasColumnName("SMSCNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("enum('SendingOK','SendingOKNoReport','SendingError','DeliveryOK','DeliveryFailed','DeliveryPending','DeliveryUnknown','Error')")
                    .HasDefaultValueSql("'SendingOK'");

                entity.Property(e => e.StatusError).HasDefaultValueSql("'-1'");

                entity.Property(e => e.Text).IsRequired();

                entity.Property(e => e.TextDecoded).IsRequired();

                entity.Property(e => e.Tpmr)
                    .HasColumnName("TPMR")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Udh)
                    .IsRequired()
                    .HasColumnName("UDH");

                entity.Property(e => e.UpdatedInDb)
                    .HasColumnName("UpdatedInDB")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.CollectionLoanItem)
                    .WithMany(p => p.Sentitems)
                    .HasForeignKey(d => d.CollectionLoanItemId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("sentitems_cli");
            });

            modelBuilder.Entity<SerialArticlefiles>(entity =>
            {
                entity.ToTable("serial_articlefiles");

                entity.HasIndex(e => e.ArticlesId)
                    .HasName("Articles_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArticlesId).HasColumnName("Articles_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileFlash)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileUrl)
                    .HasColumnName("FileURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsFromMember)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsPublish).HasDefaultValueSql("'1'");

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.SizeFile)
                    .HasColumnName("sizeFile")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Articles)
                    .WithMany(p => p.SerialArticlefiles)
                    .HasForeignKey(d => d.ArticlesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("serial_articlefiles_ibfk_1");
            });

            modelBuilder.Entity<SerialArticles>(entity =>
            {
                entity.ToTable("serial_articles");

                entity.HasIndex(e => e.CatalogId)
                    .HasName("articles_catalog");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("articles_createby");

                entity.HasIndex(e => e.Title)
                    .HasName("idx_title");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("articles_updateby");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ArticleType)
                    .HasColumnName("Article_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CallNumber)
                    .HasColumnName("Call_Number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CatalogId).HasColumnName("Catalog_id");

                entity.Property(e => e.Contributor)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Creator)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.Ddc)
                    .HasColumnName("DDC")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Edisiserial)
                    .HasColumnName("EDISISERIAL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Isopac)
                    .HasColumnName("ISOPAC")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Subject)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.TanggalTerbitEdisiSerial)
                    .HasColumnName("TANGGAL_TERBIT_EDISI_SERIAL")
                    .HasColumnType("date");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.SerialArticles)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("articles_catalog");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.SerialArticlesCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("articles_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.SerialArticlesUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("articles_updateby");
            });

            modelBuilder.Entity<SerialArticlesRepeatable>(entity =>
            {
                entity.ToTable("serial_articles_repeatable");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("CREATE_USER");

                entity.HasIndex(e => e.SerialArticleId)
                    .HasName("SERIAL_ARTICLE_ID");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("UPDATE_USER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArticleField)
                    .HasColumnName("article_field")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerialArticleId).HasColumnName("serial_article_ID");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(111)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.SerialArticlesRepeatableCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("CREATE_USER");

                entity.HasOne(d => d.SerialArticle)
                    .WithMany(p => p.SerialArticlesRepeatable)
                    .HasForeignKey(d => d.SerialArticleId)
                    .HasConstraintName("SERIAL_ARTICLE_ID");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.SerialArticlesRepeatableUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("UPDATE_USER");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("session");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("blob");

                entity.Property(e => e.Expire).HasColumnName("expire");
            });

            modelBuilder.Entity<Settingcatalogdetail>(entity =>
            {
                entity.ToTable("settingcatalogdetail");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("settingcatalogdetail_createby");

                entity.HasIndex(e => e.FieldId)
                    .HasName("settingcatalogdetail_Field");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("settingcatalogdetail_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FieldId).HasColumnName("Field_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.SettingcatalogdetailCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("settingcatalogdetail_createby");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.Settingcatalogdetail)
                    .HasForeignKey(d => d.FieldId)
                    .HasConstraintName("settingcatalogdetail_Field");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.SettingcatalogdetailUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("settingcatalogdetail_updateby");
            });

            modelBuilder.Entity<Settingparameters>(entity =>
            {
                entity.ToTable("settingparameters");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("settingparameters_createby");

                entity.HasIndex(e => e.Name)
                    .HasName("settingparameters_name");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("settingparameters_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.SettingparametersCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("settingparameters_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.SettingparametersUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("settingparameters_updateby");
            });

            modelBuilder.Entity<Smslogs>(entity =>
            {
                entity.ToTable("smslogs");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("updateby");

                entity.HasIndex(e => e.PhoneNumber)
                    .HasName("phoneNumber_IDX");

                entity.HasIndex(e => e.RecieverId)
                    .HasName("recieverID_IDX");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("createby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phoneNumber")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecieverId).HasColumnName("recieverID");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusAnggota>(entity =>
            {
                entity.ToTable("status_anggota");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("status_anggota_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("status_anggota_updateby");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.StatusAnggotaCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("status_anggota_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.StatusAnggotaUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("status_anggota_updateby");
            });

            modelBuilder.Entity<Stockopname>(entity =>
            {
                entity.ToTable("stockopname");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("stockopname_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("stockopname_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Koordinator)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.StockopnameCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("stockopname_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.StockopnameUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("stockopname_updateby");
            });

            modelBuilder.Entity<Stockopnamedetail>(entity =>
            {
                entity.ToTable("stockopnamedetail");

                entity.HasIndex(e => e.CollectionId)
                    .HasName("stockopnamedetail_collection");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("stockopnamedetail_createby");

                entity.HasIndex(e => e.CurrentCollectionRuleId)
                    .HasName("stockopnamedetail_collectionrule2");

                entity.HasIndex(e => e.CurrentLocationId)
                    .HasName("stockopnamedetail_location2");

                entity.HasIndex(e => e.CurrentStatusId)
                    .HasName("stockopnamedetail_colstatus2");

                entity.HasIndex(e => e.PrevCollectionRuleId)
                    .HasName("stockopnamedetail_collectionrule1");

                entity.HasIndex(e => e.PrevLocationId)
                    .HasName("stockopnamedetail_location1");

                entity.HasIndex(e => e.PrevStatusId)
                    .HasName("stockopnamedetail_colstatus1");

                entity.HasIndex(e => e.StockOpnameId)
                    .HasName("stockopnamedetail_stockopname");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("stockopnamedetail_updateby");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CollectionId).HasColumnName("CollectionID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentCollectionRuleId).HasColumnName("CurrentCollectionRuleID");

                entity.Property(e => e.CurrentLocationId).HasColumnName("CurrentLocationID");

                entity.Property(e => e.CurrentStatusId).HasColumnName("CurrentStatusID");

                entity.Property(e => e.PrevCollectionRuleId).HasColumnName("PrevCollectionRuleID");

                entity.Property(e => e.PrevLocationId).HasColumnName("PrevLocationID");

                entity.Property(e => e.PrevStatusId).HasColumnName("PrevStatusID");

                entity.Property(e => e.StockOpnameId).HasColumnName("StockOpnameID");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.Stockopnamedetail)
                    .HasForeignKey(d => d.CollectionId)
                    .HasConstraintName("stockopnamedetail_collection");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.StockopnamedetailCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("stockopnamedetail_createby");

                entity.HasOne(d => d.CurrentCollectionRule)
                    .WithMany(p => p.StockopnamedetailCurrentCollectionRule)
                    .HasForeignKey(d => d.CurrentCollectionRuleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("stockopnamedetail_collectionrule2");

                entity.HasOne(d => d.CurrentLocation)
                    .WithMany(p => p.StockopnamedetailCurrentLocation)
                    .HasForeignKey(d => d.CurrentLocationId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("stockopnamedetail_location2");

                entity.HasOne(d => d.CurrentStatus)
                    .WithMany(p => p.StockopnamedetailCurrentStatus)
                    .HasForeignKey(d => d.CurrentStatusId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("stockopnamedetail_colstatus2");

                entity.HasOne(d => d.PrevCollectionRule)
                    .WithMany(p => p.StockopnamedetailPrevCollectionRule)
                    .HasForeignKey(d => d.PrevCollectionRuleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("stockopnamedetail_collectionrule1");

                entity.HasOne(d => d.PrevLocation)
                    .WithMany(p => p.StockopnamedetailPrevLocation)
                    .HasForeignKey(d => d.PrevLocationId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("stockopnamedetail_location1");

                entity.HasOne(d => d.PrevStatus)
                    .WithMany(p => p.StockopnamedetailPrevStatus)
                    .HasForeignKey(d => d.PrevStatusId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("stockopnamedetail_colstatus1");

                entity.HasOne(d => d.StockOpname)
                    .WithMany(p => p.Stockopnamedetail)
                    .HasForeignKey(d => d.StockOpnameId)
                    .HasConstraintName("stockopnamedetail_stockopname");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.StockopnamedetailUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("stockopnamedetail_updateby");
            });

            modelBuilder.Entity<Sumbangan>(entity =>
            {
                entity.ToTable("sumbangan");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("sumbangan_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("sumbangan_createdate");

                entity.HasIndex(e => e.MemberId)
                    .HasName("sumbangan_member");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("sumbangan_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Jumlah)
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId).HasColumnName("Member_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.SumbanganCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("sumbangan_createby");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Sumbangan)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("sumbangan_member");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.SumbanganUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("sumbangan_updateby");
            });

            modelBuilder.Entity<SumbanganKoleksi>(entity =>
            {
                entity.ToTable("sumbangan_koleksi");

                entity.HasIndex(e => e.CollectionId)
                    .HasName("sumbangan_koleksi_collection_idx");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("sumbangan_koleksi_createby");

                entity.HasIndex(e => e.SumbanganId)
                    .HasName("sumbangan_koleksi_sumbangan_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("sumbangan_koleksi_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CollectionId).HasColumnName("Collection_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SumbanganId).HasColumnName("Sumbangan_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.SumbanganKoleksi)
                    .HasForeignKey(d => d.CollectionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("sumbangan_koleksi_collection");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.SumbanganKoleksiCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("sumbangan_koleksi_createby");

                entity.HasOne(d => d.Sumbangan)
                    .WithMany(p => p.SumbanganKoleksi)
                    .HasForeignKey(d => d.SumbanganId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("sumbangan_koleksi_sumbangan");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.SumbanganKoleksiUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("sumbangan_koleksi_updateby");
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.ToTable("survey");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("survey_createby_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("survey_updateby_idx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HasilSurveyShow)
                    .HasDefaultValueSql("'0'")
                    .HasComment("0: Back Office dan Modul Survey, 1: Back Office");

                entity.Property(e => e.IsActive)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NamaSurvey)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomorUrut).HasDefaultValueSql("'99'");

                entity.Property(e => e.TargetSurvey)
                    .HasDefaultValueSql("'0'")
                    .HasComment("0: Semua, 1: Anggota");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.SurveyCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("survey_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.SurveyUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("survey_updateby");
            });

            modelBuilder.Entity<SurveyIsian>(entity =>
            {
                entity.ToTable("survey_isian");

                entity.HasIndex(e => e.Sesi)
                    .HasName("survey_isian_sesi");

                entity.HasIndex(e => e.SurveyPertanyaanId)
                    .HasName("survey_isian_pertanyaan_idx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sesi)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SurveyPertanyaanId).HasColumnName("Survey_Pertanyaan_id");

                entity.HasOne(d => d.SurveyPertanyaan)
                    .WithMany(p => p.SurveyIsian)
                    .HasForeignKey(d => d.SurveyPertanyaanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("survey_isian_pertanyaan");
            });

            modelBuilder.Entity<SurveyPertanyaan>(entity =>
            {
                entity.ToTable("survey_pertanyaan");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("survey_pertanyaan_createby_idx");

                entity.HasIndex(e => e.JenisPertanyaan)
                    .HasName("survey_pertanyaan_jenis");

                entity.HasIndex(e => e.NoUrut)
                    .HasName("survey_pertanyaan_nourut");

                entity.HasIndex(e => e.SurveyId)
                    .HasName("survey_pertanyaan_survey_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("survey_pertanyaan_updateby_idx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsCanMultipleAnswer)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsMandatory)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.JenisPertanyaan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Pilihan'")
                    .HasComment("Pilihan/isian");

                entity.Property(e => e.NoUrut).HasDefaultValueSql("'1'");

                entity.Property(e => e.Orientation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Vertikal'")
                    .HasComment("Vertikal/Horisontal");

                entity.Property(e => e.Pertanyaan).IsRequired();

                entity.Property(e => e.SurveyId).HasColumnName("Survey_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.SurveyPertanyaanCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("survey_pertanyaan_createby");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyPertanyaan)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("survey_pertanyaan_survey");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.SurveyPertanyaanUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("survey_pertanyaan_updateby");
            });

            modelBuilder.Entity<SurveyPilihan>(entity =>
            {
                entity.ToTable("survey_pilihan");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("survey_pilihan_createby_idx");

                entity.HasIndex(e => e.SurveyPertanyaanId)
                    .HasName("survey_pilihan_survey_pertanyaan_idx");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("survey_pilihan_updateby_idx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChoosenCount).HasDefaultValueSql("'0'");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pilihan).IsRequired();

                entity.Property(e => e.SurveyPertanyaanId).HasColumnName("Survey_Pertanyaan_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.SurveyPilihanCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("survey_pilihan_createby");

                entity.HasOne(d => d.SurveyPertanyaan)
                    .WithMany(p => p.SurveyPilihan)
                    .HasForeignKey(d => d.SurveyPertanyaanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("survey_pilihan_survey_pertanyaan");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.SurveyPilihanUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("survey_pilihan_updateby");
            });

            modelBuilder.Entity<SurveyPilihanSesi>(entity =>
            {
                entity.ToTable("survey_pilihan_sesi");

                entity.HasIndex(e => e.Sesi)
                    .HasName("survey_pilihan_sesi");

                entity.HasIndex(e => e.SurveyPilihanId)
                    .HasName("survey_pilihan_sesi_pilihan_idx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sesi)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SurveyPilihanId).HasColumnName("Survey_Pilihan_id");

                entity.HasOne(d => d.SurveyPilihan)
                    .WithMany(p => p.SurveyPilihanSesi)
                    .HasForeignKey(d => d.SurveyPilihanId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("survey_pilihan_sesi_pilihan");
            });

            modelBuilder.Entity<Tempnoinduk>(entity =>
            {
                entity.ToTable("tempnoinduk");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("tempnoinduk_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("tempnoinduk_updateby");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoInduk)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.TempnoindukCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tempnoinduk_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.TempnoindukUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tempnoinduk_updateby");
            });

            modelBuilder.Entity<TujuanKunjungan>(entity =>
            {
                entity.ToTable("tujuan_kunjungan");

                entity.HasIndex(e => e.Code)
                    .HasName("Code")
                    .IsUnique();

                entity.HasIndex(e => e.CreateBy)
                    .HasName("tujuan_kunjungan_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("tujuan_kunjungan_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Member).HasColumnType("tinyint(1)");

                entity.Property(e => e.NonMember).HasColumnType("tinyint(1)");

                entity.Property(e => e.Rombongan).HasColumnType("tinyint(1)");

                entity.Property(e => e.TujuanKunjungan1)
                    .IsRequired()
                    .HasColumnName("TujuanKunjungan")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.TujuanKunjunganCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tujuan_kunjungan_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.TujuanKunjunganUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("tujuan_kunjungan_updateby");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("user_createby");

                entity.HasIndex(e => e.Email)
                    .HasName("email")
                    .IsUnique();

                entity.HasIndex(e => e.PasswordResetToken)
                    .HasName("password_reset_token")
                    .IsUnique();

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("user");

                entity.HasIndex(e => e.Username)
                    .HasName("username")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthKey)
                    .IsRequired()
                    .HasColumnName("auth_key")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasColumnName("password_hash")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordResetToken)
                    .HasColumnName("password_reset_token")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'10'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.UserCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("user_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.UserUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("user");
            });

            modelBuilder.Entity<Userloclibforcol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userloclibforcol");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("userloclibforcol_createby");

                entity.HasIndex(e => e.LocLibId)
                    .HasName("LocLib_id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("userloclibforcol_updateby");

                entity.HasIndex(e => e.UserId)
                    .HasName("User_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocLibId).HasColumnName("LocLib_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("userloclibforcol_createby");

                entity.HasOne(d => d.LocLib)
                    .WithMany()
                    .HasForeignKey(d => d.LocLibId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_userloclibforcol_loclib");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("userloclibforcol_updateby");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_userloclibforcol_user");
            });

            modelBuilder.Entity<Userloclibforloan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userloclibforloan");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("userloclibforloan_createby");

                entity.HasIndex(e => e.LocLibId)
                    .HasName("LocLib_id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("userloclibforloan");

                entity.HasIndex(e => e.UserId)
                    .HasName("User_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocLibId).HasColumnName("LocLib_id");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("userloclibforloan_createby");

                entity.HasOne(d => d.LocLib)
                    .WithMany()
                    .HasForeignKey(d => d.LocLibId)
                    .HasConstraintName("FK_userloclibforloan_loclib");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("userloclibforloan");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_userloclibforloan_user");
            });

            modelBuilder.Entity<Userlogs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("userlogs");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("userlogs_createby");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("userlogs");

                entity.HasIndex(e => e.UserId)
                    .HasName("User_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("userlogs_createby");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("userlogs");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FKF49AED76753825B6");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.BranchId)
                    .HasName("Branch_id");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("users_createby");

                entity.HasIndex(e => e.CreateDate)
                    .HasName("users_createdate");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("Department_id");

                entity.HasIndex(e => e.IsActive)
                    .HasName("users_IsActive");

                entity.HasIndex(e => e.KiilastUploadDate)
                    .HasName("users_kii");

                entity.HasIndex(e => e.Password)
                    .HasName("Users_Password");

                entity.HasIndex(e => e.RoleId)
                    .HasName("Role_id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("users_updateby");

                entity.HasIndex(e => e.UpdateDate)
                    .HasName("users_updatedate");

                entity.HasIndex(e => e.Username)
                    .HasName("Users_UserName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActivationCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AuthKey)
                    .HasColumnName("auth_key")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("Branch_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_id");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'1'");

                entity.Property(e => e.IsAdvanceEntryCatalog)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsAdvanceEntryCollection)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsCanResetMemberPassword)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsCanResetUserPassword)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.KiilastUploadDate).HasColumnName("KIILastUploadDate");

                entity.Property(e => e.MaxDateSesId).HasColumnName("MaxDateSesID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .HasColumnName("password_hash")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordResetToken)
                    .HasColumnName("password_reset_token")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("Role_id");

                entity.Property(e => e.SesId)
                    .HasColumnName("SesID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK617D3C3A6ADC8006");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.InverseCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("users_createby");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK617D3C3AA5775E88");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK617D3C3AD86F6C52");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.InverseUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("users");
            });

            modelBuilder.Entity<Worksheetfielditems>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("worksheetfielditems");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("worksheetfielditems_createby");

                entity.HasIndex(e => e.RefferenceId)
                    .HasName("Refference_id");

                entity.HasIndex(e => e.StartPosition)
                    .HasName("WFItems_StartPosition");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("worksheetfielditems_updateby");

                entity.HasIndex(e => e.WorksheetFieldId)
                    .HasName("WorksheetField_id");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdemTag)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RefferenceId).HasColumnName("Refference_id");

                entity.Property(e => e.RefferenceMode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorksheetFieldId).HasColumnName("WorksheetField_id");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("worksheetfielditems_createby");

                entity.HasOne(d => d.Refference)
                    .WithMany()
                    .HasForeignKey(d => d.RefferenceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FKB9A428D2EACE6BC0");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("worksheetfielditems_updateby");

                entity.HasOne(d => d.WorksheetField)
                    .WithMany()
                    .HasForeignKey(d => d.WorksheetFieldId)
                    .HasConstraintName("FKB9A428D2352BBDA2");
            });

            modelBuilder.Entity<Worksheetfields>(entity =>
            {
                entity.ToTable("worksheetfields");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("worksheetfields_createby");

                entity.HasIndex(e => e.FieldId)
                    .HasName("Field_id");

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("worksheetfields_updateby");

                entity.HasIndex(e => e.WorksheetId)
                    .HasName("Worksheet_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FieldId).HasColumnName("Field_id");

                entity.Property(e => e.IsAkuisisi)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Isdeposit)
                    .HasColumnName("ISDEPOSIT")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsdetailkoleksiAkuisisi)
                    .HasColumnName("ISDETAILKOLEKSI_AKUISISI")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.IsdetailkoleksiPengolahan)
                    .HasColumnName("ISDETAILKOLEKSI_PENGOLAHAN")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorksheetId).HasColumnName("Worksheet_id");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.WorksheetfieldsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("worksheetfields_createby");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.Worksheetfields)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK1471BB4B66DFF9B4");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.WorksheetfieldsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("worksheetfields_updateby");

                entity.HasOne(d => d.Worksheet)
                    .WithMany(p => p.Worksheetfields)
                    .HasForeignKey(d => d.WorksheetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK1471BB4BFEC5D3CC");
            });

            modelBuilder.Entity<Worksheets>(entity =>
            {
                entity.ToTable("worksheets");

                entity.HasIndex(e => e.CreateBy)
                    .HasName("worksheets_createby");

                entity.HasIndex(e => e.FormatId)
                    .HasName("Format_id");

                entity.HasIndex(e => e.Name)
                    .HasName("Name")
                    .IsUnique();

                entity.HasIndex(e => e.UpdateBy)
                    .HasName("worksheets_updateby");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountPerpanjang).HasDefaultValueSql("'0'");

                entity.Property(e => e.CreateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DayPerpanjang).HasDefaultValueSql("'0'");

                entity.Property(e => e.DaySuspend).HasDefaultValueSql("'0'");

                entity.Property(e => e.DendaPerTenor)
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DendaTenorJumlah)
                    .HasColumnType("decimal(10,0)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DendaTenorMultiply).HasDefaultValueSql("'1'");

                entity.Property(e => e.DendaTenorSatuan)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Hari'");

                entity.Property(e => e.DendaType)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Konstan'");

                entity.Property(e => e.DepositformatCode)
                    .HasColumnName("DEPOSITFORMAT_CODE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FormatId).HasColumnName("Format_id");

                entity.Property(e => e.Iskartografi)
                    .HasColumnName("ISKARTOGRAFI")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Ismusik)
                    .HasColumnName("ISMUSIK")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Isserial)
                    .HasColumnName("ISSERIAL")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaxLoanDays).HasDefaultValueSql("'0'");

                entity.Property(e => e.MaxPinjamKoleksi).HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoUrut).HasDefaultValueSql("'99'");

                entity.Property(e => e.SuspendMember)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.SuspendTenorJumlah).HasDefaultValueSql("'0'");

                entity.Property(e => e.SuspendTenorMultiply).HasDefaultValueSql("'1'");

                entity.Property(e => e.SuspendTenorSatuan)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Hari'");

                entity.Property(e => e.SuspendType)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'Konstan'");

                entity.Property(e => e.UpdateTerminal)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WarningLoanDueDay).HasDefaultValueSql("'0'");

                entity.HasOne(d => d.CreateByNavigation)
                    .WithMany(p => p.WorksheetsCreateByNavigation)
                    .HasForeignKey(d => d.CreateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("worksheets_createby");

                entity.HasOne(d => d.Format)
                    .WithMany(p => p.Worksheets)
                    .HasForeignKey(d => d.FormatId)
                    .HasConstraintName("FK3800D37D5B024CA8");

                entity.HasOne(d => d.UpdateByNavigation)
                    .WithMany(p => p.WorksheetsUpdateByNavigation)
                    .HasForeignKey(d => d.UpdateBy)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("worksheets_updateby");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
