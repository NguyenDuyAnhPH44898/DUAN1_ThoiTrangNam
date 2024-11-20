namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    partial class FormKhachHang
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
            groupBox2 = new GroupBox();
            btn_lammoi = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            txt_sdt = new TextBox();
            label6 = new Label();
            txt_email = new TextBox();
            label5 = new Label();
            txt_diachi = new TextBox();
            label4 = new Label();
            txt_hoten = new TextBox();
            label3 = new Label();
            txt_timkiem = new TextBox();
            label2 = new Label();
            dgv_dskhachhang = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btn_timkiem = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_dskhachhang).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_lammoi);
            groupBox2.Controls.Add(btn_xoa);
            groupBox2.Controls.Add(btn_sua);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Controls.Add(txt_sdt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_email);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_diachi);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_hoten);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(1274, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 916);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // btn_lammoi
            // 
            btn_lammoi.FlatStyle = FlatStyle.Flat;
            btn_lammoi.ForeColor = Color.Navy;
            btn_lammoi.Location = new Point(247, 854);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(94, 29);
            btn_lammoi.TabIndex = 3;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.FlatStyle = FlatStyle.Flat;
            btn_xoa.ForeColor = Color.Navy;
            btn_xoa.Location = new Point(22, 854);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 3;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.FlatStyle = FlatStyle.Flat;
            btn_sua.ForeColor = Color.Navy;
            btn_sua.Location = new Point(247, 769);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 3;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.FlatStyle = FlatStyle.Flat;
            btn_them.ForeColor = Color.Navy;
            btn_them.Location = new Point(22, 769);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 3;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(20, 393);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(321, 27);
            txt_sdt.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 365);
            label6.Name = "label6";
            label6.Size = new Size(44, 18);
            label6.TabIndex = 0;
            label6.Text = "SDT:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(20, 280);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(321, 27);
            txt_email.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 252);
            label5.Name = "label5";
            label5.Size = new Size(54, 18);
            label5.TabIndex = 0;
            label5.Text = "Email:";
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(20, 175);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(321, 27);
            txt_diachi.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 147);
            label4.Name = "label4";
            label4.Size = new Size(63, 18);
            label4.TabIndex = 0;
            label4.Text = "Địa chỉ:";
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(20, 78);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(321, 27);
            txt_hoten.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 50);
            label3.Name = "label3";
            label3.Size = new Size(65, 18);
            label3.TabIndex = 0;
            label3.Text = "Họ tên:";
            // 
            // txt_timkiem
            // 
            txt_timkiem.BackColor = Color.FromArgb(157, 187, 216);
            txt_timkiem.BorderStyle = BorderStyle.None;
            txt_timkiem.Location = new Point(355, 31);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.PlaceholderText = "Tìm kiếm theo tên và mã";
            txt_timkiem.Size = new Size(501, 20);
            txt_timkiem.TabIndex = 8;
            txt_timkiem.TextChanged += txt_timkiem_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Gray;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(356, 57);
            label2.Name = "label2";
            label2.Size = new Size(500, 1);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // dgv_dskhachhang
            // 
            dgv_dskhachhang.BackgroundColor = Color.White;
            dgv_dskhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dskhachhang.GridColor = Color.DarkGray;
            dgv_dskhachhang.Location = new Point(6, 25);
            dgv_dskhachhang.Name = "dgv_dskhachhang";
            dgv_dskhachhang.RowHeadersWidth = 51;
            dgv_dskhachhang.RowTemplate.Height = 29;
            dgv_dskhachhang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_dskhachhang.Size = new Size(1216, 877);
            dgv_dskhachhang.TabIndex = 0;
            dgv_dskhachhang.CellClick += dgv_dskhachhang_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_dskhachhang);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1228, 916);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 5;
            label1.Text = "Quản lý nhân viên";
            // 
            // btn_timkiem
            // 
            btn_timkiem.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_timkiem.Location = new Point(874, 31);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(94, 29);
            btn_timkiem.TabIndex = 9;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 187, 216);
            ClientSize = new Size(1674, 992);
            Controls.Add(btn_timkiem);
            Controls.Add(groupBox2);
            Controls.Add(txt_timkiem);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKhachHang";
            Text = "FormKhachHang";
            Load += FormKhachHang_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_dskhachhang).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btn_lammoi;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private TextBox txt_sdt;
        private Label label6;
        private TextBox txt_email;
        private Label label5;
        private TextBox txt_diachi;
        private Label label4;
        private TextBox txt_hoten;
        private Label label3;
        private TextBox txt_timkiem;
        private Label label2;
        private DataGridView dgv_dskhachhang;
        private GroupBox groupBox1;
        private Label label1;
        private Button btn_timkiem;
    }
}