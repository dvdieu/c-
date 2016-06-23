using QLBanHang.BUS.DanhMuc.KhuVuc;
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
    public partial class frmSuaKhuVuc : Form
    {
        KhuVucBus bus = new KhuVucBus();
        public frmSuaKhuVuc(KHUVUC kv)
        {
            InitializeComponent();
            txtSuaMaKhuVuc.Text = kv.MaKhuVuc;
            txtSuaTenKhuVuc.Text = kv.TenKhuVuc;
            txtSuaGhiChuKhuVuc.Text = kv.GhiChu;
            if (kv.ConQuanLyKhuVuc == true)
                CkechSuaConQuanLyKhuVuc.Checked = true;
            else
                CkechSuaConQuanLyKhuVuc.Checked = false;
        }

        private void btnSuaClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSuaLuu_Click(object sender, EventArgs e)
        {
            KHUVUC kv = new KHUVUC();
            kv.MaKhuVuc = txtSuaMaKhuVuc.Text;
            kv.TenKhuVuc = txtSuaTenKhuVuc.Text;
            kv.GhiChu = txtSuaGhiChuKhuVuc.Text;
            if (CkechSuaConQuanLyKhuVuc.Checked == true)
                kv.ConQuanLyKhuVuc = true;
            else
                kv.ConQuanLyKhuVuc = false;
         
            bus.SuaKhuVuc_Bus(kv);
        }

        private void frmSuaKhuVuc_Load(object sender, EventArgs e)
        {

        }
    }
}
