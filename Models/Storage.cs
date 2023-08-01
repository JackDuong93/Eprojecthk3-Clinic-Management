using System;
using System.Collections.Generic;

namespace ClinicManagement_hk3.Models
{
    public partial class Storage
    {
        public Storage()
        {
            StorageDetails = new HashSet<StorageDetail>();
        }

        public int SlotId { get; set; }
        public DateTime? ImportDate { get; set; }
        public int? Quantity { get; set; }
        public int? UserId { get; set; }

        public virtual Account? User { get; set; }
        public virtual ICollection<StorageDetail> StorageDetails { get; set; }
    }
}
