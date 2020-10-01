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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panelVaitro = new System.Windows.Forms.Panel();
            this.buttonXoaChucVu = new System.Windows.Forms.Button();
            this.buttonSuaChucVu = new System.Windows.Forms.Button();
            this.buttonThemChucVu = new System.Windows.Forms.Button();
            this.comboBoxChucVu = new System.Windows.Forms.ComboBox();
            this.labelVaitro = new System.Windows.Forms.Label();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMainPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.panelVaitro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCheck,
            this.gridColumnQuyenId,
            this.gridColumnThaoTac});
            this.gridViewDetail.CustomizationFormBounds = new System.Drawing.Rectangle(1044, 202, 322, 276);
            this.gridViewDetail.GridControl = this.gridControlMainPhanQuyen;
            this.gridViewDetail.Name = "gridViewDetail";
            this.gridViewDetail.OptionsCustomization.AllowRowSizing = true;
            this.gridViewDetail.OptionsDetail.ShowDetailTabs = false;
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
            this.gridColumnCheck.MinWidth = 24;
            this.gridColumnCheck.Name = "gridColumnCheck";
            this.gridColumnCheck.OptionsColumn.FixedWidth = true;
            this.gridColumnCheck.Visible = true;
            this.gridColumnCheck.VisibleIndex = 0;
            this.gridColumnCheck.Width = 500;
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
            this.gridColumnQuyenId.MinWidth = 24;
            this.gridColumnQuyenId.Name = "gridColumnQuyenId";
            this.gridColumnQuyenId.OptionsColumn.AllowEdit = false;
            this.gridColumnQuyenId.OptionsColumn.FixedWidth = true;
            this.gridColumnQuyenId.Visible = true;
            this.gridColumnQuyenId.VisibleIndex = 1;
            this.gridColumnQuyenId.Width = 640;
            // 
            // gridColumnThaoTac
            // 
            this.gridColumnThaoTac.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnThaoTac.AppearanceCell.Options.UseFont = true;
            this.gridColumnThaoTac.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumnThaoTac.AppearanceHeader.Options.UseFont = true;
            this.gridColumnThaoTac.Caption = "Mô Tả";
            this.gridColumnThaoTac.FieldName = "MoTa";
            this.gridColumnThaoTac.MinWidth = 24;
            this.gridColumnThaoTac.Name = "gridColumnThaoTac";
            this.gridColumnThaoTac.OptionsColumn.AllowEdit = false;
            this.gridColumnThaoTac.OptionsColumn.FixedWidth = true;
            this.gridColumnThaoTac.Visible = true;
            this.gridColumnThaoTac.VisibleIndex = 2;
            this.gridColumnThaoTac.Width = 800;
            // 
            // gridControlMainPhanQuyen
            // 
            this.gridControlMainPhanQuyen.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode1.LevelTemplate = this.gridViewDetail;
            gridLevelNode1.RelationName = "Detail";
            this.gridControlMainPhanQuyen.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlMainPhanQuyen.Location = new System.Drawing.Point(553, 79);
            this.gridControlMainPhanQuyen.MainView = this.gridViewMain;
            this.gridControlMainPhanQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlMainPhanQuyen.Name = "gridControlMainPhanQuyen";
            this.gridControlMainPhanQuyen.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlMainPhanQuyen.Size = new System.Drawing.Size(1023, 666);
            this.gridControlMainPhanQuyen.TabIndex = 1;
            this.gridControlMainPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain,
            this.gridView1,
            this.gridViewDetail});
            this.gridControlMainPhanQuyen.Load += new System.EventHandler(this.gridControlDetaiPhanQuyen_Load);
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnQuyen});
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
            this.gridColumnQuyen.MinWidth = 24;
            this.gridColumnQuyen.Name = "gridColumnQuyen";
            this.gridColumnQuyen.OptionsColumn.AllowEdit = false;
            this.gridColumnQuyen.OptionsColumn.FixedWidth = true;
            this.gridColumnQuyen.Visible = true;
            this.gridColumnQuyen.VisibleIndex = 0;
            this.gridColumnQuyen.Width = 94;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlMainPhanQuyen;
            this.gridView1.Name = "gridView1";
            // 
            // panelVaitro
            // 
            this.panelVaitro.Controls.Add(this.buttonXoaChucVu);
            this.panelVaitro.Controls.Add(this.buttonSuaChucVu);
            this.panelVaitro.Controls.Add(this.buttonThemChucVu);
            this.panelVaitro.Controls.Add(this.comboBoxChucVu);
            this.panelVaitro.Controls.Add(this.labelVaitro);
            this.panelVaitro.Location = new System.Drawing.Point(238, 11);
            this.panelVaitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelVaitro.Name = "panelVaitro";
            this.panelVaitro.Size = new System.Drawing.Size(309, 756);
            this.panelVaitro.TabIndex = 0;
            // 
            // buttonXoaChucVu
            // 
            this.buttonXoaChucVu.AutoSize = true;
            this.buttonXoaChucVu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonXoaChucVu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonXoaChucVu.Location = new System.Drawing.Point(6, 308);
            this.buttonXoaChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoaChucVu.Name = "buttonXoaChucVu";
            this.buttonXoaChucVu.Size = new System.Drawing.Size(232, 46);
            this.buttonXoaChucVu.TabIndex = 9;
            this.buttonXoaChucVu.Text = "Xoá chức vụ";
            this.buttonXoaChucVu.UseVisualStyleBackColor = false;
            this.buttonXoaChucVu.Click += new System.EventHandler(this.buttonXoaChucVu_Click);
            // 
            // buttonSuaChucVu
            // 
            this.buttonSuaChucVu.AutoSize = true;
            this.buttonSuaChucVu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSuaChucVu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSuaChucVu.Location = new System.Drawing.Point(6, 234);
            this.buttonSuaChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSuaChucVu.Name = "buttonSuaChucVu";
            this.buttonSuaChucVu.Size = new System.Drawing.Size(232, 46);
            this.buttonSuaChucVu.TabIndex = 8;
            this.buttonSuaChucVu.Text = "Sửa chức vụ";
            this.buttonSuaChucVu.UseVisualStyleBackColor = false;
            this.buttonSuaChucVu.Click += new System.EventHandler(this.buttonSuaChucVu_Click);
            // 
            // buttonThemChucVu
            // 
            this.buttonThemChucVu.AutoSize = true;
            this.buttonThemChucVu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonThemChucVu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThemChucVu.Location = new System.Drawing.Point(6, 158);
            this.buttonThemChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThemChucVu.Name = "buttonThemChucVu";
            this.buttonThemChucVu.Size = new System.Drawing.Size(232, 46);
            this.buttonThemChucVu.TabIndex = 7;
            this.buttonThemChucVu.Text = "Thêm chức vụ";
            this.buttonThemChucVu.UseVisualStyleBackColor = false;
            this.buttonThemChucVu.Click += new System.EventHandler(this.buttonThemChucVu_Click);
            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.Location = new System.Drawing.Point(6, 47);
            this.comboBoxChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.Size = new System.Drawing.Size(280, 30);
            this.comboBoxChucVu.TabIndex = 2;
            this.comboBoxChucVu.SelectedIndexChanged += new System.EventHandler(this.comboBoxChucVu_SelectedIndexChanged);
            // 
            // labelVaitro
            // 
            this.labelVaitro.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVaitro.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVaitro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelVaitro.Location = new System.Drawing.Point(0, 0);
            this.labelVaitro.Name = "labelVaitro";
            this.labelVaitro.Size = new System.Drawing.Size(309, 32);
            this.labelVaitro.TabIndex = 0;
            this.labelVaitro.Text = "Chức vụ";
            // 
            // buttonLuu
            // 
            this.buttonLuu.AutoSize = true;
            this.buttonLuu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonLuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLuu.Location = new System.Drawing.Point(553, 11);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(147, 46);
            this.buttonLuu.TabIndex = 6;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.AutoSize = true;
            this.buttonThoat.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonThoat.Location = new System.Drawing.Point(741, 11);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(147, 46);
            this.buttonThoat.TabIndex = 11;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // Phanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1932, 756);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.panelVaitro);
            this.Controls.Add(this.gridControlMainPhanQuyen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Phanquyen";
            this.Text = "Phanquyen";
            this.Load += new System.EventHandler(this.Phanquyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMainPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.panelVaitro.ResumeLayout(false);
            this.panelVaitro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.GridControl gridControlMainPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetail;
        public DevExpress.XtraGrid.Columns.GridColumn gridColumnCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuyenId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnThaoTac;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panelVaitro;
        private System.Windows.Forms.Button buttonXoaChucVu;
        private System.Windows.Forms.Button buttonSuaChucVu;
        private System.Windows.Forms.Button buttonThemChucVu;
        private System.Windows.Forms.ComboBox comboBoxChucVu;
        private System.Windows.Forms.Label labelVaitro;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonThoat;
    }
}