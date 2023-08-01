using System;
using System.Collections.Generic;

namespace ClinicManagement_hk3.Models
{
    public partial class DrugCategory
    {
        public DrugCategory()
        {
            Drugs = new HashSet<Drug>();
        }

        public int CateId { get; set; }
        public string? CateName { get; set; }

        public virtual ICollection<Drug> Drugs { get; set; }
    }
}
