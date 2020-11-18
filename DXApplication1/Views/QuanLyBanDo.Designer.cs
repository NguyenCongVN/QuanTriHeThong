namespace DXApplication1.Views
{
    partial class QuanLyBanDo
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
            this.simpleButtonXN = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSua = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenBanDo = new DevExpress.XtraEditors.TextEdit();
            this.dataGridViewDSBanDo = new System.Windows.Forms.DataGridView();
            this.txtDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonHuy = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditMaBanDo = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonChonDuongDan = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBanDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSBanDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaBanDo.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButtonXN
            // 
            this.simpleButtonXN.Location = new System.Drawing.Point(378, 119);
            this.simpleButtonXN.Name = "simpleButtonXN";
            this.simpleButtonXN.Size = new System.Drawing.Size(70, 23);
            this.simpleButtonXN.TabIndex = 36;
            this.simpleButtonXN.Text = "Xác Nhận";
            this.simpleButtonXN.Visible = false;
            this.simpleButtonXN.Click += new System.EventHandler(this.simpleButtonXN_Click);
            // 
            // simpleButtonXoa
            // 
            this.simpleButtonXoa.Location = new System.Drawing.Point(300, 119);
            this.simpleButtonXoa.Name = "simpleButtonXoa";
            this.simpleButtonXoa.Size = new System.Drawing.Size(70, 23);
            this.simpleButtonXoa.TabIndex = 35;
            this.simpleButtonXoa.Text = "Xóa";
            this.simpleButtonXoa.Click += new System.EventHandler(this.simpleButtonXoa_Click);
            // 
            // simpleButtonSua
            // 
            this.simpleButtonSua.Location = new System.Drawing.Point(222, 119);
            this.simpleButtonSua.Name = "simpleButtonSua";
            this.simpleButtonSua.Size = new System.Drawing.Size(70, 23);
            this.simpleButtonSua.TabIndex = 34;
            this.simpleButtonSua.Text = "Sửa";
            this.simpleButtonSua.Click += new System.EventHandler(this.simpleButtonSua_Click);
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Location = new System.Drawing.Point(144, 119);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(70, 23);
            this.simpleButtonThem.TabIndex = 26;
            this.simpleButtonThem.Text = "Thêm mới";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThem_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(25, 84);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(111, 13);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "Đường dẫn ảnh bản đồ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Tên Bản Đồ";
            // 
            // txtTenBanDo
            // 
            this.txtTenBanDo.Location = new System.Drawing.Point(145, 54);
            this.txtTenBanDo.Name = "txtTenBanDo";
            this.txtTenBanDo.Properties.ReadOnly = true;
            this.txtTenBanDo.Size = new System.Drawing.Size(382, 20);
            this.txtTenBanDo.TabIndex = 27;
            // 
            // dataGridViewDSBanDo
            // 
            this.dataGridViewDSBanDo.AllowUserToAddRows = false;
            this.dataGridViewDSBanDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSBanDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSBanDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDSBanDo.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewDSBanDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDSBanDo.Name = "dataGridViewDSBanDo";
            this.dataGridViewDSBanDo.RowHeadersWidth = 51;
            this.dataGridViewDSBanDo.RowTemplate.Height = 24;
            this.dataGridViewDSBanDo.Size = new System.Drawing.Size(539, 191);
            this.dataGridViewDSBanDo.TabIndex = 38;
            this.dataGridViewDSBanDo.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSDem_CellEnter);
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(144, 81);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Properties.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(343, 20);
            this.txtDuongDan.TabIndex = 41;
            // 
            // simpleButtonHuy
            // 
            this.simpleButtonHuy.Location = new System.Drawing.Point(456, 119);
            this.simpleButtonHuy.Name = "simpleButtonHuy";
            this.simpleButtonHuy.Size = new System.Drawing.Size(70, 23);
            this.simpleButtonHuy.TabIndex = 42;
            this.simpleButtonHuy.Text = "Hủy";
            this.simpleButtonHuy.Visible = false;
            this.simpleButtonHuy.Click += new System.EventHandler(this.simpleButtonHuy_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 44;
            this.labelControl1.Text = "Mã Bản Đồ";
            // 
            // textEditMaBanDo
            // 
            this.textEditMaBanDo.Location = new System.Drawing.Point(145, 26);
            this.textEditMaBanDo.Name = "textEditMaBanDo";
            this.textEditMaBanDo.Properties.ReadOnly = true;
            this.textEditMaBanDo.Size = new System.Drawing.Size(382, 20);
            this.textEditMaBanDo.TabIndex = 43;
            // 
            // simpleButtonChonDuongDan
            // 
            this.simpleButtonChonDuongDan.Location = new System.Drawing.Point(493, 80);
            this.simpleButtonChonDuongDan.Name = "simpleButtonChonDuongDan";
            this.simpleButtonChonDuongDan.Size = new System.Drawing.Size(30, 23);
            this.simpleButtonChonDuongDan.TabIndex = 45;
            this.simpleButtonChonDuongDan.Text = "...";
            this.simpleButtonChonDuongDan.ToolTipTitle = "Chọn đường dẫn";
            this.simpleButtonChonDuongDan.Click += new System.EventHandler(this.simpleButtonChonDuongDan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textEditMaBanDo);
            this.groupBox1.Controls.Add(this.simpleButtonHuy);
            this.groupBox1.Controls.Add(this.simpleButtonChonDuongDan);
            this.groupBox1.Controls.Add(this.txtTenBanDo);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.simpleButtonXN);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.simpleButtonXoa);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.simpleButtonSua);
            this.groupBox1.Controls.Add(this.simpleButtonThem);
            this.groupBox1.Controls.Add(this.txtDuongDan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 155);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bản đồ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDSBanDo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 211);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bản Đồ";
            // 
            // QuanLyBanDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyBanDo";
            this.Text = "Quản Lý Bản Đồ";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBanDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSBanDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaBanDo.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButtonXN;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXoa;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSua;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenBanDo;
        public System.Windows.Forms.DataGridView dataGridViewDSBanDo;
        private DevExpress.XtraEditors.TextEdit txtDuongDan;
        private DevExpress.XtraEditors.SimpleButton simpleButtonHuy;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditMaBanDo;
        private DevExpress.XtraEditors.SimpleButton simpleButtonChonDuongDan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}