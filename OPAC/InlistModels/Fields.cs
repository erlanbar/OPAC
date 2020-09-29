using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Fields
    {
        public Fields()
        {
            Fielddatas = new HashSet<Fielddatas>();
            Fieldindicator1s = new HashSet<Fieldindicator1s>();
            Fieldindicator2s = new HashSet<Fieldindicator2s>();
            Settingcatalogdetail = new HashSet<Settingcatalogdetail>();
            Worksheetfields = new HashSet<Worksheetfields>();
        }

        public int Id { get; set; }
        public string Tag { get; set; }
        public string Name { get; set; }
        public short? Fixed { get; set; }
        public short? Enabled { get; set; }
        public int? Length { get; set; }
        public short? Repeatable { get; set; }
        public short? Mandatory { get; set; }
        public short? IsCustomable { get; set; }
        public int FormatId { get; set; }
        public int GroupId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public string Defaultsubtag { get; set; }
        public short? Issubserial { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Formats Format { get; set; }
        public virtual Fieldgroups Group { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual ICollection<Fielddatas> Fielddatas { get; set; }
        public virtual ICollection<Fieldindicator1s> Fieldindicator1s { get; set; }
        public virtual ICollection<Fieldindicator2s> Fieldindicator2s { get; set; }
        public virtual ICollection<Settingcatalogdetail> Settingcatalogdetail { get; set; }
        public virtual ICollection<Worksheetfields> Worksheetfields { get; set; }
    }
}
