using System;
using System.Collections.Generic;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL.Models
{
    public partial class HoaDonCt
    {
        public int IdHdct { get; set; }
        public int? IdHd { get; set; }
        public int? IdSpct { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGia { get; set; }
        public double? ThanhTien { get; set; }

        public virtual HoaDon? IdHdNavigation { get; set; }
        public virtual Sanphamct? IdSpctNavigation { get; set; }
    }
}
