namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_dangxuat = new Button();
            btn_thongke = new Button();
            btn_khachhang = new Button();
            btn_taikhoan = new Button();
            btn_nhanvien = new Button();
            btn_khuyenmai = new Button();
            btn_hoadon = new Button();
            btn_banhang = new Button();
            btn_sanpham = new Button();
            pictureBox1 = new PictureBox();
            panel_main = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_dangxuat);
            panel1.Controls.Add(btn_thongke);
            panel1.Controls.Add(btn_khachhang);
            panel1.Controls.Add(btn_taikhoan);
            panel1.Controls.Add(btn_nhanvien);
            panel1.Controls.Add(btn_khuyenmai);
            panel1.Controls.Add(btn_hoadon);
            panel1.Controls.Add(btn_banhang);
            panel1.Controls.Add(btn_sanpham);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 945);
            panel1.TabIndex = 2;
            // 
            // btn_dangxuat
            // 
            btn_dangxuat.BackColor = Color.FromArgb(157, 187, 216);
            btn_dangxuat.FlatStyle = FlatStyle.Flat;
            btn_dangxuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dangxuat.Location = new Point(21, 868);
            btn_dangxuat.Name = "btn_dangxuat";
            btn_dangxuat.Size = new Size(202, 52);
            btn_dangxuat.TabIndex = 1;
            btn_dangxuat.Text = "Đăng Xuất";
            btn_dangxuat.UseVisualStyleBackColor = false;
            btn_dangxuat.Click += btn_dangxuat_Click;
            // 
            // btn_thongke
            // 
            btn_thongke.BackColor = Color.FromArgb(157, 187, 216);
            btn_thongke.FlatStyle = FlatStyle.Flat;
            btn_thongke.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thongke.Location = new Point(21, 688);
            btn_thongke.Name = "btn_thongke";
            btn_thongke.Size = new Size(202, 52);
            btn_thongke.TabIndex = 1;
            btn_thongke.Text = "Thống Kê";
            btn_thongke.UseVisualStyleBackColor = false;
            btn_thongke.Click += btn_thongke_Click;
            // 
            // btn_khachhang
            // 
            btn_khachhang.BackColor = Color.FromArgb(157, 187, 216);
            btn_khachhang.FlatStyle = FlatStyle.Flat;
            btn_khachhang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_khachhang.Location = new Point(21, 537);
            btn_khachhang.Name = "btn_khachhang";
            btn_khachhang.Size = new Size(202, 52);
            btn_khachhang.TabIndex = 1;
            btn_khachhang.Text = "Khách Hàng";
            btn_khachhang.UseVisualStyleBackColor = false;
            btn_khachhang.Click += btn_khachhang_Click;
            // 
            // btn_taikhoan
            // 
            btn_taikhoan.BackColor = Color.FromArgb(157, 187, 216);
            btn_taikhoan.FlatStyle = FlatStyle.Flat;
            btn_taikhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_taikhoan.Location = new Point(21, 612);
            btn_taikhoan.Name = "btn_taikhoan";
            btn_taikhoan.Size = new Size(202, 52);
            btn_taikhoan.TabIndex = 1;
            btn_taikhoan.Text = "Cá Nhân";
            btn_taikhoan.UseVisualStyleBackColor = false;
            btn_taikhoan.Click += btn_taikhoan_Click;
            // 
            // btn_nhanvien
            // 
            btn_nhanvien.BackColor = Color.FromArgb(157, 187, 216);
            btn_nhanvien.FlatStyle = FlatStyle.Flat;
            btn_nhanvien.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nhanvien.Location = new Point(21, 464);
            btn_nhanvien.Name = "btn_nhanvien";
            btn_nhanvien.Size = new Size(202, 52);
            btn_nhanvien.TabIndex = 1;
            btn_nhanvien.Text = "Nhân Viên";
            btn_nhanvien.UseVisualStyleBackColor = false;
            btn_nhanvien.Click += btn_nhanvien_Click;
            // 
            // btn_khuyenmai
            // 
            btn_khuyenmai.BackColor = Color.FromArgb(157, 187, 216);
            btn_khuyenmai.FlatStyle = FlatStyle.Flat;
            btn_khuyenmai.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_khuyenmai.Location = new Point(21, 389);
            btn_khuyenmai.Name = "btn_khuyenmai";
            btn_khuyenmai.Size = new Size(202, 52);
            btn_khuyenmai.TabIndex = 1;
            btn_khuyenmai.Text = "Khuyến Mãi";
            btn_khuyenmai.UseVisualStyleBackColor = false;
            btn_khuyenmai.Click += btn_khuyenmai_Click;
            // 
            // btn_hoadon
            // 
            btn_hoadon.BackColor = Color.FromArgb(157, 187, 216);
            btn_hoadon.FlatStyle = FlatStyle.Flat;
            btn_hoadon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_hoadon.Location = new Point(21, 314);
            btn_hoadon.Name = "btn_hoadon";
            btn_hoadon.Size = new Size(202, 52);
            btn_hoadon.TabIndex = 1;
            btn_hoadon.Text = "Hóa Đơn";
            btn_hoadon.UseVisualStyleBackColor = false;
            btn_hoadon.Click += btn_hoadon_Click;
            // 
            // btn_banhang
            // 
            btn_banhang.BackColor = Color.FromArgb(157, 187, 216);
            btn_banhang.FlatStyle = FlatStyle.Flat;
            btn_banhang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_banhang.Location = new Point(21, 236);
            btn_banhang.Name = "btn_banhang";
            btn_banhang.Size = new Size(202, 52);
            btn_banhang.TabIndex = 1;
            btn_banhang.Text = "Bán Hàng";
            btn_banhang.UseVisualStyleBackColor = false;
            btn_banhang.Click += btn_banhang_Click;
            // 
            // btn_sanpham
            // 
            btn_sanpham.BackColor = Color.FromArgb(157, 187, 216);
            btn_sanpham.FlatStyle = FlatStyle.Flat;
            btn_sanpham.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sanpham.Location = new Point(21, 159);
            btn_sanpham.Name = "btn_sanpham";
            btn_sanpham.Size = new Size(202, 52);
            btn_sanpham.TabIndex = 1;
            btn_sanpham.Text = "Sản Phẩm";
            btn_sanpham.UseVisualStyleBackColor = false;
            btn_sanpham.Click += btn_sanpham_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(72, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_main
            // 
            panel_main.BackColor = Color.White;
            panel_main.BackgroundImageLayout = ImageLayout.Zoom;
            panel_main.Controls.Add(label1);
            panel_main.Controls.Add(pictureBox2);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(248, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1248, 945);
            panel_main.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(157, 187, 216);
            label1.Location = new Point(568, 94);
            label1.Name = "label1";
            label1.Size = new Size(469, 32);
            label1.TabIndex = 1;
            label1.Text = "Chào mừng bạn đến với SHOP-GO88";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(713, 419);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 945);
            Controls.Add(panel_main);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "FormMain";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_main.ResumeLayout(false);
            panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_dangxuat;
        private Button btn_thongke;
        private Button btn_khachhang;
        private Button btn_taikhoan;
        private Button btn_nhanvien;
        private Button btn_khuyenmai;
        private Button btn_hoadon;
        private Button btn_banhang;
        private Button btn_sanpham;
        private PictureBox pictureBox1;
        private Panel panel_main;
        private Label label1;
        private PictureBox pictureBox2;
    }
}