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

namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    public partial class FormKhachHang : Form
    {
        DB_DUAN1_Nhom6Context db = new DB_DUAN1_Nhom6Context();
        private KhachHang_BLL khachHang_BLL;
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
           loaddata();

        }

        public void loaddata()
        {
            khachHang_BLL = new KhachHang_BLL();
            loadKhachHang();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        public void loadKhachHang()
        {

            var danhsach = khachHang_BLL.LayDanhSachKH();

            var show = danhsach.Select(kh => new
            {

                MaKhachHang = kh.IdKh,
                HoVaTen = kh.HoTen,
                DiaChi = kh.DiaChi,
                Email = kh.Email,
                SoDienThoai = kh.Sdt
            }).ToList();
            dgv_dskhachhang.DataSource = show;
            dgv_dskhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_dskhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txt_hoten.Text = dgv_dskhachhang.Rows[d].Cells[1].Value.ToString();
            txt_diachi.Text = dgv_dskhachhang.Rows[d].Cells[2].Value.ToString();
            txt_email.Text = dgv_dskhachhang.Rows[d].Cells[3].Value.ToString();
            txt_sdt.Text = dgv_dskhachhang.Rows[d].Cells[4].Value.ToString();

            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    
                    if (!Validate())
                    {
                        return;
                    }

                    KhachHang khachHang = new KhachHang();

                    khachHang.HoTen = txt_hoten.Text;
                    khachHang.DiaChi = txt_diachi.Text;
                    khachHang.Email = txt_email.Text;
                    khachHang.Sdt = txt_sdt.Text;

                    khachHang_BLL.themkh(khachHang);
                    MessageBox.Show("Thêm khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadKhachHang();
                    txt_hoten.Clear();
                    txt_diachi.Clear();
                    txt_email.Clear();
                    txt_sdt.Clear();
                    btn_sua.Enabled = false;
                    btn_xoa.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm khách hàng không thành công" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool Validate()
        {
            if (string.IsNullOrWhiteSpace(txt_hoten.Text) ||
                string.IsNullOrWhiteSpace(txt_diachi.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_sdt.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            if (!ValidateEmail(txt_email.Text))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            if (!ValidateSDT(txt_sdt.Text))
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

        private bool ValidateSDT(string phoneNumber)
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
                    if (dgv_dskhachhang.SelectedRows.Count > 0)
                    {
                        int idkh = Convert.ToInt32(dgv_dskhachhang.SelectedRows[0].Cells["MaKhachHang"].Value);


                        string hoTen = txt_hoten.Text;
                        string diaChi = txt_diachi.Text;
                        string email = txt_email.Text;
                        string sdt = txt_sdt.Text;
                        if (khachHang_BLL.suakh(idkh, hoTen, diaChi, email, sdt))
                        {
                            MessageBox.Show("Sửa thông tin sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadKhachHang();
                            txt_hoten.Clear();
                            txt_diachi.Clear();
                            txt_email.Clear();
                            txt_sdt.Clear();
                            btn_sua.Enabled = false;
                            btn_xoa.Enabled = false;
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
                    MessageBox.Show("Thêm khách hàng khong thành công" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dgv_dskhachhang.SelectedCells.Count > 0)
                    {
                        int idkh = Convert.ToInt32(dgv_dskhachhang.SelectedRows[0].Cells["MaKhachHang"].Value);
 
                        if (khachHang_BLL.xoakh(idkh))
                        {
                            MessageBox.Show("Xóa thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadKhachHang();
                            txt_hoten.Clear();
                            txt_diachi.Clear();
                            txt_email.Clear();
                            txt_sdt.Clear();
                            btn_sua.Enabled = false;
                            btn_xoa.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("xóa thông tin khách hàng không thành công. Kiểm tra lại thông tin nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một khách hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("xóa khách hàng không thành công" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txt_timkiem.Text.Trim();
                if (keyword != "")
                {
                    var searchResult = khachHang_BLL.TimKiemKH(keyword);

                    if (searchResult.Any())
                    {
                        var show = searchResult.Select(kh => new
                        {
                            MaKhachHang = kh.IdKh,
                            HoVaTen = kh.HoTen,
                            DiaChi = kh.DiaChi,
                            Email = kh.Email,
                            SoDienThoai = kh.Sdt
                        }).ToList();

                        dgv_dskhachhang.DataSource = show;
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

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_timkiem.Text.Trim()))
            {

                loadKhachHang();
            }
        }
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_hoten.Clear();
            txt_diachi.Clear();
            txt_email.Clear();
            txt_sdt.Clear();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }
    }
}
