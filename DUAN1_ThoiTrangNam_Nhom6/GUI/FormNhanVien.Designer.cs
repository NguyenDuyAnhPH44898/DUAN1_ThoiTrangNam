namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    partial class FormNhanVien
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgv_dsNhanVien = new DataGridView();
            label2 = new Label();
            txt_timkiem = new TextBox();
            label3 = new Label();
            txt_hoten = new TextBox();
            label4 = new Label();
            txt_diachi = new TextBox();
            label5 = new Label();
            txt_email = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_sdt = new TextBox();
            label9 = new Label();
            txt_tendangnhap = new TextBox();
            txt_matkhau = new TextBox();
            rd_nam = new RadioButton();
            rd_nu = new RadioButton();
            btn_them = new Button();
            btn_sua = new Button();
            btn_lammoi = new Button();
            groupBox2 = new GroupBox();
            cbb_chucvu = new ComboBox();
            label10 = new Label();
            btn_timkiem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_dsNhanVien).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Quản lý nhân viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_dsNhanVien);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(15, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1228, 916);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách ";
            // 
            // dgv_dsNhanVien
            // 
            dgv_dsNhanVien.BackgroundColor = Color.White;
            dgv_dsNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dsNhanVien.GridColor = Color.DarkGray;
            dgv_dsNhanVien.Location = new Point(6, 33);
            dgv_dsNhanVien.Name = "dgv_dsNhanVien";
            dgv_dsNhanVien.RowHeadersWidth = 51;
            dgv_dsNhanVien.RowTemplate.Height = 29;
            dgv_dsNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_dsNhanVien.Size = new Size(1216, 877);
            dgv_dsNhanVien.TabIndex = 0;
            dgv_dsNhanVien.CellClick += dgv_dsNhanVien_CellClick;
            // 
            // label2
            // 
            label2.BackColor = Color.Gray;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(359, 60);
            label2.Name = "label2";
            label2.Size = new Size(500, 1);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // txt_timkiem
            // 
            txt_timkiem.BackColor = Color.FromArgb(157, 187, 216);
            txt_timkiem.BorderStyle = BorderStyle.None;
            txt_timkiem.Location = new Point(358, 34);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.PlaceholderText = "Tìm kiếm theo tên và mã";
            txt_timkiem.Size = new Size(501, 20);
            txt_timkiem.TabIndex = 3;
            txt_timkiem.TextChanged += txt_timkiem_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 50);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 0;
            label3.Text = "Họ tên:";
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(20, 78);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(321, 27);
            txt_hoten.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 136);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 0;
            label4.Text = "Địa chỉ:";
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(20, 164);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(321, 27);
            txt_diachi.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 224);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 0;
            label5.Text = "Email:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(20, 252);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(321, 27);
            txt_email.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 327);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 0;
            label6.Text = "SDT:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(21, 426);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 0;
            label7.Text = "Giới tính:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 490);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 0;
            label8.Text = "Tên đang nhâp:";
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(20, 355);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(321, 27);
            txt_sdt.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(16, 579);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 0;
            label9.Text = "Mật khẩu:";
            // 
            // txt_tendangnhap
            // 
            txt_tendangnhap.Location = new Point(18, 518);
            txt_tendangnhap.Name = "txt_tendangnhap";
            txt_tendangnhap.Size = new Size(321, 27);
            txt_tendangnhap.TabIndex = 1;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(18, 607);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(321, 27);
            txt_matkhau.TabIndex = 1;
            // 
            // rd_nam
            // 
            rd_nam.AutoSize = true;
            rd_nam.Location = new Point(133, 423);
            rd_nam.Name = "rd_nam";
            rd_nam.Size = new Size(62, 24);
            rd_nam.TabIndex = 2;
            rd_nam.TabStop = true;
            rd_nam.Text = "Nam";
            rd_nam.UseVisualStyleBackColor = true;
            // 
            // rd_nu
            // 
            rd_nu.AutoSize = true;
            rd_nu.Location = new Point(217, 423);
            rd_nu.Name = "rd_nu";
            rd_nu.Size = new Size(50, 24);
            rd_nu.TabIndex = 2;
            rd_nu.TabStop = true;
            rd_nu.Text = "Nữ";
            rd_nu.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.BackColor = Color.FromArgb(192, 255, 255);
            btn_them.FlatStyle = FlatStyle.Flat;
            btn_them.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_them.ForeColor = Color.Black;
            btn_them.Location = new Point(22, 751);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(140, 47);
            btn_them.TabIndex = 3;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.BackColor = Color.FromArgb(192, 255, 255);
            btn_sua.FlatStyle = FlatStyle.Flat;
            btn_sua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.ForeColor = Color.Black;
            btn_sua.Location = new Point(199, 751);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(140, 47);
            btn_sua.TabIndex = 3;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_lammoi
            // 
            btn_lammoi.BackColor = Color.FromArgb(192, 255, 255);
            btn_lammoi.FlatStyle = FlatStyle.Flat;
            btn_lammoi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lammoi.ForeColor = Color.Black;
            btn_lammoi.Location = new Point(103, 849);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(140, 47);
            btn_lammoi.TabIndex = 3;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = false;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbb_chucvu);
            groupBox2.Controls.Add(btn_lammoi);
            groupBox2.Controls.Add(btn_sua);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Controls.Add(rd_nu);
            groupBox2.Controls.Add(rd_nam);
            groupBox2.Controls.Add(txt_matkhau);
            groupBox2.Controls.Add(txt_tendangnhap);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txt_sdt);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_email);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_diachi);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_hoten);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(1274, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 916);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // cbb_chucvu
            // 
            cbb_chucvu.FormattingEnabled = true;
            cbb_chucvu.Location = new Point(114, 677);
            cbb_chucvu.Name = "cbb_chucvu";
            cbb_chucvu.Size = new Size(225, 28);
            cbb_chucvu.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(16, 687);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 0;
            label10.Text = "Chúc vụ:";
            // 
            // btn_timkiem
            // 
            btn_timkiem.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_timkiem.Location = new Point(878, 25);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(140, 36);
            btn_timkiem.TabIndex = 4;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 187, 216);
            ClientSize = new Size(1674, 992);
            Controls.Add(btn_timkiem);
            Controls.Add(txt_timkiem);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNhanVien";
            Text = "FormNhanVien";
            Load += FormNhanVien_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_dsNhanVien).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgv_dsNhanVien;
        private Label label2;
        private TextBox txt_timkiem;
        private Label label3;
        private TextBox txt_hoten;
        private Label label4;
        private TextBox txt_diachi;
        private Label label5;
        private TextBox txt_email;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_sdt;
        private Label label9;
        private TextBox txt_tendangnhap;
        private TextBox txt_matkhau;
        private RadioButton rd_nam;
        private RadioButton rd_nu;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_lammoi;
        private GroupBox groupBox2;
        private Label label10;
        private Button btn_timkiem;
        private ComboBox cbb_chucvu;
    }
}