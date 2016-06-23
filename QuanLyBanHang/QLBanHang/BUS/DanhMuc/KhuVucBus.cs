using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.Model;
using QLBanHang.DAO;
using QLBanHang.DAO.DanhMuc.KhuVuc;
using QuanLyBanHang.Model;

namespace QLBanHang.BUS.DanhMuc.KhuVuc
{
    class KhuVucBus
    {
        KhuVucDao dao = new KhuVucDao();
        public void ThemKhuVuc_Bus(KHUVUC kv)
        {
            dao.ThemKhuVuc_Dao(kv);
        }
        public void XoaKhuVuc_Bus(KHUVUC kv)
        {
            dao.XoaKhuVuc_Dao(kv);
        }
        public void SuaKhuVuc_Bus(KHUVUC kv)
        {
            dao.SuaKhuVuc_Dao(kv);
        }
        public List<KhuVucModel> Formload_khuvucbus()
        {
            return dao.Formload_khuvucdao();
        }

    }
}
