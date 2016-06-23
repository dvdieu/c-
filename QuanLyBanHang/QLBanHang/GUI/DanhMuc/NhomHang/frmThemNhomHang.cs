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
    public partial class frmThemNhomHang : Form
    {
        NhomHangBus bus = new NhomHangBus();
        public frmThemNhomHang()
        {
            InitializeComponent();
        }

        private void btnSuaClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemLuu_Click(object sender, EventArgs e)
        {
            NHOMHANG nh = new NHOMHANG();
            nh.MaNhomHang = txtMa.Text;
            nh.TenNhomHang = txtTen.Text;
            nh.GhiChu = txtGhiChu.Text;
            if (CkThemConQuanLy.Checked == true)
                nh.ConQuanLyDonNhomHang = true;
            else
                nh.ConQuanLyDonNhomHang = false;
            bus.ThemNhomHang_Bus(nh);
        }
    }
}
