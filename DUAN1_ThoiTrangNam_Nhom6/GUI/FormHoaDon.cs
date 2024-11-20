using DUAN1_ThoiTrangNam_Nhom6.BLL;
using DUAN1_ThoiTrangNam_Nhom6.DAL;
using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    public partial class FormHoaDon : Form
    {
        DB_DUAN1_Nhom6Context db = new DB_DUAN1_Nhom6Context();
        private HoaDon_BLL hoaDon;
        private KhachHang_BLL khachhang;
        private NguoiDung_BLL nguoiDung;
        private KhuyenMai_BLL khuyenMai;
        private HoaDonCT_BLL hoaDonChiTiet;
        private SanPhamCT_BLL sanPhamCT;
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            hoaDon = new HoaDon_BLL(new DB_DUAN1_Nhom6Context());
            khachhang = new KhachHang_BLL();
            khuyenMai = new KhuyenMai_BLL();
            hoaDonChiTiet = new HoaDonCT_BLL();
            sanPhamCT = new SanPhamCT_BLL();
            nguoiDung = NguoiDung_BLL.Instance;
            loadHoaDonchitiet(0);
            loadhoadonthanhtoan();
        }
        public void loadHoaDonchitiet(int maHoaDon)
        {
            int stt = 1;
            var dataToShow = (from hdct in hoaDonChiTiet.LayDanhSachHoaDonChiTietCuaKhachHang()
                              join hd in hoaDon.LayDanhSachHoadon()
                              on hdct.IdHd equals hd.IdHd
                              join spct in sanPhamCT.LayDanhSachSanPhamCT()
                              on hdct.IdSpct equals spct.IdSpct
                              where hdct.IdHd == maHoaDon
                              select new
                              {
                                  STT = stt++,
                                  MaHoaDon = hdct.IdHd,
                                  TenSanPham = spct.TenSanpham,
                                  KichThuoc = spct.Size,
                                  MauSac = spct.MauSac,
                                  ChatLieu = spct.ChatLieu,
                                  GiaBan = spct.GiaBan,
                                  SoLuongBan = hdct.SoLuong,
                                  ThanhTien = hdct.DonGia,
                              }).ToList();
            dgv_hoadonchitiet.DataSource = dataToShow;
            dgv_hoadonchitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void loadData(List<HoaDon> danhSachHoaDon)
        {
            dgv_hoadon.DataSource = danhSachHoaDon;
        }

        public void loadhoadonthanhtoan()
        {
            int stt = 1;
            var dataToShow = (from hd in hoaDon.LayDanhSachHoadon()
                              join kh in khachhang.LayDanhSachKH()
                              on hd.IdKh equals kh.IdKh
                              join km in khuyenMai.laythongtin()
                              on hd.IdKhuyenMai equals km.IdKhuyenMai into kmGroup
                              from km in kmGroup.DefaultIfEmpty()
                              join nd in nguoiDung.laydanhsachnguoidung()
                              on hd.IdNd equals nd.IdNd
                              where hd.TinhTrang == true 
                              select new
                              { 
                                  STT = stt++,
                                  MaHoaDon = hd.IdHd,
                                  NguoiTao = nd.HoTen,
                                  MaKhuyemai = km != null ? km.MaKhuyenMai : "Không áp dụng",
                                  NgayTaoHD = hd.NgayTao,
                                  TenKhachHang = kh.HoTen,
                                  SDT = kh.Sdt,
                                  kh.DiaChi,
                                  TongTien = hd.TongTien,
                                  TrangThai = "Đã thanh toán"
                              }).ToList();
            dgv_hoadon.DataSource = dataToShow;
            dgv_hoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ThanhToanFormBanHang(object sender, EventArgs e)
        {
            loadhoadonthanhtoan();
        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int maHoaDon = Convert.ToInt32(dgv_hoadon.Rows[e.RowIndex].Cells["MaHoaDon"].Value);
                loadHoaDonchitiet(maHoaDon);
            }
        }

        private void txt_tkhdcho_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_tkhdcho.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {              
                loadhoadonthanhtoan();
            }
            else
            {
                int stt = 1;
               
                keyword = keyword.ToLower();
             
                var dataToShow = (from hd in hoaDon.LayDanhSachHoadon()
                                  join kh in khachhang.LayDanhSachKH()
                                  on hd.IdKh equals kh.IdKh
                                  join km in khuyenMai.laythongtin()
                                  on hd.IdKhuyenMai equals km.IdKhuyenMai
                                  join nd in nguoiDung.laydanhsachnguoidung()
                                  on hd.IdNd equals nd.IdNd                                 
                                  where hd.TinhTrang == true && (kh.HoTen.ToLower().Contains(keyword) || hd.IdHd.ToString().ToLower().Contains(keyword) || nd.HoTen.ToString().ToLower().Contains(keyword)) 
                                  select new
                                  {
                                      STT = stt++,
                                      MaHoaDon = hd.IdHd,
                                      NguoiTao = nd.HoTen,
                                      NgayTaoHD = hd.NgayTao,
                                      TenKhachHang = kh.HoTen,
                                      SDT = kh.Sdt,
                                      kh.DiaChi,
                                      TongTien = hd.TongTien,
                                      TrangThai = "Đã thanh toán"
                                  }).ToList();
                dgv_hoadon.DataSource = dataToShow;
                dgv_hoadon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        public void XuatPDF(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont("C:\\Windows\\Fonts\\cour.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); // ĐOẠN NÀY TÌM PATH ĐẾN FILE FONT TRONG MÁY RỒI COPY VÀO
            PdfPTable pdfTable = new PdfPTable(dgw.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;


            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            // Add header
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            // Add datarow
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = filename;
            saveFileDialoge.DefaultExt = ".pdf";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialoge.FileName, FileMode.Create))
                {
                    iTextSharp.text.Document pdfdoc = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }

        private void btn_xuathd_Click(object sender, EventArgs e)
        {
            XuatPDF(dgv_hoadon, "test");
        }
    }
    
}

