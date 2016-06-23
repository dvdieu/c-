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
    public partial class frmThemTienTe : Form
    {
        TienTeBus bus = new TienTeBus();
        public frmThemTienTe()
        {
            InitializeComponent();
        }

        private void btnSuaClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSuaLuu_Click(object sender, EventArgs e)
        {
            TYGIA tg = new TYGIA();
             tg.MaTyGia = txtMa.Text;
             tg.TenTyGia = txtTen.Text;
             tg.TyGiaQuyDoi = calcQuydoi.Value;
            if (CkThemConQuanLy.Checked == true)
                tg.ConQuanLyDonTyGia = true;
            else
                tg.ConQuanLyDonTyGia = false;
             bus.ThemTyGia_Bus(tg);
        }
    }
}
