using DUAN1_ThoiTrangNam_Nhom6.BLL;
using System.Data;

namespace DUAN1_ThoiTrangNam_Nhom6.GUI
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            dt_ngaybatdau.Format = DateTimePickerFormat.Custom;
            dt_ngaybatdau.CustomFormat = "dd/MM/yyyy";
            dt_ngayketthuc.Format = DateTimePickerFormat.Custom;
            dt_ngayketthuc.CustomFormat = "dd/MM/yyyy";
        }

        public void load()
        {
            Loaddata();
        }

        private Thongke_BLL thongke_BLL = new Thongke_BLL();
        private bool isFiltering = false;
        private Dictionary<string, Tuple<Nullable<int>, Nullable<double>, Nullable<DateTime>>> thongtinsanpham = new Dictionary<string, Tuple<Nullable<int>, Nullable<double>, Nullable<DateTime>>>();
        private Dictionary<string, Tuple<Nullable<int>, Nullable<double>, Nullable<DateTime>>> thongtinsanphamLoc;

        public void Loaddata()
        {
            int stt = 1;
            dgv_spchay.ColumnCount = 5;
            dgv_spchay.Columns[0].Name = "STT";
            dgv_spchay.Columns[0].Visible = false;
            dgv_spchay.Columns[1].Name = "Tên sản phẩm";
            dgv_spchay.Columns[2].Name = "Số lượng bán";
            dgv_spchay.Columns[3].Name = "Tổng tiền";
            dgv_spchay.Columns[4].Name = "Ngày tạo";
            dgv_spchay.Columns[4].Visible = false;

            dgv_spchay.Rows.Clear();

            double? tongtiente = 0.0;
            int? soluong = 0;
            int tonghoadon = 0;
            thongtinsanpham.Clear();

            HashSet<int> uniqueHoaDonIds = new HashSet<int>();

            var sanphamData = thongtinsanphamLoc != null ? thongtinsanphamLoc : thongtinsanpham;
            var sapxepgiamdan = sanphamData.OrderByDescending(e => e.Value.Item1);

            foreach (var sanpham in sapxepgiamdan)
            {
                dgv_spchay.Rows.Add(stt++, sanpham.Key, sanpham.Value.Item1, sanpham.Value.Item2, "N/A");
            }

            foreach (var x in thongke_BLL.thongkehoadonct())
            {
                var idSanPhamCT = thongke_BLL.SanPhamCT().FirstOrDefault(e => e.IdSpct == x.IdSpct);
                var Tensanpham = thongke_BLL.SanPhamCT().FirstOrDefault(e => e.IdSpct == idSanPhamCT.IdSpct)?.TenSanpham;
                var hoadon = thongke_BLL.GetHoadons().FirstOrDefault(h => h.IdHd == x.IdHd);

                if (isFiltering)
                {
                    DateTime? ngayTao = hoadon.NgayTao;
                    if (!IsWithinDateRange(ngayTao, dt_ngaybatdau.Value, dt_ngayketthuc.Value))
                    {
                        continue;
                    }
                }

                if (thongtinsanpham.ContainsKey(Tensanpham))
                {
                    var existingTuple = thongtinsanpham[Tensanpham];
                    thongtinsanpham[Tensanpham] = Tuple.Create(existingTuple.Item1 + x.SoLuong, existingTuple.Item2 + x.DonGia * x.SoLuong, hoadon.NgayTao);
                }
                else
                {
                    thongtinsanpham[Tensanpham] = Tuple.Create(x.SoLuong, x.DonGia * x.SoLuong, hoadon.NgayTao);
                }
                if (uniqueHoaDonIds.Add(hoadon.IdHd))
                {
                    tonghoadon++;
                }

                tongtiente += x.SoLuong * x.DonGia;
                soluong += x.SoLuong;
            }

            lb_tongtien.Text = tongtiente?.ToString("N0") + " VND";
            lb_tongsp.Text = soluong.ToString();
            lb_tonghd.Text = tonghoadon.ToString();
        }

        private bool IsWithinDateRange(DateTime? dateToCheck, DateTime startDate, DateTime endDate)
        {
            return dateToCheck >= startDate && dateToCheck <= endDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dt_ngaybatdau.Value >= dt_ngayketthuc.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime batdau = dt_ngaybatdau.Value;
            DateTime ketthuc = dt_ngayketthuc.Value;
            DateTime today = DateTime.Today;

            if (dt_ngaybatdau.Value.Year < 2023)
            {
                MessageBox.Show("Ngày bắt đầu không thể bé hơn ngày sản phẩm ra đời.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dt_ngayketthuc.Value.Year < 2023)
            {
                MessageBox.Show("Ngày kết thúc không thể bé hơn ngày sản phẩm ra đời.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dt_ngayketthuc.Value > today.AddDays(10))
            {
                MessageBox.Show("Ngày kết thúc không quá hiện tại 10 ngày.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            thongtinsanphamLoc = thongtinsanpham
                .Where(pair =>
                {
                    DateTime? ngayTao = pair.Value.Item3;
                    return ngayTao >= batdau && ngayTao <= ketthuc;
                })
                .ToDictionary(pair => pair.Key, pair => Tuple.Create(pair.Value.Item1, pair.Value.Item2, pair.Value.Item3));

            isFiltering = true;
            Loaddata();
            isFiltering = false;
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}