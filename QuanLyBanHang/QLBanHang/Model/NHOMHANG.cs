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
    
    public partial class NHOMHANG
    {
        public NHOMHANG()
        {
            this.HANGHOA = new HashSet<HANGHOA>();
        }
    
        public string MaNhomHang { get; set; }
        public string TenNhomHang { get; set; }
        public string GhiChu { get; set; }
        public Nullable<bool> ConQuanLyDonNhomHang { get; set; }
    
        public virtual ICollection<HANGHOA> HANGHOA { get; set; }
    }
}
