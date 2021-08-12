using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Bulk_Insert.Models
{
    public partial class FakeDBContext : DbContext
    {
        public FakeDBContext()
        {
        }

        public FakeDBContext(DbContextOptions<FakeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblPerson> TblPeople { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=FakeDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Persian_100_CI_AI");

            modelBuilder.Entity<TblPerson>(entity =>
            {
                entity.ToTable("tbl_person");

                entity.Property(e => e.Id)
                    .HasMaxLength(11)
                    .IsFixedLength(true);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsFixedLength(true);

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Faname)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("FAName")
                    .IsFixedLength(true);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
