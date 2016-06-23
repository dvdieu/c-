using QLBanHang.DAO;
using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.BUS
{
    class MaLuuBus

    {
        MaLuuDao dao = new MaLuuDao();
        public string Formload_khuvucbus()
        {
            return dao.Formload_MaLuuKhuVucdao();
        }
    }
}
