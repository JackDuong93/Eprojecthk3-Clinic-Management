using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ClinicManagement_hk3.Models
{
    public partial class Projecthk3Context : DbContext
    {
        public Projecthk3Context()
        {
        }

        public Projecthk3Context(DbContextOptions<Projecthk3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Drug> Drugs { get; set; } = null!;
        public virtual DbSet<DrugCategory> DrugCategories { get; set; } = null!;
        public virtual DbSet<EduDetail> EduDetails { get; set; } = null!;
        public virtual DbSet<Education> Educations { get; set; } = null!;
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<Machine> Machines { get; set; } = null!;
        public virtual DbSet<MachineCategory> MachineCategories { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Storage> Storages { get; set; } = null!;
        public virtual DbSet<StorageDetail> StorageDetails { get; set; } = null!;
        public virtual DbSet<staff> staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=LUUVINHHAN\\SQLEXPRESS01; database=Projecthk3; trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Accounts__1788CC4C1298D693");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Accounts__RoleId__267ABA7A");
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.ToTable("Drug");

                entity.Property(e => e.DrugId).ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DrugName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredients)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NetWeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Original)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserManual)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Warning)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cate)
                    .WithMany(p => p.Drugs)
                    .HasForeignKey(d => d.CateId)
                    .HasConstraintName("FK__Drug__CateId__300424B4");
            });

            modelBuilder.Entity<DrugCategory>(entity =>
            {
                entity.HasKey(e => e.CateId)
                    .HasName("PK__DrugCate__27638D14396DD6B1");

                entity.ToTable("DrugCategory");

                entity.Property(e => e.CateId).ValueGeneratedNever();

                entity.Property(e => e.CateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EduDetail>(entity =>
            {
                entity.ToTable("EduDetail");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Edu)
                    .WithMany(p => p.EduDetails)
                    .HasForeignKey(d => d.EduId)
                    .HasConstraintName("FK__EduDetail__EduId__47DBAE45");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.EduDetails)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK__EduDetail__Staff__46E78A0C");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.HasKey(e => e.EduId)
                    .HasName("PK__Educatio__1FD9490E804A404E");

                entity.ToTable("Education");

                entity.Property(e => e.EduId).ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Educations)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Education__UserI__4222D4EF");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.FeedbackId).ValueGeneratedNever();

                entity.Property(e => e.FbInfo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FbTime).HasColumnType("date");

                entity.Property(e => e.Reply)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyTime).HasColumnType("date");

                entity.HasOne(d => d.FbUserNavigation)
                    .WithMany(p => p.FeedbackFbUserNavigations)
                    .HasForeignKey(d => d.FbUser)
                    .HasConstraintName("FK__Feedback__FbUser__4AB81AF0");


            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.ToTable("Machine");

                entity.Property(e => e.MachineId).ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Original)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cate)
                    .WithMany(p => p.Machines)
                    .HasForeignKey(d => d.CateId)
                    .HasConstraintName("FK__Machine__CateId__2D27B809");
            });

            modelBuilder.Entity<MachineCategory>(entity =>
            {
                entity.HasKey(e => e.CateId)
                    .HasName("PK__MachineC__27638D147F6F94C6");

                entity.ToTable("MachineCategory");

                entity.Property(e => e.CateId).ValueGeneratedNever();

                entity.Property(e => e.CateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Order__UserId__32E0915F");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.OrderDetailId).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK__OrderDeta__DrugI__35BCFE0A");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("FK__OrderDeta__Machi__36B12243");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderDeta__Order__37A5467C");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.Role1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role");
            });

            modelBuilder.Entity<Storage>(entity =>
            {
                entity.HasKey(e => e.SlotId)
                    .HasName("PK__Storage__0A124AAF837CF8F5");

                entity.ToTable("Storage");

                entity.Property(e => e.SlotId).ValueGeneratedNever();

                entity.Property(e => e.ImportDate)
                    .HasColumnType("date")
                    .HasColumnName("Import_date");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Storages)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Storage__UserId__3A81B327");
            });

            modelBuilder.Entity<StorageDetail>(entity =>
            {
                entity.ToTable("StorageDetail");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("Expiry_date");

                entity.Property(e => e.ImportDate)
                    .HasColumnType("date")
                    .HasColumnName("Import_date");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.StorageDetails)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK__StorageDe__DrugI__3D5E1FD2");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.StorageDetails)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("FK__StorageDe__Machi__3E52440B");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.StorageDetails)
                    .HasForeignKey(d => d.SlotId)
                    .HasConstraintName("FK__StorageDe__SlotI__3F466844");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.StaffId).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
