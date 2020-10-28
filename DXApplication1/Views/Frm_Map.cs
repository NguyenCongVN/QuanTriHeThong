using Braincase.USGS.DEM;
using DevExpress.Utils.Extensions;
using DXApplication1.Models;
using DXApplication1.Utilizes;
using DXApplication1.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using Cursors = System.Windows.Forms.Cursors;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;
using DXApplication1.Objects_Icon;
using System.IO;
using System.Text;

namespace DXApplication1.Views
{
    public partial class Frm_test1 : DevExpress.XtraEditors.XtraForm
    {
        int panelWidth;
        int panelWidthFile;
        bool hided;
        bool hidedFile;


        private bool pictureBoxDoiTuongIsMoved = false;

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

        // Resize bitmap background
        Bitmap bitmapInit = new Bitmap(bitmapInit1, 1201, 1201);


        // Bitmap Temp to be used in virtualization
        Bitmap bitmapTemp = new Bitmap(bitmapInit1, 1201, 1201);

        // Bitmap to be used in resize mode
        Bitmap bitmapResize = new Bitmap(bitmapInit1, 1201, 1201);

        // Resize information
        private int widthResize = 0;

        private int heightResize = 0;
        //

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
           // initImageOfNode();
            pictureBoxMap.Image = bitmapResize;
            panelWidth = panelNode.Width;
            panelWidthFile = txtOutput.Width;
            hided = false;
            hidedFile = false;
            this.pictureBoxMap.MouseWheel += PictureBoxMap_MouseWheel;
        }

