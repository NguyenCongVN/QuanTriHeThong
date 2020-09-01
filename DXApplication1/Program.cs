using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DXApplication1.Views;
using DXApplication1.Models;
using DXApplication1.Account;


namespace DXApplication1
{
    static class Program
    {
        public static FrmMain main;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static NguoiDungSql ndSql;
        public static frmLogin lg;
        public static UpdatePass up_datePass;
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            ndSql = new NguoiDungSql();
            main = new FrmMain();
            lg = new frmLogin();
            up_datePass = new UpdatePass();
            main.IsMdiContainer = true;
            Application.Run(lg);
        }
    }
}
