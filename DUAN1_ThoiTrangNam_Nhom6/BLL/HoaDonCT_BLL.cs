using DUAN1_ThoiTrangNam_Nhom6.DAL;
using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.BLL
{
    public class HoaDonCT_BLL
    {
        private readonly HoaDonCT_DAL hoaDonChiTietDAL;
        private  DB_DUAN1_Nhom6Context db;
        public HoaDonCT_BLL()
        {
            hoaDonChiTietDAL = new HoaDonCT_DAL();
            db = new DB_DUAN1_Nhom6Context();
        }

        public List<HoaDonCt> LayDanhSachHoaDonChiTietCuaHoaDon(int maHoaDon)
        {
            return hoaDonChiTietDAL.LayDanhSachHoaDonChiTietCuaHoaDon(maHoaDon);
        }
        public List<HoaDonCt> LayDanhSachHoaDonChiTietCuaKhachHang()
        {
            return db.HoaDonCts.ToList();
        }

        public bool ThemChiTietHoaDon(HoaDonCt chiTietHoaDon)
        {
            return hoaDonChiTietDAL.ThemChiTietHoaDon(chiTietHoaDon);
        }

        public List<HoaDonCt> LayChiTietHoaDon(int maHoaDon)
        {
            // Gọi phương thức tương ứng từ lớp DAL để truy vấn danh sách chi tiết hóa đơn
            return hoaDonChiTietDAL.LayChiTietHoaDon(maHoaDon);
        }  
    }
}
