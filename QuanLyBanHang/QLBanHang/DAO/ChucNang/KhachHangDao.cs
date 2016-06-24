using QuanLyBanHang.Model;
using QuanLyBanHang.Model.ChucNang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAO.ChucNang
{
    class KhachHangDao
    {
        public List<KhachHang> LoadDanhSachKH()
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                var list = ctx.KHACHHANG.Select(k => new KhachHang
                {
                    MaKhachHang = k.MaKhachHang,
                    TenKhachHang = k.TenKhachHang
                })
                .ToList();
                return list;
            }
        }
        public List<string> LoadMaKhachHang()
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                var list = ctx.KHACHHANG
                    .Select(k => k.MaKhachHang)
                    .ToList();
                return list;
            }
        }
    }
}
