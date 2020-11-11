﻿namespace DXApplication1.Admin
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMainPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.panelVaitro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewDetail
            // 
            this.gridViewDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCheck,
            this.gridColumnQuyenId,
            this.gridColumnThaoTac});
            this.gridViewDetail.CustomizationFormBounds = new System.Drawing.Rectangle(1044, 202, 276, 224);
            this.gridViewDetail.DetailHeight = 284;
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
            this.gridColumnCheck.MinWidth = 21;
            this.gridColumnCheck.Name = "gridColumnCheck";
            this.gridColumnCheck.OptionsColumn.FixedWidth = true;
            this.gridColumnCheck.Visible = true;
            this.gridColumnCheck.VisibleIndex = 0;
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
            this.gridColumnQuyenId.VisibleIndex = 1;
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
            this.gridColumnThaoTac.VisibleIndex = 2;
            this.gridColumnThaoTac.Width = 686;
            // 
            // gridControlMainPhanQuyen
            // 
            this.gridControlMainPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMainPhanQuyen.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode2.LevelTemplate = this.gridViewDetail;
            gridLevelNode2.RelationName = "Detail";
            this.gridControlMainPhanQuyen.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControlMainPhanQuyen.Location = new System.Drawing.Point(3, 17);
            this.gridControlMainPhanQuyen.MainView = this.gridViewMain;
            this.gridControlMainPhanQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlMainPhanQuyen.Name = "gridControlMainPhanQuyen";
            this.gridControlMainPhanQuyen.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControlMainPhanQuyen.Size = new System.Drawing.Size(822, 319);
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
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
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
            this.panelVaitro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVaitro.Location = new System.Drawing.Point(0, 0);
            this.panelVaitro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelVaitro.Name = "panelVaitro";
            this.panelVaitro.Size = new System.Drawing.Size(828, 57);
            this.panelVaitro.TabIndex = 0;
            // 
            // buttonXoaChucVu
            // 
            this.buttonXoaChucVu.AutoSize = true;
            this.buttonXoaChucVu.BackColor = System.Drawing.Color.Transparent;
            this.buttonXoaChucVu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonXoaChucVu.Location = new System.Drawing.Point(655, 13);
            this.buttonXoaChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoaChucVu.Name = "buttonXoaChucVu";
            this.buttonXoaChucVu.Size = new System.Drawing.Size(126, 31);
            this.buttonXoaChucVu.TabIndex = 9;
            this.buttonXoaChucVu.Text = "Xoá chức vụ";
            this.buttonXoaChucVu.UseVisualStyleBackColor = false;
            this.buttonXoaChucVu.Click += new System.EventHandler(this.buttonXoaChucVu_Click);
            // 
            // buttonSuaChucVu
            // 
            this.buttonSuaChucVu.AutoSize = true;
            this.buttonSuaChucVu.BackColor = System.Drawing.Color.Transparent;
            this.buttonSuaChucVu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSuaChucVu.Location = new System.Drawing.Point(523, 13);
            this.buttonSuaChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSuaChucVu.Name = "buttonSuaChucVu";
            this.buttonSuaChucVu.Size = new System.Drawing.Size(129, 31);
            this.buttonSuaChucVu.TabIndex = 8;
            this.buttonSuaChucVu.Text = "Sửa chức vụ";
            this.buttonSuaChucVu.UseVisualStyleBackColor = false;
            this.buttonSuaChucVu.Click += new System.EventHandler(this.buttonSuaChucVu_Click);
            // 
            // buttonThemChucVu
            // 
            this.buttonThemChucVu.AutoSize = true;
            this.buttonThemChucVu.BackColor = System.Drawing.Color.Transparent;
            this.buttonThemChucVu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonThemChucVu.Location = new System.Drawing.Point(389, 13);
            this.buttonThemChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThemChucVu.Name = "buttonThemChucVu";
            this.buttonThemChucVu.Size = new System.Drawing.Size(128, 31);
            this.buttonThemChucVu.TabIndex = 7;
            this.buttonThemChucVu.Text = "Thêm chức vụ";
            this.buttonThemChucVu.UseVisualStyleBackColor = false;
            this.buttonThemChucVu.Click += new System.EventHandler(this.buttonThemChucVu_Click);
            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.Location = new System.Drawing.Point(129, 13);
            this.comboBoxChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.Size = new System.Drawing.Size(241, 27);
            this.comboBoxChucVu.TabIndex = 2;
            this.comboBoxChucVu.SelectedIndexChanged += new System.EventHandler(this.comboBoxChucVu_SelectedIndexChanged);
            // 
            // labelVaitro
            // 
            this.labelVaitro.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVaitro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelVaitro.Location = new System.Drawing.Point(15, 11);
            this.labelVaitro.Name = "labelVaitro";
            this.labelVaitro.Size = new System.Drawing.Size(108, 26);
            this.labelVaitro.TabIndex = 0;
            this.labelVaitro.Text = "Chức vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControlMainPhanQuyen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 339);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PHÂN QUYỀN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLuu);
            this.groupBox2.Controls.Add(this.buttonThoat);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 58);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // buttonLuu
            // 
            this.buttonLuu.AutoSize = true;
            this.buttonLuu.BackColor = System.Drawing.Color.Transparent;
            this.buttonLuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLuu.Location = new System.Drawing.Point(320, 16);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(126, 37);
            this.buttonLuu.TabIndex = 6;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = false;
            // 
            // buttonThoat
            // 
            this.buttonThoat.AutoSize = true;
            this.buttonThoat.BackColor = System.Drawing.Color.Transparent;
            this.buttonThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonThoat.Location = new System.Drawing.Point(452, 16);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(126, 37);
            this.buttonThoat.TabIndex = 11;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.sidePanel1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Appearance.Options.UseBorderColor = true;
            this.sidePanel1.Controls.Add(this.groupBox1);
            this.sidePanel1.Controls.Add(this.panelVaitro);
            this.sidePanel1.Controls.Add(this.groupBox2);
            this.sidePanel1.Location = new System.Drawing.Point(480, 71);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(828, 454);
            this.sidePanel1.TabIndex = 14;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(713, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "QUẢN LÝ CHỨC VỤ VÀ PHÂN QUYỀN NGƯỜI DÙNG";
            // 
            // Phanquyen
            // 
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sidePanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Phanquyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHÂN QUYỀN NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.Phanquyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMainPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.panelVaitro.ResumeLayout(false);
            this.panelVaitro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.sidePanel1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonThoat;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.Label label1;
    }
}