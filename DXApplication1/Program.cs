using DevExpress.UserSkins;
using DXApplication1.Account;
using DXApplication1.Admin;
using DXApplication1.Models;
using DXApplication1.Views;
using System;
using System.Windows.Forms;
using DXApplication1.Objects_Icon;


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
        public static Phanquyen phanquyen;
        public static QuyenSql quyenSql;
        public static ThongTinNguoiDung detail_user;
        public static QuanLyNhanVien quanLyNhanVien;
        public static QuanLyNhanVienSql quanLyNhanVienSql;
        public static ChucvuSql chucvuSql;
        public static BanDoSql banDoSql;
        public static Chucvu cvu;
        public static Frm_test1 frm_Map;
        public static KeHoachSql KeHoachSql;
        public static ThongTinChiTietDoiTuongSql ThongTinChiTietDoiTuongSql;
        public static ThongTinBanDoKeHoachSql ThongTinBanDoKeHoachSql;
        public static ThongTinFileDemKeHoachSql ThongTinFileDemKeHoachSql;
        public static  NodeOnMap nodeOnMap;

        public static FileDem fileDem;
        public static FileDemSql fileDemSql;
        public static QuanLyBanDo QuanLyBanDo;
        public static string getMa;
        public static bool flag;
        public static DoiTuong doiTuong;
        public static TTDoiTuong tTDoiTuong;
        public static bool flag_Doituong;
        public static QuanLyPhuongAnForm quanLyPhuongAnForm;
        public static BinhChung binhChung;
        public static DonVi donVi;
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            ndSql = new NguoiDungSql();
            detail_userSql = new ThongTinNguoiDungSql();
            phanquyen = new Phanquyen();
            chucvuSql = new ChucvuSql();
            cvu = new Chucvu();
            quyenSql = new QuyenSql();
            quanLyNhanVien = new QuanLyNhanVien();
            KeHoachSql = new KeHoachSql();
            ThongTinChiTietDoiTuongSql = new ThongTinChiTietDoiTuongSql();
            banDoSql = new BanDoSql();
            fileDemSql = new FileDemSql();
            ThongTinBanDoKeHoachSql = new ThongTinBanDoKeHoachSql();
            ThongTinFileDemKeHoachSql = new ThongTinFileDemKeHoachSql();
            lg = new frmLogin();
            frm_Map = new Frm_test1();
            nodeOnMap = new NodeOnMap();
            binhChung = new BinhChung();
            donVi = new DonVi();
            fileDem = new FileDem();
            QuanLyBanDo = new QuanLyBanDo();
            Application.Run(lg);
        }
    }
}