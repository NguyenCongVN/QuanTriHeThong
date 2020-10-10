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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node1", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node2", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node3", 3, 3);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node4", 4, 4);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("con1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("con2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("con3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("cha1", -2, -2, new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("con1");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("con2");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("con3");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("cha2", -2, -2, new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_test1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.item1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButtonBatDau = new DevExpress.XtraEditors.SimpleButton();
            this.labeTocDo = new System.Windows.Forms.Label();
            this.simpleButtonDatLai = new DevExpress.XtraEditors.SimpleButton();
            this.checkButtonTamDung = new DevExpress.XtraEditors.CheckButton();
            this.trackBarTocDo = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTocDo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1120, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 756);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 380);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách ";
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 38);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node0";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Node0";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node1";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Node1";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "Node2";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Node2";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "Node3";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "Node3";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "Node4";
            treeNode5.SelectedImageIndex = 4;
            treeNode5.Text = "Node4";
            treeNode6.Name = "Node1";
            treeNode6.Text = "con1";
            treeNode7.Name = "Node2";
            treeNode7.Text = "con2";
            treeNode8.Name = "Node3";
            treeNode8.Text = "con3";
            treeNode9.ImageIndex = -2;
            treeNode9.Name = "Node5";
            treeNode9.SelectedImageIndex = -2;
            treeNode9.Text = "cha1";
            treeNode10.Name = "Node5";
            treeNode10.Text = "con1";
            treeNode11.Name = "Node6";
            treeNode11.Text = "con2";
            treeNode12.Name = "Node7";
            treeNode12.Text = "con3";
            treeNode13.ImageIndex = -2;
            treeNode13.Name = "Node4";
            treeNode13.SelectedImageIndex = -2;
            treeNode13.Text = "cha2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode9,
            treeNode13});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(227, 474);
            this.treeView1.TabIndex = 0;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.PNG");
            this.imageList1.Images.SetKeyName(1, "2.PNG");
            this.imageList1.Images.SetKeyName(2, "3.PNG");
            this.imageList1.Images.SetKeyName(3, "4.PNG");
            this.imageList1.Images.SetKeyName(4, "5.PNG");
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(251, 756);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(251, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1350, 756);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simpleButtonBatDau);
            this.panel2.Controls.Add(this.labeTocDo);
            this.panel2.Controls.Add(this.simpleButtonDatLai);
            this.panel2.Controls.Add(this.checkButtonTamDung);
            this.panel2.Controls.Add(this.trackBarTocDo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(251, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 65);
            this.panel2.TabIndex = 9;
            // 
            // simpleButtonBatDau
            // 
            this.simpleButtonBatDau.ImageOptions.Image = global::DXApplication1.Properties.Resources.start_16;
            this.simpleButtonBatDau.Location = new System.Drawing.Point(688, 2);
            this.simpleButtonBatDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButtonBatDau.Name = "simpleButtonBatDau";
            this.simpleButtonBatDau.Size = new System.Drawing.Size(87, 33);
            this.simpleButtonBatDau.TabIndex = 12;
            this.simpleButtonBatDau.Text = "Bắt Đầu";
            // 
            // labeTocDo
            // 
            this.labeTocDo.AutoSize = true;
            this.labeTocDo.Location = new System.Drawing.Point(461, 46);
            this.labeTocDo.Name = "labeTocDo";
            this.labeTocDo.Size = new System.Drawing.Size(80, 17);
            this.labeTocDo.TabIndex = 11;
            this.labeTocDo.Text = "Tốc độ : X1";
            // 
            // simpleButtonDatLai
            // 
            this.simpleButtonDatLai.Location = new System.Drawing.Point(940, 3);
            this.simpleButtonDatLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButtonDatLai.Name = "simpleButtonDatLai";
            this.simpleButtonDatLai.Size = new System.Drawing.Size(60, 33);
            this.simpleButtonDatLai.TabIndex = 10;
            this.simpleButtonDatLai.Text = "Đặt Lại";
            // 
            // checkButtonTamDung
            // 
            this.checkButtonTamDung.ImageOptions.Image = global::DXApplication1.Properties.Resources.pause_16;
            this.checkButtonTamDung.Location = new System.Drawing.Point(809, 1);
            this.checkButtonTamDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkButtonTamDung.Name = "checkButtonTamDung";
            this.checkButtonTamDung.Size = new System.Drawing.Size(104, 34);
            this.checkButtonTamDung.TabIndex = 9;
            this.checkButtonTamDung.Text = "Tạm Dừng";
            // 
            // trackBarTocDo
            // 
            this.trackBarTocDo.Location = new System.Drawing.Point(327, 3);
            this.trackBarTocDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTocDo.Maximum = 7;
            this.trackBarTocDo.Minimum = 1;
            this.trackBarTocDo.Name = "trackBarTocDo";
            this.trackBarTocDo.Size = new System.Drawing.Size(320, 56);
            this.trackBarTocDo.TabIndex = 8;
            this.trackBarTocDo.Value = 4;
            // 
            // Frm_test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 756);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_test1";
            this.Text = resources.GetString("$this.Text");
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_test1_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTocDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem item1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem item2ToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBatDau;
        private System.Windows.Forms.Label labeTocDo;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDatLai;
        private DevExpress.XtraEditors.CheckButton checkButtonTamDung;
        private System.Windows.Forms.TrackBar trackBarTocDo;
    }
}