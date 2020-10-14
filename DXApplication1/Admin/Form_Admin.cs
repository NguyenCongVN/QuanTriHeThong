using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using DXApplication1.Account;
using DXApplication1.Models;

namespace DXApplication1
{

    public partial class FrmMain_Admin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int chk = 0;
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

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

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

        private void barButtonItemBanDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}
