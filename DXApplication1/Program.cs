using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DXApplication1.Views;
using DXApplication1.Models;


namespace DXApplication1
{
    static class Program
    {
        public static FrmMain main;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static NguoiDungSql ndSql;
        
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            ndSql = new NguoiDungSql();
            main = new FrmMain();

            main.IsMdiContainer = true;
            Application.Run(new frmLogin());
        }
    }
}
