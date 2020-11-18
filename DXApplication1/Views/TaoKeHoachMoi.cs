using DXApplication1.Models;
using DXApplication1.Utilizes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Braincase.USGS.DEM;
using ComboBoxItemBanDo = DXApplication1.Utilizes.ComboBoxItemBanDo;
using System.IO;

namespace DXApplication1.Views
{
    public partial class QuanLyPhuongAnForm : DevExpress.XtraEditors.XtraForm
    {
        enum ThongTinKeHoach
        {
            MaKeHoach,
            TenKeHoach,
            NguoiLapKeHoach,
            ThoiGianLap,
            MaNguoiLap
        }
        private IntClass Count { get; set; }
        private TreeView TreeView { get; set; }
        private ImageList ImageList { get; set; }
        public BooleanAndDoiTuongClass isChange { get; set; }

        public QuanLyPhuongAnForm(List<DoiTuong> doiTuong, IntClass count, TreeView treeView, ImageList imageList, BooleanAndDoiTuongClass isChange)
        {
            this.isChange = isChange;
            this.isChange.DoiTuongs = doiTuong;
            this.Count = count;
            this.ImageList = imageList;
            this.TreeView = treeView;
            this.isChange = isChange;
            InitializeComponent();
            InitComBoBoxFile();
            InitComBoBoxBanDo();
            LoadKeHoach();
            LoadKeHoachDeTail();
        }

        // Load Thong tin ke hoach vao trong cac text box
        public void LoadKeHoachDeTail()
        {
            if (Program.frm_Map.KeHoach != null)
            {
                textEditTenPhuongAn.Text = Program.frm_Map.KeHoach.TenKeHoach;
                timeEditThoiGianLap.DateTime = Program.frm_Map.KeHoach.ThoiGianTao;
                if (Program.frm_Map.KeHoach.BanDo != null)
                    foreach (ComboBoxItemBanDo comboBoxItemBanDo in comboBoxMaBanDo.Items)
                    {
                        if (comboBoxItemBanDo.MaBanDo == Program.frm_Map.KeHoach.BanDo.MaBanDo)
                        {
                            comboBoxMaBanDo.SelectedItem = comboBoxItemBanDo;
                        }
                    }
                else
                {
                    comboBoxMaBanDo.SelectedIndex = -1;
                    comboBoxTenBanDo.SelectedIndex = -1;
                }

                if (Program.frm_Map.KeHoach.FileDem != null)
                    foreach (ComboBoxItemFileDem comboBoxItemFileDem in comboBoxMaFile.Items)
                    {
                        if (comboBoxItemFileDem.MaFile == Program.frm_Map.KeHoach.FileDem.MaFile)
                        {
                            comboBoxMaFile.SelectedItem = comboBoxItemFileDem;
                        }
                    }
                else
                {
                    comboBoxMaFile.SelectedIndex = -1;
                    comboBoxTenFile.SelectedIndex = -1;
                }
            }
        }

        // Load Thong tin ke hoach vao trong cac text box
        public void LoadKeHoachDeTail(KeHoach keHoach)
        {
            textEditTenPhuongAn.Text = keHoach.TenKeHoach;
            timeEditThoiGianLap.DateTime = keHoach.ThoiGianTao;
            if (keHoach.BanDo != null)
                foreach (ComboBoxItemBanDo comboBoxItemBanDo in comboBoxMaBanDo.Items)
                {
                    if (comboBoxItemBanDo.MaBanDo == keHoach.BanDo.MaBanDo)
                    {
                        comboBoxMaBanDo.SelectedItem = comboBoxItemBanDo;
                    }
                }
            else
            {
                comboBoxMaBanDo.SelectedIndex = -1;
                comboBoxTenBanDo.SelectedIndex = -1;
            }

            if (keHoach.FileDem != null)
                foreach (ComboBoxItemFileDem comboBoxItemFileDem in comboBoxMaFile.Items)
                {
                    if (comboBoxItemFileDem.MaFile == keHoach.FileDem.MaFile)
                    {
                        comboBoxMaFile.SelectedItem = comboBoxItemFileDem;
                    }
                }
            else
            {
                comboBoxMaFile.SelectedIndex = -1;
                comboBoxTenFile.SelectedIndex = -1;
            }
        }

