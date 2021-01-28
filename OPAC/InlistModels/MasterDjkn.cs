﻿using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class MasterDjkn
    {
        public int Id { get; set; }
        public string OptionId { get; set; }
        public string OptionName { get; set; }
        public string Value { get; set; }
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