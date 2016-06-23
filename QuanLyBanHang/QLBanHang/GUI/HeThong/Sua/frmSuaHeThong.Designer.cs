namespace QLBanHang
{
    partial class frmSuaHeThong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaHeThong));
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.trChucNang = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trTatCa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trTruyCap = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trThem = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trSua = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trXoa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trIn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trNhap = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trXuat = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chKichHoat = new DevExpress.XtraEditors.CheckEdit();
            this.txtDienGiai = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chKichHoat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btDong
            // 
            this.btDong.Image = ((System.Drawing.Image)(resources.GetObject("btDong.Image")));
            this.btDong.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btDong.Location = new System.Drawing.Point(501, 560);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(184, 23);
            this.btDong.TabIndex = 6;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = ((System.Drawing.Image)(resources.GetObject("btLuu.Image")));
            this.btLuu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(311, 560);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(184, 23);
            this.btLuu.TabIndex = 5;
            this.btLuu.Text = "Lưu";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.treeList1);
            this.groupControl2.Location = new System.Drawing.Point(10, 132);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(676, 413);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Quyền Hạn";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.trChucNang,
            this.trTatCa,
            this.trTruyCap,
            this.trThem,
            this.trSua,
            this.trXoa,
            this.trIn,
            this.trNhap,
            this.trXuat});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(2, 20);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(672, 391);
            this.treeList1.TabIndex = 0;
            // 
            // trChucNang
            // 
            this.trChucNang.Caption = "Chức Năng";
            this.trChucNang.FieldName = "Chức Năng";
            this.trChucNang.Name = "trChucNang";
            this.trChucNang.Visible = true;
            this.trChucNang.VisibleIndex = 0;
            // 
            // trTatCa
            // 
            this.trTatCa.Caption = "Tất Cả";
            this.trTatCa.FieldName = "Tất Cả";
            this.trTatCa.Name = "trTatCa";
            this.trTatCa.Visible = true;
            this.trTatCa.VisibleIndex = 1;
            // 
            // trTruyCap
            // 
            this.trTruyCap.Caption = "Truy Cập";
            this.trTruyCap.FieldName = "Truy Cập";
            this.trTruyCap.Name = "trTruyCap";
            this.trTruyCap.Visible = true;
            this.trTruyCap.VisibleIndex = 2;
            // 
            // trThem
            // 
            this.trThem.Caption = "Thêm";
            this.trThem.FieldName = "Thêm";
            this.trThem.Name = "trThem";
            this.trThem.Visible = true;
            this.trThem.VisibleIndex = 3;
            // 
            // trSua
            // 
            this.trSua.Caption = "Sửa";
            this.trSua.FieldName = "Sửa";
            this.trSua.Name = "trSua";
            this.trSua.Visible = true;
            this.trSua.VisibleIndex = 4;
            // 
            // trXoa
            // 
            this.trXoa.Caption = "Xóa";
            this.trXoa.FieldName = "Xóa";
            this.trXoa.Name = "trXoa";
            this.trXoa.Visible = true;
            this.trXoa.VisibleIndex = 5;
            // 
            // trIn
            // 
            this.trIn.Caption = "In";
            this.trIn.FieldName = "In";
            this.trIn.Name = "trIn";
            this.trIn.Visible = true;
            this.trIn.VisibleIndex = 6;
            // 
            // trNhap
            // 
            this.trNhap.Caption = "Nhập";
            this.trNhap.FieldName = "Nhập";
            this.trNhap.Name = "trNhap";
            this.trNhap.Visible = true;
            this.trNhap.VisibleIndex = 7;
            // 
            // trXuat
            // 
            this.trXuat.Caption = "Xuất";
            this.trXuat.FieldName = "Xuất";
            this.trXuat.Name = "trXuat";
            this.trXuat.Visible = true;
            this.trXuat.VisibleIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chKichHoat);
            this.groupControl1.Controls.Add(this.txtDienGiai);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.txtMa);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(10, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(676, 114);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông Tin Vai Trò";
            // 
            // chKichHoat
            // 
            this.chKichHoat.EditValue = true;
            this.chKichHoat.Location = new System.Drawing.Point(390, 73);
            this.chKichHoat.Name = "chKichHoat";
            this.chKichHoat.Properties.Caption = "";
            this.chKichHoat.Size = new System.Drawing.Size(75, 19);
            this.chKichHoat.TabIndex = 7;
            // 
            // txtDienGiai
            // 
            this.txtDienGiai.Location = new System.Drawing.Point(390, 30);
            this.txtDienGiai.Name = "txtDienGiai";
            this.txtDienGiai.Size = new System.Drawing.Size(254, 21);
            this.txtDienGiai.TabIndex = 6;
            this.txtDienGiai.Text = "Quản Trị Hệ Thống";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(58, 73);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(272, 21);
            this.txtTen.TabIndex = 5;
            this.txtTen.Text = "Quản Trị Hệ Thống";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(58, 30);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(272, 21);
            this.txtMa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kích Hoạt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diễn Giải";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // frmSuaHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 595);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.groupControl2);
            this.Name = "frmSuaHeThong";
            this.Text = "Cập Nhật Vai Trò";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chKichHoat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trChucNang;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trTatCa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trTruyCap;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trThem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trSua;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trXoa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trIn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trNhap;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trXuat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chKichHoat;
        private System.Windows.Forms.TextBox txtDienGiai;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}