using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DXApplication1.Views;
using DXApplication1.Models;
using DXApplication1.Account;
using DXApplication1.Admin;


namespace DXApplication1
{
    static class Program
    {
        public static FrmMain_Admin main;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static NguoiDungSql ndSql;
        public static frmLogin lg;
        public static UpdatePass up_datePass;
        public static LoaiQuyenSql loaiQuyenSql;
        public static QuyenSql quyenSql;
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            main = new FrmMain_Admin();
            main.IsMdiContainer = true;
            Application.Run(new Phanquyen());

        }
    }
}