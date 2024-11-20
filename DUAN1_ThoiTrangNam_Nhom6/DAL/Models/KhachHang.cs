using System;
using System.Collections.Generic;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int IdKh { get; set; }
        public string HoTen { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? Email { get; set; }
        public string Sdt { get; set; } = null!;

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
