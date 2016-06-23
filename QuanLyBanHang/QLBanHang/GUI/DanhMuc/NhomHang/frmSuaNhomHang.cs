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
    public partial class frmSuaNhomHang : Form
    {
        NhomHangBus bus = new NhomHangBus();
        public frmSuaNhomHang(NHOMHANG nh)
        {
            InitializeComponent();

            txtMa.Text = nh.MaNhomHang;
            txtTen.Text = nh.TenNhomHang;
            txtGhiChu.Text = nh.GhiChu;
            if (nh.ConQuanLyDonNhomHang == true)
                CkSuaConQuanLy.Checked = true;
            else
                CkSuaConQuanLy.Checked = false;
           
        }

        private void btnSuaClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSuaLuu_Click(object sender, EventArgs e)
        {
            NHOMHANG nh = new NHOMHANG();
            nh.MaNhomHang = txtMa.Text;
            nh.TenNhomHang = txtTen.Text;
            nh.GhiChu = txtGhiChu.Text;
            if (CkSuaConQuanLy.Checked == true)
                nh.ConQuanLyDonNhomHang = true;
            else
                nh.ConQuanLyDonNhomHang = false;
          
            bus.SuaNhomHang_Bus(nh);
        }
    }
}
