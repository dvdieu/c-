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
    public partial class frmSuaBoPhan : Form
    {
        BoPhanBus bus = new BoPhanBus();
        public frmSuaBoPhan(BOPHAN bp)
        {
            InitializeComponent();
            txtMa.Text = bp.MaBoPhan;
            txtTen.Text = bp.TenBoPhan;
            txtGhiChu.Text = bp.GhiChu;
            if (bp.ConQuanLyBoPhan == true)
                CkSuaConQuanLy.Checked = true;
            else
                CkSuaConQuanLy.Checked = false;
            bus.SuaBoPhan_Bus(bp);
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
            if (CkSuaConQuanLy.Checked == true)
                bp.ConQuanLyBoPhan = true;
            else
                bp.ConQuanLyBoPhan = false;

            bus.SuaBoPhan_Bus(bp);
        }
    }
}
