namespace DXApplication1.Admin
{
    partial class AddChucVu
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
            this.labelMaChucVu = new System.Windows.Forms.Label();
            this.labelTenChucVu = new System.Windows.Forms.Label();
            this.textBoxMaChucVu = new System.Windows.Forms.TextBox();
            this.textBoxTenChucVu = new System.Windows.Forms.TextBox();
            this.groupControlThêmChucVu = new DevExpress.XtraEditors.GroupControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.buttonThem = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThêmChucVu)).BeginInit();
            this.groupControlThêmChucVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMaChucVu
            // 
            this.labelMaChucVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMaChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaChucVu.Location = new System.Drawing.Point(29, 47);
            this.labelMaChucVu.Name = "labelMaChucVu";
            this.labelMaChucVu.Size = new System.Drawing.Size(131, 25);
            this.labelMaChucVu.TabIndex = 0;
            this.labelMaChucVu.Text = "Mã Chức Vụ";
            this.labelMaChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTenChucVu
            // 
            this.labelTenChucVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTenChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenChucVu.Location = new System.Drawing.Point(29, 123);
            this.labelTenChucVu.Name = "labelTenChucVu";
            this.labelTenChucVu.Size = new System.Drawing.Size(131, 25);
            this.labelTenChucVu.TabIndex = 1;
            this.labelTenChucVu.Text = "Tên Chức Vụ";
            this.labelTenChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMaChucVu
            // 
            this.textBoxMaChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaChucVu.Location = new System.Drawing.Point(216, 45);
            this.textBoxMaChucVu.Name = "textBoxMaChucVu";
            this.textBoxMaChucVu.Size = new System.Drawing.Size(216, 30);
            this.textBoxMaChucVu.TabIndex = 0;
            // 
            // textBoxTenChucVu
            // 
            this.textBoxTenChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenChucVu.Location = new System.Drawing.Point(216, 121);
            this.textBoxTenChucVu.Name = "textBoxTenChucVu";
            this.textBoxTenChucVu.Size = new System.Drawing.Size(216, 30);
            this.textBoxTenChucVu.TabIndex = 1;
            // 
            // groupControlThêmChucVu
            // 
            this.groupControlThêmChucVu.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlThêmChucVu.AppearanceCaption.Options.UseFont = true;
            this.groupControlThêmChucVu.Controls.Add(this.labelMaChucVu);
            this.groupControlThêmChucVu.Controls.Add(this.labelTenChucVu);
            this.groupControlThêmChucVu.Controls.Add(this.textBoxMaChucVu);
            this.groupControlThêmChucVu.Controls.Add(this.textBoxTenChucVu);
            this.groupControlThêmChucVu.Location = new System.Drawing.Point(12, 31);
            this.groupControlThêmChucVu.Name = "groupControlThêmChucVu";
            this.groupControlThêmChucVu.Size = new System.Drawing.Size(468, 212);
            this.groupControlThêmChucVu.TabIndex = 7;
            this.groupControlThêmChucVu.Text = "Thông tin chức vụ";
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Location = new System.Drawing.Point(56, 280);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 30);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Appearance.Options.UseFont = true;
            this.buttonThem.Location = new System.Drawing.Point(199, 280);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(87, 30);
            this.buttonThem.TabIndex = 9;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // ButtonHuy
            // 
            this.ButtonHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHuy.Appearance.Options.UseFont = true;
            this.ButtonHuy.Location = new System.Drawing.Point(357, 280);
            this.ButtonHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonHuy.Name = "ButtonHuy";
            this.ButtonHuy.Size = new System.Drawing.Size(87, 30);
            this.ButtonHuy.TabIndex = 10;
            this.ButtonHuy.Text = "Huỷ";
            this.ButtonHuy.Click += new System.EventHandler(this.ButtonHuy_Click);
            // 
            // AddChucVu
            // 
            this.Appearance.BackColor = System.Drawing.Color.Snow;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 361);
            this.Controls.Add(this.ButtonHuy);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupControlThêmChucVu);
            this.Name = "AddChucVu";
            this.Text = "ChucVuForm";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThêmChucVu)).EndInit();
            this.groupControlThêmChucVu.ResumeLayout(false);
            this.groupControlThêmChucVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMaChucVu;
        private System.Windows.Forms.Label labelTenChucVu;
        private System.Windows.Forms.TextBox textBoxMaChucVu;
        private System.Windows.Forms.TextBox textBoxTenChucVu;
        private DevExpress.XtraEditors.GroupControl groupControlThêmChucVu;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton buttonThem;
        private DevExpress.XtraEditors.SimpleButton ButtonHuy;
    }
}