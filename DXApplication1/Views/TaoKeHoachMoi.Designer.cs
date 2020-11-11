namespace DXApplication1.Views
{
    partial class QuanLyPhuongAnForm
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
            this.textEditTenPhuongAn = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.timeEditThoiGianLap = new DevExpress.XtraEditors.DateEdit();
            this.richEditControlChiTiet = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLuu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonMo = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDong = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewKeHoach = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxMaBanDo = new System.Windows.Forms.ComboBox();
            this.comboBoxMaFile = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxTenFile = new System.Windows.Forms.ComboBox();
            this.comboBoxTenBanDo = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonChinhSua = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenPhuongAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditThoiGianLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditThoiGianLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeHoach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEditTenPhuongAn
            // 
            this.textEditTenPhuongAn.Location = new System.Drawing.Point(153, 23);
            this.textEditTenPhuongAn.Name = "textEditTenPhuongAn";
            this.textEditTenPhuongAn.Properties.ReadOnly = true;
            this.textEditTenPhuongAn.Size = new System.Drawing.Size(361, 20);
            this.textEditTenPhuongAn.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.textEditTimKiem);
            this.panelControl1.Controls.Add(this.simpleButtonTimKiem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(619, 46);
            this.panelControl1.TabIndex = 4;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(21, 17);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(86, 13);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "Thông tin tìm kiếm";
            // 
            // textEditTimKiem
            // 
            this.textEditTimKiem.Location = new System.Drawing.Point(153, 14);
            this.textEditTimKiem.Name = "textEditTimKiem";
            this.textEditTimKiem.Size = new System.Drawing.Size(361, 20);
            this.textEditTimKiem.TabIndex = 24;
            this.textEditTimKiem.TextChanged += new System.EventHandler(this.textEditTimKiem_TextChanged);
            // 
            // simpleButtonTimKiem
            // 
            this.simpleButtonTimKiem.Location = new System.Drawing.Point(518, 11);
            this.simpleButtonTimKiem.Name = "simpleButtonTimKiem";
            this.simpleButtonTimKiem.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonTimKiem.TabIndex = 0;
            this.simpleButtonTimKiem.Text = "Tìm Kiếm";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Tên phương án";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(17, 53);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(115, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Thời gian lập phương án";
            // 
            // timeEditThoiGianLap
            // 
            this.timeEditThoiGianLap.EditValue = new System.DateTime(2020, 10, 20, 0, 0, 0, 0);
            this.timeEditThoiGianLap.Location = new System.Drawing.Point(153, 50);
            this.timeEditThoiGianLap.Name = "timeEditThoiGianLap";
            this.timeEditThoiGianLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEditThoiGianLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEditThoiGianLap.Properties.DisplayFormat.FormatString = "";
            this.timeEditThoiGianLap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeEditThoiGianLap.Properties.EditFormat.FormatString = "";
            this.timeEditThoiGianLap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeEditThoiGianLap.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.timeEditThoiGianLap.Properties.Mask.EditMask = "T";
            this.timeEditThoiGianLap.Properties.ReadOnly = true;
            this.timeEditThoiGianLap.Size = new System.Drawing.Size(361, 20);
            this.timeEditThoiGianLap.TabIndex = 15;
            // 
            // richEditControlChiTiet
            // 
            this.richEditControlChiTiet.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControlChiTiet.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.richEditControlChiTiet.Location = new System.Drawing.Point(153, 76);
            this.richEditControlChiTiet.Name = "richEditControlChiTiet";
            this.richEditControlChiTiet.ReadOnly = true;
            this.richEditControlChiTiet.Size = new System.Drawing.Size(361, 122);
            this.richEditControlChiTiet.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(17, 82);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(89, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Chi tiết phương án";
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Location = new System.Drawing.Point(519, 23);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonThem.TabIndex = 1;
            this.simpleButtonThem.Text = "Thêm mới";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThem_Click);
            // 
            // simpleButtonXoa
            // 
            this.simpleButtonXoa.Location = new System.Drawing.Point(520, 79);
            this.simpleButtonXoa.Name = "simpleButtonXoa";
            this.simpleButtonXoa.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonXoa.TabIndex = 20;
            this.simpleButtonXoa.Text = "Xóa";
            // 
            // simpleButtonLuu
            // 
            this.simpleButtonLuu.Location = new System.Drawing.Point(520, 108);
            this.simpleButtonLuu.Name = "simpleButtonLuu";
            this.simpleButtonLuu.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonLuu.TabIndex = 21;
            this.simpleButtonLuu.Text = "Lưu lại";
            this.simpleButtonLuu.Click += new System.EventHandler(this.simpleButtonLuu_Click);
            // 
            // simpleButtonMo
            // 
            this.simpleButtonMo.Location = new System.Drawing.Point(520, 137);
            this.simpleButtonMo.Name = "simpleButtonMo";
            this.simpleButtonMo.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonMo.TabIndex = 22;
            this.simpleButtonMo.Text = "Mở phương án";
            this.simpleButtonMo.Click += new System.EventHandler(this.simpleButtonMo_Click);
            // 
            // simpleButtonDong
            // 
            this.simpleButtonDong.Location = new System.Drawing.Point(520, 166);
            this.simpleButtonDong.Name = "simpleButtonDong";
            this.simpleButtonDong.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonDong.TabIndex = 23;
            this.simpleButtonDong.Text = "Đóng";
            this.simpleButtonDong.Click += new System.EventHandler(this.simpleButtonDong_Click);
            // 
            // dataGridViewKeHoach
            // 
            this.dataGridViewKeHoach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeHoach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKeHoach.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewKeHoach.MultiSelect = false;
            this.dataGridViewKeHoach.Name = "dataGridViewKeHoach";
            this.dataGridViewKeHoach.RowHeadersWidth = 51;
            this.dataGridViewKeHoach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKeHoach.Size = new System.Drawing.Size(613, 221);
            this.dataGridViewKeHoach.TabIndex = 25;
            this.dataGridViewKeHoach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKeHoach_CellClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 220);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Chọn bản đồ nền";
            // 
            // comboBoxMaBanDo
            // 
            this.comboBoxMaBanDo.FormattingEnabled = true;
            this.comboBoxMaBanDo.Location = new System.Drawing.Point(173, 216);
            this.comboBoxMaBanDo.Name = "comboBoxMaBanDo";
            this.comboBoxMaBanDo.Size = new System.Drawing.Size(126, 21);
            this.comboBoxMaBanDo.TabIndex = 27;
            this.comboBoxMaBanDo.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaBanDo_SelectedIndexChanged);
            // 
            // comboBoxMaFile
            // 
            this.comboBoxMaFile.FormattingEnabled = true;
            this.comboBoxMaFile.Location = new System.Drawing.Point(173, 249);
            this.comboBoxMaFile.Name = "comboBoxMaFile";
            this.comboBoxMaFile.Size = new System.Drawing.Size(126, 21);
            this.comboBoxMaFile.TabIndex = 29;
            this.comboBoxMaFile.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaFile_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 249);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "Chọn file Dem";
            // 
            // comboBoxTenFile
            // 
            this.comboBoxTenFile.FormattingEnabled = true;
            this.comboBoxTenFile.Location = new System.Drawing.Point(359, 249);
            this.comboBoxTenFile.Name = "comboBoxTenFile";
            this.comboBoxTenFile.Size = new System.Drawing.Size(155, 21);
            this.comboBoxTenFile.TabIndex = 31;
            this.comboBoxTenFile.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenFile_SelectedIndexChanged);
            // 
            // comboBoxTenBanDo
            // 
            this.comboBoxTenBanDo.FormattingEnabled = true;
            this.comboBoxTenBanDo.Location = new System.Drawing.Point(359, 216);
            this.comboBoxTenBanDo.Name = "comboBoxTenBanDo";
            this.comboBoxTenBanDo.Size = new System.Drawing.Size(155, 21);
            this.comboBoxTenBanDo.TabIndex = 30;
            this.comboBoxTenBanDo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenBanDo_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(153, 252);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(14, 13);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Mã";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(153, 219);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(14, 13);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "Mã";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(335, 252);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 13);
            this.labelControl6.TabIndex = 35;
            this.labelControl6.Text = "Tên";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(335, 219);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(18, 13);
            this.labelControl10.TabIndex = 34;
            this.labelControl10.Text = "Tên";
            // 
            // simpleButtonChinhSua
            // 
            this.simpleButtonChinhSua.Location = new System.Drawing.Point(519, 50);
            this.simpleButtonChinhSua.Name = "simpleButtonChinhSua";
            this.simpleButtonChinhSua.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonChinhSua.TabIndex = 36;
            this.simpleButtonChinhSua.Text = "Sửa";
            this.simpleButtonChinhSua.Click += new System.EventHandler(this.simpleButtonChinhSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.simpleButtonChinhSua);
            this.groupBox1.Controls.Add(this.timeEditThoiGianLap);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.textEditTenPhuongAn);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.richEditControlChiTiet);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.comboBoxTenFile);
            this.groupBox1.Controls.Add(this.simpleButtonThem);
            this.groupBox1.Controls.Add(this.comboBoxTenBanDo);
            this.groupBox1.Controls.Add(this.simpleButtonXoa);
            this.groupBox1.Controls.Add(this.comboBoxMaFile);
            this.groupBox1.Controls.Add(this.simpleButtonLuu);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.simpleButtonMo);
            this.groupBox1.Controls.Add(this.comboBoxMaBanDo);
            this.groupBox1.Controls.Add(this.simpleButtonDong);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 283);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phương án";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewKeHoach);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 241);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phương án";
            // 
            // QuanLyPhuongAnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl1);
            this.Name = "QuanLyPhuongAnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phương Án";
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenPhuongAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditThoiGianLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditThoiGianLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeHoach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit textEditTenPhuongAn;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit timeEditThoiGianLap;
        private DevExpress.XtraRichEdit.RichEditControl richEditControlChiTiet;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXoa;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLuu;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDong;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEditTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewKeHoach;
        public DevExpress.XtraEditors.SimpleButton simpleButtonMo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox comboBoxMaBanDo;
        private System.Windows.Forms.ComboBox comboBoxMaFile;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox comboBoxTenFile;
        private System.Windows.Forms.ComboBox comboBoxTenBanDo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton simpleButtonChinhSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}