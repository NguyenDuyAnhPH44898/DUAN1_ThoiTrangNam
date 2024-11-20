using System;
using System.Collections.Generic;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonCts = new HashSet<HoaDonCt>();
        }

        public int IdHd { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool TinhTrang { get; set; }
        public double TongTien { get; set; }
        public int? IdKh { get; set; }
        public int? IdKhuyenMai { get; set; }
        public int? IdNd { get; set; }

        public virtual KhachHang? IdKhNavigation { get; set; }
        public virtual KhuyenMai? IdKhuyenMaiNavigation { get; set; }
        public virtual NguoiDung? IdNdNavigation { get; set; }
        public virtual ICollection<HoaDonCt> HoaDonCts { get; set; }
    }
}
