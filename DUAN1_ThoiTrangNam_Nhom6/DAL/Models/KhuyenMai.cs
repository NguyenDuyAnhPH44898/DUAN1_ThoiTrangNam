using System;
using System.Collections.Generic;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL.Models
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int IdKhuyenMai { get; set; }
        public string MaKhuyenMai { get; set; } = null!;
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public double? PhanTramGiamGia { get; set; }
        public int SoLuong { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
