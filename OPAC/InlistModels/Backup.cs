using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Backup
    {
        public int Id { get; set; }
        public string BackupType { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
    }
}
