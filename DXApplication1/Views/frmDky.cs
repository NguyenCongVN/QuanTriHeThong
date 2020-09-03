using DevExpress.XtraEditors;
using DXApplication1.Models;
using DXApplication1.Utilizes;
using System;

namespace DXApplication1.Views
{
    public partial class frmDky : DevExpress.XtraEditors.XtraForm
    {
        public frmDky()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            // Bắt lỗi nhập thông tin.
            try
            {
                if (txtUser.Text == "" || txtPass.Text == "" || txtRePass.Text == "" || txtDiaChi.Text == ""
                    || txtEmail.Text == "" || txtHoTen.Text == "" || txtSoDienThoai.Text == "")
                    throw new Exception("Bạn phải nhập đầy đủ thông tin!");
                if (txtRePass.Text != txtPass.Text)
                    throw new Exception("Mật khẩu xác nhận không đúng!");
                if (!UserUtilizes.IsValidEmail(txtEmail.Text))
                {
                    throw new Exception("Hãy nhập một email hợp lệ");
                }

                if (!UserUtilizes.IsPhoneNumber(txtSoDienThoai.Text))
                {
                    throw new Exception("Hãy nhập vào số điện thoại đúng");
                }
                if(!UserUtilizes.IsValidDay(dateNgaySinh.DateTime.Date))
                {
                    throw new Exception("Hãy nhập vào ngày sinh đúng");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }

            //// Đăng kí tài khoản
            ///

            DangKy(txtUser.Text, txtPass.Text, txtHoTen.Text,
                txtEmail.Text, txtSoDienThoai.Text, txtDiaChi.Text, dateNgaySinh.DateTime);
        }


        public bool DangKy(string maDangNhap, string matKhau, string hoTen, string email, string soDienThoai, string diaChi, DateTime ngaySinh)
        {
            string hashedPassword = Utilizes.UserUtilizes.GetHashString(matKhau);
            ThongTinNguoiDung thongTinNguoiDung = new ThongTinNguoiDung
            {
                MaDangNhapNguoiDung = maDangNhap,
                HoTen = hoTen,
                Email = email,
                SoDienThoai = soDienThoai,
                DiaChi = diaChi,
                ChucVu = "Nhanvien",
                NgaySinh = ngaySinh
            };
            NguoiDung nguoiDung = new NguoiDung
            {
                MaDangNhapNguoiDung = maDangNhap,
                MatKhau = hashedPassword,
                ThongTinNguoiDung = thongTinNguoiDung
            };
            if (Program.ndSql.Register(nguoiDung))
                return true;
            return false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkEditHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditHienMatKhau.Checked == true)
                txtPass.Properties.PasswordChar = char.MinValue;
            else
            {
                txtPass.Properties.PasswordChar = '*';
            }
        }

        private void checkEditHienMatKhauNhapLai_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditHienMatKhauNhapLai.Checked == true)
                txtRePass.Properties.PasswordChar = char.MinValue;
            else
            {
                txtRePass.Properties.PasswordChar = '*';
            }
        }
    }
}