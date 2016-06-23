using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class frmThemNguoiDungHeThong : Form
    {
        public frmThemNguoiDungHeThong()
        {
            InitializeComponent();
        }

        private void resourcesTree1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
