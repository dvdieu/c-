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
    class NhanVienBus
    {
        NhanVienDao dao = new NhanVienDao();
        public List<NhanVienModel> Formload_NhanVienbus()
        {
            return dao.Formload_NhanViendao();
        }
        public void ThemNhanVien_Bus(NHANVIEN nv)
        {
            dao.ThemNhanVien_Dao(nv);
        }
        public void XoaNhanVien_Bus(NHANVIEN nv)
        {
            dao.XoaKhachhang_Dao(nv);
        }
        public void SuaNhanVien_Bus(NHANVIEN nv)
        {
            dao.SuaNhanVien_Dao(nv);
        }
    }
}