        // Load Ke Hoach vao trong GridView
        public void LoadKeHoach()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Kế Hoạch");
            dt.Columns.Add("Tên Kế Hoạch");
            dt.Columns.Add("Người Lập Kế Hoạch");
            dt.Columns.Add("Thời Gian Tạo");
            dt.Columns.Add("Mã Người Lập");
            foreach (var item in Program.KeHoachSql.GetAllKeHoach())
            {
                dt.Rows.Add(new object[]
                {
                    item.MaKeHoach, item.TenKeHoach ,
                    item.TenNguoiLap,
                    item.ThoiGianTao,
                    item.MaNguoiLap
                });
            }
            dataGridViewKeHoach.DataSource = dt;
        }

        // Luu lai ke hoach da tao
        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            // Neu chua dang nhap thi bao loi
            if (Program.lg.UserLogin == null)
            {
                MessageBox.Show("Bạn Phải Đăng Nhập");
                return;
            }
            // Neu dang mo mot ke hoach
            if (Program.frm_Map.KeHoach != null)
            {
                // Neu chon ke hoach khac de luu thi bao canh bao
                //if (Program.frm_Map.KeHoach.MaKeHoach
                //    != Int32.Parse(dataGridViewKeHoach.SelectedRows[0].Cells[(int)ThongTinKeHoach.MaKeHoach].Value.ToString()))
                //{
                //    MessageBox.Show("Bạn đang chọn lưu vào một phương án khác\n Hãy tạo phương án mới hoặc mở phương án trước khi lưu");
                //    return;
                //}
                //else
                {
                    Program.frm_Map.KeHoach.TenKeHoach = textEditTenPhuongAn.Text;
                    Program.frm_Map.KeHoach.ThoiGianTao = timeEditThoiGianLap.DateTime;
                    Program.KeHoachSql.UpdateKeHoach(Program.frm_Map.KeHoach);
                    List<ThongTinChiTietDoiTuong> list = new List<ThongTinChiTietDoiTuong>();
                    // Them cac doi tuong moi
                    foreach (DoiTuong doiTuong in Program.frm_Map.listAdd)
                    {
                        list.Add(doiTuong.ThongTinChiTietDoiTuong);
                    }

                    Program.ThongTinChiTietDoiTuongSql.AddDoiTuong(list);

                    // Sua cac doi tuong duoc sua doi
                    Program.ThongTinChiTietDoiTuongSql.SuaDoiTuong(Program.frm_Map.listUpdate);

                    // Xoa cac doi tuong khong con tren ban do
                    Program.ThongTinChiTietDoiTuongSql.XoaDoiTuong(Program.frm_Map.listRemove);

                    // Lưu lại bản đồ và file dem
                    if (comboBoxMaBanDo.SelectedItem != null)
                    {
                        if (Program.frm_Map.KeHoach.BanDo != null)
                        {
                            Program.ThongTinBanDoKeHoachSql.RemoveThongTinBanDoKeHoach(Program.frm_Map.KeHoach.MaThongTinBanDoKeHoach);
                        }
                        ComboBoxItemBanDo banDo = (ComboBoxItemBanDo)comboBoxMaBanDo.SelectedItem;
                        Program.frm_Map.KeHoach.BanDo = new BanDo()
                        {
                            MaBanDo = banDo.MaBanDo,
                            DuongDanAnh = banDo.DuongDan,
                            TenBanDo = banDo.TenBanDo
                        };
                        Program.ThongTinBanDoKeHoachSql.AddThongTinBanDoKeHoach(new ThongTinBanDoKeHoach()
                        {
                            MaKeHoach = Program.frm_Map.KeHoach.MaKeHoach,
                            MaBanDo = Program.frm_Map.KeHoach.BanDo.MaBanDo,
                        });
                    }

                    if (comboBoxMaFile.SelectedItem != null)
                    {
                        if (Program.frm_Map.KeHoach.FileDem != null)
                        {
                            Program.ThongTinFileDemKeHoachSql.RemoveThongTinFileDemKeHoach(Program.frm_Map.KeHoach.MaThongTinFileDemKeHoach);
                        }
                        ComboBoxItemFileDem file = (ComboBoxItemFileDem)comboBoxMaFile.SelectedItem;
                        Program.frm_Map.KeHoach.FileDem = new Dem()
                        {
                            MaFile = file.MaFile,
                            TenFile = file.TenFile,
                            DuongDan = file.DuongDan
                        };
                        Program.ThongTinFileDemKeHoachSql.AddThongTinFileDemKeHoach(new ThongTinFileDemKeHoach()
                        {
                            MaKeHoach = Program.frm_Map.KeHoach.MaKeHoach,
                            MaFile = Program.frm_Map.KeHoach.FileDem.MaFile,
                        });
                    }
                }
            }
            else
            {
                if (this.timeEditThoiGianLap.DateTime <= DateTime.Now)
                {
                    if (textEditTenPhuongAn.Text == string.Empty)
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn chưa đặt tên cho kế hoạch ! Bạn có muốn đặt tên không?", "Lưu ý", MessageBoxButtons.YesNoCancel);
                        if (dialogResult == DialogResult.Yes)
                        {
                            textEditTenPhuongAn.ReadOnly = false;
                            timeEditThoiGianLap.ReadOnly = false;
                            richEditControlChiTiet.ReadOnly = false;
                            return;
                        }
                        else
                        {
                            if(dialogResult == DialogResult.Cancel)
                            return;
                        }
                    }
                    if (comboBoxMaBanDo.SelectedItem == null || comboBoxMaFile.SelectedItem == null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn chưa chọn bản đồ hoặc kế hoạch ! Bạn có lưu lại luôn không?", "Lưu ý", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            KeHoach keHoach = new KeHoach()
                            {
                                MaNguoiLap = Program.lg.UserLogin.MaDangNhapNguoiDung,
                                TenKeHoach = textEditTenPhuongAn.Text
                            };
                            Program.KeHoachSql.ThemKeHoach(keHoach);
                            Program.frm_Map.KeHoach = keHoach;
                            List<ThongTinChiTietDoiTuong> list = new List<ThongTinChiTietDoiTuong>();
                            for (int i = 0; i < Count.IntVar; i++)
                            {
                                list.Add(new ThongTinChiTietDoiTuong()
                                {
                                    MaKeHoach = keHoach.MaKeHoach,
                                    MaDonVi = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.MaDonVi,
                                    ToaDoX = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.ToaDoX,
                                    ToaDoY = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.ToaDoY,
                                    ChieuDaiAnh = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.ChieuDaiAnh,
                                    ChieuRongAnh = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.ChieuRongAnh,
                                    ChieuNgang = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.ChieuNgang,
                                    ChieuDoc = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.ChieuDoc,
                                    TenDoiTuong = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.TenDoiTuong
                                });
                            }
                            Program.ThongTinChiTietDoiTuongSql.AddDoiTuong(list);
                            MessageBox.Show("Thành Công");
                            LoadKeHoach();
                            LoadKeHoachDeTail();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        KeHoach keHoach = new KeHoach()
                        {
                            MaNguoiLap = Program.lg.UserLogin.MaDangNhapNguoiDung,
                            TenKeHoach = textEditTenPhuongAn.Text
                        };

                        Program.KeHoachSql.ThemKeHoach(keHoach);
                        // Lưu lại bản đồ và file dem
                        ComboBoxItemBanDo banDo = (ComboBoxItemBanDo)comboBoxMaBanDo.SelectedItem;
                        keHoach.BanDo = new BanDo()
                        {
                            MaBanDo = banDo.MaBanDo,
                            DuongDanAnh = banDo.DuongDan,
                            TenBanDo = banDo.TenBanDo
                        };
                        Program.ThongTinBanDoKeHoachSql.AddThongTinBanDoKeHoach(new ThongTinBanDoKeHoach()
                        {
                            MaKeHoach = keHoach.MaKeHoach,
                            MaBanDo = keHoach.BanDo.MaBanDo,
                        });

                        ComboBoxItemFileDem file = (ComboBoxItemFileDem)comboBoxMaFile.SelectedItem;
                        keHoach.FileDem = new Dem()
                        {
                            MaFile = file.MaFile,
                            TenFile = file.TenFile,
                            DuongDan = file.DuongDan
                        };
                        Program.ThongTinFileDemKeHoachSql.AddThongTinFileDemKeHoach(new ThongTinFileDemKeHoach()
                        {
                            MaKeHoach = keHoach.MaKeHoach,
                            MaFile = keHoach.FileDem.MaFile,
                        });

                        // Thêm các đối tượng
                        List<ThongTinChiTietDoiTuong> list = new List<ThongTinChiTietDoiTuong>();
                        for (int i = 0; i < Count.IntVar; i++)
                        {
                            list.Add(new ThongTinChiTietDoiTuong()
                            {
                                MaKeHoach = keHoach.MaKeHoach,
                                MaDonVi = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.MaDonVi,
                                ToaDoX = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.ToaDoX,
                                ToaDoY = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.ToaDoY,
                                ChieuDaiAnh = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.ChieuDaiAnh,
                                ChieuRongAnh = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.ChieuRongAnh,
                                ChieuNgang = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.ChieuNgang,
                                ChieuDoc = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.ChieuDoc,
                                TenDoiTuong = isChange.DoiTuongs[i].ThongTinChiTietDoiTuong.TenDoiTuong
                            });
                        }
                        Program.ThongTinChiTietDoiTuongSql.AddDoiTuong(list);
                        Program.frm_Map.KeHoach = keHoach;
                        MessageBox.Show("Thành Công");
                        LoadKeHoach();
                        LoadKeHoachDeTail();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn ngày đúng");
                    return;
                }
            }
            MessageBox.Show("Lưu lại thành công");
            Program.frm_Map.listUpdate.Clear();
            Program.frm_Map.listAdd.Clear();
            Program.frm_Map.listRemove.Clear();
            LoadKeHoach();
        }

        private void dataGridViewKeHoach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (!string.IsNullOrEmpty(dataGridViewKeHoach[0, e.RowIndex].Value.ToString()))
                {
                    int MaKeHoach = Int32.Parse(dataGridViewKeHoach[0, e.RowIndex].Value.ToString());
                    LoadKeHoachDeTail(Program.KeHoachSql.GetKeHoachAndDetailById(MaKeHoach));
                }
            }
        }

        public void MoKeHoach(KeHoach keHoach)
        {
            if (Program.frm_Map.listAdd.Count != 0 || Program.frm_Map.listUpdate.Count != 0 || Program.frm_Map.listRemove.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có thông tin chưa lưu lại ! Bạn có muốn lưu lại trước khi mở một kế hoạch khác", "Cảnh báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    simpleButtonLuu_Click(null, null);
                }
            }
            Program.frm_Map.KeHoach = keHoach;
            if (keHoach.BanDo != null)
            {
                if(File.Exists(keHoach.BanDo.DuongDanAnh))
                {
                    Frm_test1.bitmapInit1 = new Bitmap(keHoach.BanDo.DuongDanAnh);

                    // Resize bitmap background
                    Program.frm_Map.bitmapInit = new Bitmap(Frm_test1.bitmapInit1, 1201, 1201);

                    Program.frm_Map.pictureBoxMap.Image = Program.frm_Map.bitmapInit;

                    // Bitmap Temp to be used in virtualization
                    Program.frm_Map.bitmapTemp = new Bitmap(Frm_test1.bitmapInit1, 1201, 1201);

                    // Bitmap to be used in resize mode
                    Program.frm_Map.bitmapResize = new Bitmap(Frm_test1.bitmapInit1, 1201, 1201);
                }
               else
                {
                    MessageBox.Show("Không tồn tại file bản đồ");
                }
            }

            if (keHoach.FileDem != null)
            {
                if (System.IO.File.Exists(keHoach.FileDem.DuongDan))
                {
                    Program.frm_Map.path = keHoach.FileDem.DuongDan;
                    Frm_test1._mDem = new DemDocument();
                    Frm_test1._mDem.Read(keHoach.FileDem.DuongDan);
                    Program.frm_Map.txtOutput.Text = string.Empty;
                    Program.frm_Map.txtOutput.Text += "DEM Name: " + new string(Frm_test1._mDem.ARecord.file_name) + Environment.NewLine;
                    Program.frm_Map.txtOutput.Text += "SE Coord: " + new string(Frm_test1._mDem.ARecord.SE_geographic_corner_S) + ", " +
                                      new string(Frm_test1._mDem.ARecord.SE_geographic_corner_E) + Environment.NewLine;
                    Program.frm_Map.txtOutput.Text += "DEM Level Code: " + Frm_test1._mDem.ARecord.dem_level_code + Environment.NewLine;
                    Program.frm_Map.txtOutput.Text += "Ground Reference System: " +
                                      (GROUND_REF_SYSTEM)Frm_test1._mDem.ARecord.ground_ref_system + Environment.NewLine;
                    Program.frm_Map.txtOutput.Text += "Ground Reference Zone: " + Frm_test1._mDem.ARecord.ground_ref_zone + Environment.NewLine;
                    Program.frm_Map.txtOutput.Text += "Ground Unit: " + (GROUND_UNIT)Frm_test1._mDem.ARecord.ground_unit + Environment.NewLine;
                    Program.frm_Map.txtOutput.Text += "Elevation Unit: " + (ELEVATION_UNIT)Frm_test1._mDem.ARecord.elevation_unit +
                                      Environment.NewLine;
                    Program.frm_Map.txtOutput.Text += "Ground Resolution (lat, lng, elev): " + Frm_test1._mDem.ARecord.xyz_resolution[0] + ", " +
                                      Frm_test1._mDem.ARecord.xyz_resolution[1] + ", " + Frm_test1._mDem.ARecord.xyz_resolution[2] +
                                      Environment.NewLine;
                    Program.frm_Map.txtOutput.Text += "Elavation Array Szie: " + Frm_test1._mDem.ARecord.northings_rows + " x " +
                                      Frm_test1._mDem.ARecord.eastings_cols + Environment.NewLine;
                    Program.frm_Map.txtOutput.Text += "Percentage void: " + Frm_test1._mDem.ARecord.percent_void + Environment.NewLine;
                    Program.frm_Map.txtOutput.Text += "SW Coord: " + Frm_test1._mDem.ARecord.sw_coord[0] + ", " + Frm_test1._mDem.ARecord.sw_coord[1] +
                                      Environment.NewLine;
                    Program.frm_Map.txtOutput.Text += "NW Coord: " + Frm_test1._mDem.ARecord.nw_coord[0] + ", " + Frm_test1._mDem.ARecord.nw_coord[1] +
                                      Environment.NewLine;
                    Program.frm_Map.txtOutput.Text += "NE Coord: " + Frm_test1._mDem.ARecord.ne_coord[0] + ", " + Frm_test1._mDem.ARecord.ne_coord[1] +
                                      Environment.NewLine;
                    Program.frm_Map.txtOutput.Text += "SE Coord: " + Frm_test1._mDem.ARecord.se_coord[0] + ", " + Frm_test1._mDem.ARecord.se_coord[1] +
                                      Environment.NewLine;

                }
            }
            this.isChange.DoiTuongs = Program.ThongTinChiTietDoiTuongSql.LayCacDoiTuongTuKeHoach(keHoach.MaKeHoach, TreeView, ImageList, Count);
            this.isChange.BoolVar = true;
            this.Dispose();
        }

        public void simpleButtonMo_Click(object sender, EventArgs e)
        {
            if (dataGridViewKeHoach.SelectedRows == null)
            {
                MessageBox.Show("Hãy chọn kế hoạch để mở");
            }
            else
            {
                //KeHoach selectedKeHoach = new KeHoach()
                //{
                //    MaKeHoach = Int32.Parse(dataGridViewKeHoach.SelectedRows[0].Cells[(int)ThongTinKeHoach.MaKeHoach].Value.ToString()),
                //    TenKeHoach = dataGridViewKeHoach.SelectedRows[0].Cells[(int)ThongTinKeHoach.TenKeHoach].Value.ToString(),
                //    MaNguoiLap = dataGridViewKeHoach.SelectedRows[0].Cells[(int)ThongTinKeHoach.MaNguoiLap].Value.ToString(),
                //    ThoiGianTao = DateTime.Parse(dataGridViewKeHoach.SelectedRows[0].Cells[(int)ThongTinKeHoach.ThoiGianLap].Value.ToString()),
                //    TenNguoiLap = dataGridViewKeHoach.SelectedRows[0].Cells[(int)ThongTinKeHoach.NguoiLapKeHoach].Value.ToString(),
                //};
                int ma = Int32.Parse(dataGridViewKeHoach.SelectedRows[0].Cells[(int)ThongTinKeHoach.MaKeHoach].Value
                    .ToString());
                KeHoach selectedKeHoach = Program.KeHoachSql.GetKeHoachAndDetailById(ma);
                MoKeHoach(selectedKeHoach);
            }
        }

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Hãy nhập thông tin và nhấn lưu lại", "Thành Công", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Program.frm_Map.KeHoach = null;
                textEditTenPhuongAn.Text = "";
                timeEditThoiGianLap.DateTime = DateTime.Now;
                richEditControlChiTiet.Text = "";

                // 

                DialogResult dialogResult1 = MessageBox.Show("Bạn có muốn giữ lại các đối tượng hiện tại không>", "Thành Công", MessageBoxButtons.YesNoCancel);
                if (dialogResult1 == DialogResult.Yes)
                {
                    Program.frm_Map.KeHoach = null;
                    textEditTenPhuongAn.Text = "";
                    timeEditThoiGianLap.DateTime = DateTime.Now;
                    richEditControlChiTiet.Text = "";
                    Program.frm_Map.listUpdate.Clear();
                    Program.frm_Map.listAdd.Clear();
                    Program.frm_Map.listRemove.Clear();
                    textEditTenPhuongAn.ReadOnly = false;
                    timeEditThoiGianLap.DateTime = DateTime.Now;
                    richEditControlChiTiet.ReadOnly = false;
                }
                else
                {
                    if (dialogResult1 == DialogResult.No)
                    {
                        Program.frm_Map.KeHoach = null;
                        textEditTenPhuongAn.Text = "";
                        timeEditThoiGianLap.DateTime = DateTime.Now;
                        richEditControlChiTiet.Text = "";
                        isChange.DoiTuongs.Clear();
                        Program.frm_Map.listUpdate.Clear();
                        Program.frm_Map.listAdd.Clear();
                        Program.frm_Map.listRemove.Clear();
                        Program.frm_Map.pictureBoxMap.Controls.Clear();
                        textEditTenPhuongAn.ReadOnly = false;
                        timeEditThoiGianLap.DateTime = DateTime.Now;
                        richEditControlChiTiet.ReadOnly = false;
                        Program.frm_Map.opted = 0;
                    }
                    else
                    {
                        if (dialogResult1 == DialogResult.Cancel)
                            return;
                    }
                }
            }


        }

        private void TimKiem()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Kế Hoạch");
            dt.Columns.Add("Tên Kế Hoạch");
            dt.Columns.Add("Người Lập Kế Hoạch");
            dt.Columns.Add("Thời Gian Tạo");
            dt.Columns.Add("Mã Người Lập");
            var list = Program.KeHoachSql.GetAllKeHoach();
            list = list.Where(keHoach => keHoach.TenKeHoach.Contains(textEditTimKiem.Text)).ToList();
            foreach (var item in list)
            {
                dt.Rows.Add(new object[]
                {
                    item.MaKeHoach, item.TenKeHoach ,
                    item.TenNguoiLap,
                    item.ThoiGianTao,
                    item.MaNguoiLap
                });
            }
            dataGridViewKeHoach.DataSource = dt;
        }

        private void textEditTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void InitComBoBoxBanDo()
        {
            List<BanDo> listBanDo = Program.banDoSql.Select_All_Map();
            foreach (BanDo banDo in listBanDo)
            {
                comboBoxMaBanDo.Items.Add(new ComboBoxItemBanDo() { MaBanDo = banDo.MaBanDo, TenBanDo = banDo.TenBanDo, checkComboBox = true, DuongDan = banDo.DuongDanAnh });
                comboBoxTenBanDo.Items.Add(new ComboBoxItemBanDo() { MaBanDo = banDo.MaBanDo, TenBanDo = banDo.TenBanDo, checkComboBox = false, DuongDan = banDo.DuongDanAnh });
            }
        }

        private void InitComBoBoxFile()
        {
            List<Dem> listFileDem = Program.fileDemSql.SelectAllFileDem();
            foreach (Dem fileDem in listFileDem)
            {
                comboBoxMaFile.Items.Add(new ComboBoxItemFileDem() { MaFile = fileDem.MaFile, TenFile = fileDem.TenFile, checkComboBox = true, DuongDan = fileDem.DuongDan });
                comboBoxTenFile.Items.Add(new ComboBoxItemFileDem() { MaFile = fileDem.MaFile, TenFile = fileDem.TenFile, checkComboBox = false, DuongDan = fileDem.DuongDan });
            }
        }

        private void comboBoxMaBanDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMaBanDo.SelectedItem != null)
            {
                ComboBoxItemBanDo item = comboBoxMaBanDo.SelectedItem as ComboBoxItemBanDo;
                foreach (ComboBoxItemBanDo comboBoxItemBanDo in comboBoxTenBanDo.Items)
                {
                    if (comboBoxItemBanDo.MaBanDo == item.MaBanDo)
                    {
                        comboBoxTenBanDo.SelectedItem = comboBoxItemBanDo;
                    }
                }
            }
        }

        private void comboBoxTenBanDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTenBanDo.SelectedItem != null)
            {
                ComboBoxItemBanDo item = comboBoxTenBanDo.SelectedItem as ComboBoxItemBanDo;
                foreach (ComboBoxItemBanDo comboBoxItemBanDo in comboBoxMaBanDo.Items)
                {
                    if (comboBoxItemBanDo.MaBanDo == item.MaBanDo)
                    {
                        comboBoxMaBanDo.SelectedItem = comboBoxItemBanDo;
                    }
                }
            }
        }

        private void comboBoxMaFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMaFile.SelectedItem != null)
            {
                ComboBoxItemFileDem item = comboBoxMaFile.SelectedItem as ComboBoxItemFileDem;
                foreach (ComboBoxItemFileDem comboBoxItemFileDem in comboBoxTenFile.Items)
                {
                    if (comboBoxItemFileDem.MaFile == item.MaFile)
                    {
                        comboBoxTenFile.SelectedItem = comboBoxItemFileDem;
                    }
                }
            }
        }

        private void comboBoxTenFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTenFile.SelectedItem != null)
            {
                ComboBoxItemFileDem item = comboBoxTenFile.SelectedItem as ComboBoxItemFileDem;
                foreach (ComboBoxItemFileDem comboBoxItemFileDem in comboBoxMaFile.Items)
                {
                    if (comboBoxItemFileDem.MaFile == item.MaFile)
                    {
                        comboBoxMaFile.SelectedItem = comboBoxItemFileDem;
                    }
                }
            }
        }

        private void simpleButtonChinhSua_Click(object sender, EventArgs e)
        {
            if(Program.frm_Map.KeHoach == null)
            {
                MessageBox.Show("Hãy mở kế hoạch trước khi sửa");
                return;
            }
            else
            {
                textEditTenPhuongAn.ReadOnly = false;
                timeEditThoiGianLap.ReadOnly = false;
                richEditControlChiTiet.ReadOnly = false;
            }
        }
    }
}