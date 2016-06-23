namespace QLBanHang
{
    partial class frmPhucHoiHeThong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhucHoiHeThong));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.txtTenTapTin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grTenTapTin = new DevExpress.XtraEditors.ButtonEdit();
            this.btDong = new DevExpress.XtraEditors.SimpleButton();
            this.btThucHien = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTenTapTin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(117, 19);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(357, 18);
            this.progressBarControl1.TabIndex = 14;
            // 
            // txtTenTapTin
            // 
            this.txtTenTapTin.Enabled = false;
            this.txtTenTapTin.Location = new System.Drawing.Point(117, 84);
            this.txtTenTapTin.Name = "txtTenTapTin";
            this.txtTenTapTin.Size = new System.Drawing.Size(357, 20);
            this.txtTenTapTin.TabIndex = 13;
            this.txtTenTapTin.Text = "SaleExample";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cơ Sở Dữ Liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên Tập Tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tiến Trình";
            // 
            // grTenTapTin
            // 
            this.grTenTapTin.EditValue = "";
            this.grTenTapTin.Location = new System.Drawing.Point(117, 51);
            this.grTenTapTin.Name = "grTenTapTin";
            this.grTenTapTin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.Default, ((System.Drawing.Image)(resources.GetObject("grTenTapTin.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, true)});
            this.grTenTapTin.Properties.NullText = "[EditValue is null]";
            this.grTenTapTin.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.grTenTapTin.Size = new System.Drawing.Size(357, 22);
            this.grTenTapTin.TabIndex = 15;
            // 
            // btDong
            // 
            this.btDong.Image = ((System.Drawing.Image)(resources.GetObject("btDong.Image")));
            this.btDong.Location = new System.Drawing.Point(399, 118);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(75, 23);
            this.btDong.TabIndex = 17;
            this.btDong.Text = "Đóng";
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btThucHien
            // 
            this.btThucHien.Image = ((System.Drawing.Image)(resources.GetObject("btThucHien.Image")));
            this.btThucHien.Location = new System.Drawing.Point(301, 118);
            this.btThucHien.Name = "btThucHien";
            this.btThucHien.Size = new System.Drawing.Size(75, 23);
            this.btThucHien.TabIndex = 16;
            this.btThucHien.Text = "Thực Hiện";
            // 
            // frmPhucHoiHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 154);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btThucHien);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.txtTenTapTin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grTenTapTin);
            this.Name = "frmPhucHoiHeThong";
            this.Text = "Phục Hồi Dữ Liệu";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTenTapTin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btDong;
        private DevExpress.XtraEditors.SimpleButton btThucHien;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.Windows.Forms.TextBox txtTenTapTin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ButtonEdit grTenTapTin;
    }
}