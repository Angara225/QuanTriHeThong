﻿namespace DXApplication1
{
    partial class frmLogin
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
            this.grpCtrl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.lbPass = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.lbUser = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.checkEditHienMatKhau = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCtrl1)).BeginInit();
            this.grpCtrl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCtrl1
            // 
            this.grpCtrl1.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.grpCtrl1.Appearance.Options.UseBackColor = true;
            this.grpCtrl1.Controls.Add(this.checkEditHienMatKhau);
            this.grpCtrl1.Controls.Add(this.txtPass);
            this.grpCtrl1.Controls.Add(this.lbPass);
            this.grpCtrl1.Controls.Add(this.txtUser);
            this.grpCtrl1.Controls.Add(this.lbUser);
            this.grpCtrl1.Location = new System.Drawing.Point(62, 26);
            this.grpCtrl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCtrl1.Name = "grpCtrl1";
            this.grpCtrl1.Size = new System.Drawing.Size(586, 171);
            this.grpCtrl1.TabIndex = 0;
            this.grpCtrl1.Text = "Thông tin đăng nhập";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(243, 102);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseFont = true;

            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(204, 20);

            this.txtPass.TabIndex = 3;
            this.txtPass.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // lbPass
            // 
            this.lbPass.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Appearance.Options.UseFont = true;
            this.lbPass.Location = new System.Drawing.Point(78, 104);
            this.lbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(50, 14);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(243, 50);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Properties.Appearance.Options.UseFont = true;
            this.txtUser.Size = new System.Drawing.Size(204, 20);
            this.txtUser.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Appearance.Options.UseFont = true;
            this.lbUser.Location = new System.Drawing.Point(78, 51);
            this.lbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(84, 14);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Tên đăng nhập";
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(224, 217);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 24);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseLeave += new System.EventHandler(this.btnOK_MouseLeave);
            this.btnOK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOK_MouseMove);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(358, 217);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseMove);
            // 
            // checkEditHienMatKhau
            // 
            this.checkEditHienMatKhau.Location = new System.Drawing.Point(478, 101);
            this.checkEditHienMatKhau.Name = "checkEditHienMatKhau";
            this.checkEditHienMatKhau.Properties.Caption = "Hiện mật khẩu";
            this.checkEditHienMatKhau.Size = new System.Drawing.Size(94, 19);
            this.checkEditHienMatKhau.TabIndex = 4;
            this.checkEditHienMatKhau.CheckedChanged += new System.EventHandler(this.checkEditHienMatKhau_CheckedChanged);
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.Snow;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 256);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpCtrl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpCtrl1)).EndInit();
            this.grpCtrl1.ResumeLayout(false);
            this.grpCtrl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHienMatKhau.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCtrl1;
        private DevExpress.XtraEditors.LabelControl lbPass;
        private DevExpress.XtraEditors.LabelControl lbUser;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        public DevExpress.XtraEditors.TextEdit txtPass;
        public DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.CheckEdit checkEditHienMatKhau;
    }
}