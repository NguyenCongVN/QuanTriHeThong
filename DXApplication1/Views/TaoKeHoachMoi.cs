using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DXApplication1.Models;

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
        private DoiTuong[] DoiTuong { get; set; }
        private int Count { get; set; }
        private TreeView TreeView { get; set; }
        private ImageList ImageList { get; set; }
        public bool isChange {get ; set; }
        public QuanLyPhuongAnForm(DoiTuong[] doiTuong , int count , TreeView treeView ,ImageList imageList ,ref bool isChange )
        {
            isChange = true;
            this.DoiTuong = doiTuong;
            this.Count = count;
            this.ImageList = imageList;
            this.TreeView = treeView;
            this.isChange = isChange;
            InitializeComponent();
            LoadKeHoach();
            LoadKeHoachDeTail();
        }

        public void LoadKeHoachDeTail()
        {
            if (Program.frm_Map.KeHoach != null)
            {
                textEditTenPhuongAn.Text = Program.frm_Map.KeHoach.TenKeHoach;
                timeEditThoiGianLap.DateTime = Program.frm_Map.KeHoach.ThoiGianTao;
            }
        }

        public void LoadKeHoachDeTail(KeHoach keHoach)
        {
            textEditTenPhuongAn.Text = keHoach.TenKeHoach;
            timeEditThoiGianLap.DateTime = keHoach.ThoiGianTao;
        }

        public void LoadKeHoach()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Kế Hoạch");
            dt.Columns.Add("Tên Kế Hoạch");
            dt.Columns.Add("Người Lập Kế Hoạch");
            dt.Columns.Add("Thời Gian Tạo");
            dt.Columns.Add("Mã Người Lập");
            foreach(var item in Program.KeHoachSql.GetAllKeHoach())
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

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            if (Program.lg.UserLogin == null)
            {
                MessageBox.Show("Bạn Phải Đăng Nhập");
                return;
            }
            if (this.timeEditThoiGianLap.DateTime <= DateTime.Now)
            {
                KeHoach keHoach = new KeHoach()
                {
                    MaNguoiLap = Program.lg.UserLogin.MaDangNhapNguoiDung,
                    TenKeHoach = textEditTenPhuongAn.Text
                };
                Program.KeHoachSql.ThemKeHoach(keHoach);
                Program.frm_Map.KeHoach = keHoach;
                List<ThongTinChiTietDoiTuong> list = new List<ThongTinChiTietDoiTuong>();
                for(int i = 0 ; i < Count ; i++)
                {
                    list.Add(new ThongTinChiTietDoiTuong()
                    {
                        MaKeHoach = keHoach.MaKeHoach,
                        MaDonVi = DoiTuong[i].MaDonVi,
                        ToaDoX = DoiTuong[i].LocationInImage.X,
                        ToaDoY = DoiTuong[i].LocationInImage.Y,
                        ChieuDaiAnh = DoiTuong[i].initSizePicture.Height,
                        ChieuRongAnh = DoiTuong[i].initSizePicture.Width,
                });
                }
                Program.ThongTinChiTietDoiTuongSql.AddDoiTuong(list);
                MessageBox.Show("Thanh Cong");
                LoadKeHoach();
                LoadKeHoachDeTail();
            }
        }

        private void dataGridViewKeHoach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int MaKeHoach = Int32.Parse(dataGridViewKeHoach[0, e.RowIndex].Value.ToString());
            LoadKeHoachDeTail(Program.KeHoachSql.GetKeHoachById(MaKeHoach));
        }

        public void MoKeHoach(KeHoach keHoach)
        {
            Program.frm_Map.KeHoach = keHoach;
            DoiTuong = Program.ThongTinChiTietDoiTuongSql.LayCacDoiTuongTuKeHoach(keHoach.MaKeHoach , TreeView , ImageList).ToArray();
            this.isChange = true;
            this.Dispose();
        }

        private void simpleButtonMo_Click(object sender, EventArgs e)
        {
            if (dataGridViewKeHoach.SelectedRows == null)
            {
                MessageBox.Show("Hãy chọn kế hoạch để mở"); // Is Unreachable ??
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
    }
}