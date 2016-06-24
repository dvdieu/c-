using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.DanhMuc;
using QLBanHang.HeThong;
using QLBanHang.ChucNang;
using QLBanHang.BUS.DanhMuc;
using QLBanHang.Model;
using QLBanHang.BUS.DanhMuc.KhuVuc;
using QuanLyBanHang.Model;

namespace QLBanHang
{
    public partial class frmPhanMemQuanLyBanHang : Form
    {
        KhuVucBus buskv = new KhuVucBus();
        KhachHangBus buskh = new KhachHangBus();
        DonViTinhBus busdvt = new DonViTinhBus();
        NhomHangBus busNh = new NhomHangBus();
        TienTeBus bustt = new TienTeBus();
        BoPhanBus busbp = new BoPhanBus();
        NhaCungCapBus busncc = new NhaCungCapBus();
        KhoHangBus buxkhoh = new KhoHangBus();
        NhanVienBus busnv = new NhanVienBus();
        HangHoaBus bushh = new HangHoaBus();
        public frmPhanMemQuanLyBanHang()
        {
            InitializeComponent();
        }

        //private void TabPhanQuyen_CloseButtonClick(object sender, EventArgs e)
        //{
        //    XtraTabControl TabControl = (XtraTabControl)sender;
        //    int i = TabControl.SelectedTabPageIndex;
        //    TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
        //    TabControl.SelectedTabPageIndex = i - 1;
        //}

