using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.Models
{
    class DoiTuong : Form
    {
        PictureBox picture;
        string detail;
        public enum DoiTuongFields
        {
            Picture,
            Detail
        }
        public PictureBox Picture { get => picture; set => picture = value; }
        public string Detail { get => detail; set => detail = value; }

        public DoiTuong()
        {
            picture = new PictureBox();
            picture.BackColor = System.Drawing.Color.Transparent;
            picture.Size = new System.Drawing.Size(13, 20);
            picture.SizeMode = PictureBoxSizeMode.AutoSize;
            picture.Click += new System.EventHandler(this.picClick);
        }
        public DoiTuong(PictureBox _pic, string _detail)
        {
            this.picture = _pic;
            this.detail = _detail;
        }
        public void picClick(object sender, EventArgs e)
        {
            MessageBox.Show(detail);
        }
    }
}
