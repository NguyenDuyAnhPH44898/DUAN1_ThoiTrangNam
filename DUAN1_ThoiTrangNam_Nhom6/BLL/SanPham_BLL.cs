using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using DUAN1_ThoiTrangNam_Nhom6.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.BLL
{
    public class SanPham_BLL
    {
        private DB_DUAN1_Nhom6Context _dbContext;
        private readonly SanPham_DAL sanPham_DAL;
        public SanPham_BLL()
        {
            _dbContext = new DB_DUAN1_Nhom6Context();
            sanPham_DAL = new SanPham_DAL(new DB_DUAN1_Nhom6Context());
        }

        public List<Sanpham> LayDanhSachSanPham()
        {
            return _dbContext.Sanphams.ToList();
        }

        


        public void ThemSanPham(Sanpham sanPham)
        {

            sanPham_DAL.ThemSanPham(sanPham);
        }

        public bool SuaSanPham(int idSanPham, string loaiSanPham, bool tinhTrang)
        {
            try
            {

                Sanpham sanPham = _dbContext.Sanphams.FirstOrDefault(sp => sp.IdSanpham == idSanPham);
                if (sanPham != null)
                {

                   
                    sanPham.LoaiSanpham = loaiSanPham;
                    sanPham.IsAlive = tinhTrang;


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

        public bool XoaSanPham(int idSanPham)
        {
            try
            {

                Sanpham sanPham = _dbContext.Sanphams.FirstOrDefault(sp => sp.IdSanpham == idSanPham);
                if (sanPham != null)
                {

                    _dbContext.Sanphams.Remove(sanPham);
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
