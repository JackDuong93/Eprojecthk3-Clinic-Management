using System;
using System.Collections.Generic;

namespace ClinicManagement_hk3.Models
{
    public partial class EduDetail
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public int? EduId { get; set; }

        public virtual Education? Edu { get; set; }
        public virtual staff? Staff { get; set; }
    }
}
