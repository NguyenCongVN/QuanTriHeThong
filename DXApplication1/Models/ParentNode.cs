using DXApplication1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.Models
{
    public partial class ParentNode : Form
    {
        private ContextMenuStrip controlTreeView;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem đoiTenToolStripMenuItem;
        private ToolStripMenuItem thêmKíHiệuToolStripMenuItem;
        private ToolStripMenuItem xoáToolStripMenuItem;

        public enum ChildNodeFields
        {

        }

        public ParentNode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.controlTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đoiTenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmKíHiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlTreeView
            // 
            this.controlTreeView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.controlTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đoiTenToolStripMenuItem,
            this.thêmKíHiệuToolStripMenuItem,
            this.xoáToolStripMenuItem});
            this.controlTreeView.Name = "controlTreeView";
            this.controlTreeView.Size = new System.Drawing.Size(215, 110);
            // 
            // đoiTenToolStripMenuItem
            // 
            this.đoiTenToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.icons8_rename_48;
            this.đoiTenToolStripMenuItem.Name = "đoiTenToolStripMenuItem";
            this.đoiTenToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.đoiTenToolStripMenuItem.Text = "Đổi tên";
            this.đoiTenToolStripMenuItem.Click += new System.EventHandler(this.đoiTenToolStripMenuItem_Click);
            // 
            // thêmKíHiệuToolStripMenuItem
            // 
            this.thêmKíHiệuToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.icons8_add_new_100;
            this.thêmKíHiệuToolStripMenuItem.Name = "thêmKíHiệuToolStripMenuItem";
            this.thêmKíHiệuToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.thêmKíHiệuToolStripMenuItem.Text = "Thêm kí hiệu";
            this.thêmKíHiệuToolStripMenuItem.Click += new System.EventHandler(this.thêmKíHiệuToolStripMenuItem_Click);
            // 
            // xoáToolStripMenuItem
            // 
            this.xoáToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.iconDelete;
            this.xoáToolStripMenuItem.Name = "xoáToolStripMenuItem";
            this.xoáToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.xoáToolStripMenuItem.Text = "Xoá";
            this.xoáToolStripMenuItem.Click += new System.EventHandler(this.xoáToolStripMenuItem_Click);
            // 
            // ParentNode
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "ParentNode";
            this.controlTreeView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void đoiTenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmKíHiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
