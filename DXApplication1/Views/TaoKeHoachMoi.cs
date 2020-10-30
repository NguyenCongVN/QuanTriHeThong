using DXApplication1.Models;
using DXApplication1.Utilizes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
            }
        }

        // Load Thong tin ke hoach vao trong cac text box
        public void LoadKeHoachDeTail(KeHoach keHoach)
        {
            textEditTenPhuongAn.Text = keHoach.TenKeHoach;
            timeEditThoiGianLap.DateTime = keHoach.ThoiGianTao;
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
                }
            }
            else
            {
                if (this.timeEditThoiGianLap.DateTime <= DateTime.Now)
                {
                    KeHoach keHoach = new KeHoach()
                    {
                        MaNguoiLap = Program.lg.UserLogin.MaDangNhapNguoiDung,
                        TenKeHoach = textEditTenPhuongAn.Text
                    };
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
                        });
                    }

                    Program.KeHoachSql.ThemKeHoach(keHoach);
                    Program.frm_Map.KeHoach = keHoach;
                    Program.ThongTinChiTietDoiTuongSql.AddDoiTuong(list);
                    MessageBox.Show("Thành Công");
                    LoadKeHoach();
                    LoadKeHoachDeTail();
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
        }

        private void dataGridViewKeHoach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (!string.IsNullOrEmpty(dataGridViewKeHoach[0, e.RowIndex].Value.ToString()))
                {
                    int MaKeHoach = Int32.Parse(dataGridViewKeHoach[0, e.RowIndex].Value.ToString());
                    LoadKeHoachDeTail(Program.KeHoachSql.GetKeHoachById(MaKeHoach));
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
            this.isChange.DoiTuongs = Program.ThongTinChiTietDoiTuongSql.LayCacDoiTuongTuKeHoach(keHoach.MaKeHoach, TreeView, ImageList, Count);
            this.isChange.BoolVar = true;
            this.Dispose();
        }

        private void simpleButtonMo_Click(object sender, EventArgs e)
        {
            if (dataGridViewKeHoach.SelectedRows == null)
            {
                MessageBox.Show("Hãy chọn kế hoạch để mở");
            }
            else
            {
                KeHoach selectedKeHoach = new KeHoach()
                {
                    MaKeHoach = Int32.Parse(dataGridViewKeHoach.SelectedRows[0].Cells[(int)ThongTinKeHoach.MaKeHoach].Value.ToString()),
                    TenKeHoach = dataGridViewKeHoach.SelectedRows[0].Cells[(int)ThongTinKeHoach.TenKeHoach].Value.ToString(),
                    MaNguoiLap = dataGridViewKeHoach.SelectedRows[0].Cells[(int)ThongTinKeHoach.MaNguoiLap].Value.ToString(),
                    ThoiGianTao = DateTime.Parse(dataGridViewKeHoach.SelectedRows[0].Cells[(int)ThongTinKeHoach.ThoiGianLap].Value.ToString()),
                    TenNguoiLap = dataGridViewKeHoach.SelectedRows[0].Cells[(int)ThongTinKeHoach.NguoiLapKeHoach].Value.ToString(),
                };
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
    }
}