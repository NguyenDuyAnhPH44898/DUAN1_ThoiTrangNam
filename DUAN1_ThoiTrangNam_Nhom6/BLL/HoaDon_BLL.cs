using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using DUAN1_ThoiTrangNam_Nhom6.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.BLL
{
    public class HoaDon_BLL
    {
        private DB_DUAN1_Nhom6Context _dbContext;
        private readonly HoaDon_DAL hoaDon_DAL;
        public HoaDon_BLL(DB_DUAN1_Nhom6Context dbContext)
        {
            _dbContext = new DB_DUAN1_Nhom6Context();
            hoaDon_DAL = new HoaDon_DAL(dbContext);
        }

        public List<HoaDon> LayDanhSachHoadon()
        {
            return _dbContext.HoaDons.ToList();
        }
 
        public void CapNhatTrangThaiHoaDon(int maHoaDon)
        {
            hoaDon_DAL.CapNhatTrangThaiHoaDon(maHoaDon);
        }

        public int ThemHoaDon(HoaDon hoaDon)
        {
            return hoaDon_DAL.ThemHoaDon(hoaDon);
        }
        public void ThemHoaDonChiTiet(HoaDonCt hoaDonCt)
        {
            // Có thể thêm bất kỳ kiểm tra hoặc xử lý nào khác ở đây trước khi gọi DAL để thêm hóa đơn chi tiết
            hoaDon_DAL.ThemHoaDonChiTiet(hoaDonCt);
        }    
        public bool TaoHoaDonBan(HoaDon hoaDon, List<HoaDonCt> danhSachHoaDonCT)
        {
            return hoaDon_DAL.TaoHoaDonBan(hoaDon, danhSachHoaDonCT);
        }
        public bool thanhtoan(int maHoaDon)
        {
            try
            {
                var hoaDon = _dbContext.HoaDons.FirstOrDefault(hd => hd.IdHd == maHoaDon);
                if (hoaDon != null)
                {
                    hoaDon.TinhTrang = true; // Đặt trạng thái của hóa đơn thành "Đã hủy"
                    _dbContext.SaveChanges();
                    return true; // Trả về true nếu cập nhật thành công
                }
                return false; // Trả về false nếu không tìm thấy hóa đơn
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                return false; // Trả về false nếu xảy ra lỗi
            }
        }

        public bool XoaHoaDon(int maHoaDon)
        {
            try
            {
                var hoaDon = _dbContext.HoaDons.FirstOrDefault(hd => hd.IdHd == maHoaDon);
                if (hoaDon != null)
                {
                    _dbContext.HoaDons.Remove(hoaDon);
                    _dbContext.SaveChanges();
                    return true; // Trả về true nếu xóa thành công
                }
                return false; // Trả về false nếu không tìm thấy hóa đơn
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.ToString());
                return false; // Trả về false nếu xảy ra lỗi
            }
        }

        public bool XoaHoaDonVaChiTiet(int maHoaDon)
        {
            return hoaDon_DAL.XoaHoaDonVaChiTiet(maHoaDon);
        }

        
    }
}
