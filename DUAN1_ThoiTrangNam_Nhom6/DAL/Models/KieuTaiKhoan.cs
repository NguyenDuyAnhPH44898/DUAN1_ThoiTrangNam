using System;
using System.Collections.Generic;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL.Models
{
    public partial class KieuTaiKhoan
    {
        public KieuTaiKhoan()
        {
            NguoiDungs = new HashSet<NguoiDung>();
        }

        public int IdKtk { get; set; }
        public string TenKtk { get; set; } = null!;

        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
