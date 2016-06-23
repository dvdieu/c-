using QLBanHang.DAO;
using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.BUS.DanhMuc
{
    class BoPhanBus
    {
        BoPhanDao dao= new BoPhanDao();
        public List<BoPhanModel> Formload_khachhangbus()
        {
            return dao.Formload_BoPhandao();
        }
        public void ThemBoPhan_Bus(BOPHAN bp)
        {
            dao.ThemBoPhan_Dao(bp);
        }
        public void XoaBoPhan_Bus(BOPHAN bp)
        {
            dao.XoaBoPhan_Dao(bp);
        }
        public void SuaBoPhan_Bus(BOPHAN bp)
        {
            dao.SuaBoPhan_Dao(bp);
        }
      
    }
}
