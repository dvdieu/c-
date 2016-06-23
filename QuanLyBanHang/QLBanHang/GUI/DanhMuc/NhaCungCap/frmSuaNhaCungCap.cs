using QLBanHang.BUS.DanhMuc;
using QLBanHang.BUS.DanhMuc.KhuVuc;
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
    public partial class frmSuaNhaCungCap : Form
    {
        NhaCungCapBus bus = new NhaCungCapBus();
        KhuVucBus buskv = new KhuVucBus();
        public frmSuaNhaCungCap(NHACUNGCAP ncc)
        {
            InitializeComponent();

            txtThemMa.Text = ncc.MaNhaCungCap;
            txtThemTen.Text = ncc.TenNhaCungCap;
            txtThemNguoiLienHe.Text = ncc.NguoiLienHe;
            txtThemChucvu.Text = ncc.ChucVu;
            txtThemDiaChi.Text = ncc.DiaChi;
            txtThemSDT.Text = ncc.DienThoai;
            txtThemMobile.Text = ncc.DiDong;
            txtThemFax.Text = ncc.Fax;
            txtThemEmail.Text = ncc.Email;
            txtThemMaSoThue.Text = ncc.MaSoThue;
            txtThemTaiKhoan.Text = ncc.SoTaiKhoan;
            txtThemNganHang.Text = ncc.TenNganHang;
            LookUpEditKhuVuc.EditValue = ncc.MaKhuVuc;
            if (ncc.ChietKhau != null)
            {
                calcThemChietKhau.Value = (decimal)ncc.ChietKhau;
                calcThemGioiHanNo.Value = (decimal)ncc.GioiHanNo;
                calcThemNOHienTai.Value = (decimal)ncc.NoHienTai;
            }
           
             txtThemWebsite.Text = ncc.Website;

            if (ncc.ConQuanLyNhaCungCap == true)
                CkechSuaConQuanLy.Checked = true;
            else
                CkechSuaConQuanLy.Checked = false;

        }

 

        private void frmSuaNhaCungCap_Load(object sender, EventArgs e)
        {
            LookUpEditKhuVuc.Properties.DataSource = buskv.Formload_khuvucbus();
            LookUpEditKhuVuc.Properties.DisplayMember = "MaKhuVuc";
            LookUpEditKhuVuc.Properties.ValueMember = "TenKhuVuc";

        }

       

      

        private void btnkhuvuc_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemKhuVuc KhuVuc = new DanhMuc.frmThemKhuVuc();
            KhuVuc.ShowDialog();
            frmSuaNhaCungCap_Load(sender, e);
        }

        private void btnSuaLuu_Click(object sender, EventArgs e)
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
            ncc.Email = txtThemEmail.Text;
            //
            if (calcThemNOHienTai.Value != null)
                ncc.NoHienTai = calcThemNOHienTai.Value;
            else
                ncc.NoHienTai = '0';
            if (calcThemGioiHanNo.Value != null)
                ncc.GioiHanNo = calcThemGioiHanNo.Value;
            else
                ncc.GioiHanNo = '0';
            if (calcThemChietKhau.Value !=null)
                 ncc.ChietKhau = calcThemChietKhau.Value;
            else
                ncc.ChietKhau = '0';
            ncc.MaSoThue = txtThemMaSoThue.Text;
            ncc.SoTaiKhoan = txtThemTaiKhoan.Text;
            ncc.TenNganHang = txtThemNganHang.Text;
            if (CkechSuaConQuanLy.Checked == true)
                ncc.ConQuanLyNhaCungCap = true;
            else
                ncc.ConQuanLyNhaCungCap = false;
            bus.SuaKhachhang_Bus(ncc);
        }

        private void btnSuaClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