        private void PictureBoxMap_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Keyboard.GetKeyStates(Key.LeftCtrl) == KeyStates.Down)
            {
                if (e.Delta > 0)
                {
                    widthResize = widthResize + 50;
                    heightResize = heightResize + 50;
                }
                else
                {
                    widthResize = widthResize - 50;
                    heightResize = heightResize - 50;
                }
                var bitmap = new Bitmap(bitmapResize, pictureBoxMap.Width + widthResize,
                    pictureBoxMap.Height + heightResize);
                pictureBoxMap.Image = bitmap;
                if (opted != 0)
                {
                    for (int i = 0; i < opted; i++)
                    {
                        selected[i].Picture.Location =
                            DrawHelper.ScaleImage(selected[i].LocationInImage, selected[i].initSizePicture, pictureBoxMap);
                    }
                }
                pictureBoxMap.Refresh();
                widthResize = 0;
                heightResize = 0;
            }
        }

        public void initImageOfNode()
        {
            nodeOnMap = new NodeOnMap();
            DataSet PicSet = nodeOnMap.getIconChild();
            foreach (DataRow dr in PicSet.Tables[0].Rows)
            {
                string fileName = Path.GetFileName(dr["DuongDanAnh"].ToString());
                if (fileName == dr["DuongDanAnh"].ToString())
                {
                    imageListChild.Images.Add(dr["MaDonVi"].ToString(), Image.FromFile(Environment.CurrentDirectory.ToString() + @"\..\..\Resources\" + dr["DuongDanAnh"].ToString()));
                }
                else
                {
                    imageListChild.Images.Add(dr["MaDonVi"].ToString(), Image.FromFile(dr["DuongDanAnh"].ToString()));
                }
              //  imageListChild.Images.Add(dr["MaDonVi"].ToString(), Image.FromFile(Environment.CurrentDirectory.ToString() + @"\..\..\Resources\" + dr["DuongDanAnh"].ToString()));
                // string filename = Environment.CurrentDirectory.ToString() + @"\..\..\Resources\" + dr["DuongDanAnh"].ToString();
                //// if (Image.FromFile(filename).Width > 0)
                //  //   imageListChild.Images.Add(dr["MaDonVi"].ToString(), Image.FromFile(Environment.CurrentDirectory.ToString() + @"\..\..\Resources\" + dr["DuongDanAnh"].ToString()));
                // //else
                //     imageListChild.Images.Add(dr["MaDonVi"].ToString(), Image.FromFile(dr["DuongDanAnh"].ToString()));

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
                    pp.LocationChanged += pp_LocationChanged;
                    pp.Location = new Point(pp.Location.X - res.X, pp.Location.Y - res.Y);
                    firstPoint = temp;
                    pictureBoxDoiTuongIsMoved = true;
                }
            };
        }

        private void pp_LocationChanged(object sender, EventArgs e)
        {
            if (pictureBoxDoiTuongIsMoved)
            {
                PictureBox pic = sender as PictureBox;
                if (pic != null)
                    for (int i = 0; i < opted; i++)
                    {
                        if (selected[i].Picture == pic)
                        {
                            selected[i].LocationInImage = pic.Location;
                            selected[i].initSizePicture = pictureBoxMap.Size;
                        }
                    }
                pictureBoxDoiTuongIsMoved = false;
            }
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
            //DataSet PicSet = nodeOnMap.getIconChild();
            ParentNode parentNode = new ParentNode();
            //foreach (DataRow dr in PicSet.Tables[0].Rows)
            //{
            //    imageListChild.Images.Add(dr["MaDonVi"].ToString(), Image.FromFile(Environment.CurrentDirectory.ToString() + @"\..\..\Resources\" + dr["DuongDanAnh"].ToString()));
            //}
            int count = imageListChild.Images.Count;
            treeView1.ImageList = imageListChild;
            nodeOnMap = new NodeOnMap();
            DataSet PrSet = nodeOnMap.getDataParentNode();
            treeView1.Nodes.Clear();
            int i = 0;
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Name = dr["MaBinhChung"].ToString();
                treeNode.SelectedImageIndex = count + 2; // không hien anh
                treeNode.ImageIndex = count + 1; // khong hien anh
                treeNode.Text = dr["TenBinhChung"].ToString();
                treeNode.ContextMenuStrip = controlParentNode;
                treeView1.Nodes.Add(treeNode);
                DataSet chSet = Program.nodeOnMap.getDataChildNode(dr["MaBinhChung"].ToString());
                foreach (DataRow drch in chSet.Tables[0].Rows)
                {
                    int index = imageListChild.Images.IndexOfKey(drch["MaDonVi"].ToString());
                    TreeNode treeNode1 = new TreeNode();
                    treeNode1.SelectedImageIndex = index;
                    treeNode1.ImageIndex = index;
                  //  treeNode1.ImageKey = drch["MaDonVi"].ToString();
                    treeNode1.Text = drch["TenDonVi"].ToString();
                    treeNode1.ContextMenuStrip = controlChildNode;
                    treeView1.Nodes[i].Nodes.Add(treeNode1);
                }
                i++;
            }
        }



        public void Frm_test1_Load(object sender, EventArgs e)
        {
            initImageOfNode();
            load_Tree();
            
        }

        string getMaBinhChung;
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            for (int i = 0; i < imageListChild.Images.Count; i++)
            {
                if (e.Node.ImageIndex == i)
                {
                    selected[opted] = new DoiTuong();
                    selected[opted].Picture.Image = imageListChild.Images[i];
                    selected[opted].Detail = e.Node.Text;

                    selected[opted].Picture.Visible = false;
                    selected[opted].Picture.Location = new Point(10, 10);
                    pictureBoxMap.AddControl(selected[opted].Picture);
                    MoveButton(selected[opted].Picture);
                    check = 1;
                    this.Cursor = Cursors.NoMove2D;
                    deletePic(selected[opted].Picture);
                    opted++;
                }
            }

            if (e.Button == MouseButtons.Right)
                Program.getMa = e.Node.Name;


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
                        bitmapTemp = new Bitmap(bitmapInit1, 1201, 1201);

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
                                        bitmapTemp.SetPixel(row, col, DrawHelper.GetGreenYellowRedByPropotion(height - min, max - min));
                                        // Or this, as suggested by thanaphan4 for fixing bitmap x/y orientation
                                        //bitmap.SetPixel(col, _mDem.ARecord.northings_rows - row - 1, Color.FromArgb(128, 128, ratio));
                                    }
                                    else
                                    {
                                        bitmapTemp.SetPixel(row, col, DrawHelper.GetGreenYellowRedByPropotion(0, max - min));
                                        //bitmap.SetPixel(col, _mDem.ARecord.northings_rows - row - 1, Color.FromArgb(128, 128, 0));
                                    }
                            }
                        }
                        bitmapResize = new Bitmap(bitmapTemp, pictureBoxMap.Width + widthResize,
                            pictureBoxMap.Height + heightResize);

                        _mPictureBox.Invoke((MethodInvoker)delegate
                       {
                           // Running on the UI thread
                           _mPictureBox.Image = bitmapResize;
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
                DrawImage(pictureBoxMap);
            });
            b.Start();
            b.IsBackground = true;
        }

        private void simpleButtonDatLai_Click(object sender, EventArgs e)
        {
            a.Abort();
            b.Abort();
            _mDem.Read(path);
            pictureBoxMap.Image = bitmapInit;
            bitmapResize = new Bitmap(bitmapInit1, 1201, 1201);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                //selected[opted - 1].Picture.Location = new Point(10, 10);
                selected[opted - 1].Picture.Location = new Point(Control.MousePosition.X - 240, Control.MousePosition.Y - 270);
                selected[opted - 1].LocationInImage = selected[opted - 1].Picture.Location;
                selected[opted - 1].initSizePicture = pictureBoxMap.Size;
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

        private void buttonAnHien_Click(object sender, EventArgs e)
        {
            if (hided)
                buttonAnHien.Text = "H\ni\nd\ne";
            else
                buttonAnHien.Text = "S\nh\no\nw";
            timerAnHien.Start();
        }

        private void timerAnHien_Tick(object sender, EventArgs e)
        {
            if (hided) // true là an
            {
                panelNode.Width = panelNode.Width + 20;
                panelMap.Width = panelMap.Width - 20;
                if (panelNode.Width >= panelWidth)
                {
                    timerAnHien.Stop();
                    hided = false;
                    //    panelMap.Width = panelMap.Width + 20;
                    this.Refresh();
                }
            }
            else // hien 
            {
                panelNode.Width = panelNode.Width - 20;
                panelMap.Width = panelMap.Width + 20;
                if (panelNode.Width <= 0)
                {
                    timerAnHien.Stop();
                    hided = true;
                    //    panelMap.Width = panelMap.Width + 20;
                    this.Refresh();
                }
            }
        }
        private void buttonAnHienChiTietFile_Click(object sender, EventArgs e)
        {
            if (hidedFile)
                buttonAnHienChiTietFile.Text = "H\ni\nd\ne";
            else
                buttonAnHienChiTietFile.Text = "S\nh\no\nw";
            timerAnHienFile.Start();
        }

        private void timerAnHienFile_Tick(object sender, EventArgs e)
        {
            if (hidedFile)
            {
                txtOutput.Width = txtOutput.Width + 20;
                //  panelMap.Left = panelMap.Left-20;
                //panelMap.Width = panelMap.Width - 20;
                if (txtOutput.Width >= panelWidthFile)
                {
                    timerAnHienFile.Stop();
                    hidedFile = false;
                    this.Refresh();
                }
            }
            else
            {
                txtOutput.Width = txtOutput.Width - 20;
                // panelMap.RightToLeft = 9;// panelMap.Left + 20;
                if (txtOutput.Width <= 0)
                {
                    timerAnHienFile.Stop();
                    hidedFile = true;

                    this.Refresh();
                }
            }
        }

        private void doiTentoolStripMenuItemChild_Click(object sender, EventArgs e)
        {
            Program.flag = false;
            Icon_DoiTuong icon = new Icon_DoiTuong();
            icon.ShowDialog();
        }

        private void xoatoolStripMenuItemChild_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
            Program.nodeOnMap.XoaDonVi(Program.getMa);

        }

        private void đoiTenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.flag = false;
            LoaiDoiTuong loaiDoiTuong = new LoaiDoiTuong();
            loaiDoiTuong.ShowDialog();
        }

        private void thêmKíHiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.flag = true;
            Icon_DoiTuong icon = new Icon_DoiTuong();
            icon.ShowDialog();
        }

        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
            Program.nodeOnMap.XoaBinhChung(Program.getMa);
        }

        private void themtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.flag = true;
            LoaiDoiTuong loaiDoiTuong = new LoaiDoiTuong();
            loaiDoiTuong.ShowDialog();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
    }
}
