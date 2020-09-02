using DevExpress.XtraEditors;
using DXApplication1.Account;
using System;
using System.Windows.Forms;

namespace DXApplication1
{

    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public FrmMain()
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

        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

        }


        private void tabHienThi1_Click(object sender, EventArgs e)
        {

        }


        private void btnPhanquyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.up_datePass = new UpdatePass();
            Program.up_datePass.Show();
        }


    }
}
