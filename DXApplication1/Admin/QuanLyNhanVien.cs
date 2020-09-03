using DXApplication1.Models;

namespace DXApplication1.Admin
{
    public partial class QuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public QuanLyNhanVien()
        {
            ThongTinNguoiDung thongTinNguoiDung = Program.detail_user;
            InitializeComponent();
            textBoxMaDangNhap.Text = thongTinNguoiDung.MaDangNhapNguoiDung;
            textBoxHoTen.Text = thongTinNguoiDung.HoTen;
            textBoxEmail.Text = thongTinNguoiDung.Email;
            textBoxDiaChi.Text = thongTinNguoiDung.DiaChi;
            textBoxSoDienThoai.Text = thongTinNguoiDung.SoDienThoai;
            textBoxChucVu.Text = thongTinNguoiDung.ChucVu;
            dateEditNgaySinh.DateTime = thongTinNguoiDung.NgaySinh;
            dateEditNgayTaoTaiKhoan.DateTime = thongTinNguoiDung.NgayTao;
        }
    }
}