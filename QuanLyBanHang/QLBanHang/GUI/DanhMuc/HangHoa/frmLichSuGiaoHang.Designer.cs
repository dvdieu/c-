namespace QLBanHang.DanhMuc
{
    partial class frmLichSuGiaoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSuGiaoHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThoat = new System.Windows.Forms.Button();
            this.bntTim = new System.Windows.Forms.Button();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.gridControlLichsugiaohang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichsugiaohang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThoat);
            this.groupBox1.Controls.Add(this.bntTim);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Location = new System.Drawing.Point(-2, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtThoat
            // 
            this.txtThoat.Image = ((System.Drawing.Image)(resources.GetObject("txtThoat.Image")));
            this.txtThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtThoat.Location = new System.Drawing.Point(518, 11);
            this.txtThoat.Name = "txtThoat";
            this.txtThoat.Size = new System.Drawing.Size(75, 23);
            this.txtThoat.TabIndex = 3;
            this.txtThoat.Text = "Thoát";
            this.txtThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtThoat.UseVisualStyleBackColor = true;
            this.txtThoat.Click += new System.EventHandler(this.txtThoat_Click);
            // 
            // bntTim
            // 
            this.bntTim.Image = ((System.Drawing.Image)(resources.GetObject("bntTim.Image")));
            this.bntTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntTim.Location = new System.Drawing.Point(428, 11);
            this.bntTim.Name = "bntTim";
            this.bntTim.Size = new System.Drawing.Size(70, 23);
            this.bntTim.TabIndex = 2;
            this.bntTim.Text = "Tìm";
            this.bntTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntTim.UseVisualStyleBackColor = true;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(159, 14);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(233, 20);
            this.txtTenHang.TabIndex = 1;
            this.txtTenHang.Text = "Tên Hàng";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(53, 14);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(100, 20);
            this.txtMaHang.TabIndex = 0;
            this.txtMaHang.Text = "Mã Hàng";
            // 
            // gridControlLichsugiaohang
            // 
            this.gridControlLichsugiaohang.Location = new System.Drawing.Point(-2, 54);
            this.gridControlLichsugiaohang.MainView = this.gridView1;
            this.gridControlLichsugiaohang.Name = "gridControlLichsugiaohang";
            this.gridControlLichsugiaohang.Size = new System.Drawing.Size(832, 425);
            this.gridControlLichsugiaohang.TabIndex = 1;
            this.gridControlLichsugiaohang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlLichsugiaohang;
            this.gridView1.Name = "gridView1";
            // 
            // frmLichSuGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 479);
            this.Controls.Add(this.gridControlLichsugiaohang);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLichSuGiaoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch Sử Giao Hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLichsugiaohang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtThoat;
        private System.Windows.Forms.Button bntTim;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private DevExpress.XtraGrid.GridControl gridControlLichsugiaohang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}