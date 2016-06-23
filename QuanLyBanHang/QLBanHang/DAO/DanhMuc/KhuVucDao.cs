using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraTab;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using QLBanHang.Model;
using System.Windows.Forms;
using QuanLyBanHang.Model;

namespace QLBanHang.DAO.DanhMuc.KhuVuc
{
    class KhuVucDao
    {
        public List<KhuVucModel> Formload_khuvucdao()
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                var lst = ctx.KHUVUC.Select(k => new KhuVucModel
                {
                   MaKhuVuc = k.MaKhuVuc,
                   TenKhuVuc = k.TenKhuVuc,
                   GhiChu = k.GhiChu,
                   ConQuanLyKhuVuc = k.ConQuanLyKhuVuc
                }
             ).ToList();
                return lst;
            }

        }
        public void ThemKhuVuc_Dao(KHUVUC kv)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.KHUVUC.Add(kv);
                ctx.SaveChanges();
            }
        }
        public void SuaKhuVuc_Dao(KHUVUC kv)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.Entry(kv).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void XoaKhuVuc_Dao(KHUVUC kv)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                kv = ctx.KHUVUC.Find(kv.MaKhuVuc);
                //ctx.Entry(kv).State = System.Data.Entity.EntityState.Deleted;
                //ctx.SaveChanges();
                var result = MessageBox.Show("Ban cho chac cmun xoa khong", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ctx.KHUVUC.Remove(kv);
                    ctx.SaveChanges();
                }
                else
                {

                }


            }
        }

    }
}
