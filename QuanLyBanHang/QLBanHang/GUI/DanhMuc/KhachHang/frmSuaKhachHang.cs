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
    public partial class frmSuaKhachHang : Form
    {
        KhachHangBus bus = new KhachHangBus();
        KhuVucBus buskv = new KhuVucBus();
        public frmSuaKhachHang(KHACHHANG kh)
        {
            InitializeComponent();
            txtmakh.Text = kh.MaKhachHang;
            txttenkhachhang.Text = kh.TenKhachHang;
            lookUpkhuvuc.EditValue = kh.MaKhuVuc;
            // khu vuc
            txtthemnguoilienhe.Text = kh.NguoiLienHe;
            txtdiachi.Text = kh.DiaChi;
            txtsodienthoai.Text = kh.DienThoai;
            txtthemoblie.Text = kh.DiDong;
            txtthemfaxkh.Text = kh.Fax;
            txtemail.Text = kh.Email;
            txtThemWebsiteKhachHang.Text= kh.Website;
            txtthemtaikhoankh.Text = kh.SoTaiKhoan;
            txttenkhachhang.Text = kh.TenNganHang;
            calcthemchietkhau.Value =(decimal)kh.ChietKhau;
            calcthemgioihanno.Value = (decimal)kh.GioiHanNo;
            calcThemNOHienTai.Value = (decimal)kh.NoHienTai;
            txtThemYahooKhachHang.Text = kh.NickYaHoo;
            txtThemSkypeKhachHang.Text= kh.NickSkype;
            txtMasotheu.Text = kh.MaSoThue;
            txtThemNganHangKhachHang.Text = kh.TenNganHang;
            if (kh.ConQuanLyKhachHang == true)
                CkThemConQuanLy.Checked = true;
            else
                CkThemConQuanLy.Checked= false;      
        }


     

     

        private void frmSuaKhachHang_Load(object sender, EventArgs e)
        {
            lookUpkhuvuc.Properties.DataSource = buskv.Formload_khuvucbus();
            lookUpkhuvuc.Properties.DisplayMember = "MaKhuVuc";
            lookUpkhuvuc.Properties.ValueMember = "TenKhuVuc";
        }

        private void btnSuaClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSuaLuu_Click_1(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG();
            kh.MaKhachHang = txtmakh.Text;
            kh.TenKhachHang = txttenkhachhang.Text;
            kh.MaKhuVuc = lookUpkhuvuc.GetColumnValue("MaKhuVuc").ToString(); // lookUpEdit1.GetColumnValue("Hoten").ToString();
            kh.NguoiLienHe = txtthemnguoilienhe.Text;
            kh.DiaChi = txtdiachi.Text;
            kh.DienThoai = txtsodienthoai.Text;
            kh.DiDong = txtthemoblie.Text;
            kh.Fax = txtthemfaxkh.Text;
            kh.Email = txtemail.Text;
            kh.Website = txtThemWebsiteKhachHang.Text;
            kh.MaSoThue = txtMasotheu.Text;
            kh.SoTaiKhoan = txtthemtaikhoankh.Text;
            kh.TenNganHang = txtThemNganHangKhachHang.Text;

            if (calcthemchietkhau.Value != null)
                kh.ChietKhau = (decimal)calcthemchietkhau.Value;
            else
                kh.ChietKhau = '0';

            if (calcthemgioihanno.Value != null)
                kh.GioiHanNo = (decimal)calcthemgioihanno.Value;
            else
                kh.GioiHanNo = '0';
            if (calcThemNOHienTai.Value != null)
                kh.NoHienTai = (decimal)calcThemNOHienTai.Value;
            else
                kh.NoHienTai = '0';
            kh.NickSkype = txtThemSkypeKhachHang.Text;
            kh.NickYaHoo = txtThemYahooKhachHang.Text;
            if (CkThemConQuanLy.Checked == true)
                kh.ConQuanLyKhachHang = true;
            else
                kh.ConQuanLyKhachHang = false;
            bus.SuaKhachhang_Bus(kh);
        }

        private void btnkhuvuc_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemKhuVuc KhuVuc = new DanhMuc.frmThemKhuVuc();
            KhuVuc.ShowDialog();
            frmSuaKhachHang_Load(sender, e);
        }

     
    }
}
