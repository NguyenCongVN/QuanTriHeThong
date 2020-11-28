namespace DXApplication1.Admin
{
    partial class SuaChucVu
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
            this.ButtonHuy = new DevExpress.XtraEditors.SimpleButton();
            this.buttonLuuthaydoi = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlThêmChucVu = new DevExpress.XtraEditors.GroupControl();
            this.labelTenChucVuCu = new System.Windows.Forms.Label();
            this.labelTenChucVuMoi = new System.Windows.Forms.Label();
            this.textBoxTenChucVuCu = new System.Windows.Forms.TextBox();
            this.textBoxTenChucVuMoi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThêmChucVu)).BeginInit();
            this.groupControlThêmChucVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonHuy
            // 
            this.ButtonHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHuy.Appearance.Options.UseFont = true;
            this.ButtonHuy.Location = new System.Drawing.Point(316, 155);
            this.ButtonHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonHuy.Name = "ButtonHuy";
            this.ButtonHuy.Size = new System.Drawing.Size(100, 28);
            this.ButtonHuy.TabIndex = 14;
            this.ButtonHuy.Text = "Huỷ";
            this.ButtonHuy.Click += new System.EventHandler(this.ButtonHuy_Click);
            // 
            // buttonLuuthaydoi
            // 
            this.buttonLuuthaydoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuuthaydoi.Appearance.Options.UseFont = true;
            this.buttonLuuthaydoi.Location = new System.Drawing.Point(209, 155);
            this.buttonLuuthaydoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLuuthaydoi.Name = "buttonLuuthaydoi";
            this.buttonLuuthaydoi.Size = new System.Drawing.Size(100, 28);
            this.buttonLuuthaydoi.TabIndex = 13;
            this.buttonLuuthaydoi.Text = "Lưu";
            this.buttonLuuthaydoi.Click += new System.EventHandler(this.buttonLuuthaydoi_Click);
            // 
            // groupControlThêmChucVu
            // 
            this.groupControlThêmChucVu.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlThêmChucVu.AppearanceCaption.Options.UseFont = true;
            this.groupControlThêmChucVu.Controls.Add(this.ButtonHuy);
            this.groupControlThêmChucVu.Controls.Add(this.labelTenChucVuCu);
            this.groupControlThêmChucVu.Controls.Add(this.buttonLuuthaydoi);
            this.groupControlThêmChucVu.Controls.Add(this.labelTenChucVuMoi);
            this.groupControlThêmChucVu.Controls.Add(this.textBoxTenChucVuCu);
            this.groupControlThêmChucVu.Controls.Add(this.textBoxTenChucVuMoi);
            this.groupControlThêmChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlThêmChucVu.Location = new System.Drawing.Point(0, 0);
            this.groupControlThêmChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControlThêmChucVu.Name = "groupControlThêmChucVu";
            this.groupControlThêmChucVu.Size = new System.Drawing.Size(488, 208);
            this.groupControlThêmChucVu.TabIndex = 11;
            this.groupControlThêmChucVu.Text = "Thông tin chức vụ";
            // 
            // labelTenChucVuCu
            // 
            this.labelTenChucVuCu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenChucVuCu.Location = new System.Drawing.Point(18, 48);
            this.labelTenChucVuCu.Name = "labelTenChucVuCu";
            this.labelTenChucVuCu.Size = new System.Drawing.Size(145, 25);
            this.labelTenChucVuCu.TabIndex = 0;
            this.labelTenChucVuCu.Text = "Tên Chức Vụ Cũ";
            this.labelTenChucVuCu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTenChucVuMoi
            // 
            this.labelTenChucVuMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenChucVuMoi.Location = new System.Drawing.Point(18, 92);
            this.labelTenChucVuMoi.Name = "labelTenChucVuMoi";
            this.labelTenChucVuMoi.Size = new System.Drawing.Size(156, 25);
            this.labelTenChucVuMoi.TabIndex = 1;
            this.labelTenChucVuMoi.Text = "Tên Chức Vụ Mới";
            this.labelTenChucVuMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTenChucVuCu
            // 
            this.textBoxTenChucVuCu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenChucVuCu.Location = new System.Drawing.Point(180, 46);
            this.textBoxTenChucVuCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenChucVuCu.Name = "textBoxTenChucVuCu";
            this.textBoxTenChucVuCu.Size = new System.Drawing.Size(283, 30);
            this.textBoxTenChucVuCu.TabIndex = 0;
            // 
            // textBoxTenChucVuMoi
            // 
            this.textBoxTenChucVuMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenChucVuMoi.Location = new System.Drawing.Point(180, 87);
            this.textBoxTenChucVuMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenChucVuMoi.Name = "textBoxTenChucVuMoi";
            this.textBoxTenChucVuMoi.Size = new System.Drawing.Size(283, 30);
            this.textBoxTenChucVuMoi.TabIndex = 1;
            // 
            // SuaChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 208);
            this.Controls.Add(this.groupControlThêmChucVu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SuaChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa chức vụ";
            this.Load += new System.EventHandler(this.SuaChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThêmChucVu)).EndInit();
            this.groupControlThêmChucVu.ResumeLayout(false);
            this.groupControlThêmChucVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ButtonHuy;
        private DevExpress.XtraEditors.SimpleButton buttonLuuthaydoi;
        private DevExpress.XtraEditors.GroupControl groupControlThêmChucVu;
        private System.Windows.Forms.Label labelTenChucVuCu;
        private System.Windows.Forms.Label labelTenChucVuMoi;
        private System.Windows.Forms.TextBox textBoxTenChucVuCu;
        private System.Windows.Forms.TextBox textBoxTenChucVuMoi;
    }
}