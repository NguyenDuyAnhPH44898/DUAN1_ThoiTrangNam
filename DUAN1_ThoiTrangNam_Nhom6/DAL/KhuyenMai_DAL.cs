using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL
{
    
    public class KhuyenMai_DAL
    {     
        DB_DUAN1_Nhom6Context db = new DB_DUAN1_Nhom6Context();

        public List<KhuyenMai> Laythongtinkm()
        {
            return db.KhuyenMais.ToList();
        }

        public KhuyenMai_DAL()
        {
            db = new DB_DUAN1_Nhom6Context();
        }

        public bool ThemKhuyenMai(KhuyenMai khuyenMai)
        {
            try
            {
                db.KhuyenMais.Add(khuyenMai);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool SuaKhuyenMai(KhuyenMai khuyenMai)
        {
            try
            {
                var km = db.KhuyenMais.Find(khuyenMai.IdKhuyenMai);
                if (km != null)
                {
                    km.MaKhuyenMai = khuyenMai.MaKhuyenMai;
                    km.NgayKetThuc = khuyenMai.NgayKetThuc;
                    km.PhanTramGiamGia = khuyenMai.PhanTramGiamGia;
                    km.SoLuong = khuyenMai.SoLuong;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool XoaKhuyenMai(int id)
        {
            try
            {
                var km = db.KhuyenMais.Find(id);
                if (km != null)
                {
                    db.KhuyenMais.Remove(km);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public int KiemTraSoLuongKhuyenMaiConLai(int maKhuyenMai)
        {
            // Sử dụng LINQ để truy vấn dữ liệu từ cơ sở dữ liệu
            var soluong = db.KhuyenMais.FirstOrDefault(sp => sp.IdKhuyenMai == maKhuyenMai);
            if (soluong != null)
            {
                return soluong.SoLuong;
            }
            return 0;
        }

        public void GiamSoLuongKhuyenMai(int maKhuyenMai)
        {
           
                var khuyenMai = db.KhuyenMais.FirstOrDefault(km => km.IdKhuyenMai == maKhuyenMai);
                if (khuyenMai != null)
                {
                    khuyenMai.SoLuong--;
                    db.SaveChanges();
                }
            
        }

        public void TangSoLuongKhuyenMai(int maKhuyenMai, int soLuong)
        {
           
                var khuyenMai = db.KhuyenMais.FirstOrDefault(km => km.IdKhuyenMai == maKhuyenMai);
                if (khuyenMai != null)
                {
                    khuyenMai.SoLuong += soLuong;
                    db.SaveChanges();
                }
            
        }

       
        public void CapNhatSoLuongSanPhamCT(int maKhuyenMai, int soLuong)
        {
             var khuyenMai = db.KhuyenMais.FirstOrDefault(km => km.IdKhuyenMai == maKhuyenMai);
                if (khuyenMai != null)
                {
                    khuyenMai.SoLuong = soLuong;
                    db.SaveChanges();
                    
                }                        
        }
    }
   
}
