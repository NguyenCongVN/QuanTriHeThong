﻿namespace DXApplication1.Admin
{
    partial class QuanLyNhanVien
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
            this.buttonSua = new System.Windows.Forms.Button();
            this.panelControlHienthitt = new DevExpress.XtraEditors.PanelControl();
            this.sidePanelThongTin = new DevExpress.XtraEditors.SidePanel();
            this.groupControlDanhSachNhanVien = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewDSNV = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDangNhapNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControlThongTinChiTiet = new DevExpress.XtraEditors.GroupControl();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.searchLookUpEditDSNV = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBoxChucVu = new System.Windows.Forms.TextBox();
            this.labelMaDangNhap = new System.Windows.Forms.Label();
            this.textBoxNgayTao = new System.Windows.Forms.TextBox();
            this.textBoxMaDangNhap = new System.Windows.Forms.TextBox();
            this.textBoxNgaySinh = new System.Windows.Forms.TextBox();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.labelSoDienThoai = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelChucVu = new System.Windows.Forms.Label();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelnvviet = new System.Windows.Forms.Label();
            this.labelnvketoan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHienthitt)).BeginInit();
            this.panelControlHienthitt.SuspendLayout();
            this.sidePanelThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDanhSachNhanVien)).BeginInit();
            this.groupControlDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinChiTiet)).BeginInit();
            this.groupControlThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditDSNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSua
            // 
            this.buttonSua.AutoSize = true;
            this.buttonSua.BackColor = System.Drawing.Color.Transparent;
            this.buttonSua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSua.Location = new System.Drawing.Point(992, 135);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(112, 41);
            this.buttonSua.TabIndex = 5;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // panelControlHienthitt
            // 
            this.panelControlHienthitt.Controls.Add(this.sidePanelThongTin);
            this.panelControlHienthitt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlHienthitt.Location = new System.Drawing.Point(0, 0);
            this.panelControlHienthitt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControlHienthitt.Name = "panelControlHienthitt";
            this.panelControlHienthitt.Size = new System.Drawing.Size(1605, 817);
            this.panelControlHienthitt.TabIndex = 4;
            // 
            // sidePanelThongTin
            // 
            this.sidePanelThongTin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sidePanelThongTin.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sidePanelThongTin.Appearance.Options.UseBackColor = true;
            this.sidePanelThongTin.Appearance.Options.UseBorderColor = true;
            this.sidePanelThongTin.Appearance.Options.UseForeColor = true;
            this.sidePanelThongTin.BorderThickness = 3;
            this.sidePanelThongTin.Controls.Add(this.groupControlDanhSachNhanVien);
            this.sidePanelThongTin.Controls.Add(this.groupControlThongTinChiTiet);
            this.sidePanelThongTin.Location = new System.Drawing.Point(498, 44);
            this.sidePanelThongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidePanelThongTin.Name = "sidePanelThongTin";
            this.sidePanelThongTin.Size = new System.Drawing.Size(1114, 662);
            this.sidePanelThongTin.TabIndex = 30;
            this.sidePanelThongTin.Text = "sidePanel1";
            // 
            // groupControlDanhSachNhanVien
            // 
            this.groupControlDanhSachNhanVien.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupControlDanhSachNhanVien.AppearanceCaption.Options.UseFont = true;
            this.groupControlDanhSachNhanVien.Controls.Add(this.dataGridViewDSNV);
            this.groupControlDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDanhSachNhanVien.Location = new System.Drawing.Point(0, 282);
            this.groupControlDanhSachNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControlDanhSachNhanVien.Name = "groupControlDanhSachNhanVien";
            this.groupControlDanhSachNhanVien.Size = new System.Drawing.Size(1114, 380);
            this.groupControlDanhSachNhanVien.TabIndex = 1;
            this.groupControlDanhSachNhanVien.Text = "Danh Sách Nhân Viên";
            // 
            // dataGridViewDSNV
            // 
            this.dataGridViewDSNV.AllowUserToAddRows = false;
            this.dataGridViewDSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaDangNhapNguoiDung,
            this.HoTen,
            this.NgaySinh,
            this.SoDienThoai,
            this.Email,
            this.DiaChi,
            this.TenChucVu,
            this.NgayTao});
            this.dataGridViewDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDSNV.Location = new System.Drawing.Point(2, 30);
            this.dataGridViewDSNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDSNV.Name = "dataGridViewDSNV";
            this.dataGridViewDSNV.RowHeadersWidth = 51;
            this.dataGridViewDSNV.RowTemplate.Height = 24;
            this.dataGridViewDSNV.Size = new System.Drawing.Size(1110, 348);
            this.dataGridViewDSNV.TabIndex = 0;
            this.dataGridViewDSNV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSNV_CellEnter);
            this.dataGridViewDSNV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewDSNV_RowPrePaint);
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
            // MaDangNhapNguoiDung
            // 
            this.MaDangNhapNguoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaDangNhapNguoiDung.DataPropertyName = "MaDangNhapNguoiDung";
            this.MaDangNhapNguoiDung.HeaderText = "Mã nhân viên";
            this.MaDangNhapNguoiDung.MinimumWidth = 6;
            this.MaDangNhapNguoiDung.Name = "MaDangNhapNguoiDung";
            this.MaDangNhapNguoiDung.ReadOnly = true;
            this.MaDangNhapNguoiDung.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.FillWeight = 89.12591F;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.FillWeight = 89.12591F;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 89.12591F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.FillWeight = 89.12591F;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // TenChucVu
            // 
            this.TenChucVu.DataPropertyName = "TenChucVu";
            this.TenChucVu.FillWeight = 89.12591F;
            this.TenChucVu.HeaderText = "Chức vụ";
            this.TenChucVu.MinimumWidth = 6;
            this.TenChucVu.Name = "TenChucVu";
            this.TenChucVu.ReadOnly = true;
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "NgayTao";
            this.NgayTao.FillWeight = 89.12591F;
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.MinimumWidth = 6;
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            // 
            // groupControlThongTinChiTiet
            // 
            this.groupControlThongTinChiTiet.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlThongTinChiTiet.AppearanceCaption.Options.UseFont = true;
            this.groupControlThongTinChiTiet.Controls.Add(this.buttonThoat);
            this.groupControlThongTinChiTiet.Controls.Add(this.label1);
            this.groupControlThongTinChiTiet.Controls.Add(this.buttonXoa);
            this.groupControlThongTinChiTiet.Controls.Add(this.searchLookUpEditDSNV);
            this.groupControlThongTinChiTiet.Controls.Add(this.buttonThem);
            this.groupControlThongTinChiTiet.Controls.Add(this.buttonSua);
            this.groupControlThongTinChiTiet.Controls.Add(this.textBoxChucVu);
            this.groupControlThongTinChiTiet.Controls.Add(this.labelMaDangNhap);
            this.groupControlThongTinChiTiet.Controls.Add(this.textBoxNgayTao);
            this.groupControlThongTinChiTiet.Controls.Add(this.textBoxMaDangNhap);
            this.groupControlThongTinChiTiet.Controls.Add(this.textBoxNgaySinh);
            this.groupControlThongTinChiTiet.Controls.Add(this.labelHoTen);
            this.groupControlThongTinChiTiet.Controls.Add(this.textBoxDiaChi);
            this.groupControlThongTinChiTiet.Controls.Add(this.labelEmail);
            this.groupControlThongTinChiTiet.Controls.Add(this.textBoxHoTen);
            this.groupControlThongTinChiTiet.Controls.Add(this.labelSoDienThoai);
            this.groupControlThongTinChiTiet.Controls.Add(this.textBoxEmail);
            this.groupControlThongTinChiTiet.Controls.Add(this.labelChucVu);
            this.groupControlThongTinChiTiet.Controls.Add(this.textBoxSoDienThoai);
            this.groupControlThongTinChiTiet.Controls.Add(this.labelNgaySinh);
            this.groupControlThongTinChiTiet.Controls.Add(this.labelnvviet);
            this.groupControlThongTinChiTiet.Controls.Add(this.labelnvketoan);
            this.groupControlThongTinChiTiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlThongTinChiTiet.Location = new System.Drawing.Point(0, 0);
            this.groupControlThongTinChiTiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControlThongTinChiTiet.Name = "groupControlThongTinChiTiet";
            this.groupControlThongTinChiTiet.Size = new System.Drawing.Size(1114, 282);
            this.groupControlThongTinChiTiet.TabIndex = 0;
            this.groupControlThongTinChiTiet.Text = "Thông Tin Chi Tiết";
            // 
            // buttonThoat
            // 
            this.buttonThoat.AutoSize = true;
            this.buttonThoat.BackColor = System.Drawing.Color.Transparent;
            this.buttonThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonThoat.Location = new System.Drawing.Point(992, 214);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(112, 41);
            this.buttonThoat.TabIndex = 9;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(186, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tìm kiếm/lọc thông tin";
            // 
            // buttonXoa
            // 
            this.buttonXoa.AutoSize = true;
            this.buttonXoa.BackColor = System.Drawing.Color.Transparent;
            this.buttonXoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonXoa.Location = new System.Drawing.Point(992, 175);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(112, 41);
            this.buttonXoa.TabIndex = 8;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // searchLookUpEditDSNV
            // 
            this.searchLookUpEditDSNV.EditValue = " ";
            this.searchLookUpEditDSNV.Location = new System.Drawing.Point(398, 42);
            this.searchLookUpEditDSNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchLookUpEditDSNV.Name = "searchLookUpEditDSNV";
            this.searchLookUpEditDSNV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEditDSNV.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEditDSNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditDSNV.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEditDSNV.Size = new System.Drawing.Size(385, 28);
            this.searchLookUpEditDSNV.TabIndex = 2;
            this.searchLookUpEditDSNV.EditValueChanged += new System.EventHandler(this.searchLookUpEditDSNV_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // buttonThem
            // 
            this.buttonThem.AutoSize = true;
            this.buttonThem.BackColor = System.Drawing.Color.Transparent;
            this.buttonThem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonThem.Location = new System.Drawing.Point(992, 96);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(112, 41);
            this.buttonThem.TabIndex = 7;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // textBoxChucVu
            // 
            this.textBoxChucVu.Enabled = false;
            this.textBoxChucVu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChucVu.Location = new System.Drawing.Point(660, 178);
            this.textBoxChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxChucVu.Name = "textBoxChucVu";
            this.textBoxChucVu.ReadOnly = true;
            this.textBoxChucVu.Size = new System.Drawing.Size(310, 28);
            this.textBoxChucVu.TabIndex = 29;
            // 
            // labelMaDangNhap
            // 
            this.labelMaDangNhap.AutoSize = true;
            this.labelMaDangNhap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelMaDangNhap.Location = new System.Drawing.Point(7, 99);
            this.labelMaDangNhap.Name = "labelMaDangNhap";
            this.labelMaDangNhap.Size = new System.Drawing.Size(135, 21);
            this.labelMaDangNhap.TabIndex = 2;
            this.labelMaDangNhap.Text = "Mã Đăng Nhập";
            // 
            // textBoxNgayTao
            // 
            this.textBoxNgayTao.Enabled = false;
            this.textBoxNgayTao.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNgayTao.Location = new System.Drawing.Point(660, 219);
            this.textBoxNgayTao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNgayTao.Name = "textBoxNgayTao";
            this.textBoxNgayTao.ReadOnly = true;
            this.textBoxNgayTao.Size = new System.Drawing.Size(310, 28);
            this.textBoxNgayTao.TabIndex = 28;
            // 
            // textBoxMaDangNhap
            // 
            this.textBoxMaDangNhap.Enabled = false;
            this.textBoxMaDangNhap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaDangNhap.Location = new System.Drawing.Point(149, 97);
            this.textBoxMaDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaDangNhap.Name = "textBoxMaDangNhap";
            this.textBoxMaDangNhap.ReadOnly = true;
            this.textBoxMaDangNhap.Size = new System.Drawing.Size(314, 28);
            this.textBoxMaDangNhap.TabIndex = 3;
            // 
            // textBoxNgaySinh
            // 
            this.textBoxNgaySinh.Enabled = false;
            this.textBoxNgaySinh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNgaySinh.Location = new System.Drawing.Point(660, 97);
            this.textBoxNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNgaySinh.Name = "textBoxNgaySinh";
            this.textBoxNgaySinh.ReadOnly = true;
            this.textBoxNgaySinh.Size = new System.Drawing.Size(310, 28);
            this.textBoxNgaySinh.TabIndex = 27;
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelHoTen.Location = new System.Drawing.Point(14, 140);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(67, 21);
            this.labelHoTen.TabIndex = 4;
            this.labelHoTen.Text = "Họ tên";
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Enabled = false;
            this.textBoxDiaChi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiaChi.Location = new System.Drawing.Point(660, 138);
            this.textBoxDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.ReadOnly = true;
            this.textBoxDiaChi.Size = new System.Drawing.Size(310, 28);
            this.textBoxDiaChi.TabIndex = 22;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelEmail.Location = new System.Drawing.Point(14, 182);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 21);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Enabled = false;
            this.textBoxHoTen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTen.Location = new System.Drawing.Point(149, 137);
            this.textBoxHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.ReadOnly = true;
            this.textBoxHoTen.Size = new System.Drawing.Size(314, 28);
            this.textBoxHoTen.TabIndex = 21;
            // 
            // labelSoDienThoai
            // 
            this.labelSoDienThoai.AutoSize = true;
            this.labelSoDienThoai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelSoDienThoai.Location = new System.Drawing.Point(14, 224);
            this.labelSoDienThoai.Name = "labelSoDienThoai";
            this.labelSoDienThoai.Size = new System.Drawing.Size(123, 21);
            this.labelSoDienThoai.TabIndex = 6;
            this.labelSoDienThoai.Text = "Số điện thoại";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(149, 176);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(314, 28);
            this.textBoxEmail.TabIndex = 20;
            // 
            // labelChucVu
            // 
            this.labelChucVu.AutoSize = true;
            this.labelChucVu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelChucVu.Location = new System.Drawing.Point(492, 180);
            this.labelChucVu.Name = "labelChucVu";
            this.labelChucVu.Size = new System.Drawing.Size(79, 21);
            this.labelChucVu.TabIndex = 14;
            this.labelChucVu.Text = "Chức vụ";
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.Enabled = false;
            this.textBoxSoDienThoai.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(149, 215);
            this.textBoxSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.ReadOnly = true;
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(314, 28);
            this.textBoxSoDienThoai.TabIndex = 19;
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelNgaySinh.Location = new System.Drawing.Point(492, 97);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(97, 21);
            this.labelNgaySinh.TabIndex = 15;
            this.labelNgaySinh.Text = "Ngày Sinh";
            // 
            // labelnvviet
            // 
            this.labelnvviet.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelnvviet.Location = new System.Drawing.Point(492, 139);
            this.labelnvviet.Name = "labelnvviet";
            this.labelnvviet.Size = new System.Drawing.Size(142, 22);
            this.labelnvviet.TabIndex = 17;
            this.labelnvviet.Text = "Địa chỉ";
            // 
            // labelnvketoan
            // 
            this.labelnvketoan.AutoSize = true;
            this.labelnvketoan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelnvketoan.Location = new System.Drawing.Point(492, 222);
            this.labelnvketoan.Name = "labelnvketoan";
            this.labelnvketoan.Size = new System.Drawing.Size(172, 21);
            this.labelnvketoan.TabIndex = 16;
            this.labelnvketoan.Text = "Ngày tạo tài khoản";
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 817);
            this.Controls.Add(this.panelControlHienthitt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyNhanVien";
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHienthitt)).EndInit();
            this.panelControlHienthitt.ResumeLayout(false);
            this.sidePanelThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDanhSachNhanVien)).EndInit();
            this.groupControlDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinChiTiet)).EndInit();
            this.groupControlThongTinChiTiet.ResumeLayout(false);
            this.groupControlThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditDSNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSua;
        private DevExpress.XtraEditors.PanelControl panelControlHienthitt;
        private System.Windows.Forms.Label labelnvviet;
        private System.Windows.Forms.Label labelnvketoan;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelChucVu;
        private System.Windows.Forms.Label labelSoDienThoai;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.TextBox textBoxMaDangNhap;
        private System.Windows.Forms.Label labelMaDangNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditDSNV;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        public System.Windows.Forms.DataGridView dataGridViewDSNV;
        private System.Windows.Forms.TextBox textBoxChucVu;
        private System.Windows.Forms.TextBox textBoxNgayTao;
        private System.Windows.Forms.TextBox textBoxNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDangNhapNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.Button buttonThoat;
        private DevExpress.XtraEditors.SidePanel sidePanelThongTin;
        private DevExpress.XtraEditors.GroupControl groupControlDanhSachNhanVien;
        private DevExpress.XtraEditors.GroupControl groupControlThongTinChiTiet;
        private System.Windows.Forms.Label label1;
    }
}