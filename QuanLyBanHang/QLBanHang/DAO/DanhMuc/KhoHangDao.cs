using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.DAO.DanhMuc
{
    class KhoHangDao
    {
        public List<KhoHangModel> Formload_khoHangdao()
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                var lst = ctx.KHOHANG.Select(k => new KhoHangModel
                {
                  MaKho =k.MaKho,
                  TenKho =k.TenKho,
                  NguoiQuanLy = k.NguoiQuanLy,
                  NguoiLienHe =k.NguoiLienHe,
                  DiaChi = k.DiaChi,
                  DienThoai = k.DienThoai,
                  KyHieu = k.KyHieu,
                  GhiChu = k.GhiChu,
                  Email =k.Email,
                  Fax = k.Fax,
                  ConQuanLyKhoHang =k.ConQuanLyKhoHang

                }).ToList();
                return lst;
            }

        }

        public void ThemKhoHang_Dao(KHOHANG kh)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.KHOHANG.Add(kh);
                ctx.SaveChanges();
            }
        }
        public void SuaKhohang_Dao(KHOHANG kh)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.Entry(kh).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void XoaKhoHang_Dao(KHOHANG kh)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                kh = ctx.KHOHANG.Find(kh.MaKho);
                //ctx.Entry(kv).State = System.Data.Entity.EntityState.Deleted;
                //ctx.SaveChanges();
                var result = MessageBox.Show("Ban cho chac cmun xoa khong", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ctx.KHOHANG.Remove(kh);
                    ctx.SaveChanges();
                }
                else
                {

                }


            }
        }
    }
}
