using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using Braincase.USGS.DEM;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DXApplication1.Models;
using DXApplication1.Objects_Icon;
using DXApplication1.Properties;
using DXApplication1.Utilizes;
using Cursors = System.Windows.Forms.Cursors;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace DXApplication1.Views
{
    public partial class Frm_test1 : XtraForm
    {
        // Speed of virtualization
        // Default
        public const short speedInit = 5;

        // Temporary speed
        public static short speed = speedInit;

        //
        // Lock object for virtualization's speed
        public static object speedLock = new object();

        // Pause
        public static bool isPause;

        // Pause Lock
        public static object pauseLock = new object();

        public static Bitmap bitmapInit1 = new Bitmap(Resources.Screenshot_2020_09_25_202017);
        //

        //
        public static DemDocument _mDem;

        // object to lock _mDem file

        private static readonly object DemLock = new object();

        // Ready to read file

        public static EventWaitHandle readyToRead = new AutoResetEvent(false);

        // Ready to write file

        public static EventWaitHandle readyToWrite = new AutoResetEvent(true);

        /// <summary>
        /// </summary>
        /// Thread to change height
        public Thread a;

        // Thread to draw 
        public Thread b;

        // Resize bitmap background
        public Bitmap bitmapInit = new Bitmap(bitmapInit1, 1201, 1201);

        // Bitmap to be used in resize mode
        public Bitmap bitmapResize = new Bitmap(bitmapInit1, 1201, 1201);


        // Bitmap Temp to be used in virtualization
        public Bitmap bitmapTemp = new Bitmap(bitmapInit1, 1201, 1201);

        private int check;

        private Point firstPoint;

        private int heightResize;
        private bool hided;
        private bool hidedFile;
        private bool hidedMP;
        private Image[] images;
        public List<DoiTuong> listAdd = new List<DoiTuong>();
        private Dictionary<string, string> ListdiachiAnh = new Dictionary<string, string>();
        private List<DoiTuong> listPic = new List<DoiTuong>();
        public List<DoiTuong> listRemove = new List<DoiTuong>();
        public List<DoiTuong> listUpdate = new List<DoiTuong>();
        private NodeOnMap nodeOnMap;
        public int opted;

        private PictureBox p1;


        private readonly int panelWidth;
        private readonly int panelWidthFile;

        private readonly int panelWidthMP;

        // Current path
        public string path;


        private bool pictureBoxDoiTuongIsMoved;
        private List<DoiTuong> selected = new List<DoiTuong>();

        // Resize information
        private int widthResize;


        public Frm_test1()
        {
            InitializeComponent();
            buttonKyHieuQuanSu_Click(null, null);
            buttonAnHienChiTietFile_Click_1(null, null);
            pictureBoxMap.Image = bitmapResize;
            panelWidth = panelNode.Width;
            panelWidthMP = panelMP.Width;
            panelWidthFile = txtOutput.Width;
            hided = true;
            hidedFile = true;
            pictureBoxMap.MouseWheel += PictureBoxMap_MouseWheel;
            pictureBoxMap.Margin = new Padding(0);
        }

        // Ke Hoach
        public KeHoach KeHoach { get; set; }

        // Map value to proportion
        public float MapValueToProportion(int value)
        {
            switch (value)
            {
                case 1: return (float) 0.2;
                case 2: return (float) 0.5;
                case 3: return (float) 0.8;
                case 4: return 1;
                case 5: return 2;
                case 6: return 5;
                case 7: return 8;
                default: return 1;
            }
        }

        // Center PictureBox
        private void CenterPictureBox(PictureBox picBox, Bitmap picImage)
        {
            picBox.Image = picImage;
            picBox.Location = new Point(picBox.Parent.ClientSize.Width / 2 - picImage.Width / 2,
                picBox.Parent.ClientSize.Height / 2 - picImage.Height / 2);
        }

        private void PictureBoxMap_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl))
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

                var CurrentSize = pictureBoxMap.Image.Size;
                var currentPoint = pictureBoxMap.PointToClient(MousePosition);
                var bitmap = new Bitmap(bitmapResize, pictureBoxMap.Width + widthResize,
                    pictureBoxMap.Height + heightResize);
                pictureBoxMap.Image = bitmap;
                if (opted != 0)
                    for (var i = 0; i < opted; i++)
                        selected[i].Picture.Location =
                            DrawHelper.ScaleImage(
                                new Point(selected[i].ThongTinChiTietDoiTuong.ToaDoX,
                                    selected[i].ThongTinChiTietDoiTuong.ToaDoY),
                                new Size(selected[i].ThongTinChiTietDoiTuong.ChieuRongAnh,
                                    selected[i].ThongTinChiTietDoiTuong.ChieuDaiAnh), pictureBoxMap);
                pictureBoxMap.Refresh();
                var newPoint = DrawHelper.ScaleImage(currentPoint, CurrentSize, pictureBoxMap);
                panelMap.ScrollToMouseInPictureBox(newPoint, pictureBoxMap);
                var currentPoint1 = pictureBoxMap.PointToClient(MousePosition);
                widthResize = 0;
                heightResize = 0;
            }
        }

        public void initImageOfNode()
        {
            imageListChild = new ImageList();
            ListdiachiAnh = new Dictionary<string, string>();
            nodeOnMap = new NodeOnMap();
            var PicSet = nodeOnMap.getIconChild();
            string diachiAnh;
            foreach (DataRow dr in PicSet.Tables[0].Rows)
            {
                var fileName = Path.GetFileName(dr["DuongDanAnh"].ToString());
                if (fileName == dr["DuongDanAnh"].ToString())
                {
                    diachiAnh = Environment.CurrentDirectory + @"\..\..\Resources\" + dr["DuongDanAnh"];
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

        public void MoveButton(PictureBox pp)
        {
            pp.MouseDown += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left) firstPoint = MousePosition;
            };
            pp.MouseMove += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left)
                {
                    var temp = MousePosition;
                    var res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);
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
                var pic = sender as PictureBox;
                if (pic != null)
                    for (var i = 0; i < opted; i++)
                        if (selected[i].Picture == pic)
                        {
                            selected[i].ThongTinChiTietDoiTuong.ToaDoX = pic.Location.X;
                            selected[i].ThongTinChiTietDoiTuong.ToaDoY = pic.Location.Y;
                            selected[i].ThongTinChiTietDoiTuong.ChieuDaiAnh = pictureBoxMap.Size.Height;
                            selected[i].ThongTinChiTietDoiTuong.ChieuRongAnh = pictureBoxMap.Size.Width;
                            var list = listUpdate.FindAll(c =>
                                c.ThongTinChiTietDoiTuong.MaDoiTuong == selected[i].ThongTinChiTietDoiTuong.MaDoiTuong);
                            if (list.Count != 0)
                            {
                                foreach (var doiTuong in list) listUpdate.Remove(doiTuong);
                                listUpdate.Add(selected[i]);
                            }
                            else
                            {
                                listUpdate.Add(selected[i]);
                            }
                        }

                pictureBoxDoiTuongIsMoved = false;
            }
        }

        public void deletePic(PictureBox pic)
        {
            pic.Click += (ss, ee) =>
            {
                if (ModifierKeys == Keys.Delete) MessageBox.Show("delete");
            };
        }

        public void load_Tree()
        {
            nodeOnMap = new NodeOnMap();
            var count = imageListChild.Images.Count;
            treeView1.ImageList = imageListChild;
            nodeOnMap = new NodeOnMap();
            var PrSet = nodeOnMap.getDataParentNode();
            treeView1.Nodes.Clear();
            var i = 0;
            foreach (DataRow dr in PrSet.Tables[0].Rows)
            {
                var treeNode = new TreeNode();
                treeNode.Name = dr["MaBinhChung"].ToString();
                treeNode.SelectedImageIndex = count + 2; // không hien anh
                treeNode.ImageIndex = count + 1; // khong hien anh
                treeNode.Text = dr["TenBinhChung"].ToString();
                treeNode.ContextMenuStrip = controlParentNode;
                treeView1.Nodes.Add(treeNode);
                var chSet = Program.nodeOnMap.getDataChildNode(dr["MaBinhChung"].ToString());
                var dem = chSet.Tables[0].Rows.Count;
                foreach (DataRow drch in chSet.Tables[0].Rows)
                {
                    var index = imageListChild.Images.IndexOfKey(drch["MaDonVi"].ToString());
                    if (index >= 0)
                    {
                        var treeNode1 = new TreeNode();
                        treeNode1.SelectedImageIndex = index;
                        treeNode1.ImageIndex = index;
                        treeNode1.Name = drch["MaDonVi"].ToString();
                        treeNode1.Text = drch["TenDonVi"].ToString();
                        treeNode1.ContextMenuStrip = controlChildNode;
                        treeView1.Nodes[i].Nodes.Add(treeNode1);
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
            for (var i = 0; i < imageListChild.Images.Count; i++)
                if (e.Node.ImageIndex == i)
                {
                    var doiTuong = new DoiTuong();
                    doiTuong.ThongTinChiTietDoiTuong.MaDonVi = e.Node.Name;
                    if (Program.frm_Map.KeHoach != null)
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
                    Cursor = Cursors.NoMove2D;
                    deletePic(doiTuong.Picture);
                    opted++;
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
                    var index = imageListChild.Images.IndexOfKey(e.Node.Name);
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
                    var tryToLockPause = false;
                    Monitor.TryEnter(pauseLock, ref tryToLockPause);
                    if (tryToLockPause)
                        try
                        {
                            if (isPause)
                                Thread.Sleep(5);
                            else
                                break;
                        }
                        finally
                        {
                            Monitor.Exit(pauseLock);
                            Thread.Sleep(5);
                        }
                }

                readyToWrite.WaitOne();
                lock (DemLock)
                {
                    while (true)
                    {
                        var tryToLockSpeed = false;
                        Monitor.TryEnter(speedLock, ref tryToLockSpeed);
                        if (tryToLockSpeed)
                        {
                            for (var col = 0; col < _mDem.ARecord.eastings_cols; col++)
                            for (var row = 0; row < _mDem.ARecord.northings_rows; row++)
                                _mDem.BRecord.elevations[col, row] -= speed;
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
                    var tryToLockPause1 = false;
                    Monitor.TryEnter(pauseLock, ref tryToLockPause1);
                    if (tryToLockPause1)
                        try
                        {
                            if (isPause)
                                Thread.Sleep(5);
                            else
                                break;
                        }
                        finally
                        {
                            Monitor.Exit(pauseLock);
                            Thread.Sleep(5);
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
                        Debug.WriteLine("Size of bitmapInit1 :" + bitmapInit1.Size);
                        Debug.WriteLine("Size of picuteBox before :" + pictureBoxMap.Size);
                        for (var col = 0; col < _mDem.ARecord.eastings_cols; col++)
                        for (var row = 0; row < _mDem.ARecord.northings_rows; row++)
                        {
                            double height = _mDem.BRecord.elevations[col, row] * _mDem.ARecord.xyz_resolution[2];
                            var min = _mDem.ARecord.elevation_min;
                            var max = _mDem.ARecord.elevation_max;
                            if (row % 5 == 0)
                                if (height >= min)
                                    //int ratio = (int)(((height - min) / (max - min)) * 255f);
                                    bitmapTemp.SetPixel(row, col,
                                        DrawHelper.GetGreenYellowRedByPropotion(height - min, max - min));
                                // Or this, as suggested by thanaphan4 for fixing bitmap x/y orientation
                                //bitmap.SetPixel(col, _mDem.ARecord.northings_rows - row - 1, Color.FromArgb(128, 128, ratio));
                                else
                                    bitmapTemp.SetPixel(row, col,
                                        DrawHelper.GetGreenYellowRedByPropotion(0, max - min));
                                //bitmap.SetPixel(col, _mDem.ARecord.northings_rows - row - 1, Color.FromArgb(128, 128, 0));
                        }
                        bitmapResize = new Bitmap(bitmapTemp, pictureBoxMap.Width + widthResize,
                            pictureBoxMap.Height + heightResize);
                        _mPictureBox.Invoke((MethodInvoker) delegate
                        {
                            // Running on the UI thread
                            _mPictureBox.Image = bitmapResize;
                            Debug.WriteLine("Size of picuteBox after invoke :" + pictureBoxMap.Size);
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
                var point = new Point(MousePosition.X, MousePosition.Y);
                point = pictureBoxMap.PointToClient(point);
                selected[opted - 1].Picture.Location = point;
                selected[opted - 1].ThongTinChiTietDoiTuong.ToaDoX = selected[opted - 1].Picture.Location.X;
                selected[opted - 1].ThongTinChiTietDoiTuong.ToaDoY = selected[opted - 1].Picture.Location.Y;
                selected[opted - 1].ThongTinChiTietDoiTuong.ChieuRongAnh = pictureBoxMap.Size.Width;
                selected[opted - 1].ThongTinChiTietDoiTuong.ChieuDaiAnh = pictureBoxMap.Size.Height;
                selected[opted - 1].Picture.Visible = true;
                if (KeHoach != null) listAdd.Add(selected[opted - 1]);
                check = 0;
                Cursor = Cursors.Default;
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
                    Refresh();
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
                    Refresh();
                }
            }
        }

        public void btnAnHienMophong_Click(object sender, EventArgs e)
        {
            timerMP.Start();
        }

        private void timerMP_Tick(object sender, EventArgs e)
        {
            if (hidedMP) // true là an
            {
                panelMP.Width = panelMP.Width + 20;
                panelMap.Width = panelMap.Width - 20;
                if (panelMP.Width >= panelWidthMP)
                {
                    timerMP.Stop();
                    hidedMP = false;
                    //    panelMap.Width = panelMap.Width + 20;
                    Refresh();
                }
            }
            else // hien 
            {
                panelMP.Width = panelMP.Width - 20;
                panelMap.Width = panelMap.Width + 20;
                if (panelMP.Width <= 0)
                {
                    timerMP.Stop();
                    hidedMP = true;
                    //    panelMap.Width = panelMap.Width + 20;
                    Refresh();
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
                    Refresh();
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

                    Refresh();
                }
            }
        }

        public void simpleButtonLuuPhuongAn_Click(object sender, EventArgs e)
        {
            var check = new BooleanAndDoiTuongClass {BoolVar = false};
            var count = new IntClass {IntVar = opted};
            var taoKeHoachMoi = new QuanLyPhuongAnForm(selected, count, treeView1, imageListChild, check);
            taoKeHoachMoi.ShowDialog();
            if (check.BoolVar)
            {
                opted = count.IntVar;
                selected = check.DoiTuongs;
                pictureBoxMap.Controls.Clear();
                for (var i = 0; i < opted; i++)
                {
                    selected[i].Picture.Visible = true;
                    selected[i].Picture.Location =
                        DrawHelper.ScaleImage(new Point(selected[i].ThongTinChiTietDoiTuong.ToaDoX,
                                selected[i].ThongTinChiTietDoiTuong.ToaDoY)
                            , new Size(selected[i].ThongTinChiTietDoiTuong.ChieuRongAnh, selected[i].ThongTinChiTietDoiTuong.ChieuDaiAnh),
                            pictureBoxMap);
                    pictureBoxMap.AddControl(selected[i].Picture);
                    MoveButton(selected[i].Picture);
                    deletePic(selected[i].Picture);
                }
            }
        }

        private void buttonAnHien_Paint(object sender, PaintEventArgs e)
        {
            var font = new Font("Tahoma", 8);
            Brush brush = new SolidBrush(Color.Black);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("Ký hiệu quân sự", font, brush, 0, 0);
        }


        private void panelMP_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonAnHienChiTietFile_Paint(object sender, PaintEventArgs e)
        {
            var font = new Font("Tahoma", 8);
            Brush brush = new SolidBrush(Color.Black);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("Chi tiết File", font, brush, 0, 0);
        }

        private void btnAnHienMophong_Paint(object sender, PaintEventArgs e)
        {
            var font = new Font("Tahoma", 8);
            Brush brush = new SolidBrush(Color.Black);
            e.Graphics.TranslateTransform(30, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("Mô phỏng", font, brush, 0, 0);
        }

        public void buttonAnHienChiTietFile_Click_1(object sender, EventArgs e)
        {
            timerAnHienFile.Start();
        }

        public void buttonKyHieuQuanSu_Click(object sender, EventArgs e)
        {
            timerAnHien.Start();
        }

        private void simpleButtonBatDau_Click(object sender, EventArgs e)
        {
            if (Program.frm_Map.KeHoach == null)
            {
                MessageBox.Show("Hãy chọn kế hoạch để mô phỏng");
                return;
            }
            if (Program.frm_Map.KeHoach.BanDo == null || Program.frm_Map.KeHoach.FileDem == null)
            {
                MessageBox.Show("Hãy chọn bản đồ và dữ liệu cho kế hoạch để mô phỏng");
                return;
            }

            readyToWrite.Set();
            Program.frm_Map.a = new Thread(() => { ChangeHeight(); });
            Program.frm_Map.a.IsBackground = true;
            Program.frm_Map.a.Start();
            Program.frm_Map.b = new Thread(() => { Program.frm_Map.DrawImage(Program.frm_Map.pictureBoxMap); });
            Program.frm_Map.b.Start();
            Program.frm_Map.b.IsBackground = true;
        }

        private void simpleButtonDatLai_Click(object sender, EventArgs e)
        {
            Program.frm_Map.a.Abort();
            Program.frm_Map.b.Abort();
            _mDem.Read(Program.frm_Map.path);
            Program.frm_Map.pictureBoxMap.Image = Program.frm_Map.bitmapInit;
            Program.frm_Map.bitmapResize = new Bitmap(bitmapInit1, 1201, 1201);
        }

        private void checkButtonTamDung_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButtonTamDung.Checked)
            {
                checkButtonTamDung.Image = Resources.start_16;
                checkButtonTamDung.Text = "Tiếp Tục";
                // Set Pause
                lock (pauseLock)
                {
                    isPause = true;
                }
            }
            else
            {
                checkButtonTamDung.Image = Resources.pause_16;
                checkButtonTamDung.Text = "Tạm Dừng";
                // Set Pause
                lock (pauseLock)
                {
                    isPause = false;
                }
            }
        }

        private void trackBarTocDo_ValueChanged(object sender, EventArgs e)
        {
            while (true)
            {
                var tryToLockSpeed = false;
                Monitor.TryEnter(speedLock, ref tryToLockSpeed);
                var proportion = Program.frm_Map.MapValueToProportion(trackBarTocDo.Value);
                if (tryToLockSpeed)
                {
                    speed = (short) (speedInit * proportion);
                    labeTocDo.Text = "Tốc độ : X" + proportion;
                    Monitor.Exit(speedLock);
                    break;
                }
            }
        }

        #region  quanlytreeview

        private void doiTentoolStripMenuItemChild_Click(object sender, EventArgs e)
        {
            Program.flag = false;
            var icon = new Icon_DoiTuong();
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
            var icon = new Icon_DoiTuong();
            icon.HienMaBinhChung(Program.binhChung.mabinhchung);
            icon.ShowDialog();
        }

        private void đoiTenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.flag = false;
            var loaiDoiTuong = new LoaiDoiTuong();
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
            var loaiDoiTuong = new LoaiDoiTuong();
            loaiDoiTuong.ShowDialog();
        }

        #endregion
    }
}