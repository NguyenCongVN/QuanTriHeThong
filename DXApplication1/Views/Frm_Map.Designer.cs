

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
            this.buttonAnHien = new System.Windows.Forms.Button();
            this.timerAnHien = new System.Windows.Forms.Timer(this.components);
            this.panelNode = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.controlDanhSach = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.themtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAnHienChiTietFile = new System.Windows.Forms.Button();
            this.timerAnHienFile = new System.Windows.Forms.Timer(this.components);
            this.simpleButtonQuanLyPhuongAn = new DevExpress.XtraEditors.SimpleButton();
            this.controlParentNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đoiTenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmKíHiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlChildNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.doiTentoolStripMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.xoatoolStripMenuItemChild = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMap = new DXApplication1.Views.CustomScrollPanel();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panelNode.SuspendLayout();
            this.controlDanhSach.SuspendLayout();
            this.panel1.SuspendLayout();
            this.controlParentNode.SuspendLayout();
            this.controlChildNode.SuspendLayout();
            this.panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
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
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtOutput.Location = new System.Drawing.Point(32, 0);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(161, 614);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.iconPro;
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.item1ToolStripMenuItem.Text = "Thông tin";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.item2ToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.iconDelete;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.item2ToolStripMenuItem.Text = "Delete";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.item2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 56);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelSideBar.Controls.Add(this.buttonAnHien);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideBar.Location = new System.Drawing.Point(1147, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(32, 614);
            this.panelSideBar.TabIndex = 0;
            // 
            // buttonAnHien
            // 
            this.buttonAnHien.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAnHien.Location = new System.Drawing.Point(0, 0);
            this.buttonAnHien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnHien.Name = "buttonAnHien";
            this.buttonAnHien.Size = new System.Drawing.Size(32, 79);
            this.buttonAnHien.TabIndex = 1;
            this.buttonAnHien.Text = "H\r\ni\r\nd\r\ne";
            this.buttonAnHien.UseVisualStyleBackColor = true;
            this.buttonAnHien.Click += new System.EventHandler(this.buttonAnHien_Click);
            // 
            // timerAnHien
            // 
            this.timerAnHien.Tick += new System.EventHandler(this.timerAnHien_Tick);
            // 
            // panelNode
            // 
            this.panelNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelNode.Controls.Add(this.label1);
            this.panelNode.Controls.Add(this.treeView1);
            this.panelNode.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNode.Location = new System.Drawing.Point(945, 0);
            this.panelNode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNode.Name = "panelNode";
            this.panelNode.Size = new System.Drawing.Size(202, 614);
            this.panelNode.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.ContextMenuStrip = this.controlDanhSach;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách ";
            // 
            // controlDanhSach
            // 
            this.controlDanhSach.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.controlDanhSach.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themtoolStripMenuItem});
            this.controlDanhSach.Name = "controlTreeView";
            this.controlDanhSach.Size = new System.Drawing.Size(175, 30);
            // 
            // themtoolStripMenuItem
            // 
            this.themtoolStripMenuItem.Image = global::DXApplication1.Properties.Resources.icons8_add_new_100;
            this.themtoolStripMenuItem.Name = "themtoolStripMenuItem";
            this.themtoolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.themtoolStripMenuItem.Text = "Thêm Binh Chủng";
            this.themtoolStripMenuItem.Click += new System.EventHandler(this.themtoolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageListChild;
            this.treeView1.Location = new System.Drawing.Point(0, 42);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(234, 362);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.buttonAnHienChiTietFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 614);
            this.panel1.TabIndex = 1;
            // 
            // buttonAnHienChiTietFile
            // 
            this.buttonAnHienChiTietFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAnHienChiTietFile.Location = new System.Drawing.Point(0, 0);
            this.buttonAnHienChiTietFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnHienChiTietFile.Name = "buttonAnHienChiTietFile";
            this.buttonAnHienChiTietFile.Size = new System.Drawing.Size(32, 79);
            this.buttonAnHienChiTietFile.TabIndex = 1;
            this.buttonAnHienChiTietFile.Text = "H\r\ni\r\nd\r\ne";
            this.buttonAnHienChiTietFile.UseVisualStyleBackColor = true;
            this.buttonAnHienChiTietFile.Click += new System.EventHandler(this.buttonAnHienChiTietFile_Click);
            // 
            // timerAnHienFile
            // 
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
            this.controlParentNode.Size = new System.Drawing.Size(147, 82);
            // 
            // đoiTenToolStripMenuItem
            // 
            this.đoiTenToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.icons8_rename_48;
            this.đoiTenToolStripMenuItem.Name = "đoiTenToolStripMenuItem";
            this.đoiTenToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.đoiTenToolStripMenuItem.Text = "Chỉnh sửa";
            this.đoiTenToolStripMenuItem.Click += new System.EventHandler(this.đoiTenToolStripMenuItem_Click);
            // 
            // thêmKíHiệuToolStripMenuItem
            // 
            this.thêmKíHiệuToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.icons8_add_new_100;
            this.thêmKíHiệuToolStripMenuItem.Name = "thêmKíHiệuToolStripMenuItem";
            this.thêmKíHiệuToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.thêmKíHiệuToolStripMenuItem.Text = "Thêm kí hiệu";
            this.thêmKíHiệuToolStripMenuItem.Click += new System.EventHandler(this.thêmKíHiệuToolStripMenuItem_Click);
            // 
            // xoáToolStripMenuItem
            // 
            this.xoáToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.iconDelete;
            this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            this.xoáToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
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
            this.controlChildNode.Size = new System.Drawing.Size(132, 56);
            // 
            // doiTentoolStripMenuItemChild
            // 
            this.doiTentoolStripMenuItemChild.Image = global::DXApplication1.Properties.Resources.icons8_rename_48;
            this.doiTentoolStripMenuItemChild.Name = "doiTentoolStripMenuItemChild";
            this.doiTentoolStripMenuItemChild.Size = new System.Drawing.Size(131, 26);
            this.doiTentoolStripMenuItemChild.Text = "Chỉnh sửa";
            this.doiTentoolStripMenuItemChild.Click += new System.EventHandler(this.doiTentoolStripMenuItemChild_Click);
            // 
            // xoatoolStripMenuItemChild
            // 
            this.xoatoolStripMenuItemChild.Image = global::DXApplication1.Properties.Resources.iconDelete;
            this.xoatoolStripMenuItemChild.Name = "xoatoolStripMenuItemChild";
            this.xoatoolStripMenuItemChild.Size = new System.Drawing.Size(131, 26);
            this.xoatoolStripMenuItemChild.Text = "Xoá";
            this.xoatoolStripMenuItemChild.Click += new System.EventHandler(this.xoatoolStripMenuItemChild_Click);
            // 
            // panelMap
            // 
            this.panelMap.AutoScroll = true;
            this.panelMap.Controls.Add(this.pictureBoxMap);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(193, 0);
            this.panelMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(752, 614);
            this.panelMap.TabIndex = 14;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMap.InitialImage = null;
            this.pictureBoxMap.Location = new System.Drawing.Point(-81, 22);
            this.pictureBoxMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(861, 266);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Frm_test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 614);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.controlParentNode.ResumeLayout(false);
            this.controlChildNode.ResumeLayout(false);
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
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
        private Button buttonAnHien;
        private Timer timerAnHien;
        private Panel panelNode;
        private Label label1;
        private TreeView treeView1;
        private Panel panel1;
        private Button buttonAnHienChiTietFile;
        private Timer timerAnHienFile;
//<<<<<<< HEAD
        private DevExpress.XtraEditors.SimpleButton simpleButtonQuanLyPhuongAn;
        private CustomScrollPanel panelMap;
        public PictureBox pictureBoxMap;
        //=======
        private ContextMenuStrip controlParentNode;
        private ToolStripMenuItem đoiTenToolStripMenuItem;
        private ToolStripMenuItem thêmKíHiệuToolStripMenuItem;
        private ToolStripMenuItem xoáToolStripMenuItem;
        private ContextMenuStrip controlChildNode;
        private ToolStripMenuItem doiTentoolStripMenuItemChild;
        private ToolStripMenuItem xoatoolStripMenuItemChild;
        private ContextMenuStrip controlDanhSach;
        private ToolStripMenuItem themtoolStripMenuItem;
        //>>>>>>> pr/53
    }
}