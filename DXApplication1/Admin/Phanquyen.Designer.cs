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
            this.gridViewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnQuyenId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnThaoTac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlMainPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelVaitro = new System.Windows.Forms.Panel();
            this.comboBoxChucVu = new System.Windows.Forms.ComboBox();
            this.labelVaitro = new System.Windows.Forms.Label();
            this.panelDetailPhanQuyen = new System.Windows.Forms.Panel();
            this.buttonLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMainPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.panelVaitro.SuspendLayout();
            this.panelDetailPhanQuyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnQuyenId,
            this.gridColumnThaoTac});
            this.gridViewDetail.CustomizationFormBounds = new System.Drawing.Rectangle(1598, 754, 322, 276);
            this.gridViewDetail.GridControl = this.gridControlMainPhanQuyen;
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.OptionsDetail.ShowDetailTabs = false;
            this.gridViewDetail.OptionsSelection.MultiSelect = true;
            this.gridViewDetail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewDetail.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnQuyenId
            // 
            this.gridColumnQuyenId.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnQuyenId.AppearanceCell.Options.UseFont = true;
            this.gridColumnQuyenId.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnQuyenId.AppearanceHeader.Options.UseFont = true;
            this.gridColumnQuyenId.Caption = "QuyenId";
            this.gridColumnQuyenId.FieldName = "QuyenId";
            this.gridColumnQuyenId.MinWidth = 25;
            this.gridColumnQuyenId.Name = "gridColumnQuyenId";
            this.gridColumnQuyenId.OptionsColumn.AllowEdit = false;
            this.gridColumnQuyenId.OptionsColumn.FixedWidth = true;
            this.gridColumnQuyenId.Visible = true;
            this.gridColumnQuyenId.VisibleIndex = 1;
            this.gridColumnQuyenId.Width = 800;
            // 
            // gridColumnThaoTac
            // 
            this.gridColumnThaoTac.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnThaoTac.AppearanceCell.Options.UseFont = true;
            this.gridColumnThaoTac.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnThaoTac.AppearanceHeader.Options.UseFont = true;
            this.gridColumnThaoTac.Caption = "Mô Tả";
            this.gridColumnThaoTac.FieldName = "MoTa";
            this.gridColumnThaoTac.MinWidth = 25;
            this.gridColumnThaoTac.Name = "gridColumnThaoTac";
            this.gridColumnThaoTac.OptionsColumn.AllowEdit = false;
            this.gridColumnThaoTac.OptionsColumn.FixedWidth = true;
            this.gridColumnThaoTac.Visible = true;
            this.gridColumnThaoTac.VisibleIndex = 2;
            this.gridColumnThaoTac.Width = 800;
            // 
            // gridControlMainPhanQuyen
            // 
            this.gridControlMainPhanQuyen.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode1.LevelTemplate = this.gridViewDetail;
            gridLevelNode1.RelationName = "Detail";
            this.gridControlMainPhanQuyen.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlMainPhanQuyen.Location = new System.Drawing.Point(0, 63);
            this.gridControlMainPhanQuyen.MainView = this.gridViewMain;
            this.gridControlMainPhanQuyen.Name = "gridControlMainPhanQuyen";
            this.gridControlMainPhanQuyen.Size = new System.Drawing.Size(1445, 776);
            this.gridControlMainPhanQuyen.TabIndex = 1;
            this.gridControlMainPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain,
            this.gridViewDetail});
            this.gridControlMainPhanQuyen.Load += new System.EventHandler(this.gridControlDetaiPhanQuyen_Load);
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnQuyen});
            this.gridViewMain.GridControl = this.gridControlMainPhanQuyen;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsDetail.ShowDetailTabs = false;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridViewMain_MasterRowEmpty);
            this.gridViewMain.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridViewMain_MasterRowGetChildList);
            this.gridViewMain.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridViewMain_MasterRowGetRelationName);
            this.gridViewMain.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridViewMain_MasterRowGetRelationCount);
            // 
            // gridColumnQuyen
            // 
            this.gridColumnQuyen.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnQuyen.AppearanceCell.Options.UseFont = true;
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
            this.panelVaitro.Controls.Add(this.comboBoxChucVu);
            this.panelVaitro.Controls.Add(this.labelVaitro);
            this.panelVaitro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVaitro.Location = new System.Drawing.Point(0, 0);
            this.panelVaitro.Name = "panelVaitro";
            this.panelVaitro.Size = new System.Drawing.Size(332, 839);
            this.panelVaitro.TabIndex = 0;
            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.Location = new System.Drawing.Point(13, 36);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.Size = new System.Drawing.Size(280, 30);
            this.comboBoxChucVu.TabIndex = 2;
            this.comboBoxChucVu.SelectedIndexChanged += new System.EventHandler(this.comboBoxChucVu_SelectedIndexChanged);
            // 
            // labelVaitro
            // 
            this.labelVaitro.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVaitro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVaitro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelVaitro.Location = new System.Drawing.Point(0, 0);
            this.labelVaitro.Name = "labelVaitro";
            this.labelVaitro.Size = new System.Drawing.Size(332, 32);
            this.labelVaitro.TabIndex = 0;
            this.labelVaitro.Text = "Chức vụ và người dùng";
            // 
            // panelDetailPhanQuyen
            // 
            this.panelDetailPhanQuyen.Controls.Add(this.buttonLuu);
            this.panelDetailPhanQuyen.Controls.Add(this.gridControlMainPhanQuyen);
            this.panelDetailPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetailPhanQuyen.Location = new System.Drawing.Point(332, 0);
            this.panelDetailPhanQuyen.Name = "panelDetailPhanQuyen";
            this.panelDetailPhanQuyen.Size = new System.Drawing.Size(1445, 839);
            this.panelDetailPhanQuyen.TabIndex = 1;
            // 
            // buttonLuu
            // 
            this.buttonLuu.AutoSize = true;
            this.buttonLuu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonLuu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLuu.Location = new System.Drawing.Point(6, 12);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(132, 45);
            this.buttonLuu.TabIndex = 6;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // Phanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 839);
            this.Controls.Add(this.panelDetailPhanQuyen);
            this.Controls.Add(this.panelVaitro);
            this.Name = "Phanquyen";
            this.Text = "Phanquyen";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMainPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.panelVaitro.ResumeLayout(false);
            this.panelDetailPhanQuyen.ResumeLayout(false);
            this.panelDetailPhanQuyen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVaitro;
        private System.Windows.Forms.Label labelVaitro;
        private System.Windows.Forms.Panel panelDetailPhanQuyen;
        private DevExpress.XtraGrid.GridControl gridControlMainPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnThaoTac;
        private System.Windows.Forms.Button buttonLuu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuyenId;
        private System.Windows.Forms.ComboBox comboBoxChucVu;
    }
}