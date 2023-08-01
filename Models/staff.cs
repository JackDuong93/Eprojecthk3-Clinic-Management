using System;
using System.Collections.Generic;

namespace ClinicManagement_hk3.Models
{
    public partial class staff
    {
        public staff()
        {
            EduDetails = new HashSet<EduDetail>();
        }

        public int StaffId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? StartDate { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<EduDetail> EduDetails { get; set; }
    }
}
