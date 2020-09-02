using DevExpress.UserSkins;
using DXApplication1.Account;
using DXApplication1.Models;
using DXApplication1.Views;
using System;
using System.Windows.Forms;


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


            lg = new frmLogin();

            Application.Run(new frmLogin());



        }
    }
}