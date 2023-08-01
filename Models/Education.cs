using System;
using System.Collections.Generic;

namespace ClinicManagement_hk3.Models
{
    public partial class Education
    {
        public Education()
        {
            EduDetails = new HashSet<EduDetail>();
        }

        public int EduId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int? UserId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public virtual Account? User { get; set; }
        public virtual ICollection<EduDetail> EduDetails { get; set; }
    }
}
