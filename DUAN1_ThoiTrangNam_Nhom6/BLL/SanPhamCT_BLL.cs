using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using DUAN1_ThoiTrangNam_Nhom6.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DUAN1_ThoiTrangNam_Nhom6.GUI;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace DUAN1_ThoiTrangNam_Nhom6.BLL
{
    public class SanPhamCT_BLL
    {
        private readonly DB_DUAN1_Nhom6Context _dbContext;
        private readonly SanPhamCT_DAL sanPhamCT_DAL;
        public SanPhamCT_BLL()
        {
            _dbContext = new DB_DUAN1_Nhom6Context();
            sanPhamCT_DAL = new SanPhamCT_DAL(new DB_DUAN1_Nhom6Context());

        }
        public List<Sanphamct> LayDanhSachSanPhamCT()
        {
            return _dbContext.Sanphamcts.ToList();
        }

        public  void GiamSoLuongSanPhamTrongKho(int maSanPham, int soLuongGiam)
        {
            // Gọi phương thức từ lớp DAL để giảm số lượng sản phẩm trong kho
            sanPhamCT_DAL.GiamSoLuongSanPhamTrongKho(maSanPham, soLuongGiam);
        }


        public int LaySoLuongTrongKho(int maSanPham)
        {
            return sanPhamCT_DAL.LaySoLuongTrongKho(maSanPham);
        }
     
        public void CapNhatSoLuongSanPhamCT(int maSanPham, int soLuong)
        {
            sanPhamCT_DAL.CapNhatSoLuongSanPhamCT(maSanPham, soLuong);
        }

        public bool ThemSanPhamCT(Sanphamct spct)
        {
            return sanPhamCT_DAL.ThemSanPhamCT(spct);
        }
       
     
        public bool CapNhatSanPhamCT(int idSanPhamCT, string size, string tensp, string mauSac, string chatLieu, int soLuong, double giaBan, string ghiChu, byte[] imageData)
        {
            try
            {

                Sanphamct sanphamct = _dbContext.Sanphamcts.FirstOrDefault(sp => sp.IdSpct == idSanPhamCT);
                if (sanphamct != null)
                {

                    sanphamct.Size = size;
                    sanphamct.TenSanpham = tensp;
                    sanphamct.MauSac = mauSac;
                    sanphamct.ChatLieu = chatLieu;
                    sanphamct.SoLuong = soLuong;
                    sanphamct.GiaBan = giaBan;
                    sanphamct.GhiChu = ghiChu;
                    sanphamct.HinhAnh = imageData;

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
        public bool XoaSanPhamCT(int idSanPhamCT)
        {
            try
            {
                Sanphamct sanphamct = _dbContext.Sanphamcts.FirstOrDefault(sp => sp.IdSpct == idSanPhamCT);
                if (sanphamct != null)
                {
                    _dbContext.Sanphamcts.Remove(sanphamct);
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
