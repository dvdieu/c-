using QuanLyBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Model
{
    class NhaCungCapModel
    {

        public string TenKhuVuc { get; set; }
        public string MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; }
        public string MaKhuVuc { get; set; }
        public string NguoiLienHe { get; set; }
        public string ChucVu { get; set; }
        public string DiaChi { get; set; }
        public string MaSoThue { get; set; }
        public string DienThoai { get; set; }
        public string DiDong { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string SoTaiKhoan { get; set; }
        public string TenNganHang { get; set; }
        public Nullable<decimal> ChietKhau { get; set; }
        public Nullable<decimal> GioiHanNo { get; set; }
        public Nullable<decimal> NoHienTai { get; set; }
        public Nullable<bool> ConQuanLyNhaCungCap { get; set; }

        public virtual KHUVUC KHUVUC { get; set; }
    }
}
