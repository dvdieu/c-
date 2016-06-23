using QLBanHang.Model;
using QuanLyBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.DAO
{
    class NhomHangDao
    {
        public List<NhomHangModel> Formload_NhomHangdao()
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                var lst = ctx.NHOMHANG.Select(k => new NhomHangModel
                {
                   MaNhomHang = k.MaNhomHang,
                   TenNhomHang = k.TenNhomHang,
                   GhiChu =k.GhiChu,
                   ConQuanLyDonNhomHang = k.ConQuanLyDonNhomHang
                }
               ).ToList();
                return lst;
            }

        }

        public void ThemNhomHang_Dao(NHOMHANG nh)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.NHOMHANG.Add(nh);
                ctx.SaveChanges();
            }
        }
        public void SuaNhomHang_Dao(NHOMHANG nh)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.Entry(nh).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void XoaNhomHang_Dao(NHOMHANG nh)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                nh = ctx.NHOMHANG.Find(nh.MaNhomHang);
                //ctx.Entry(kv).State = System.Data.Entity.EntityState.Deleted;
                //ctx.SaveChanges();
                var result = MessageBox.Show("Ban cho chac cmun xoa khong", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ctx.NHOMHANG.Remove(nh);
                    ctx.SaveChanges();
                }
                else
                {

                }


            }
        }
    }
}
