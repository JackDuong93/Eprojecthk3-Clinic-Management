using System;
using System.Collections.Generic;

namespace ClinicManagement_hk3.Models
{
    public partial class Drug
    {
        public Drug()
        {
            OrderDetails = new HashSet<OrderDetail>();
            StorageDetails = new HashSet<StorageDetail>();
        }

        public int DrugId { get; set; }
        public string? ProductCode { get; set; }
        public string? DrugName { get; set; }
        public int? CateId { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
        public string? Original { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public string? Ingredients { get; set; }
        public string? Warning { get; set; }
        public string? Note { get; set; }
        public string? UserManual { get; set; }
        public string? NetWeight { get; set; }

        public virtual DrugCategory? Cate { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<StorageDetail> StorageDetails { get; set; }
    }
}
