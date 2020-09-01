using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DXApplication1.Views;

namespace DXApplication1
{
    static class Program
    {
        public static FrmMain_Admin main;
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            main = new FrmMain_Admin();
            main.IsMdiContainer = true;
            Application.Run(new FrmMain_Admin());
        }
    }
}
