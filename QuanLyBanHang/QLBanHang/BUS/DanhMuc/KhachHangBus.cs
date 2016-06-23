using QLBanHang.DAO.DanhMuc;
using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLBanHang.BUS.DanhMuc
{
    class KhachHangBus
    {
        KhachHangDao dao = new KhachHangDao();
        public List<KhachHangModel> Formload_khachhangbus()
        {
            return dao.Formload_khachhangdao();
        }
        public void ThemKhachhang_Bus(KHACHHANG kv)
        {
            dao.ThemKhachhang_Dao(kv);
        }
        public void XoaKhachhang_Bus(KHACHHANG kh)
        {
            dao.XoaKhachhang_Dao(kh);
        }
        public void SuaKhachhang_Bus(KHACHHANG kh)
        {
            dao.SuaKhachhang_Dao(kh);
        }
      

    }
}
