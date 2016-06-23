using QLBanHang.DAO;
using QLBanHang.Model;
using QLBanHang.Model.DanhMuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.BUS.DanhMuc
{
    class TienTeBus
    {
        TienTeDao dao = new TienTeDao();
        public List<TyGiaModel> Formload_TyGiabus()
        {
            return dao.Formload_TyGiadao();
        }
        public void ThemTyGia_Bus(TYGIA tg)
        {
            dao.ThemTyGia_Dao(tg);
        }
        public void XoaTyGia_Bus(TYGIA tg)
        {
            dao.XoaTyGia_Dao(tg);
        }
        public void SuaTyGia_Bus(TYGIA tg)
        {
            dao.SuaTyGia_Dao(tg);
        }
    }
}
