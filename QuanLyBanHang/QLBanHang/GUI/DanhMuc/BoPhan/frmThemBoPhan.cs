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
    public partial class frmThemBoPhan : Form
    {
        BoPhanBus bus = new BoPhanBus();
        public frmThemBoPhan()
        {
            InitializeComponent();
        }

        private void btnSuaClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSuaLuu_Click(object sender, EventArgs e)
        {
            BOPHAN bp = new BOPHAN();
            bp.MaBoPhan = txtMa.Text;
            bp.TenBoPhan = txtTen.Text;
            bp.GhiChu = txtGhiChu.Text;
            if (CkThemConQuanLy.Checked == true)
                bp.ConQuanLyBoPhan = true;
            else
                bp.ConQuanLyBoPhan = false;

            bus.ThemBoPhan_Bus(bp);
        }
    }
}
