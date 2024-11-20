using DUAN1_ThoiTrangNam_Nhom6.BLL;
using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using DUAN1_ThoiTrangNam_Nhom6.GUI;

namespace DUAN1_ThoiTrangNam_Nhom6
{
    public partial class FormLogin : Form
    {

        private bool isAdmin;
        public FormLogin()
        {
            InitializeComponent();

        }
        //-------------------------------------Chức Năng Đăng Nhập----------------------------------------------
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_taikhoan.Text;
            string matKhau = txt_matkhau.Text;

            NguoiDung nguoiDung = NguoiDung_BLL.Instance.XacThuc(tenDangNhap, matKhau);

            if (nguoiDung != null)
            {
                isAdmin = (nguoiDung.IdKtk == 1); // Cập nhật thông tin về vai trò của người dùng

                string loaiNguoiDung = isAdmin ? "Admin" : "Nhân viên";
                MessageBox.Show($"{loaiNguoiDung} {nguoiDung.TenDangNhap} đang đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Khởi tạo form chính và truyền thông tin về vai trò của người dùng
                FormMain mainForm = new FormMain(isAdmin);
                mainForm.Show();

                //Sau khi vào form main sẽ ẩn đi form login
                this.Hide();

            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-------------------------------------Chức Năng Hiện Thị Mật Khẩu----------------------------------------------
        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked)
            {

                txt_matkhau.PasswordChar = '\0';
            }
            else
            {

                txt_matkhau.PasswordChar = '*';
            }
        }
        //-------------------------------------Chức Năng Thoát Form Đăng Nhập----------------------------------------------
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đóng ứng dụng khi nhấn nút "Thoát"
                Application.Exit();

            }
        }

        private void txt_taikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                DangNhap();
            }
        }

        private void txt_matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DangNhap();
            }
        }

        private void DangNhap()
        {
            string tenDangNhap = txt_taikhoan.Text;
            string matKhau = txt_matkhau.Text;

            NguoiDung nguoiDung = NguoiDung_BLL.Instance.XacThuc(tenDangNhap, matKhau);

            if (nguoiDung != null)
            {
                isAdmin = (nguoiDung.IdKtk == 1); // Cập nhật thông tin về vai trò của người dùng

                string loaiNguoiDung = isAdmin ? "Admin" : "Nhân viên";
                MessageBox.Show($"{loaiNguoiDung} {nguoiDung.TenDangNhap} đang đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Khởi tạo form chính và truyền thông tin về vai trò của người dùng
                FormMain mainForm = new FormMain(isAdmin);
                mainForm.Show();

                //Sau khi vào form main sẽ ẩn đi form login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
