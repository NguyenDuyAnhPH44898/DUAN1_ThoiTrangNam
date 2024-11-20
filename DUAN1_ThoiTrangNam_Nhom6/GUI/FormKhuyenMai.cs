using DUAN1_ThoiTrangNam_Nhom6.BLL;
using DUAN1_ThoiTrangNam_Nhom6.DAL;
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
    public partial class FormKhuyenMai : Form
    {

        private KhuyenMai_BLL khuyenMai_BLL;
       
        public FormKhuyenMai()
        {
            InitializeComponent();
            txt_makm.ReadOnly = true;
            txt_ngaybatdau.ReadOnly = true;
            txt_makm.BackColor = Color.DarkGray;
            txt_ngaybatdau.BackColor = Color.DarkGray;

            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

           
        }


        private void FormKhuyenMai_Load(object sender, EventArgs e)
        {
            loaddata();
            XoaKhuyenMaiHetHan();
        }

        public void loaddata()
        {
            khuyenMai_BLL = new KhuyenMai_BLL();
            LoaddataKM();

        }


        public void LoaddataKM()
        {
            var re = khuyenMai_BLL.laythongtin();

            var show = re.Select(km => new
            {
                ID = km.IdKhuyenMai,
                Ma = km.MaKhuyenMai,
                NgayBatDau = km.NgayBatDau,
                Ngayketthuc = km.NgayKetThuc,
                GiamGia = km.PhanTramGiamGia,
                SoLuong = km.SoLuong,

            }).ToList();
            dgv_dsKhuyemai.DataSource = show;
            dgv_dsKhuyemai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_dsKhuyemai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dgv_dsKhuyemai.Rows.Count)
            {
                DataGridViewRow selectedRow = dgv_dsKhuyemai.Rows[rowIndex];
                txt_makm.Text = selectedRow.Cells["Ma"].Value.ToString();
                txt_ngaybatdau.Text = selectedRow.Cells["NgayBatDau"].Value.ToString();
                txt_phantram.Text = selectedRow.Cells["GiamGia"].Value.ToString();
                txt_soluong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                dt_ngayketthuc.Text = selectedRow.Cells["Ngayketthuc"].Value.ToString();
            }
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm khuyến mãi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    
                    if (!IsValidInput())
                    {
                        return;
                    }

                    KhuyenMai khuyenMai = new KhuyenMai
                    {
                        MaKhuyenMai = SinhMaKhuyenMai(),
                        NgayBatDau = DateTime.Now,
                        NgayKetThuc = DateTime.Parse(dt_ngayketthuc.Text),
                        PhanTramGiamGia = float.Parse(txt_phantram.Text),
                        SoLuong = int.Parse(txt_soluong.Text)
                    };

                    if (khuyenMai_BLL.ThemKhuyenMai(khuyenMai))
                    {
                        MessageBox.Show("Thêm khuyến mãi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoaddataKM();
                        txt_makm.Clear();
                        txt_ngaybatdau.Clear();
                        txt_phantram.Clear();
                        txt_soluong.Clear();
                        btn_sua.Enabled = false;
                        btn_xoa.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm khuyến mãi thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm khuyến mãi không thành công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValidInput()
        {

            // Kiểm tra phần trăm giảm giá
            if (!float.TryParse(txt_phantram.Text, out float phanTram) || phanTram < 0 || phanTram > 100)
            {
                MessageBox.Show("Phần trăm giảm giá không hợp lệ. Vui lòng nhập giá trị từ 0 đến 100.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra số lượng
            if (!int.TryParse(txt_soluong.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập một số nguyên không âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private string SinhMaKhuyenMai()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa khuyến mãi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                KhuyenMai khuyenMai = new KhuyenMai
                {
                    IdKhuyenMai = int.Parse(dgv_dsKhuyemai.CurrentRow.Cells["ID"].Value.ToString()),
                    MaKhuyenMai = txt_makm.Text,
                    NgayKetThuc = DateTime.Parse(dt_ngayketthuc.Text),
                    PhanTramGiamGia = float.Parse(txt_phantram.Text),
                    SoLuong = int.Parse(txt_soluong.Text)
                };
                if (khuyenMai_BLL.SuaKhuyenMai(khuyenMai))
                {
                    MessageBox.Show("Sửa khuyến mãi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoaddataKM();
                    txt_makm.Clear();
                    txt_ngaybatdau.Clear();
                    txt_phantram.Clear();
                    txt_soluong.Clear();
                    btn_sua.Enabled = false;
                    btn_xoa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sửa khuyến mãi thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = int.Parse(dgv_dsKhuyemai.CurrentRow.Cells["ID"].Value.ToString());
                if (khuyenMai_BLL.XoaKhuyenMai(id))
                {
                    MessageBox.Show("Xóa khuyến mãi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoaddataKM();
                    txt_makm.Clear();
                    txt_ngaybatdau.Clear();
                    txt_phantram.Clear();
                    txt_soluong.Clear();
                    btn_sua.Enabled = false;
                    btn_xoa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Xóa khuyến mãi thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            txt_makm.Clear();
            txt_ngaybatdau.Clear();
            txt_phantram.Clear();
            txt_soluong.Clear();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        public void XoaKhuyenMaiHetHan()
        {
           
            var danhSachKhuyenMai = khuyenMai_BLL.laythongtin();

          
            foreach (var khuyenMai in danhSachKhuyenMai)
            {
              
                if (DateTime.Now > khuyenMai.NgayKetThuc)
                {
                    
                    khuyenMai_BLL.XoaKhuyenMai(khuyenMai.IdKhuyenMai);
                }
            }
          
            LoaddataKM();
        }

       
    }
}
