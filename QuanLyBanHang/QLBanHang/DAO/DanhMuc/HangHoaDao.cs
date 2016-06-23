using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.DAO.DanhMuc
{
    class HangHoaDao
    {
        public List<HangHoaModel> Formload_HangHoadao()
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                var lst = ctx.HANGHOA.Select(k => new HangHoaModel
                {
                   MaHangHoa = k.MaHangHoa,
                   TenHangHoa = k.TenHangHoa,
                   LoaiHang = k.LoaiHang,
                   MaNhomHang = k.MaNhomHang,
                   TenNhomHang = k.NHOMHANG.TenNhomHang,
                   TenKho = k.KHOHANG.TenKho,
                   TenDonVi = k.DONVITINH.TenDonVi,
                   MaDonVi =k.MaDonVi,
                   XuatXu = k.XuatXu,
                   MaNhaCungCap = k.MaNhaCungCap,
                   GiaMua =k.GiaMua,
                   GiaBanLe = k.GiaBanLe,
                   GiaBanSi = k.GiaBanSi,
                   VachNhaSX = k.VachNhaSX,
                   MaKho = k.MaKho,
                   TonKhoHienTai = k.TonKhoHienTai,
                   TonKhoToiThieu = k.TonKhoToiThieu,
                   ConQuanLyHangHoa = k.ConQuanLyHangHoa
                }
               ).ToList();
                return lst;
            }

        }

        public void ThemHangHoa_Dao(HANGHOA hh)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.HANGHOA.Add(hh);
                ctx.SaveChanges();
            }
        }
        public void SuaHangHoa_Dao(HANGHOA hh)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                ctx.Entry(hh).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public void XoaHangHoa_Dao(HANGHOA hh)
        {
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                hh = ctx.HANGHOA.Find(hh.MaHangHoa);
                //ctx.Entry(kv).State = System.Data.Entity.EntityState.Deleted;
                //ctx.SaveChanges();
                var result = MessageBox.Show("Ban cho chac cmun xoa khong", "thong báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ctx.HANGHOA.Remove(hh);
                    ctx.SaveChanges();
                }
                else
                {

                }


            }
        }
    }
}
