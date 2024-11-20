namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    partial class FormThongKe
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
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            lb_tongsp = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lb_tonghd = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lb_tongtien = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            dt_ngayketthuc = new DateTimePicker();
            dt_ngaybatdau = new DateTimePicker();
            groupBox3 = new GroupBox();
            dgv_spchay = new DataGridView();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_spchay).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1219, 155);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống kê";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(157, 187, 216);
            panel3.Controls.Add(lb_tongsp);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(417, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(385, 130);
            panel3.TabIndex = 2;
            // 
            // lb_tongsp
            // 
            lb_tongsp.AutoSize = true;
            lb_tongsp.Location = new Point(171, 65);
            lb_tongsp.Name = "lb_tongsp";
            lb_tongsp.Size = new Size(23, 18);
            lb_tongsp.TabIndex = 1;
            lb_tongsp.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(109, 27);
            label2.Name = "label2";
            label2.Size = new Size(177, 23);
            label2.TabIndex = 0;
            label2.Text = "TỔNG SẢN PHẨM";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(157, 187, 216);
            panel2.Controls.Add(lb_tonghd);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(802, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 130);
            panel2.TabIndex = 1;
            // 
            // lb_tonghd
            // 
            lb_tonghd.AutoSize = true;
            lb_tonghd.Location = new Point(202, 65);
            lb_tonghd.Name = "lb_tonghd";
            lb_tonghd.Size = new Size(23, 18);
            lb_tonghd.TabIndex = 1;
            lb_tonghd.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(130, 27);
            label3.Name = "label3";
            label3.Size = new Size(167, 23);
            label3.TabIndex = 0;
            label3.Text = "TỔNG HÓA ĐƠN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(157, 187, 216);
            panel1.Controls.Add(lb_tongtien);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 130);
            panel1.TabIndex = 0;
            // 
            // lb_tongtien
            // 
            lb_tongtien.AutoSize = true;
            lb_tongtien.Location = new Point(134, 65);
            lb_tongtien.Name = "lb_tongtien";
            lb_tongtien.Size = new Size(23, 18);
            lb_tongtien.TabIndex = 1;
            lb_tongtien.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(136, 27);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 0;
            label1.Text = "TỔNG TIỀN";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(dt_ngayketthuc);
            groupBox2.Controls.Add(dt_ngaybatdau);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1219, 85);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(488, 40);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 2;
            label5.Text = "Đến ngày:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 37);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 2;
            label4.Text = "Từ ngày:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(157, 187, 216);
            button1.Location = new Point(1016, 22);
            button1.Name = "button1";
            button1.Size = new Size(149, 48);
            button1.TabIndex = 1;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dt_ngayketthuc
            // 
            dt_ngayketthuc.Location = new Point(597, 37);
            dt_ngayketthuc.Name = "dt_ngayketthuc";
            dt_ngayketthuc.Size = new Size(223, 28);
            dt_ngayketthuc.TabIndex = 0;
            // 
            // dt_ngaybatdau
            // 
            dt_ngaybatdau.Location = new Point(147, 34);
            dt_ngaybatdau.Name = "dt_ngaybatdau";
            dt_ngaybatdau.Size = new Size(215, 28);
            dt_ngaybatdau.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_spchay);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 240);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1219, 721);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Top sản phẩm bán chạy";
            // 
            // dgv_spchay
            // 
            dgv_spchay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_spchay.Dock = DockStyle.Fill;
            dgv_spchay.Location = new Point(3, 24);
            dgv_spchay.Name = "dgv_spchay";
            dgv_spchay.RowHeadersWidth = 51;
            dgv_spchay.RowTemplate.Height = 29;
            dgv_spchay.Size = new Size(1213, 694);
            dgv_spchay.TabIndex = 0;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 961);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormThongKe";
            Text = "FormThongKe";
            Load += FormThongKe_Load;
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_spchay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgv_spchay;
        private Label lb_tongsp;
        private Label lb_tonghd;
        private Label lb_tongtien;
        private Button button1;
        private DateTimePicker dt_ngayketthuc;
        private DateTimePicker dt_ngaybatdau;
        private Label label5;
        private Label label4;
    }
}