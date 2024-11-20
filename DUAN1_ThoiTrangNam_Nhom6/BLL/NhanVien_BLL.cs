using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using DUAN1_ThoiTrangNam_Nhom6.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.BLL
{
    public class NhanVien_BLL
    {


        private DB_DUAN1_Nhom6Context _dbContext;
        private readonly NhanVien_Dal nhanVien_Dal;
        public NhanVien_BLL()
        {
            _dbContext = new DB_DUAN1_Nhom6Context();
            nhanVien_Dal = new NhanVien_Dal(new DB_DUAN1_Nhom6Context());
        }

        public List<NguoiDung> laydanhsachND()
        {
            return _dbContext.NguoiDungs.ToList();
        }

        public void ThemND(NguoiDung  nguoidung)
        {

            nhanVien_Dal.ThemND(nguoidung);
        }

        public bool SuaND(int mand, string hoTen, string diaChi, string email, string sdt, string gioitinh, string tendangnhap, string matkhau, int idktk  )
        {
            try
            {

                NguoiDung nguoidung = _dbContext.NguoiDungs.FirstOrDefault(sp => sp.IdNd == mand);
                if (nguoidung != null)
                {


                    nguoidung.HoTen = hoTen;
                    nguoidung.Email = email;
                    nguoidung.DiaChi = diaChi;
                    nguoidung.Sdt = sdt;
                    nguoidung.GioiTinh = gioitinh;
                    nguoidung.TenDangNhap = tendangnhap;
                    nguoidung.MatKhau = matkhau;
                    nguoidung.IdKtk = idktk;
                


                    _dbContext.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaND(int mand)
        {
            try
            {

                NguoiDung nguoidung = _dbContext.NguoiDungs.FirstOrDefault(sp => sp.IdNd == mand);
                if (nguoidung != null)
                {

                    _dbContext.NguoiDungs.Remove(nguoidung);
                    _dbContext.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
