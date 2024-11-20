namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    partial class FormKhuyenMai
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
            dgv_dsKhuyemai = new DataGridView();
            groupBox2 = new GroupBox();
            dt_ngayketthuc = new DateTimePicker();
            txt_soluong = new TextBox();
            label11 = new Label();
            txt_phantram = new TextBox();
            label9 = new Label();
            label7 = new Label();
            txt_ngaybatdau = new TextBox();
            label5 = new Label();
            txt_makm = new TextBox();
            label2 = new Label();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_lammoi = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_dsKhuyemai).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 0;
            label1.Text = "Khuyến Mãi";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_dsKhuyemai);
            groupBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(742, 170);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(892, 643);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khuyến mãi";
            // 
            // dgv_dsKhuyemai
            // 
            dgv_dsKhuyemai.BackgroundColor = Color.White;
            dgv_dsKhuyemai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dsKhuyemai.Location = new Point(24, 33);
            dgv_dsKhuyemai.Name = "dgv_dsKhuyemai";
            dgv_dsKhuyemai.RowHeadersWidth = 51;
            dgv_dsKhuyemai.RowTemplate.Height = 29;
            dgv_dsKhuyemai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_dsKhuyemai.Size = new Size(858, 591);
            dgv_dsKhuyemai.TabIndex = 0;
            dgv_dsKhuyemai.CellClick += dgv_dsKhuyemai_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dt_ngayketthuc);
            groupBox2.Controls.Add(txt_soluong);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txt_phantram);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txt_ngaybatdau);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_makm);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(140, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 637);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // dt_ngayketthuc
            // 
            dt_ngayketthuc.CustomFormat = "yyyy/MM/dd";
            dt_ngayketthuc.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dt_ngayketthuc.Format = DateTimePickerFormat.Custom;
            dt_ngayketthuc.Location = new Point(17, 280);
            dt_ngayketthuc.Name = "dt_ngayketthuc";
            dt_ngayketthuc.Size = new Size(322, 30);
            dt_ngayketthuc.TabIndex = 4;
            // 
            // txt_soluong
            // 
            txt_soluong.BorderStyle = BorderStyle.None;
            txt_soluong.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_soluong.Location = new Point(17, 480);
            txt_soluong.Multiline = true;
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(322, 31);
            txt_soluong.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(13, 457);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 1;
            label11.Text = "Số lượng:";
            // 
            // txt_phantram
            // 
            txt_phantram.BorderStyle = BorderStyle.None;
            txt_phantram.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phantram.Location = new Point(17, 373);
            txt_phantram.Multiline = true;
            txt_phantram.Name = "txt_phantram";
            txt_phantram.Size = new Size(322, 31);
            txt_phantram.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(13, 346);
            label9.Name = "label9";
            label9.Size = new Size(187, 20);
            label9.TabIndex = 1;
            label9.Text = "Phần trăm giảm giá:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 255);
            label7.Name = "label7";
            label7.Size = new Size(138, 20);
            label7.TabIndex = 1;
            label7.Text = "Ngày kết thúc:";
            // 
            // txt_ngaybatdau
            // 
            txt_ngaybatdau.BorderStyle = BorderStyle.None;
            txt_ngaybatdau.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ngaybatdau.Location = new Point(17, 163);
            txt_ngaybatdau.Multiline = true;
            txt_ngaybatdau.Name = "txt_ngaybatdau";
            txt_ngaybatdau.Size = new Size(322, 31);
            txt_ngaybatdau.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 136);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 1;
            label5.Text = "Ngày bắt đầu:";
            // 
            // txt_makm
            // 
            txt_makm.BorderStyle = BorderStyle.None;
            txt_makm.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_makm.Location = new Point(17, 60);
            txt_makm.Multiline = true;
            txt_makm.Name = "txt_makm";
            txt_makm.Size = new Size(322, 31);
            txt_makm.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 33);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã KM:";
            // 
            // btn_them
            // 
            btn_them.BackColor = Color.FromArgb(192, 255, 255);
            btn_them.FlatStyle = FlatStyle.Flat;
            btn_them.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_them.ForeColor = Color.Black;
            btn_them.Location = new Point(527, 182);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(181, 67);
            btn_them.TabIndex = 6;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = false;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.BackColor = Color.FromArgb(192, 192, 255);
            btn_sua.FlatStyle = FlatStyle.Flat;
            btn_sua.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.ForeColor = Color.Black;
            btn_sua.Location = new Point(527, 373);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(181, 67);
            btn_sua.TabIndex = 6;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.BackColor = Color.FromArgb(255, 192, 192);
            btn_xoa.FlatStyle = FlatStyle.Flat;
            btn_xoa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xoa.ForeColor = Color.Black;
            btn_xoa.Location = new Point(527, 543);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(181, 67);
            btn_xoa.TabIndex = 6;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = false;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_lammoi
            // 
            btn_lammoi.BackColor = Color.FromArgb(255, 255, 192);
            btn_lammoi.FlatStyle = FlatStyle.Flat;
            btn_lammoi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lammoi.ForeColor = Color.Black;
            btn_lammoi.Location = new Point(527, 740);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(181, 67);
            btn_lammoi.TabIndex = 6;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = false;
            btn_lammoi.Click += btn_lammoi_Click;
            // 
            // FormKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 187, 216);
            ClientSize = new Size(1674, 992);
            Controls.Add(btn_lammoi);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKhuyenMai";
            Text = "FormKhuyenMai";
            Load += FormKhuyenMai_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_dsKhuyemai).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgv_dsKhuyemai;
        private GroupBox groupBox2;
        private TextBox txt_soluong;
        private Label label11;
        private TextBox txt_phantram;
        private Label label9;
        private Label label7;
        private TextBox txt_ngaybatdau;
        private Label label5;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_lammoi;
        private TextBox txt_makm;
        private Label label2;
        private DateTimePicker dt_ngayketthuc;
    }
}