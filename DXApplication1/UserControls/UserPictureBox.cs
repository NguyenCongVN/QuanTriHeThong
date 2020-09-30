using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.UserControls
{
    public partial class UserPictureBox : UserControl
    {
        int check = 0;
        public UserPictureBox()
        {
            InitializeComponent();
            
        }

        private void UserPictureBox_Load(object sender, EventArgs e)
        {
            
        }
        public void init(Image im1, string lb1)
        {
            pictureBox1.Image = im1;
            label1.Text = lb1;
            label1.Location = new Point((pictureBox1.Location.X + pictureBox1.Width) / 2, (pictureBox1.Location.Y + pictureBox1.Height + 1));

        }
        private Point firstPoint = new Point();
        public void MoveUser()
        {
            pictureBox1.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }

            };
            pictureBox1.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                     Point temp = Control.MousePosition;
                     Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    
                    this.Location = new Point(this.Location.X - res.X, this.Location.Y - res.Y);
                    firstPoint = temp;
                }
            };
            
        }
        public void UserClick(string ThongTin)
        {

            MessageBox.Show(ThongTin, "Thông tin");


        }

        public void pic_click(EventHandler e)
        {
            this.pictureBox1.Click += e;
        }    
    }
}
