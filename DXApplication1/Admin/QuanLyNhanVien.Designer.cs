namespace DXApplication1.Admin
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
            this.labelCapnhat = new System.Windows.Forms.Label();
            this.buttonSua = new System.Windows.Forms.Button();
            this.panelControlHienthitt = new DevExpress.XtraEditors.PanelControl();
            this.textBoxNgaySinh = new System.Windows.Forms.TextBox();
            this.textBoxNgayTao = new System.Windows.Forms.TextBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxChucVu = new System.Windows.Forms.TextBox();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.labelnvviet = new System.Windows.Forms.Label();
            this.labelnvketoan = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelChucVu = new System.Windows.Forms.Label();
            this.labelSoDienThoai = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.textBoxMaDangNhap = new System.Windows.Forms.TextBox();
            this.labelMaDangNhap = new System.Windows.Forms.Label();
            this.panelControlCapNhat = new DevExpress.XtraEditors.PanelControl();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.labelHienthitt = new System.Windows.Forms.Label();
            this.labelDSNV = new System.Windows.Forms.Label();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.searchLookUpEditDSNV = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.dataGridViewDSNV = new System.Windows.Forms.DataGridView();
            this.btnPre = new System.Windows.Forms.Button();
            this.panelDSNV = new System.Windows.Forms.Panel();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDangNhapNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHienthitt)).BeginInit();
            this.panelControlHienthitt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCapNhat)).BeginInit();
            this.panelControlCapNhat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditDSNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNV)).BeginInit();
            this.panelDSNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCapnhat
            // 
            this.labelCapnhat.AutoSize = true;
            this.labelCapnhat.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCapnhat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapnhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCapnhat.Location = new System.Drawing.Point(2, 2);
            this.labelCapnhat.Name = "labelCapnhat";
            this.labelCapnhat.Size = new System.Drawing.Size(110, 26);
            this.labelCapnhat.TabIndex = 0;
            this.labelCapnhat.Text = "Cập Nhật";
            // 
            // buttonSua
            // 
            this.buttonSua.AutoSize = true;
            this.buttonSua.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSua.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSua.Location = new System.Drawing.Point(198, 166);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(204, 69);
            this.buttonSua.TabIndex = 5;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // panelControlHienthitt
            // 
            this.panelControlHienthitt.Controls.Add(this.textBoxNgaySinh);
            this.panelControlHienthitt.Controls.Add(this.textBoxNgayTao);
            this.panelControlHienthitt.Controls.Add(this.textBoxDiaChi);
            this.panelControlHienthitt.Controls.Add(this.textBoxHoTen);
            this.panelControlHienthitt.Controls.Add(this.textBoxEmail);
            this.panelControlHienthitt.Controls.Add(this.textBoxChucVu);
            this.panelControlHienthitt.Controls.Add(this.textBoxSoDienThoai);
            this.panelControlHienthitt.Controls.Add(this.labelnvviet);
            this.panelControlHienthitt.Controls.Add(this.labelnvketoan);
            this.panelControlHienthitt.Controls.Add(this.labelNgaySinh);
            this.panelControlHienthitt.Controls.Add(this.labelChucVu);
            this.panelControlHienthitt.Controls.Add(this.labelSoDienThoai);
            this.panelControlHienthitt.Controls.Add(this.labelEmail);
            this.panelControlHienthitt.Controls.Add(this.labelHoTen);
            this.panelControlHienthitt.Controls.Add(this.textBoxMaDangNhap);
            this.panelControlHienthitt.Controls.Add(this.labelMaDangNhap);
            this.panelControlHienthitt.Controls.Add(this.panelControlCapNhat);
            this.panelControlHienthitt.Controls.Add(this.labelHienthitt);
            this.panelControlHienthitt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlHienthitt.Location = new System.Drawing.Point(0, 0);
            this.panelControlHienthitt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControlHienthitt.Name = "panelControlHienthitt";
            this.panelControlHienthitt.Size = new System.Drawing.Size(1638, 410);
            this.panelControlHienthitt.TabIndex = 4;
            // 
            // textBoxNgaySinh
            // 
            this.textBoxNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNgaySinh.Location = new System.Drawing.Point(778, 93);
            this.textBoxNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNgaySinh.Name = "textBoxNgaySinh";
            this.textBoxNgaySinh.ReadOnly = true;
            this.textBoxNgaySinh.Size = new System.Drawing.Size(244, 30);
            this.textBoxNgaySinh.TabIndex = 26;
            // 
            // textBoxNgayTao
            // 
            this.textBoxNgayTao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNgayTao.Location = new System.Drawing.Point(778, 345);
            this.textBoxNgayTao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNgayTao.Name = "textBoxNgayTao";
            this.textBoxNgayTao.ReadOnly = true;
            this.textBoxNgayTao.Size = new System.Drawing.Size(244, 30);
            this.textBoxNgayTao.TabIndex = 25;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Enabled = false;
            this.textBoxDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiaChi.Location = new System.Drawing.Point(778, 183);
            this.textBoxDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.ReadOnly = true;
            this.textBoxDiaChi.Size = new System.Drawing.Size(244, 30);
            this.textBoxDiaChi.TabIndex = 22;
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Enabled = false;
            this.textBoxHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTen.Location = new System.Drawing.Point(188, 183);
            this.textBoxHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.ReadOnly = true;
            this.textBoxHoTen.Size = new System.Drawing.Size(244, 30);
            this.textBoxHoTen.TabIndex = 21;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(188, 265);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(244, 30);
            this.textBoxEmail.TabIndex = 20;
            // 
            // textBoxChucVu
            // 
            this.textBoxChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChucVu.Location = new System.Drawing.Point(778, 261);
            this.textBoxChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxChucVu.Name = "textBoxChucVu";
            this.textBoxChucVu.ReadOnly = true;
            this.textBoxChucVu.Size = new System.Drawing.Size(244, 30);
            this.textBoxChucVu.TabIndex = 18;
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.Enabled = false;
            this.textBoxSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(188, 345);
            this.textBoxSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.ReadOnly = true;
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(244, 30);
            this.textBoxSoDienThoai.TabIndex = 19;
            // 
            // labelnvviet
            // 
            this.labelnvviet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnvviet.Location = new System.Drawing.Point(599, 187);
            this.labelnvviet.Name = "labelnvviet";
            this.labelnvviet.Size = new System.Drawing.Size(142, 22);
            this.labelnvviet.TabIndex = 17;
            this.labelnvviet.Text = "Địa chỉ";
            // 
            // labelnvketoan
            // 
            this.labelnvketoan.AutoSize = true;
            this.labelnvketoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnvketoan.Location = new System.Drawing.Point(599, 353);
            this.labelnvketoan.Name = "labelnvketoan";
            this.labelnvketoan.Size = new System.Drawing.Size(156, 22);
            this.labelnvketoan.TabIndex = 16;
            this.labelnvketoan.Text = "Ngày tạo tài khoản";
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaySinh.Location = new System.Drawing.Point(599, 101);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(91, 22);
            this.labelNgaySinh.TabIndex = 15;
            this.labelNgaySinh.Text = "Ngày Sinh";
            // 
            // labelChucVu
            // 
            this.labelChucVu.AutoSize = true;
            this.labelChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChucVu.Location = new System.Drawing.Point(599, 268);
            this.labelChucVu.Name = "labelChucVu";
            this.labelChucVu.Size = new System.Drawing.Size(76, 22);
            this.labelChucVu.TabIndex = 14;
            this.labelChucVu.Text = "Chức vụ";
            // 
            // labelSoDienThoai
            // 
            this.labelSoDienThoai.AutoSize = true;
            this.labelSoDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoDienThoai.Location = new System.Drawing.Point(10, 350);
            this.labelSoDienThoai.Name = "labelSoDienThoai";
            this.labelSoDienThoai.Size = new System.Drawing.Size(114, 22);
            this.labelSoDienThoai.TabIndex = 6;
            this.labelSoDienThoai.Text = "Số điện thoại";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(10, 265);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 22);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.Location = new System.Drawing.Point(10, 187);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(62, 22);
            this.labelHoTen.TabIndex = 4;
            this.labelHoTen.Text = "Họ tên";
            // 
            // textBoxMaDangNhap
            // 
            this.textBoxMaDangNhap.Enabled = false;
            this.textBoxMaDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaDangNhap.Location = new System.Drawing.Point(188, 101);
            this.textBoxMaDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaDangNhap.Name = "textBoxMaDangNhap";
            this.textBoxMaDangNhap.ReadOnly = true;
            this.textBoxMaDangNhap.Size = new System.Drawing.Size(244, 30);
            this.textBoxMaDangNhap.TabIndex = 3;
            // 
            // labelMaDangNhap
            // 
            this.labelMaDangNhap.AutoSize = true;
            this.labelMaDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaDangNhap.Location = new System.Drawing.Point(10, 101);
            this.labelMaDangNhap.Name = "labelMaDangNhap";
            this.labelMaDangNhap.Size = new System.Drawing.Size(129, 22);
            this.labelMaDangNhap.TabIndex = 2;
            this.labelMaDangNhap.Text = "Mã Đăng Nhập";
            // 
            // panelControlCapNhat
            // 
            this.panelControlCapNhat.Controls.Add(this.buttonXoa);
            this.panelControlCapNhat.Controls.Add(this.buttonThem);
            this.panelControlCapNhat.Controls.Add(this.buttonSua);
            this.panelControlCapNhat.Controls.Add(this.labelCapnhat);
            this.panelControlCapNhat.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControlCapNhat.Location = new System.Drawing.Point(1099, 35);
            this.panelControlCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControlCapNhat.Name = "panelControlCapNhat";
            this.panelControlCapNhat.Size = new System.Drawing.Size(537, 373);
            this.panelControlCapNhat.TabIndex = 1;
            // 
            // buttonXoa
            // 
            this.buttonXoa.AutoSize = true;
            this.buttonXoa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonXoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonXoa.Location = new System.Drawing.Point(198, 312);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(204, 69);
            this.buttonXoa.TabIndex = 8;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.AutoSize = true;
            this.buttonThem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThem.Location = new System.Drawing.Point(198, 38);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(204, 69);
            this.buttonThem.TabIndex = 7;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // labelHienthitt
            // 
            this.labelHienthitt.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHienthitt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHienthitt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelHienthitt.Location = new System.Drawing.Point(2, 2);
            this.labelHienthitt.Name = "labelHienthitt";
            this.labelHienthitt.Size = new System.Drawing.Size(1634, 33);
            this.labelHienthitt.TabIndex = 0;
            this.labelHienthitt.Text = "Thông Tin Chi Tiết";
            // 
            // labelDSNV
            // 
            this.labelDSNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDSNV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDSNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDSNV.Location = new System.Drawing.Point(0, 0);
            this.labelDSNV.Name = "labelDSNV";
            this.labelDSNV.Size = new System.Drawing.Size(1638, 47);
            this.labelDSNV.TabIndex = 1;
            this.labelDSNV.Text = "Danh Sách Nhân Viên";
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnNext
            // 
            this.btnNext.ForeColor = System.Drawing.Color.Aqua;
            this.btnNext.Location = new System.Drawing.Point(1491, 162);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(48, 31);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // searchLookUpEditDSNV
            // 
            this.searchLookUpEditDSNV.EditValue = " ";
            this.searchLookUpEditDSNV.Location = new System.Drawing.Point(337, 0);
            this.searchLookUpEditDSNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchLookUpEditDSNV.Name = "searchLookUpEditDSNV";
            this.searchLookUpEditDSNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookUpEditDSNV.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEditDSNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditDSNV.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEditDSNV.Size = new System.Drawing.Size(385, 28);
            this.searchLookUpEditDSNV.TabIndex = 2;
            // 
            // dataGridViewDSNV
            // 
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
            this.MaChucVu,
            this.NgayTao});
            this.dataGridViewDSNV.Location = new System.Drawing.Point(76, 50);
            this.dataGridViewDSNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDSNV.Name = "dataGridViewDSNV";
            this.dataGridViewDSNV.RowHeadersWidth = 51;
            this.dataGridViewDSNV.RowTemplate.Height = 24;
            this.dataGridViewDSNV.Size = new System.Drawing.Size(1400, 263);
            this.dataGridViewDSNV.TabIndex = 0;
            this.dataGridViewDSNV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSNV_CellEnter);
            this.dataGridViewDSNV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewDSNV_RowPrePaint);
            // 
            // btnPre
            // 
            this.btnPre.ForeColor = System.Drawing.Color.Aqua;
            this.btnPre.Location = new System.Drawing.Point(16, 162);
            this.btnPre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(44, 31);
            this.btnPre.TabIndex = 4;
            this.btnPre.Text = "<<";
            this.btnPre.UseVisualStyleBackColor = true;
            // 
            // panelDSNV
            // 
            this.panelDSNV.Controls.Add(this.btnPre);
            this.panelDSNV.Controls.Add(this.btnNext);
            this.panelDSNV.Controls.Add(this.searchLookUpEditDSNV);
            this.panelDSNV.Controls.Add(this.labelDSNV);
            this.panelDSNV.Controls.Add(this.dataGridViewDSNV);
            this.panelDSNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDSNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDSNV.Location = new System.Drawing.Point(0, 410);
            this.panelDSNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDSNV.Name = "panelDSNV";
            this.panelDSNV.Size = new System.Drawing.Size(1638, 407);
            this.panelDSNV.TabIndex = 3;
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
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.FillWeight = 89.12591F;
            this.MaChucVu.HeaderText = "Chức vụ";
            this.MaChucVu.MinimumWidth = 6;
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.ReadOnly = true;
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
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 817);
            this.Controls.Add(this.panelControlHienthitt);
            this.Controls.Add(this.panelDSNV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHienthitt)).EndInit();
            this.panelControlHienthitt.ResumeLayout(false);
            this.panelControlHienthitt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlCapNhat)).EndInit();
            this.panelControlCapNhat.ResumeLayout(false);
            this.panelControlCapNhat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditDSNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNV)).EndInit();
            this.panelDSNV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelCapnhat;
        private System.Windows.Forms.Button buttonSua;
        private DevExpress.XtraEditors.PanelControl panelControlHienthitt;
        private System.Windows.Forms.TextBox textBoxChucVu;
        private System.Windows.Forms.Label labelnvviet;
        private System.Windows.Forms.Label labelnvketoan;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelChucVu;
        private System.Windows.Forms.Label labelSoDienThoai;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.TextBox textBoxMaDangNhap;
        private System.Windows.Forms.Label labelMaDangNhap;
        private DevExpress.XtraEditors.PanelControl panelControlCapNhat;
        private System.Windows.Forms.Label labelHienthitt;
        private System.Windows.Forms.Label labelDSNV;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Button btnNext;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditDSNV;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Panel panelDSNV;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox textBoxNgaySinh;
        private System.Windows.Forms.TextBox textBoxNgayTao;
        public System.Windows.Forms.DataGridView dataGridViewDSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDangNhapNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
    }
}