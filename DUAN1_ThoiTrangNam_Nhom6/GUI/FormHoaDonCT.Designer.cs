namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    partial class FormHoaDonCT
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
            dgv_HoaDonCT = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDonCT).BeginInit();
            SuspendLayout();
            // 
            // dgv_HoaDonCT
            // 
            dgv_HoaDonCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDonCT.Location = new Point(23, 47);
            dgv_HoaDonCT.Name = "dgv_HoaDonCT";
            dgv_HoaDonCT.RowHeadersWidth = 51;
            dgv_HoaDonCT.RowTemplate.Height = 29;
            dgv_HoaDonCT.Size = new Size(980, 391);
            dgv_HoaDonCT.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 2;
            label1.Text = "Hóa đơn chi tiết";
            // 
            // FormHoaDonCT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 465);
            Controls.Add(dgv_HoaDonCT);
            Controls.Add(label1);
            Name = "FormHoaDonCT";
            Text = "FormHoaDonCT";
            Load += FormHoaDonCT_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDonCT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_HoaDonCT;
        private Label label1;
    }
}