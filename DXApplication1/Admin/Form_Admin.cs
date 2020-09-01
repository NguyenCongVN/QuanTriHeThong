using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication1.Models;
using DXApplication1.Views;

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

        private void barButtonItemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}
