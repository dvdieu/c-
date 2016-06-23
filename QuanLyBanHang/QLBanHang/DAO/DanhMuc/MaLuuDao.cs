using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DAO
{
    class MaLuuDao
    {
        public string Formload_MaLuuKhuVucdao()
        {
            string cuoi ="";
            using (QuanLyBanHangEntities ctx = new QuanLyBanHangEntities())
            {
                //var lst = ctx.KHUVUC.Select(k => new KhuVucModel
                //{
                //    MaKhuVuc = k.MaKhuVuc,
                //    TenKhuVuc = k.TenKhuVuc,
                //    GhiChu = k.GhiChu,
                //    ConQuanLyKhuVuc = k.ConQuanLyKhuVuc

                     var query = from b in ctx.KHUVUC
                        orderby b.MaKhuVuc
                        select b;
                    
                        //Console.WriteLine("All blogs in the database:"); 
                        foreach (var item in query) 
                        {
                            cuoi = item.MaKhuVuc;
                        } 

             //   }
             //).ToList();
            } 
                return cuoi;
           

        }
    }
}
