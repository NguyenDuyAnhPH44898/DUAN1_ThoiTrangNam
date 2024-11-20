using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL
{
    public class SanPham_DAL
    {
        private readonly DB_DUAN1_Nhom6Context db;

        public SanPham_DAL(DB_DUAN1_Nhom6Context context)
        {
            db = context;
        }

        public List<Sanpham> LayDanhSachSanPham()
        {
            return db.Sanphams.ToList();
        }

        public static bool IsAllDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public Sanpham LaySanPhamTheoId(int id)
        {
            return db.Sanphams.FirstOrDefault(s => s.IdSanpham == id);
        }

        public void ThemSanPham(Sanpham sanPham)
        {
            if (sanPham.IdSanpham < 1 || sanPham.IdSanpham > 100)
            {
                throw new ArgumentException("Id loại sản phẩm nhập từ 1 - 100 ");
            }
            if (sanPham.LoaiSanpham.Length < 2 || sanPham.LoaiSanpham.Length > 50)
            {
                throw new ArgumentException("Loại sản phẩm nhập từ 2 - 50 ký tự");
            }
            db.Sanphams.Add(sanPham);
            db.SaveChanges();
        }

        public void SuaSanPham(Sanpham sanPham)
        {
            if (sanPham == null)
            {
                throw new NullReferenceException("Sản phẩm không được bỏ trống");
            }
            if (sanPham.IdSanpham < 1 || sanPham.IdSanpham > 100)
            {
                throw new ArgumentException("Id loại sản phẩm nhập từ 1 - 100 ");
            }
            if (sanPham.LoaiSanpham.Length < 2 || sanPham.LoaiSanpham.Length > 50)
            {
                throw new ArgumentException("Loại sản phẩm nhập từ 2 - 50 ký tự");
            }
            var existingSanPham = db.Sanphams.FirstOrDefault(x => x.IdSanpham == sanPham.IdSanpham);
            if (existingSanPham == null)
            {
                throw new NullReferenceException("Id không tồn tại");
            }
            db.Entry(sanPham).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void XoaSanPham(int id)
        {
            var sanPham = db.Sanphams.FirstOrDefault(sp => sp.IdSanpham == id);
            if (sanPham == null)
            {
                throw new NullReferenceException("Id loại sản phẩm không tồn tại");
            }
            if (sanPham != null)
            {
                db.Sanphams.Remove(sanPham);
                db.SaveChanges();
            }
        }
    }
}