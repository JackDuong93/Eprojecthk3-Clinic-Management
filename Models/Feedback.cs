using System;
using System.Collections.Generic;

namespace ClinicManagement_hk3.Models
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public int? FbUser { get; set; }
        public string? FbInfo { get; set; }
        public DateTime? FbTime { get; set; }
        public string? Reply { get; set; }
        public DateTime? ReplyTime { get; set; }
        public virtual Account? FbUserNavigation { get; set; }
    }
}
