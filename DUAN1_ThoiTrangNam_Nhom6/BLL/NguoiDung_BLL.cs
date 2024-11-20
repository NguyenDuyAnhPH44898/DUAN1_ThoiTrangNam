using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using DUAN1_ThoiTrangNam_Nhom6.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.BLL
{
    public class NguoiDung_BLL
    {
        //private static NguoiDung_BLL instance;
        //private readonly NguoiDung_DAL _nguoiDungDAL;
        //private DB_DUAN1_Nhom6Context _dbContext;

        //public NguoiDung_BLL()
        //{
        //    _dbContext = new DB_DUAN1_Nhom6Context();
        //    _nguoiDungDAL = new NguoiDung_DAL(new DB_DUAN1_Nhom6Context());
        //}

        //public List<NguoiDung> LayThongTinNguoiDung()
        //{
        //    return _dbContext.NguoiDungs.ToList();
        //}


        //public static NguoiDung_BLL Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new NguoiDung_BLL();
        //        }
        //        return instance;
        //    }
        //}

        //private NguoiDung_BLL() { }

        //public NguoiDung XacThuc(string tenDangNhap, string matKhau)
        //{
        //    return NguoiDung_DAL.Instance.XacThuc(tenDangNhap, matKhau);
        //}

        //public string PhanQuyen(int idKieuTaiKhoan)
        //{

        //    if (idKieuTaiKhoan == 1)
        //    {
        //        return "Admin đang đăng nhập!";
        //    }
        //    else if (idKieuTaiKhoan == 2)
        //    {
        //        return "Nhân viên đang đăng nhập!";
        //    }
        //    else
        //    {
        //        return "Tài khoản không có quyền truy cập!";
        //    }
        //}

        private static NguoiDung_BLL _instance;
        private readonly NguoiDung_DAL _nguoiDungDAL;
        private readonly DB_DUAN1_Nhom6Context _dbContext;
        private string _tenDangNhapHienTai;

        private NguoiDung_BLL()
        {
            _dbContext = new DB_DUAN1_Nhom6Context();
            _nguoiDungDAL = new NguoiDung_DAL(_dbContext);
        }

        public List<NguoiDung> laydanhsachnguoidung()
        {
            return _nguoiDungDAL.Laydanhsachnguoidung();
        }
        public static NguoiDung_BLL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NguoiDung_BLL();
                }
                return _instance;
            }
        }

        public void SetTenDangNhapHienTai(string tenDangNhap)
        {
            _tenDangNhapHienTai = tenDangNhap;
        }

        public List<NguoiDung> LayThongTinNguoiDung()
        {
            return _dbContext.NguoiDungs.Where(nd => nd.TenDangNhap == _tenDangNhapHienTai).ToList();
        }

        public NguoiDung XacThuc(string tenDangNhap, string matKhau)
        {
            var authenticatedUser = _nguoiDungDAL.XacThuc(tenDangNhap, matKhau);
            if (authenticatedUser != null)
            {
                SetTenDangNhapHienTai(authenticatedUser.TenDangNhap);
            }
            return authenticatedUser;
        }

        public string PhanQuyen(int idKieuTaiKhoan)
        {
            switch (idKieuTaiKhoan)
            {
                case 1:
                    return "Admin đang đăng nhập!";
                case 2:
                    return "Nhân viên đang đăng nhập!";
                default:
                    return "Tài khoản không có quyền truy cập!";
            }
        }

        public bool CapNhatThongTinNguoiDung(NguoiDung nguoiDung)
        {
            return _nguoiDungDAL.CapNhatThongTinNguoiDung(nguoiDung);
        }
    }

}

