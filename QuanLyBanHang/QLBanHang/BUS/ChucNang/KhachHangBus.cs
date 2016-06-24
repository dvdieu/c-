using QuanLyBanHang.DAO.ChucNang;
using QuanLyBanHang.Model.ChucNang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.BUS.ChucNang
{
    class KhachHangBus
    {
        KhachHangDao dao = new KhachHangDao();
        public List<KhachHang> LoadDanhSachKH()
        {
            return dao.LoadDanhSachKH();
        }
        public List<string> LoadMaKH()
        {
            return dao.LoadMaKhachHang();

        }
    }
}
