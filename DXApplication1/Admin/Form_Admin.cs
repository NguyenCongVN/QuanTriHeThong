using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using DXApplication1.Account;
using DXApplication1.Models;

namespace DXApplication1
{

    public partial class FrmMain_Admin : DevExpress.XtraBars.Ribbon.RibbonForm
    {

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

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

        }
        private void barButtonItemPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Admin.Phanquyen phanquyen = new Admin.Phanquyen();
            phanquyen.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(phanquyen);
            phanquyen.Dock = DockStyle.Fill;
            phanquyen.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            phanquyen.Show();
        }

        public void barButtonItemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Admin.QuanLyNhanVien quanLyNhanVien = new Admin.QuanLyNhanVien();
            quanLyNhanVien.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(quanLyNhanVien);
            quanLyNhanVien.Dock = DockStyle.Fill;
            quanLyNhanVien.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            quanLyNhanVien.Show();
        }

        private void btnThongTinCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kt = 0;
            foreach (var q in Program.lg.List_Q)
            {
                if (q.QuyenId == "QNXEMNV")
                {
                    Program.detail_user = new ThongTinNguoiDung();
                    Program.detail_userSql.Select_Detail(Program.detail_user, Program.lg.UserLogin.MaDangNhapNguoiDung);
                    Detail_User detail_form = new Detail_User();
                    detail_form.Show();
                    kt = 1;
                    break;
                }

            }
            if (kt == 0)
                XtraMessageBox.Show("Bạn không có quyền xem thông tin!!!", "Thông báo");

        }
    }
}
