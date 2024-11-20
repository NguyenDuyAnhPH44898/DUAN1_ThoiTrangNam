using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL
{
    public class NhanVien_Dal
    {
        private readonly DB_DUAN1_Nhom6Context db;

        public NhanVien_Dal(DB_DUAN1_Nhom6Context context)
        {
            db = context;
        }

        public List<NguoiDung> LayDanhSachND()
        {
            return db.NguoiDungs.ToList();
        }

        public void ThemND(NguoiDung nguoiDung)
        {
            db.NguoiDungs.Add(nguoiDung);
            db.SaveChanges();
        }

        public void SuaND(NguoiDung nguoiDung)
        {
            db.Entry(nguoiDung).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void XoaND(int mand)
        {
            var nguoidung = db.NguoiDungs.FirstOrDefault(sp => sp.IdNd == mand);
            if (nguoidung != null)
            {
                db.NguoiDungs.Remove(nguoidung);
                db.SaveChanges();
            }
        }
    }
}
