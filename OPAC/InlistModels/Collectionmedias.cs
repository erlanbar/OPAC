﻿using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Collectionmedias
    {
        public Collectionmedias()
        {
            Collections = new HashSet<Collections>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? WorksheetId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public DateTime? KiilastUploadDate { get; set; }

        public virtual Users CreateByNavigation { get; set; }
        public virtual Users UpdateByNavigation { get; set; }
        public virtual Worksheets Worksheet { get; set; }
        public virtual ICollection<Collections> Collections { get; set; }
    }
}