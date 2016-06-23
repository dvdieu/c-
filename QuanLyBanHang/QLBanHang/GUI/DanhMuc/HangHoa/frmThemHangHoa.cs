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
    public partial class frmThemHangHoa : Form
    {
        KhoHangBus buskho =new KhoHangBus();
        NhomHangBus busnhom = new NhomHangBus();
        DonViTinhBus busdon = new DonViTinhBus();
        NhaCungCapBus busncc = new NhaCungCapBus();
        HangHoaBus bus = new HangHoaBus();
        public frmThemHangHoa()
        {
            InitializeComponent();
        }

        private void btnLichSuGiaoDich_Click(object sender, EventArgs e)
        {
            Form HangHoa = new frmLichSuGiaoHang();
            HangHoa.ShowDialog();
        }

        private void btnSuaClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSuaLuu_Click(object sender, EventArgs e)
        {
            HANGHOA hh = new HANGHOA();
            hh.MaHangHoa = txtthemmahang.Text;
            hh.TenHangHoa = txtthemtenhang.Text;
            hh.LoaiHang = cboxthemloai.Text;
            hh.MaNhomHang = lookUpthemphanloai.GetColumnValue("MaNhomHang").ToString();
            hh.MaDonVi = lookUpthemdonvi.GetColumnValue("MaDonVi").ToString();
            hh.XuatXu = txtthemxuatxu.Text;
            hh.MaNhaCungCap = lookUpthemnhacungcap.GetColumnValue("MaNhaCungCap").ToString();
            hh.MaKho = LookUpthemkhomacdinh.GetColumnValue("MaKho").ToString();
            hh.VachNhaSX = txtthemvachnhasx.Text;
            hh.TonKhoHienTai = (int)calcthemtonhientai.Value;
            hh.TonKhoToiThieu =(int) calcthemtonkho.Value;
            
            hh.GiaMua = (decimal)calcthemgiamua.Value;
            hh.GiaBanLe = (decimal)calcthemgiabanle.Value;
            hh.GiaBanSi = (decimal)calcthemgiabansi.Value;
            if (CkthemConQuanLy.Checked == true)
                hh.ConQuanLyHangHoa = true;
            else
                hh.ConQuanLyHangHoa = false;

            bus.ThemHangHoa_Bus(hh);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemKhoHang kho = new DanhMuc.frmThemKhoHang();
            kho.ShowDialog();
            frmThemHangHoa_Load(sender,e);
        }

        private void frmThemHangHoa_Load(object sender, EventArgs e)
        {
            LookUpthemkhomacdinh.Properties.DataSource = buskho.Formload_khoHangbus();
            LookUpthemkhomacdinh.Properties.DisplayMember = "MaKho";
            LookUpthemkhomacdinh.Properties.ValueMember = "TenKho";
            // donvi
            lookUpthemdonvi.Properties.DataSource = busdon.Formload_DoViTinhbus();
            lookUpthemdonvi.Properties.DisplayMember = "MaDonVi";
            lookUpthemdonvi.Properties.ValueMember = "TenDonVi";
            //nha 
            lookUpthemnhacungcap.Properties.DataSource = busncc.Formload_NhaCungCapbus();
            lookUpthemnhacungcap.Properties.DisplayMember = "MaNhaCungCap";
            lookUpthemnhacungcap.Properties.ValueMember = "TenNhaCungCap";
            //nhom
            lookUpthemphanloai.Properties.DataSource = busnhom.Formload_NhomHangbus();
            lookUpthemphanloai.Properties.DisplayMember = "MaNhomHang";
            lookUpthemphanloai.Properties.ValueMember = "TenNhomHang";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemNhomHang Nhom = new DanhMuc.frmThemNhomHang();
            Nhom.ShowDialog();
            frmThemHangHoa_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemDonViTinh donvi = new DanhMuc.frmThemDonViTinh();
            donvi.ShowDialog();
            frmThemHangHoa_Load(sender, e);
        }

        private void btnbophan_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemNhaCungCap cungcap = new DanhMuc.frmThemNhaCungCap();
            cungcap.ShowDialog();
            frmThemHangHoa_Load(sender, e);
        }
    }
}