        private void btnhotro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btnvideohdan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Hệ Thống
        private void KetThuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void ThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTinHeThong tt = new frmThongTinHeThong();
            tt.ShowDialog();
        }
        private void PhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TabPhanQuyen.PageVisible = true;
            AllTab.SelectedTabPage = TabPhanQuyen;
        }

        private void DoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhauHeThong fr = new frmDoiMatKhauHeThong();
            fr.ShowDialog();
        }
        private void NhatKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TabNhatKy.PageVisible = true;
            AllTab.SelectedTabPage = TabNhatKy;
        }
        private void SaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSaoLuuHeThong fr = new frmSaoLuuHeThong();
            fr.ShowDialog();
        }

        private void PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhucHoiHeThong fr = new frmPhucHoiHeThong();
            fr.ShowDialog();
        }
        //_______________________Phân Quyền
        private void btAddVaiTro_Click(object sender, EventArgs e)
        {
            frmThemVaiTro fr = new frmThemVaiTro();
            fr.ShowDialog();
        }

        private void btAddNguoiDung_Click(object sender, EventArgs e)
        {
            frmThemNguoiDungHeThong fr = new frmThemNguoiDungHeThong();
            fr.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            frmSuaHeThong fr = new frmSuaHeThong();
            fr.ShowDialog();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            TabPhanQuyen.PageVisible = false;
        }
        //____________________Nhật Ký
        private void CloseNhatKy_Click(object sender, EventArgs e)
        {
            TabNhatKy.PageVisible = false;
        }


        //

        // Phần Danh Mục
        private void tabDonViTinh_Paint(object sender, PaintEventArgs e)
        {

        }
        // Thêm vô nek 

        private void btnThemKV_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemKhuVuc KhuVuc = new DanhMuc.frmThemKhuVuc();
            KhuVuc.ShowDialog();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            KHUVUC kv = new KHUVUC(); // lưu qua  hiển thị lên testbox
            kv.MaKhuVuc = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKhuVuc");
            kv.TenKhuVuc = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenKhuVuc");
            kv.GhiChu = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GhiChu");
            kv.ConQuanLyKhuVuc = (bool)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ConQuanLyKhuVuc");
            frmSuaKhuVuc KhuVuc = new frmSuaKhuVuc(kv);
            KhuVuc.ShowDialog();

        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            KHUVUC kv = new KHUVUC();
            kv.MaKhuVuc = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKhuVuc");

            buskv.XoaKhuVuc_Bus(kv);
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemKhachHang KhachHang = new DanhMuc.frmThemKhachHang();
            KhachHang.ShowDialog();
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {

            KHACHHANG kh = new KHACHHANG(); // lưu qua  hiển thị lên testbox
            kh.MaKhachHang = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "MaKhachHang");
            kh.MaKhuVuc = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "MaKhuVuc");
            // dư  rôi     kh.MaSoThe = (string)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GhiChu");
            kh.TenKhachHang = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "TenKhachHang");
            kh.NguoiLienHe = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "NguoiLienHe");
            kh.DiaChi = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "DiaChi");
            kh.DienThoai = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "DienThoai");
            kh.DiDong = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "DiDong");
            kh.Fax = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "Fax");
            kh.Email = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "Email");
            kh.Website = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "Website");
            kh.SoTaiKhoan = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "SoTaiKhoan");
            kh.TenNganHang = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "TenNganHang");
            kh.MaSoThue = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "MaSoThue");

            kh.ChietKhau = (decimal)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "ChietKhau");
            kh.GioiHanNo = (decimal)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "GioiHanNo");
            kh.NoHienTai = (decimal)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "NoHienTai");

            kh.NickSkype = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "NickSkype");
            kh.NickYaHoo = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "NickYaHoo");
            kh.ConQuanLyKhachHang = (bool)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "ConQuanLyKhachHang");
            //kh.ConQuanLyKhachHang = (bool)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "ConQuanLyKhachHang");

            DanhMuc.frmSuaKhachHang KhachHang = new DanhMuc.frmSuaKhachHang(kh);
            KhachHang.ShowDialog();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {

            KHACHHANG kh = new KHACHHANG();
            kh.MaKhachHang = (string)grid_khachhang.GetRowCellValue(grid_khachhang.FocusedRowHandle, "MaKhachHang");

            buskh.XoaKhachhang_Bus(kh);
        }

        

        private void simpleButton72_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemTienTe TienTe = new DanhMuc.frmThemTienTe();
            TienTe.ShowDialog();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemNhanVien NV = new DanhMuc.frmThemNhanVien();
            NV.ShowDialog();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN(); // lưu qua  hiển thị lên testbox
            nv.MaNhanVien = (string)gridView8.GetRowCellValue(gridView8.FocusedRowHandle, "MaNhanVien");
            nv.HoTen = (string)gridView8.GetRowCellValue(gridView8.FocusedRowHandle, "HoTen");
            nv.Email = (string)gridView8.GetRowCellValue(gridView8.FocusedRowHandle, "Email");
            nv.DienThoai = (string)gridView8.GetRowCellValue(gridView8.FocusedRowHandle, "DienThoai");
            nv.DiDong = (string)gridView8.GetRowCellValue(gridView8.FocusedRowHandle, "DiDong");
            nv.DiaChi = (string)gridView8.GetRowCellValue(gridView8.FocusedRowHandle, "DiaChi");
            nv.ChucVu = (string)gridView8.GetRowCellValue(gridView8.FocusedRowHandle, "ChucVu");
            nv.MaBoPhan = (string)gridView8.GetRowCellValue(gridView8.FocusedRowHandle, "MaBoPhan");
            nv.QuanLy = (string)gridView8.GetRowCellValue(gridView8.FocusedRowHandle, "QuanLy ");

            nv.ConQuanLyNhanVien = (bool)gridView8.GetRowCellValue(gridView8.FocusedRowHandle, "ConQuanLyNhanVien");
            DanhMuc.frmSuaNhanVien NV = new DanhMuc.frmSuaNhanVien(nv);
            NV.ShowDialog();
        }

        private void btnThemBoPhan_Click(object sender, EventArgs e)
        {
            Form BP = new frmThemBoPhan();
            BP.ShowDialog();
        }

        private void btnSuaBoPhan_Click(object sender, EventArgs e)
        {
            BOPHAN bp = new BOPHAN(); // lưu qua  hiển thị lên testbox
            bp.MaBoPhan = (string)gridView7.GetRowCellValue(gridView7.FocusedRowHandle, "MaBoPhan");
            bp.TenBoPhan = (string)gridView7.GetRowCellValue(gridView7.FocusedRowHandle, "TenBoPhan");
            bp.GhiChu = (string)gridView7.GetRowCellValue(gridView7.FocusedRowHandle, "GhiChu");
            bp.ConQuanLyBoPhan = (bool)gridView7.GetRowCellValue(gridView7.FocusedRowHandle, "ConQuanLyBoPhan");
            Form BP = new frmSuaBoPhan(bp);
            BP.ShowDialog();
        }

        private void TyGia_Click(object sender, EventArgs e)
        {
            TYGIA tg = new TYGIA(); // lưu qua  hiển thị lên testbox
            tg.MaTyGia = (string)gridView6.GetRowCellValue(gridView6.FocusedRowHandle, "MaTyGia");
            tg.TenTyGia = (string)gridView6.GetRowCellValue(gridView6.FocusedRowHandle, "TenTyGia");
            tg.TyGiaQuyDoi = (decimal)gridView6.GetRowCellValue(gridView6.FocusedRowHandle, "TyGiaQuyDoi");
            tg.ConQuanLyDonTyGia = (bool)gridView6.GetRowCellValue(gridView6.FocusedRowHandle, "ConQuanLyDonTyGia");
            Form TienTe = new frmSuaTienTe(tg);
            TienTe.ShowDialog();
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            Form HangHoa = new frmThemHangHoa();
            HangHoa.ShowDialog();
        }

        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            HANGHOA hh = new HANGHOA(); // lưu qua  hiển thị lên testbox
            hh.MaHangHoa = (string)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "MaHangHoa");
            hh.MaKho = (string)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "MaKho");
            hh.MaNhaCungCap = (string)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "MaNhaCungCap");
            hh.MaDonVi = (string)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "MaDonVi");
            hh.LoaiHang = (string)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "LoaiHang");
            hh.GiaMua = (decimal)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "GiaMua");
            hh.GiaBanSi = (decimal)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "GiaBanSi");
            hh.GiaBanLe = (decimal)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "GiaBanLe");
            hh.VachNhaSX = (string)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "VachNhaSX");
            hh.XuatXu = (string)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "XuatXu");
            hh.TonKhoToiThieu = (int)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "TonKhoToiThieu");
            hh.TonKhoHienTai = (int)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "TonKhoHienTai");
            hh.TenHangHoa = (string)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "TenHangHoa");
            hh.MaNhomHang = (string)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "MaNhomHang");
            hh.ConQuanLyHangHoa = (bool)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "ConQuanLyHangHoa");

            DanhMuc.frmSuaHangHoa HangHoa = new DanhMuc.frmSuaHangHoa(hh);
            HangHoa.ShowDialog();
        }

        private void btnThemnhomHang_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemNhomHang NhomHang = new DanhMuc.frmThemNhomHang();
            NhomHang.ShowDialog();
        }

        private void btnSuanhomHang_Click(object sender, EventArgs e)
        {
            NHOMHANG nh = new NHOMHANG(); // lưu qua  hiển thị lên testbox
            nh.MaNhomHang = (string)gridView4.GetRowCellValue(gridView4.FocusedRowHandle, "MaNhomHang");
            nh.TenNhomHang = (string)gridView4.GetRowCellValue(gridView4.FocusedRowHandle, "TenNhomHang");
            nh.GhiChu = (string)gridView4.GetRowCellValue(gridView4.FocusedRowHandle, "GhiChu");
            nh.ConQuanLyDonNhomHang = (bool)gridView4.GetRowCellValue(gridView4.FocusedRowHandle, "ConQuanLyDonNhomHang");

            DanhMuc.frmSuaNhomHang NhomHang = new DanhMuc.frmSuaNhomHang(nh);
            NhomHang.ShowDialog();
        }

        private void btnThemDonVitinh_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemDonViTinh DonViVitinh = new DanhMuc.frmThemDonViTinh();
            DonViVitinh.ShowDialog();
        }

        private void btnSuaDonViTinh_Click(object sender, EventArgs e)
        {

            DONVITINH dvt = new DONVITINH(); // lưu qua  hiển thị lên testbox
            dvt.MaDonVi = (string)gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "MaDonVi");
            dvt.TenDonVi = (string)gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "TenDonVi");
            dvt.GhiChu = (string)gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "GhiChu");
            dvt.ConQuanLyDonViTinh = (bool)gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "ConQuanLyDonViTinh");
            DanhMuc.frmSuaDonViTinh DonViVitinh = new DanhMuc.frmSuaDonViTinh(dvt);
            DonViVitinh.ShowDialog();
        }

        private void simpleButton34_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemKhoHang Khohang = new DanhMuc.frmThemKhoHang();
            Khohang.ShowDialog();
        }

        private void btnSuaKhoHnag_Click(object sender, EventArgs e)
        {

            KHOHANG kh = new KHOHANG(); // lưu qua  hiển thị lên testbox
            kh.MaKho = (string)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MaKho");
            kh.TenKho = (string)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TenKho");
            kh.DiaChi = (string)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DiaChi");
            kh.GhiChu = (string)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "GhiChu");
            kh.Fax = (string)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Fax");
            kh.DienThoai = (string)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DienThoai");
            kh.Email = (string)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Email");
            kh.KyHieu = (string)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "KyHieu");
            kh.NguoiQuanLy = (string)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NguoiQuanLy");
            kh.NguoiLienHe = (string)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "NguoiLienHe");
            kh.ConQuanLyKhoHang = (bool)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ConQuanLyKhoHang");
            DanhMuc.frmSuaKhoHang Khohang = new DanhMuc.frmSuaKhoHang(kh);
            Khohang.ShowDialog();
        }

        private void btnThemNhaCC_Click(object sender, EventArgs e)
        {
            DanhMuc.frmThemNhaCungCap NhaCC = new DanhMuc.frmThemNhaCungCap();
            NhaCC.ShowDialog();
        }

        private void btnSuaNhaCC_Click(object sender, EventArgs e)
        {

            NHACUNGCAP ncc = new NHACUNGCAP(); // lưu qua  hiển thị lên testbox
            ncc.MaNhaCungCap = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "MaNhaCungCap");
            ncc.TenNhaCungCap = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "TenNhaCungCap");
            ncc.NguoiLienHe = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "NguoiLienHe");
            ncc.ChucVu = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "ChucVu");
            ncc.DiaChi = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "DiaChi");
            ncc.DienThoai = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "DienThoai");
            ncc.DiDong = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "DiDong");
            ncc.Fax = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "Fax");
            ncc.Email = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "Email");
            ncc.Website = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "SoTaiKhoan");
            ncc.SoTaiKhoan = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "Fax");
            ncc.TenNganHang = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "TenNganHang");
            ncc.MaSoThue = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "MaSoThue");
            ncc.MaKhuVuc = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "MaKhuVuc");

            ncc.NoHienTai = (decimal)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "NoHienTai");
            ncc.ChietKhau = (decimal)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "ChietKhau");
            ncc.GioiHanNo = (decimal)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "GioiHanNo");

            ncc.ConQuanLyNhaCungCap = (bool)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "ConQuanLyNhaCungCap");
            DanhMuc.frmSuaNhaCungCap NhaCC = new DanhMuc.frmSuaNhaCungCap(ncc);
            NhaCC.ShowDialog();
        }

        private void KhuVuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabKhuVuc.PageVisible = true;
            AllTab.SelectedTabPage = tabKhuVuc;
            grid_khuvuc.DataSource = buskv.Formload_khuvucbus();
        }

        private void tabKhuVuc_Paint(object sender, PaintEventArgs e)
        {
            //tẹndoentity con = new đaentyty()
            //tengridcontrol.datasuoce = con.tenbang.toliss();
        }

        private void AllTab_CloseButtonClick(object sender, EventArgs e)
        {
            AllTab.SelectedTabPage.PageVisible = false;
        }

        // khách hàng__________________
        private void KhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabKhachHang.PageVisible = true;
            AllTab.SelectedTabPage = tabKhachHang;
            grrid_khachhang.DataSource = buskh.Formload_khachhangbus();
        }



        private void NhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabNhacc.PageVisible = true;
            AllTab.SelectedTabPage = tabNhacc;
            grid_nhacungcap.DataSource = busncc.Formload_NhaCungCapbus();

        }

        private void KhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabKhoHang.PageVisible = true;
            AllTab.SelectedTabPage = tabKhoHang;
            grid_khohang.DataSource = buxkhoh.Formload_khoHangbus();
        }

        private void DonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabDonViTinh.PageVisible = true;
            AllTab.SelectedTabPage = tabDonViTinh;

            grid_donvitinh.DataSource = busdvt.Formload_DoViTinhbus();

            ///,,,,,,,
        }

        private void NhomHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabNhomHang.PageVisible = true;
            AllTab.SelectedTabPage = tabNhomHang;
            grid_nhomhang.DataSource = busNh.Formload_NhomHangbus();
        }

        private void HangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabHangHoa.PageVisible = true;

            AllTab.SelectedTabPage = tabHangHoa;

            grid_hanghoa.DataSource = bushh.Formload_HangHoabus();

        }

        private void InMaVach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabInMaVach.PageVisible = true;
            AllTab.SelectedTabPage = tabInMaVach;
        }

        private void TiGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TabTyGia.PageVisible = true;
            AllTab.SelectedTabPage = TabTyGia;
            grid_tygia.DataSource = bustt.Formload_TyGiabus();


        }

        private void BoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabbophan.PageVisible = true;
            AllTab.SelectedTabPage = tabbophan;
            grid_bophan.DataSource = busbp.Formload_khachhangbus();
        }

        private void NhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabNhanVien.PageVisible = true;
            AllTab.SelectedTabPage = tabNhanVien;
            grid_nhanvien.DataSource = busnv.Formload_NhanVienbus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            tabKhuVuc.PageVisible = false;
        }

        private void btnDongtabKHang_Click(object sender, EventArgs e)
        {
            tabKhachHang.PageVisible = false;
        }

        private void btnDongtabNCC_Click(object sender, EventArgs e)
        {
            tabNhacc.PageVisible = false;
        }

        private void btnDongtabKH_Click(object sender, EventArgs e)
        {
            tabKhoHang.PageVisible = false;
        }

        private void btnDongtabDVT_Click(object sender, EventArgs e)
        {
            tabDonViTinh.PageVisible = false;
        }

        private void btnDongtabNH_Click(object sender, EventArgs e)
        {
            tabNhomHang.PageVisible = false;
        }

        private void btnDongtabHH_Click(object sender, EventArgs e)
        {
            tabHangHoa.PageVisible = false;
        }

        private void toolDong_Click(object sender, EventArgs e)
        {
            tabInMaVach.PageVisible = false;
        }

        private void btnDongtabTG_Click(object sender, EventArgs e)
        {
            TabTyGia.PageVisible = false;
        }

        private void btnDongtabBp_Click(object sender, EventArgs e)
        {
            tabbophan.PageVisible = false;
        }

        private void btnDongtabNV_Click(object sender, EventArgs e)
        {
            tabNhanVien.PageVisible = false;
        }

        private void tabInMaVach_Paint(object sender, PaintEventArgs e)
        {

        }


        // Phần chức Năng 

        private void btnMuaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabMuaHang.PageVisible = true;
            AllTab.SelectedTabPage = tabMuaHang;
            pnMain.Controls.Clear();
            PhieuNhapHangControl cont = new PhieuNhapHangControl();
            cont.Show();
            cont.Dock = DockStyle.Fill;
            pnMain.Controls.Add(cont);
        }

       

        private void btnTonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabTonKho.PageVisible = true;
            AllTab.SelectedTabPage = tabTonKho;
            pnMain.Controls.Clear();
            TonKhoControl control = new TonKhoControl();
            control.Show();
            control.Dock = DockStyle.Fill;
            pnMain.Controls.Add(control);
        }

        private void btnChuyenKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabChuyenKho.PageVisible = true;
            AllTab.SelectedTabPage = tabChuyenKho;
        }

        private void btnNSDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabSoDuDauKy.PageVisible = true;
            AllTab.SelectedTabPage = tabSoDuDauKy;
        }

        private void btnThuTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabThuTien.PageVisible = true;
            AllTab.SelectedTabPage = tabThuTien;
        }

        private void btnTraTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabPhieuChi.PageVisible = true;
            AllTab.SelectedTabPage = tabPhieuChi;
        }

        private void btnBCKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabBCTH.PageVisible = true;
            AllTab.SelectedTabPage = tabBCTH;
        }

        private void btnBCBH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabBCBH.PageVisible = true;
            AllTab.SelectedTabPage = tabBCBH;
        }

        private void btnChungTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabChungTu.PageVisible = true;
            AllTab.SelectedTabPage = tabChungTu;
        }
        // su ly Mua Hang
        private void btnHangHoa_MuaHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmHangHoa hh = new frmHangHoa();
            hh.ShowDialog();
        }

        private void btnKhachHang_MuaHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.ShowDialog();
        }

        private void btnKhoHang_MuaHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKhoHang kh = new frmKhoHang();
            kh.ShowDialog();
        }
        // sử lý tap Bán Hàng
        private void btnHangHoa_BanHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmHangHoa hh = new frmHangHoa();
            hh.ShowDialog();
        }

        // __________________________Khách Hàng
        private void btnKhachHang_BanHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.ShowDialog();
        }


        private void btnKhoHang_BanHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKhoHang kh = new frmKhoHang();
            kh.ShowDialog();
        }
        //  CHuyển Kho
        private void btnHangHoa_ChuyenKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmHangHoa hh = new frmHangHoa();
            hh.ShowDialog();
        }

        private void btnKhoHang_ChuyenKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKhoHang kh = new frmKhoHang();
            kh.ShowDialog();
        }

        private void btnNhanVien_ChuyenKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemNhanVien nv = new frmThemNhanVien();
            nv.ShowDialog();
        }

        private void btnxuat_khuvuc_Click(object sender, EventArgs e)
        {

        }
        private void btnnaplai_khuvuc_Click(object sender, EventArgs e)
        {
            grid_khuvuc.DataSource = buskv.Formload_khuvucbus();
        }

        private void grrid_khachhang_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaDonViTinh_Click(object sender, EventArgs e)
        {
            DONVITINH dvt = new DONVITINH();
            dvt.MaDonVi = (string)gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "MaDonVi");
            busdvt.XoaDoViTinh_Bus(dvt);
        }

        private void simpleButton37_Click(object sender, EventArgs e)
        {
            grid_donvitinh.DataSource = busdvt.Formload_DoViTinhbus();
        }

        private void btnXoanhomHang_Click(object sender, EventArgs e)
        {
            NHOMHANG nh = new NHOMHANG();
            nh.MaNhomHang = (string)gridView4.GetRowCellValue(gridView4.FocusedRowHandle, "MaNhomHang");
            busNh.XoaNhomHang_Bus(nh);
        }

        private void simpleButton44_Click(object sender, EventArgs e)
        {
            grid_nhomhang.DataSource = busNh.Formload_NhomHangbus();
        }

        private void btnNaplai_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaTyGia_Click(object sender, EventArgs e)
        {
            TYGIA tg = new TYGIA(); // lưu qua  hiển thị lên testbox
            tg.MaTyGia = (string)gridView6.GetRowCellValue(gridView6.FocusedRowHandle, "MaTyGia");
            bustt.XoaTyGia_Bus(tg);
        }

        private void simpleButton63_Click(object sender, EventArgs e)
        {
            grid_bophan.DataSource = busbp.Formload_khachhangbus();
        }

        private void btnXoaBoPhan_Click(object sender, EventArgs e)
        {
            BOPHAN bp = new BOPHAN(); // lưu qua  hiển thị lên testbox
            bp.MaBoPhan = (string)gridView7.GetRowCellValue(gridView7.FocusedRowHandle, "MaBoPhan");
            busbp.XoaBoPhan_Bus(bp);
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            grrid_khachhang.DataSource = buskh.Formload_khachhangbus();
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            grid_nhacungcap.DataSource = busncc.Formload_NhaCungCapbus();
        }

        private void btnXoaNhaCC_Click(object sender, EventArgs e)
        {
            NHACUNGCAP ncc = new NHACUNGCAP(); // lưu qua  hiển thị lên testbox
            ncc.MaNhaCungCap = (string)gridView10.GetRowCellValue(gridView10.FocusedRowHandle, "MaNhaCungCap");
            busncc.XoaNhaCungCap_Bus(ncc);
        }

        private void simpleButton31_Click(object sender, EventArgs e)
        {
            grid_khohang.DataSource = buxkhoh.Formload_khoHangbus();
        }

        private void btnXoaKhoHang_Click(object sender, EventArgs e)
        {
            KHOHANG kh = new KHOHANG(); // lưu qua  hiển thị lên testbox
            kh.MaKho = (string)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MaKho");
            buxkhoh.XoaKhohang_Bus(kh);
        }

        private void simpleButton57_Click(object sender, EventArgs e)
        {
            grid_nhanvien.DataSource = busnv.Formload_NhanVienbus();
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN(); // lưu qua  hiển thị lên testbox
            nv.MaNhanVien = (string)gridView8.GetRowCellValue(gridView8.FocusedRowHandle, "MaNhanVien");
            busnv.XoaNhanVien_Bus(nv);
        }

        private void simpleButton51_Click(object sender, EventArgs e)
        {
            grid_hanghoa.DataSource = bushh.Formload_HangHoabus();
        }

        private void btnXoaHangHoa_Click(object sender, EventArgs e)
        {
            HANGHOA hh = new HANGHOA(); // lưu qua  hiển thị lên testbox
            hh.MaHangHoa = (string)gridView12.GetRowCellValue(gridView12.FocusedRowHandle, "MaHangHoa");
            bushh.XoaHangHoa_Bus(hh);
        }

        private void btnPhieuNhapHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnMain.Controls.Clear();
            PhieuNhapHangControl cont = new PhieuNhapHangControl();
            cont.Show();
            cont.Dock = DockStyle.Fill;
            pnMain.Controls.Add(cont);
        }

        private void btnBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabBanHang.PageVisible = true;
            AllTab.SelectedTabPage = tabBanHang;
            panel1.Controls.Clear();
            PhieuBanHangControl control = new PhieuBanHangControl();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void btnPhieuBanHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            PhieuBanHangControl control = new PhieuBanHangControl();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void btnTheoChungTu_BanHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            TheoChungTuControl control = new TheoChungTuControl();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void btnTheoHangHoa_BanHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel1.Controls.Clear();
            TheoHangHoaControl control = new TheoHangHoaControl();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }
    }
}
