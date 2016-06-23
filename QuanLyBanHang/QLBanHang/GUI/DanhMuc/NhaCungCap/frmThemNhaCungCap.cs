using QLBanHang.BUS.DanhMuc;
using QLBanHang.BUS.DanhMuc.KhuVuc;
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
    public partial class frmThemNhaCungCap : Form
    {
        NhaCungCapBus bus = new NhaCungCapBus();
        KhuVucBus buskv = new KhuVucBus();
        public frmThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnThemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemLuu_Click(object sender, EventArgs e)
        {
            NHACUNGCAP ncc = new NHACUNGCAP();
            ncc.MaNhaCungCap = txtThemMa.Text;
            ncc.TenNhaCungCap = txtThemTen.Text;
            ncc.MaKhuVuc = LookUpEditKhuVuc.GetColumnValue("MaKhuVuc").ToString();
            ncc.NguoiLienHe = txtThemNguoiLienHe.Text;
            ncc.ChucVu = txtThemChucvu.Text;
            ncc.DiaChi = txtThemDiaChi.Text;
            ncc.DienThoai = txtThemSDT.Text;
            ncc.DiDong = txtThemMobile.Text;
            ncc.Fax = txtThemFax.Text;
            ncc.Email = txtThemEmail.Text;
            ncc.Website = txtThemWebsite.Text;
            ncc.MaSoThue = txtThemMaSoThue.Text;
            //ncc.ChietKhau = calcThemChietKhau.Value;
            //ncc.GioiHanNo = calcThemGioiHanNo.Value;
            //ncc.NoHienTai = calcThemNOHienTai.Value;

            if (calcThemNOHienTai.Value != null)
                ncc.NoHienTai = calcThemNOHienTai.Value;
            else
                ncc.NoHienTai = '0';
            if (calcThemGioiHanNo.Value != null)
                ncc.GioiHanNo = calcThemGioiHanNo.Value;
            else
                ncc.GioiHanNo = '0';
            if (calcThemChietKhau.Value != null)
                ncc.ChietKhau = calcThemChietKhau.Value;
            else
                ncc.ChietKhau = '0';
            // 3 nợ
            ncc.SoTaiKhoan = txtThemTaiKhoan.Text;
            ncc.TenNganHang = txtThemNganHang.Text;
            if(CkechThemConQuanLy.Checked == true)
                     ncc.ConQuanLyNhaCungCap = true;
            else
                ncc.ConQuanLyNhaCungCap = false;
            bus.ThemNhaCungCap_Bus(ncc);

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmThemNhaCungCap_Load(object sender, EventArgs e)
        {
            LookUpEditKhuVuc.Properties.DataSource = buskv.Formload_khuvucbus();
            LookUpEditKhuVuc.Properties.DisplayMember = "MaKhuVuc";
            LookUpEditKhuVuc.Properties.ValueMember = "TenKhuVuc";
        }

        private void CkechThemConQuanLy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnkhuvuc_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemKhuVuc KhuVuc = new DanhMuc.frmThemKhuVuc();
            KhuVuc.ShowDialog();
            frmThemNhaCungCap_Load(sender, e);
        }
    }
}
