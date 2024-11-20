namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    partial class FormHoaDon
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
            dgv_hoadonchitiet = new DataGridView();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgv_hoadon = new DataGridView();
            btn_xuathd = new Button();
            txt_tkhdcho = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_hoadonchitiet).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_hoadon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgv_hoadonchitiet);
            groupBox1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(41, 577);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1593, 374);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn chi tiết";
            // 
            // dgv_hoadonchitiet
            // 
            dgv_hoadonchitiet.BackgroundColor = Color.White;
            dgv_hoadonchitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_hoadonchitiet.Location = new Point(16, 24);
            dgv_hoadonchitiet.Name = "dgv_hoadonchitiet";
            dgv_hoadonchitiet.RowHeadersWidth = 51;
            dgv_hoadonchitiet.RowTemplate.Height = 29;
            dgv_hoadonchitiet.Size = new Size(1559, 331);
            dgv_hoadonchitiet.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 14;
            label2.Text = "Hóa Đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_hoadon);
            groupBox2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(41, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1593, 462);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn ";
            // 
            // dgv_hoadon
            // 
            dgv_hoadon.BackgroundColor = Color.White;
            dgv_hoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_hoadon.Location = new Point(13, 33);
            dgv_hoadon.Name = "dgv_hoadon";
            dgv_hoadon.RowHeadersWidth = 51;
            dgv_hoadon.RowTemplate.Height = 29;
            dgv_hoadon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_hoadon.Size = new Size(1562, 412);
            dgv_hoadon.TabIndex = 0;
            dgv_hoadon.CellClick += dgv_hoadon_CellClick;
            // 
            // btn_xuathd
            // 
            btn_xuathd.BackColor = Color.White;
            btn_xuathd.FlatStyle = FlatStyle.Flat;
            btn_xuathd.ForeColor = Color.FromArgb(0, 0, 192);
            btn_xuathd.Location = new Point(1209, 52);
            btn_xuathd.Name = "btn_xuathd";
            btn_xuathd.Size = new Size(202, 34);
            btn_xuathd.TabIndex = 19;
            btn_xuathd.Text = "Xuất danh sách hóa đơn";
            btn_xuathd.UseVisualStyleBackColor = false;
            btn_xuathd.Click += btn_xuathd_Click;
            // 
            // txt_tkhdcho
            // 
            txt_tkhdcho.BackColor = Color.FromArgb(157, 187, 216);
            txt_tkhdcho.BorderStyle = BorderStyle.None;
            txt_tkhdcho.Location = new Point(487, 59);
            txt_tkhdcho.Name = "txt_tkhdcho";
            txt_tkhdcho.PlaceholderText = "Tìm kiếm theo tên hoặc mã";
            txt_tkhdcho.Size = new Size(716, 20);
            txt_tkhdcho.TabIndex = 17;
            txt_tkhdcho.TextChanged += txt_tkhdcho_TextChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.DimGray;
            label3.Location = new Point(488, 81);
            label3.Name = "label3";
            label3.Size = new Size(680, 1);
            label3.TabIndex = 18;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 187, 216);
            ClientSize = new Size(1674, 992);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(btn_xuathd);
            Controls.Add(txt_tkhdcho);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHoaDon";
            Text = "FormHoaDon";
            Load += FormHoaDon_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_hoadonchitiet).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_hoadon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgv_hoadonchitiet;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dgv_hoadon;
        private Button btn_xuathd;
        private TextBox txt_tkhdcho;
        private Label label3;
    }
}