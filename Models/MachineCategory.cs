using System;
using System.Collections.Generic;

namespace ClinicManagement_hk3.Models
{
    public partial class MachineCategory
    {
        public MachineCategory()
        {
            Machines = new HashSet<Machine>();
        }

        public int CateId { get; set; }
        public string? CateName { get; set; }

        public virtual ICollection<Machine> Machines { get; set; }
    }
}
