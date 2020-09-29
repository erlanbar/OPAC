using System;
using System.Collections.Generic;

namespace OPAC.InlistModels
{
    public partial class NotifSmsGateway
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int NumberHp { get; set; }
        public int? CollectionloanitemId { get; set; }
        public string SendMessageText { get; set; }
        public string CriteriaMessage { get; set; }
        public DateTime? SendDate { get; set; }
        public string SendStatus { get; set; }
    }
}
