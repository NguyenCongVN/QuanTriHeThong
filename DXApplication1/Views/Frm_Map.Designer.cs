

using System.Windows.Forms;

namespace DXApplication1.Views
{
    partial class Frm_test1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_test1));
            this.imageListChild = new System.Windows.Forms.ImageList(this.components);
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.buttonAnHienChiTietFile = new System.Windows.Forms.Button();
            this.buttonAnHienKyHieuQuanSu = new System.Windows.Forms.Button();
            this.btnAnHienMophong = new System.Windows.Forms.Button();
            this.timerAnHien = new System.Windows.Forms.Timer(this.components);
            this.panelNode = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.controlDanhSach = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.timerAnHienFile = new System.Windows.Forms.Timer(this.components);
            this.simpleButtonQuanLyPhuongAn = new DevExpress.XtraEditors.SimpleButton();
            this.controlParentNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đoiTenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmKíHiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlChildNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.doiTentoolStripMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.xoatoolStripMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMP = new System.Windows.Forms.Timer(this.components);
            this.panelMap = new DXApplication1.Views.CustomScrollPanel();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.panelMP = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labeTocDo = new System.Windows.Forms.Label();
            this.trackBarTocDo = new System.Windows.Forms.TrackBar();
            this.checkButtonTamDung = new DevExpress.XtraEditors.CheckButton();
            this.simpleButtonDatLai = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonBatDau = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panelNode.SuspendLayout();
            this.controlDanhSach.SuspendLayout();
            this.controlParentNode.SuspendLayout();
            this.controlChildNode.SuspendLayout();
            this.panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.panelMP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTocDo)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListChild
            // 
            this.imageListChild.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListChild.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListChild.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtOutput.Location = new System.Drawing.Point(845, 0);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(257, 756);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.iconPro;
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.item1ToolStripMenuItem.Text = "Thông tin";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.item2ToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.iconDelete;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.item2ToolStripMenuItem.Text = "Delete";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.item2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 56);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelSideBar.Controls.Add(this.buttonAnHienChiTietFile);
            this.panelSideBar.Controls.Add(this.buttonAnHienKyHieuQuanSu);
            this.panelSideBar.Controls.Add(this.btnAnHienMophong);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideBar.Location = new System.Drawing.Point(1338, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(37, 756);
            this.panelSideBar.TabIndex = 0;
            // 
            // buttonAnHienChiTietFile
            // 
            this.buttonAnHienChiTietFile.Location = new System.Drawing.Point(0, 299);
            this.buttonAnHienChiTietFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnHienChiTietFile.Name = "buttonAnHienChiTietFile";
            this.buttonAnHienChiTietFile.Size = new System.Drawing.Size(40, 121);
            this.buttonAnHienChiTietFile.TabIndex = 2;
            this.buttonAnHienChiTietFile.UseVisualStyleBackColor = true;
            this.buttonAnHienChiTietFile.Click += new System.EventHandler(this.buttonAnHienChiTietFile_Click_1);
            this.buttonAnHienChiTietFile.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonAnHienChiTietFile_Paint);
            // 
            // buttonAnHienKyHieuQuanSu
            // 
            this.buttonAnHienKyHieuQuanSu.Location = new System.Drawing.Point(0, 124);
            this.buttonAnHienKyHieuQuanSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnHienKyHieuQuanSu.Name = "buttonAnHienKyHieuQuanSu";
            this.buttonAnHienKyHieuQuanSu.Size = new System.Drawing.Size(41, 162);
            this.buttonAnHienKyHieuQuanSu.TabIndex = 1;
            this.buttonAnHienKyHieuQuanSu.UseVisualStyleBackColor = true;
            this.buttonAnHienKyHieuQuanSu.Click += new System.EventHandler(this.buttonKyHieuQuanSu_Click);
            this.buttonAnHienKyHieuQuanSu.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonAnHien_Paint);
            // 
            // btnAnHienMophong
            // 
            this.btnAnHienMophong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnHienMophong.Location = new System.Drawing.Point(0, 0);
            this.btnAnHienMophong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnHienMophong.Name = "btnAnHienMophong";
            this.btnAnHienMophong.Size = new System.Drawing.Size(37, 119);
            this.btnAnHienMophong.TabIndex = 2;
            this.btnAnHienMophong.UseVisualStyleBackColor = true;
            this.btnAnHienMophong.Click += new System.EventHandler(this.btnAnHienMophong_Click);
            this.btnAnHienMophong.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAnHienMophong_Paint);
            // 
            // timerAnHien
            // 
            this.timerAnHien.Interval = 10;
            this.timerAnHien.Tick += new System.EventHandler(this.timerAnHien_Tick);
            // 
            // panelNode
            // 
            this.panelNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelNode.Controls.Add(this.label1);
            this.panelNode.Controls.Add(this.treeView1);
            this.panelNode.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNode.Location = new System.Drawing.Point(1102, 0);
            this.panelNode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNode.Name = "panelNode";
            this.panelNode.Size = new System.Drawing.Size(236, 756);
            this.panelNode.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.ContextMenuStrip = this.controlDanhSach;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách ";
            // 
            // controlDanhSach
            // 
            this.controlDanhSach.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.controlDanhSach.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themtoolStripMenuItem});
            this.controlDanhSach.Name = "controlTreeView";
            this.controlDanhSach.Size = new System.Drawing.Size(199, 30);
            // 
            // themtoolStripMenuItem
            // 
            this.themtoolStripMenuItem.Image = global::DXApplication1.Properties.Resources.icons8_add_new_100;
            this.themtoolStripMenuItem.Name = "themtoolStripMenuItem";
            this.themtoolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.themtoolStripMenuItem.Text = "Thêm Binh Chủng";
            this.themtoolStripMenuItem.Click += new System.EventHandler(this.themtoolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageListChild;
            this.treeView1.Location = new System.Drawing.Point(0, 52);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(272, 445);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // timerAnHienFile
            // 
            this.timerAnHienFile.Interval = 10;
            this.timerAnHienFile.Tick += new System.EventHandler(this.timerAnHienFile_Tick);
            // 
            // simpleButtonQuanLyPhuongAn
            // 
            this.simpleButtonQuanLyPhuongAn.Location = new System.Drawing.Point(389, 1);
            this.simpleButtonQuanLyPhuongAn.Name = "simpleButtonQuanLyPhuongAn";
            this.simpleButtonQuanLyPhuongAn.Size = new System.Drawing.Size(136, 23);
            this.simpleButtonQuanLyPhuongAn.TabIndex = 13;
            this.simpleButtonQuanLyPhuongAn.Text = "Quản lý phương án";
            this.simpleButtonQuanLyPhuongAn.Click += new System.EventHandler(this.simpleButtonLuuPhuongAn_Click);
            // 
            // controlParentNode
            // 
            this.controlParentNode.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.controlParentNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đoiTenToolStripMenuItem,
            this.thêmKíHiệuToolStripMenuItem,
            this.xoáToolStripMenuItem});
            this.controlParentNode.Name = "controlTreeView";
            this.controlParentNode.Size = new System.Drawing.Size(167, 82);
            // 
            // đoiTenToolStripMenuItem
            // 
            this.đoiTenToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.icons8_rename_48;
            this.đoiTenToolStripMenuItem.Name = "đoiTenToolStripMenuItem";
            this.đoiTenToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.đoiTenToolStripMenuItem.Text = "Chỉnh sửa";
            this.đoiTenToolStripMenuItem.Click += new System.EventHandler(this.đoiTenToolStripMenuItem_Click);
            // 
            // thêmKíHiệuToolStripMenuItem
            // 
            this.thêmKíHiệuToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.icons8_add_new_100;
            this.thêmKíHiệuToolStripMenuItem.Name = "thêmKíHiệuToolStripMenuItem";
            this.thêmKíHiệuToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.thêmKíHiệuToolStripMenuItem.Text = "Thêm kí hiệu";
            this.thêmKíHiệuToolStripMenuItem.Click += new System.EventHandler(this.thêmKíHiệuToolStripMenuItem_Click);
            // 
            // xoáToolStripMenuItem
            // 
            this.xoáToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.iconDelete;
            this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            this.xoáToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.xoáToolStripMenuItem.Text = "Xoá";
            this.xoáToolStripMenuItem.Click += new System.EventHandler(this.xoáToolStripMenuItem_Click);
            // 
            // controlChildNode
            // 
            this.controlChildNode.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.controlChildNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiTentoolStripMenuItemChild,
            this.xoatoolStripMenuItemChild});
            this.controlChildNode.Name = "controlTreeView";
            this.controlChildNode.Size = new System.Drawing.Size(147, 56);
            // 
            // doiTentoolStripMenuItemChild
            // 
            this.doiTentoolStripMenuItemChild.Image = global::DXApplication1.Properties.Resources.icons8_rename_48;
            this.doiTentoolStripMenuItemChild.Name = "doiTentoolStripMenuItemChild";
            this.doiTentoolStripMenuItemChild.Size = new System.Drawing.Size(146, 26);
            this.doiTentoolStripMenuItemChild.Text = "Chỉnh sửa";
            this.doiTentoolStripMenuItemChild.Click += new System.EventHandler(this.doiTentoolStripMenuItemChild_Click);
            // 
            // xoatoolStripMenuItemChild
            // 
            this.xoatoolStripMenuItemChild.Image = global::DXApplication1.Properties.Resources.iconDelete;
            this.xoatoolStripMenuItemChild.Name = "xoatoolStripMenuItemChild";
            this.xoatoolStripMenuItemChild.Size = new System.Drawing.Size(146, 26);
            this.xoatoolStripMenuItemChild.Text = "Xoá";
            this.xoatoolStripMenuItemChild.Click += new System.EventHandler(this.xoatoolStripMenuItemChild_Click);
            // 
            // timerMP
            // 
            this.timerMP.Interval = 10;
            this.timerMP.Tick += new System.EventHandler(this.timerMP_Tick);
            // 
            // panelMap
            // 
            this.panelMap.AutoScroll = true;
            this.panelMap.Controls.Add(this.pictureBoxMap);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 0);
            this.panelMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(570, 756);
            this.panelMap.TabIndex = 14;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMap.InitialImage = null;
            this.pictureBoxMap.Location = new System.Drawing.Point(-80, 22);
            this.pictureBoxMap.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(861, 266);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelMP
            // 
            this.panelMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelMP.Controls.Add(this.label2);
            this.panelMP.Controls.Add(this.labeTocDo);
            this.panelMP.Controls.Add(this.trackBarTocDo);
            this.panelMP.Controls.Add(this.checkButtonTamDung);
            this.panelMP.Controls.Add(this.simpleButtonDatLai);
            this.panelMP.Controls.Add(this.simpleButtonBatDau);
            this.panelMP.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMP.Location = new System.Drawing.Point(570, 0);
            this.panelMP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMP.Name = "panelMP";
            this.panelMP.Size = new System.Drawing.Size(275, 756);
            this.panelMP.TabIndex = 11;
            this.panelMP.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMP_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cài Đặt Mô Phỏng";
            // 
            // labeTocDo
            // 
            this.labeTocDo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeTocDo.Location = new System.Drawing.Point(9, 299);
            this.labeTocDo.Name = "labeTocDo";
            this.labeTocDo.Size = new System.Drawing.Size(93, 21);
            this.labeTocDo.TabIndex = 4;
            this.labeTocDo.Text = "Tốc độ : X1";
            // 
            // trackBarTocDo
            // 
            this.trackBarTocDo.Location = new System.Drawing.Point(104, 288);
            this.trackBarTocDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTocDo.Maximum = 7;
            this.trackBarTocDo.Minimum = 1;
            this.trackBarTocDo.Name = "trackBarTocDo";
            this.trackBarTocDo.Size = new System.Drawing.Size(160, 56);
            this.trackBarTocDo.TabIndex = 3;
            this.trackBarTocDo.Value = 4;
            this.trackBarTocDo.ValueChanged += new System.EventHandler(this.trackBarTocDo_ValueChanged);
            // 
            // checkButtonTamDung
            // 
            this.checkButtonTamDung.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButtonTamDung.Appearance.Options.UseFont = true;
            this.checkButtonTamDung.ImageOptions.Image = global::DXApplication1.Properties.Resources.pause_16;
            this.checkButtonTamDung.Location = new System.Drawing.Point(90, 222);
            this.checkButtonTamDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkButtonTamDung.Name = "checkButtonTamDung";
            this.checkButtonTamDung.Size = new System.Drawing.Size(104, 34);
            this.checkButtonTamDung.TabIndex = 2;
            this.checkButtonTamDung.Text = "Tạm dừng";
            this.checkButtonTamDung.CheckedChanged += new System.EventHandler(this.checkButtonTamDung_CheckedChanged);
            // 
            // simpleButtonDatLai
            // 
            this.simpleButtonDatLai.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonDatLai.Appearance.Options.UseFont = true;
            this.simpleButtonDatLai.ImageOptions.Image = global::DXApplication1.Properties.Resources.start_16;
            this.simpleButtonDatLai.Location = new System.Drawing.Point(98, 160);
            this.simpleButtonDatLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButtonDatLai.Name = "simpleButtonDatLai";
            this.simpleButtonDatLai.Size = new System.Drawing.Size(87, 34);
            this.simpleButtonDatLai.TabIndex = 1;
            this.simpleButtonDatLai.Text = "Đặt lại";
            this.simpleButtonDatLai.Click += new System.EventHandler(this.simpleButtonDatLai_Click);
            // 
            // simpleButtonBatDau
            // 
            this.simpleButtonBatDau.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonBatDau.Appearance.Options.UseFont = true;
            this.simpleButtonBatDau.ImageOptions.Image = global::DXApplication1.Properties.Resources.start_16;
            this.simpleButtonBatDau.Location = new System.Drawing.Point(98, 94);
            this.simpleButtonBatDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButtonBatDau.Name = "simpleButtonBatDau";
            this.simpleButtonBatDau.Size = new System.Drawing.Size(87, 34);
            this.simpleButtonBatDau.TabIndex = 0;
            this.simpleButtonBatDau.Text = "Bắt đầu";
            this.simpleButtonBatDau.Click += new System.EventHandler(this.simpleButtonBatDau_Click);
            // 
            // Frm_test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 756);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.panelMP);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.panelNode);
            this.Controls.Add(this.panelSideBar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_test1";
            this.Text = resources.GetString("$this.Text");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_test1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            this.panelNode.ResumeLayout(false);
            this.controlDanhSach.ResumeLayout(false);
            this.controlParentNode.ResumeLayout(false);
            this.controlChildNode.ResumeLayout(false);
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.panelMP.ResumeLayout(false);
            this.panelMP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTocDo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListChild;
        public System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Panel panelSideBar;
        private Button buttonAnHienKyHieuQuanSu;
        private Timer timerAnHien;
        private Panel panelNode;
        private Label label1;
        private TreeView treeView1;
        private Timer timerAnHienFile;
        private DevExpress.XtraEditors.SimpleButton simpleButtonQuanLyPhuongAn;
        private CustomScrollPanel panelMap;
        public PictureBox pictureBoxMap;
        private ContextMenuStrip controlParentNode;
        private ToolStripMenuItem đoiTenToolStripMenuItem;
        private ToolStripMenuItem thêmKíHiệuToolStripMenuItem;
        private ToolStripMenuItem xoáToolStripMenuItem;
        private ContextMenuStrip controlChildNode;
        private ToolStripMenuItem doiTentoolStripMenuItemChild;
        private ToolStripMenuItem xoatoolStripMenuItemChild;
        private ContextMenuStrip controlDanhSach;
        private ToolStripMenuItem themtoolStripMenuItem;
        private Button buttonAnHienChiTietFile;
        private Button btnAnHienMophong;
        private Timer timerMP;
        private Panel panelMP;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBatDau;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDatLai;
        private DevExpress.XtraEditors.CheckButton checkButtonTamDung;
        private Label labeTocDo;
        private TrackBar trackBarTocDo;
        private Label label2;
    }
}