using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    public partial class FormHoaDonCT : Form
    {
        DB_DUAN1_Nhom6Context db = new DB_DUAN1_Nhom6Context();
        private List<HoaDonCt> danhSachHoaDonChiTiet;
        public FormHoaDonCT(List<HoaDonCt> danhSachHoaDonChiTiet)
        {
            InitializeComponent();

            this.danhSachHoaDonChiTiet = danhSachHoaDonChiTiet;
            HienThiThongTinHoaDonChiTiet();

            dgv_HoaDonCT.DataSource = danhSachHoaDonChiTiet;

            dgv_HoaDonCT.Columns["IdSpct"].HeaderText = "ID Sản phẩm";


        }

        private void HienThiThongTinHoaDonChiTiet()
        {

        }
        private void FormHoaDonCT_Load(object sender, EventArgs e)
        {

        }
    }
}
