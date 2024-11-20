namespace DUAN1_ThoiTrangNam_Nhom6.DAL.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Sanphamcts = new HashSet<Sanphamct>();
        }

        public int IdSanpham { get; set; }
        public string LoaiSanpham { get; set; } = null!;
        public bool? IsAlive { get; set; }

        public Sanpham(int idSanpham, string loaiSanpham, bool? isAlive)
        {
            IdSanpham = idSanpham;
            LoaiSanpham = loaiSanpham;
            IsAlive = isAlive;
        }

        public virtual ICollection<Sanphamct> Sanphamcts { get; set; }
    }
}