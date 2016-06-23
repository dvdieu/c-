using QLBanHang.DAO.DanhMuc;
using QLBanHang.Model;
using QuanLyBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.BUS.DanhMuc
{
    class HangHoaBus
    {
        HangHoaDao dao = new HangHoaDao();
        public List<HangHoaModel> Formload_HangHoabus()
        {
            return dao.Formload_HangHoadao();
        }
        public void ThemHangHoa_Bus(HANGHOA hh)
        {
            dao.ThemHangHoa_Dao(hh);
        }
        public void XoaHangHoa_Bus(HANGHOA hh)
        {
            dao.XoaHangHoa_Dao(hh);
        }
        public void SuaHangHoa_Bus(HANGHOA hh)
        {
            dao.SuaHangHoa_Dao(hh);
        }
      
    }
}
