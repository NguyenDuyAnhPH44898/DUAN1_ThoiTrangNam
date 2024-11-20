using DUAN1_ThoiTrangNam_Nhom6.DAL.Models;
using DUAN1_ThoiTrangNam_Nhom6.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUAN1_ThoiTrangNam_Nhom6.BLL
{
    public class KTK_BLL
    {
        private DB_DUAN1_Nhom6Context _dbContext;
        private readonly KTK_DAL kTK_DAL;
        public KTK_BLL()
        {
            _dbContext = new DB_DUAN1_Nhom6Context();
            kTK_DAL = new KTK_DAL(new DB_DUAN1_Nhom6Context());
        }

        public List<KieuTaiKhoan> laydanhsachktk()
        {
            return _dbContext.KieuTaiKhoans.ToList();
        }
    }
}
