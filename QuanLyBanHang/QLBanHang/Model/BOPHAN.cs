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
    
    public partial class BOPHAN
    {
        public BOPHAN()
        {
            this.NHANVIEN = new HashSet<NHANVIEN>();
        }
    
        public string MaBoPhan { get; set; }
        public string TenBoPhan { get; set; }
        public string GhiChu { get; set; }
        public Nullable<bool> ConQuanLyBoPhan { get; set; }
    
        public virtual ICollection<NHANVIEN> NHANVIEN { get; set; }
    }
}
