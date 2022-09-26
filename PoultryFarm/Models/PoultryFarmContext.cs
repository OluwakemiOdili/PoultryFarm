using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PoultryFarm.Models
{
    public partial class PoultryFarmContext : DbContext
    {
        public PoultryFarmContext()
        {
        }

        public PoultryFarmContext(DbContextOptions<PoultryFarmContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PoultryFeed> PoultryFeeds { get; set; } = null!;
        public virtual DbSet<PoultryStaff> PoultryStaffs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=PoultryFarm;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PoultryFeed>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.Property(e => e.TagId)
                    .ValueGeneratedNever()
                    .HasColumnName("Tag ID");

                entity.Property(e => e.ChickenBreed)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Chicken Breed");

                entity.Property(e => e.ChickenMeds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Chicken Meds");

                entity.Property(e => e.NumberOfFeeds).HasColumnName("Number Of Feeds");

                entity.Property(e => e.TypesOfFeeds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Types Of Feeds");
            });

            modelBuilder.Entity<PoultryStaff>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("PoultryStaff");

                entity.Property(e => e.StaffId)
                    .ValueGeneratedNever()
                    .HasColumnName("Staff ID");

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)   
                    .HasColumnName("Phone Number");

                entity.Property(e => e.StaffAddress)
                    .IsUnicode(false)
                    .HasColumnName("Staff Address");

                entity.Property(e => e.StaffName)
                    .IsUnicode(false)
                    .HasColumnName("Staff Name"); 
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
