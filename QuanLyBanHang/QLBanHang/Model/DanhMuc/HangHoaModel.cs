using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Model
{
    class HangHoaModel
    {


        public string TenNhomHang { get; set; }
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public string LoaiHang { get; set; }
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string MaNhomHang { get; set; }
        public string TenDonVi{ get; set; }
        public string MaDonVi { get; set; }
        public string VachNhaSX { get; set; }
        public string XuatXu { get; set; }
        public string MaNhaCungCap { get; set; }
        public decimal GiaMua { get; set; }
        public decimal GiaBanLe { get; set; }
        public decimal GiaBanSi { get; set; }
        public int TonKhoToiThieu { get; set; }
        public int TonKhoHienTai { get; set; }
        public Nullable<bool> ConQuanLyHangHoa { get; set; }
    }
}
