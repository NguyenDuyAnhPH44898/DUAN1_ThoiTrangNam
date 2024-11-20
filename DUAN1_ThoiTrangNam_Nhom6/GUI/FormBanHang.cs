using DUAN1_ThoiTrangNam_Nhom6.BLL;
using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using Microsoft.VisualBasic;
using System.Data;

namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    public partial class FormBanHang : Form
    {
        private int tongtien = 0;
        private string khachhang = " ";
        private string diachi = " ";
        private string SDT = " ";
        private string thungan = " ";
        private double tienkhachtra = 0;
        private double tienthua = 0;
        private SanPham_BLL sanPham_BLL;
        private SanPhamCT_BLL sanPhamCT_BLL;
        private KhachHang_BLL khachHang_BLL;
        private KhuyenMai_BLL khuyenMai_BLL;
        private NguoiDung_BLL nguoiDung_BLL;
        private HoaDon_BLL hoaDon_BLL;
        private HoaDonCT_BLL hoaDonCT_BLL;
        private PictureBox pictureBox;

        private List<Sanphamct> danhSachSanPhamBan;
        private string maSanPhamChon;
        private string maSanPhamCTChon;
        private string tenSanPhamChon;
        private string LoaiSPmua;
        private string Sizemua;
        private string ChatLieumua;
        private string Mausacmua;
        private string Giaban;

        public FormBanHang()
        {
            InitializeComponent();
            hoaDon_BLL = new HoaDon_BLL(new DB_DUAN1_Nhom6Context());
            danhSachSanPhamBan = new List<Sanphamct>();
            dtg_sanphammua.CellValueChanged += dtg_sanphammua_CellValueChanged;
            txt_tongtien.Enabled = false;
            txt_tienthua.Enabled = false;
            cbb_nguoidung.Enabled = false;
            txt_mahoadon.Enabled = false;
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        public void Loaddata()
        {
            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Dock = DockStyle.Fill;
            sanPham_BLL = new SanPham_BLL();
            sanPhamCT_BLL = new SanPhamCT_BLL();
            khachHang_BLL = new KhachHang_BLL();
            khuyenMai_BLL = new KhuyenMai_BLL();
            nguoiDung_BLL = NguoiDung_BLL.Instance;
            hoaDon_BLL = new HoaDon_BLL(new DB_DUAN1_Nhom6Context());
            hoaDonCT_BLL = new HoaDonCT_BLL();
            loaddataSPCT();
            Loadkhachhang();
            LoadkM();
            LoadnguoiDung();
            loadHoaDonCho();
        }

        public void loaddataSPCT()
        {
            sanPham_BLL = new SanPham_BLL();
            sanPhamCT_BLL = new SanPhamCT_BLL();

            var dataToShow = (from sp in sanPham_BLL.LayDanhSachSanPham()
                              join spct in sanPhamCT_BLL.LayDanhSachSanPhamCT()
                              on sp.IdSanpham equals spct.IdSanpham
                              where sp.IsAlive == true
                              select new
                              {
                                  Masanpham = sp.IdSanpham,
                                  LoaiSanPham = sp.LoaiSanpham,
                                  Tensanpham = spct.TenSanpham,
                                  Size = spct.Size,
                                  MauSac = spct.MauSac,
                                  ChatLieu = spct.ChatLieu,
                                  SoLuong = spct.SoLuong,
                                  GiaBan = spct.GiaBan,
                                  GhiCHu = spct.GhiChu,
                                  HinhAnh = ByteArrayToImage(spct.HinhAnh),
                              }).ToList();

            dtg_danhsachSP.DataSource = dataToShow;

            // Đặt chế độ chọn theo Row Header
            dtg_danhsachSP.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
        }

        public void Loadkhachhang()
        {
            khachHang_BLL = new KhachHang_BLL();
            var TenSP = khachHang_BLL.LayDanhSachKH();
            cbb_khachhang.DataSource = TenSP;
            cbb_khachhang.ValueMember = "IdKh";
            cbb_khachhang.DisplayMember = "HoTen";
        }

        public void LoadkM()
        {
            khuyenMai_BLL = new KhuyenMai_BLL();
            var TenSP = khuyenMai_BLL.laythongtin();
            cbb_makm.DataSource = TenSP;
            cbb_makm.ValueMember = "IdKhuyenMai";
            cbb_makm.DisplayMember = "MaKhuyenMai";
            cbb_makm.Visible = false;
        }

        public void LoadnguoiDung()
        {
            nguoiDung_BLL = NguoiDung_BLL.Instance;
            var danhSachNguoiDung = nguoiDung_BLL.LayThongTinNguoiDung();

            if (danhSachNguoiDung.Count > 0)
            {
                var nguoiDung = danhSachNguoiDung[0];

                List<NguoiDung> listNguoiDung = new List<NguoiDung>();
                listNguoiDung.Add(nguoiDung);

                // Gán danh sách người dùng cho DataSource của ComboBox
                cbb_nguoidung.DataSource = listNguoiDung;
                cbb_nguoidung.ValueMember = "IdND";
                cbb_nguoidung.DisplayMember = "HoTen";
                cbb_nguoidung.Visible = true;
            }
            else
            {
                // Nếu không tìm thấy thông tin người dùng, thông báo cho người dùng
                MessageBox.Show("Không tìm thấy thông tin người dùng.");
            }
        }

        public void loadHoaDonCho()
        {
            hoaDon_BLL = new HoaDon_BLL(new DB_DUAN1_Nhom6Context());
            int stt = 1;
            var dataShow = (from hd in hoaDon_BLL.LayDanhSachHoadon()
                            join kh in khachHang_BLL.LayDanhSachKH()
                            on hd.IdKh equals kh.IdKh
                            join km in khuyenMai_BLL.laythongtin()
                            on hd.IdKhuyenMai equals km.IdKhuyenMai into kmGroup
                            from km in kmGroup.DefaultIfEmpty()
                            join nd in nguoiDung_BLL.LayThongTinNguoiDung()
                            on hd.IdNd equals nd.IdNd
                            where hd.TinhTrang == false
                            select new
                            {
                                STT = stt++,
                                MaHoaDon = hd.IdHd,
                                MaKhuyemai = km != null ? km.MaKhuyenMai : "Không áp dụng",
                                NguoiTao = nd.HoTen,
                                TenKhachHang = kh.HoTen,
                                SDT = kh.Sdt,
                                DiaChi = kh.DiaChi,
                                NgayTaoHD = hd.NgayTao,
                                TongTien = hd.TongTien,
                                TrangThai = "Chưa thanh toán"
                            }).ToList();
            dgv_hoadoncho.DataSource = dataShow;
            dgv_hoadoncho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_hoadoncho.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void dtg_danhsachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtg_danhsachSP.Rows[rowIndex];
                maSanPhamChon = selectedRow.Cells["Masanpham"].Value.ToString();
                tenSanPhamChon = selectedRow.Cells["Tensanpham"].Value.ToString();
                Sizemua = selectedRow.Cells["Size"].Value.ToString();
                Mausacmua = selectedRow.Cells["MauSac"].Value.ToString();
                ChatLieumua = selectedRow.Cells["ChatLieu"].Value.ToString();
                Giaban = selectedRow.Cells["GiaBan"].Value.ToString();

                TongTien();
            }
        }

        private decimal CalculateDiscountAmount(decimal totalPrice)
        {
            decimal discountAmount = 0;

            var selectedPromotion = (KhuyenMai)cbb_makm.SelectedItem;

            if (selectedPromotion != null)
            {
                discountAmount = totalPrice * (decimal)(selectedPromotion.PhanTramGiamGia / 100);
            }

            return discountAmount;
        }

        private void dtg_sanphammua_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TongTien();
        }

        private void Themsanphammua()
        {
            string soLuong = txt_soluongban.Text;

            if (!string.IsNullOrEmpty(soLuong) && int.TryParse(soLuong, out int soLuongInt))
            {
                if (dtg_danhsachSP.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dtg_danhsachSP.SelectedCells[0].RowIndex;

                    int maSanPhamChon = Convert.ToInt32(dtg_danhsachSP.Rows[selectedRowIndex].Cells["Masanpham"].Value);

                    SanPhamCT_BLL sanPhamCT_BLL = new SanPhamCT_BLL();

                    int soLuongTrongKho = sanPhamCT_BLL.LaySoLuongTrongKho(maSanPhamChon);

                    if (soLuongInt <= soLuongTrongKho)
                    {
                        string tenSanPhamChon = dtg_danhsachSP.Rows[selectedRowIndex].Cells["Tensanpham"].Value.ToString();
                        string Sizemua = dtg_danhsachSP.Rows[selectedRowIndex].Cells["Size"].Value.ToString();
                        string ChatLieumua = dtg_danhsachSP.Rows[selectedRowIndex].Cells["ChatLieu"].Value.ToString();
                        string Mausacmua = dtg_danhsachSP.Rows[selectedRowIndex].Cells["MauSac"].Value.ToString();
                        double Giaban = Convert.ToDouble(dtg_danhsachSP.Rows[selectedRowIndex].Cells["GiaBan"].Value);

                        double thanhTien = soLuongInt * Giaban;

                        if (dtg_sanphammua.Columns.Count == 0)
                        {
                            dtg_sanphammua.Columns.Add("MaSanPham", "Mã Sản Phẩm");
                            dtg_sanphammua.Columns.Add("TenSanPham", "Tên Sản Phẩm");
                            dtg_sanphammua.Columns.Add("Size", "Size");
                            dtg_sanphammua.Columns.Add("ChatLieu", "Chất Liệu");
                            dtg_sanphammua.Columns.Add("MauSac", "Màu Sắc");
                            dtg_sanphammua.Columns.Add("GiaBan", "Giá Bán");
                            dtg_sanphammua.Columns.Add("SoLuong", "Số Lượng");
                            dtg_sanphammua.Columns.Add("ThanhTien", "Thành Tiền");
                        }

                        dtg_sanphammua.Rows.Add(maSanPhamChon, tenSanPhamChon, Sizemua, ChatLieumua, Mausacmua, Giaban, soLuongInt, thanhTien);

                        TongTien();
                    }
                    else
                    {
                        // Hiển thị thông báo số lượng sản phẩm không đủ trong kho
                        MessageBox.Show("Số lượng sản phẩm không đủ trong kho.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Hiển thị thông báo chọn sản phẩm trước khi thêm vào đơn hàng
                    MessageBox.Show("Vui lòng chọn sản phẩm trước khi thêm vào đơn hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string soLuong = txt_soluongban.Text;
            if (!string.IsNullOrEmpty(soLuong) && int.TryParse(soLuong, out _))
            {
                Themsanphammua();
                TongTien();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dtg_sanphammua.SelectedRows.Count > 0 && !dtg_sanphammua.SelectedRows[0].IsNewRow)
            {
                DataGridViewRow selectedRow = dtg_sanphammua.SelectedRows[0];
                dtg_sanphammua.Rows.Remove(selectedRow);

                TongTien();
            }
            else if (dtg_sanphammua.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
            }
            else
            {
                MessageBox.Show("Không còn sản phẩm nào để xóa.");
            }
        }

        private void btn_suasl_Click(object sender, EventArgs e)
        {
            if (dtg_sanphammua.SelectedRows.Count > 0)
            {
                // Lấy chỉ mục của dòng được chọn
                int rowIndex = dtg_sanphammua.SelectedRows[0].Index;

                string currentQuantity = dtg_sanphammua.Rows[rowIndex].Cells["SoLuong"].Value.ToString();
                string newQuantity = Interaction.InputBox("Nhập số lượng mới:", "Sửa số lượng", currentQuantity);

                if (!string.IsNullOrEmpty(newQuantity))
                {
                    if (int.TryParse(newQuantity, out int quantity))
                    {
                        dtg_sanphammua.Rows[rowIndex].Cells["SoLuong"].Value = quantity;

                        TongTien();

                        txt_soluongban.Text = quantity.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa số lượng.");
            }
        }

        private void cb_khuyenmai_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_khuyenmai.Checked)
            {
                cbb_makm.Visible = true;
            }
            else
            {
                cbb_makm.Visible = false;
            }
            TongTien();
        }

        private void cbb_makm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_makm.SelectedItem != null)
            {
                var selectedPromotion = (KhuyenMai)cbb_makm.SelectedItem;
                if (selectedPromotion != null)
                {
                    TongTien();
                }
            }
        }

        private void txt_tksanpham_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_hoadoncho.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(keyword))
            {
                var re = (from sp in sanPham_BLL.LayDanhSachSanPham()
                          join spct in sanPhamCT_BLL.LayDanhSachSanPhamCT()
                          on sp.IdSanpham equals spct.IdSanpham
                          where sp.IdSanpham.ToString().Contains(keyword) || sp.LoaiSanpham.ToLower().Contains(keyword)
                          select new
                          {
                              Masanpham = sp.IdSanpham,
                              LoaiSanPham = sp.LoaiSanpham,
                              Tensanpham = spct.TenSanpham,
                              Size = spct.Size,
                              MauSac = spct.MauSac,
                              ChatLieu = spct.ChatLieu,
                              SoLuong = spct.SoLuong,
                              GiaBan = spct.GiaBan,
                              GhiCHu = spct.GhiChu,
                              HinhAnh = ByteArrayToImage(spct.HinhAnh),
                          }).ToList();
                dtg_danhsachSP.DataSource = re;
            }
            else
            {
                loaddataSPCT();
            }
        }

        private void btn_taohoadonban_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tạo hóa đơn chờ không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (cbb_khachhang.SelectedItem == null)
                {
                    MessageBox.Show("Bạn chưa chọn khách hàng để mua.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtg_sanphammua.Rows.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm để tạo hóa đơn chờ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    HoaDon newHoaDon = new HoaDon
                    {
                        IdKh = Convert.ToInt32(cbb_khachhang.SelectedValue),
                        IdNd = Convert.ToInt32(cbb_nguoidung.SelectedValue),
                        NgayTao = DateTime.Now,
                        TongTien = double.Parse(txt_tongtien.Text),
                        IdKhuyenMai = cb_khuyenmai.Checked ? ((KhuyenMai)cbb_makm.SelectedItem).IdKhuyenMai : null,
                    };

                    int newHoaDonId = hoaDon_BLL.ThemHoaDon(newHoaDon);

                    if (newHoaDonId != -1)
                    {
                        foreach (DataGridViewRow row in dtg_sanphammua.Rows)
                        {
                            if (row.Cells["MaSanPham"].Value != null &&
                                row.Cells["SoLuong"].Value != null &&
                                row.Cells["GiaBan"].Value != null)
                            {
                                int maSanPham, soLuong;
                                double giaBan;

                                if (int.TryParse(row.Cells["MaSanPham"].Value.ToString(), out maSanPham) &&
                                    int.TryParse(row.Cells["SoLuong"].Value.ToString(), out soLuong) &&
                                    double.TryParse(row.Cells["GiaBan"].Value.ToString(), out giaBan))
                                {
                                    HoaDonCt hoaDonCt = new HoaDonCt
                                    {
                                        IdHd = newHoaDonId,
                                        IdSpct = maSanPham,
                                        SoLuong = soLuong,
                                        DonGia = giaBan,
                                        ThanhTien = soLuong * giaBan
                                    };

                                    hoaDon_BLL.ThemHoaDonChiTiet(hoaDonCt);
                                    bool hetKhuyenMai = false;

                                    if (cb_khuyenmai.Checked)
                                    {
                                        KhuyenMai selectedKhuyenMai = (KhuyenMai)cbb_makm.SelectedItem;
                                        int maKhuyenMai = selectedKhuyenMai.IdKhuyenMai;

                                        if (khuyenMai_BLL.KiemTraSoLuongKhuyenMaiConLai(maKhuyenMai) > 0)
                                        {
                                            khuyenMai_BLL.GiamSoLuongKhuyenMai(maKhuyenMai);

                                            if (khuyenMai_BLL.KiemTraSoLuongKhuyenMaiConLai(maKhuyenMai) <= 0)
                                            {
                                                hetKhuyenMai = false;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Số lượng khuyến mãi đã hết. Vui lòng chọn mã khuyến mãi khác hoặc không chọn khuyến mãi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            cb_khuyenmai.Checked = false;
                                        }
                                    }

                                    sanPhamCT_BLL.GiamSoLuongSanPhamTrongKho(maSanPham, soLuong);
                                }
                                else
                                {
                                    MessageBox.Show("Dữ liệu sản phẩm không hợp lệ.");
                                }
                            }
                        }

                        MessageBox.Show("Tạo hóa đơn chờ thành công.");
                        loadHoaDonCho();
                        loaddataSPCT();
                        dtg_sanphammua.Rows.Clear();
                        ClearForm();
                        txt_tongtien.Clear();
                        cbb_khachhang.SelectedItem = null;
                        cb_khuyenmai.Checked = false;
                        txt_mahoadon.Clear();
                        txt_tienthua.Clear();
                        txt_tienkhachdua.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi tạo hóa đơn. Vui lòng thử lại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tạo hóa đơn chờ: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            danhSachSanPhamBan.Clear();
        }

        private void btn_huyhoadon_Click(object sender, EventArgs e)
        {
            if (dgv_hoadoncho.SelectedCells.Count > 0)
            {
                try
                {
                    int selectedRowIndex = dgv_hoadoncho.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dgv_hoadoncho.Rows[selectedRowIndex];

                    int maHoaDon = Convert.ToInt32(selectedRow.Cells["MaHoaDon"].Value);

                    List<HoaDonCt> hoaDonChiTietList = hoaDonCT_BLL.LayDanhSachHoaDonChiTietCuaHoaDon(maHoaDon);
                    List<HoaDon> hoaDons = hoaDon_BLL.LayDanhSachHoadon();

                    DialogResult result = MessageBox.Show("Bạn có chắc muốn huỷ hoá đơn này?", "Xác nhận huỷ hoá đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bool deleteResult = hoaDon_BLL.XoaHoaDonVaChiTiet(maHoaDon);
                        if (deleteResult)
                        {
                            foreach (HoaDonCt hoaDonChiTiet in hoaDonChiTietList)
                            {
                                if (hoaDonChiTiet != null)
                                {
                                    int maSanPham = hoaDonChiTiet.IdSpct.Value;
                                    int soLuongMua = hoaDonChiTiet.SoLuong.Value;

                                    int soLuongCon = sanPhamCT_BLL.LaySoLuongTrongKho(maSanPham);

                                    int tongSoLuong = soLuongCon + soLuongMua;

                                    sanPhamCT_BLL.CapNhatSoLuongSanPhamCT(maSanPham, tongSoLuong);
                                }
                                else
                                {
                                }
                            }

                            if (cb_khuyenmai.Checked != false)
                            {
                                KhuyenMai selectedKhuyenMai = (KhuyenMai)cbb_makm.SelectedItem;
                                int maKhuyenMai = selectedKhuyenMai.IdKhuyenMai;

                                int soLuongCon = khuyenMai_BLL.KiemTraSoLuongKhuyenMaiConLai(maKhuyenMai);

                                HoaDon hoaDonWithKhuyenMai = hoaDons.FirstOrDefault(hd => hd.IdKhuyenMai.HasValue && hd.IdKhuyenMai.Value == maKhuyenMai);

                                if (hoaDonWithKhuyenMai != null && hoaDonWithKhuyenMai.IdKhuyenMai.HasValue)
                                {
                                    int maKhuyenMaiTrongHoaDon = hoaDonWithKhuyenMai.IdKhuyenMai.Value;

                                    int tongSoLuong = soLuongCon + 1;

                                    khuyenMai_BLL.CapNhatSoLuongSanPhamCT(maKhuyenMaiTrongHoaDon, tongSoLuong);
                                }
                            }

                            MessageBox.Show("Huỷ hoá đơn thành công");
                            loaddataSPCT();
                            loadHoaDonCho();
                            txt_tongtien.Clear();
                            cbb_khachhang.SelectedItem = null;
                            cb_khuyenmai.Checked = false;
                            txt_mahoadon.Clear();
                            txt_tienthua.Clear();
                            txt_tienkhachdua.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi huỷ hoá đơn.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hoá đơn để huỷ.");
            }
        }

        private void dgv_hoadoncho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_hoadoncho.Rows[e.RowIndex];
                txt_mahoadon.Text = selectedRow.Cells["MaHoaDon"].Value.ToString();
                cbb_khachhang.Text = selectedRow.Cells["TenKhachHang"].Value.ToString();
                string maKhuyenMai = selectedRow.Cells["MaKhuyemai"].Value.ToString();
                cbb_makm.Text = maKhuyenMai;
                cbb_nguoidung.Text = selectedRow.Cells["NguoiTao"].Value.ToString();
                double tongTien;
                double.TryParse(selectedRow.Cells["TongTien"].Value.ToString(), out tongTien);
                txt_tongtien.Text = tongTien.ToString("N0");

                if (maKhuyenMai.Equals("Không áp dụng"))
                {
                    // Hiển thị ComboBox và CheckBox với giá trị "Không áp dụng"

                    cb_khuyenmai.Checked = false;
                    cbb_makm.Visible = false;
                }
                else
                {
                    // Hiển thị ComboBox và CheckBox với giá trị khác
                    cb_khuyenmai.Visible = true;
                    cb_khuyenmai.Checked = true;
                    cbb_makm.Visible = true;
                }
            }
        }

        private void dgv_hoadoncho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_tongtien.Clear();
            cbb_khachhang.SelectedItem = null;
            cb_khuyenmai.Checked = false;
            txt_mahoadon.Clear();
            txt_tienthua.Clear();
            txt_tienkhachdua.Clear();
        }

        private void txt_tkhdcho_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_tkhdcho.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                loadHoaDonCho();
            }
            else
            {
                int stt = 1;

                keyword = keyword.ToLower();

                var dataToShow = (from hd in hoaDon_BLL.LayDanhSachHoadon()
                                  join kh in khachHang_BLL.LayDanhSachKH()
                                  on hd.IdKh equals kh.IdKh
                                  join km in khuyenMai_BLL.laythongtin()
                                  on hd.IdKhuyenMai equals km.IdKhuyenMai
                                  where hd.TinhTrang == false && (kh.HoTen.ToLower().Contains(keyword) || hd.IdHd.ToString().ToLower().Contains(keyword)) // Tìm kiếm theo tên khách hàng hoặc mã hóa đơn (viết thường)
                                  select new
                                  {
                                      STT = stt++,
                                      MaHoaDon = hd.IdHd,
                                      TenKhachHang = kh.HoTen,
                                      SDT = kh.Sdt,
                                      kh.DiaChi,
                                      NgayLapHD = hd.NgayTao,
                                      TongTien = hd.TongTien,
                                      TrangThai = "Chưa thanh toán"
                                  }).ToList();
                dgv_hoadoncho.DataSource = dataToShow;
                dgv_hoadoncho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void TongTien()
        {
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in dtg_sanphammua.Rows)
            {
                if (row.Cells["GiaBan"].Value != null && row.Cells["SoLuong"].Value != null &&
                    decimal.TryParse(row.Cells["GiaBan"].Value.ToString(), out decimal giaBan) &&
                    int.TryParse(row.Cells["SoLuong"].Value.ToString(), out int soLuong))
                {
                    totalPrice += giaBan * soLuong;
                }
            }

            if (cb_khuyenmai.Checked && cbb_makm.SelectedItem != null)
            {
                decimal discountAmount = CalculateDiscountAmount(totalPrice);
                decimal totalPriceWithDiscount = totalPrice - discountAmount;
                txt_tongtien.Text = totalPriceWithDiscount.ToString("N0"); // Định dạng số tiền với dấu phẩy
            }
            else
            {
                txt_tongtien.Text = totalPrice.ToString("N0");
            }
        }

        private void txt_tienkhachdua_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_tienkhachdua.Text) && double.TryParse(txt_tienkhachdua.Text, out double tienKhachDua))
            {
                if (double.TryParse(txt_tongtien.Text, out double tongTien))
                {
                    double tienThua = tienKhachDua - tongTien;

                    txt_tienthua.Text = tienThua.ToString("N0");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tổng tiền hóa đơn hợp lệ.");
                }
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (dgv_hoadoncho.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_hoadoncho.Rows[dgv_hoadoncho.SelectedCells[0].RowIndex];
                int maHoaDon = Convert.ToInt32(selectedRow.Cells["MaHoaDon"].Value);

                // Kiểm tra xem TextBox txt_tienkhachdua có giá trị hợp lệ hay không
                if (!string.IsNullOrEmpty(txt_tienkhachdua.Text) && double.TryParse(txt_tienkhachdua.Text, out double tienKhachDua))
                {
                    bool result = hoaDon_BLL.thanhtoan(maHoaDon);
                    if (result)
                    {
                        MessageBox.Show("Thanh toán hoá đơn thành công");
                        tongtien = Convert.ToInt32(selectedRow.Cells[8].Value);
                        khachhang = selectedRow.Cells[4].Value.ToString();
                        diachi = selectedRow.Cells[6].Value.ToString();
                        SDT = selectedRow.Cells[5].Value.ToString();
                        thungan = cbb_nguoidung.Text;
                        tienkhachtra = tienKhachDua;
                        tienthua = tienkhachtra - tongtien;
                        InBienLai();
                        loadHoaDonCho();
                        txt_tongtien.Clear();
                        cbb_khachhang.SelectedItem = null;
                        cb_khuyenmai.Checked = false;
                        txt_mahoadon.Clear();
                        txt_tienthua.Clear();
                        txt_tienkhachdua.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán hoá đơn không thành công.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng cần khách đưa tiền mới được thanh toán hóa đơn này.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hoá đơn để thanh toán.");
            }
        }

        public void InBienLai()
        {
            ppd_inBienLai.Document = pdoc_inBienLai;
            ppd_inBienLai.ShowDialog();
        }

        private void pdoc_inBienLai_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow selectedRow = dgv_hoadoncho.Rows[dgv_hoadoncho.SelectedCells[0].RowIndex];
            int maHoaDon = Convert.ToInt32(selectedRow.Cells["MaHoaDon"].Value);

            var w = pdoc_inBienLai.DefaultPageSettings.PaperSize.Width;
            int sum = 0;

            #region header

            // Tên của hàng
            e.Graphics.DrawString("GO88_Shop".ToUpper(), new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(100, 20));

            // Thời gian in hoá đơn
            e.Graphics.DrawString(String.Format("HD{0}", maHoaDon), new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 200, 20));

            // Ngày giờ xuất hoá đơn
            e.Graphics.DrawString(String.Format("{0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 200, 45));

            // Định dạng bút vẽ
            Pen blackPen = new Pen(Color.Black, 1);

            // toạ độ theo chiều dọc
            var y = 70;

            // định nghĩa 2 điểm để vẽ dường thẳng
            // cách lề trái 10, lề phải 10
            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);

            // kẻ đường thẳng thứ nhất
            e.Graphics.DrawLine(blackPen, p1, p2);

            // chữ to
            e.Graphics.DrawString("Phiếu thanh toán".ToUpper(), new Font("Courier New", 40, FontStyle.Bold), Brushes.Black, new Point(150, 100));

            // Tổng tiền
            //e.Graphics.DrawString(String.Format("TỔNG TIỀN: {0:N0} VNĐ", tongtien), new Font("Courier New", 14, FontStyle.Bold), Brushes.Black, new Point(500, 240));

            // Khách hàng
            e.Graphics.DrawString(String.Format("Khách hàng: {0}", khachhang), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(100, 180));

            // Địa chỉ
            e.Graphics.DrawString(String.Format("Địa chỉ: {0}", diachi), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(100, 210));

            // Số điện thoại
            e.Graphics.DrawString(String.Format("SĐT: {0}", SDT), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(100, 240));

            // Thu ngân
            e.Graphics.DrawString(String.Format("Thu ngân: {0}", thungan), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(500, 180));

            // Kẻ thẳng thứ 2
            y += 220;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            #endregion header

            #region body

            y += 10;
            e.Graphics.DrawString("STT", new Font("Courier New", 11, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString("Sản phẩm", new Font("Courier New", 11, FontStyle.Bold), Brushes.Black, new Point(50, y));
            e.Graphics.DrawString("SL", new Font("Courier New", 11, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
            e.Graphics.DrawString("Đơn giá", new Font("Courier New", 11, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
            //e.Graphics.DrawString("Thành tiền", new Font("Courier New", 11, FontStyle.Bold), Brushes.Black, new Point(w - 200, y));

            // lấy dữ liệu hoá đơn dựa vào idhoadon
            var result = from hdct in hoaDonCT_BLL.LayDanhSachHoaDonChiTietCuaKhachHang()
                         join hd in hoaDon_BLL.LayDanhSachHoadon()
                         on hdct.IdHd equals hd.IdHd
                         join spct in sanPhamCT_BLL.LayDanhSachSanPhamCT()
                         on hdct.IdSpct equals spct.IdSpct
                         where hdct.IdHd == maHoaDon
                         select new
                         {
                             TenSanPham = spct.TenSanpham,
                             SL = (int)hdct.SoLuong,
                             DonGia = (int)spct.GiaBan,
                         };

            // lập các phần tử của mảng
            // mõi phần tử tương ứng với 1 hàng trên bill
            int i = 1;
            y += 20;
            foreach (var l in result)
            {
                sum += l.DonGia * l.SL;
                e.Graphics.DrawString(string.Format("{0}", i++), new Font("Courier New", 9, FontStyle.Bold), Brushes.Black, new Point(10, y));
                e.Graphics.DrawString(l.TenSanPham, new Font("Courier New", 9, FontStyle.Bold), Brushes.Black, new Point(50, y));
                e.Graphics.DrawString(string.Format("{0:N0}", l.SL), new Font("Courier New", 9, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
                e.Graphics.DrawString(string.Format("{0:N0}", l.DonGia), new Font("Courier New", 9, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
                //e.Graphics.DrawString(string.Format("{0:N0}", l.ThanhTien), new Font("Courier New", 9, FontStyle.Bold), Brushes.Black, new Point(w - 200, y));
                y += 20;
            }

            #endregion body

            #region footer

            y += 300;
            //đường thẳng thứ 3;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            // tổng tiền thanh toán
            y += 20;
            e.Graphics.DrawString(string.Format("TỔNG TIỀN: {0:N0} VNĐ", tongtien), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(w - 350, y));

            // tiền khách trả
            y += 40;
            e.Graphics.DrawString(string.Format("TIỀN KHÁCH TRẢ: {0:N0} VNĐ", tienkhachtra), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(w - 350, y));

            // tiền dư
            y += 50;
            e.Graphics.DrawString(string.Format("TIỀN THỪA: {0:N0} VNĐ", tienthua), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(w - 350, y));

            // đọc số thành chữ
            y += 60;
            foreach (var f in result)
            {
                e.Graphics.DrawString(string.Format("Thành chữ: {0}", new SoThanhChu().ChuyenSoSangChuoi(tongtien)), new Font("Courier New", 13, FontStyle.Italic), Brushes.Black, new Point(10, y));
            }

            // lời cảm ơn
            y += 70;
            e.Graphics.DrawString(string.Format("Xin chân thành cảm ơn sự ủng hộ của quý khách!"), new Font("Courier New", 13, FontStyle.Bold), Brushes.Black, new Point(170, y));

            #endregion footer
        }
    }

    #region SoThanhChu

    public class SoThanhChu
    {
        //123 => một trăm hai ba đồng
        //1,123,000=>một triệu một trăm hai ba nghìn đồng
        //1,123,345,000 => một tỉ một trăm hai ba triệu ba trăm bốn lăm ngàn đồng
        private string[] mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');

        //Viết hàm chuyển số hàng chục, giá trị truyền vào là số cần chuyển và một biến đọc phần lẻ hay không ví dụ 101 => một trăm lẻ một
        private string DocHangChuc(double so, bool daydu)
        {
            string chuoi = "";
            //Hàm để lấy số hàng chục ví dụ 21/10 = 2
            Int64 chuc = Convert.ToInt64(Math.Floor((double)(so / 10)));
            //Lấy số hàng đơn vị bằng phép chia 21 % 10 = 1
            Int64 donvi = (Int64)so % 10;
            //Nếu số hàng chục tồn tại tức >=20
            if (chuc > 1)
            {
                chuoi = " " + mNumText[chuc] + " mươi";
                if (donvi == 1)
                {
                    chuoi += " mốt";
                }
            }
            else if (chuc == 1)
            {//Số hàng chục từ 10-19
                chuoi = " mười";
                if (donvi == 1)
                {
                    chuoi += " một";
                }
            }
            else if (daydu && donvi > 0)
            {//Nếu hàng đơn vị khác 0 và có các số hàng trăm ví dụ 101 => thì biến daydu = true => và sẽ đọc một trăm lẻ một
                chuoi = " lẻ";
            }
            if (donvi == 5 && chuc >= 1)
            {//Nếu đơn vị là số 5 và có hàng chục thì chuỗi sẽ là " lăm" chứ không phải là " năm"
                chuoi += " lăm";
            }
            else if (donvi > 1 || (donvi == 1 && chuc == 0))
            {
                chuoi += " " + mNumText[donvi];
            }
            return chuoi;
        }

        private string DocHangTram(double so, bool daydu)
        {
            string chuoi = "";
            //Lấy số hàng trăm ví du 434 / 100 = 4 (hàm Floor sẽ làm tròn số nguyên bé nhất)
            Int64 tram = Convert.ToInt64(Math.Floor((double)so / 100));
            //Lấy phần còn lại của hàng trăm 434 % 100 = 34 (dư 34)
            so = so % 100;
            if (daydu || tram > 0)
            {
                chuoi = " " + mNumText[tram] + " trăm";
                chuoi += DocHangChuc(so, true);
            }
            else
            {
                chuoi = DocHangChuc(so, false);
            }
            return chuoi;
        }

        private string DocHangTrieu(double so, bool daydu)
        {
            string chuoi = "";
            //Lấy số hàng triệu
            Int64 trieu = Convert.ToInt64(Math.Floor((double)so / 1000000));
            //Lấy phần dư sau số hàng triệu ví dụ 2,123,000 => so = 123,000
            so = so % 1000000;
            if (trieu > 0)
            {
                chuoi = DocHangTram(trieu, daydu) + " triệu";
                daydu = true;
            }
            //Lấy số hàng nghìn
            Int64 nghin = Convert.ToInt64(Math.Floor((double)so / 1000));
            //Lấy phần dư sau số hàng nghin
            so = so % 1000;
            if (nghin > 0)
            {
                chuoi += DocHangTram(nghin, daydu) + " nghìn";
                daydu = true;
            }
            if (so > 0)
            {
                chuoi += DocHangTram(so, daydu);
            }
            return chuoi;
        }

        public string ChuyenSoSangChuoi(double so)
        {
            if (so == 0)
                return mNumText[0];
            string chuoi = "", hauto = "";
            Int64 ty;
            do
            {
                //Lấy số hàng tỷ
                ty = Convert.ToInt64(Math.Floor((double)so / 1000000000));
                //Lấy phần dư sau số hàng tỷ
                so = so % 1000000000;
                if (ty > 0)
                {
                    chuoi = DocHangTrieu(so, true) + hauto + chuoi;
                }
                else
                {
                    chuoi = DocHangTrieu(so, false) + hauto + chuoi;
                }
                hauto = " tỷ";
            } while (ty > 0);
            return chuoi + " đồng";
        }
    }

    #endregion SoThanhChu
}