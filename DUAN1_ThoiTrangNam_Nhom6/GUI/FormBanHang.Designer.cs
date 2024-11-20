namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    partial class FormBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            btn_thanhtoan = new Button();
            dgv_hoadoncho = new DataGridView();
            groupBox3 = new GroupBox();
            dtg_danhsachSP = new DataGridView();
            btn_huyhoadon = new Button();
            dtg_sanphammua = new DataGridView();
            btn_suasl = new Button();
            txt_tongtien = new TextBox();
            btn_lammoi = new Button();
            btn_taohoadonban = new Button();
            cb_khuyenmai = new CheckBox();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            cbb_makm = new ComboBox();
            cbb_nguoidung = new ComboBox();
            btn_xoa = new Button();
            btn_luu = new Button();
            groupBox2 = new GroupBox();
            txt_soluongban = new TextBox();
            label3 = new Label();
            txt_hoadoncho = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            cbb_khachhang = new ComboBox();
            label6 = new Label();
            txt_tkhdcho = new TextBox();
            txt_tienkhachdua = new TextBox();
            label7 = new Label();
            label10 = new Label();
            txt_tienthua = new TextBox();
            label11 = new Label();
            txt_mahoadon = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pdoc_inBienLai = new System.Drawing.Printing.PrintDocument();
            ppd_inBienLai = new PrintPreviewDialog();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_hoadoncho).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_danhsachSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_sanphammua).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.BackColor = Color.FromArgb(192, 255, 255);
            btn_thanhtoan.FlatStyle = FlatStyle.Flat;
            btn_thanhtoan.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thanhtoan.ForeColor = Color.Navy;
            btn_thanhtoan.Location = new Point(1339, 916);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(242, 63);
            btn_thanhtoan.TabIndex = 65;
            btn_thanhtoan.Text = "Thanh Toán";
            btn_thanhtoan.UseVisualStyleBackColor = false;
            btn_thanhtoan.Click += btn_thanhtoan_Click;
            // 
            // dgv_hoadoncho
            // 
            dgv_hoadoncho.BackgroundColor = Color.White;
            dgv_hoadoncho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_hoadoncho.Location = new Point(13, 27);
            dgv_hoadoncho.Name = "dgv_hoadoncho";
            dgv_hoadoncho.RowHeadersWidth = 51;
            dgv_hoadoncho.RowTemplate.Height = 29;
            dgv_hoadoncho.Size = new Size(1604, 195);
            dgv_hoadoncho.TabIndex = 0;
            dgv_hoadoncho.CellClick += dgv_hoadoncho_CellClick;
            dgv_hoadoncho.CellDoubleClick += dgv_hoadoncho_CellDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_hoadoncho);
            groupBox3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(27, 66);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1623, 236);
            groupBox3.TabIndex = 64;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa đơn chờ";
            // 
            // dtg_danhsachSP
            // 
            dtg_danhsachSP.BackgroundColor = Color.White;
            dtg_danhsachSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_danhsachSP.Location = new Point(13, 25);
            dtg_danhsachSP.Name = "dtg_danhsachSP";
            dtg_danhsachSP.RowHeadersWidth = 51;
            dtg_danhsachSP.RowTemplate.Height = 29;
            dtg_danhsachSP.Size = new Size(1166, 271);
            dtg_danhsachSP.TabIndex = 0;
            dtg_danhsachSP.CellClick += dtg_danhsachSP_CellClick;
            // 
            // btn_huyhoadon
            // 
            btn_huyhoadon.BackColor = Color.FromArgb(192, 255, 255);
            btn_huyhoadon.FlatStyle = FlatStyle.Flat;
            btn_huyhoadon.ForeColor = Color.Navy;
            btn_huyhoadon.Location = new Point(961, 681);
            btn_huyhoadon.Name = "btn_huyhoadon";
            btn_huyhoadon.Size = new Size(157, 35);
            btn_huyhoadon.TabIndex = 66;
            btn_huyhoadon.Text = "Hủy hóa đơn chờ";
            btn_huyhoadon.UseVisualStyleBackColor = false;
            btn_huyhoadon.Click += btn_huyhoadon_Click;
            // 
            // dtg_sanphammua
            // 
            dtg_sanphammua.BackgroundColor = Color.White;
            dtg_sanphammua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_sanphammua.Location = new Point(13, 23);
            dtg_sanphammua.Name = "dtg_sanphammua";
            dtg_sanphammua.RowHeadersWidth = 51;
            dtg_sanphammua.RowTemplate.Height = 29;
            dtg_sanphammua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_sanphammua.Size = new Size(1166, 230);
            dtg_sanphammua.TabIndex = 0;
            dtg_sanphammua.CellValueChanged += dtg_sanphammua_CellValueChanged;
            // 
            // btn_suasl
            // 
            btn_suasl.BackColor = Color.FromArgb(192, 255, 255);
            btn_suasl.FlatStyle = FlatStyle.Flat;
            btn_suasl.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_suasl.ForeColor = Color.Navy;
            btn_suasl.Location = new Point(546, 682);
            btn_suasl.Name = "btn_suasl";
            btn_suasl.Size = new Size(94, 35);
            btn_suasl.TabIndex = 63;
            btn_suasl.Text = "sửa SL";
            btn_suasl.UseVisualStyleBackColor = false;
            btn_suasl.Click += btn_suasl_Click;
            // 
            // txt_tongtien
            // 
            txt_tongtien.BackColor = Color.FromArgb(157, 187, 216);
            txt_tongtien.BorderStyle = BorderStyle.None;
            txt_tongtien.Location = new Point(112, 306);
            txt_tongtien.Name = "txt_tongtien";
            txt_tongtien.Size = new Size(180, 20);
            txt_tongtien.TabIndex = 62;
            // 
            // btn_lammoi
            // 
            btn_lammoi.BackColor = Color.FromArgb(192, 255, 255);
            btn_lammoi.FlatStyle = FlatStyle.Flat;
            btn_lammoi.ForeColor = Color.Navy;
            btn_lammoi.Location = new Point(134, 512);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(132, 34);
            btn_lammoi.TabIndex = 61;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = false;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // btn_taohoadonban
            // 
            btn_taohoadonban.BackColor = Color.FromArgb(192, 255, 255);
            btn_taohoadonban.FlatStyle = FlatStyle.Flat;
            btn_taohoadonban.ForeColor = Color.Navy;
            btn_taohoadonban.Location = new Point(776, 681);
            btn_taohoadonban.Name = "btn_taohoadonban";
            btn_taohoadonban.Size = new Size(162, 35);
            btn_taohoadonban.TabIndex = 60;
            btn_taohoadonban.Text = "Tạo hóa đơn chờ";
            btn_taohoadonban.UseVisualStyleBackColor = false;
            btn_taohoadonban.Click += btn_taohoadonban_Click;
            // 
            // cb_khuyenmai
            // 
            cb_khuyenmai.AutoSize = true;
            cb_khuyenmai.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cb_khuyenmai.Location = new Point(6, 168);
            cb_khuyenmai.Name = "cb_khuyenmai";
            cb_khuyenmai.Size = new Size(162, 20);
            cb_khuyenmai.TabIndex = 59;
            cb_khuyenmai.Text = "Áp dụng khuyễn mãi";
            cb_khuyenmai.UseVisualStyleBackColor = true;
            cb_khuyenmai.CheckedChanged += cb_khuyenmai_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(8, 305);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 58;
            label9.Text = "Tổng tiền:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 239);
            label8.Name = "label8";
            label8.Size = new Size(142, 20);
            label8.TabIndex = 57;
            label8.Text = "Nhân viên bán:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 105);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 56;
            label5.Text = "Khách hàng:";
            // 
            // cbb_makm
            // 
            cbb_makm.BackColor = Color.FromArgb(157, 187, 216);
            cbb_makm.FlatStyle = FlatStyle.Flat;
            cbb_makm.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_makm.FormattingEnabled = true;
            cbb_makm.Location = new Point(182, 162);
            cbb_makm.Name = "cbb_makm";
            cbb_makm.Size = new Size(203, 26);
            cbb_makm.TabIndex = 53;
            cbb_makm.SelectedIndexChanged += cbb_makm_SelectedIndexChanged;
            // 
            // cbb_nguoidung
            // 
            cbb_nguoidung.FlatStyle = FlatStyle.Flat;
            cbb_nguoidung.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_nguoidung.FormattingEnabled = true;
            cbb_nguoidung.Location = new Point(160, 235);
            cbb_nguoidung.Name = "cbb_nguoidung";
            cbb_nguoidung.Size = new Size(225, 28);
            cbb_nguoidung.TabIndex = 55;
            // 
            // btn_xoa
            // 
            btn_xoa.BackColor = Color.FromArgb(192, 255, 255);
            btn_xoa.FlatStyle = FlatStyle.Flat;
            btn_xoa.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xoa.ForeColor = Color.Navy;
            btn_xoa.Location = new Point(661, 682);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 35);
            btn_xoa.TabIndex = 52;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = false;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_luu
            // 
            btn_luu.BackColor = Color.FromArgb(192, 255, 255);
            btn_luu.FlatStyle = FlatStyle.Flat;
            btn_luu.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_luu.ForeColor = Color.Navy;
            btn_luu.Location = new Point(429, 682);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(94, 35);
            btn_luu.TabIndex = 51;
            btn_luu.Text = "Lưu tạm";
            btn_luu.UseVisualStyleBackColor = false;
            btn_luu.Click += btn_luu_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtg_sanphammua);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(27, 726);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1199, 271);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sản phẩm mua";
            // 
            // txt_soluongban
            // 
            txt_soluongban.BackColor = Color.FromArgb(157, 187, 216);
            txt_soluongban.BorderStyle = BorderStyle.None;
            txt_soluongban.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_soluongban.Location = new Point(150, 682);
            txt_soluongban.Name = "txt_soluongban";
            txt_soluongban.PlaceholderText = "Số lượng sản phẩm";
            txt_soluongban.Size = new Size(247, 19);
            txt_soluongban.TabIndex = 50;
            // 
            // label3
            // 
            label3.BackColor = Color.DimGray;
            label3.Location = new Point(150, 710);
            label3.Name = "label3";
            label3.Size = new Size(247, 1);
            label3.TabIndex = 45;
            label3.Text = "label4";
            // 
            // txt_hoadoncho
            // 
            txt_hoadoncho.BackColor = Color.FromArgb(157, 187, 216);
            txt_hoadoncho.BorderStyle = BorderStyle.None;
            txt_hoadoncho.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_hoadoncho.Location = new Point(315, 317);
            txt_hoadoncho.Name = "txt_hoadoncho";
            txt_hoadoncho.PlaceholderText = "Tìm kiếm theo tên hoặc mã";
            txt_hoadoncho.Size = new Size(700, 19);
            txt_hoadoncho.TabIndex = 49;
            txt_hoadoncho.TextChanged += txt_tksanpham_TextChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.DimGray;
            label4.Location = new Point(315, 345);
            label4.Name = "label4";
            label4.Size = new Size(700, 1);
            label4.TabIndex = 44;
            label4.Text = "label4";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_danhsachSP);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(27, 353);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1199, 309);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(198, 28);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 22);
            label1.TabIndex = 40;
            label1.Text = "Bán Hàng";
            // 
            // cbb_khachhang
            // 
            cbb_khachhang.BackColor = Color.FromArgb(157, 187, 216);
            cbb_khachhang.FlatStyle = FlatStyle.Flat;
            cbb_khachhang.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_khachhang.FormattingEnabled = true;
            cbb_khachhang.Location = new Point(134, 102);
            cbb_khachhang.Name = "cbb_khachhang";
            cbb_khachhang.Size = new Size(195, 26);
            cbb_khachhang.TabIndex = 54;
            // 
            // label6
            // 
            label6.BackColor = Color.DimGray;
            label6.Location = new Point(315, 61);
            label6.Name = "label6";
            label6.Size = new Size(700, 1);
            label6.TabIndex = 44;
            label6.Text = "label4";
            // 
            // txt_tkhdcho
            // 
            txt_tkhdcho.BackColor = Color.FromArgb(157, 187, 216);
            txt_tkhdcho.BorderStyle = BorderStyle.None;
            txt_tkhdcho.ForeColor = Color.Black;
            txt_tkhdcho.Location = new Point(314, 34);
            txt_tkhdcho.Name = "txt_tkhdcho";
            txt_tkhdcho.PlaceholderText = "Tìm kiếm theo tên hoặc mã";
            txt_tkhdcho.Size = new Size(701, 20);
            txt_tkhdcho.TabIndex = 67;
            txt_tkhdcho.TextChanged += txt_tkhdcho_TextChanged;
            // 
            // txt_tienkhachdua
            // 
            txt_tienkhachdua.BackColor = Color.FromArgb(157, 187, 216);
            txt_tienkhachdua.BorderStyle = BorderStyle.FixedSingle;
            txt_tienkhachdua.ForeColor = Color.Black;
            txt_tienkhachdua.Location = new Point(162, 382);
            txt_tienkhachdua.Name = "txt_tienkhachdua";
            txt_tienkhachdua.Size = new Size(225, 27);
            txt_tienkhachdua.TabIndex = 68;
            txt_tienkhachdua.TextChanged += txt_tienkhachdua_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(8, 385);
            label7.Name = "label7";
            label7.Size = new Size(148, 20);
            label7.TabIndex = 58;
            label7.Text = "Tiền khách đưa:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(13, 455);
            label10.Name = "label10";
            label10.Size = new Size(109, 20);
            label10.TabIndex = 58;
            label10.Text = "Tiền trả lại:";
            // 
            // txt_tienthua
            // 
            txt_tienthua.BackColor = Color.FromArgb(157, 187, 216);
            txt_tienthua.BorderStyle = BorderStyle.None;
            txt_tienthua.Location = new Point(134, 455);
            txt_tienthua.Name = "txt_tienthua";
            txt_tienthua.Size = new Size(180, 20);
            txt_tienthua.TabIndex = 68;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 47);
            label11.Name = "label11";
            label11.Size = new Size(116, 20);
            label11.TabIndex = 56;
            label11.Text = "Mã hóa đơn:";
            // 
            // txt_mahoadon
            // 
            txt_mahoadon.BackColor = Color.FromArgb(157, 187, 216);
            txt_mahoadon.Location = new Point(134, 40);
            txt_mahoadon.Name = "txt_mahoadon";
            txt_mahoadon.Size = new Size(77, 27);
            txt_mahoadon.TabIndex = 69;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // pdoc_inBienLai
            // 
            pdoc_inBienLai.PrintPage += pdoc_inBienLai_PrintPage_1;
            // 
            // ppd_inBienLai
            // 
            ppd_inBienLai.AutoScrollMargin = new Size(0, 0);
            ppd_inBienLai.AutoScrollMinSize = new Size(0, 0);
            ppd_inBienLai.ClientSize = new Size(400, 300);
            ppd_inBienLai.Enabled = true;
            ppd_inBienLai.Icon = (Icon)resources.GetObject("ppd_inBienLai.Icon");
            ppd_inBienLai.Name = "printPreviewDialog1";
            ppd_inBienLai.Visible = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(txt_tienthua);
            groupBox4.Controls.Add(txt_mahoadon);
            groupBox4.Controls.Add(txt_tienkhachdua);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(cbb_khachhang);
            groupBox4.Controls.Add(btn_lammoi);
            groupBox4.Controls.Add(cb_khuyenmai);
            groupBox4.Controls.Add(cbb_makm);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(cbb_nguoidung);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(txt_tongtien);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(1252, 324);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(398, 571);
            groupBox4.TabIndex = 70;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin";
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 187, 216);
            ClientSize = new Size(1674, 1031);
            Controls.Add(groupBox4);
            Controls.Add(txt_tkhdcho);
            Controls.Add(btn_thanhtoan);
            Controls.Add(groupBox3);
            Controls.Add(btn_huyhoadon);
            Controls.Add(btn_suasl);
            Controls.Add(btn_taohoadonban);
            Controls.Add(btn_xoa);
            Controls.Add(btn_luu);
            Controls.Add(groupBox2);
            Controls.Add(txt_soluongban);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(txt_hoadoncho);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBanHang";
            Text = "FormBanHang";
            Load += FormBanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_hoadoncho).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_danhsachSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_sanphammua).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_thanhtoan;
        private DataGridView dgv_hoadoncho;
        private GroupBox groupBox3;
        private DataGridView dtg_danhsachSP;
        private Button btn_huyhoadon;
        private DataGridView dtg_sanphammua;
        private Button btn_suasl;
        private TextBox txt_tongtien;
        private Button btn_lammoi;
        private Button btn_taohoadonban;
        private CheckBox cb_khuyenmai;
        private Label label9;
        private Label label8;
        private Label label5;
        private ComboBox cbb_makm;
        private ComboBox cbb_nguoidung;
        private Button btn_xoa;
        private Button btn_luu;
        private GroupBox groupBox2;
        private TextBox txt_soluongban;
        private Label label3;
        private TextBox txt_hoadoncho;
        private Label label4;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox cbb_khachhang;
        private Label label6;
        private TextBox txt_tkhdcho;
        private TextBox txt_tienkhachdua;
        private Label label7;
        private Label label10;
        private TextBox txt_tienthua;
        private Label label11;
        private TextBox txt_mahoadon;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Drawing.Printing.PrintDocument pdoc_inBienLai;
  
        private PrintPreviewDialog ppd_inBienLai;
        private GroupBox groupBox4;
    }
}