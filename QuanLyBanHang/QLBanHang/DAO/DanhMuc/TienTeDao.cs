using QLBanHang.Model;
using QLBanHang.Model.DanhMuc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.DAO
{
    class TienTeDao
    {
        public List<TyGiaModel> Formload_TyGiadao()
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                var lst = ctx.TYGIA.Select(k => new TyGiaModel
                {
                    MaTyGia = k.MaTyGia,
                    TenTyGia = k.TenTyGia,
                    TyGiaQuyDoi = k.TyGiaQuyDoi,
                    ConQuanLyDonTyGia = k.ConQuanLyDonTyGia
                }
               ).ToList();
                return lst;
            }

        }

        public void ThemTyGia_Dao(TYGIA tg)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.TYGIA.Add(tg);
                ctx.SaveChanges();
            }
        }
        public void SuaTyGia_Dao(TYGIA  tg)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.Entry(tg).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void XoaTyGia_Dao(TYGIA tg)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                tg = ctx.TYGIA.Find(tg.MaTyGia);
                //ctx.Entry(kv).State = System.Data.Entity.EntityState.Deleted;
                //ctx.SaveChanges();
                var result = MessageBox.Show("Ban cho chac cmun xoa khong", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ctx.TYGIA.Remove(tg);
                    ctx.SaveChanges();
                }
                else
                {

                }


            }
        }
    }
}
