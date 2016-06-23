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
    public partial class frmSuaDonViTinh : Form
    {
        DonViTinhBus bus = new DonViTinhBus();
        public frmSuaDonViTinh(DONVITINH dvt)
        {
            InitializeComponent();
            txtMa.Text = dvt.MaDonVi;
            txtTen.Text = dvt.TenDonVi;
            txtGhiChu.Text = dvt.GhiChu;
            if (dvt.ConQuanLyDonViTinh == true)
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

            DONVITINH dvt = new DONVITINH();
            dvt.MaDonVi = txtMa.Text;
            dvt.TenDonVi = txtTen.Text;
            dvt.GhiChu = txtGhiChu.Text;
            if (CkSuaConQuanLy.Checked == true)
                dvt.ConQuanLyDonViTinh = true;
            else
                dvt.ConQuanLyDonViTinh = false;
          
            bus.SuaDonViTinh_Bus(dvt);
        }
    }
}
