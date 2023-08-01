using System;
using System.Collections.Generic;

namespace ClinicManagement_hk3.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public int? TotalQuantity { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? State { get; set; }

        public virtual Account? User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
