namespace DXApplication1.Views
{
    partial class FileDem
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
            this.simpleButtonMo = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXN = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSua = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenFile = new DevExpress.XtraEditors.TextEdit();
            this.searchLookUpEditDSNV = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelDSNV = new System.Windows.Forms.Label();
            this.dataGridViewDSDem = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuongDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKeHoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditDSNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonMo
            // 
            this.simpleButtonMo.Location = new System.Drawing.Point(153, 81);
            this.simpleButtonMo.Name = "simpleButtonMo";
            this.simpleButtonMo.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonMo.TabIndex = 37;
            this.simpleButtonMo.Text = "Mở File";
            this.simpleButtonMo.Click += new System.EventHandler(this.simpleButtonMo_Click);
            // 
            // simpleButtonXN
            // 
            this.simpleButtonXN.Location = new System.Drawing.Point(207, 122);
            this.simpleButtonXN.Name = "simpleButtonXN";
            this.simpleButtonXN.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonXN.TabIndex = 36;
            this.simpleButtonXN.Text = "Xác Nhận";
            this.simpleButtonXN.Visible = false;
            this.simpleButtonXN.Click += new System.EventHandler(this.simpleButtonXN_Click);
            // 
            // simpleButtonXoa
            // 
            this.simpleButtonXoa.Location = new System.Drawing.Point(519, 75);
            this.simpleButtonXoa.Name = "simpleButtonXoa";
            this.simpleButtonXoa.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonXoa.TabIndex = 35;
            this.simpleButtonXoa.Text = "Xóa";
            this.simpleButtonXoa.Click += new System.EventHandler(this.simpleButtonXoa_Click);
            // 
            // simpleButtonSua
            // 
            this.simpleButtonSua.Location = new System.Drawing.Point(519, 46);
            this.simpleButtonSua.Name = "simpleButtonSua";
            this.simpleButtonSua.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonSua.TabIndex = 34;
            this.simpleButtonSua.Text = "Sửa";
            this.simpleButtonSua.Click += new System.EventHandler(this.simpleButtonSua_Click);
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Location = new System.Drawing.Point(519, 16);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonThem.TabIndex = 26;
            this.simpleButtonThem.Text = "Thêm mới";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThem_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(17, 53);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 13);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "Đường dẫn File";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Tên File";
            // 
            // txtTenFile
            // 
            this.txtTenFile.Location = new System.Drawing.Point(153, 21);
            this.txtTenFile.Name = "txtTenFile";
            this.txtTenFile.Properties.ReadOnly = true;
            this.txtTenFile.Size = new System.Drawing.Size(361, 20);
            this.txtTenFile.TabIndex = 27;
            // 
            // searchLookUpEditDSNV
            // 
            this.searchLookUpEditDSNV.EditValue = " ";
            this.searchLookUpEditDSNV.Location = new System.Drawing.Point(223, 150);
            this.searchLookUpEditDSNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchLookUpEditDSNV.Name = "searchLookUpEditDSNV";
            this.searchLookUpEditDSNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEditDSNV.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEditDSNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditDSNV.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEditDSNV.Size = new System.Drawing.Size(232, 26);
            this.searchLookUpEditDSNV.TabIndex = 40;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelDSNV
            // 
            this.labelDSNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDSNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDSNV.Location = new System.Drawing.Point(27, 152);
            this.labelDSNV.Name = "labelDSNV";
            this.labelDSNV.Size = new System.Drawing.Size(487, 38);
            this.labelDSNV.TabIndex = 39;
            this.labelDSNV.Text = "Danh Sách Fie Dem";
            // 
            // dataGridViewDSDem
            // 
            this.dataGridViewDSDem.AllowUserToAddRows = false;
            this.dataGridViewDSDem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSDem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSDem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenFile,
            this.DuongDan,
            this.MaKeHoach});
            this.dataGridViewDSDem.Location = new System.Drawing.Point(-1, 192);
            this.dataGridViewDSDem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDSDem.Name = "dataGridViewDSDem";
            this.dataGridViewDSDem.RowHeadersWidth = 51;
            this.dataGridViewDSDem.RowTemplate.Height = 24;
            this.dataGridViewDSDem.Size = new System.Drawing.Size(611, 214);
            this.dataGridViewDSDem.TabIndex = 38;
            this.dataGridViewDSDem.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSDem_CellEnter);
            this.dataGridViewDSDem.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewDSDem_RowPrePaint);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 2;
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // TenFile
            // 
            this.TenFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenFile.DataPropertyName = "TenFile";
            this.TenFile.HeaderText = "Tên File";
            this.TenFile.MinimumWidth = 6;
            this.TenFile.Name = "TenFile";
            this.TenFile.ReadOnly = true;
            this.TenFile.Width = 125;
            // 
            // DuongDan
            // 
            this.DuongDan.DataPropertyName = "DuongDan";
            this.DuongDan.FillWeight = 89.12591F;
            this.DuongDan.HeaderText = "Đường Dẫn File";
            this.DuongDan.MinimumWidth = 6;
            this.DuongDan.Name = "DuongDan";
            this.DuongDan.ReadOnly = true;
            // 
            // MaKeHoach
            // 
            this.MaKeHoach.DataPropertyName = "MaKeHoach";
            this.MaKeHoach.HeaderText = "Mã Kế Hoạch";
            this.MaKeHoach.MinimumWidth = 6;
            this.MaKeHoach.Name = "MaKeHoach";
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(153, 50);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Properties.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(361, 20);
            this.txtDuongDan.TabIndex = 41;
            // 
            // simpleButtonHuy
            // 
            this.simpleButtonHuy.Location = new System.Drawing.Point(347, 122);
            this.simpleButtonHuy.Name = "simpleButtonHuy";
            this.simpleButtonHuy.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonHuy.TabIndex = 42;
            this.simpleButtonHuy.Text = "Hủy";
            this.simpleButtonHuy.Visible = false;
            this.simpleButtonHuy.Click += new System.EventHandler(this.simpleButtonHuy_Click);
            // 
            // FileDem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 415);
            this.Controls.Add(this.simpleButtonHuy);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.searchLookUpEditDSNV);
            this.Controls.Add(this.labelDSNV);
            this.Controls.Add(this.dataGridViewDSDem);
            this.Controls.Add(this.simpleButtonMo);
            this.Controls.Add(this.simpleButtonXN);
            this.Controls.Add(this.simpleButtonXoa);
            this.Controls.Add(this.simpleButtonSua);
            this.Controls.Add(this.simpleButtonThem);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTenFile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FileDem";
            this.Text = "Quản Lý File Dem";
            this.Load += new System.EventHandler(this.FileDem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditDSNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButtonMo;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXN;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXoa;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSua;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenFile;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditDSNV;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label labelDSNV;
        public System.Windows.Forms.DataGridView dataGridViewDSDem;
        private DevExpress.XtraEditors.TextEdit txtDuongDan;
        private DevExpress.XtraEditors.SimpleButton simpleButtonHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuongDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKeHoach;
    }
}