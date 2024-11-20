using DUAN1_ThoiTrangNam_Nhom6.DAL;
using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.BLL
{
    public class Thongke_BLL
    {
        private Thongke_DAL thongke_DAL;

        public Thongke_BLL()
        {
            thongke_DAL = new Thongke_DAL();
        }

        public double TinhTongTienHoaDon()
        {
            return thongke_DAL.TinhTongTienHoaDon();
        }

        public int TinhTongSoSanPham()
        {
            return thongke_DAL.TinhTongSoSanPham();
        }

        public int TinhTongSoHoaDon()
        {
            return thongke_DAL.TinhTongSoHoaDon();
        }


        public List<HoaDonCt> thongkehoadonct()
        {
            return thongke_DAL.thognkehoadonct();
        }
        public List<Sanphamct> SanPhamCT()
        {
            return thongke_DAL.sanPhamCT();
        }

        public List<Sanpham> GetGiays()
        {
            return thongke_DAL.GetGiays();
        }

        public List<HoaDon> GetHoadons()
        {
            return thongke_DAL.GetHoadons();
        }
    }
}
