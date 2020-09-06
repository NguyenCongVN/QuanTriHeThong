using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication1.Account
{
    public partial class Detail_User : DevExpress.XtraEditors.XtraForm
    {
        public Detail_User()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            txtDiaChi.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtHoTen.ReadOnly = false;
            txtSoDienThoai.ReadOnly = false;
            dateNgaySinh.ReadOnly = false;
            btnXacnhan.Visible = true;
            if (Program.lg.check_CV == 1)
            {
                txtChucvu.ReadOnly = false;
            }
  
        }

        private void grpCtrl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Detail_User_Load(object sender, EventArgs e)
        {
            txtUser.Text = Program.detail_user.MaDangNhapNguoiDung;
            txtHoTen.Text = Program.detail_user.HoTen;
            txtEmail.Text = Program.detail_user.Email;
            txtDiaChi.Text = Program.detail_user.DiaChi;
            txtSoDienThoai.Text = Program.detail_user.SoDienThoai;
            txtChucvu.Text = Program.detail_user.ChucVu;
            dateNgaySinh.DateTime = Program.detail_user.NgaySinh;
            dateNgayTao.DateTime = Program.detail_user.NgayTao;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ họ tên và số điện thoại!!!", "ERROR???");
            }
            else
            {
                Program.detail_user = new Models.ThongTinNguoiDung();
                Program.detail_user.MaDangNhapNguoiDung = txtUser.Text;
                Program.detail_user.HoTen = txtHoTen.Text;
                Program.detail_user.NgaySinh = dateNgaySinh.DateTime.Date;
                Program.detail_user.SoDienThoai = txtSoDienThoai.Text;
                Program.detail_user.DiaChi = txtDiaChi.Text;
                Program.detail_user.ChucVu = txtChucvu.Text;
                Program.detail_user.NgayTao = dateNgayTao.DateTime;
                Program.detail_user.Email = txtEmail.Text;
                if (Program.detail_userSql.Update_Detail(Program.detail_user) == true)
                    MessageBox.Show("Cập nhật thành công");
                else
                    MessageBox.Show("Thông tin không hợp lệ!!!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}