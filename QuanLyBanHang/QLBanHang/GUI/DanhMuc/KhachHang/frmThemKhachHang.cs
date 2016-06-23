using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.Model;
using QLBanHang.BUS.DanhMuc;
using QLBanHang.BUS.DanhMuc.KhuVuc;

namespace QLBanHang.DanhMuc
{
    public partial class frmThemKhachHang : Form
    {
        KhachHangBus bus = new KhachHangBus();
        KhuVucBus buskv = new KhuVucBus();
        public frmThemKhachHang()
        {
            InitializeComponent();
          

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnThemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemLuu_Click(object sender, EventArgs e)
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
            kh.MaSoThue = txtsotheu.Text;
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
            bus.ThemKhachhang_Bus(kh);
            //// gọi lớp  buss
            
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            //gridthemkhuvuc
            lookUpkhuvuc.Properties.DataSource = buskv.Formload_khuvucbus();
            lookUpkhuvuc.Properties.DisplayMember = "MaKhuVuc";
            lookUpkhuvuc.Properties.ValueMember = "TenKhuVuc";
          
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnkhuvuc_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemKhuVuc KhuVuc = new DanhMuc.frmThemKhuVuc();
            KhuVuc.ShowDialog();
            frmThemKhachHang_Load(sender, e);
        }
    }
}
