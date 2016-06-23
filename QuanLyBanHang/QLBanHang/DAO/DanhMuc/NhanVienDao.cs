using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.DAO.DanhMuc
{
    class NhanVienDao
    {
        public List<NhanVienModel> Formload_NhanViendao()
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                var lst = ctx.NHANVIEN.Select(k => new NhanVienModel
                {
                   MaNhanVien = k.MaNhanVien,
                   HoTen = k.HoTen,
                   DiaChi = k.DiaChi,
                   DienThoai =k .DienThoai,
                   Email=  k.Email,
                   MaBoPhan = k.MaBoPhan,
                   QuanLy = k.QuanLy,
                   ChucVu =k.ChucVu,
                   DiDong = k.DiDong,
                   ConQuanLyNhanVien = k.ConQuanLyNhanVien
                }
                ).ToList();
                return lst;
            }

        }

        public void ThemNhanVien_Dao(NHANVIEN nv)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.NHANVIEN.Add(nv);
                ctx.SaveChanges();
            }
        }
        public void SuaNhanVien_Dao(NHANVIEN nv)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.Entry(nv).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void XoaKhachhang_Dao(NHANVIEN nv )
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                nv = ctx.NHANVIEN.Find(nv.MaNhanVien);
                //ctx.Entry(kv).State = System.Data.Entity.EntityState.Deleted;
                //ctx.SaveChanges();
                var result = MessageBox.Show("Ban cho chac cmun xoa khong", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ctx.NHANVIEN.Remove(nv);
                    ctx.SaveChanges();
                }
                else
                {

                }


            }
        }
    }
}
