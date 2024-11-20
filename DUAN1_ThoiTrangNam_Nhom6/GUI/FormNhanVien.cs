using DUAN1_ThoiTrangNam_Nhom6.BLL;
using DUAN1_ThoiTrangNam_Nhom6.DAL;
using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    public partial class FormNhanVien : Form
    {

        DB_DUAN1_Nhom6Context db = new DB_DUAN1_Nhom6Context();
        private NhanVien_BLL nhanVien_BLL;
        private KTK_BLL kTK_BLL;
        public FormNhanVien()
        {

            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        public void Loaddata()
        {
            nhanVien_BLL = new NhanVien_BLL();
            kTK_BLL = new KTK_BLL();
            loadNguoiDung();
            loadktk();

           
            btn_sua.Enabled = false;
        }

        public void loadNguoiDung()
        {
            var dataToShow = (from nd in nhanVien_BLL.laydanhsachND()
                              join ktk in kTK_BLL.laydanhsachktk()
                              on nd.IdKtk equals ktk.IdKtk
                              orderby nd.IdNd 
                              select new
                              {
                                  MaNguoiDung = nd.IdNd,
                                  HoTen = nd.HoTen,
                                  DiaChi = nd.DiaChi,
                                  Email = nd.Email,
                                  SDT = nd.Sdt,
                                  GioiTinh = nd.GioiTinh,
                                  TenDangNhap = nd.TenDangNhap,
                                  MatKhau = "",
                                  ChucVu = ktk.TenKtk,
                              }).ToList();           
            dgv_dsNhanVien.DataSource = dataToShow;
            dgv_dsNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
        }

        public void loadktk()
        {
            var ktk = kTK_BLL.laydanhsachktk();
            cbb_chucvu.DataSource = ktk;
            cbb_chucvu.ValueMember = "IdKtk";
            cbb_chucvu.DisplayMember = "TenKtk";
        }

        private void dgv_dsNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_dsNhanVien.Rows.Count)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = dgv_dsNhanVien.Rows[rowIndex];

                txt_hoten.Text = selectedRow.Cells["HoTen"].Value.ToString();
                txt_diachi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txt_email.Text = selectedRow.Cells["Email"].Value.ToString();
                txt_sdt.Text = selectedRow.Cells["SDT"].Value.ToString();
                if (selectedRow.Cells["GioiTinh"].Value != null)
                {
                    if (selectedRow.Cells["GioiTinh"].Value.ToString() == "Nam")
                    {
                        rd_nam.Checked = true;
                    }
                    else if (selectedRow.Cells["GioiTinh"].Value.ToString() == "Nữ")
                    {
                        rd_nu.Checked = true;
                    }
                }
                txt_tendangnhap.Text = selectedRow.Cells["TenDangNhap"].Value.ToString();
                txt_matkhau.Text = selectedRow.Cells["MatKhau"].Value.ToString();

               
                string loai = selectedRow.Cells["Chucvu"].Value.ToString();
                cbb_chucvu.Text = loai;
               
                btn_sua.Enabled = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Kiểm tra hợp lệ của dữ liệu đầu vào
                    if (!Validate())
                    {
                        return;
                    }

                    NguoiDung nguoiDung = new NguoiDung();

                    nguoiDung.HoTen = txt_hoten.Text;
                    nguoiDung.Email = txt_email.Text;
                    nguoiDung.DiaChi = txt_diachi.Text;
                    nguoiDung.Sdt = txt_sdt.Text;
                    nguoiDung.GioiTinh = rd_nam.Checked ? "Nam" : "Nữ";
                    nguoiDung.TenDangNhap = txt_tendangnhap.Text;
                    nguoiDung.MatKhau = txt_matkhau.Text;

                    nguoiDung.IdKtk = Convert.ToInt32(cbb_chucvu.SelectedValue);

                    nhanVien_BLL.ThemND(nguoiDung);
                    MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadNguoiDung();
                    txt_hoten.Text = "";
                    txt_diachi.Text = "";
                    txt_email.Text = "";
                    txt_sdt.Text = "";
                    rd_nam.Checked = false;
                    rd_nu.Checked = false;
                    txt_tendangnhap.Text = "";
                    txt_matkhau.Text = "";
                    cbb_chucvu.SelectedIndex = -1;
                   
                    btn_sua.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm nhân viên không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(txt_hoten.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_diachi.Text) ||
                string.IsNullOrWhiteSpace(txt_sdt.Text) ||
                string.IsNullOrWhiteSpace(txt_tendangnhap.Text) ||
                string.IsNullOrWhiteSpace(txt_matkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra định dạng email
            if (!ValidateEmail(txt_email.Text))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra định dạng số điện thoại
            if (!validateSDT(txt_sdt.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool validateSDT(string phoneNumber)
        {
            return Regex.Match(phoneNumber, @"^0[0-9]{9}$").Success;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dgv_dsNhanVien.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dgv_dsNhanVien.SelectedRows[0];
                        int idNguoiDung = Convert.ToInt32(selectedRow.Cells["MaNguoiDung"].Value);

                        string hoTen = txt_hoten.Text;
                        string diaChi = txt_diachi.Text;
                        string email = txt_email.Text;
                        string sdt = txt_sdt.Text;
                        string gioiTinh = rd_nam.Checked ? "Nam" : "Nữ";
                        string tenDangNhap = txt_tendangnhap.Text;
                        string matKhau = txt_matkhau.Text;
                        int idKtk = Convert.ToInt32(cbb_chucvu.SelectedValue);

                        NguoiDung nguoiDung = new NguoiDung
                        {
                            IdNd = idNguoiDung,
                            HoTen = hoTen,
                            DiaChi = diaChi,
                            Email = email,
                            Sdt = sdt,
                            GioiTinh = gioiTinh,
                            TenDangNhap = tenDangNhap,
                            MatKhau = matKhau,
                            IdKtk = idKtk
                        };

                        if (nhanVien_BLL.SuaND(idNguoiDung, hoTen, diaChi, email, sdt, gioiTinh, tenDangNhap, matKhau, idKtk))
                        {
                            MessageBox.Show("Cập nhật thông tin người dùng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadNguoiDung();
                            txt_hoten.Text = "";
                            txt_diachi.Text = "";
                            txt_email.Text = "";
                            txt_sdt.Text = "";
                            rd_nam.Checked = false;
                            rd_nu.Checked = false;
                            txt_tendangnhap.Text = "";
                            txt_matkhau.Text = "";
                            cbb_chucvu.SelectedIndex = -1;
                           
                            btn_sua.Enabled = false;

                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin người dùng không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một người dùng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thông tin người dùng không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_hoten.Text = "";
            txt_diachi.Text = "";
            txt_email.Text = "";
            txt_sdt.Text = "";
            rd_nam.Checked = false;
            rd_nu.Checked = false;
            txt_tendangnhap.Text = "";
            txt_matkhau.Text = "";
            cbb_chucvu.SelectedIndex = -1;        
            btn_sua.Enabled = false;  

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_timkiem.Text.Trim()))
            {
               
                loadNguoiDung();
                loadktk();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_timkiem.Text.Trim(); 
                if (keyword != "") 
                {                 
                    var searchResult = (from nd in nhanVien_BLL.laydanhsachND()
                                        join ktk in kTK_BLL.laydanhsachktk()
                                        on nd.IdKtk equals ktk.IdKtk
                                        where nd.HoTen.ToLower().Contains(keyword) || nd.Email.Contains(keyword) || nd.Sdt.Contains(keyword) || nd.TenDangNhap.ToLower().Contains(keyword) || nd.MatKhau.Contains(keyword) || ktk.TenKtk.ToLower().Contains(keyword)
                                        orderby nd.IdNd
                                        select new
                                        {
                                            MaNguoiDung = nd.IdNd,
                                            HoTen = nd.HoTen,
                                            DiaChi = nd.DiaChi,
                                            Email = nd.Email,
                                            SDT = nd.Sdt,
                                            GioiTinh = nd.GioiTinh,
                                            TenDangNhap = nd.TenDangNhap,
                                            MatKhau = "",
                                            ChucVu = ktk.TenKtk,
                                        }).ToList();

                   
                    if (searchResult.Any())
                    {
                        dgv_dsNhanVien.DataSource = searchResult;
                    }
                    else
                    {
                       
                        MessageBox.Show("Không tìm thấy kết quả nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                   
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
