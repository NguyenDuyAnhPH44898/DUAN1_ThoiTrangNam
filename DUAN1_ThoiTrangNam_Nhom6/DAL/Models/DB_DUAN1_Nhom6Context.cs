using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL.Models
{
    public partial class DB_DUAN1_Nhom6Context : DbContext
    {
        public DB_DUAN1_Nhom6Context()
        {
        }

        public DB_DUAN1_Nhom6Context(DbContextOptions<DB_DUAN1_Nhom6Context> options)
            : base(options)
        {
        }

        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonCt> HoaDonCts { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; } = null!;
        public virtual DbSet<KieuTaiKhoan> KieuTaiKhoans { get; set; } = null!;
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; } = null!;
        public virtual DbSet<Sanpham> Sanphams { get; set; } = null!;
        public virtual DbSet<Sanphamct> Sanphamcts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SAMSEPI0L\\SQLEXPRESS;Database=DB_DUAN1_Nhom6;Trusted_Connection=True; TrustServerCertificate =True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.IdHd)
                    .HasName("PK__HoaDon__8B62D72114E7FE5E");

                entity.ToTable("HoaDon");

                entity.Property(e => e.IdHd).HasColumnName("ID_HD");

                entity.Property(e => e.IdKh).HasColumnName("ID_KH");

                entity.Property(e => e.IdKhuyenMai).HasColumnName("ID_KhuyenMai");

                entity.Property(e => e.IdNd).HasColumnName("ID_ND");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdKhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdKh)
                    .HasConstraintName("FK__HoaDon__ID_KH__628FA481");

                entity.HasOne(d => d.IdKhuyenMaiNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdKhuyenMai)
                    .HasConstraintName("FK__HoaDon__ID_Khuye__6383C8BA");

                entity.HasOne(d => d.IdNdNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.IdNd)
                    .HasConstraintName("FK__HoaDon__ID_ND__6477ECF3");
            });

            modelBuilder.Entity<HoaDonCt>(entity =>
            {
                entity.HasKey(e => e.IdHdct)
                    .HasName("PK__HoaDonCT__6158DDD4F2C0206B");

                entity.ToTable("HoaDonCT");

                entity.Property(e => e.IdHdct).HasColumnName("ID_HDCT");

                entity.Property(e => e.IdHd).HasColumnName("ID_HD");

                entity.Property(e => e.IdSpct).HasColumnName("ID_SPCT");

                entity.HasOne(d => d.IdHdNavigation)
                    .WithMany(p => p.HoaDonCts)
                    .HasForeignKey(d => d.IdHd)
                    .HasConstraintName("FK__HoaDonCT__ID_HD__6754599E");

                entity.HasOne(d => d.IdSpctNavigation)
                    .WithMany(p => p.HoaDonCts)
                    .HasForeignKey(d => d.IdSpct)
                    .HasConstraintName("FK__HoaDonCT__ID_SPC__68487DD7");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.IdKh)
                    .HasName("PK__KhachHan__8B62EC895A242681");

                entity.ToTable("KhachHang");

                entity.Property(e => e.IdKh).HasColumnName("ID_KH");

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .HasColumnName("SDT");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.HasKey(e => e.IdKhuyenMai)
                    .HasName("PK__KhuyenMa__E93749B4A6E85605");

                entity.ToTable("KhuyenMai");

                entity.Property(e => e.IdKhuyenMai).HasColumnName("ID_KhuyenMai");

                entity.Property(e => e.MaKhuyenMai).HasMaxLength(8);

                entity.Property(e => e.NgayBatDau)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<KieuTaiKhoan>(entity =>
            {
                entity.HasKey(e => e.IdKtk)
                    .HasName("PK__KieuTaiK__2DF8016560CC57CD");

                entity.ToTable("KieuTaiKhoan");

                entity.Property(e => e.IdKtk).HasColumnName("ID_KTK");

                entity.Property(e => e.TenKtk)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_KTK");
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.IdNd)
                    .HasName("PK__NguoiDun__8B63E07598F68BE7");

                entity.ToTable("NguoiDung");

                entity.Property(e => e.IdNd).HasColumnName("ID_ND");

                entity.Property(e => e.GioiTinh).HasMaxLength(5);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.IdKtk).HasColumnName("ID_KTK");

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenDangNhap).HasMaxLength(50);

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdKtkNavigation)
                    .WithMany(p => p.NguoiDungs)
                    .HasForeignKey(d => d.IdKtk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NguoiDung__ID_KT__534D60F1");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.IdSanpham)
                    .HasName("PK__SANPHAM__216A05535BE3337E");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.IdSanpham).HasColumnName("ID_SANPHAM");

                entity.Property(e => e.IsAlive)
                    .IsRequired()
                    .HasColumnName("Is_Alive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LoaiSanpham)
                    .HasMaxLength(100)
                    .HasColumnName("Loai_SANPHAM");
            });

            modelBuilder.Entity<Sanphamct>(entity =>
            {
                entity.HasKey(e => e.IdSpct)
                    .HasName("PK__SANPHAMC__F5AB632701EC1B1C");

                entity.ToTable("SANPHAMCT");

                entity.Property(e => e.IdSpct).HasColumnName("ID_SPCT");

                entity.Property(e => e.ChatLieu).HasMaxLength(100);

                entity.Property(e => e.HinhAnh).HasColumnType("image");

                entity.Property(e => e.IdSanpham).HasColumnName("ID_SANPHAM");

                entity.Property(e => e.IsAlive)
                    .IsRequired()
                    .HasColumnName("Is_Alive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MauSac).HasMaxLength(100);

                entity.Property(e => e.Size)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TenSanpham)
                    .HasMaxLength(100)
                    .HasColumnName("Ten_SANPHAM");

                entity.HasOne(d => d.IdSanphamNavigation)
                    .WithMany(p => p.Sanphamcts)
                    .HasForeignKey(d => d.IdSanpham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCT__ID_SA__4D94879B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
