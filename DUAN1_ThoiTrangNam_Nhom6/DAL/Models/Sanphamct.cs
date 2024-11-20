namespace DUAN1_ThoiTrangNam_Nhom6.DAL.Models
{
    public partial class Sanphamct
    {
        public Sanphamct()
        {
            HoaDonCts = new HashSet<HoaDonCt>();
        }

        public int IdSpct { get; set; }
        public string TenSanpham { get; set; } = null!;
        public string Size { get; set; } = null!;
        public string ChatLieu { get; set; } = null!;
        public string MauSac { get; set; } = null!;
        public int SoLuong { get; set; }
        public double GiaBan { get; set; }
        public string? GhiChu { get; set; }
        public byte[]? HinhAnh { get; set; }
        public bool? IsAlive { get; set; }
        public int IdSanpham { get; set; }

        public Sanphamct(int idSpct, string tenSanpham, string size, string chatLieu, string mauSac, int soLuong, double giaBan, string? ghiChu, byte[]? hinhAnh, bool? isAlive, int idSanpham)
        {
            IdSpct = idSpct;
            TenSanpham = tenSanpham;
            Size = size;
            ChatLieu = chatLieu;
            MauSac = mauSac;
            SoLuong = soLuong;
            GiaBan = giaBan;
            GhiChu = ghiChu;
            HinhAnh = hinhAnh;
            IsAlive = isAlive;
            IdSanpham = idSanpham;
        }

        public virtual Sanpham IdSanphamNavigation { get; set; } = null!;
        public virtual ICollection<HoaDonCt> HoaDonCts { get; set; }
    }
}