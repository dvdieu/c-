using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.Model;
using DevExpress.XtraGrid.Columns;
using QuanLyBanHang.Model.ChucNang;
using QuanLyBanHang.BUS.ChucNang;

namespace QLBanHang
{
    public partial class PhieuBanHangControl : UserControl
    {

        public PhieuBanHangControl()
        {
            InitializeComponent();
            Load += PhieuBanHangControl_Load;
        }
        private void LoadKhachHang()
        {
            KhachHangBus bus = new KhachHangBus();
            List<KhachHang> list = bus.LoadDanhSachKH();
            lupKhachHang.Properties.DataSource = list;
            lupKhachHang.Properties.DisplayMember = "TenKhachHang";
            lupKhachHang.Properties.ValueMember = "MaKhachHang";

            cbMaKhachHang.Properties.DataSource = list;
            cbMaKhachHang.Properties.DisplayMember = "TenKhachHang";
            cbMaKhachHang.Properties.ValueMember = "MaKhachHang";
        }
        private void LoadMaKhachHang()
        {
            KhachHangBus bus = new KhachHangBus();
            List<string> list = bus.LoadMaKH();
            
            cbMaKhachHang.Properties.DataSource = list;
            cbMaKhachHang.Properties.DisplayMember = "MaKhachHang";
            cbMaKhachHang.Properties.ValueMember = "MaKhachHang";
        }
        private void PhieuBanHangControl_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            //LoadMaKhachHang();
        }

        
    }
}
