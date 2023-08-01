using System;
using System.Collections.Generic;

namespace ClinicManagement_hk3.Models
{
    public partial class StorageDetail
    {
        public int Id { get; set; }
        public int? SlotId { get; set; }
        public DateTime? ImportDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? Quantity { get; set; }
        public int? MachineId { get; set; }
        public int? DrugId { get; set; }

        public virtual Drug? Drug { get; set; }
        public virtual Machine? Machine { get; set; }
        public virtual Storage? Slot { get; set; }
    }
}
