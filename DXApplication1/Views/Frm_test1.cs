using Braincase.USGS.DEM;
using DXApplication1.Models;
using DXApplication1.Utilizes;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DXApplication1.Views
{
    public partial class Frm_test1 : DevExpress.XtraEditors.XtraForm
    {

        /// <summary>
        /// 
        /// </summary>
        ///
        /// Thread to change height
        private Thread a;
        // Thread to draw 
        private Thread b;
        // Map value to proportion
        private float MapValueToProportion(int value)
        {
            switch (value)
            {
                case 1: return (float)0.2;
                case 2: return (float)0.5;
                case 3: return (float)0.8;
                case 4: return (float)1;
                case 5: return (float)2;
                case 6: return (float)5;
                case 7: return (float)8;
                default: return (float)1;
            }
        }
        // Current path
        private string path;
        // Speed of virtualization
        // Default
        private const short speedInit = 5;
        // Temporary speed
        private static short speed = speedInit;
        //
        // Lock object for virtualization's speed
        private static object speedLock = new object();

        // Pause
        private static bool isPause = false;
        // Pause Lock
        private static object pauseLock = new object();

        static Bitmap bitmapInit1 = new Bitmap(Properties.Resources.Screenshot_2020_09_25_202017);

        Bitmap bitmapInit = new Bitmap(bitmapInit1, 1201, 1201);

        //

        Bitmap bitmapTemp = new Bitmap(bitmapInit1, 1201, 1201);

        //
        public static DemDocument _mDem = null;

        // object to lock _mDem file

        private static object DemLock = new object();

        // Ready to read file

        public static EventWaitHandle readyToRead = new AutoResetEvent(false);

        // Ready to write file

        public static EventWaitHandle readyToWrite = new AutoResetEvent(true);


        int check = 0;
        int opted = 0;

        PictureBox p1;
        DoiTuong[] listPic;
        DoiTuong[] selected = new DoiTuong[100];
        Image[] images;


        NodeOnMap nodeOnMap;

        public Frm_test1()
        {
            InitializeComponent();
            initImageOfNode();
            init();
            MovePic();
            pictureBox1.Image = bitmapInit;
        }
        public void initImageOfNode()
        {
            nodeOnMap = new NodeOnMap();
            DataSet PicSet = nodeOnMap.getIconChild();
            //images = new Image[1000];
            ////for (int i = 1; i <= 6; i++)
            ////{
            ////    images[i] = Image.FromFile(Environment.CurrentDirectory.ToString() + @"\..\..\Resources\" + i + ".png");
            ////}
            //int i = 0;
            foreach (DataRow dr in PicSet.Tables[0].Rows)
            {
                imageListChild.Images.Add(Image.FromFile(Environment.CurrentDirectory.ToString() + @"\..\..\Resources\" + dr["DuongDanAnh"].ToString()));
            }
        }
        public void init()
        {

            //picture
            p1 = new PictureBox();
            p1.Size = new Size(13, 20);
            p1.Image = global::DXApplication1.Properties.Resources.TrungVo;
            p1.SizeMode = PictureBoxSizeMode.AutoSize;
            p1.Location = new Point(20, 20);


            listPic = new DoiTuong[10];
            for (int i = 1; i <= 6; i++)
            {
                //listPic[i] = new DoiTuong();
                //listPic[i].Picture.Image = images[i];
            }

        }

        private Point firstPoint;


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

                    pp.Location = new Point(pp.Location.X - res.X, pp.Location.Y - res.Y);

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

        public void deletePic(PictureBox pic)
        {
            pic.Click += (ss, ee) =>
            {

                if (Control.ModifierKeys == Keys.Delete)
                {
                    MessageBox.Show("delete");
                }
            };
        }
        public void load_Tree()
        {
            nodeOnMap = new NodeOnMap();
            DataSet PicSet = nodeOnMap.getIconChild();
            //images = new Image[1000];
            ////for (int i = 1; i <= 6; i++)
            ////{
            ////    images[i] = Image.FromFile(Environment.CurrentDirectory.ToString() + @"\..\..\Resources\" + i + ".png");
            ////}
            //int i = 0;
            foreach (DataRow dr in PicSet.Tables[0].Rows)
            {
                imageListChild.Images.Add(dr["MaDonVi"].ToString(), Image.FromFile(Environment.CurrentDirectory.ToString() + @"\..\..\Resources\" + dr["DuongDanAnh"].ToString()));
            }
            int count = imageListChild.Images.Count;
            treeView1.ImageList = imageListChild;
            nodeOnMap = new NodeOnMap();
            DataSet PrSet = nodeOnMap.getDataParentNode();
            treeView1.Nodes.Clear();
            int i = 0;
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                treeView1.Nodes.Add(dr["MaBinhChung"].ToString(), dr["TenBinhChung"].ToString(), count + 1, count + 2);
                DataSet chSet = nodeOnMap.getDataChildNode(dr["MaBinhChung"].ToString());
                foreach (DataRow drch in chSet.Tables[0].Rows)
                {
                    int index = imageListChild.Images.IndexOfKey(drch["MaDonVi"].ToString());
                    treeView1.Nodes[i].Nodes.Add(drch["MaDonVi"].ToString(), drch["TenDonVi"].ToString(), index, index);
                }
                i++;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {



        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {

        }

        private void Frm_test1_Load(object sender, EventArgs e)
        {
            load_Tree();
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string fileName);
        Cursor myCursor;

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //if (e.Node.ImageIndex == 1)
            //{
            //    selected[opted] = new DoiTuong();
            //    selected[opted].Picture.Image = images[1];
            //    selected[opted].Detail = "detail" + opted;
            //    selected[opted].Picture.Location = new Point(10, 10);
            //    pictureBox1.AddControl(selected[opted].Picture);
            //    MoveButton(selected[opted].Picture);
            //    deletePic(selected[opted].Picture);
            //    opted++;

            //}
            //if (e.Node.ImageIndex == 2)
            //{
            //    selected[opted] = new DoiTuong();
            //    selected[opted].Picture.Image = images[2];
            //    selected[opted].Detail = "detail" + opted;
            //    selected[opted].Picture.Location = new Point(10, 10);
            //    pictureBox1.AddControl(selected[opted].Picture);
            //    MoveButton(selected[opted].Picture);
            //    opted++;
            //}
            //if (e.Node.ImageIndex == 3)
            //{
            //    selected[opted] = new DoiTuong();
            //    selected[opted].Picture.Image = images[3];
            //    selected[opted].Detail = "detail" + opted;
            //    selected[opted].Picture.Location = new Point(10, 10);
            //    pictureBox1.AddControl(selected[opted].Picture);
            //    MoveButton(selected[opted].Picture);
            //    opted++;

            //}
            //if (e.Node.ImageIndex == 4)
            //{
            //    selected[opted] = new DoiTuong();
            //    selected[opted].Picture.Image = images[4];
            //    selected[opted].Detail = "detail" + opted;
            //    selected[opted].Picture.Location = new Point(10, 10);
            //    pictureBox1.AddControl(selected[opted].Picture);
            //    MoveButton(selected[opted].Picture);
            //    opted++;

            //}
            //if (e.Node.ImageIndex == 5)
            //{
            //    selected[opted] = new DoiTuong();
            //    selected[opted].Picture.Image = images[5];
            //    selected[opted].Detail = "detail" + opted;
            //    selected[opted].Picture.Location = new Point(10, 10);
            //    pictureBox1.AddControl(selected[opted].Picture);
            //    MoveButton(selected[opted].Picture);
            //    opted++;

            //}

        }
        //nhap chuot phai hien thong tin, chuot trai cho phep sua thong tin
        //===============================================================================================           

        public static void ChangeHeight()
        {
            while (true)
            {
                // Check Pause
                while (true)
                {
                    bool tryToLockPause = false;
                    Monitor.TryEnter(pauseLock, ref tryToLockPause);
                    if (tryToLockPause)
                    {
                        try
                        {
                            if (isPause)
                            {
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                break;
                            }
                        }
                        finally
                        {
                            Monitor.Exit(pauseLock);
                            Thread.Sleep(1000);
                        }
                    }
                }
                readyToWrite.WaitOne();
                lock (DemLock)
                {
                    while (true)
                    {
                        bool tryToLockSpeed = false;
                        Monitor.TryEnter(speedLock, ref tryToLockSpeed);
                        if (tryToLockSpeed)
                        {
                            for (int col = 0; col < _mDem.ARecord.eastings_cols; col++)
                            {
                                for (int row = 0; row < _mDem.ARecord.northings_rows; row++)
                                {
                                    _mDem.BRecord.elevations[col, row] -= speed;
                                }
                            }
                            Monitor.Exit(speedLock);
                            break;
                        }
                    }
                }
                readyToRead.Set();
            }
        }

        public void DrawImage(PictureBox _mPictureBox)
        {
            while (true)
            {
                // Check Pause
                while (true)
                {
                    bool tryToLockPause1 = false;
                    Monitor.TryEnter(pauseLock, ref tryToLockPause1);
                    if (tryToLockPause1)
                    {
                        try
                        {
                            if (isPause)
                            {
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                break;
                            }
                        }
                        finally
                        {
                            Monitor.Exit(pauseLock);
                            Thread.Sleep(1000);
                        }
                    }
                }
                //
                readyToRead.WaitOne();
                lock (DemLock)
                {
                    if (_mDem != null)
                    {
                        //var bitmap = new Bitmap(_mDem.ARecord.northings_rows, _mDem.ARecord.eastings_cols);
                        var bitmap = new Bitmap(bitmapTemp);

                        for (int col = 0; col < _mDem.ARecord.eastings_cols; col++)
                        {
                            for (int row = 0; row < _mDem.ARecord.northings_rows; row++)
                            {
                                double height = _mDem.BRecord.elevations[col, row] * _mDem.ARecord.xyz_resolution[2];
                                var min = _mDem.ARecord.elevation_min;
                                var max = _mDem.ARecord.elevation_max;
                                if (row % 5 == 0)
                                    if (height >= min)
                                    {
                                        //int ratio = (int)(((height - min) / (max - min)) * 255f);
                                        bitmap.SetPixel(row, col, DrawHelper.GetGreenYellowRedByPropotion(height - min, max - min));
                                        // Or this, as suggested by thanaphan4 for fixing bitmap x/y orientation
                                        //bitmap.SetPixel(col, _mDem.ARecord.northings_rows - row - 1, Color.FromArgb(128, 128, ratio));
                                    }
                                    else
                                    {
                                        bitmap.SetPixel(row, col, DrawHelper.GetGreenYellowRedByPropotion(0, max - min));
                                        //bitmap.SetPixel(col, _mDem.ARecord.northings_rows - row - 1, Color.FromArgb(128, 128, 0));
                                    }
                            }
                        }

                        _mPictureBox.Invoke((MethodInvoker)delegate
                       {
                           // Running on the UI thread
                           _mPictureBox.Image = bitmap;
                       });
                    }
                }
                readyToWrite.Set();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (System.IO.File.Exists(dialog.FileName))
                {
                    path = dialog.FileName;
                    _mDem = new DemDocument();
                    _mDem.Read(dialog.FileName);
                    txtOutput.Text = string.Empty;
                    txtOutput.Text += "DEM Name: " + new string(_mDem.ARecord.file_name) + Environment.NewLine;
                    txtOutput.Text += "SE Coord: " + new string(_mDem.ARecord.SE_geographic_corner_S) + ", " + new string(_mDem.ARecord.SE_geographic_corner_E) + Environment.NewLine;
                    txtOutput.Text += "DEM Level Code: " + _mDem.ARecord.dem_level_code + Environment.NewLine;
                    txtOutput.Text += "Ground Reference System: " + (GROUND_REF_SYSTEM)_mDem.ARecord.ground_ref_system + Environment.NewLine;
                    txtOutput.Text += "Ground Reference Zone: " + _mDem.ARecord.ground_ref_zone + Environment.NewLine;
                    txtOutput.Text += "Ground Unit: " + (GROUND_UNIT)_mDem.ARecord.ground_unit + Environment.NewLine;
                    txtOutput.Text += "Elevation Unit: " + (ELEVATION_UNIT)_mDem.ARecord.elevation_unit + Environment.NewLine;
                    txtOutput.Text += "Ground Resolution (lat, lng, elev): " + _mDem.ARecord.xyz_resolution[0] + ", " + _mDem.ARecord.xyz_resolution[1] + ", " + _mDem.ARecord.xyz_resolution[2] + Environment.NewLine;
                    txtOutput.Text += "Elavation Array Szie: " + _mDem.ARecord.northings_rows + " x " + _mDem.ARecord.eastings_cols + Environment.NewLine;
                    txtOutput.Text += "Percentage void: " + _mDem.ARecord.percent_void + Environment.NewLine;
                    txtOutput.Text += "SW Coord: " + _mDem.ARecord.sw_coord[0] + ", " + _mDem.ARecord.sw_coord[1] + Environment.NewLine;
                    txtOutput.Text += "NW Coord: " + _mDem.ARecord.nw_coord[0] + ", " + _mDem.ARecord.nw_coord[1] + Environment.NewLine;
                    txtOutput.Text += "NE Coord: " + _mDem.ARecord.ne_coord[0] + ", " + _mDem.ARecord.ne_coord[1] + Environment.NewLine;
                    txtOutput.Text += "SE Coord: " + _mDem.ARecord.se_coord[0] + ", " + _mDem.ARecord.se_coord[1] + Environment.NewLine;

                }
            }
        }

        private void trackBarTocDo_ValueChanged(object sender, EventArgs e)
        {
            while (true)
            {
                bool tryToLockSpeed = false;
                Monitor.TryEnter(speedLock, ref tryToLockSpeed);
                float proportion = MapValueToProportion(trackBarTocDo.Value);
                if (tryToLockSpeed)
                {
                    speed = (short)(speedInit * proportion);
                    labeTocDo.Text = "Tốc độ : X" + proportion;
                    Monitor.Exit(speedLock);
                    break;
                }
            }
        }

        private void checkButtonTamDung_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButtonTamDung.Checked)
            {

                checkButtonTamDung.Image = Properties.Resources.start_16;
                checkButtonTamDung.Text = "Tiếp Tục";
                // Set Pause
                lock (pauseLock)
                {
                    isPause = true;
                }
            }
            else
            {
                checkButtonTamDung.Image = Properties.Resources.pause_16;
                checkButtonTamDung.Text = "Tạm Dừng";
                // Set Pause
                lock (pauseLock)
                {
                    isPause = false;
                }
            }
        }

        private void simpleButtonBatDau_Click(object sender, EventArgs e)
        {
            readyToWrite.Set();
            a = new Thread((() =>
            {
                ChangeHeight();
            }));
            a.IsBackground = true;
            a.Start();
            b = new Thread(() =>
            {
                DrawImage(pictureBox1);
            });
            b.Start();
            b.IsBackground = true;
        }

        private void simpleButtonDatLai_Click(object sender, EventArgs e)
        {
            a.Abort();
            b.Abort();
            _mDem.Read(path);
            pictureBox1.Image = bitmapInit;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (check == 1)
            {
                selected[opted - 1].Picture.Location = new Point(Control.MousePosition.X - pictureBox1.Location.X - 20, Control.MousePosition.Y - pictureBox1.Location.Y - 20);

                selected[opted - 1].Picture.Visible = true;
                check = 0;
                this.Cursor = Cursors.Default;
            }
        }

        private void item1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (System.IO.File.Exists(dialog.FileName))
                {
                    path = dialog.FileName;
                    _mDem = new DemDocument();
                    _mDem.Read(dialog.FileName);
                    txtOutput.Text = string.Empty;
                    txtOutput.Text += "DEM Name: " + new string(_mDem.ARecord.file_name) + Environment.NewLine;
                    txtOutput.Text += "SE Coord: " + new string(_mDem.ARecord.SE_geographic_corner_S) + ", " +
                                      new string(_mDem.ARecord.SE_geographic_corner_E) + Environment.NewLine;
                    txtOutput.Text += "DEM Level Code: " + _mDem.ARecord.dem_level_code + Environment.NewLine;
                    txtOutput.Text += "Ground Reference System: " +
                                      (GROUND_REF_SYSTEM)_mDem.ARecord.ground_ref_system + Environment.NewLine;
                    txtOutput.Text += "Ground Reference Zone: " + _mDem.ARecord.ground_ref_zone + Environment.NewLine;
                    txtOutput.Text += "Ground Unit: " + (GROUND_UNIT)_mDem.ARecord.ground_unit + Environment.NewLine;
                    txtOutput.Text += "Elevation Unit: " + (ELEVATION_UNIT)_mDem.ARecord.elevation_unit +
                                      Environment.NewLine;
                    txtOutput.Text += "Ground Resolution (lat, lng, elev): " + _mDem.ARecord.xyz_resolution[0] + ", " +
                                      _mDem.ARecord.xyz_resolution[1] + ", " + _mDem.ARecord.xyz_resolution[2] +
                                      Environment.NewLine;
                    txtOutput.Text += "Elavation Array Szie: " + _mDem.ARecord.northings_rows + " x " +
                                      _mDem.ARecord.eastings_cols + Environment.NewLine;
                    txtOutput.Text += "Percentage void: " + _mDem.ARecord.percent_void + Environment.NewLine;
                    txtOutput.Text += "SW Coord: " + _mDem.ARecord.sw_coord[0] + ", " + _mDem.ARecord.sw_coord[1] +
                                      Environment.NewLine;
                    txtOutput.Text += "NW Coord: " + _mDem.ARecord.nw_coord[0] + ", " + _mDem.ARecord.nw_coord[1] +
                                      Environment.NewLine;
                    txtOutput.Text += "NE Coord: " + _mDem.ARecord.ne_coord[0] + ", " + _mDem.ARecord.ne_coord[1] +
                                      Environment.NewLine;
                    txtOutput.Text += "SE Coord: " + _mDem.ARecord.se_coord[0] + ", " + _mDem.ARecord.se_coord[1] +
                                      Environment.NewLine;

                }
            }
        }

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            //if (e.Node.ImageIndex >= e.Node.TreeView.ImageList.Images.Count) // if there is no image 
            //{
            //    int imagewidths = e.Node.TreeView.ImageList.ImageSize.Width;
            //    int textheight = TextRenderer.MeasureText(e.Node.Text, e.Node.NodeFont).Height;
            //    int x = e.Node.Bounds.Left - 3 - imagewidths / 2;
            //    int y = (e.Bounds.Top + e.Bounds.Bottom) / 2 + 1;

            //    Point point = new Point(x - imagewidths / 2, y - textheight / 2); // the new location for the text to be drawn 

            //    TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.NodeFont, point, e.Node.ForeColor.);
            //}
            //else // drawn at the default location 
            //    TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.TreeView.Font, e.Bounds, default);
        }
    }
}
