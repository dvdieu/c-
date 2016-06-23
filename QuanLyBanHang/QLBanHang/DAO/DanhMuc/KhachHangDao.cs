using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.DAO.DanhMuc
{
    class KhachHangDao
    {
        public List<KhachHangModel> Formload_khachhangdao()
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                var lst = ctx.KHACHHANG.Select(k => new KhachHangModel { 
                MaKhachHang = k.MaKhachHang,
                TenKhuVuc = k.KHUVUC.TenKhuVuc,
                TenKhachHang =k.TenKhachHang,
                NguoiLienHe=k.NguoiLienHe,
                DiaChi = k.DiaChi,
                DienThoai =k.DienThoai,
                DiDong = k.DiDong,
                Fax =k.Fax,
                Email = k.Email,
                Website = k.Website,
                MaSoThue =k.MaSoThue,
                TenNganHang = k.TenNganHang,
                SoTaiKhoan = k.SoTaiKhoan,
                NickSkype = k.NickSkype,
                NickYaHoo = k.NickYaHoo,
                NoHienTai = k.NoHienTai,
                GioiHanNo = k.GioiHanNo,
                ChietKhau = k.ChietKhau,
                MaKhuVuc = k.MaKhuVuc,
                ConQuanLyKhachHang = k.ConQuanLyKhachHang

                }).ToList();
                return lst;
            }

        }

        public void ThemKhachhang_Dao(KHACHHANG kh)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.KHACHHANG.Add(kh);
                ctx.SaveChanges();
            }
        }
        public void SuaKhachhang_Dao(KHACHHANG kh)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.Entry(kh).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void XoaKhachhang_Dao(KHACHHANG kh)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                kh = ctx.KHACHHANG.Find(kh.MaKhachHang);
                //ctx.Entry(kv).State = System.Data.Entity.EntityState.Deleted;
                //ctx.SaveChanges();
                var result = MessageBox.Show("Ban cho chac cmun xoa khong", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ctx.KHACHHANG.Remove(kh);
                    ctx.SaveChanges();
                }
                else
                {

                }


            }
        }

    }
}
