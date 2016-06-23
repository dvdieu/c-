using QLBanHang.BUS.DanhMuc;
using QLBanHang.Model;
using QuanLyBanHang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.DanhMuc
{
    public partial class frmThemNhanVien : Form
    {
        NhanVienBus busnv = new NhanVienBus();
        BoPhanBus busbp = new BoPhanBus();
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnSuaClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbophan_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemBoPhan BP = new DanhMuc.frmThemBoPhan();
            BP.ShowDialog();
            frmThemNhanVien_Load(sender, e);
           
        }

        private void btnquanly_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemNhanVien BP = new DanhMuc.frmThemNhanVien();
            BP.ShowDialog();
            frmThemNhanVien_Load(sender, e);
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            LookUpEditBoPhan.Properties.DataSource = busbp.Formload_khachhangbus();
            LookUpEditBoPhan.Properties.DisplayMember = "MaBoPhan";
            LookUpEditBoPhan.Properties.ValueMember = "TenBoPhan";
            // nhan vien
            LookUpEditQuanLy.Properties.DataSource = busnv.Formload_NhanVienbus();
            LookUpEditQuanLy.Properties.DisplayMember = "MaNhanVien";
            LookUpEditQuanLy.Properties.ValueMember = "HoTen";
        }

        private void btnSuaLuu_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MaNhanVien = txtThemMa.Text;
            nv.HoTen = txtTenKhachHang.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.DienThoai =txtDT.Text ;
            nv.ChucVu = txtChucVu.Text;
            nv.DiDong = txtDiDong.Text;
            //  thieu di dong
            nv.Email = txtEmail.Text;
            nv.MaBoPhan = LookUpEditBoPhan.GetColumnValue("MaBoPhan").ToString();
            nv.QuanLy = LookUpEditQuanLy.GetColumnValue("MaNhanVien").ToString();
            if (CkSuaConQuanLy.Checked == true)
                nv.ConQuanLyNhanVien = true;
            else
                nv.ConQuanLyNhanVien = false;
            busnv.ThemNhanVien_Bus(nv);
        }
    }
}
