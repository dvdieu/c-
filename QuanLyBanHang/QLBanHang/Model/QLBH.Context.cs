﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyBanHangEntities : DbContext
    {
        public QuanLyBanHangEntities()
            : base("name=QuanLyBanHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BOPHAN> BOPHAN { get; set; }
        public virtual DbSet<CHITIETPHIEUBANHANG> CHITIETPHIEUBANHANG { get; set; }
        public virtual DbSet<CHITIETPHIEUCHUYENKHO> CHITIETPHIEUCHUYENKHO { get; set; }
        public virtual DbSet<CHITIETPHIEUNHAPHANG> CHITIETPHIEUNHAPHANG { get; set; }
        public virtual DbSet<CHUCNANG> CHUCNANG { get; set; }
        public virtual DbSet<CONGNOCHI> CONGNOCHI { get; set; }
        public virtual DbSet<CONGNOTHU> CONGNOTHU { get; set; }
        public virtual DbSet<DONVITINH> DONVITINH { get; set; }
        public virtual DbSet<HANGHOA> HANGHOA { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<KHOHANG> KHOHANG { get; set; }
        public virtual DbSet<KHUVUC> KHUVUC { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAP { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<NHOMHANG> NHOMHANG { get; set; }
        public virtual DbSet<PHANQUYEN> PHANQUYEN { get; set; }
        public virtual DbSet<PHIEUBANHANG> PHIEUBANHANG { get; set; }
        public virtual DbSet<PHIEUCHUYENKHO> PHIEUCHUYENKHO { get; set; }
        public virtual DbSet<PHIEUNHAPHANG> PHIEUNHAPHANG { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOAN { get; set; }
        public virtual DbSet<TONKHO> TONKHO { get; set; }
        public virtual DbSet<TYGIA> TYGIA { get; set; }
        public virtual DbSet<VAITRO> VAITRO { get; set; }
    }
}
