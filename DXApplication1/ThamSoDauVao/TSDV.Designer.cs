namespace DXApplication1.Views
{
    partial class TSDV
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
            this.sidePanelThamSoDauVao = new DevExpress.XtraEditors.SidePanel();
            this.groupControlDanhSachNhanVien = new DevExpress.XtraEditors.GroupControl();
            this.dataGridViewTSDV = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idThamSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_water_velocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y_water_velocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x_wind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y_wind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upward_velocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.significant_height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokes_drift_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokes_drift_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salinity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLoaiDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoiluongdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianmophong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitridauthatthoat_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitridauthatthoat_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControlThongTinChiTiet = new DevExpress.XtraEditors.GroupControl();
            this.tbthoigian = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbvitrithatthoat_y = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbtemperature = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbmathamso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbmaloaidau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbsalinity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbvitrithatthoat_x = new System.Windows.Forms.TextBox();
            this.tbluongdau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbupward_sea = new System.Windows.Forms.TextBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchLookUpEditTSDV = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tbdrift_y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.tbdrift_x = new System.Windows.Forms.TextBox();
            this.buttonSua = new System.Windows.Forms.Button();
            this.tbsign_height = new System.Windows.Forms.TextBox();
            this.labelMaDangNhap = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_water = new System.Windows.Forms.TextBox();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tby_water = new System.Windows.Forms.TextBox();
            this.labelSoDienThoai = new System.Windows.Forms.Label();
            this.tbx_wind = new System.Windows.Forms.TextBox();
            this.tby_wind = new System.Windows.Forms.TextBox();
            this.sidePanelThamSoDauVao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDanhSachNhanVien)).BeginInit();
            this.groupControlDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTSDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinChiTiet)).BeginInit();
            this.groupControlThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditTSDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanelThamSoDauVao
            // 
            this.sidePanelThamSoDauVao.Controls.Add(this.groupControlDanhSachNhanVien);
            this.sidePanelThamSoDauVao.Controls.Add(this.groupControlThongTinChiTiet);
            this.sidePanelThamSoDauVao.Location = new System.Drawing.Point(160, 42);
            this.sidePanelThamSoDauVao.Name = "sidePanelThamSoDauVao";
            this.sidePanelThamSoDauVao.Size = new System.Drawing.Size(1493, 652);
            this.sidePanelThamSoDauVao.TabIndex = 4;
            this.sidePanelThamSoDauVao.Text = "sidePanel1";
            // 
            // groupControlDanhSachNhanVien
            // 
            this.groupControlDanhSachNhanVien.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlDanhSachNhanVien.AppearanceCaption.Options.UseFont = true;
            this.groupControlDanhSachNhanVien.Controls.Add(this.dataGridViewTSDV);
            this.groupControlDanhSachNhanVien.Location = new System.Drawing.Point(0, 327);
            this.groupControlDanhSachNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControlDanhSachNhanVien.Name = "groupControlDanhSachNhanVien";
            this.groupControlDanhSachNhanVien.Size = new System.Drawing.Size(1493, 325);
            this.groupControlDanhSachNhanVien.TabIndex = 4;
            this.groupControlDanhSachNhanVien.Text = "Danh Sách Tham Số Đầu Vào";
            // 
            // dataGridViewTSDV
            // 
            this.dataGridViewTSDV.AllowUserToAddRows = false;
            this.dataGridViewTSDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTSDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTSDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.idThamSo,
            this.x_water_velocity,
            this.y_water_velocity,
            this.x_wind,
            this.y_wind,
            this.upward_velocity,
            this.significant_height,
            this.stokes_drift_x,
            this.stokes_drift_y,
            this.temperature,
            this.salinity,
            this.idLoaiDau,
            this.khoiluongdau,
            this.thoigianmophong,
            this.vitridauthatthoat_x,
            this.vitridauthatthoat_y});
            this.dataGridViewTSDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTSDV.Location = new System.Drawing.Point(2, 28);
            this.dataGridViewTSDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTSDV.Name = "dataGridViewTSDV";
            this.dataGridViewTSDV.RowHeadersWidth = 51;
            this.dataGridViewTSDV.RowTemplate.Height = 24;
            this.dataGridViewTSDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTSDV.Size = new System.Drawing.Size(1489, 295);
            this.dataGridViewTSDV.TabIndex = 0;
            this.dataGridViewTSDV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTSDV_CellEnter);
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
            // idThamSo
            // 
            this.idThamSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idThamSo.DataPropertyName = "idThamSo";
            this.idThamSo.HeaderText = "Mã tham số";
            this.idThamSo.MinimumWidth = 6;
            this.idThamSo.Name = "idThamSo";
            this.idThamSo.ReadOnly = true;
            this.idThamSo.Width = 125;
            // 
            // x_water_velocity
            // 
            this.x_water_velocity.DataPropertyName = "x_water_velocity";
            this.x_water_velocity.FillWeight = 89.12591F;
            this.x_water_velocity.HeaderText = "x_water velocity";
            this.x_water_velocity.MinimumWidth = 6;
            this.x_water_velocity.Name = "x_water_velocity";
            this.x_water_velocity.ReadOnly = true;
            // 
            // y_water_velocity
            // 
            this.y_water_velocity.DataPropertyName = "y_water_velocity";
            this.y_water_velocity.FillWeight = 89.12591F;
            this.y_water_velocity.HeaderText = "y_water velocity";
            this.y_water_velocity.MinimumWidth = 6;
            this.y_water_velocity.Name = "y_water_velocity";
            this.y_water_velocity.ReadOnly = true;
            // 
            // x_wind
            // 
            this.x_wind.DataPropertyName = "x_wind";
            this.x_wind.HeaderText = "x_wind";
            this.x_wind.MinimumWidth = 6;
            this.x_wind.Name = "x_wind";
            this.x_wind.ReadOnly = true;
            // 
            // y_wind
            // 
            this.y_wind.DataPropertyName = "y_wind";
            this.y_wind.FillWeight = 89.12591F;
            this.y_wind.HeaderText = "y_wind";
            this.y_wind.MinimumWidth = 6;
            this.y_wind.Name = "y_wind";
            this.y_wind.ReadOnly = true;
            // 
            // upward_velocity
            // 
            this.upward_velocity.DataPropertyName = "upward_velocity";
            this.upward_velocity.FillWeight = 89.12591F;
            this.upward_velocity.HeaderText = "upward velocity";
            this.upward_velocity.MinimumWidth = 6;
            this.upward_velocity.Name = "upward_velocity";
            this.upward_velocity.ReadOnly = true;
            // 
            // significant_height
            // 
            this.significant_height.DataPropertyName = "significant_height";
            this.significant_height.FillWeight = 89.12591F;
            this.significant_height.HeaderText = "significant height";
            this.significant_height.MinimumWidth = 6;
            this.significant_height.Name = "significant_height";
            this.significant_height.ReadOnly = true;
            // 
            // stokes_drift_x
            // 
            this.stokes_drift_x.DataPropertyName = "stokes_drift_x";
            this.stokes_drift_x.FillWeight = 89.12591F;
            this.stokes_drift_x.HeaderText = "stokes drift_x";
            this.stokes_drift_x.MinimumWidth = 6;
            this.stokes_drift_x.Name = "stokes_drift_x";
            this.stokes_drift_x.ReadOnly = true;
            // 
            // stokes_drift_y
            // 
            this.stokes_drift_y.DataPropertyName = "stokes_drift_y";
            this.stokes_drift_y.HeaderText = "stokes drift_y";
            this.stokes_drift_y.MinimumWidth = 6;
            this.stokes_drift_y.Name = "stokes_drift_y";
            // 
            // temperature
            // 
            this.temperature.DataPropertyName = "temperature";
            this.temperature.HeaderText = "temperature";
            this.temperature.MinimumWidth = 6;
            this.temperature.Name = "temperature";
            // 
            // salinity
            // 
            this.salinity.DataPropertyName = "salinity";
            this.salinity.HeaderText = "salinity";
            this.salinity.MinimumWidth = 6;
            this.salinity.Name = "salinity";
            // 
            // idLoaiDau
            // 
            this.idLoaiDau.DataPropertyName = "idLoaiDau";
            this.idLoaiDau.HeaderText = "Mã loại dầu";
            this.idLoaiDau.MinimumWidth = 6;
            this.idLoaiDau.Name = "idLoaiDau";
            // 
            // khoiluongdau
            // 
            this.khoiluongdau.DataPropertyName = "khoiluongdau";
            this.khoiluongdau.HeaderText = "Khối lượng dầu";
            this.khoiluongdau.MinimumWidth = 6;
            this.khoiluongdau.Name = "khoiluongdau";
            // 
            // thoigianmophong
            // 
            this.thoigianmophong.DataPropertyName = "thoigianmophong";
            this.thoigianmophong.HeaderText = "Thời gian mô phỏng";
            this.thoigianmophong.MinimumWidth = 6;
            this.thoigianmophong.Name = "thoigianmophong";
            // 
            // vitridauthatthoat_x
            // 
            this.vitridauthatthoat_x.DataPropertyName = "vitridauthatthoat_x";
            this.vitridauthatthoat_x.HeaderText = "Vị trí dầu thất thoát_x";
            this.vitridauthatthoat_x.MinimumWidth = 6;
            this.vitridauthatthoat_x.Name = "vitridauthatthoat_x";
            // 
            // vitridauthatthoat_y
            // 
            this.vitridauthatthoat_y.DataPropertyName = "vitridauthatthoat_y";
            this.vitridauthatthoat_y.HeaderText = "Vị trí dầu thất thoát_y";
            this.vitridauthatthoat_y.MinimumWidth = 6;
            this.vitridauthatthoat_y.Name = "vitridauthatthoat_y";
            // 
            // groupControlThongTinChiTiet
            // 
            this.groupControlThongTinChiTiet.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControlThongTinChiTiet.AppearanceCaption.Options.UseFont = true;
            this.groupControlThongTinChiTiet.Controls.Add(this.tbthoigian);
            this.groupControlThongTinChiTiet.Controls.Add(this.label13);
            this.groupControlThongTinChiTiet.Controls.Add(this.tbvitrithatthoat_y);
            this.groupControlThongTinChiTiet.Controls.Add(this.label12);
            this.groupControlThongTinChiTiet.Controls.Add(this.tbtemperature);
            this.groupControlThongTinChiTiet.Controls.Add(this.label11);
            this.groupControlThongTinChiTiet.Controls.Add(this.tbmathamso);
            this.groupControlThongTinChiTiet.Controls.Add(this.label10);
            this.groupControlThongTinChiTiet.Controls.Add(this.label6);
            this.groupControlThongTinChiTiet.Controls.Add(this.tbmaloaidau);
            this.groupControlThongTinChiTiet.Controls.Add(this.label7);
            this.groupControlThongTinChiTiet.Controls.Add(this.label8);
            this.groupControlThongTinChiTiet.Controls.Add(this.tbsalinity);
            this.groupControlThongTinChiTiet.Controls.Add(this.label9);
            this.groupControlThongTinChiTiet.Controls.Add(this.tbvitrithatthoat_x);
            this.groupControlThongTinChiTiet.Controls.Add(this.tbluongdau);
            this.groupControlThongTinChiTiet.Controls.Add(this.label2);
            this.groupControlThongTinChiTiet.Controls.Add(this.buttonThoat);
            this.groupControlThongTinChiTiet.Controls.Add(this.label1);
            this.groupControlThongTinChiTiet.Controls.Add(this.tbupward_sea);
            this.groupControlThongTinChiTiet.Controls.Add(this.buttonXoa);
            this.groupControlThongTinChiTiet.Controls.Add(this.label3);
            this.groupControlThongTinChiTiet.Controls.Add(this.searchLookUpEditTSDV);
            this.groupControlThongTinChiTiet.Controls.Add(this.tbdrift_y);
            this.groupControlThongTinChiTiet.Controls.Add(this.label4);
            this.groupControlThongTinChiTiet.Controls.Add(this.buttonThem);
            this.groupControlThongTinChiTiet.Controls.Add(this.tbdrift_x);
            this.groupControlThongTinChiTiet.Controls.Add(this.buttonSua);
            this.groupControlThongTinChiTiet.Controls.Add(this.tbsign_height);
            this.groupControlThongTinChiTiet.Controls.Add(this.labelMaDangNhap);
            this.groupControlThongTinChiTiet.Controls.Add(this.label5);
            this.groupControlThongTinChiTiet.Controls.Add(this.tbx_water);
            this.groupControlThongTinChiTiet.Controls.Add(this.labelHoTen);
            this.groupControlThongTinChiTiet.Controls.Add(this.labelEmail);
            this.groupControlThongTinChiTiet.Controls.Add(this.tby_water);
            this.groupControlThongTinChiTiet.Controls.Add(this.labelSoDienThoai);
            this.groupControlThongTinChiTiet.Controls.Add(this.tbx_wind);
            this.groupControlThongTinChiTiet.Controls.Add(this.tby_wind);
            this.groupControlThongTinChiTiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlThongTinChiTiet.Location = new System.Drawing.Point(0, 0);
            this.groupControlThongTinChiTiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControlThongTinChiTiet.Name = "groupControlThongTinChiTiet";
            this.groupControlThongTinChiTiet.Size = new System.Drawing.Size(1493, 327);
            this.groupControlThongTinChiTiet.TabIndex = 3;
            this.groupControlThongTinChiTiet.Text = "Thông Tin Chi Tiết";
            // 
            // tbthoigian
            // 
            this.tbthoigian.Enabled = false;
            this.tbthoigian.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbthoigian.Location = new System.Drawing.Point(1179, 193);
            this.tbthoigian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbthoigian.Name = "tbthoigian";
            this.tbthoigian.ReadOnly = true;
            this.tbthoigian.Size = new System.Drawing.Size(193, 28);
            this.tbthoigian.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label13.Location = new System.Drawing.Point(710, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 21);
            this.label13.TabIndex = 54;
            this.label13.Text = "Vị trí dầu thất thoát_y";
            // 
            // tbvitrithatthoat_y
            // 
            this.tbvitrithatthoat_y.Enabled = false;
            this.tbvitrithatthoat_y.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbvitrithatthoat_y.Location = new System.Drawing.Point(913, 191);
            this.tbvitrithatthoat_y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbvitrithatthoat_y.Name = "tbvitrithatthoat_y";
            this.tbvitrithatthoat_y.ReadOnly = true;
            this.tbvitrithatthoat_y.Size = new System.Drawing.Size(123, 28);
            this.tbvitrithatthoat_y.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label12.Location = new System.Drawing.Point(710, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 21);
            this.label12.TabIndex = 51;
            this.label12.Text = "sea_water_temperature";
            // 
            // tbtemperature
            // 
            this.tbtemperature.Enabled = false;
            this.tbtemperature.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbtemperature.Location = new System.Drawing.Point(912, 149);
            this.tbtemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbtemperature.Name = "tbtemperature";
            this.tbtemperature.ReadOnly = true;
            this.tbtemperature.Size = new System.Drawing.Size(123, 28);
            this.tbtemperature.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label11.Location = new System.Drawing.Point(12, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 21);
            this.label11.TabIndex = 49;
            this.label11.Text = "Mã tham số đầu vào";
            // 
            // tbmathamso
            // 
            this.tbmathamso.Enabled = false;
            this.tbmathamso.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbmathamso.Location = new System.Drawing.Point(181, 111);
            this.tbmathamso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmathamso.Name = "tbmathamso";
            this.tbmathamso.ReadOnly = true;
            this.tbmathamso.Size = new System.Drawing.Size(123, 28);
            this.tbmathamso.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label10.Location = new System.Drawing.Point(1078, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 21);
            this.label10.TabIndex = 47;
            this.label10.Text = "Thời gian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label6.Location = new System.Drawing.Point(1078, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Mã loại dầu";
            // 
            // tbmaloaidau
            // 
            this.tbmaloaidau.Enabled = false;
            this.tbmaloaidau.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbmaloaidau.Location = new System.Drawing.Point(1179, 231);
            this.tbmaloaidau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmaloaidau.Name = "tbmaloaidau";
            this.tbmaloaidau.ReadOnly = true;
            this.tbmaloaidau.Size = new System.Drawing.Size(193, 28);
            this.tbmaloaidau.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label7.Location = new System.Drawing.Point(341, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "sea_water_salinity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label8.Location = new System.Drawing.Point(710, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 21);
            this.label8.TabIndex = 42;
            this.label8.Text = "Vị trí dầu thất thoát_x";
            // 
            // tbsalinity
            // 
            this.tbsalinity.Enabled = false;
            this.tbsalinity.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbsalinity.Location = new System.Drawing.Point(555, 109);
            this.tbsalinity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbsalinity.Name = "tbsalinity";
            this.tbsalinity.ReadOnly = true;
            this.tbsalinity.Size = new System.Drawing.Size(123, 28);
            this.tbsalinity.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label9.Location = new System.Drawing.Point(10, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 21);
            this.label9.TabIndex = 43;
            this.label9.Text = "Khối lượng dầu loang";
            // 
            // tbvitrithatthoat_x
            // 
            this.tbvitrithatthoat_x.Enabled = false;
            this.tbvitrithatthoat_x.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbvitrithatthoat_x.Location = new System.Drawing.Point(913, 234);
            this.tbvitrithatthoat_x.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbvitrithatthoat_x.Name = "tbvitrithatthoat_x";
            this.tbvitrithatthoat_x.ReadOnly = true;
            this.tbvitrithatthoat_x.Size = new System.Drawing.Size(123, 28);
            this.tbvitrithatthoat_x.TabIndex = 45;
            // 
            // tbluongdau
            // 
            this.tbluongdau.Enabled = false;
            this.tbluongdau.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbluongdau.Location = new System.Drawing.Point(181, 234);
            this.tbluongdau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbluongdau.Name = "tbluongdau";
            this.tbluongdau.ReadOnly = true;
            this.tbluongdau.Size = new System.Drawing.Size(123, 28);
            this.tbluongdau.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label2.Location = new System.Drawing.Point(332, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "upward_sea_water_velocity";
            // 
            // buttonThoat
            // 
            this.buttonThoat.AutoSize = true;
            this.buttonThoat.BackColor = System.Drawing.Color.Transparent;
            this.buttonThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonThoat.Location = new System.Drawing.Point(1378, 221);
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
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tìm kiếm/lọc thông tin";
            // 
            // tbupward_sea
            // 
            this.tbupward_sea.Enabled = false;
            this.tbupward_sea.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbupward_sea.Location = new System.Drawing.Point(555, 150);
            this.tbupward_sea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbupward_sea.Name = "tbupward_sea";
            this.tbupward_sea.ReadOnly = true;
            this.tbupward_sea.Size = new System.Drawing.Size(123, 28);
            this.tbupward_sea.TabIndex = 32;
            // 
            // buttonXoa
            // 
            this.buttonXoa.AutoSize = true;
            this.buttonXoa.BackColor = System.Drawing.Color.Transparent;
            this.buttonXoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonXoa.Location = new System.Drawing.Point(1378, 182);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(112, 41);
            this.buttonXoa.TabIndex = 8;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label3.Location = new System.Drawing.Point(332, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 21);
            this.label3.TabIndex = 33;
            this.label3.Text = "significant_height";
            // 
            // searchLookUpEditTSDV
            // 
            this.searchLookUpEditTSDV.EditValue = " ";
            this.searchLookUpEditTSDV.Location = new System.Drawing.Point(391, 42);
            this.searchLookUpEditTSDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchLookUpEditTSDV.Name = "searchLookUpEditTSDV";
            this.searchLookUpEditTSDV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.searchLookUpEditTSDV.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEditTSDV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditTSDV.Properties.NullText = "";
            this.searchLookUpEditTSDV.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEditTSDV.Size = new System.Drawing.Size(385, 28);
            this.searchLookUpEditTSDV.TabIndex = 2;
            this.searchLookUpEditTSDV.EditValueChanged += new System.EventHandler(this.searchLookUpEditTSDV_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // tbdrift_y
            // 
            this.tbdrift_y.Enabled = false;
            this.tbdrift_y.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbdrift_y.Location = new System.Drawing.Point(912, 109);
            this.tbdrift_y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbdrift_y.Name = "tbdrift_y";
            this.tbdrift_y.ReadOnly = true;
            this.tbdrift_y.Size = new System.Drawing.Size(123, 28);
            this.tbdrift_y.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label4.Location = new System.Drawing.Point(332, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "stokes_drift_x_velocity";
            // 
            // buttonThem
            // 
            this.buttonThem.AutoSize = true;
            this.buttonThem.BackColor = System.Drawing.Color.Transparent;
            this.buttonThem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonThem.Location = new System.Drawing.Point(1378, 103);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(112, 41);
            this.buttonThem.TabIndex = 7;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // tbdrift_x
            // 
            this.tbdrift_x.Enabled = false;
            this.tbdrift_x.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbdrift_x.Location = new System.Drawing.Point(555, 234);
            this.tbdrift_x.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbdrift_x.Name = "tbdrift_x";
            this.tbdrift_x.ReadOnly = true;
            this.tbdrift_x.Size = new System.Drawing.Size(123, 28);
            this.tbdrift_x.TabIndex = 37;
            // 
            // buttonSua
            // 
            this.buttonSua.AutoSize = true;
            this.buttonSua.BackColor = System.Drawing.Color.Transparent;
            this.buttonSua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSua.Location = new System.Drawing.Point(1378, 142);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(112, 41);
            this.buttonSua.TabIndex = 5;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // tbsign_height
            // 
            this.tbsign_height.Enabled = false;
            this.tbsign_height.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbsign_height.Location = new System.Drawing.Point(555, 193);
            this.tbsign_height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbsign_height.Name = "tbsign_height";
            this.tbsign_height.ReadOnly = true;
            this.tbsign_height.Size = new System.Drawing.Size(123, 28);
            this.tbsign_height.TabIndex = 38;
            // 
            // labelMaDangNhap
            // 
            this.labelMaDangNhap.AutoSize = true;
            this.labelMaDangNhap.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labelMaDangNhap.Location = new System.Drawing.Point(12, 150);
            this.labelMaDangNhap.Name = "labelMaDangNhap";
            this.labelMaDangNhap.Size = new System.Drawing.Size(135, 21);
            this.labelMaDangNhap.TabIndex = 2;
            this.labelMaDangNhap.Text = "x_water_velocity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.label5.Location = new System.Drawing.Point(709, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "stokes_drift_y_velocity";
            // 
            // tbx_water
            // 
            this.tbx_water.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbx_water.Location = new System.Drawing.Point(181, 152);
            this.tbx_water.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_water.Name = "tbx_water";
            this.tbx_water.ReadOnly = true;
            this.tbx_water.Size = new System.Drawing.Size(123, 28);
            this.tbx_water.TabIndex = 3;
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labelHoTen.Location = new System.Drawing.Point(12, 191);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(135, 21);
            this.labelHoTen.TabIndex = 4;
            this.labelHoTen.Text = "y_water_velocity";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labelEmail.Location = new System.Drawing.Point(1080, 151);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(62, 21);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "x_wind";
            // 
            // tby_water
            // 
            this.tby_water.Enabled = false;
            this.tby_water.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tby_water.Location = new System.Drawing.Point(181, 192);
            this.tby_water.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tby_water.Name = "tby_water";
            this.tby_water.ReadOnly = true;
            this.tby_water.Size = new System.Drawing.Size(123, 28);
            this.tby_water.TabIndex = 21;
            // 
            // labelSoDienThoai
            // 
            this.labelSoDienThoai.AutoSize = true;
            this.labelSoDienThoai.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labelSoDienThoai.Location = new System.Drawing.Point(1078, 116);
            this.labelSoDienThoai.Name = "labelSoDienThoai";
            this.labelSoDienThoai.Size = new System.Drawing.Size(62, 21);
            this.labelSoDienThoai.TabIndex = 6;
            this.labelSoDienThoai.Text = "y_wind";
            // 
            // tbx_wind
            // 
            this.tbx_wind.Enabled = false;
            this.tbx_wind.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tbx_wind.Location = new System.Drawing.Point(1179, 147);
            this.tbx_wind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_wind.Name = "tbx_wind";
            this.tbx_wind.ReadOnly = true;
            this.tbx_wind.Size = new System.Drawing.Size(193, 28);
            this.tbx_wind.TabIndex = 20;
            // 
            // tby_wind
            // 
            this.tby_wind.Enabled = false;
            this.tby_wind.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.tby_wind.Location = new System.Drawing.Point(1179, 109);
            this.tby_wind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tby_wind.Name = "tby_wind";
            this.tby_wind.ReadOnly = true;
            this.tby_wind.Size = new System.Drawing.Size(193, 28);
            this.tby_wind.TabIndex = 19;
            // 
            // TSDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 812);
            this.Controls.Add(this.sidePanelThamSoDauVao);
            this.Name = "TSDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThamSoDauVao";
            this.Load += new System.EventHandler(this.ThamSoDauVao_Load);
            this.sidePanelThamSoDauVao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDanhSachNhanVien)).EndInit();
            this.groupControlDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTSDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlThongTinChiTiet)).EndInit();
            this.groupControlThongTinChiTiet.ResumeLayout(false);
            this.groupControlThongTinChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditTSDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SidePanel sidePanelThamSoDauVao;
        private DevExpress.XtraEditors.GroupControl groupControlDanhSachNhanVien;
        public System.Windows.Forms.DataGridView dataGridViewTSDV;
        private DevExpress.XtraEditors.GroupControl groupControlThongTinChiTiet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbtemperature;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbmathamso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbmaloaidau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbsalinity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbvitrithatthoat_x;
        private System.Windows.Forms.TextBox tbluongdau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbupward_sea;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditTSDV;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.TextBox tbdrift_y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox tbdrift_x;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.TextBox tbsign_height;
        private System.Windows.Forms.Label labelMaDangNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_water;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tby_water;
        private System.Windows.Forms.Label labelSoDienThoai;
        private System.Windows.Forms.TextBox tbx_wind;
        private System.Windows.Forms.TextBox tby_wind;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbvitrithatthoat_y;
        private System.Windows.Forms.TextBox tbthoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idThamSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_water_velocity;
        private System.Windows.Forms.DataGridViewTextBoxColumn y_water_velocity;
        private System.Windows.Forms.DataGridViewTextBoxColumn x_wind;
        private System.Windows.Forms.DataGridViewTextBoxColumn y_wind;
        private System.Windows.Forms.DataGridViewTextBoxColumn upward_velocity;
        private System.Windows.Forms.DataGridViewTextBoxColumn significant_height;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokes_drift_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokes_drift_y;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn salinity;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLoaiDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoiluongdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianmophong;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitridauthatthoat_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitridauthatthoat_y;
    }
}