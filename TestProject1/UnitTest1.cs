using DUAN1_ThoiTrangNam_Nhom6.DAL;
using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private SanPham_DAL sanPham_DAL;
        private SanPhamCT_DAL sanPhamCT_DAL;
        private DB_DUAN1_Nhom6Context _db;

        [SetUp]
        public void SetUp()
        {
            _db = new DB_DUAN1_Nhom6Context();
            sanPham_DAL = new SanPham_DAL(_db);
            sanPhamCT_DAL = new SanPhamCT_DAL(_db);
        }

        //=========================================== SAN PHAM =========================================
        // Thêm
        [Test]
        public void AddLoaiSP_1KyTu()
        {
            Assert.Throws<ArgumentException>(() => sanPham_DAL.ThemSanPham(new Sanpham(1, "A", true)));
        }

        [Test]
        public void AddLoaiSP_51KyTu()
        {
            Assert.Throws<ArgumentException>(() => sanPham_DAL.ThemSanPham(new Sanpham(1, new string('A', 51), true)));
        }

        [Test]
        public void AddIdSP_Am1()
        {
            Assert.Throws<ArgumentException>(() => sanPham_DAL.ThemSanPham(new Sanpham(-1, "Quần", true)));
        }

        [Test]
        public void AddIdSP_101()
        {
            Assert.Throws<ArgumentException>(() => sanPham_DAL.ThemSanPham(new Sanpham(101, "Quần", true)));
        }

        // Sửa
        [Test]
        public void SuaSP_Null()
        {
            var sanPham = new Sanpham(1, "Quần", true);
            Assert.Throws<NullReferenceException>(() => sanPham_DAL.SuaSanPham(null));
        }

        [Test]
        public void SuaSP_IdKhongKhop()
        {
            Assert.Throws<NullReferenceException>(() => sanPham_DAL.SuaSanPham(new Sanpham(11, "Quần", true)));
        }

        [Test]
        public void SuaLoaiSP_1KyTu()
        {
            Assert.Throws<ArgumentException>(() => sanPham_DAL.SuaSanPham(new Sanpham(1, "A", true)));
        }

        [Test]
        public void SuaLoaiSP_51KyTu()
        {
            Assert.Throws<ArgumentException>(() => sanPham_DAL.SuaSanPham(new Sanpham(1, new string('A', 51), true)));
        }

        [Test]
        public void SuaIdSP_Am1()
        {
            Assert.Throws<ArgumentException>(() => sanPham_DAL.SuaSanPham(new Sanpham(-1, "Quần", true)));
        }

        [Test]
        public void SuaIdSP_101()
        {
            Assert.Throws<ArgumentException>(() => sanPham_DAL.SuaSanPham(new Sanpham(101, "Quần", true)));
        }

        // Xoá
        [Test]
        public void XoaSP_KhongTonTai()
        {
            Assert.Throws<NullReferenceException>(() => sanPham_DAL.XoaSanPham(99));
        }

        //=========================================== SAN PHAM CHI TIET=========================================
        // Thêm
        private byte[] ConvertImageToByteArray(string imagePath)
        {
            return File.ReadAllBytes(imagePath);
        }

        [Test]
        public void ThemSPCT_TenSPCT4KyTu()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần", "XL", "Daaaaa", "Bluedfsdf", 10, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_TenSPCT60KyTu()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, new string('a', 60), "XL", "Daaaaa", "Bluedfsdf", 10, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_TenSPCT51KyTu()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, new string('a', 51), "XL", "Daaaaa", "Bluedfsdf", 10, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_Size0KyTu()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "", "Daaaaa", "Bluedfsdf", 10, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_Size100KyTu()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                new string('a', 100), "Daaaaa", "Bluedfsdf", 10, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_Size51KyTu()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                new string('a', 51), "Daaaaa", "Bluedfsdf", 10, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_ChatLieu4KyTu()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "XL", "abcd", "Bluedfsdf", 10, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_ChatLieu2KyTu()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "XL", "ab", "Bluedfsdf", 10, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_ChatLieu51KyTu()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "XL", new string('a', 51), "Bluedfsdf", 10, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_MauSac1KyTu()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "XL", "Da bò", "b", 10, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_MauSac80KyTu()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "XL", "Da bò", new string('a', 80), 10, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_MauSac51KyTu()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "XL", "Da bò", new string('a', 51), 10, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_SoLuong0()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "XL", "Da bò", "Bluedfsdf", 0, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_SoLuong20()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "XL", "Da bò", "Bluedfsdf", 20, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_SoLuong11()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "XL", "Da bò", "Bluedfsdf", 11, 500, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_GiaBan4()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "XL", "Da bò", "Bluedfsdf", 10, 4, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_GiaBan567()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "XL", "Da bò", "Bluedfsdf", 10, 567, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_GiaBan600()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<ArgumentException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "XL", "Da bò", "Bluedfsdf", 10, 600, "Ghi chú", imageData, true, 2)));
        }

        [Test]
        public void ThemSPCT_LoaiSPNull()
        {
            string imagePath = @"C:\Users\ngduy\OneDrive\Pictures\soi co doc.jpg";
            byte[] imageData = ConvertImageToByteArray(imagePath);
            Assert.Throws<NullReferenceException>(() => sanPhamCT_DAL.ThemSanPhamCT(new Sanphamct(1, "Quần bò",
                "XL", "Da bò", "Bluedfsdf", 10, 500, "Ghi chú", imageData, true, 100)));
        }

        // Xoá
        public void XoaSPCT_IdKhongKhop()
        {
            Assert.Throws<NullReferenceException>(() => sanPhamCT_DAL.XoaSanPhamCT(99));
        }
    }
}