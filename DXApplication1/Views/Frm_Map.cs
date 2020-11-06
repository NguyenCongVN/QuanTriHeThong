using Braincase.USGS.DEM;
using DevExpress.Utils.Extensions;
using DXApplication1.Models;
using DXApplication1.Objects_Icon;
using DXApplication1.Utilizes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using Cursors = System.Windows.Forms.Cursors;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace DXApplication1.Views
{
    public partial class Frm_test1 : DevExpress.XtraEditors.XtraForm
    {
        Dictionary<string, string> ListdiachiAnh = new Dictionary<string, string>();

        // Ke Hoach
        public KeHoach KeHoach { get; set; }


        int panelWidth;
        int panelWidthFile;
        bool hided;
        bool hidedFile;


        private bool pictureBoxDoiTuongIsMoved = false;

        /// Thread to change height
        public Thread a;
        // Thread to draw 
        public Thread b;
        // Map value to proportion
        public float MapValueToProportion(int value)
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
        public string path;
        // Speed of virtualization
        // Default
        public const short speedInit = 5;
        // Temporary speed
        public static short speed = speedInit;
        //
        // Lock object for virtualization's speed
        public static object speedLock = new object();

        // Pause
        public static bool isPause = false;
        // Pause Lock
        public static object pauseLock = new object();
        //E:\PICTURE\
        public static Bitmap bitmapInit1 = new Bitmap(Properties.Resources.Screenshot_2020_09_25_202017);

        // Resize bitmap background
        public Bitmap bitmapInit = new Bitmap(bitmapInit1, 1201, 1201);


        // Bitmap Temp to be used in virtualization
        Bitmap bitmapTemp = new Bitmap(bitmapInit1, 1201, 1201);

        // Bitmap to be used in resize mode
        public Bitmap bitmapResize = new Bitmap(bitmapInit1, 1201, 1201);

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
        public int opted = 0;

        PictureBox p1;
        List<DoiTuong> listPic = new List<DoiTuong>();
        List<DoiTuong> selected = new List<DoiTuong>();
        Image[] images;
        public List<DoiTuong> listAdd = new List<DoiTuong>();
        public List<DoiTuong> listUpdate = new List<DoiTuong>();
        public List<DoiTuong> listRemove = new List<DoiTuong>();
        NodeOnMap nodeOnMap;

        public Frm_test1()
        {
            
            InitializeComponent();
            buttonKyHieuQuanSu_Click(null, null);
            buttonAnHienChiTietFile_Click_1(null, null);
            pictureBoxMap.Image = bitmapResize;
            panelWidth = panelNode.Width;
            panelWidthFile = txtOutput.Width;
            hided = true;
            hidedFile = true;
            this.pictureBoxMap.MouseWheel += PictureBoxMap_MouseWheel;

        }

        // Center PictureBox is being tested
        private void CenterPictureBox(PictureBox picBox, Bitmap picImage)
        {
            picBox.Image = picImage;
            picBox.Location = new Point((picBox.Parent.ClientSize.Width / 2) - (picImage.Width / 2),
                                        (picBox.Parent.ClientSize.Height / 2) - (picImage.Height / 2));
        }

        private void PictureBoxMap_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl) == true)
            {
                if (e.Delta > 20)
                {
                    widthResize = widthResize + 50;
                    heightResize = heightResize + 50;
                }
                else
                {
                    widthResize = widthResize - 50;
                    heightResize = heightResize - 50;
                }
                Size CurrentSize = pictureBoxMap.Image.Size;
                Point currentPoint = pictureBoxMap.PointToClient(Control.MousePosition);
                var bitmap = new Bitmap(bitmapResize, pictureBoxMap.Width + widthResize,
                    pictureBoxMap.Height + heightResize);
                pictureBoxMap.Image = bitmap;
                if (opted != 0)
                {
                    for (int i = 0; i < opted; i++)
                    {
                        selected[i].Picture.Location =
                            DrawHelper.ScaleImage(new Point(selected[i].ThongTinChiTietDoiTuong.ToaDoX, selected[i].ThongTinChiTietDoiTuong.ToaDoY),
                            new Size(selected[i].ThongTinChiTietDoiTuong.ChieuRongAnh, selected[i].ThongTinChiTietDoiTuong.ChieuDaiAnh), pictureBoxMap);
                    }
                }
                pictureBoxMap.Refresh();
                Point newPoint = DrawHelper.ScaleImage(currentPoint, CurrentSize, pictureBoxMap);
                DrawHelper.ScrollToMouseInPictureBox(this.panelMap, newPoint, pictureBoxMap);
                Point currentPoint1 = pictureBoxMap.PointToClient(Control.MousePosition);
                widthResize = 0;
                heightResize = 0;
            }
        }

        public void initImageOfNode()
        {
            imageListChild = new ImageList();
            ListdiachiAnh = new Dictionary<string, string>();
            nodeOnMap = new NodeOnMap();
            DataSet PicSet = nodeOnMap.getIconChild();
            string diachiAnh;
            foreach (DataRow dr in PicSet.Tables[0].Rows)
            {
                string fileName = Path.GetFileName(dr["DuongDanAnh"].ToString());
                if (fileName == dr["DuongDanAnh"].ToString())
                {
                    diachiAnh = Environment.CurrentDirectory.ToString() + @"\..\..\Resources\" + dr["DuongDanAnh"].ToString();
                    imageListChild.Images.Add(dr["MaDonVi"].ToString(), Image.FromFile(diachiAnh));
                    ListdiachiAnh.Add(dr["MaDonVi"].ToString(), diachiAnh);
                }
                else
                {
                    diachiAnh = dr["DuongDanAnh"].ToString();
                    imageListChild.Images.Add(dr["MaDonVi"].ToString(), Image.FromFile(diachiAnh));
                    ListdiachiAnh.Add(dr["MaDonVi"].ToString(), diachiAnh);

                }
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
                            selected[i].ThongTinChiTietDoiTuong.ToaDoX = pic.Location.X;
                            selected[i].ThongTinChiTietDoiTuong.ToaDoY = pic.Location.Y;
                            selected[i].ThongTinChiTietDoiTuong.ChieuDaiAnh = pictureBoxMap.Size.Height;
                            selected[i].ThongTinChiTietDoiTuong.ChieuRongAnh = pictureBoxMap.Size.Width;
                            var list = listUpdate.FindAll(c => c.ThongTinChiTietDoiTuong.MaDoiTuong == selected[i].ThongTinChiTietDoiTuong.MaDoiTuong);
                            if (list.Count != 0)
                            {
                                foreach (var doiTuong in list)
                                {
                                    listUpdate.Remove(doiTuong);
                                }
                                listUpdate.Add(selected[i]);
                            }
                            else
                            {
                                listUpdate.Add(selected[i]);
                            }
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
                int dem = chSet.Tables[0].Rows.Count;
                foreach (DataRow drch in chSet.Tables[0].Rows)
                {
                    int index = imageListChild.Images.IndexOfKey(drch["MaDonVi"].ToString());
                    if (index >= 0)
                    {
                        TreeNode treeNode1 = new TreeNode();
                        treeNode1.SelectedImageIndex = index;
                        treeNode1.ImageIndex = index;
                        treeNode1.Name = drch["MaDonVi"].ToString();
                        treeNode1.Text = drch["TenDonVi"].ToString();
                        treeNode1.ContextMenuStrip = controlChildNode;
                        treeView1.Nodes[i].Nodes.Add(treeNode1);
                    }
                    else
                    {
                        continue;
                    }
                }
                i++;

            }
        }

        public void Frm_test1_Load(object sender, EventArgs e)
        {
            initImageOfNode();
            load_Tree();
           
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            for (int i = 0; i < imageListChild.Images.Count; i++)
            {
                if (e.Node.ImageIndex == i)
                {
                    DoiTuong doiTuong = new DoiTuong();
                    doiTuong.ThongTinChiTietDoiTuong.MaDonVi = e.Node.Name;
                    doiTuong.ThongTinChiTietDoiTuong.MaKeHoach = Program.frm_Map.KeHoach.MaKeHoach;
                    doiTuong.ThongTinChiTietDoiTuong.ChieuDoc = 10;
                    doiTuong.ThongTinChiTietDoiTuong.ChieuNgang = 10;
                    doiTuong.InitImage = imageListChild.Images[i];
                    doiTuong.Picture.Image = new Bitmap(doiTuong.InitImage, doiTuong.ThongTinChiTietDoiTuong.ChieuNgang,
                     doiTuong.ThongTinChiTietDoiTuong.ChieuDoc);
                    doiTuong.Picture.Visible = false;
                    doiTuong.Picture.Location = new Point(10, 10);
                    selected.Add(doiTuong);
                    pictureBoxMap.AddControl(doiTuong.Picture);
                    MoveButton(doiTuong.Picture);
                    check = 1;
                    this.Cursor = Cursors.NoMove2D;
                    deletePic(doiTuong.Picture);
                    opted++;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                treeView1.SelectedNode = e.Node;
                if (e.Node.Parent != null && e.Node.Parent.GetType() == typeof(TreeNode))
                {
                    //Program.getMa = e.Node.Name;
                    // la node con
                    Program.donVi.madonvi = e.Node.Name;
                    Program.donVi.mabinhchung = e.Node.Parent.Name;
                    int index = imageListChild.Images.IndexOfKey(e.Node.Name);
                    Program.donVi.duongdananh = ListdiachiAnh[e.Node.Name];
                    Program.donVi.tendonvi = e.Node.Text;
                }  
                else // node cha
                {
                    Program.binhChung.mabinhchung = e.Node.Name;
                    Program.binhChung.tenbinhchung = e.Node.Text;
                }
            }    
                


        }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                //selected[opted - 1].Picture.Location = new Point(10, 10);
                Point point = new Point(Control.MousePosition.X, Control.MousePosition.Y);
                point = pictureBoxMap.PointToClient(point);
                selected[opted - 1].Picture.Location = point;
                selected[opted - 1].ThongTinChiTietDoiTuong.ToaDoX = selected[opted - 1].Picture.Location.X;
                selected[opted - 1].ThongTinChiTietDoiTuong.ToaDoY = selected[opted - 1].Picture.Location.Y;
                selected[opted - 1].ThongTinChiTietDoiTuong.ChieuRongAnh = pictureBoxMap.Size.Width;
                selected[opted - 1].ThongTinChiTietDoiTuong.ChieuDaiAnh = pictureBoxMap.Size.Height;
                selected[opted - 1].Picture.Visible = true;
                if (this.KeHoach != null)
                {
                    this.listAdd.Add(selected[opted - 1]);
                }
                check = 0;
                this.Cursor = Cursors.Default;
            }
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

        public void simpleButtonLuuPhuongAn_Click(object sender, EventArgs e)
        {
            BooleanAndDoiTuongClass check = new BooleanAndDoiTuongClass() { BoolVar = false };
            IntClass count = new IntClass() { IntVar = opted };
            QuanLyPhuongAnForm taoKeHoachMoi = new QuanLyPhuongAnForm(selected, count, treeView1, imageListChild, check);
            taoKeHoachMoi.ShowDialog();
            if (check.BoolVar)
            {
                opted = count.IntVar;
                selected = check.DoiTuongs;
                this.pictureBoxMap.Controls.Clear();
                for (int i = 0; i < opted; i++)
                {
                    selected[i].Picture.Visible = true;
                    selected[i].Picture.Location =
                            DrawHelper.ScaleImage(new Point(selected[i].ThongTinChiTietDoiTuong.ToaDoX, selected[i].ThongTinChiTietDoiTuong.ToaDoY)
                            , new Size(selected[i].ThongTinChiTietDoiTuong.ChieuRongAnh, selected[i].ThongTinChiTietDoiTuong.ChieuDaiAnh), pictureBoxMap);
                    pictureBoxMap.AddControl(selected[i].Picture);
                    MoveButton(selected[i].Picture);
                    deletePic(selected[i].Picture);
                }
            }
        }

        #region  quanlytreeview

        private void doiTentoolStripMenuItemChild_Click(object sender, EventArgs e)
        {
            Program.flag = false;
            Icon_DoiTuong icon = new Icon_DoiTuong();
            icon.LoadDataDonVi(Program.donVi);
            icon.ShowDialog();
        }
        private void xoatoolStripMenuItemChild_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
            Program.nodeOnMap.XoaDonVi(Program.donVi.madonvi);

        }
        private void thêmKíHiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.flag = true;
            Icon_DoiTuong icon = new Icon_DoiTuong();
            icon.HienMaBinhChung(Program.binhChung.mabinhchung);
            icon.ShowDialog();
            
        }
        private void đoiTenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.flag = false;
            LoaiDoiTuong loaiDoiTuong = new LoaiDoiTuong();
            loaiDoiTuong.HienThiThongTinBinhChung(Program.binhChung);
            loaiDoiTuong.ShowDialog();
        }
        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
            Program.nodeOnMap.XoaBinhChung(Program.binhChung.mabinhchung);
        }
        private void themtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.flag = true;
            LoaiDoiTuong loaiDoiTuong = new LoaiDoiTuong();
            loaiDoiTuong.ShowDialog();
        }
        #endregion
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            

        }

        private void buttonAnHien_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Tahoma", 8);
            Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("Ký hiệu quân sự", font, brush, 0, 0);
        }

        private void buttonAnHienChiTietFile_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Tahoma", 8);
            Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("Chi tiết File", font, brush, 0, 0);
        }

        private void buttonAnHienChiTietFile_Click_1(object sender, EventArgs e)
        {
            timerAnHienFile.Start();
        }

        private void buttonKyHieuQuanSu_Click(object sender, EventArgs e)
        {
            timerAnHien.Start();
        }

        
    }
}