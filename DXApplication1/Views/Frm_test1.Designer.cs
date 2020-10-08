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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0", 0, 0);
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(1108, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 639);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách ";
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 51);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "Node0";
            treeNode1.SelectedImageIndex = 0;
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
            this.treeView1.Size = new System.Drawing.Size(230, 297);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(273, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(815, 653);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mở File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(14, 64);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(251, 590);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            // 
            // Frm_test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 823);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_test1";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.Frm_test1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}