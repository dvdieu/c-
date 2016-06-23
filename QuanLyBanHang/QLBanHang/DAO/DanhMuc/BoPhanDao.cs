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
    class BoPhanDao
    {
        public List<BoPhanModel> Formload_BoPhandao()
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                try
                {
                    var lst = ctx.BOPHAN.Select(k => new BoPhanModel
                    {
                        MaBoPhan = k.MaBoPhan,
                        TenBoPhan = k.TenBoPhan,
                        GhiChu = k.GhiChu,
                        ConQuanLyBoPhan = k.ConQuanLyBoPhan
                    }).ToList();
                    return lst;
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }
            
        }

        public void ThemBoPhan_Dao(BOPHAN bp)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.BOPHAN.Add(bp);
                ctx.SaveChanges();
            }
        }
        public void SuaBoPhan_Dao(BOPHAN bp)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.Entry(bp).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void XoaBoPhan_Dao(BOPHAN bp)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                bp = ctx.BOPHAN.Find(bp.MaBoPhan);
                //ctx.Entry(kv).State = System.Data.Entity.EntityState.Deleted;
                //ctx.SaveChanges();
                var result = MessageBox.Show("Ban cho chac muon xoa khong", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ctx.BOPHAN.Remove(bp);
                    ctx.SaveChanges();
                }
                else
                {

                }


            }
        }
    }
}
