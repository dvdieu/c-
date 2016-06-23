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
    public partial class frmThemDonViTinh : Form
    {
        DonViTinhBus bus = new DonViTinhBus();
        public frmThemDonViTinh()
        {
            InitializeComponent();
        }

        private void btnSuaClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSuaLuu_Click(object sender, EventArgs e)
        {
            DONVITINH dvt = new DONVITINH();
            dvt.MaDonVi = txtMa.Text;
            dvt.TenDonVi = txtTen.Text;
            dvt.GhiChu = txtGhiChu.Text;
            if (CkThemConQuanLy.Checked  == true)
                dvt.ConQuanLyDonViTinh= true;
            else
                dvt.ConQuanLyDonViTinh = false;
            bus.ThemDonViTinh_Bus(dvt);
            // gọi ham bus
        }
    }
}
