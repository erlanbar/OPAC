﻿using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class Bacaditempat
    {
        public double Id { get; set; }
        public string NoPengunjung { get; set; }
        public double CollectionId { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateTerminal { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateTerminal { get; set; }
        public double? MemberId { get; set; }
        public int? LocationId { get; set; }
        public string IsReturn { get; set; }

        public virtual Collections Collection { get; set; }
        public virtual Users CreateByNavigation { get; set; }
        public virtual Locations Location { get; set; }
        public virtual Members Member { get; set; }
    }
}