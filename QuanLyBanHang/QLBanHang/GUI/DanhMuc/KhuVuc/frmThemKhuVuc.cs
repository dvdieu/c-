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
using QLBanHang.BUS.DanhMuc.KhuVuc;
using QLBanHang.BUS;

namespace QLBanHang.DanhMuc
{
    public partial class frmThemKhuVuc : Form
    {
        MaLuuBus makv = new MaLuuBus();
        KhuVucBus bus = new KhuVucBus();
        public frmThemKhuVuc()
        {
            InitializeComponent();

            txtThemMaKhuVuc.Text = KiemTang(makv.Formload_khuvucbus());
        }

        public string KiemTang(string chuoi)
        {
            string tam;
           
            string chuoi2 = chuoi.Substring(0, 1);
            string chuoi1 = chuoi.Substring(2);
            int i = Convert.ToInt32(chuoi1);
            i += 1;
            chuoi1 = Convert.ToString(i);
            if(i < 10)
                tam = chuoi2 +"00"+ chuoi1;
            else if(i< 100)
                tam = chuoi2 +"0"+ chuoi1;
            else
                tam = chuoi2 + chuoi1;
            return tam;
        }
        private void btnThemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemLuu_Click(object sender, EventArgs e)
        {
            
            KHUVUC kv = new KHUVUC();
            kv.MaKhuVuc = txtThemMaKhuVuc.Text;
            kv.TenKhuVuc = txtThemTenKhuVuc.Text;
            kv.GhiChu = txtThemGhiChuKhuVuc.Text;
            if (CkechThemConQuanLyKhuVuc.Checked == true)
                kv.ConQuanLyKhuVuc = true;
            else
                kv.ConQuanLyKhuVuc = false;
            bus.ThemKhuVuc_Bus(kv);
        }

        private void frmThemKhuVuc_Load(object sender, EventArgs e)
        {

        }
    }
}
