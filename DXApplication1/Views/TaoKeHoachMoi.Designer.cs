﻿namespace DXApplication1.Views
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
            this.simpleButtonSua = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLuu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonMo = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDong = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewKeHoach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenPhuongAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditThoiGianLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditThoiGianLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeHoach)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditTenPhuongAn
            // 
            this.textEditTenPhuongAn.Location = new System.Drawing.Point(133, 108);
            this.textEditTenPhuongAn.Name = "textEditTenPhuongAn";
            this.textEditTenPhuongAn.Size = new System.Drawing.Size(361, 20);
            this.textEditTenPhuongAn.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.textEditTimKiem);
            this.panelControl1.Controls.Add(this.simpleButtonTimKiem);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(602, 74);
            this.panelControl1.TabIndex = 4;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(5, 28);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(86, 13);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "Thông tin tìm kiếm";
            // 
            // textEditTimKiem
            // 
            this.textEditTimKiem.Location = new System.Drawing.Point(121, 25);
            this.textEditTimKiem.Name = "textEditTimKiem";
            this.textEditTimKiem.Size = new System.Drawing.Size(361, 20);
            this.textEditTimKiem.TabIndex = 24;
            // 
            // simpleButtonTimKiem
            // 
            this.simpleButtonTimKiem.Location = new System.Drawing.Point(507, 23);
            this.simpleButtonTimKiem.Name = "simpleButtonTimKiem";
            this.simpleButtonTimKiem.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonTimKiem.TabIndex = 0;
            this.simpleButtonTimKiem.Text = "Tìm Kiếm";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Tên phương án";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(17, 139);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(115, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Thời gian lập phương án";
            // 
            // timeEditThoiGianLap
            // 
            this.timeEditThoiGianLap.EditValue = new System.DateTime(2020, 10, 20, 0, 0, 0, 0);
            this.timeEditThoiGianLap.Location = new System.Drawing.Point(133, 136);
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
            this.timeEditThoiGianLap.Size = new System.Drawing.Size(361, 20);
            this.timeEditThoiGianLap.TabIndex = 15;
            // 
            // richEditControlChiTiet
            // 
            this.richEditControlChiTiet.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControlChiTiet.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.richEditControlChiTiet.Location = new System.Drawing.Point(133, 162);
            this.richEditControlChiTiet.Name = "richEditControlChiTiet";
            this.richEditControlChiTiet.Size = new System.Drawing.Size(361, 166);
            this.richEditControlChiTiet.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(17, 175);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(89, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Chi tiết phương án";
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Location = new System.Drawing.Point(519, 105);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonThem.TabIndex = 1;
            this.simpleButtonThem.Text = "Thêm mới";
            // 
            // simpleButtonSua
            // 
            this.simpleButtonSua.Location = new System.Drawing.Point(519, 134);
            this.simpleButtonSua.Name = "simpleButtonSua";
            this.simpleButtonSua.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonSua.TabIndex = 19;
            this.simpleButtonSua.Text = "Sửa";
            // 
            // simpleButtonXoa
            // 
            this.simpleButtonXoa.Location = new System.Drawing.Point(519, 163);
            this.simpleButtonXoa.Name = "simpleButtonXoa";
            this.simpleButtonXoa.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonXoa.TabIndex = 20;
            this.simpleButtonXoa.Text = "Xóa";
            // 
            // simpleButtonLuu
            // 
            this.simpleButtonLuu.Location = new System.Drawing.Point(519, 192);
            this.simpleButtonLuu.Name = "simpleButtonLuu";
            this.simpleButtonLuu.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonLuu.TabIndex = 21;
            this.simpleButtonLuu.Text = "Lưu lại";
            this.simpleButtonLuu.Click += new System.EventHandler(this.simpleButtonLuu_Click);
            // 
            // simpleButtonMo
            // 
            this.simpleButtonMo.Location = new System.Drawing.Point(519, 221);
            this.simpleButtonMo.Name = "simpleButtonMo";
            this.simpleButtonMo.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonMo.TabIndex = 22;
            this.simpleButtonMo.Text = "Mở phương án";
            this.simpleButtonMo.Click += new System.EventHandler(this.simpleButtonMo_Click);
            // 
            // simpleButtonDong
            // 
            this.simpleButtonDong.Location = new System.Drawing.Point(519, 250);
            this.simpleButtonDong.Name = "simpleButtonDong";
            this.simpleButtonDong.Size = new System.Drawing.Size(90, 23);
            this.simpleButtonDong.TabIndex = 23;
            this.simpleButtonDong.Text = "Đóng";
            // 
            // dataGridViewKeHoach
            // 
            this.dataGridViewKeHoach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeHoach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewKeHoach.Location = new System.Drawing.Point(0, 347);
            this.dataGridViewKeHoach.MultiSelect = false;
            this.dataGridViewKeHoach.Name = "dataGridViewKeHoach";
            this.dataGridViewKeHoach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKeHoach.Size = new System.Drawing.Size(621, 108);
            this.dataGridViewKeHoach.TabIndex = 25;
            this.dataGridViewKeHoach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKeHoach_CellClick);
            // 
            // QuanLyPhuongAnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 455);
            this.Controls.Add(this.dataGridViewKeHoach);
            this.Controls.Add(this.simpleButtonDong);
            this.Controls.Add(this.simpleButtonMo);
            this.Controls.Add(this.simpleButtonLuu);
            this.Controls.Add(this.simpleButtonXoa);
            this.Controls.Add(this.simpleButtonSua);
            this.Controls.Add(this.simpleButtonThem);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.richEditControlChiTiet);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.textEditTenPhuongAn);
            this.Controls.Add(this.timeEditThoiGianLap);
            this.Name = "QuanLyPhuongAnForm";
            this.Text = "Quản Lý Phương Án";
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenPhuongAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditThoiGianLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditThoiGianLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeHoach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraEditors.SimpleButton simpleButtonSua;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXoa;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLuu;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMo;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDong;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEditTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewKeHoach;
    }
}