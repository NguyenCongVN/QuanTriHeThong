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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageListChild = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.trackBarTocDo = new System.Windows.Forms.TrackBar();
            this.simpleButtonDatLai = new DevExpress.XtraEditors.SimpleButton();
            this.labeTocDo = new System.Windows.Forms.Label();
            this.checkButtonTamDung = new DevExpress.XtraEditors.CheckButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButtonBatDau = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTocDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(1117, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 639);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách ";
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageListChild;
            this.treeView1.Location = new System.Drawing.Point(0, 50);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(230, 365);
            this.treeView1.TabIndex = 0;
            // 
            // imageListChild
            // 
            this.imageListChild.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListChild.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListChild.TransparentColor = System.Drawing.Color.Transparent;
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
            // trackBarTocDo
            // 
            this.trackBarTocDo.Location = new System.Drawing.Point(309, 15);
            this.trackBarTocDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTocDo.Maximum = 7;
            this.trackBarTocDo.Minimum = 1;
            this.trackBarTocDo.Name = "trackBarTocDo";
            this.trackBarTocDo.Size = new System.Drawing.Size(320, 56);
            this.trackBarTocDo.TabIndex = 3;
            this.trackBarTocDo.Value = 4;
            this.trackBarTocDo.ValueChanged += new System.EventHandler(this.trackBarTocDo_ValueChanged);
            // 
            // simpleButtonDatLai
            // 
            this.simpleButtonDatLai.Location = new System.Drawing.Point(927, 16);
            this.simpleButtonDatLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButtonDatLai.Name = "simpleButtonDatLai";
            this.simpleButtonDatLai.Size = new System.Drawing.Size(76, 33);
            this.simpleButtonDatLai.TabIndex = 5;
            this.simpleButtonDatLai.Text = "Đặt Lại";
            this.simpleButtonDatLai.Click += new System.EventHandler(this.simpleButtonDatLai_Click);
            // 
            // labeTocDo
            // 
            this.labeTocDo.AutoSize = true;
            this.labeTocDo.Location = new System.Drawing.Point(448, 53);
            this.labeTocDo.Name = "labeTocDo";
            this.labeTocDo.Size = new System.Drawing.Size(80, 17);
            this.labeTocDo.TabIndex = 6;
            this.labeTocDo.Text = "Tốc độ : X1";
            // 
            // checkButtonTamDung
            // 
            this.checkButtonTamDung.ImageOptions.Image = global::DXApplication1.Properties.Resources.pause_16;
            this.checkButtonTamDung.Location = new System.Drawing.Point(796, 14);
            this.checkButtonTamDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkButtonTamDung.Name = "checkButtonTamDung";
            this.checkButtonTamDung.Size = new System.Drawing.Size(104, 34);
            this.checkButtonTamDung.TabIndex = 4;
            this.checkButtonTamDung.Text = "Tạm Dừng";
            this.checkButtonTamDung.CheckedChanged += new System.EventHandler(this.checkButtonTamDung_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(271, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(815, 653);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButtonBatDau
            // 
            this.simpleButtonBatDau.ImageOptions.Image = global::DXApplication1.Properties.Resources.start_16;
            this.simpleButtonBatDau.Location = new System.Drawing.Point(675, 15);
            this.simpleButtonBatDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButtonBatDau.Name = "simpleButtonBatDau";
            this.simpleButtonBatDau.Size = new System.Drawing.Size(87, 33);
            this.simpleButtonBatDau.TabIndex = 7;
            this.simpleButtonBatDau.Text = "Bắt Đầu";
            this.simpleButtonBatDau.Click += new System.EventHandler(this.simpleButtonBatDau_Click);
            // 
            // Frm_test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 756);
            this.Controls.Add(this.simpleButtonBatDau);
            this.Controls.Add(this.labeTocDo);
            this.Controls.Add(this.simpleButtonDatLai);
            this.Controls.Add(this.checkButtonTamDung);
            this.Controls.Add(this.trackBarTocDo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_test1";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.Frm_test1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTocDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageListChild;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TrackBar trackBarTocDo;
        private DevExpress.XtraEditors.CheckButton checkButtonTamDung;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDatLai;
        private System.Windows.Forms.Label labeTocDo;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBatDau;
    }
}