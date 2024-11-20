namespace DUAN1_ThoiTrangNam_Nhom6
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_thoat = new Button();
            cb_showpass = new CheckBox();
            btn_dangnhap = new Button();
            label2 = new Label();
            label1 = new Label();
            txt_matkhau = new TextBox();
            txt_taikhoan = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_thoat);
            panel1.Controls.Add(cb_showpass);
            panel1.Controls.Add(btn_dangnhap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_matkhau);
            panel1.Controls.Add(txt_taikhoan);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(561, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 427);
            panel1.TabIndex = 2;
            // 
            // btn_thoat
            // 
            btn_thoat.BackColor = Color.FromArgb(157, 187, 216);
            btn_thoat.FlatStyle = FlatStyle.Flat;
            btn_thoat.Location = new Point(184, 380);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(103, 36);
            btn_thoat.TabIndex = 5;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = false;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // cb_showpass
            // 
            cb_showpass.AutoSize = true;
            cb_showpass.Location = new Point(31, 310);
            cb_showpass.Name = "cb_showpass";
            cb_showpass.Size = new Size(83, 24);
            cb_showpass.TabIndex = 1;
            cb_showpass.Text = "Hiển thị";
            cb_showpass.UseVisualStyleBackColor = true;
            cb_showpass.CheckedChanged += cb_showpass_CheckedChanged;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.BackColor = Color.FromArgb(157, 187, 216);
            btn_dangnhap.FlatStyle = FlatStyle.Flat;
            btn_dangnhap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dangnhap.Location = new Point(29, 380);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(117, 35);
            btn_dangnhap.TabIndex = 3;
            btn_dangnhap.Text = "Đăng Nhập";
            btn_dangnhap.UseVisualStyleBackColor = false;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 217);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 138);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 2;
            label1.Text = "Tài Khoản";
            // 
            // txt_matkhau
            // 
            txt_matkhau.BackColor = Color.FromArgb(157, 187, 216);
            txt_matkhau.ForeColor = Color.White;
            txt_matkhau.Location = new Point(29, 245);
            txt_matkhau.Multiline = true;
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.PasswordChar = '•';
            txt_matkhau.Size = new Size(258, 35);
            txt_matkhau.TabIndex = 1;
            txt_matkhau.KeyPress += txt_matkhau_KeyPress;
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.BackColor = Color.FromArgb(157, 187, 216);
            txt_taikhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_taikhoan.ForeColor = Color.White;
            txt_taikhoan.Location = new Point(29, 168);
            txt_taikhoan.Multiline = true;
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(258, 35);
            txt_taikhoan.TabIndex = 1;
            txt_taikhoan.KeyPress += txt_taikhoan_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(91, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.nen;
            ClientSize = new Size(860, 427);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox cb_showpass;
        private Button btn_dangnhap;
        private Label label2;
        private Label label1;
        private TextBox txt_matkhau;
        private TextBox txt_taikhoan;
        private PictureBox pictureBox1;
        private Button btn_thoat;
    }
}
