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
using DevExpress.XtraEditors;
using DXApplication1.Models;

namespace DXApplication1.Views
{
    public partial class TaoKeHoachMoi : DevExpress.XtraEditors.XtraForm
    {
        private DoiTuong[] DoiTuong { get; set; }
        public TaoKeHoachMoi(DoiTuong[] doiTuong)
        {
            this.DoiTuong = doiTuong;
            InitializeComponent();
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
                foreach (DoiTuong doiTuong in DoiTuong)
                {
                    list.Add(new ThongTinChiTietDoiTuong()
                    {
                        MaKeHoach = keHoach.MaKeHoach,
                        MaDonVi = doiTuong.
                    });
                }
            }
        }
    }
}