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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    public partial class FormCaNhancs : Form
    {

        DB_DUAN1_Nhom6Context db = new DB_DUAN1_Nhom6Context();
        private NguoiDung_BLL nguoiDung_BLL;
        public FormCaNhancs()
        {
            InitializeComponent();
            txt_ma.ReadOnly = true;
        }

        private void FormCaNhancs_Load(object sender, EventArgs e)
        {
            nguoiDung_BLL = NguoiDung_BLL.Instance;
            LoadNguoiDung();
        }


        public void LoadNguoiDung()
        {
            var danhSachNguoiDung = nguoiDung_BLL.LayThongTinNguoiDung();


            if (danhSachNguoiDung.Count > 0)
            {

                var nguoiDung = danhSachNguoiDung[0];

                txt_ma.Text = nguoiDung.IdNd.ToString();
                txt_ten.Text = nguoiDung.HoTen;
                rd_nam.Checked = nguoiDung.GioiTinh == "Nam";
                rd_nu.Checked = nguoiDung.GioiTinh == "Nữ";
                txt_diachi.Text = nguoiDung.DiaChi;
                txt_email.Text = nguoiDung.Email;
                txt_sdt.Text = nguoiDung.Sdt;
                txt_tendn.Text = nguoiDung.TenDangNhap;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng.");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

           
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var danhSachNguoiDung = nguoiDung_BLL.LayThongTinNguoiDung();
               
                var nguoiDung = danhSachNguoiDung[0];

               
                nguoiDung.HoTen = txt_ten.Text;
                nguoiDung.GioiTinh = rd_nam.Checked ? "Nam" : "Nữ";
                nguoiDung.DiaChi = txt_diachi.Text;
                nguoiDung.Email = txt_email.Text;
                nguoiDung.Sdt = txt_sdt.Text;
                nguoiDung.TenDangNhap = txt_tendn.Text;

                
                bool re = nguoiDung_BLL.CapNhatThongTinNguoiDung(nguoiDung);

                if (re)
                {
                    MessageBox.Show("Cập nhật thông tin người dùng thành công.");
                  
                    LoadNguoiDung();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin người dùng thất bại. Vui lòng thử lại.");
                }
            }


        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đổi không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               
                var danhSachNguoiDung = nguoiDung_BLL.LayThongTinNguoiDung();

                
                if (danhSachNguoiDung.Count > 0)
                {
                    
                    var nguoiDung = danhSachNguoiDung[0];

                   
                    if (txt_mkmoi.Text == txt_nhaplai.Text && txt_matkhaudoi.Text == nguoiDung.MatKhau)
                    {
                       
                        nguoiDung.MatKhau = txt_mkmoi.Text;

                       
                        bool re = nguoiDung_BLL.CapNhatThongTinNguoiDung(nguoiDung);

                        if (re)
                        {
                            MessageBox.Show("Cập nhật mật khẩu thành công.");
                          
                            LoadNguoiDung();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật mật khẩu thất bại. Vui lòng thử lại.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận mật khẩu mới không khớp hoặc mật khẩu cũ không đúng. Vui lòng nhập lại.");
                       
                        txt_mkmoi.Clear();
                        txt_nhaplai.Clear();
                        txt_matkhaudoi.Clear();
                       
                        txt_matkhaudoi.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Không có người dùng để đổi mật khẩu.");
                }
            }
        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked)
            {
                txt_mkmoi.PasswordChar = '\0';
                txt_nhaplai.PasswordChar= '\0';
            }
            else
            {
                txt_mkmoi.PasswordChar = '*';
                txt_nhaplai.PasswordChar = '*';
            }
        }
    }
}
