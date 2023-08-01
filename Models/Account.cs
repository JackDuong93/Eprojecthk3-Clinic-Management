using System;
using System.Collections.Generic;

namespace ClinicManagement_hk3.Models
{
    public partial class Account
    {
        public Account()
        {
            Educations = new HashSet<Education>();
            FeedbackFbUserNavigations = new HashSet<Feedback>();
            FeedbackReplyUserNavigations = new HashSet<Feedback>();
            Orders = new HashSet<Order>();
            Storages = new HashSet<Storage>();
        }

        public int UserId { get; set; }
        public string? FullName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? PassWord { get; set; }
        public string? Phone { get; set; }
        public string? State { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Feedback> FeedbackFbUserNavigations { get; set; }
        public virtual ICollection<Feedback> FeedbackReplyUserNavigations { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Storage> Storages { get; set; }
    }
}
