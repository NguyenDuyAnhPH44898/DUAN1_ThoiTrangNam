using System;
using System.Collections.Generic;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL.Models
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int IdNd { get; set; }
        public string HoTen { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? Email { get; set; }
        public string Sdt { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public bool? TinhTrang { get; set; }
        public int IdKtk { get; set; }

        public virtual KieuTaiKhoan IdKtkNavigation { get; set; } = null!;
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
