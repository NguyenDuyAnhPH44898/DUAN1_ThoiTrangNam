using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using DUAN1_ThoiTrangNam_Nhom6.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.BLL
{
    public class KhachHang_BLL
    {
        private DB_DUAN1_Nhom6Context _dbContext;
        private readonly KhachHang_DAL khachHang_DAL;
        public KhachHang_BLL()
        {
            _dbContext = new DB_DUAN1_Nhom6Context();
            khachHang_DAL = new KhachHang_DAL(new DB_DUAN1_Nhom6Context());
        }

        public List<KhachHang> LayDanhSachKH()
        {
            return _dbContext.KhachHangs.ToList();
        }
        public void themkh(KhachHang khachhang)
        {
            khachHang_DAL.ThemKh(khachhang);
        }
        public bool suakh(int idkh, string hoTen, string DiaChi, string Email, string Sdt)
        {
            try
            {
                KhachHang kh = _dbContext.KhachHangs.FirstOrDefault(kh => kh.IdKh == idkh);
                if (kh != null)
                {

                    kh.HoTen = hoTen;
                    kh.DiaChi = DiaChi;
                    kh.Email = Email;
                    kh.Sdt = Sdt;
                    _dbContext.SaveChanges();
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool xoakh(int idkh)
        {
            try
            {
                KhachHang kh = _dbContext.KhachHangs.FirstOrDefault(kh => kh.IdKh == idkh);
                if (kh != null)
                {
                    _dbContext.KhachHangs.Remove(kh);
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

        public List<KhachHang> TimKiemKH(string keyword)
        {
            return khachHang_DAL.TimKiemKH(keyword);
        }

    }
}
