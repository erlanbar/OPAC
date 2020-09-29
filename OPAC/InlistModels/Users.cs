using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Users
    {
        public Users()
        {
            AgamaCreateByNavigation = new HashSet<Agama>();
            AgamaUpdateByNavigation = new HashSet<Agama>();
            ApplicationsCreateByNavigation = new HashSet<Applications>();
            ApplicationsUpdateByNavigation = new HashSet<Applications>();
            AuthAssignmentCreateByNavigation = new HashSet<AuthAssignment>();
            AuthAssignmentUpdateByNavigation = new HashSet<AuthAssignment>();
            AuthDataCreateByNavigation = new HashSet<AuthData>();
            AuthDataUpdateByNavigation = new HashSet<AuthData>();
            AuthHeaderCreateByNavigation = new HashSet<AuthHeader>();
            AuthHeaderUpdateByNavigation = new HashSet<AuthHeader>();
            AuthItemChildCreateByNavigation = new HashSet<AuthItemChild>();
            AuthItemChildUpdateByNavigation = new HashSet<AuthItemChild>();
            AuthItemCreateByNavigation = new HashSet<AuthItem>();
            AuthItemUpdateByNavigation = new HashSet<AuthItem>();
            AuthRuleCreateByNavigation = new HashSet<AuthRule>();
            AuthRuleUpdateByNavigation = new HashSet<AuthRule>();
            Bacaditempat = new HashSet<Bacaditempat>();
            BibidavailableCreateByNavigation = new HashSet<Bibidavailable>();
            BibidavailableUpdateByNavigation = new HashSet<Bibidavailable>();
            BookmarkCreateByNavigation = new HashSet<Bookmark>();
            BookmarkUpdateByNavigation = new HashSet<Bookmark>();
            BranchsCreateByNavigation = new HashSet<Branchs>();
            BranchsUpdateByNavigation = new HashSet<Branchs>();
            CardformatsCreateByNavigation = new HashSet<Cardformats>();
            CardformatsUpdateByNavigation = new HashSet<Cardformats>();
            CatalogRuasCreateByNavigation = new HashSet<CatalogRuas>();
            CatalogRuasUpdateByNavigation = new HashSet<CatalogRuas>();
            CatalogSubruasCreateByNavigation = new HashSet<CatalogSubruas>();
            CatalogSubruasUpdateByNavigation = new HashSet<CatalogSubruas>();
            CatalogfilesCreateByNavigation = new HashSet<Catalogfiles>();
            CatalogfilesUpdateByNavigation = new HashSet<Catalogfiles>();
            CatalogsCreateByNavigation = new HashSet<Catalogs>();
            CatalogsQuarantinedbyNavigation = new HashSet<Catalogs>();
            CatalogsUpdateByNavigation = new HashSet<Catalogs>();
            CatalogstagingCreateByNavigation = new HashSet<Catalogstaging>();
            CatalogstagingUpdateByNavigation = new HashSet<Catalogstaging>();
            CheckpointLocationsCreateByNavigation = new HashSet<CheckpointLocations>();
            CheckpointLocationsUpdateByNavigation = new HashSet<CheckpointLocations>();
            CollectioncategorysCreateByNavigation = new HashSet<Collectioncategorys>();
            CollectioncategorysUpdateByNavigation = new HashSet<Collectioncategorys>();
            CollectioncategorysdefaultCreateByNavigation = new HashSet<Collectioncategorysdefault>();
            CollectioncategorysdefaultUpdateByNavigation = new HashSet<Collectioncategorysdefault>();
            CollectioncategorysloanhariCreateByNavigation = new HashSet<Collectioncategorysloanhari>();
            CollectioncategorysloanhariUpdateByNavigation = new HashSet<Collectioncategorysloanhari>();
            CollectionloanextendsCreateByNavigation = new HashSet<Collectionloanextends>();
            CollectionloanextendsUpdateByNavigation = new HashSet<Collectionloanextends>();
            CollectionloanitemsCreateByNavigation = new HashSet<Collectionloanitems>();
            CollectionloanitemsUpdateByNavigation = new HashSet<Collectionloanitems>();
            CollectionloansCreateByNavigation = new HashSet<Collectionloans>();
            CollectionloansUpdateByNavigation = new HashSet<Collectionloans>();
            CollectionlocationsCreateByNavigation = new HashSet<Collectionlocations>();
            CollectionlocationsUpdateByNavigation = new HashSet<Collectionlocations>();
            CollectionmediasCreateByNavigation = new HashSet<Collectionmedias>();
            CollectionmediasUpdateByNavigation = new HashSet<Collectionmedias>();
            CollectionrulesCreateByNavigation = new HashSet<Collectionrules>();
            CollectionrulesUpdateByNavigation = new HashSet<Collectionrules>();
            CollectionsCreateByNavigation = new HashSet<Collections>();
            CollectionsJilidcreatebyNavigation = new HashSet<Collections>();
            CollectionsQuarantinedbyNavigation = new HashSet<Collections>();
            CollectionsUpdateByNavigation = new HashSet<Collections>();
            CollectionsourcesCreateByNavigation = new HashSet<Collectionsources>();
            CollectionsourcesUpdateByNavigation = new HashSet<Collectionsources>();
            CollectionstatusCreateByNavigation = new HashSet<Collectionstatus>();
            CollectionstatusUpdateByNavigation = new HashSet<Collectionstatus>();
            CurrencyCreateByNavigation = new HashSet<Currency>();
            CurrencyUpdateByNavigation = new HashSet<Currency>();
            DepartmentsCreateByNavigation = new HashSet<Departments>();
            DepartmentsUpdateByNavigation = new HashSet<Departments>();
            DjknDataCreateByNavigation = new HashSet<DjknData>();
            DjknDataUpdateByNavigation = new HashSet<DjknData>();
            FielddatasCreateByNavigation = new HashSet<Fielddatas>();
            FielddatasUpdateByNavigation = new HashSet<Fielddatas>();
            FieldgroupsCreateByNavigation = new HashSet<Fieldgroups>();
            FieldgroupsUpdateByNavigation = new HashSet<Fieldgroups>();
            Fieldindicator1sCreateByNavigation = new HashSet<Fieldindicator1s>();
            Fieldindicator1sUpdateByNavigation = new HashSet<Fieldindicator1s>();
            Fieldindicator2sCreateByNavigation = new HashSet<Fieldindicator2s>();
            Fieldindicator2sUpdateByNavigation = new HashSet<Fieldindicator2s>();
            FieldsCreateByNavigation = new HashSet<Fields>();
            FieldsUpdateByNavigation = new HashSet<Fields>();
            FormatsCreateByNavigation = new HashSet<Formats>();
            FormatsUpdateByNavigation = new HashSet<Formats>();
            GroupguessesCreateByNavigation = new HashSet<Groupguesses>();
            GroupguessesUpdateByNavigation = new HashSet<Groupguesses>();
            HistorydataCreateByNavigation = new HashSet<Historydata>();
            HistorydataUpdateByNavigation = new HashSet<Historydata>();
            HolidaysCreateByNavigation = new HashSet<Holidays>();
            HolidaysUpdateByNavigation = new HashSet<Holidays>();
            InverseCreateByNavigation = new HashSet<Users>();
            InverseUpdateByNavigation = new HashSet<Users>();
            JenisAnggotaCreateByNavigation = new HashSet<JenisAnggota>();
            JenisAnggotaUpdateByNavigation = new HashSet<JenisAnggota>();
            JenisDendaCreateByNavigation = new HashSet<JenisDenda>();
            JenisDendaUpdateByNavigation = new HashSet<JenisDenda>();
            JenisKelaminCreateByNavigation = new HashSet<JenisKelamin>();
            JenisKelaminUpdateByNavigation = new HashSet<JenisKelamin>();
            JenisPelanggaranCreateByNavigation = new HashSet<JenisPelanggaran>();
            JenisPelanggaranUpdateByNavigation = new HashSet<JenisPelanggaran>();
            JenisPermohonanCreateByNavigation = new HashSet<JenisPermohonan>();
            JenisPermohonanUpdateByNavigation = new HashSet<JenisPermohonan>();
            JenisPerpustakaanCreateByNavigation = new HashSet<JenisPerpustakaan>();
            JenisPerpustakaanUpdateByNavigation = new HashSet<JenisPerpustakaan>();
            KabupatenCreateByNavigation = new HashSet<Kabupaten>();
            KabupatenUpdateByNavigation = new HashSet<Kabupaten>();
            KataSandangCreateByNavigation = new HashSet<KataSandang>();
            KataSandangUpdateByNavigation = new HashSet<KataSandang>();
            KelasSiswaCreateByNavigation = new HashSet<KelasSiswa>();
            KelasSiswaUpdateByNavigation = new HashSet<KelasSiswa>();
            KelompokPelanggaranCreateByNavigation = new HashSet<KelompokPelanggaran>();
            KelompokPelanggaranUpdateByNavigation = new HashSet<KelompokPelanggaran>();
            KeranjangAnggotaCreateByNavigation = new HashSet<KeranjangAnggota>();
            KeranjangAnggotaUpdateByNavigation = new HashSet<KeranjangAnggota>();
            KeranjangKatalogCreateByNavigation = new HashSet<KeranjangKatalog>();
            KeranjangKatalogUpdateByNavigation = new HashSet<KeranjangKatalog>();
            KeranjangKoleksiCreateByNavigation = new HashSet<KeranjangKoleksi>();
            KeranjangKoleksiUpdateByNavigation = new HashSet<KeranjangKoleksi>();
            KriteriaKoleksiCreateByNavigation = new HashSet<KriteriaKoleksi>();
            KriteriaKoleksiUpdateByNavigation = new HashSet<KriteriaKoleksi>();
            LibraryCreateByNavigation = new HashSet<Library>();
            LibraryUpdateByNavigation = new HashSet<Library>();
            LibrarysearchcriteriaCreateByNavigation = new HashSet<Librarysearchcriteria>();
            LibrarysearchcriteriaUpdateByNavigation = new HashSet<Librarysearchcriteria>();
            LocationLibraryCreateByNavigation = new HashSet<LocationLibrary>();
            LocationLibraryDefaultCreateByNavigation = new HashSet<LocationLibraryDefault>();
            LocationLibraryDefaultUpdateByNavigation = new HashSet<LocationLibraryDefault>();
            LocationLibraryUpdateByNavigation = new HashSet<LocationLibrary>();
            LocationsCreateByNavigation = new HashSet<Locations>();
            LocationsUpdateByNavigation = new HashSet<Locations>();
            LockersCreateByNavigation = new HashSet<Lockers>();
            LockersUpdateByNavigation = new HashSet<Lockers>();
            MailserverCreateByNavigation = new HashSet<Mailserver>();
            MailserverUpdateByNavigation = new HashSet<Mailserver>();
            MasaBerlakuAnggotaCreateByNavigation = new HashSet<MasaBerlakuAnggota>();
            MasaBerlakuAnggotaUpdateByNavigation = new HashSet<MasaBerlakuAnggota>();
            MasterDjknCreateByNavigation = new HashSet<MasterDjkn>();
            MasterDjknUpdateByNavigation = new HashSet<MasterDjkn>();
            MasterFakultasCreateByNavigation = new HashSet<MasterFakultas>();
            MasterFakultasUpdateByNavigation = new HashSet<MasterFakultas>();
            MasterJenisIdentitasCreateByNavigation = new HashSet<MasterJenisIdentitas>();
            MasterJenisIdentitasUpdateByNavigation = new HashSet<MasterJenisIdentitas>();
            MasterJurusanCreateByNavigation = new HashSet<MasterJurusan>();
            MasterJurusanUpdateByNavigation = new HashSet<MasterJurusan>();
            MasterKelasBesarCreateByNavigation = new HashSet<MasterKelasBesar>();
            MasterKelasBesarUpdateByNavigation = new HashSet<MasterKelasBesar>();
            MasterKependudukanCreateByNavigation = new HashSet<MasterKependudukan>();
            MasterKependudukanUpdateByNavigation = new HashSet<MasterKependudukan>();
            MasterLokerCreateByNavigation = new HashSet<MasterLoker>();
            MasterLokerUpdateByNavigation = new HashSet<MasterLoker>();
            MasterPekerjaanCreateByNavigation = new HashSet<MasterPekerjaan>();
            MasterPekerjaanUpdateByNavigation = new HashSet<MasterPekerjaan>();
            MasterPendidikanCreateByNavigation = new HashSet<MasterPendidikan>();
            MasterPendidikanUpdateByNavigation = new HashSet<MasterPendidikan>();
            MasterProgramStudiCreateByNavigation = new HashSet<MasterProgramStudi>();
            MasterProgramStudiUpdateByNavigation = new HashSet<MasterProgramStudi>();
            MasterRangeUmurCreateByNavigation = new HashSet<MasterRangeUmur>();
            MasterRangeUmurUpdateByNavigation = new HashSet<MasterRangeUmur>();
            MasterStatusPerkawinanCreateByNavigation = new HashSet<MasterStatusPerkawinan>();
            MasterStatusPerkawinanUpdateByNavigation = new HashSet<MasterStatusPerkawinan>();
            MemberFieldsCreateByNavigation = new HashSet<MemberFields>();
            MemberFieldsUpdateByNavigation = new HashSet<MemberFields>();
            MemberPerpanjanganCreateByNavigation = new HashSet<MemberPerpanjangan>();
            MemberPerpanjanganUpdateByNavigation = new HashSet<MemberPerpanjangan>();
            MemberguessesCreateByNavigation = new HashSet<Memberguesses>();
            MemberguessesUpdateByNavigation = new HashSet<Memberguesses>();
            MemberloanauthorizecategoryCreateByNavigation = new HashSet<Memberloanauthorizecategory>();
            MemberloanauthorizecategoryUpdateByNavigation = new HashSet<Memberloanauthorizecategory>();
            MemberloanauthorizelocationCreateByNavigation = new HashSet<Memberloanauthorizelocation>();
            MemberloanauthorizelocationUpdateByNavigation = new HashSet<Memberloanauthorizelocation>();
            MemberrulesCreateByNavigation = new HashSet<Memberrules>();
            MemberrulesUpdateByNavigation = new HashSet<Memberrules>();
            MembersCreateByNavigation = new HashSet<Members>();
            MembersFormCreateByNavigation = new HashSet<MembersForm>();
            MembersFormListCreateByNavigation = new HashSet<MembersFormList>();
            MembersFormListUpdateByNavigation = new HashSet<MembersFormList>();
            MembersFormUpdateByNavigation = new HashSet<MembersForm>();
            MembersInfoFormCreateByNavigation = new HashSet<MembersInfoForm>();
            MembersInfoFormUpdateByNavigation = new HashSet<MembersInfoForm>();
            MembersLoanFormCreateByNavigation = new HashSet<MembersLoanForm>();
            MembersLoanFormUpdateByNavigation = new HashSet<MembersLoanForm>();
            MembersLoanreturnFormCreateByNavigation = new HashSet<MembersLoanreturnForm>();
            MembersLoanreturnFormUpdateByNavigation = new HashSet<MembersLoanreturnForm>();
            MembersOnlineFormCreateByNavigation = new HashSet<MembersOnlineForm>();
            MembersOnlineFormEditCreateByNavigation = new HashSet<MembersOnlineFormEdit>();
            MembersOnlineFormEditUpdateByNavigation = new HashSet<MembersOnlineFormEdit>();
            MembersOnlineFormUpdateByNavigation = new HashSet<MembersOnlineForm>();
            MembersUpdateByNavigation = new HashSet<Members>();
            MembersonlineCreateByNavigation = new HashSet<Membersonline>();
            MembersonlineUpdateByNavigation = new HashSet<Membersonline>();
            MenuCreateByNavigation = new HashSet<Menu>();
            MenuUpdateByNavigation = new HashSet<Menu>();
            MigrationCreateByNavigation = new HashSet<Migration>();
            MigrationUpdateByNavigation = new HashSet<Migration>();
            ModulesCreateByNavigation = new HashSet<Modules>();
            ModulesUpdateByNavigation = new HashSet<Modules>();
            OpacfieldsCreateByNavigation = new HashSet<Opacfields>();
            OpacfieldsUpdateByNavigation = new HashSet<Opacfields>();
            OpaclogsCreateByNavigation = new HashSet<Opaclogs>();
            OpaclogsUpdateByNavigation = new HashSet<Opaclogs>();
            PartnersCreateByNavigation = new HashSet<Partners>();
            PartnersUpdateByNavigation = new HashSet<Partners>();
            PelanggaranCreateByNavigation = new HashSet<Pelanggaran>();
            PelanggaranUpdateByNavigation = new HashSet<Pelanggaran>();
            PengirimanCreateByNavigation = new HashSet<Pengiriman>();
            PengirimanUpdateByNavigation = new HashSet<Pengiriman>();
            PeraturanPeminjamanHariCreateByNavigation = new HashSet<PeraturanPeminjamanHari>();
            PeraturanPeminjamanHariUpdateByNavigation = new HashSet<PeraturanPeminjamanHari>();
            PeraturanPeminjamanTanggalCreateByNavigation = new HashSet<PeraturanPeminjamanTanggal>();
            PeraturanPeminjamanTanggalUpdateByNavigation = new HashSet<PeraturanPeminjamanTanggal>();
            PropinsiCreateByNavigation = new HashSet<Propinsi>();
            PropinsiUpdateByNavigation = new HashSet<Propinsi>();
            PublishersCreateByNavigation = new HashSet<Publishers>();
            PublishersUpdateByNavigation = new HashSet<Publishers>();
            QuarantinedAuthDataCreateByNavigation = new HashSet<QuarantinedAuthData>();
            QuarantinedAuthDataUpdateByNavigation = new HashSet<QuarantinedAuthData>();
            QuarantinedAuthHeaderCreateByNavigation = new HashSet<QuarantinedAuthHeader>();
            QuarantinedAuthHeaderUpdateByNavigation = new HashSet<QuarantinedAuthHeader>();
            QuarantinedCatalogRuasCreateByNavigation = new HashSet<QuarantinedCatalogRuas>();
            QuarantinedCatalogRuasUpdateByNavigation = new HashSet<QuarantinedCatalogRuas>();
            QuarantinedCatalogSubruasCreateByNavigation = new HashSet<QuarantinedCatalogSubruas>();
            QuarantinedCatalogSubruasUpdateByNavigation = new HashSet<QuarantinedCatalogSubruas>();
            QuarantinedCatalogsCreateByNavigation = new HashSet<QuarantinedCatalogs>();
            QuarantinedCatalogsQuarantinedbyNavigation = new HashSet<QuarantinedCatalogs>();
            QuarantinedCatalogsUpdateByNavigation = new HashSet<QuarantinedCatalogs>();
            QuarantinedCollectionsCreateByNavigation = new HashSet<QuarantinedCollections>();
            QuarantinedCollectionsQuarantinedbyNavigation = new HashSet<QuarantinedCollections>();
            QuarantinedCollectionsUpdateByNavigation = new HashSet<QuarantinedCollections>();
            QuarantinedPengirimanCreateByNavigation = new HashSet<QuarantinedPengiriman>();
            QuarantinedPengirimanUpdateByNavigation = new HashSet<QuarantinedPengiriman>();
            ReadinlocationCreateByNavigation = new HashSet<Readinlocation>();
            ReadinlocationUpdateByNavigation = new HashSet<Readinlocation>();
            RefferenceitemsCreateByNavigation = new HashSet<Refferenceitems>();
            RefferenceitemsUpdateByNavigation = new HashSet<Refferenceitems>();
            RefferencesCreateByNavigation = new HashSet<Refferences>();
            RefferencesUpdateByNavigation = new HashSet<Refferences>();
            RequestcatalogCreateByNavigation = new HashSet<Requestcatalog>();
            RequestcatalogUpdateByNavigation = new HashSet<Requestcatalog>();
            RolemoduleCreateByNavigation = new HashSet<Rolemodule>();
            RolemoduleUpdateByNavigation = new HashSet<Rolemodule>();
            RolesCreateByNavigation = new HashSet<Roles>();
            RolesUpdateByNavigation = new HashSet<Roles>();
            SerialArticlesCreateByNavigation = new HashSet<SerialArticles>();
            SerialArticlesRepeatableCreateByNavigation = new HashSet<SerialArticlesRepeatable>();
            SerialArticlesRepeatableUpdateByNavigation = new HashSet<SerialArticlesRepeatable>();
            SerialArticlesUpdateByNavigation = new HashSet<SerialArticles>();
            SettingcatalogdetailCreateByNavigation = new HashSet<Settingcatalogdetail>();
            SettingcatalogdetailUpdateByNavigation = new HashSet<Settingcatalogdetail>();
            SettingparametersCreateByNavigation = new HashSet<Settingparameters>();
            SettingparametersUpdateByNavigation = new HashSet<Settingparameters>();
            StatusAnggotaCreateByNavigation = new HashSet<StatusAnggota>();
            StatusAnggotaUpdateByNavigation = new HashSet<StatusAnggota>();
            StockopnameCreateByNavigation = new HashSet<Stockopname>();
            StockopnameUpdateByNavigation = new HashSet<Stockopname>();
            StockopnamedetailCreateByNavigation = new HashSet<Stockopnamedetail>();
            StockopnamedetailUpdateByNavigation = new HashSet<Stockopnamedetail>();
            SumbanganCreateByNavigation = new HashSet<Sumbangan>();
            SumbanganKoleksiCreateByNavigation = new HashSet<SumbanganKoleksi>();
            SumbanganKoleksiUpdateByNavigation = new HashSet<SumbanganKoleksi>();
            SumbanganUpdateByNavigation = new HashSet<Sumbangan>();
            SurveyCreateByNavigation = new HashSet<Survey>();
            SurveyPertanyaanCreateByNavigation = new HashSet<SurveyPertanyaan>();
            SurveyPertanyaanUpdateByNavigation = new HashSet<SurveyPertanyaan>();
            SurveyPilihanCreateByNavigation = new HashSet<SurveyPilihan>();
            SurveyPilihanUpdateByNavigation = new HashSet<SurveyPilihan>();
            SurveyUpdateByNavigation = new HashSet<Survey>();
            TempnoindukCreateByNavigation = new HashSet<Tempnoinduk>();
            TempnoindukUpdateByNavigation = new HashSet<Tempnoinduk>();
            TujuanKunjunganCreateByNavigation = new HashSet<TujuanKunjungan>();
            TujuanKunjunganUpdateByNavigation = new HashSet<TujuanKunjungan>();
            UserCreateByNavigation = new HashSet<User>();
            UserUpdateByNavigation = new HashSet<User>();
            WorksheetfieldsCreateByNavigation = new HashSet<Worksheetfields>();
            WorksheetfieldsUpdateByNavigation = new HashSet<Worksheetfields>();
            WorksheetsCreateByNavigation = new HashSet<Worksheets>();
            WorksheetsUpdateByNavigation = new HashSet<Worksheets>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AuthKey { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordResetToken { get; set; }
        public short? Status { get; set; }
        public string PhotoUrl { get; set; }
        public string Fullname { get; set; }
        public string EmailAddress { get; set; }
        public short? IsActive { get; set; }
        public string SesId { get; set; }
        public DateTime? MaxDateSesId { get; set; }
        public string ActivationCode { get; set; }
        public int? LoginAttemp { get; set; }
        public DateTime? LastSubmtLogin { get; set; }
        public DateTime? LastSuccess { get; set; }
        public int? DepartmentId { get; set; }
        public int? BranchId { get; set; }
        public int RoleId { get; set; }
        public short? IsCanResetUserPassword { get; set; }
        public short? IsCanResetMemberPassword { get; set; }
        public short? IsAdvanceEntryCatalog { get; set; }
        public short? IsAdvanceEntryCollection { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public int? CreatedAt { get; set; }
        public int? UpdatedAt { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Branchs Branch { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Departments Department { get; set; }
        public virtual Roles Role { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Agama> AgamaCreateByNavigation { get; set; }
        public virtual ICollection<Agama> AgamaUpdateByNavigation { get; set; }
        public virtual ICollection<Applications> ApplicationsCreateByNavigation { get; set; }
        public virtual ICollection<Applications> ApplicationsUpdateByNavigation { get; set; }
        public virtual ICollection<AuthAssignment> AuthAssignmentCreateByNavigation { get; set; }
        public virtual ICollection<AuthAssignment> AuthAssignmentUpdateByNavigation { get; set; }
        public virtual ICollection<AuthData> AuthDataCreateByNavigation { get; set; }
        public virtual ICollection<AuthData> AuthDataUpdateByNavigation { get; set; }
        public virtual ICollection<AuthHeader> AuthHeaderCreateByNavigation { get; set; }
        public virtual ICollection<AuthHeader> AuthHeaderUpdateByNavigation { get; set; }
        public virtual ICollection<AuthItemChild> AuthItemChildCreateByNavigation { get; set; }
        public virtual ICollection<AuthItemChild> AuthItemChildUpdateByNavigation { get; set; }
        public virtual ICollection<AuthItem> AuthItemCreateByNavigation { get; set; }
        public virtual ICollection<AuthItem> AuthItemUpdateByNavigation { get; set; }
        public virtual ICollection<AuthRule> AuthRuleCreateByNavigation { get; set; }
        public virtual ICollection<AuthRule> AuthRuleUpdateByNavigation { get; set; }
        public virtual ICollection<Bacaditempat> Bacaditempat { get; set; }
        public virtual ICollection<Bibidavailable> BibidavailableCreateByNavigation { get; set; }
        public virtual ICollection<Bibidavailable> BibidavailableUpdateByNavigation { get; set; }
        public virtual ICollection<Bookmark> BookmarkCreateByNavigation { get; set; }
        public virtual ICollection<Bookmark> BookmarkUpdateByNavigation { get; set; }
        public virtual ICollection<Branchs> BranchsCreateByNavigation { get; set; }
        public virtual ICollection<Branchs> BranchsUpdateByNavigation { get; set; }
        public virtual ICollection<Cardformats> CardformatsCreateByNavigation { get; set; }
        public virtual ICollection<Cardformats> CardformatsUpdateByNavigation { get; set; }
        public virtual ICollection<CatalogRuas> CatalogRuasCreateByNavigation { get; set; }
        public virtual ICollection<CatalogRuas> CatalogRuasUpdateByNavigation { get; set; }
        public virtual ICollection<CatalogSubruas> CatalogSubruasCreateByNavigation { get; set; }
        public virtual ICollection<CatalogSubruas> CatalogSubruasUpdateByNavigation { get; set; }
        public virtual ICollection<Catalogfiles> CatalogfilesCreateByNavigation { get; set; }
        public virtual ICollection<Catalogfiles> CatalogfilesUpdateByNavigation { get; set; }
        public virtual ICollection<Catalogs> CatalogsCreateByNavigation { get; set; }
        public virtual ICollection<Catalogs> CatalogsQuarantinedbyNavigation { get; set; }
        public virtual ICollection<Catalogs> CatalogsUpdateByNavigation { get; set; }
        public virtual ICollection<Catalogstaging> CatalogstagingCreateByNavigation { get; set; }
        public virtual ICollection<Catalogstaging> CatalogstagingUpdateByNavigation { get; set; }
        public virtual ICollection<CheckpointLocations> CheckpointLocationsCreateByNavigation { get; set; }
        public virtual ICollection<CheckpointLocations> CheckpointLocationsUpdateByNavigation { get; set; }
        public virtual ICollection<Collectioncategorys> CollectioncategorysCreateByNavigation { get; set; }
        public virtual ICollection<Collectioncategorys> CollectioncategorysUpdateByNavigation { get; set; }
        public virtual ICollection<Collectioncategorysdefault> CollectioncategorysdefaultCreateByNavigation { get; set; }
        public virtual ICollection<Collectioncategorysdefault> CollectioncategorysdefaultUpdateByNavigation { get; set; }
        public virtual ICollection<Collectioncategorysloanhari> CollectioncategorysloanhariCreateByNavigation { get; set; }
        public virtual ICollection<Collectioncategorysloanhari> CollectioncategorysloanhariUpdateByNavigation { get; set; }
        public virtual ICollection<Collectionloanextends> CollectionloanextendsCreateByNavigation { get; set; }
        public virtual ICollection<Collectionloanextends> CollectionloanextendsUpdateByNavigation { get; set; }
        public virtual ICollection<Collectionloanitems> CollectionloanitemsCreateByNavigation { get; set; }
        public virtual ICollection<Collectionloanitems> CollectionloanitemsUpdateByNavigation { get; set; }
        public virtual ICollection<Collectionloans> CollectionloansCreateByNavigation { get; set; }
        public virtual ICollection<Collectionloans> CollectionloansUpdateByNavigation { get; set; }
        public virtual ICollection<Collectionlocations> CollectionlocationsCreateByNavigation { get; set; }
        public virtual ICollection<Collectionlocations> CollectionlocationsUpdateByNavigation { get; set; }
        public virtual ICollection<Collectionmedias> CollectionmediasCreateByNavigation { get; set; }
        public virtual ICollection<Collectionmedias> CollectionmediasUpdateByNavigation { get; set; }
        public virtual ICollection<Collectionrules> CollectionrulesCreateByNavigation { get; set; }
        public virtual ICollection<Collectionrules> CollectionrulesUpdateByNavigation { get; set; }
        public virtual ICollection<Collections> CollectionsCreateByNavigation { get; set; }
        public virtual ICollection<Collections> CollectionsJilidcreatebyNavigation { get; set; }
        public virtual ICollection<Collections> CollectionsQuarantinedbyNavigation { get; set; }
        public virtual ICollection<Collections> CollectionsUpdateByNavigation { get; set; }
        public virtual ICollection<Collectionsources> CollectionsourcesCreateByNavigation { get; set; }
        public virtual ICollection<Collectionsources> CollectionsourcesUpdateByNavigation { get; set; }
        public virtual ICollection<Collectionstatus> CollectionstatusCreateByNavigation { get; set; }
        public virtual ICollection<Collectionstatus> CollectionstatusUpdateByNavigation { get; set; }
        public virtual ICollection<Currency> CurrencyCreateByNavigation { get; set; }
        public virtual ICollection<Currency> CurrencyUpdateByNavigation { get; set; }
        public virtual ICollection<Departments> DepartmentsCreateByNavigation { get; set; }
        public virtual ICollection<Departments> DepartmentsUpdateByNavigation { get; set; }
        public virtual ICollection<DjknData> DjknDataCreateByNavigation { get; set; }
        public virtual ICollection<DjknData> DjknDataUpdateByNavigation { get; set; }
        public virtual ICollection<Fielddatas> FielddatasCreateByNavigation { get; set; }
        public virtual ICollection<Fielddatas> FielddatasUpdateByNavigation { get; set; }
        public virtual ICollection<Fieldgroups> FieldgroupsCreateByNavigation { get; set; }
        public virtual ICollection<Fieldgroups> FieldgroupsUpdateByNavigation { get; set; }
        public virtual ICollection<Fieldindicator1s> Fieldindicator1sCreateByNavigation { get; set; }
        public virtual ICollection<Fieldindicator1s> Fieldindicator1sUpdateByNavigation { get; set; }
        public virtual ICollection<Fieldindicator2s> Fieldindicator2sCreateByNavigation { get; set; }
        public virtual ICollection<Fieldindicator2s> Fieldindicator2sUpdateByNavigation { get; set; }
        public virtual ICollection<Fields> FieldsCreateByNavigation { get; set; }
        public virtual ICollection<Fields> FieldsUpdateByNavigation { get; set; }
        public virtual ICollection<Formats> FormatsCreateByNavigation { get; set; }
        public virtual ICollection<Formats> FormatsUpdateByNavigation { get; set; }
        public virtual ICollection<Groupguesses> GroupguessesCreateByNavigation { get; set; }
        public virtual ICollection<Groupguesses> GroupguessesUpdateByNavigation { get; set; }
        public virtual ICollection<Historydata> HistorydataCreateByNavigation { get; set; }
        public virtual ICollection<Historydata> HistorydataUpdateByNavigation { get; set; }
        public virtual ICollection<Holidays> HolidaysCreateByNavigation { get; set; }
        public virtual ICollection<Holidays> HolidaysUpdateByNavigation { get; set; }
        public virtual ICollection<Users> InverseCreateByNavigation { get; set; }
        public virtual ICollection<Users> InverseUpdateByNavigation { get; set; }
        public virtual ICollection<JenisAnggota> JenisAnggotaCreateByNavigation { get; set; }
        public virtual ICollection<JenisAnggota> JenisAnggotaUpdateByNavigation { get; set; }
        public virtual ICollection<JenisDenda> JenisDendaCreateByNavigation { get; set; }
        public virtual ICollection<JenisDenda> JenisDendaUpdateByNavigation { get; set; }
        public virtual ICollection<JenisKelamin> JenisKelaminCreateByNavigation { get; set; }
        public virtual ICollection<JenisKelamin> JenisKelaminUpdateByNavigation { get; set; }
        public virtual ICollection<JenisPelanggaran> JenisPelanggaranCreateByNavigation { get; set; }
        public virtual ICollection<JenisPelanggaran> JenisPelanggaranUpdateByNavigation { get; set; }
        public virtual ICollection<JenisPermohonan> JenisPermohonanCreateByNavigation { get; set; }
        public virtual ICollection<JenisPermohonan> JenisPermohonanUpdateByNavigation { get; set; }
        public virtual ICollection<JenisPerpustakaan> JenisPerpustakaanCreateByNavigation { get; set; }
        public virtual ICollection<JenisPerpustakaan> JenisPerpustakaanUpdateByNavigation { get; set; }
        public virtual ICollection<Kabupaten> KabupatenCreateByNavigation { get; set; }
        public virtual ICollection<Kabupaten> KabupatenUpdateByNavigation { get; set; }
        public virtual ICollection<KataSandang> KataSandangCreateByNavigation { get; set; }
        public virtual ICollection<KataSandang> KataSandangUpdateByNavigation { get; set; }
        public virtual ICollection<KelasSiswa> KelasSiswaCreateByNavigation { get; set; }
        public virtual ICollection<KelasSiswa> KelasSiswaUpdateByNavigation { get; set; }
        public virtual ICollection<KelompokPelanggaran> KelompokPelanggaranCreateByNavigation { get; set; }
        public virtual ICollection<KelompokPelanggaran> KelompokPelanggaranUpdateByNavigation { get; set; }
        public virtual ICollection<KeranjangAnggota> KeranjangAnggotaCreateByNavigation { get; set; }
        public virtual ICollection<KeranjangAnggota> KeranjangAnggotaUpdateByNavigation { get; set; }
        public virtual ICollection<KeranjangKatalog> KeranjangKatalogCreateByNavigation { get; set; }
        public virtual ICollection<KeranjangKatalog> KeranjangKatalogUpdateByNavigation { get; set; }
        public virtual ICollection<KeranjangKoleksi> KeranjangKoleksiCreateByNavigation { get; set; }
        public virtual ICollection<KeranjangKoleksi> KeranjangKoleksiUpdateByNavigation { get; set; }
        public virtual ICollection<KriteriaKoleksi> KriteriaKoleksiCreateByNavigation { get; set; }
        public virtual ICollection<KriteriaKoleksi> KriteriaKoleksiUpdateByNavigation { get; set; }
        public virtual ICollection<Library> LibraryCreateByNavigation { get; set; }
        public virtual ICollection<Library> LibraryUpdateByNavigation { get; set; }
        public virtual ICollection<Librarysearchcriteria> LibrarysearchcriteriaCreateByNavigation { get; set; }
        public virtual ICollection<Librarysearchcriteria> LibrarysearchcriteriaUpdateByNavigation { get; set; }
        public virtual ICollection<LocationLibrary> LocationLibraryCreateByNavigation { get; set; }
        public virtual ICollection<LocationLibraryDefault> LocationLibraryDefaultCreateByNavigation { get; set; }
        public virtual ICollection<LocationLibraryDefault> LocationLibraryDefaultUpdateByNavigation { get; set; }
        public virtual ICollection<LocationLibrary> LocationLibraryUpdateByNavigation { get; set; }
        public virtual ICollection<Locations> LocationsCreateByNavigation { get; set; }
        public virtual ICollection<Locations> LocationsUpdateByNavigation { get; set; }
        public virtual ICollection<Lockers> LockersCreateByNavigation { get; set; }
        public virtual ICollection<Lockers> LockersUpdateByNavigation { get; set; }
        public virtual ICollection<Mailserver> MailserverCreateByNavigation { get; set; }
        public virtual ICollection<Mailserver> MailserverUpdateByNavigation { get; set; }
        public virtual ICollection<MasaBerlakuAnggota> MasaBerlakuAnggotaCreateByNavigation { get; set; }
        public virtual ICollection<MasaBerlakuAnggota> MasaBerlakuAnggotaUpdateByNavigation { get; set; }
        public virtual ICollection<MasterDjkn> MasterDjknCreateByNavigation { get; set; }
        public virtual ICollection<MasterDjkn> MasterDjknUpdateByNavigation { get; set; }
        public virtual ICollection<MasterFakultas> MasterFakultasCreateByNavigation { get; set; }
        public virtual ICollection<MasterFakultas> MasterFakultasUpdateByNavigation { get; set; }
        public virtual ICollection<MasterJenisIdentitas> MasterJenisIdentitasCreateByNavigation { get; set; }
        public virtual ICollection<MasterJenisIdentitas> MasterJenisIdentitasUpdateByNavigation { get; set; }
        public virtual ICollection<MasterJurusan> MasterJurusanCreateByNavigation { get; set; }
        public virtual ICollection<MasterJurusan> MasterJurusanUpdateByNavigation { get; set; }
        public virtual ICollection<MasterKelasBesar> MasterKelasBesarCreateByNavigation { get; set; }
        public virtual ICollection<MasterKelasBesar> MasterKelasBesarUpdateByNavigation { get; set; }
        public virtual ICollection<MasterKependudukan> MasterKependudukanCreateByNavigation { get; set; }
        public virtual ICollection<MasterKependudukan> MasterKependudukanUpdateByNavigation { get; set; }
        public virtual ICollection<MasterLoker> MasterLokerCreateByNavigation { get; set; }
        public virtual ICollection<MasterLoker> MasterLokerUpdateByNavigation { get; set; }
        public virtual ICollection<MasterPekerjaan> MasterPekerjaanCreateByNavigation { get; set; }
        public virtual ICollection<MasterPekerjaan> MasterPekerjaanUpdateByNavigation { get; set; }
        public virtual ICollection<MasterPendidikan> MasterPendidikanCreateByNavigation { get; set; }
        public virtual ICollection<MasterPendidikan> MasterPendidikanUpdateByNavigation { get; set; }
        public virtual ICollection<MasterProgramStudi> MasterProgramStudiCreateByNavigation { get; set; }
        public virtual ICollection<MasterProgramStudi> MasterProgramStudiUpdateByNavigation { get; set; }
        public virtual ICollection<MasterRangeUmur> MasterRangeUmurCreateByNavigation { get; set; }
        public virtual ICollection<MasterRangeUmur> MasterRangeUmurUpdateByNavigation { get; set; }
        public virtual ICollection<MasterStatusPerkawinan> MasterStatusPerkawinanCreateByNavigation { get; set; }
        public virtual ICollection<MasterStatusPerkawinan> MasterStatusPerkawinanUpdateByNavigation { get; set; }
        public virtual ICollection<MemberFields> MemberFieldsCreateByNavigation { get; set; }
        public virtual ICollection<MemberFields> MemberFieldsUpdateByNavigation { get; set; }
        public virtual ICollection<MemberPerpanjangan> MemberPerpanjanganCreateByNavigation { get; set; }
        public virtual ICollection<MemberPerpanjangan> MemberPerpanjanganUpdateByNavigation { get; set; }
        public virtual ICollection<Memberguesses> MemberguessesCreateByNavigation { get; set; }
        public virtual ICollection<Memberguesses> MemberguessesUpdateByNavigation { get; set; }
        public virtual ICollection<Memberloanauthorizecategory> MemberloanauthorizecategoryCreateByNavigation { get; set; }
        public virtual ICollection<Memberloanauthorizecategory> MemberloanauthorizecategoryUpdateByNavigation { get; set; }
        public virtual ICollection<Memberloanauthorizelocation> MemberloanauthorizelocationCreateByNavigation { get; set; }
        public virtual ICollection<Memberloanauthorizelocation> MemberloanauthorizelocationUpdateByNavigation { get; set; }
        public virtual ICollection<Memberrules> MemberrulesCreateByNavigation { get; set; }
        public virtual ICollection<Memberrules> MemberrulesUpdateByNavigation { get; set; }
        public virtual ICollection<Members> MembersCreateByNavigation { get; set; }
        public virtual ICollection<MembersForm> MembersFormCreateByNavigation { get; set; }
        public virtual ICollection<MembersFormList> MembersFormListCreateByNavigation { get; set; }
        public virtual ICollection<MembersFormList> MembersFormListUpdateByNavigation { get; set; }
        public virtual ICollection<MembersForm> MembersFormUpdateByNavigation { get; set; }
        public virtual ICollection<MembersInfoForm> MembersInfoFormCreateByNavigation { get; set; }
        public virtual ICollection<MembersInfoForm> MembersInfoFormUpdateByNavigation { get; set; }
        public virtual ICollection<MembersLoanForm> MembersLoanFormCreateByNavigation { get; set; }
        public virtual ICollection<MembersLoanForm> MembersLoanFormUpdateByNavigation { get; set; }
        public virtual ICollection<MembersLoanreturnForm> MembersLoanreturnFormCreateByNavigation { get; set; }
        public virtual ICollection<MembersLoanreturnForm> MembersLoanreturnFormUpdateByNavigation { get; set; }
        public virtual ICollection<MembersOnlineForm> MembersOnlineFormCreateByNavigation { get; set; }
        public virtual ICollection<MembersOnlineFormEdit> MembersOnlineFormEditCreateByNavigation { get; set; }
        public virtual ICollection<MembersOnlineFormEdit> MembersOnlineFormEditUpdateByNavigation { get; set; }
        public virtual ICollection<MembersOnlineForm> MembersOnlineFormUpdateByNavigation { get; set; }
        public virtual ICollection<Members> MembersUpdateByNavigation { get; set; }
        public virtual ICollection<Membersonline> MembersonlineCreateByNavigation { get; set; }
        public virtual ICollection<Membersonline> MembersonlineUpdateByNavigation { get; set; }
        public virtual ICollection<Menu> MenuCreateByNavigation { get; set; }
        public virtual ICollection<Menu> MenuUpdateByNavigation { get; set; }
        public virtual ICollection<Migration> MigrationCreateByNavigation { get; set; }
        public virtual ICollection<Migration> MigrationUpdateByNavigation { get; set; }
        public virtual ICollection<Modules> ModulesCreateByNavigation { get; set; }
        public virtual ICollection<Modules> ModulesUpdateByNavigation { get; set; }
        public virtual ICollection<Opacfields> OpacfieldsCreateByNavigation { get; set; }
        public virtual ICollection<Opacfields> OpacfieldsUpdateByNavigation { get; set; }
        public virtual ICollection<Opaclogs> OpaclogsCreateByNavigation { get; set; }
        public virtual ICollection<Opaclogs> OpaclogsUpdateByNavigation { get; set; }
        public virtual ICollection<Partners> PartnersCreateByNavigation { get; set; }
        public virtual ICollection<Partners> PartnersUpdateByNavigation { get; set; }
        public virtual ICollection<Pelanggaran> PelanggaranCreateByNavigation { get; set; }
        public virtual ICollection<Pelanggaran> PelanggaranUpdateByNavigation { get; set; }
        public virtual ICollection<Pengiriman> PengirimanCreateByNavigation { get; set; }
        public virtual ICollection<Pengiriman> PengirimanUpdateByNavigation { get; set; }
        public virtual ICollection<PeraturanPeminjamanHari> PeraturanPeminjamanHariCreateByNavigation { get; set; }
        public virtual ICollection<PeraturanPeminjamanHari> PeraturanPeminjamanHariUpdateByNavigation { get; set; }
        public virtual ICollection<PeraturanPeminjamanTanggal> PeraturanPeminjamanTanggalCreateByNavigation { get; set; }
        public virtual ICollection<PeraturanPeminjamanTanggal> PeraturanPeminjamanTanggalUpdateByNavigation { get; set; }
        public virtual ICollection<Propinsi> PropinsiCreateByNavigation { get; set; }
        public virtual ICollection<Propinsi> PropinsiUpdateByNavigation { get; set; }
        public virtual ICollection<Publishers> PublishersCreateByNavigation { get; set; }
        public virtual ICollection<Publishers> PublishersUpdateByNavigation { get; set; }
        public virtual ICollection<QuarantinedAuthData> QuarantinedAuthDataCreateByNavigation { get; set; }
        public virtual ICollection<QuarantinedAuthData> QuarantinedAuthDataUpdateByNavigation { get; set; }
        public virtual ICollection<QuarantinedAuthHeader> QuarantinedAuthHeaderCreateByNavigation { get; set; }
        public virtual ICollection<QuarantinedAuthHeader> QuarantinedAuthHeaderUpdateByNavigation { get; set; }
        public virtual ICollection<QuarantinedCatalogRuas> QuarantinedCatalogRuasCreateByNavigation { get; set; }
        public virtual ICollection<QuarantinedCatalogRuas> QuarantinedCatalogRuasUpdateByNavigation { get; set; }
        public virtual ICollection<QuarantinedCatalogSubruas> QuarantinedCatalogSubruasCreateByNavigation { get; set; }
        public virtual ICollection<QuarantinedCatalogSubruas> QuarantinedCatalogSubruasUpdateByNavigation { get; set; }
        public virtual ICollection<QuarantinedCatalogs> QuarantinedCatalogsCreateByNavigation { get; set; }
        public virtual ICollection<QuarantinedCatalogs> QuarantinedCatalogsQuarantinedbyNavigation { get; set; }
        public virtual ICollection<QuarantinedCatalogs> QuarantinedCatalogsUpdateByNavigation { get; set; }
        public virtual ICollection<QuarantinedCollections> QuarantinedCollectionsCreateByNavigation { get; set; }
        public virtual ICollection<QuarantinedCollections> QuarantinedCollectionsQuarantinedbyNavigation { get; set; }
        public virtual ICollection<QuarantinedCollections> QuarantinedCollectionsUpdateByNavigation { get; set; }
        public virtual ICollection<QuarantinedPengiriman> QuarantinedPengirimanCreateByNavigation { get; set; }
        public virtual ICollection<QuarantinedPengiriman> QuarantinedPengirimanUpdateByNavigation { get; set; }
        public virtual ICollection<Readinlocation> ReadinlocationCreateByNavigation { get; set; }
        public virtual ICollection<Readinlocation> ReadinlocationUpdateByNavigation { get; set; }
        public virtual ICollection<Refferenceitems> RefferenceitemsCreateByNavigation { get; set; }
        public virtual ICollection<Refferenceitems> RefferenceitemsUpdateByNavigation { get; set; }
        public virtual ICollection<Refferences> RefferencesCreateByNavigation { get; set; }
        public virtual ICollection<Refferences> RefferencesUpdateByNavigation { get; set; }
        public virtual ICollection<Requestcatalog> RequestcatalogCreateByNavigation { get; set; }
        public virtual ICollection<Requestcatalog> RequestcatalogUpdateByNavigation { get; set; }
        public virtual ICollection<Rolemodule> RolemoduleCreateByNavigation { get; set; }
        public virtual ICollection<Rolemodule> RolemoduleUpdateByNavigation { get; set; }
        public virtual ICollection<Roles> RolesCreateByNavigation { get; set; }
        public virtual ICollection<Roles> RolesUpdateByNavigation { get; set; }
        public virtual ICollection<SerialArticles> SerialArticlesCreateByNavigation { get; set; }
        public virtual ICollection<SerialArticlesRepeatable> SerialArticlesRepeatableCreateByNavigation { get; set; }
        public virtual ICollection<SerialArticlesRepeatable> SerialArticlesRepeatableUpdateByNavigation { get; set; }
        public virtual ICollection<SerialArticles> SerialArticlesUpdateByNavigation { get; set; }
        public virtual ICollection<Settingcatalogdetail> SettingcatalogdetailCreateByNavigation { get; set; }
        public virtual ICollection<Settingcatalogdetail> SettingcatalogdetailUpdateByNavigation { get; set; }
        public virtual ICollection<Settingparameters> SettingparametersCreateByNavigation { get; set; }
        public virtual ICollection<Settingparameters> SettingparametersUpdateByNavigation { get; set; }
        public virtual ICollection<StatusAnggota> StatusAnggotaCreateByNavigation { get; set; }
        public virtual ICollection<StatusAnggota> StatusAnggotaUpdateByNavigation { get; set; }
        public virtual ICollection<Stockopname> StockopnameCreateByNavigation { get; set; }
        public virtual ICollection<Stockopname> StockopnameUpdateByNavigation { get; set; }
        public virtual ICollection<Stockopnamedetail> StockopnamedetailCreateByNavigation { get; set; }
        public virtual ICollection<Stockopnamedetail> StockopnamedetailUpdateByNavigation { get; set; }
        public virtual ICollection<Sumbangan> SumbanganCreateByNavigation { get; set; }
        public virtual ICollection<SumbanganKoleksi> SumbanganKoleksiCreateByNavigation { get; set; }
        public virtual ICollection<SumbanganKoleksi> SumbanganKoleksiUpdateByNavigation { get; set; }
        public virtual ICollection<Sumbangan> SumbanganUpdateByNavigation { get; set; }
        public virtual ICollection<Survey> SurveyCreateByNavigation { get; set; }
        public virtual ICollection<SurveyPertanyaan> SurveyPertanyaanCreateByNavigation { get; set; }
        public virtual ICollection<SurveyPertanyaan> SurveyPertanyaanUpdateByNavigation { get; set; }
        public virtual ICollection<SurveyPilihan> SurveyPilihanCreateByNavigation { get; set; }
        public virtual ICollection<SurveyPilihan> SurveyPilihanUpdateByNavigation { get; set; }
        public virtual ICollection<Survey> SurveyUpdateByNavigation { get; set; }
        public virtual ICollection<Tempnoinduk> TempnoindukCreateByNavigation { get; set; }
        public virtual ICollection<Tempnoinduk> TempnoindukUpdateByNavigation { get; set; }
        public virtual ICollection<TujuanKunjungan> TujuanKunjunganCreateByNavigation { get; set; }
        public virtual ICollection<TujuanKunjungan> TujuanKunjunganUpdateByNavigation { get; set; }
        public virtual ICollection<User> UserCreateByNavigation { get; set; }
        public virtual ICollection<User> UserUpdateByNavigation { get; set; }
        public virtual ICollection<Worksheetfields> WorksheetfieldsCreateByNavigation { get; set; }
        public virtual ICollection<Worksheetfields> WorksheetfieldsUpdateByNavigation { get; set; }
        public virtual ICollection<Worksheets> WorksheetsCreateByNavigation { get; set; }
        public virtual ICollection<Worksheets> WorksheetsUpdateByNavigation { get; set; }
    }
}
