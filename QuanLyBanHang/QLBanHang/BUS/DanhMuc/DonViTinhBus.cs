using QLBanHang.DAO.DanhMuc;
using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.BUS.DanhMuc
{
    class DonViTinhBus
    {
        DonViTinhDao dao = new DonViTinhDao();
        public List<DonViTinhModel> Formload_DoViTinhbus()
        {
            return dao.Formload_donvitinhdao();
        }
        public void ThemDonViTinh_Bus(DONVITINH dvt)
        {
            dao.ThemDonViTinh_Dao(dvt);
        }
        public void XoaDoViTinh_Bus(DONVITINH dvt)
        {
            dao.XoaDonViTinh_Dao(dvt);
        }
        public void SuaDonViTinh_Bus(DONVITINH dvt)
        {
            dao.SuaDonViTinh_Dao(dvt);
        }
    }
}
