using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DACSAN_BANHTRANG.Entities
{
    public partial class BanhTrangManagermentContext : DbContext
    {
        public BanhTrangManagermentContext()
        {
        }

        public BanhTrangManagermentContext(DbContextOptions<BanhTrangManagermentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProcductCategory> ProcductCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSlider> ProductSliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-INN6CNA\\SQLEXPRESS;Database=BanhTrangManagerment;Trusted_Connection=True;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ProcductCategory>(entity =>
            {
                entity.Property(e => e.CategoriesName).HasMaxLength(100);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ImageUrl).HasMaxLength(250);
            });

            modelBuilder.Entity<ProductSlider>(entity =>
            {
                entity.ToTable("ProductSlider");

                entity.Property(e => e.ImageUrl).HasMaxLength(250);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
