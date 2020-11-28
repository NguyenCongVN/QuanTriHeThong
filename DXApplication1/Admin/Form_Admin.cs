using Braincase.USGS.DEM;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DXApplication1.Account;
using DXApplication1.Models;
using DXApplication1.Views;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DXApplication1
{


    public partial class FrmMain_Admin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int chk = 0;
        int aa = 0;
        public FrmMain_Admin()
        {

            InitializeComponent();
        }
        //set form mặc định
        public void Skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Whiteprint";       //tên giao diện set mặc định
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Skins();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chk == 0)
            {
                DialogResult dr;
                dr = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Program.lg.Close();
                }
            }
            else
            {
                Program.lg.Close();
            }

        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

        }
        private void barButtonItemPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.phanquyen = new Admin.Phanquyen();

            Program.phanquyen.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(Program.phanquyen);
            Program.phanquyen.Dock = DockStyle.Fill;
            Program.phanquyen.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            Program.phanquyen.Show();
        }

        public void barButtonItemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kt = 0;
            foreach (var q in Program.lg.List_Q)
            {
                if (q.QuyenId == "QNXEMNV")
                {
                    kt = 1;
                    break;
                }
            }
            if (kt == 0)
                XtraMessageBox.Show("Bạn không có quyền xem thông tin nhân viên!!!", "Thông báo");
            else
            {
                Program.quanLyNhanVien = new Admin.QuanLyNhanVien();
                Program.quanLyNhanVien.TopLevel = false;
                panelMain.Controls.Clear();
                panelMain.Dock = DockStyle.Fill;
                panelMain.Controls.Add(Program.quanLyNhanVien);
                Program.quanLyNhanVien.Dock = DockStyle.Fill;
                Program.quanLyNhanVien.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Program.quanLyNhanVien.Show();
            }

        }

        private void btnThongTinCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kt = 0;
            foreach (var q in Program.lg.List_Q)
            {
                if (q.QuyenId == "QNXEMTTCN")
                {
                    Program.detail_user = new ThongTinNguoiDung();
                    Program.detail_userSql.Select_Detail(Program.detail_user, Program.lg.UserLogin.MaDangNhapNguoiDung);
                    Detail_User detail_form = new Detail_User();
                    detail_form.ShowDialog();
                    kt = 1;
                    break;
                }

            }
            if (kt == 0)
                XtraMessageBox.Show("Bạn không có quyền xem thông tin!!!", "Thông báo");

        }

        private void btnChangePass_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kt = 0;
            foreach (var q in Program.lg.List_Q)
            {
                if (q.QuyenId == "TDMKCN")
                {
                    kt = 1;
                    break;
                }
            }
            if (kt == 0)
                XtraMessageBox.Show("Bạn không có quyền thay đổi mật khẩu cá nhân!!!", "Thông báo");
            else
            {
                Program.up_datePass = new UpdatePass();
                Program.up_datePass.Show();
            }

        }

        private void btnLogout_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn đăng xuất ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                chk = 1;
                Program.lg = new frmLogin();
                Program.lg.Show();
                this.Hide();
            }
        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.frm_Map = new Views.Frm_test1();
            Program.frm_Map.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(Program.frm_Map);
            Program.frm_Map.Dock = DockStyle.Fill;
            Program.frm_Map.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Program.frm_Map.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.fileDem==null||Program.fileDem.IsDisposed)
            {
                Program.fileDem = new FileDem();
                Program.fileDem.Show();
            }
            else
            {
                Program.fileDem.Show();
            }
        }

        private void barButtonItemQLBanDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.QuanLyBanDo==null || Program.QuanLyBanDo.IsDisposed)
            {
                Program.QuanLyBanDo = new QuanLyBanDo();
                Program.QuanLyBanDo.ShowDialog();
            }
            else
            {
                Program.QuanLyBanDo.ShowDialog();
            }
        }

        private void barButtonItemQuanLyDuLieuTranDau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.fileDem == null || Program.fileDem.IsDisposed)
            {
                Program.fileDem = new FileDem();
                Program.fileDem.ShowDialog();
            }
            else
            {
                Program.fileDem.ShowDialog();
            }
        }

        private void barButtonItemQLPhuongAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!panelMain.Controls.Contains(Program.frm_Map))
            {
                barButtonItem4_ItemClick(null, null);
                Program.frm_Map.simpleButtonLuuPhuongAn_Click(null, null);
                Program.frm_Map.btnAnHienMophong_Click(null, null);
                Program.frm_Map.buttonAnHienChiTietFile_Click_1(null, null);
                Program.frm_Map.buttonKyHieuQuanSu_Click(null, null);
                
            }
            else
            {
                Program.frm_Map.simpleButtonLuuPhuongAn_Click(null, null);
                Program.frm_Map.btnAnHienMophong_Click(null, null);
                Program.frm_Map.buttonAnHienChiTietFile_Click_1(null, null);
                Program.frm_Map.buttonKyHieuQuanSu_Click(null, null);
                
            }
        }
    }
}
