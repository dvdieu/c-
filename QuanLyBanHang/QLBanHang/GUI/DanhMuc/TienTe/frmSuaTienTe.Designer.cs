namespace QLBanHang.DanhMuc
{
    partial class frmSuaTienTe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaTienTe));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.calcquydoi = new DevExpress.XtraEditors.CalcEdit();
            this.CkSuaConQuanLy = new System.Windows.Forms.CheckBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaLuu = new System.Windows.Forms.Button();
            this.btnSuaClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcquydoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.calcquydoi);
            this.groupControl1.Controls.Add(this.CkSuaConQuanLy);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.txtMa);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(0, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(356, 165);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông Tin";
            // 
            // calcquydoi
            // 
            this.calcquydoi.Location = new System.Drawing.Point(89, 99);
            this.calcquydoi.Name = "calcquydoi";
            this.calcquydoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcquydoi.Size = new System.Drawing.Size(242, 20);
            this.calcquydoi.TabIndex = 44;
            // 
            // CkSuaConQuanLy
            // 
            this.CkSuaConQuanLy.AutoSize = true;
            this.CkSuaConQuanLy.Location = new System.Drawing.Point(89, 134);
            this.CkSuaConQuanLy.Name = "CkSuaConQuanLy";
            this.CkSuaConQuanLy.Size = new System.Drawing.Size(85, 17);
            this.CkSuaConQuanLy.TabIndex = 43;
            this.CkSuaConQuanLy.Text = "Còn Quản lý";
            this.CkSuaConQuanLy.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(89, 64);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(242, 21);
            this.txtTen.TabIndex = 4;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(89, 29);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(242, 21);
            this.txtMa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tỷ Giá Quy Đổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // btnSuaLuu
            // 
            this.btnSuaLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaLuu.Image")));
            this.btnSuaLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaLuu.Location = new System.Drawing.Point(89, 181);
            this.btnSuaLuu.Name = "btnSuaLuu";
            this.btnSuaLuu.Size = new System.Drawing.Size(69, 23);
            this.btnSuaLuu.TabIndex = 43;
            this.btnSuaLuu.Text = "Lưu";
            this.btnSuaLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaLuu.UseVisualStyleBackColor = true;
            this.btnSuaLuu.Click += new System.EventHandler(this.btnSuaLuu_Click);
            // 
            // btnSuaClose
            // 
            this.btnSuaClose.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaClose.Image")));
            this.btnSuaClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaClose.Location = new System.Drawing.Point(230, 181);
            this.btnSuaClose.Name = "btnSuaClose";
            this.btnSuaClose.Size = new System.Drawing.Size(71, 23);
            this.btnSuaClose.TabIndex = 44;
            this.btnSuaClose.Text = "Đóng";
            this.btnSuaClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaClose.UseVisualStyleBackColor = true;
            this.btnSuaClose.Click += new System.EventHandler(this.btnSuaClose_Click);
            // 
            // frmSuaTienTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 221);
            this.Controls.Add(this.btnSuaClose);
            this.Controls.Add(this.btnSuaLuu);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmSuaTienTe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Tiền Tệ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcquydoi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CalcEdit calcquydoi;
        private System.Windows.Forms.CheckBox CkSuaConQuanLy;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaLuu;
        private System.Windows.Forms.Button btnSuaClose;
    }
}