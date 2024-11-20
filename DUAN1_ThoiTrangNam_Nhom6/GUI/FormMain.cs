using DUAN1_ThoiTrangNam_Nhom6.BLL;
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
    public partial class FormMain : Form
    {

        //-----Tạo Các Lớp Đối Tượng-----
        FormSanPham sp = new FormSanPham();
        FormBanHang bh = new FormBanHang();
        FormHoaDon hd = new FormHoaDon();
        FormKhuyenMai km = new FormKhuyenMai();
        FormCaNhancs cn = new FormCaNhancs();
        FormNhanVien nv = new FormNhanVien();
        FormKhachHang kh = new FormKhachHang();
        FormThongKe tk = new FormThongKe();
       
        private bool isAdmin;

        public FormMain(bool isAdmin)
        {
            InitializeComponent();
            // Lưu trữ thông tin về vai trò của người dùng
            this.isAdmin = isAdmin;
            // Ẩn chức năng không liên quan nếu không phải là admin
            if (!isAdmin)
            {
                btn_khuyenmai.Enabled = false;
                btn_nhanvien.Enabled = false;         
                btn_thongke.Enabled = false;
                btn_sanpham.Enabled = false;
                // Thay đổi màu sắc của các nút
                btn_sanpham.BackColor = Color.DarkGray;
                btn_nhanvien.BackColor = Color.DarkGray;
                btn_khuyenmai.BackColor = Color.DarkGray; 
                btn_thongke.BackColor = Color.DarkGray;
            }
        }
        //-------------------------Chức Năng Sang Form Sản Phẩm---------------------
        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            sp.TopLevel = false;
            sp.Dock = DockStyle.Fill;
            panel_main.Controls.Add(sp);
            sp.Show();
            sp.loaddata();


        }
        //-------------------------Chức Năng Sang Form Bán Hàng---------------------
        private void btn_banhang_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            bh.TopLevel = false;
            bh.Dock = DockStyle.Fill;
            panel_main.Controls.Add(bh);
            bh.Show();
            bh.Loaddata();


        }
        //-------------------------Chức Năng Sang Form Hóa Đơn---------------------
        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            hd.TopLevel = false;
            hd.Dock = DockStyle.Fill;
            panel_main.Controls.Add(hd);
            hd.Show();
            hd.loaddata();

        }
        //-------------------------Chức Năng Sang Form Khuyến Mãi---------------------
        private void btn_khuyenmai_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            km.TopLevel = false;
            km.Dock = DockStyle.Fill;
            panel_main.Controls.Add(km);
            km.Show();
            km.loaddata();
        }
        //-------------------------Chức Năng Sang Form Cá Nhân---------------------
        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            cn.TopLevel = false;
            cn.Dock = DockStyle.Fill;
            panel_main.Controls.Add(cn);
            cn.Show();
        }
        //-------------------------Chức Năng Sang Form Nhân VIên---------------------
        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            nv.TopLevel = false;
            nv.Dock = DockStyle.Fill;
            panel_main.Controls.Add(nv);
            nv.Show();
            nv.Loaddata();
        }
        //-------------------------Chức Năng Sang Form Khách Hàng---------------------
        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            kh.TopLevel = false;
            kh.Dock = DockStyle.Fill;
            panel_main.Controls.Add(kh);
            kh.Show();

        }
        //-------------------------Chức Năng Đămg Xuát---------------------
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();

                FormLogin formDangNhap = new FormLogin();
                formDangNhap.ShowDialog();
            }
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            tk.TopLevel = false;
            tk.Dock = DockStyle.Fill;
            panel_main.Controls.Add(tk);
            tk.Show();
            tk.load();         
        }
    }
}
