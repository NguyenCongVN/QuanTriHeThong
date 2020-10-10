namespace DXApplication1.Account
{
    partial class UpdatePass
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
            this.txtReNewPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.lbPass = new DevExpress.XtraEditors.LabelControl();
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.lbUser = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpCtrl1)).BeginInit();
            this.grpCtrl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCtrl1
            // 
            this.grpCtrl1.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.grpCtrl1.Appearance.Options.UseBackColor = true;
            this.grpCtrl1.Controls.Add(this.txtReNewPass);
            this.grpCtrl1.Controls.Add(this.labelControl2);
            this.grpCtrl1.Controls.Add(this.txtNewPass);
            this.grpCtrl1.Controls.Add(this.lbPass);
            this.grpCtrl1.Controls.Add(this.txtOldPass);
            this.grpCtrl1.Controls.Add(this.lbUser);
            this.grpCtrl1.Location = new System.Drawing.Point(12, 30);
            this.grpCtrl1.Name = "grpCtrl1";
            this.grpCtrl1.Size = new System.Drawing.Size(429, 177);
            this.grpCtrl1.TabIndex = 0;
            this.grpCtrl1.Text = "Đổi mật khẩu";
            // 
            // txtReNewPass
            // 
            this.txtReNewPass.Location = new System.Drawing.Point(178, 130);
            this.txtReNewPass.Name = "txtReNewPass";
            this.txtReNewPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReNewPass.Properties.Appearance.Options.UseFont = true;
            this.txtReNewPass.Properties.UseSystemPasswordChar = true;
            this.txtReNewPass.Size = new System.Drawing.Size(238, 24);
            this.txtReNewPass.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(156, 18);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Nhập lại mật khẩu mới: ";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(178, 87);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Properties.Appearance.Options.UseFont = true;
            this.txtNewPass.Properties.UseSystemPasswordChar = true;
            this.txtNewPass.Size = new System.Drawing.Size(238, 24);
            this.txtNewPass.TabIndex = 3;
            // 
            // lbPass
            // 
            this.lbPass.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Appearance.Options.UseFont = true;
            this.lbPass.Location = new System.Drawing.Point(17, 90);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(99, 18);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Mật khẩu mới: ";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(178, 44);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.Properties.Appearance.Options.UseFont = true;
            this.txtOldPass.Properties.UseSystemPasswordChar = true;
            this.txtOldPass.Size = new System.Drawing.Size(238, 24);
            this.txtOldPass.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Appearance.Options.UseFont = true;
            this.lbUser.Location = new System.Drawing.Point(17, 47);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(91, 18);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Mật khẩu cũ: ";
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(81, 229);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 29);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(238, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UpdatePass
            // 
            this.Appearance.BackColor = System.Drawing.Color.Snow;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 276);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpCtrl1);
            this.Name = "UpdatePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.UpdatePass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpCtrl1)).EndInit();
            this.grpCtrl1.ResumeLayout(false);
            this.grpCtrl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCtrl1;
        private DevExpress.XtraEditors.LabelControl lbPass;
        private DevExpress.XtraEditors.LabelControl lbUser;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        public DevExpress.XtraEditors.TextEdit txtNewPass;
        public DevExpress.XtraEditors.TextEdit txtOldPass;
        public DevExpress.XtraEditors.TextEdit txtReNewPass;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}