using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.DAL
{
    public class KTK_DAL
    {
        private readonly DB_DUAN1_Nhom6Context db;

        public KTK_DAL(DB_DUAN1_Nhom6Context context)
        {
            db = context;
        }

        public List<KieuTaiKhoan> LayDanhSachktk()
        {
            return db.KieuTaiKhoans.ToList();
        }

    }
}
