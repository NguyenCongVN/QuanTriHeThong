using Braincase.USGS.DEM;
using DevExpress.Utils.Extensions;
using DXApplication1.UserControls;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DXApplication1.Utilizes;

namespace DXApplication1.Views
{
    public partial class Frm_test1 : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// 
        /// </summary>

        static Bitmap bitmapInit1 = new Bitmap(@"C:\Users\NguyenCong\Pictures\Screenshot 2020-09-25 202017.png");

        Bitmap bitmapInit = new Bitmap(bitmapInit1, 3000, 3000);

        //

        Bitmap bitmapTemp = new Bitmap(bitmapInit1, 3000, 3000);

        //
        public static DemDocument _mDem = null;

        // object to lock _mDem file

        private static object DemLock = new object();

        // Ready to read file

        public static EventWaitHandle readyToRead = new AutoResetEvent(false);

        // Ready to write file

        public static EventWaitHandle readyToWrite = new AutoResetEvent(true);





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

            
            pictureBox1.Image = bitmapInit;

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
            Image image = Image.FromFile(@"C:\Users\NguyenCong\Pictures\Screenshot 2020-09-25 202017.png");
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
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                { firstPoint = Control.MousePosition; }

            };
            b1.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
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



        public static void ChangeHeight()
        {
            while (true)
            {
                readyToWrite.WaitOne();
                lock (DemLock)
                {
                    for (int col = 0; col < _mDem.ARecord.eastings_cols; col++)
                    {
                        for (int row = 0; row < _mDem.ARecord.northings_rows; row++)
                        {
                            _mDem.BRecord.elevations[col, row] -= 5;
                        }
                    }
                }
                readyToRead.Set();
                //Thread.Sleep(3000);
            }
        }



        public void DrawImage(PictureBox _mPictureBox)
        {
            while (true)
            {
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

                        _mPictureBox.Invoke((MethodInvoker) delegate
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
                    Thread a = new Thread((() =>
                    {
                        ChangeHeight();
                    }));
                    a.Start();
                    Thread b = new Thread(() =>
                    {

                        DrawImage(pictureBox1);
                    });
                    b.Start();
                }
            }
        }
    }
}