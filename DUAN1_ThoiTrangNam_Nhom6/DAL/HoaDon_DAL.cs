using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL
{
    public class HoaDon_DAL
    {
        private readonly DB_DUAN1_Nhom6Context db;

        public HoaDon_DAL(DB_DUAN1_Nhom6Context context)
        {
            db = context;
        }

        public List<HoaDon> LayDanhSachhoadon()
        {
            return db.HoaDons.ToList();
        }

        public void CapNhatTrangThaiHoaDon(int maHoaDon)
        {
            var hoaDon = db.HoaDons.FirstOrDefault(hd => hd.IdHd == maHoaDon);
            if (hoaDon != null)
            {
                hoaDon.TinhTrang = true;
                db.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
        }


        //public bool TaoHoaDonBan(HoaDon hoaDon, List<HoaDonCt> danhSachHoaDonCT, double tongTien)
        //{
        //    try
        //    {
        //        // Thêm hóa đơn vào cơ sở dữ liệu
        //        db.HoaDons.Add(hoaDon);

        //        // Thêm chi tiết hóa đơn vào hóa đơn
        //        hoaDon.HoaDonCts = danhSachHoaDonCT;

        //        // Cập nhật tổng tiền của hóa đơn
        //        hoaDon.TongTien = tongTien;

        //        // Lưu thay đổi vào cơ sở dữ liệu
        //        db.SaveChanges();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Xử lý exception tại đây (log hoặc ném lại)
        //        throw ex;
        //    }
        //}

        public bool TaoHoaDonBan(HoaDon hoaDon, List<HoaDonCt> danhSachHoaDonCT)
        {
            try
            {
                // Thêm hóa đơn vào cơ sở dữ liệu
                db.HoaDons.Add(hoaDon);
                db.SaveChanges();

                // Gắn mã hóa đơn cho các chi tiết hóa đơn
                foreach (var chiTiet in danhSachHoaDonCT)
                {
                    chiTiet.IdHd = hoaDon.IdHd; // Gắn mã hóa đơn mới tạo
                    db.HoaDonCts.Add(chiTiet);
                }

                // Lưu các thay đổi vào cơ sở dữ liệu
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false; // Xảy ra lỗi khi thực hiện tạo hóa đơn
            }
        }

        public int ThemHoaDon(HoaDon hoaDon)
        {
            db.HoaDons.Add(hoaDon);
            db.SaveChanges();
            return hoaDon.IdHd;
        
        
        }
        public void ThemHoaDonChiTiet(HoaDonCt hoaDonCt)
        {
            var sanPhamChiTiet = db.Sanphamcts.FirstOrDefault(sp => sp.IdSpct == hoaDonCt.IdSpct);

            // Kiểm tra xem sản phẩm chi tiết có tồn tại không
            if (sanPhamChiTiet != null)
            {
                // Nếu sản phẩm chi tiết tồn tại, thực hiện thêm hóa đơn chi tiết vào DbSet của context và lưu thay đổi
                db.HoaDonCts.Add(hoaDonCt);
                db.SaveChanges();
            }
            else
            {
                // Nếu sản phẩm chi tiết không tồn tại, có thể xử lý thông báo lỗi hoặc thực hiện các hành động khác tùy thuộc vào yêu cầu của ứng dụng
                throw new Exception("Sản phẩm chi tiết không tồn tại trong bảng SANPHAMCT.");
            }
        }
        public bool XoaHoaDonVaChiTiet(int maHoaDon)
        {
            try
            {
                // Tìm hóa đơn trong cơ sở dữ liệu
                var hoaDon = db.HoaDons.Find(maHoaDon);
                if (hoaDon == null)
                {
                    return false; // Không tìm thấy hóa đơn
                }
                // Xoá các chi tiết hóa đơn tương ứng
                var chiTietHoaDonList = db.HoaDonCts.Where(ct => ct.IdHd == maHoaDon);
                db.HoaDonCts.RemoveRange(chiTietHoaDonList);           
                db.HoaDons.Remove(hoaDon);              
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false; 
            }
        } 
    }
}
