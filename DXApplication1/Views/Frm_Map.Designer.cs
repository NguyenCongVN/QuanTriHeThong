

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
            this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMap = new System.Windows.Forms.Panel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.buttonAnHien = new System.Windows.Forms.Button();
            this.timerAnHien = new System.Windows.Forms.Timer(this.components);
            this.panelNode = new System.Windows.Forms.Panel();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAnHienChiTietFile = new System.Windows.Forms.Button();
            this.timerAnHienFile = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panelNode.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListChild
            // 
            this.imageListChild.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListChild.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListChild.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.iconPro;
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.item1ToolStripMenuItem.Text = "Thông tin";
            this.item1ToolStripMenuItem.Click += new System.EventHandler(this.item1ToolStripMenuItem_Click);
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.item2ToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.iconDelete;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.item2ToolStripMenuItem.Text = "Delete";
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtOutput.Location = new System.Drawing.Point(37, 0);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(187, 756);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMap.InitialImage = null;
            this.pictureBoxMap.Location = new System.Drawing.Point(6, 16);
            this.pictureBoxMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(861, 249);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // panelMap
            // 
            this.panelMap.AutoScroll = true;
            this.panelMap.Controls.Add(this.pictureBoxMap);
            this.panelMap.Location = new System.Drawing.Point(230, 87);
            this.panelMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(1193, 607);
            this.panelMap.TabIndex = 10;
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelSideBar.Controls.Add(this.buttonAnHien);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideBar.Location = new System.Drawing.Point(1338, 0);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(37, 756);
            this.panelSideBar.TabIndex = 0;
            // 
            // buttonAnHien
            // 
            this.buttonAnHien.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAnHien.Location = new System.Drawing.Point(0, 0);
            this.buttonAnHien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnHien.Name = "buttonAnHien";
            this.buttonAnHien.Size = new System.Drawing.Size(37, 97);
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
            this.panelNode.Controls.Add(this.buttonXoa);
            this.panelNode.Controls.Add(this.label1);
            this.panelNode.Controls.Add(this.treeView1);
            this.panelNode.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNode.Location = new System.Drawing.Point(1063, 0);
            this.panelNode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNode.Name = "panelNode";
            this.panelNode.Size = new System.Drawing.Size(275, 756);
            this.panelNode.TabIndex = 11;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(93, 418);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách ";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.buttonAnHienChiTietFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 756);
            this.panel1.TabIndex = 1;
            // 
            // buttonAnHienChiTietFile
            // 
            this.buttonAnHienChiTietFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAnHienChiTietFile.Location = new System.Drawing.Point(0, 0);
            this.buttonAnHienChiTietFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAnHienChiTietFile.Name = "buttonAnHienChiTietFile";
            this.buttonAnHienChiTietFile.Size = new System.Drawing.Size(37, 97);
            this.buttonAnHienChiTietFile.TabIndex = 1;
            this.buttonAnHienChiTietFile.Text = "H\r\ni\r\nd\r\ne";
            this.buttonAnHienChiTietFile.UseVisualStyleBackColor = true;
            this.buttonAnHienChiTietFile.Click += new System.EventHandler(this.buttonAnHienChiTietFile_Click);
            // 
            // timerAnHienFile
            // 
            this.timerAnHienFile.Tick += new System.EventHandler(this.timerAnHienFile_Tick);
            // 
            // Frm_test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 756);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNode);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelMap);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_test1";
            this.Text = resources.GetString("$this.Text");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_test1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.panelNode.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageListChild;
        public System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Panel panelMap;
        private Panel panelSideBar;
        private Button buttonAnHien;
        private Timer timerAnHien;
        private Panel panelNode;
        private Button buttonXoa;
        private Label label1;
        private TreeView treeView1;
        private Panel panel1;
        private Button buttonAnHienChiTietFile;
        private Timer timerAnHienFile;
        public PictureBox pictureBoxMap;
    }
}