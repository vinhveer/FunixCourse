using Microsoft.EntityFrameworkCore;

namespace Assignment4.Data;

public partial class SinhVienContext : DbContext
{
    public SinhVienContext()
    {
    }

    public SinhVienContext(DbContextOptions<SinhVienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-QDP6VSH\\VINHNQ;Initial Catalog=SinhVien;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Lop>(entity =>
        {
            entity.HasKey(e => e.MaLop).HasName("PK__Lop__3B98D273C8D495FF");

            entity.ToTable("Lop");

            entity.Property(e => e.TenLop).HasMaxLength(50);
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSv).HasName("PK__SinhVien__2725081AE96EAD2D");

            entity.ToTable("SinhVien");

            entity.Property(e => e.MaSv).HasColumnName("MaSV");
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.TenSv)
                .HasMaxLength(100)
                .HasColumnName("TenSV");

            entity.HasOne(d => d.MaLopNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.MaLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SinhVien__MaLop__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
