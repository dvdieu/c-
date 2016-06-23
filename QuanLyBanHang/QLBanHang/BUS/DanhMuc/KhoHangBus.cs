using QLBanHang.DAO.DanhMuc;
using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.BUS.DanhMuc
{
    class KhoHangBus
    {
        KhoHangDao dao = new KhoHangDao();
        public List<KhoHangModel> Formload_khoHangbus()
        {
            return dao.Formload_khoHangdao();
        }
        public void ThemKhoHang_Bus(KHOHANG kh)
        {
            dao.ThemKhoHang_Dao(kh);
        }
        public void XoaKhohang_Bus(KHOHANG kh)
        {
            dao.XoaKhoHang_Dao(kh);
        }
        public void SuaKhachhang_Bus(KHOHANG kh)
        {
            dao.SuaKhohang_Dao(kh);
        }
    }
}
