//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanHang.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHANQUYEN
    {
        public string MaVaiTro { get; set; }
        public string MaChucNang { get; set; }
        public int Them { get; set; }
        public int Xoa { get; set; }
        public int CapNhat { get; set; }
    
        public virtual CHUCNANG CHUCNANG { get; set; }
        public virtual VAITRO VAITRO { get; set; }
    }
}
