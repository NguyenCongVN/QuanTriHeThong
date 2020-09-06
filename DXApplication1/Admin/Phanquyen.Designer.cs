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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridViewDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
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
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMainPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.panelVaitro.SuspendLayout();
            this.panelDetailPhanQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCheck,
            this.gridColumnQuyenId,
            this.gridColumnThaoTac});
            this.gridViewDetail.CustomizationFormBounds = new System.Drawing.Rectangle(1044, 478, 276, 224);
            this.gridViewDetail.DetailHeight = 284;
            this.gridViewDetail.GridControl = this.gridControlMainPhanQuyen;
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.OptionsCustomization.AllowRowSizing = true;
            this.gridViewDetail.OptionsDetail.ShowDetailTabs = false;
            this.gridViewDetail.OptionsSelection.MultiSelect = true;
            this.gridViewDetail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewDetail.OptionsView.RowAutoHeight = true;
            this.gridViewDetail.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnCheck
            // 
            this.gridColumnCheck.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnCheck.AppearanceCell.Options.UseFont = true;
            this.gridColumnCheck.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnCheck.AppearanceHeader.Options.UseFont = true;
            this.gridColumnCheck.Caption = "Check";
            this.gridColumnCheck.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumnCheck.FieldName = "Check";
            this.gridColumnCheck.MinWidth = 21;
            this.gridColumnCheck.Name = "gridColumnCheck";
            this.gridColumnCheck.OptionsColumn.FixedWidth = true;
            this.gridColumnCheck.Visible = true;
            this.gridColumnCheck.VisibleIndex = 1;
            this.gridColumnCheck.Width = 429;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemCheckEdit1.Appearance.Options.UseFont = true;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueGrayed = '1';
            this.repositoryItemCheckEdit1.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit1_CheckedChanged);
            // 
            // gridColumnQuyenId
            // 
            this.gridColumnQuyenId.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnQuyenId.AppearanceCell.Options.UseFont = true;
            this.gridColumnQuyenId.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnQuyenId.AppearanceHeader.Options.UseFont = true;
            this.gridColumnQuyenId.Caption = "QuyenId";
            this.gridColumnQuyenId.FieldName = "QuyenId";
            this.gridColumnQuyenId.MinWidth = 21;
            this.gridColumnQuyenId.Name = "gridColumnQuyenId";
            this.gridColumnQuyenId.OptionsColumn.AllowEdit = false;
            this.gridColumnQuyenId.OptionsColumn.FixedWidth = true;
            this.gridColumnQuyenId.Visible = true;
            this.gridColumnQuyenId.VisibleIndex = 2;
            this.gridColumnQuyenId.Width = 549;
            // 
            // gridColumnThaoTac
            // 
            this.gridColumnThaoTac.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnThaoTac.AppearanceCell.Options.UseFont = true;
            this.gridColumnThaoTac.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnThaoTac.AppearanceHeader.Options.UseFont = true;
            this.gridColumnThaoTac.Caption = "Mô Tả";
            this.gridColumnThaoTac.FieldName = "MoTa";
            this.gridColumnThaoTac.MinWidth = 21;
            this.gridColumnThaoTac.Name = "gridColumnThaoTac";
            this.gridColumnThaoTac.OptionsColumn.AllowEdit = false;
            this.gridColumnThaoTac.OptionsColumn.FixedWidth = true;
            this.gridColumnThaoTac.Visible = true;
            this.gridColumnThaoTac.VisibleIndex = 3;
            this.gridColumnThaoTac.Width = 686;
            // 
            // gridControlMainPhanQuyen
            // 
            this.gridControlMainPhanQuyen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlMainPhanQuyen.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode1.LevelTemplate = this.gridViewDetail;
            gridLevelNode1.RelationName = "Detail";
            this.gridControlMainPhanQuyen.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlMainPhanQuyen.Location = new System.Drawing.Point(0, 86);
            this.gridControlMainPhanQuyen.MainView = this.gridViewMain;
            this.gridControlMainPhanQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlMainPhanQuyen.Name = "gridControlMainPhanQuyen";
            this.gridControlMainPhanQuyen.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlMainPhanQuyen.Size = new System.Drawing.Size(839, 528);
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
            this.gridViewMain.DetailHeight = 284;
            this.gridViewMain.GridControl = this.gridControlMainPhanQuyen;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsCustomization.AllowRowSizing = true;
            this.gridViewMain.OptionsDetail.ShowDetailTabs = false;
            this.gridViewMain.OptionsView.RowAutoHeight = true;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            this.gridViewMain.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridViewMain_MasterRowEmpty);
            this.gridViewMain.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridViewMain_MasterRowExpanded);
            this.gridViewMain.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridViewMain_MasterRowGetChildList);
            this.gridViewMain.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridViewMain_MasterRowGetRelationName);
            this.gridViewMain.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridViewMain_MasterRowGetRelationCount);
            // 
            // gridColumnQuyen
            // 
            this.gridColumnQuyen.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnQuyen.AppearanceCell.Options.UseFont = true;
            this.gridColumnQuyen.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnQuyen.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridColumnQuyen.AppearanceHeader.Options.UseFont = true;
            this.gridColumnQuyen.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumnQuyen.Caption = "QUYỀN";
            this.gridColumnQuyen.FieldName = "MoTa";
            this.gridColumnQuyen.MinWidth = 21;
            this.gridColumnQuyen.Name = "gridColumnQuyen";
            this.gridColumnQuyen.OptionsColumn.AllowEdit = false;
            this.gridColumnQuyen.OptionsColumn.FixedWidth = true;
            this.gridColumnQuyen.Visible = true;
            this.gridColumnQuyen.VisibleIndex = 0;
            this.gridColumnQuyen.Width = 81;
            // 
            // panelVaitro
            // 
            this.panelVaitro.Controls.Add(this.comboBoxChucVu);
            this.panelVaitro.Controls.Add(this.labelVaitro);
            this.panelVaitro.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVaitro.Location = new System.Drawing.Point(0, 0);
            this.panelVaitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelVaitro.Name = "panelVaitro";
            this.panelVaitro.Size = new System.Drawing.Size(340, 614);
            this.panelVaitro.TabIndex = 0;
            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.Location = new System.Drawing.Point(11, 29);
            this.comboBoxChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.Size = new System.Drawing.Size(241, 27);
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
            this.labelVaitro.Size = new System.Drawing.Size(340, 26);
            this.labelVaitro.TabIndex = 0;
            this.labelVaitro.Text = "Chức vụ và người dùng";
            // 
            // panelDetailPhanQuyen
            // 
            this.panelDetailPhanQuyen.Controls.Add(this.buttonLuu);
            this.panelDetailPhanQuyen.Controls.Add(this.gridControlMainPhanQuyen);
            this.panelDetailPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetailPhanQuyen.Location = new System.Drawing.Point(340, 0);
            this.panelDetailPhanQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDetailPhanQuyen.Name = "panelDetailPhanQuyen";
            this.panelDetailPhanQuyen.Size = new System.Drawing.Size(839, 614);
            this.panelDetailPhanQuyen.TabIndex = 1;
            // 
            // buttonLuu
            // 
            this.buttonLuu.AutoSize = true;
            this.buttonLuu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonLuu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLuu.Location = new System.Drawing.Point(6, 2);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(113, 37);
            this.buttonLuu.TabIndex = 6;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // Phanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 614);
            this.Controls.Add(this.panelDetailPhanQuyen);
            this.Controls.Add(this.panelVaitro);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Phanquyen";
            this.Text = "Phanquyen";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMainPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.panelVaitro.ResumeLayout(false);
            this.panelDetailPhanQuyen.ResumeLayout(false);
            this.panelDetailPhanQuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumnCheck;
    }
}