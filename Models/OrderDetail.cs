using System;
using System.Collections.Generic;

namespace ClinicManagement_hk3.Models
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? MachineId { get; set; }
        public int? DrugId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Amount { get; set; }

        public virtual Drug? Drug { get; set; }
        public virtual Machine? Machine { get; set; }
        public virtual Order? Order { get; set; }
    }
}
