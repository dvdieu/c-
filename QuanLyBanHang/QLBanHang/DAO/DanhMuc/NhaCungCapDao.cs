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
    class NhaCungCapDao
    {
        public List<NhaCungCapModel> Formload_NhaCungCapdao()
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                var lst = ctx.NHACUNGCAP.Select(k => new NhaCungCapModel
                {
                    MaNhaCungCap = k.MaNhaCungCap,
                    TenNhaCungCap = k.TenNhaCungCap,
                    TenKhuVuc = k.KHUVUC.TenKhuVuc,
                    NguoiLienHe = k.NguoiLienHe,
                    ChucVu = k.ChucVu,
                    DiaChi = k.DiaChi,
                    DienThoai = k.DienThoai,
                    DiDong = k.DiDong,
                    Fax = k.Fax,
                    Email = k.Email,
                    Website = k.Website,
                    SoTaiKhoan =k.SoTaiKhoan,
                    TenNganHang = k.TenNganHang,
                    MaSoThue = k.MaSoThue,
                    ChietKhau = k.ChietKhau,
                    GioiHanNo = k.GioiHanNo,
                    NoHienTai =k.NoHienTai,
                    MaKhuVuc = k.MaKhuVuc,
                    ConQuanLyNhaCungCap = k.ConQuanLyNhaCungCap
                }
                ).ToList();
                return lst;
            }

        }

        public void ThemNhaCUngCap_Dao(NHACUNGCAP ncc)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.NHACUNGCAP.Add(ncc);
                ctx.SaveChanges();
            }
        }
        public void SuaNhaCungCap_Dao(NHACUNGCAP ncc)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.Entry(ncc).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void XoaNhaCungCap_Dao(NHACUNGCAP ncc)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ncc = ctx.NHACUNGCAP.Find(ncc.MaNhaCungCap);
                //ctx.Entry(kv).State = System.Data.Entity.EntityState.Deleted;
                //ctx.SaveChanges();
                var result = MessageBox.Show("Ban cho chac cmun xoa khong", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ctx.NHACUNGCAP.Remove(ncc);
                    ctx.SaveChanges();
                }
                else
                {

                }


            }
        }
    }
}
  