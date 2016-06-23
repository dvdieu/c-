using QLBanHang.DAO;
using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.BUS.DanhMuc
{
    class NhomHangBus
    {
        NhomHangDao dao = new NhomHangDao();
        public List<NhomHangModel> Formload_NhomHangbus()
        {
            return dao.Formload_NhomHangdao();
        }
        public void ThemNhomHang_Bus(NHOMHANG nh)
        {
            dao.ThemNhomHang_Dao(nh);
        }
        public void XoaNhomHang_Bus(NHOMHANG nh)
        {
            dao.XoaNhomHang_Dao(nh);
        }
        public void SuaNhomHang_Bus(NHOMHANG nh)
        {
            dao.SuaNhomHang_Dao(nh);
        }
    }
}
