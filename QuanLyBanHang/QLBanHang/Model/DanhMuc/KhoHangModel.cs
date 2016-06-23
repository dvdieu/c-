using QuanLyBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Model
{
    class KhoHangModel
    {

        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string NguoiQuanLy { get; set; }
        public string NguoiLienHe { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string KyHieu { get; set; }
        public string GhiChu { get; set; }
        public string Email { get; set; }
        public Nullable<bool> ConQuanLyKhoHang { get; set; }


        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
