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

using DevExpress.XtraPrinting.Export.Pdf;

namespace DXApplication1.Views
{
    public partial class Frm_test1 : DevExpress.XtraEditors.XtraForm
    {
        Button b1;
        PictureBox p1;

        PictureBox[] listPic;


        
        public Frm_test1()
        {
            InitializeComponent();
            init();
            MoveButton();
            MovePic();

            load_Tree();
            MoveButton(listPic[0]);

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




            //add button
            pictureBox1.AddControl(b1);

            //add picturebox
            pictureBox1.AddControl(p1);

            listPic = new PictureBox[10];
            listPic[0] = new PictureBox();
            listPic[0].Image = DXApplication1.Properties.Resources.TrungVo;
            listPic[0].SizeMode = PictureBoxSizeMode.AutoSize;
            listPic[0].Size = new Size(30, 30);
            listPic[0].BackColor = System.Drawing.Color.Black;

            listPic[0].Location = new Point(40,40);
            pictureBox1.AddControl(listPic[0]);

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

        public void MoveButton(PictureBox pp)
        {
            pp.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }

            };
            pp.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pp.Location = new Point(b1.Location.X - res.X, b1.Location.Y - res.Y);

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
        TreeNode nodee;
        public void load_Tree()
        {
             nodee = new TreeNode("Text for node 1");
            nodee.ImageIndex = 1;
            treeView1.Nodes.Add(nodee);
            

            TreeNode node1 = new TreeNode("C#");
            TreeNode node2 = new TreeNode("VB.NET");
            TreeNode node3 = new TreeNode("C++");
            TreeNode[] array = new TreeNode[] { node1, node2, node3 };
            TreeNode programmingLanguage = new TreeNode("Programming Language", array);
            programmingLanguage.ImageIndex = 2;
            treeView1.Nodes.Add(programmingLanguage);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == nodee)
            {
                
               
                pictureBox1.AddControl(listPic[0]);
            }
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            
        }

        private void Frm_test1_Load(object sender, EventArgs e)
        {
           
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }
    }
}