using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL
{
    public class Thongke_DAL
    {
        private DB_DUAN1_Nhom6Context context;

        public Thongke_DAL()
        {
            context = new DB_DUAN1_Nhom6Context(); // Khởi tạo đối tượng DbContext
        }

        public double TinhTongTienHoaDon()
        {
            double tongTien = 0;
            var query = context.HoaDons.Select(hd => hd.TongTien);
            if (query.Any())
            {
                tongTien = query.Sum();
            }
            return tongTien;
        }

        public int TinhTongSoSanPham()
        {
            int tongSoSanPham = 0;
            try
            {
                // Sử dụng LINQ để tính tổng số lượng sản phẩm từ bảng HoaDonCts
                tongSoSanPham = context.HoaDonCts.Sum(ct => ct.SoLuong.Value);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                Console.WriteLine("Đã xảy ra lỗi khi tính tổng số sản phẩm: " + ex.Message);
            }
            return tongSoSanPham;
        }

        public int TinhTongSoHoaDon()
        {
            int tongSoHoaDon = context.HoaDons.Count();
            return tongSoHoaDon;
        }


        public List<HoaDonCt> thognkehoadonct()
        {
            return context.HoaDonCts.ToList();
        }

        public List<Sanphamct> sanPhamCT()
        {
            return context.Sanphamcts.ToList();
        }

        

        public List<Sanpham> GetGiays()
        {
            return context.Sanphams.ToList();
        }

        public List<HoaDon> GetHoadons()
        {
            return context.HoaDons.ToList();
        }

    }
    
}
