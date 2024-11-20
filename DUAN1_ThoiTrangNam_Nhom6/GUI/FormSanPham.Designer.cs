namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    partial class FormSanPham
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
            tc_sanpham = new TabControl();
            tabPage1 = new TabPage();
            txt_loaisp = new TextBox();
            cb_ngung = new CheckBox();
            cb_dang = new CheckBox();
            btn_lammoi = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            label11 = new Label();
            label3 = new Label();
            txt_timkiemsp = new TextBox();
            label1 = new Label();
            dtg_danhsachsp = new DataGridView();
            tabPage2 = new TabPage();
            txt_tenspct = new TextBox();
            cbb_loaisp = new ComboBox();
            txt_mota = new TextBox();
            pc_anh = new PictureBox();
            btn_addanh = new Button();
            btn_capnhatct = new Button();
            btn_lammoict = new Button();
            btn_xoact = new Button();
            btn_themct = new Button();
            txt_soluong = new TextBox();
            txt_gia = new TextBox();
            txt_mausac = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txt_chatlieu = new TextBox();
            label8 = new Label();
            txt_size = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label13 = new Label();
            label12 = new Label();
            label5 = new Label();
            txt_timkiemctsp = new TextBox();
            label4 = new Label();
            dtg_dsctsanpham = new DataGridView();
            tc_sanpham.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_danhsachsp).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_anh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_dsctsanpham).BeginInit();
            SuspendLayout();
            // 
            // tc_sanpham
            // 
            tc_sanpham.Controls.Add(tabPage1);
            tc_sanpham.Controls.Add(tabPage2);
            tc_sanpham.Location = new Point(14, 14);
            tc_sanpham.Name = "tc_sanpham";
            tc_sanpham.SelectedIndex = 0;
            tc_sanpham.Size = new Size(1646, 965);
            tc_sanpham.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(txt_loaisp);
            tabPage1.Controls.Add(cb_ngung);
            tabPage1.Controls.Add(cb_dang);
            tabPage1.Controls.Add(btn_lammoi);
            tabPage1.Controls.Add(btn_xoa);
            tabPage1.Controls.Add(btn_sua);
            tabPage1.Controls.Add(btn_them);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txt_timkiemsp);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dtg_danhsachsp);
            tabPage1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1638, 932);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sản Phẩm";
            // 
            // txt_loaisp
            // 
            txt_loaisp.Location = new Point(1269, 124);
            txt_loaisp.Name = "txt_loaisp";
            txt_loaisp.Size = new Size(335, 26);
            txt_loaisp.TabIndex = 9;
            // 
            // cb_ngung
            // 
            cb_ngung.AutoSize = true;
            cb_ngung.Location = new Point(1440, 227);
            cb_ngung.Name = "cb_ngung";
            cb_ngung.Size = new Size(164, 22);
            cb_ngung.TabIndex = 8;
            cb_ngung.Text = "Ngừng kinh doanh";
            cb_ngung.UseVisualStyleBackColor = true;
            cb_ngung.CheckedChanged += cb_ngung_CheckedChanged;
            // 
            // cb_dang
            // 
            cb_dang.AutoSize = true;
            cb_dang.Location = new Point(1269, 227);
            cb_dang.Name = "cb_dang";
            cb_dang.Size = new Size(154, 22);
            cb_dang.TabIndex = 8;
            cb_dang.Text = "Đang kinh doanh";
            cb_dang.UseVisualStyleBackColor = true;
            cb_dang.CheckedChanged += cb_dang_CheckedChanged;
            // 
            // btn_lammoi
            // 
            btn_lammoi.FlatStyle = FlatStyle.Flat;
            btn_lammoi.ForeColor = Color.Black;
            btn_lammoi.Location = new Point(1535, 276);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(94, 29);
            btn_lammoi.TabIndex = 7;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.FlatStyle = FlatStyle.Flat;
            btn_xoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xoa.ForeColor = Color.Black;
            btn_xoa.Location = new Point(1515, 346);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(114, 47);
            btn_xoa.TabIndex = 7;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.FlatStyle = FlatStyle.Flat;
            btn_sua.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.ForeColor = Color.Black;
            btn_sua.Location = new Point(1379, 347);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(114, 47);
            btn_sua.TabIndex = 7;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_them
            // 
            btn_them.FlatStyle = FlatStyle.Flat;
            btn_them.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_them.ForeColor = Color.Black;
            btn_them.Location = new Point(1242, 346);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(114, 47);
            btn_them.TabIndex = 7;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1269, 178);
            label11.Name = "label11";
            label11.Size = new Size(106, 20);
            label11.TabIndex = 4;
            label11.Text = "Tình trạng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1269, 91);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Loại SP:";
            // 
            // txt_timkiemsp
            // 
            txt_timkiemsp.BackColor = Color.White;
            txt_timkiemsp.BorderStyle = BorderStyle.None;
            txt_timkiemsp.Location = new Point(285, 45);
            txt_timkiemsp.Name = "txt_timkiemsp";
            txt_timkiemsp.PlaceholderText = "Tìm kiếm theo tên hoặc mã";
            txt_timkiemsp.Size = new Size(716, 19);
            txt_timkiemsp.TabIndex = 1;
            txt_timkiemsp.TextChanged += txt_timkiemsp_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.DimGray;
            label1.Location = new Point(286, 67);
            label1.Name = "label1";
            label1.Size = new Size(680, 1);
            label1.TabIndex = 2;
            // 
            // dtg_danhsachsp
            // 
            dtg_danhsachsp.BackgroundColor = Color.White;
            dtg_danhsachsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_danhsachsp.Location = new Point(6, 91);
            dtg_danhsachsp.Name = "dtg_danhsachsp";
            dtg_danhsachsp.RowHeadersWidth = 51;
            dtg_danhsachsp.RowTemplate.Height = 29;
            dtg_danhsachsp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_danhsachsp.Size = new Size(1212, 836);
            dtg_danhsachsp.TabIndex = 0;
            dtg_danhsachsp.CellClick += dtg_danhsachsp_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(txt_tenspct);
            tabPage2.Controls.Add(cbb_loaisp);
            tabPage2.Controls.Add(txt_mota);
            tabPage2.Controls.Add(pc_anh);
            tabPage2.Controls.Add(btn_addanh);
            tabPage2.Controls.Add(btn_capnhatct);
            tabPage2.Controls.Add(btn_lammoict);
            tabPage2.Controls.Add(btn_xoact);
            tabPage2.Controls.Add(btn_themct);
            tabPage2.Controls.Add(txt_soluong);
            tabPage2.Controls.Add(txt_gia);
            tabPage2.Controls.Add(txt_mausac);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txt_chatlieu);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txt_size);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txt_timkiemctsp);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dtg_dsctsanpham);
            tabPage2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1638, 932);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Chi tiết sản phẩm";
            // 
            // txt_tenspct
            // 
            txt_tenspct.Location = new Point(1096, 43);
            txt_tenspct.Name = "txt_tenspct";
            txt_tenspct.Size = new Size(208, 26);
            txt_tenspct.TabIndex = 9;
            // 
            // cbb_loaisp
            // 
            cbb_loaisp.FormattingEnabled = true;
            cbb_loaisp.Location = new Point(900, 43);
            cbb_loaisp.Name = "cbb_loaisp";
            cbb_loaisp.Size = new Size(151, 26);
            cbb_loaisp.TabIndex = 8;
            // 
            // txt_mota
            // 
            txt_mota.Location = new Point(1336, 335);
            txt_mota.Multiline = true;
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(272, 104);
            txt_mota.TabIndex = 7;
            // 
            // pc_anh
            // 
            pc_anh.BackColor = Color.FromArgb(224, 224, 224);
            pc_anh.Location = new Point(1385, 460);
            pc_anh.Name = "pc_anh";
            pc_anh.Size = new Size(179, 236);
            pc_anh.SizeMode = PictureBoxSizeMode.Zoom;
            pc_anh.TabIndex = 6;
            pc_anh.TabStop = false;
            // 
            // btn_addanh
            // 
            btn_addanh.FlatStyle = FlatStyle.Flat;
            btn_addanh.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addanh.ForeColor = Color.Black;
            btn_addanh.Location = new Point(1427, 715);
            btn_addanh.Name = "btn_addanh";
            btn_addanh.Size = new Size(94, 29);
            btn_addanh.TabIndex = 5;
            btn_addanh.Text = "Ảnh";
            btn_addanh.UseVisualStyleBackColor = true;
            btn_addanh.Click += btn_addanh_Click;
            // 
            // btn_capnhatct
            // 
            btn_capnhatct.FlatStyle = FlatStyle.Flat;
            btn_capnhatct.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_capnhatct.ForeColor = Color.Black;
            btn_capnhatct.Location = new Point(1497, 772);
            btn_capnhatct.Name = "btn_capnhatct";
            btn_capnhatct.Size = new Size(122, 46);
            btn_capnhatct.TabIndex = 5;
            btn_capnhatct.Text = "Cập nhật";
            btn_capnhatct.UseVisualStyleBackColor = true;
            btn_capnhatct.Click += btn_capnhatct_Click;
            // 
            // btn_lammoict
            // 
            btn_lammoict.FlatStyle = FlatStyle.Flat;
            btn_lammoict.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lammoict.ForeColor = Color.Black;
            btn_lammoict.Location = new Point(1497, 865);
            btn_lammoict.Name = "btn_lammoict";
            btn_lammoict.Size = new Size(122, 46);
            btn_lammoict.TabIndex = 5;
            btn_lammoict.Text = "Làm mới";
            btn_lammoict.UseVisualStyleBackColor = true;
            btn_lammoict.Click += btn_lammoict_Click;
            // 
            // btn_xoact
            // 
            btn_xoact.FlatStyle = FlatStyle.Flat;
            btn_xoact.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xoact.ForeColor = Color.Black;
            btn_xoact.Location = new Point(1324, 865);
            btn_xoact.Name = "btn_xoact";
            btn_xoact.Size = new Size(122, 46);
            btn_xoact.TabIndex = 5;
            btn_xoact.Text = "Xóa";
            btn_xoact.UseVisualStyleBackColor = true;
            btn_xoact.Click += btn_xoact_Click;
            // 
            // btn_themct
            // 
            btn_themct.FlatStyle = FlatStyle.Flat;
            btn_themct.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_themct.ForeColor = Color.Black;
            btn_themct.Location = new Point(1324, 772);
            btn_themct.Name = "btn_themct";
            btn_themct.Size = new Size(122, 46);
            btn_themct.TabIndex = 5;
            btn_themct.Text = "Thêm";
            btn_themct.UseVisualStyleBackColor = true;
            btn_themct.Click += btn_themct_Click;
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(1483, 43);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(125, 26);
            txt_soluong.TabIndex = 4;
            // 
            // txt_gia
            // 
            txt_gia.Location = new Point(1336, 251);
            txt_gia.Name = "txt_gia";
            txt_gia.Size = new Size(272, 26);
            txt_gia.TabIndex = 4;
            // 
            // txt_mausac
            // 
            txt_mausac.Location = new Point(1336, 178);
            txt_mausac.Name = "txt_mausac";
            txt_mausac.Size = new Size(272, 26);
            txt_mausac.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(1398, 303);
            label10.Name = "label10";
            label10.Size = new Size(147, 20);
            label10.TabIndex = 3;
            label10.Text = "Mô tả sản phẩm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1332, 228);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 3;
            label9.Text = "Giá Bán:";
            // 
            // txt_chatlieu
            // 
            txt_chatlieu.Location = new Point(1336, 108);
            txt_chatlieu.Name = "txt_chatlieu";
            txt_chatlieu.Size = new Size(272, 26);
            txt_chatlieu.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1334, 154);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 3;
            label8.Text = "Màu sắc:";
            // 
            // txt_size
            // 
            txt_size.Location = new Point(1336, 43);
            txt_size.Name = "txt_size";
            txt_size.Size = new Size(125, 26);
            txt_size.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1334, 82);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 3;
            label7.Text = "Chất liệu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1486, 16);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 3;
            label6.Text = "Số lượng:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(1096, 20);
            label13.Name = "label13";
            label13.Size = new Size(76, 20);
            label13.TabIndex = 3;
            label13.Text = "Tên SP:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(900, 20);
            label12.Name = "label12";
            label12.Size = new Size(79, 20);
            label12.TabIndex = 3;
            label12.Text = "Loại SP:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1339, 16);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 3;
            label5.Text = "Size:";
            // 
            // txt_timkiemctsp
            // 
            txt_timkiemctsp.BackColor = Color.White;
            txt_timkiemctsp.BorderStyle = BorderStyle.None;
            txt_timkiemctsp.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_timkiemctsp.Location = new Point(148, 62);
            txt_timkiemctsp.Name = "txt_timkiemctsp";
            txt_timkiemctsp.PlaceholderText = "Tìm kiếm theo tên hoặc mã";
            txt_timkiemctsp.Size = new Size(700, 19);
            txt_timkiemctsp.TabIndex = 2;
            txt_timkiemctsp.TextChanged += txt_timkiemctsp_TextChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.DimGray;
            label4.Location = new Point(148, 90);
            label4.Name = "label4";
            label4.Size = new Size(700, 1);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // dtg_dsctsanpham
            // 
            dtg_dsctsanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_dsctsanpham.BackgroundColor = Color.White;
            dtg_dsctsanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_dsctsanpham.Location = new Point(34, 113);
            dtg_dsctsanpham.Name = "dtg_dsctsanpham";
            dtg_dsctsanpham.RowHeadersWidth = 51;
            dtg_dsctsanpham.RowTemplate.Height = 29;
            dtg_dsctsanpham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_dsctsanpham.Size = new Size(1243, 798);
            dtg_dsctsanpham.TabIndex = 0;
            dtg_dsctsanpham.CellClick += dtg_dsctsanpham_CellClick;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 187, 216);
            ClientSize = new Size(1674, 992);
            Controls.Add(tc_sanpham);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSanPham";
            Load += FormSanPham_Load;
            tc_sanpham.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_danhsachsp).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_anh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_dsctsanpham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tc_sanpham;
        private TabPage tabPage1;
        private CheckBox cb_ngung;
        private CheckBox cb_dang;
        private Button btn_lammoi;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private Label label11;
        private Label label3;
        private TextBox txt_timkiemsp;
        private Label label1;
        private DataGridView dtg_danhsachsp;
        private TabPage tabPage2;
        private TextBox txt_tenspct;
        private ComboBox cbb_loaisp;
        private TextBox txt_mota;
        private PictureBox pc_anh;
        private Button btn_addanh;
        private Button btn_capnhatct;
        private Button btn_lammoict;
        private Button btn_xoact;
        private Button btn_themct;
        private TextBox txt_soluong;
        private TextBox txt_gia;
        private TextBox txt_mausac;
        private Label label10;
        private Label label9;
        private TextBox txt_chatlieu;
        private Label label8;
        private TextBox txt_size;
        private Label label7;
        private Label label6;
        private Label label13;
        private Label label12;
        private Label label5;
        private TextBox txt_timkiemctsp;
        private Label label4;
        private DataGridView dtg_dsctsanpham;
        private TextBox txt_loaisp;
    }
}