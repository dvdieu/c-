﻿namespace QLBanHang.DanhMuc
{
    partial class frmThemNhomHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhomHang));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.CkThemConQuanLy = new System.Windows.Forms.CheckBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemLuu = new System.Windows.Forms.Button();
            this.btnSuaClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.CkThemConQuanLy);
            this.groupControl1.Controls.Add(this.txtGhiChu);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.txtMa);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(-1, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(356, 165);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông Tin";
            // 
            // CkThemConQuanLy
            // 
            this.CkThemConQuanLy.AutoSize = true;
            this.CkThemConQuanLy.Checked = true;
            this.CkThemConQuanLy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkThemConQuanLy.Location = new System.Drawing.Point(89, 134);
            this.CkThemConQuanLy.Name = "CkThemConQuanLy";
            this.CkThemConQuanLy.Size = new System.Drawing.Size(85, 17);
            this.CkThemConQuanLy.TabIndex = 43;
            this.CkThemConQuanLy.Text = "Còn Quản lý";
            this.CkThemConQuanLy.UseVisualStyleBackColor = true;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(89, 99);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(242, 21);
            this.txtGhiChu.TabIndex = 5;
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
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi Chú";
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
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã *";
            // 
            // btnThemLuu
            // 
            this.btnThemLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLuu.Image")));
            this.btnThemLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLuu.Location = new System.Drawing.Point(88, 188);
            this.btnThemLuu.Name = "btnThemLuu";
            this.btnThemLuu.Size = new System.Drawing.Size(69, 23);
            this.btnThemLuu.TabIndex = 40;
            this.btnThemLuu.Text = "Lưu";
            this.btnThemLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemLuu.UseVisualStyleBackColor = true;
            this.btnThemLuu.Click += new System.EventHandler(this.btnThemLuu_Click);
            // 
            // btnSuaClose
            // 
            this.btnSuaClose.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaClose.Image")));
            this.btnSuaClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaClose.Location = new System.Drawing.Point(246, 188);
            this.btnSuaClose.Name = "btnSuaClose";
            this.btnSuaClose.Size = new System.Drawing.Size(71, 23);
            this.btnSuaClose.TabIndex = 41;
            this.btnSuaClose.Text = "Đóng";
            this.btnSuaClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaClose.UseVisualStyleBackColor = true;
            this.btnSuaClose.Click += new System.EventHandler(this.btnSuaClose_Click);
            // 
            // frmThemNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 235);
            this.Controls.Add(this.btnSuaClose);
            this.Controls.Add(this.btnThemLuu);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemNhomHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nhóm Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.CheckBox CkThemConQuanLy;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemLuu;
        private System.Windows.Forms.Button btnSuaClose;
    }
}