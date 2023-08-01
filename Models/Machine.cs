using System;
using System.Collections.Generic;

namespace ClinicManagement_hk3.Models
{
    public partial class Machine
    {
        public Machine()
        {
            OrderDetails = new HashSet<OrderDetail>();
            StorageDetails = new HashSet<StorageDetail>();
        }

        public int MachineId { get; set; }
        public string? ProductCode { get; set; }
        public string? MachineName { get; set; }
        public int? CateId { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public string? Original { get; set; }
        public int? Guarantee { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }

        public virtual MachineCategory? Cate { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<StorageDetail> StorageDetails { get; set; }
    }
}
