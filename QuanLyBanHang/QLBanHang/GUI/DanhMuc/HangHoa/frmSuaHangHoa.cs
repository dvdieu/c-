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
    public partial class frmSuaHangHoa : Form
    {
        KhoHangBus buskho = new KhoHangBus();
        NhomHangBus busnhom = new NhomHangBus();
        DonViTinhBus busdon = new DonViTinhBus();
        NhaCungCapBus busncc = new NhaCungCapBus();
        HangHoaBus bus = new HangHoaBus();
        public frmSuaHangHoa(HANGHOA hh)
        {
            InitializeComponent();
            txtthemmahang.Text = hh.MaHangHoa;
            txtthemtenhang.Text = hh.TenHangHoa;
            cboxthemloai.Text = hh.LoaiHang;
            lookUpthemphanloai.EditValue = hh.MaNhomHang;
            lookUpthemdonvi.EditValue = hh.MaDonVi;
            txtthemxuatxu.Text = hh.XuatXu;
            lookUpthemnhacungcap.EditValue = hh.MaNhaCungCap;
            LookUpthemkhomacdinh.EditValue = hh.MaKho;
            txtthemvachnhasx.Text = hh.VachNhaSX;
            calcthemtonhientai.Value = (int)hh.TonKhoHienTai;
            calcthemtonkho.Value = (int)hh.TonKhoToiThieu;

            calcthemgiamua.Value = (decimal)hh.GiaMua;
            calcthemgiabanle.Value = (decimal)hh.GiaBanLe;
            calcthemgiabansi.Value = (decimal)hh.GiaBanSi;
            if (hh.ConQuanLyHangHoa == true)
                CkthemConQuanLy.Checked = true;
            else
                CkthemConQuanLy.Checked = false;
        }

        private void btnSuaClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSuaHangHoa_Load(object sender, EventArgs e)
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
            hh.TonKhoToiThieu = (int)calcthemtonkho.Value;

            hh.GiaMua = (decimal)calcthemgiamua.Value;
            hh.GiaBanLe = (decimal)calcthemgiabanle.Value;
            hh.GiaBanSi = (decimal)calcthemgiabansi.Value;
            if (CkthemConQuanLy.Checked == true)
                hh.ConQuanLyHangHoa = true;
            else
                hh.ConQuanLyHangHoa = false;

            bus.SuaHangHoa_Bus(hh);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemNhomHang Nhom = new DanhMuc.frmThemNhomHang();
            Nhom.ShowDialog();
            frmSuaHangHoa_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemKhoHang kho = new DanhMuc.frmThemKhoHang();
            kho.ShowDialog();
            frmSuaHangHoa_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemDonViTinh donvi = new DanhMuc.frmThemDonViTinh();
            donvi.ShowDialog();
            frmSuaHangHoa_Load(sender, e);
        }

        private void btnbophan_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemNhaCungCap cungcap = new DanhMuc.frmThemNhaCungCap();
            cungcap.ShowDialog();
            frmSuaHangHoa_Load(sender, e);
        }
    }
}
