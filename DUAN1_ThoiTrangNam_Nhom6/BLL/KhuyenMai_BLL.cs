using DUAN1_ThoiTrangNam_Nhom6.DAL;
using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.BLL
{
    
    public class KhuyenMai_BLL
    {


        KhuyenMai_DAL khuyenMai_DAL = new KhuyenMai_DAL();

        public List<KhuyenMai> laythongtin()
        {      
                return khuyenMai_DAL.Laythongtinkm();        
        }

        public bool ThemKhuyenMai(KhuyenMai khuyenMai)
        {
            return khuyenMai_DAL.ThemKhuyenMai(khuyenMai);
        }

        public bool SuaKhuyenMai(KhuyenMai khuyenMai)
        {
            return khuyenMai_DAL.SuaKhuyenMai(khuyenMai);
        }

        public bool XoaKhuyenMai(int id)
        {
            return khuyenMai_DAL.XoaKhuyenMai(id);
        }

        public int KiemTraSoLuongKhuyenMaiConLai(int maKhuyenMai)
        {
            return khuyenMai_DAL.KiemTraSoLuongKhuyenMaiConLai(maKhuyenMai);
        }

        public void GiamSoLuongKhuyenMai(int maKhuyenMai)
        {
            khuyenMai_DAL.GiamSoLuongKhuyenMai(maKhuyenMai);
        }

        public void XoaKhuyenMaiHetHan()
        {
            var danhSachKhuyenMai = laythongtin();

            foreach (var khuyenMai in danhSachKhuyenMai)
            {
                if (DateTime.Now > khuyenMai.NgayKetThuc)
                {
                    XoaKhuyenMai(khuyenMai.IdKhuyenMai);
                }
            }
        }
        public void CapNhatSoLuongSanPhamCT(int maKhuyenMai, int soLuong)
        {        
             khuyenMai_DAL.CapNhatSoLuongSanPhamCT(maKhuyenMai, soLuong);
        }
        public void TangSoLuongKhuyenMai(int maKhuyenMai, int soLuong)
        {
            khuyenMai_DAL.TangSoLuongKhuyenMai(maKhuyenMai, soLuong);
        }     
    }
}
