using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL
{
    public class NguoiDung_DAL
    {
       

        private readonly DB_DUAN1_Nhom6Context _dbContext;

        public NguoiDung_DAL(DB_DUAN1_Nhom6Context dbContext)
        {
            _dbContext = dbContext;
        }
        public List<NguoiDung> Laydanhsachnguoidung()
        {
          
                return _dbContext.NguoiDungs.ToList();
            
        }
        public NguoiDung XacThuc(string tenDangNhap, string matKhau)
        {
            // Trả về thông tin người dùng dựa trên tên đăng nhập và mật khẩu
            return _dbContext.NguoiDungs.FirstOrDefault(nd => nd.TenDangNhap == tenDangNhap && nd.MatKhau == matKhau);
        }

        public List<NguoiDung> LayThongTinNguoiDung(string tenDangNhap)
        {
            // Trả về thông tin người dùng dựa trên tên đăng nhập
            return _dbContext.NguoiDungs.Where(nd => nd.TenDangNhap == tenDangNhap).ToList();
        }

        public bool CapNhatThongTinNguoiDung(NguoiDung nguoiDung)
        {
            try
            {
                var nguoiDungCanCapNhat = _dbContext.NguoiDungs.Find(nguoiDung.IdNd);
                if (nguoiDungCanCapNhat != null)
                {
                    nguoiDungCanCapNhat.HoTen = nguoiDung.HoTen;
                    nguoiDungCanCapNhat.GioiTinh = nguoiDung.GioiTinh;
                    nguoiDungCanCapNhat.DiaChi = nguoiDung.DiaChi;
                    nguoiDungCanCapNhat.Email = nguoiDung.Email;
                    nguoiDungCanCapNhat.Sdt = nguoiDung.Sdt;
                    nguoiDungCanCapNhat.TenDangNhap = nguoiDung.TenDangNhap;
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
