using DXApplication1.Objects_Icon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.Models
{
    public class DoiTuong : Form
    {
        PictureBox picture;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private ToolStripMenuItem xóaToolStripMenuItem;
        string detail;

        public enum DoiTuongFields
        {
            Picture,
            Detail
        }

        public int MaDoiTuong { get; set; }

        public string MaDonVi { get; set; }

        public Point LocationInImage { get; set; }

        public Size initSizePicture { get; set; }

        public PictureBox Picture { get => picture; set => picture = value; }
        public  string Detail { get => detail; set => detail = value; }

        public DoiTuong()
        {
            InitializeComponent();
            picture = new PictureBox();
            picture.BackColor = System.Drawing.Color.Transparent;
            picture.Size = new System.Drawing.Size(13, 20);
            picture.SizeMode = PictureBoxSizeMode.AutoSize;
            picture.ContextMenuStrip = contextMenuStrip1;
        }
        public DoiTuong(PictureBox _pic, string _detail)
        {
            this.picture = _pic;
            this.detail = _detail;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 110);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.iconPro;
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.thôngTinToolStripMenuItem.Text = "Thông tin chi tiết";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.iconChinhsua;
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            this.chỉnhSửaToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::DXApplication1.Properties.Resources.iconDelete;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // DoiTuong
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "DoiTuong";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.flag = true;
            //MessageBox.Show(detail);
            Objects_Icon.TTDoiTuong tTDoiTuong = new TTDoiTuong();
            tTDoiTuong.ShowDialog();
            
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picture.Dispose();
            Program.frm_Map.pictureBoxMap.Controls.Remove(this.Picture);
            Program.frm_Map.listRemove.Add(this);
            Program.frm_Map.opted--;
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.flag = false;
            // ChinhSuaTT cs = new ChinhSuaTT();
            //cs.Show();
            //cs.Location = new Point(picture.Location.X + cs.Width + 50, picture.Location.Y + cs.Height);
            //cs.button1.Click += (ss, ee) =>
            //{

            //    if (cs.textBox1.Text != "")
            //    {
            //        detail = cs.textBox1.Text;
            //        MessageBox.Show("Thành công!");
            //        cs.Close();
            //    }
            //    else
            //        MessageBox.Show("Thông tin trống", "???");
            //};
        }
        
    }
}
