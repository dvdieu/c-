using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.DAO.DanhMuc;
using QLBanHang.DAO;
using QuanLyBanHang.Model;

namespace QLBanHang.BUS.DanhMuc
{
    class NhaCungCapBus
    {
        NhaCungCapDao dao = new NhaCungCapDao();
        public List<NhaCungCapModel> Formload_NhaCungCapbus()
        {
            return dao.Formload_NhaCungCapdao();
        }
        public void ThemNhaCungCap_Bus(NHACUNGCAP ncc)
        {
            dao.ThemNhaCUngCap_Dao(ncc);
        }
        public void XoaNhaCungCap_Bus(NHACUNGCAP ncc)
        {
            dao.XoaNhaCungCap_Dao(ncc);
        }
        public void SuaKhachhang_Bus(NHACUNGCAP ncc)
        {
            dao.SuaNhaCungCap_Dao(ncc);
        }
    }
}
