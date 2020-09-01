namespace DXApplication1.Admin
{
    partial class Phanquyen
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridViewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnThaoTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlDetaiPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelVaitro = new System.Windows.Forms.Panel();
            this.labelVaitro = new System.Windows.Forms.Label();
            this.panelDetailPhanQuyen = new System.Windows.Forms.Panel();
            this.gridControlChucVu_NguoiDung = new DevExpress.XtraGrid.GridControl();
            this.gridViewChucVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetaiPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.panelVaitro.SuspendLayout();
            this.panelDetailPhanQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChucVu_NguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnThaoTac});
            this.gridViewDetail.GridControl = this.gridControlDetaiPhanQuyen;
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.OptionsSelection.MultiSelect = true;
            this.gridViewDetail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // gridColumnThaoTac
            // 
            this.gridColumnThaoTac.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnThaoTac.AppearanceCell.Options.UseFont = true;
            this.gridColumnThaoTac.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnThaoTac.AppearanceHeader.Options.UseFont = true;
            this.gridColumnThaoTac.Caption = "Thao tác";
            this.gridColumnThaoTac.FieldName = "MoTa";
            this.gridColumnThaoTac.MinWidth = 25;
            this.gridColumnThaoTac.Name = "gridColumnThaoTac";
            this.gridColumnThaoTac.OptionsColumn.AllowEdit = false;
            this.gridColumnThaoTac.OptionsColumn.FixedWidth = true;
            this.gridColumnThaoTac.Visible = true;
            this.gridColumnThaoTac.VisibleIndex = 1;
            this.gridColumnThaoTac.Width = 94;
            // 
            // gridControlDetaiPhanQuyen
            // 
            this.gridControlDetaiPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridViewDetail;
            gridLevelNode1.RelationName = "Detail";
            this.gridControlDetaiPhanQuyen.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlDetaiPhanQuyen.Location = new System.Drawing.Point(0, 0);
            this.gridControlDetaiPhanQuyen.MainView = this.gridViewMain;
            this.gridControlDetaiPhanQuyen.Name = "gridControlDetaiPhanQuyen";
            this.gridControlDetaiPhanQuyen.Size = new System.Drawing.Size(1279, 753);
            this.gridControlDetaiPhanQuyen.TabIndex = 1;
            this.gridControlDetaiPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain,
            this.gridViewDetail});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnQuyen});
            this.gridViewMain.GridControl = this.gridControlDetaiPhanQuyen;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsDetail.ShowDetailTabs = false;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnQuyen
            // 
            this.gridColumnQuyen.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnQuyen.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridColumnQuyen.AppearanceHeader.Options.UseFont = true;
            this.gridColumnQuyen.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnQuyen.Caption = "QUYỀN";
            this.gridColumnQuyen.FieldName = "MoTa";
            this.gridColumnQuyen.MinWidth = 25;
            this.gridColumnQuyen.Name = "gridColumnQuyen";
            this.gridColumnQuyen.OptionsColumn.AllowEdit = false;
            this.gridColumnQuyen.OptionsColumn.FixedWidth = true;
            this.gridColumnQuyen.Visible = true;
            this.gridColumnQuyen.VisibleIndex = 0;
            this.gridColumnQuyen.Width = 94;
            // 
            // panelVaitro
            // 
            this.panelVaitro.Controls.Add(this.gridControlChucVu_NguoiDung);
            this.panelVaitro.Controls.Add(this.labelVaitro);
            this.panelVaitro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVaitro.Location = new System.Drawing.Point(0, 0);
            this.panelVaitro.Name = "panelVaitro";
            this.panelVaitro.Size = new System.Drawing.Size(332, 753);
            this.panelVaitro.TabIndex = 0;
            // 
            // labelVaitro
            // 
            this.labelVaitro.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVaitro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVaitro.Location = new System.Drawing.Point(0, 0);
            this.labelVaitro.Name = "labelVaitro";
            this.labelVaitro.Size = new System.Drawing.Size(332, 32);
            this.labelVaitro.TabIndex = 0;
            this.labelVaitro.Text = "Chức vụ và người dùng";
            // 
            // panelDetailPhanQuyen
            // 
            this.panelDetailPhanQuyen.Controls.Add(this.gridControlDetaiPhanQuyen);
            this.panelDetailPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetailPhanQuyen.Location = new System.Drawing.Point(332, 0);
            this.panelDetailPhanQuyen.Name = "panelDetailPhanQuyen";
            this.panelDetailPhanQuyen.Size = new System.Drawing.Size(1279, 753);
            this.panelDetailPhanQuyen.TabIndex = 1;
            // 
            // gridControlChucVu_NguoiDung
            // 
            this.gridControlChucVu_NguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.gridControlChucVu_NguoiDung.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControlChucVu_NguoiDung.Location = new System.Drawing.Point(0, 32);
            this.gridControlChucVu_NguoiDung.MainView = this.gridViewChucVu;
            this.gridControlChucVu_NguoiDung.Name = "gridControlChucVu_NguoiDung";
            this.gridControlChucVu_NguoiDung.Size = new System.Drawing.Size(332, 721);
            this.gridControlChucVu_NguoiDung.TabIndex = 1;
            this.gridControlChucVu_NguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChucVu});
            // 
            // gridViewChucVu
            // 
            this.gridViewChucVu.GridControl = this.gridControlChucVu_NguoiDung;
            this.gridViewChucVu.Name = "gridViewChucVu";
            // 
            // Phanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 753);
            this.Controls.Add(this.panelDetailPhanQuyen);
            this.Controls.Add(this.panelVaitro);
            this.Name = "Phanquyen";
            this.Text = "Phanquyen";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetaiPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.panelVaitro.ResumeLayout(false);
            this.panelDetailPhanQuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChucVu_NguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVaitro;
        private System.Windows.Forms.Label labelVaitro;
        private System.Windows.Forms.Panel panelDetailPhanQuyen;
        private DevExpress.XtraGrid.GridControl gridControlDetaiPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnThaoTac;
        private DevExpress.XtraGrid.GridControl gridControlChucVu_NguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChucVu;
    }
}