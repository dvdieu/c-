using QLBanHang.BUS.DanhMuc;
using QLBanHang.Model;
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
    public partial class frmThemKhoHang : Form
    {
        KhoHangBus bus = new KhoHangBus();
        NhanVienBus busnv = new NhanVienBus();
        public frmThemKhoHang()
        {
            InitializeComponent();
        }

        private void btnThemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemLuu_Click(object sender, EventArgs e)
        {
            KHOHANG kh = new KHOHANG();
            kh.MaKho = txtMa.Text;
            kh.TenKho = txtTen.Text;
            kh.NguoiQuanLy = cboxQuanLy.GetColumnValue("MaNhanVien").ToString();
            kh.NguoiLienHe = txtNguoiLienHe.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.DienThoai = txtSDT.Text;
            kh.KyHieu = txtKiHieu.Text;
            kh.GhiChu = txtDienGiai.Text;
            kh.Fax = txtFax.Text;
            kh.Email = txtEmail.Text;
            //kh.GhiChu
            if (CkThemConQuanLy.Checked == true)
                kh.ConQuanLyKhoHang = true;
            else
                kh.ConQuanLyKhoHang = false;
            bus.ThemKhoHang_Bus(kh);
        }

        private void frmThemKhoHang_Load(object sender, EventArgs e)
        {
            cboxQuanLy.Properties.DataSource = busnv.Formload_NhanVienbus();
            cboxQuanLy.Properties.DisplayMember = "MaNhanVien";
            cboxQuanLy.Properties.ValueMember = "HoTen";
        }

        private void btnquanly_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemNhanVien nv = new DanhMuc.frmThemNhanVien();
            nv.ShowDialog();
            frmThemKhoHang_Load(sender, e);
        }
    }
}
