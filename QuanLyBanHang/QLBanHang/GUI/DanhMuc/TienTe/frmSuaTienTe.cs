using QLBanHang.Model;
using QLBanHang.BUS.DanhMuc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Model;

namespace QLBanHang.DanhMuc
{
    
    public partial class frmSuaTienTe : Form
    {
        TienTeBus bus = new TienTeBus();
        public frmSuaTienTe(TYGIA tg)
        {
            InitializeComponent();
            txtMa.Text = tg.MaTyGia;
            txtTen.Text = tg.TenTyGia;
          calcquydoi.Value = (decimal)tg.TyGiaQuyDoi;
          if (tg.ConQuanLyDonTyGia == true)
              CkSuaConQuanLy.Checked = true;
          else
              CkSuaConQuanLy.Checked = false;
          bus.SuaTyGia_Bus(tg);
           
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
            tg.TyGiaQuyDoi = (decimal)calcquydoi.Value;
            if (CkSuaConQuanLy.Checked == true)
                tg.ConQuanLyDonTyGia = true;
            else
                tg.ConQuanLyDonTyGia = false;
        }
    }
}
