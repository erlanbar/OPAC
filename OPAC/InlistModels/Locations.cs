using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Locations
    {
        public Locations()
        {
            Bacaditempat = new HashSet<Bacaditempat>();
            CheckpointLocations = new HashSet<CheckpointLocations>();
            Collections = new HashSet<Collections>();
            Groupguesses = new HashSet<Groupguesses>();
            MasterLoker = new HashSet<MasterLoker>();
            Memberguesses = new HashSet<Memberguesses>();
            Readinlocation = new HashSet<Readinlocation>();
            StockopnamedetailCurrentLocation = new HashSet<Stockopnamedetail>();
            StockopnamedetailPrevLocation = new HashSet<Stockopnamedetail>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short? Ispusteling { get; set; }
        public string UrlLogo { get; set; }
        public short? IsPrintBarcode { get; set; }
        public short? IsGenerateVisitorNumber { get; set; }
        public short? IsInformationSought { get; set; }
        public short? IsVisitsDestination { get; set; }
        public int? LocationLibraryId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual LocationLibrary LocationLibrary { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Bacaditempat> Bacaditempat { get; set; }
        public virtual ICollection<CheckpointLocations> CheckpointLocations { get; set; }
        public virtual ICollection<Collections> Collections { get; set; }
        public virtual ICollection<Groupguesses> Groupguesses { get; set; }
        public virtual ICollection<MasterLoker> MasterLoker { get; set; }
        public virtual ICollection<Memberguesses> Memberguesses { get; set; }
        public virtual ICollection<Readinlocation> Readinlocation { get; set; }
        public virtual ICollection<Stockopnamedetail> StockopnamedetailCurrentLocation { get; set; }
        public virtual ICollection<Stockopnamedetail> StockopnamedetailPrevLocation { get; set; }
    }
}
