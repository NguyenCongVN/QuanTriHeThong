using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Extensions;
using DXApplication1.UserControls;
using DevExpress.XtraPrinting.Export.Pdf;

namespace DXApplication1.Views
{
    public partial class Frm_test1 : DevExpress.XtraEditors.XtraForm
    {
        Button b1;
        PictureBox p1;
        UserPictureBox up1;
        string tt = "aaaa" +
            "dddd";
        
        public Frm_test1()
        {
            InitializeComponent();
            init();
            MoveButton();
            MovePic();
            //up1.Usercontrol_click(new System.EventHandler(click));

            up1.MoveUser();
            //up1.Location = new Point(up1.Location.X - p3.X, up1.Location.Y - p3.Y);
            up1.pic_click(new EventHandler(User_click));

        }
        public void init()
        {
            //picture
            p1 = new PictureBox();
            p1.Size = new Size(13, 20);
            p1.Image = global::DXApplication1.Properties.Resources.TrungVo;
            p1.SizeMode = PictureBoxSizeMode.AutoSize;
            p1.Location = new Point(20, 20);

            //button
            b1 = new Button();
            b1.AutoSize = true;
            b1.Text = "b1";
            b1.Visible = true;
            b1.Location = new Point(0, 0);

            //user pic
            up1 = new UserPictureBox();
            up1.Location = new Point(50, 50);
            Image image = Image.FromFile(@"C:\Users\Dell\Desktop\Working-Lien-Cong\QuanTriHeThong\DXApplication1\Resources\gax1.PNG");
            up1.init(image, "hihi");



            //add button
            pictureBox1.AddControl(b1);

            //add picturebox
            pictureBox1.AddControl(p1);

            pictureBox1.AddControl(up1);

        }
        private Point firstPoint = new Point();
        public void MoveButton()
        {
            b1.MouseDown += (ss, ee) =>
            {
                if(ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }    

            };
            b1.MouseMove += (ss, ee) =>
            {
                if(ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    b1.Location = new Point(b1.Location.X - res.X, b1.Location.Y - res.Y);

                    firstPoint = temp;
                }    
            };
        }
        public void MovePic()
        {
            p1.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }

            };
            p1.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    p1.Location = new Point(p1.Location.X - res.X, p1.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
        }

        //move user picturebox
        public void User_click(object sender, EventArgs e)
        {
            up1.UserClick(tt);
            //MessageBox.Show("hh");
        }


        
    }
}