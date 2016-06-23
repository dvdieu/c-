using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Model.DanhMuc
{
    class TyGiaModel
    {
        public string MaTyGia { get; set; }
        public string TenTyGia { get; set; }
        public decimal TyGiaQuyDoi { get; set; }
        public Nullable<bool> ConQuanLyDonTyGia { get; set; }
    }
}
