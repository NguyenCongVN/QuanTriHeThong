using DevExpress.UserSkins;
using DXApplication1.Account;
using DXApplication1.Admin;
using DXApplication1.Models;
using DXApplication1.Views;
using System;
using System.Windows.Forms;


namespace DXApplication1
{
    static class Program
    {
        public static FrmMain main;
        public static FrmMain_Admin main_admin;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static NguoiDungSql ndSql;
        public static ThongTinNguoiDungSql detail_userSql;
        public static frmLogin lg;
        public static frmDky dky;
        public static UpdatePass up_datePass;
        public static LoaiQuyenSql loaiQuyenSql;
        public static QuyenSql quyenSql;
        public static ThongTinNguoiDung detail_user;
        public static FrmMain_Admin admin;
        public static QuanLyNhanVien quanLyNhanVien;
        public static QuanLyNhanVienSql quanLyNhanVienSql;
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            ndSql = new NguoiDungSql();
            detail_userSql = new ThongTinNguoiDungSql();

            lg = new frmLogin();
            dky = new frmDky();
            admin = new FrmMain_Admin();
            quanLyNhanVien = new QuanLyNhanVien();
            quanLyNhanVien.IsMdiContainer = true;
            Application.Run(admin);
        }
    }
}