using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL
{
    public class HoaDonCT_DAL
    {
        private DB_DUAN1_Nhom6Context db;

        public HoaDonCT_DAL()
        {
            db = new DB_DUAN1_Nhom6Context();
        }

        public List<HoaDonCt> LayDanhSachHoaDonChiTietCuaHoaDon(int maHoaDon)
        {
            return db.HoaDonCts.Where(hdct => hdct.IdHd == maHoaDon).ToList();
        }

        public List<HoaDonCt> LayChiTietHoaDon(int maHoaDon)
        {
            // Truy vấn danh sách chi tiết hóa đơn từ cơ sở dữ liệu
            var chiTietHoaDon = db.HoaDonCts.Where(hd => hd.IdHd == maHoaDon).ToList();
            return chiTietHoaDon;
        }
        public bool ThemChiTietHoaDon(HoaDonCt chiTietHoaDon)
        {
            try
            {
                // Thêm chi tiết hóa đơn vào cơ sở dữ liệu
                db.HoaDonCts.Add(chiTietHoaDon);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (nếu có)
                Console.WriteLine($"Lỗi khi thêm chi tiết hóa đơn: {ex.Message}");
                return false;
            }
        }
    
    }
}
