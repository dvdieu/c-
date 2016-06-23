namespace QLBanHang
{
    partial class TonKhoTongHopControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TonKhoTongHopControl));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnXem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXuat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDong = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAddOrRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu_Xem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu_Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu_Xuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu_Dong = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu_Restet = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCus = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTonKhoTongHop = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTonKhoTongHop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.toolStrip1);
            this.groupControl1.Controls.Add(this.cbTonKhoTongHop);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(989, 455);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tồn Kho Tổng Hợp";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(5, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 367);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXem,
            this.toolStripSeparator1,
            this.btnXuat,
            this.toolStripSeparator2,
            this.btnIn,
            this.toolStripSeparator3,
            this.btnDong});
            this.toolStrip1.Location = new System.Drawing.Point(5, 46);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(688, 34);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnXem
            // 
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(51, 31);
            this.btnXem.Text = "Xem";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // btnXuat
            // 
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(51, 31);
            this.btnXuat.Text = "Xuất";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // btnIn
            // 
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(37, 31);
            this.btnIn.Text = "In";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // btnDong
            // 
            this.btnDong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddOrRemove});
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(65, 31);
            this.btnDong.Text = "Đóng";
            // 
            // btnAddOrRemove
            // 
            this.btnAddOrRemove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenu,
            this.btnCus});
            this.btnAddOrRemove.Name = "btnAddOrRemove";
            this.btnAddOrRemove.Size = new System.Drawing.Size(200, 22);
            this.btnAddOrRemove.Text = "Add or Remove Buttons";
            // 
            // btnMenu
            // 
            this.btnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenu_Xem,
            this.btnMenu_Xoa,
            this.btnMenu_Xuat,
            this.btnMenu_Dong,
            this.btnMenu_Restet});
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(135, 22);
            this.btnMenu.Text = "Main Menu";
            // 
            // btnMenu_Xem
            // 
            this.btnMenu_Xem.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu_Xem.Image")));
            this.btnMenu_Xem.Name = "btnMenu_Xem";
            this.btnMenu_Xem.Size = new System.Drawing.Size(145, 22);
            this.btnMenu_Xem.Text = "Xem";
            // 
            // btnMenu_Xoa
            // 
            this.btnMenu_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu_Xoa.Image")));
            this.btnMenu_Xoa.Name = "btnMenu_Xoa";
            this.btnMenu_Xoa.Size = new System.Drawing.Size(145, 22);
            this.btnMenu_Xoa.Text = "Xóa";
            // 
            // btnMenu_Xuat
            // 
            this.btnMenu_Xuat.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu_Xuat.Image")));
            this.btnMenu_Xuat.Name = "btnMenu_Xuat";
            this.btnMenu_Xuat.Size = new System.Drawing.Size(145, 22);
            this.btnMenu_Xuat.Text = "Xuất";
            // 
            // btnMenu_Dong
            // 
            this.btnMenu_Dong.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu_Dong.Image")));
            this.btnMenu_Dong.Name = "btnMenu_Dong";
            this.btnMenu_Dong.Size = new System.Drawing.Size(145, 22);
            this.btnMenu_Dong.Text = "Đóng";
            // 
            // btnMenu_Restet
            // 
            this.btnMenu_Restet.Name = "btnMenu_Restet";
            this.btnMenu_Restet.Size = new System.Drawing.Size(145, 22);
            this.btnMenu_Restet.Text = "Reset Toolbar";
            // 
            // btnCus
            // 
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(135, 22);
            this.btnCus.Text = "Customize";
            // 
            // cbTonKhoTongHop
            // 
            this.cbTonKhoTongHop.Location = new System.Drawing.Point(5, 23);
            this.cbTonKhoTongHop.Name = "cbTonKhoTongHop";
            this.cbTonKhoTongHop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTonKhoTongHop.Properties.View = this.gridLookUpEdit1View;
            this.cbTonKhoTongHop.Size = new System.Drawing.Size(226, 20);
            this.cbTonKhoTongHop.TabIndex = 0;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // TonKhoTongHopControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "TonKhoTongHopControl";
            this.Size = new System.Drawing.Size(989, 455);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTonKhoTongHop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GridLookUpEdit cbTonKhoTongHop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnXem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton btnDong;
        private System.Windows.Forms.ToolStripMenuItem btnAddOrRemove;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem btnMenu_Xem;
        private System.Windows.Forms.ToolStripMenuItem btnMenu_Xoa;
        private System.Windows.Forms.ToolStripMenuItem btnMenu_Xuat;
        private System.Windows.Forms.ToolStripMenuItem btnMenu_Dong;
        private System.Windows.Forms.ToolStripMenuItem btnMenu_Restet;
        private System.Windows.Forms.ToolStripMenuItem btnCus;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
