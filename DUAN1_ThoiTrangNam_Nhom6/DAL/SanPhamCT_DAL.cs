using DUAN1_ThoiTrangNam_Nhom6.BLL;
using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL
{
    public class SanPhamCT_DAL
    {
        private readonly DB_DUAN1_Nhom6Context db;
        private readonly HoaDonCT_BLL hoaDonCT_BLL;

        public SanPhamCT_DAL(DB_DUAN1_Nhom6Context context)
        {
            hoaDonCT_BLL = new HoaDonCT_BLL();
            db = context;
        }

        public List<Sanphamct> LayDanhSachSanPhamCT()
        {
            return db.Sanphamcts.ToList();
        }

        public List<HoaDonCt> LayDanhSachHoaDonChiTietCuaKhachHang()
        {
            return db.HoaDonCts.ToList();
        }

        public void GiamSoLuongSanPhamTrongKho(int maSanPham, int soLuongGiam)
        {
            var sanPham = db.Sanphamcts.FirstOrDefault(s => s.IdSanpham == maSanPham);
            if (sanPham != null)
            {
                sanPham.SoLuong -= soLuongGiam;
                db.SaveChanges();
            }
        }

        public int LaySoLuongTrongKho(int maSanPham)
        {
            // Sử dụng LINQ để truy vấn dữ liệu từ cơ sở dữ liệu
            var soluong = db.Sanphamcts.FirstOrDefault(sp => sp.IdSanpham == maSanPham);
            if (soluong != null)
            {
                return soluong.SoLuong;
            }
            return 0;
        }

        public void CapNhatSoLuongSanPhamCT(int maSanPham, int soLuong)
        {
            var sanPhamCT = db.Sanphamcts.FirstOrDefault(sp => sp.IdSpct == maSanPham);
            if (sanPhamCT != null)
            {
                sanPhamCT.SoLuong = soLuong;
                db.SaveChanges();
            }
        }

        public bool ThemSanPhamCT(Sanphamct sanPhamCT)
        {
            try
            {
                ValidateSPCT(sanPhamCT);
                db.Sanphamcts.Add(sanPhamCT);
                db.SaveChanges();
                return true;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
        }

        private void ValidateSPCT(Sanphamct sanphamct)
        {
            if (sanphamct.TenSanpham.Length < 5 || sanphamct.TenSanpham.Length > 50)
            {
                throw new ArgumentException("Tên sản phẩm từ 5 - 50 ký tự");
            }

            if (sanphamct.Size.Length < 1 || sanphamct.Size.Length > 50)
            {
                throw new ArgumentException("Kích thước sản phẩm từ 1 - 50 ký tự");
            }
            if (sanphamct.ChatLieu.Length < 5 || sanphamct.ChatLieu.Length > 50)
            {
                throw new ArgumentException("Chất liệu sản phẩm từ 5 - 50 ký tự");
            }
            if (sanphamct.MauSac.Length < 2 || sanphamct.MauSac.Length > 50)
            {
                throw new ArgumentException("Màu sắc sản phẩm từ 2 - 50 ký tự");
            }
            if (sanphamct.SoLuong < 1 || sanphamct.SoLuong > 10)
            {
                throw new ArgumentException("Số lượng sản phẩm từ 1 - 10");
            }
            if (sanphamct.GiaBan < 5 || sanphamct.GiaBan > 500)
            {
                throw new ArgumentException("Giá bán sản phẩm từ 5 - 500");
            }
            var existidSanPham = db.Sanphams.FirstOrDefault(x => x.IdSanpham == sanphamct.IdSanpham);
            if (existidSanPham == null)
            {
                throw new NullReferenceException("Loại sản phẩm không tồn tại");
            }
        }

        public void XoaSanPhamCT(int id)
        {
            var sanphamct = db.Sanphamcts.FirstOrDefault(sp => sp.IdSanpham == id);
            if (sanphamct == null)
            {
                throw new NullReferenceException("Sản phẩm chi tiết không tồn tại");
            }
            if (sanphamct != null)
            {
                db.Sanphamcts.Remove(sanphamct);
                db.SaveChanges();
            }
        }
    }
}