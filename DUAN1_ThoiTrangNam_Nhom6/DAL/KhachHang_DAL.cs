using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL
{
    public class KhachHang_DAL
    {
        private readonly DB_DUAN1_Nhom6Context db;

        public KhachHang_DAL(DB_DUAN1_Nhom6Context context)
        {
            db = context;
        }
        public List<KhachHang> LayDanhSachKH()
        {
            return db.KhachHangs.ToList();
        }

        public void ThemKh(KhachHang khachHang)
        {
            db.KhachHangs.Add(khachHang);
            db.SaveChanges();
        }

        public void SuaKH(KhachHang khachHang)
        {
            db.KhachHangs.Update(khachHang);
            db.SaveChanges();
        }

        public void xoakh(int id)
        {
            var kh = db.KhachHangs.FirstOrDefault(kh => kh.IdKh == id);
            if (kh != null)
            {
                db.KhachHangs.Remove(kh);
                db.SaveChanges();
            }
        }

        public List<KhachHang> TimKiemKH(string keyword)
        {
            return db.KhachHangs.Where(kh => kh.HoTen.ToLower().Contains(keyword) || kh.Email.ToLower().Contains(keyword) || kh.Sdt.Contains(keyword)).ToList();
        }
    }
}
