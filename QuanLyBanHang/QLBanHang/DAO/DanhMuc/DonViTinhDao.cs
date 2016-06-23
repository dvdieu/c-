using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.DAO.DanhMuc
{
    class DonViTinhDao
    {
        public List<DonViTinhModel> Formload_donvitinhdao()
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                var lst = ctx.DONVITINH.Select(k => new DonViTinhModel
                {
                  MaDonVi = k.MaDonVi,
                  TenDonVi = k.TenDonVi,
                  GhiChu = k.GhiChu,
                  ConQuanLyDonViTinh = k.ConQuanLyDonViTinh
                }
             ).ToList();
                return lst;
            }

        }

        public void ThemDonViTinh_Dao(DONVITINH dvt)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.DONVITINH.Add(dvt);
                ctx.SaveChanges();
            }
        }
        public void SuaDonViTinh_Dao(DONVITINH dvt)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.Entry(dvt).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void XoaDonViTinh_Dao(DONVITINH dvt)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                dvt = ctx.DONVITINH.Find(dvt.MaDonVi);
                //ctx.Entry(kv).State = System.Data.Entity.EntityState.Deleted;
                //ctx.SaveChanges();
                var result = MessageBox.Show("Ban cho chac cmun xoa khong", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ctx.DONVITINH.Remove(dvt);
                    ctx.SaveChanges();
                }
                else
                {

                }


            }
        }

    }
}
