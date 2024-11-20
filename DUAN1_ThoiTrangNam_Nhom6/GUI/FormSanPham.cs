using DUAN1_ThoiTrangNam_Nhom6.BLL;
using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using System.Data;
using System.Drawing.Imaging;

namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    public partial class FormSanPham : Form
    {
        private SanPham_BLL sanPham_BLL;
        private SanPhamCT_BLL sanPhamCT_BLL;
        private HoaDon_BLL hoaDon_BLL;
        private PictureBox pictureBox;

        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        public void loaddata()
        {
            sanPham_BLL = new SanPham_BLL();
            sanPhamCT_BLL = new SanPhamCT_BLL();
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoact.Enabled = false;
            btn_capnhatct.Enabled = false;
            loaddataSP();
            loadataloaisp();
            loaddataSPCT();
        }

        //=======================SANPHAM=========================
        public void loaddataSP()
        {
            int stt = 1;
            var danhSachSanPham = sanPham_BLL.LayDanhSachSanPham();

            var dataToShow = danhSachSanPham.Select(sp => new
            {
                STT = stt++,
                Masanpham = sp.IdSanpham,
                LoaiSanPham = sp.LoaiSanpham,
                TinhTrang = sp.IsAlive == true ? "Đang kinh doanh" : "Ngừng kinh doanh"
            }).ToList();
            dtg_danhsachsp.DataSource = dataToShow;
            dtg_danhsachsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtg_danhsachsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtg_danhsachsp.Rows.Count)
            {
                DataGridViewRow selectedRow = dtg_danhsachsp.Rows[e.RowIndex];

                string loaiSanPham = selectedRow.Cells["LoaiSanPham"].Value.ToString();
                bool tinhTrang = selectedRow.Cells["TinhTrang"].Value.ToString() == "Đang kinh doanh" ? true : false;

                txt_loaisp.Text = loaiSanPham;
                cb_dang.Checked = tinhTrang;
                cb_ngung.Checked = !tinhTrang;
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;
            }
        }

        private void txt_timkiemsp_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_timkiemsp.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(keyword))
            {
                var re = sanPham_BLL.LayDanhSachSanPham()
                    .Where(sp => sp.IdSanpham.ToString().Contains(keyword) || sp.LoaiSanpham.ToLower().Contains(keyword))
                    .Select(sp => new
                    {
                        STT = sp.IdSanpham,
                        Masanpham = sp.IdSanpham,
                        LoaiSanPham = sp.LoaiSanpham,
                        TinhTrang = sp.IsAlive == true ? "Đang kinh doanh" : "Ngừng kinh doanh"
                    }).ToList();
                dtg_danhsachsp.DataSource = re;
            }
            else
            {
                loaddataSP();
            }
        }

        //-----------------------------------Chức Năng Thêm Sản Phẩm--------------------------------------
        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Kiểm tra tính hợp lệ của loại sản phẩm
                    if (string.IsNullOrWhiteSpace(txt_loaisp.Text))
                    {
                        MessageBox.Show("Vui lòng nhập loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (txt_loaisp.Text.Length < 2 || txt_loaisp.Text.Length > 50)
                    {
                        MessageBox.Show("Loại sản phẩm phải có độ dài lớn hơn 1 ký tự và bé hơn 255 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!IsAllLetters(txt_loaisp.Text))
                    {
                        MessageBox.Show("Loại sản chỉ được chứa ký tự chữ cái", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Sanpham sanPham = new Sanpham();
                    sanPham.LoaiSanpham = txt_loaisp.Text;

                    sanPham_BLL.ThemSanPham(sanPham);
                    MessageBox.Show("Thêm sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddataSP();
                    loadataloaisp();
                    loaddataSPCT();
                    txt_loaisp.Clear();
                    cb_dang.Checked = true;
                    cb_ngung.Checked = false;
                    btn_xoa.Enabled = false;
                    btn_sua.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm sản phẩm không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-----------------------------------Chức Năng Sửa Sản Phẩm---------------------------------------
        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dtg_danhsachsp.SelectedRows.Count > 0)
                    {
                        int idSanPham = Convert.ToInt32(dtg_danhsachsp.SelectedRows[0].Cells["Masanpham"].Value);

                        string loaiSanPham = txt_loaisp.Text;
                        bool tinhTrang = cb_dang.Checked;
                        if (sanPham_BLL.SuaSanPham(idSanPham, loaiSanPham, tinhTrang))
                        {
                            MessageBox.Show("Sửa thông tin sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loaddataSP();
                            loadataloaisp();
                            txt_loaisp.Clear();
                            cb_dang.Checked = true;
                            cb_ngung.Checked = false;
                            btn_xoa.Enabled = false;
                            btn_sua.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin sản phẩm không thành công. Kiểm tra lại thông tin nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thông tin sản phẩm không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-----------------------------------Chức Năng Xóa Sản Phẩm---------------------------------------
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dtg_danhsachsp.SelectedRows.Count > 0)
                    {
                        int idSanPham = Convert.ToInt32(dtg_danhsachsp.SelectedRows[0].Cells["Masanpham"].Value);

                        if (sanPham_BLL.XoaSanPham(idSanPham))
                        {
                            MessageBox.Show("Xóa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loaddataSP();
                            loadataloaisp();
                            txt_loaisp.Clear();
                            cb_dang.Checked = true;
                            cb_ngung.Checked = false;
                            btn_xoa.Enabled = false;
                            btn_sua.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Xóa sản phẩm không thành công. Kiểm tra lại thông tin nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin sản phẩm không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-----------------------------------Chức Năng Làm Mới Sản Phẩm-----------------------------------
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_loaisp.Clear();
            cb_dang.Checked = true;
            cb_ngung.Checked = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        //=======================SANPHAMCT==================================
        public void loadataloaisp()
        {
            var danhSachSanPham = sanPham_BLL.LayDanhSachSanPham().Where(sp => sp.IsAlive == true).ToList();
            cbb_loaisp.DataSource = danhSachSanPham;
            cbb_loaisp.ValueMember = "IdSanpham";
            cbb_loaisp.DisplayMember = "LoaiSanpham";
        }

        public void loaddataSPCT()
        {
            var dataToShow = (from sp in sanPham_BLL.LayDanhSachSanPham()
                              join spct in sanPhamCT_BLL.LayDanhSachSanPhamCT()
                              on sp.IdSanpham equals spct.IdSanpham
                              where sp.IsAlive == true
                              orderby spct.IdSpct // Sắp xếp theo MaSPCT tăng dần
                              select new
                              {
                                  MaSPCT = spct.IdSpct,
                                  LoaiSP = sp.LoaiSanpham,
                                  Tensanpham = spct.TenSanpham,
                                  Size = spct.Size,
                                  MauSac = spct.MauSac,
                                  ChatLieu = spct.ChatLieu,
                                  SoLuong = spct.SoLuong,
                                  GiaBan = spct.GiaBan,
                                  GhiCHu = spct.GhiChu,
                                  HinhAnh = ByteArrayToImage(spct.HinhAnh)
                              }).ToList();

            dtg_dsctsanpham.DataSource = dataToShow;
            dtg_dsctsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtg_dsctsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtg_dsctsanpham.Rows.Count)
            {
                DataGridViewRow selectedRow = dtg_dsctsanpham.Rows[e.RowIndex];

                string size = selectedRow.Cells["Size"].Value.ToString();
                string mauSac = selectedRow.Cells["MauSac"].Value.ToString();
                string chatLieu = selectedRow.Cells["ChatLieu"].Value.ToString();
                double soLuong = Convert.ToDouble(selectedRow.Cells["SoLuong"].Value);
                double giaBan = Convert.ToDouble(selectedRow.Cells["GiaBan"].Value);
                string ghiChu = selectedRow.Cells["GhiCHu"].Value.ToString();
                string Tensp = selectedRow.Cells["TenSanPham"].Value.ToString();
                string loai = selectedRow.Cells["LoaiSP"].Value.ToString();
                Image hinhAnh = selectedRow.Cells["HinhAnh"].Value as Image;

                txt_size.Text = size;
                txt_mausac.Text = mauSac;
                txt_chatlieu.Text = chatLieu;
                txt_soluong.Text = soLuong.ToString();
                txt_gia.Text = giaBan.ToString();
                txt_mota.Text = ghiChu;
                txt_tenspct.Text = Tensp;
                cbb_loaisp.Text = loai;

                if (hinhAnh != null)
                {
                    pc_anh.Image = hinhAnh;
                }
                else
                {
                    pc_anh.Image = null;
                }

                btn_xoact.Enabled = true;
                btn_capnhatct.Enabled = true;
            }
        }

        //-----------------------------------Chức Năng Thêm Sản Phẩm Chi Tiết-----------------------------
        private void btn_themct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Kiểm tra tính hợp lệ của các trường thông tin
                    if (string.IsNullOrWhiteSpace(txt_size.Text) || string.IsNullOrWhiteSpace(txt_tenspct.Text) ||
                        string.IsNullOrWhiteSpace(txt_mausac.Text) || string.IsNullOrWhiteSpace(txt_chatlieu.Text) ||
                        string.IsNullOrWhiteSpace(txt_soluong.Text) || string.IsNullOrWhiteSpace(txt_gia.Text) ||
                        string.IsNullOrWhiteSpace(txt_mota.Text) || pc_anh.Image == null)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (txt_tenspct.Text.Length < 5 || txt_tenspct.Text.Length > 100)
                    {
                        MessageBox.Show("Tên sản phẩm chi tiết phải lớn hơn 5 ký tự hoặc bé hơn 255 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (txt_size.Text.Length > 10)
                    {
                        MessageBox.Show("Kích cỡ phải bé hơn 10 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (txt_mausac.Text.Length <= 1 || txt_mausac.Text.Length >= 255)
                    {
                        MessageBox.Show("Màu sắc phải lớn hơn 1 ký tự hoặc bé hơn 255 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (txt_chatlieu.Text.Length <= 5 || txt_chatlieu.Text.Length >= 255)
                    {
                        MessageBox.Show("Chất liệu phải lớn hơn 5 ký tự hoặc bé hơn 255 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Kiểm tra số lượng và giá bán là số và dương
                    if (!int.TryParse(txt_soluong.Text, out int soLuong) || soLuong <= 0 || soLuong > 50)
                    {
                        MessageBox.Show("Vui lòng nhập số lượng là một số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!double.TryParse(txt_gia.Text, out double giaBan) || giaBan < 10000 || giaBan >= 100000000)
                    {
                        MessageBox.Show("Vui lòng nhập giá bán là một số dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Chuyển hình ảnh từ PictureBox sang mảng byte
                    byte[] imageData = ImageToByteArray(pc_anh.Image);

                    // Tạo đối tượng Sanphamct mới
                    Sanphamct sanPhamCT = new Sanphamct
                    {
                        IdSanpham = Convert.ToInt32(cbb_loaisp.SelectedValue),
                        Size = txt_size.Text,
                        TenSanpham = txt_tenspct.Text,
                        MauSac = txt_mausac.Text,
                        ChatLieu = txt_chatlieu.Text,
                        SoLuong = soLuong,
                        GiaBan = giaBan,
                        GhiChu = txt_mota.Text,
                        HinhAnh = imageData
                    };

                    // Thêm sản phẩm chi tiết vào cơ sở dữ liệu
                    if (sanPhamCT_BLL.ThemSanPhamCT(sanPhamCT))
                    {
                        MessageBox.Show("Thêm cấu hình chi tiết sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddataSPCT();
                        txt_size.Clear();
                        txt_chatlieu.Clear();
                        txt_mausac.Clear();
                        txt_gia.Text = string.Empty;
                        txt_soluong.Text = string.Empty;
                        txt_mota.Clear();
                        btn_xoact.Enabled = false;
                        btn_capnhatct.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm cấu hình chi tiết sản phẩm không thành công. Kiểm tra lại thông tin nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm cấu hình chi tiết sản phẩm không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-----------------------------------Chức Năng Sửa Sản Phẩm Chi Tiết------------------------------
        private void btn_capnhatct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dtg_dsctsanpham.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dtg_dsctsanpham.SelectedRows[0];
                        int idSanPhamCT = Convert.ToInt32(selectedRow.Cells["MaSPCT"].Value);
                        string size = txt_size.Text;
                        string tensp = txt_tenspct.Text;
                        string mauSac = txt_mausac.Text;
                        string chatLieu = txt_chatlieu.Text;
                        int soLuong = Convert.ToInt32(txt_soluong.Text);
                        double giaBan = Convert.ToDouble(txt_gia.Text);
                        string ghiChu = txt_mota.Text;

                        byte[] imageData = null;

                        // Kiểm tra xem người dùng đã chọn ảnh mới hay không
                        if (pc_anh.Image != null)
                        {
                            // Nếu người dùng đã chọn ảnh mới, chuyển đổi ảnh thành mảng byte
                            imageData = ImageToByteArray(pc_anh.Image);
                        }
                        else
                        {
                            // Nếu người dùng không chọn ảnh mới, giữ nguyên ảnh cũ
                            // Lấy ảnh cũ từ dữ liệu hiện tại trong DataGridView
                            // Hãy thay thế "HinhAnh" bằng tên cột chứa dữ liệu hình ảnh trong DataGridView của bạn
                            imageData = (byte[])selectedRow.Cells["HinhAnh"].Value;
                        }

                        if (sanPhamCT_BLL.CapNhatSanPhamCT(idSanPhamCT, size, tensp, mauSac, chatLieu, soLuong, giaBan, ghiChu, imageData))
                        {
                            MessageBox.Show("Cập nhật thông tin sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            loaddataSPCT();
                            txt_size.Clear();
                            txt_chatlieu.Clear();
                            txt_mausac.Clear();
                            txt_gia.Text = string.Empty;
                            txt_soluong.Text = string.Empty;
                            txt_mota.Clear();
                            btn_xoact.Enabled = false;
                            btn_capnhatct.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin sản phẩm không thành công. Kiểm tra lại thông tin nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thông tin sản phẩm không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-----------------------------------Chức Năng Xóa Sản Phẩm Chi Tiết------------------------------
        private void btn_xoact_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dtg_dsctsanpham.SelectedRows.Count > 0)
                    {
                        int idsanphamct = Convert.ToInt32(dtg_dsctsanpham.SelectedRows[0].Cells["MaSPCT"].Value);

                        if (sanPhamCT_BLL.XoaSanPhamCT(idsanphamct))
                        {
                            MessageBox.Show("Xóa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            loaddataSPCT();
                            txt_size.Clear();
                            txt_chatlieu.Clear();
                            txt_mausac.Clear();
                            txt_gia.Text = string.Empty;
                            txt_soluong.Text = string.Empty;
                            txt_mota.Clear();
                            btn_xoact.Enabled = false;
                            btn_capnhatct.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Xóa sản phẩm không thành công. Kiểm tra lại thông tin nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thông tin sản phẩm không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-----------------------------------Chức Năng Làm Mới Sản Phẩm Chi Tiết--------------------------
        private void btn_lammoict_Click(object sender, EventArgs e)
        {
            txt_size.Clear();
            txt_chatlieu.Clear();
            txt_mausac.Clear();
            txt_gia.Text = string.Empty;
            txt_soluong.Text = string.Empty;
            txt_mota.Clear();
            btn_xoact.Enabled = false;
            btn_capnhatct.Enabled = false;
        }

        //=======================Xử lý hình ảnh===========================
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

        private void btn_addanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                try
                {
                    // Tạo một hình ảnh từ đường dẫn tập tin
                    Image selectedImage = Image.FromFile(imagePath);

                    // Hiển thị hình ảnh trong PictureBox
                    pc_anh.Image = selectedImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tải hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public byte[] ImageToByteArray(Image image)
        {
            if (image == null)
            {
                return new byte[0];
            }

            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    // Tạo một bản sao của hình ảnh để tránh gây ra lỗi GDI+
                    using (Bitmap bitmap = new Bitmap(image))
                    {
                        bitmap.Save(ms, ImageFormat.Jpeg);
                    }
                    return ms.ToArray();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi chuyển đổi hình ảnh thành mảng byte: " + ex.Message);
                    return new byte[0];
                }
            }
        }

        private void txt_timkiemctsp_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_timkiemctsp.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(keyword))
            {
                var re = (from sp in sanPham_BLL.LayDanhSachSanPham()
                          join spct in sanPhamCT_BLL.LayDanhSachSanPhamCT()
                          on sp.IdSanpham equals spct.IdSanpham
                          where sp.IdSanpham.ToString().Contains(keyword) || sp.LoaiSanpham.ToLower().Contains(keyword)
                          select new
                          {
                              MaSPCT = spct.IdSpct,
                              LoaiSP = sp.LoaiSanpham,
                              Tensanpham = spct.TenSanpham,
                              Size = spct.Size,
                              MauSac = spct.MauSac,
                              ChatLieu = spct.ChatLieu,
                              SoLuong = spct.SoLuong,
                              GiaBan = spct.GiaBan,
                              GhiCHu = spct.GhiChu,
                              HinhAnh = ByteArrayToImage(spct.HinhAnh)
                          }).ToList();
                dtg_dsctsanpham.DataSource = re;
            }
            else
            {
                loaddataSPCT();
            }
        }

        private void cb_dang_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_dang.Checked)
            {
                cb_ngung.Checked = false;
            }
        }

        private void cb_ngung_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ngung.Checked)
            {
                cb_dang.Checked = false;
            }
        }
    }
}