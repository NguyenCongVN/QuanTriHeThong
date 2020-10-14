using DevExpress.XtraEditors;
using DXApplication1.Models;
using DXApplication1.Utilizes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        NguoiDung userLogin;
        public  int check_CV = 0;
         List<Quyen> list_Q = new List<Quyen>();
        internal List<Quyen> List_Q { get => list_Q; set => list_Q = value; }
        internal NguoiDung UserLogin { get => userLogin; set => userLogin = value; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_MouseMove(object sender, MouseEventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.ForestGreen;
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.Peru;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.Peru;
        }

        private void btnCancel_MouseMove(object sender, MouseEventArgs e)
        {
            SimpleButton button = sender as SimpleButton;
            button.BackColor = Color.ForestGreen;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
                XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
            else
            {
                if (CheckLogin(txtUser.Text, txtPass.Text) == 1)
                {
                    if(checkEditNhoMatKhau.Checked == true)
                    {
                        Properties.Settings.Default.UserName = txtUser.Text;
                        Properties.Settings.Default.Password = txtPass.Text;
                        Properties.Settings.Default.Save();
                    }
                    if (checkEditNhoMatKhau.Checked == false)
                    {
                        Properties.Settings.Default.UserName = "";
                        Properties.Settings.Default.Password = "";
                        Properties.Settings.Default.Save();
                    }
                    this.Hide();
                    Program.detail_user = new ThongTinNguoiDung();

                    Program.detail_userSql.Select_Detail(Program.detail_user, userLogin.MaDangNhapNguoiDung);
                    string maChucVu = Program.chucvuSql.GetIdByName(Program.detail_user.ChucVu);
                    if(maChucVu == "Admin")
                    {
                        check_CV = 1;
                        Program.main_admin = new FrmMain_Admin();
                        Program.main_admin.IsMdiContainer = true;
                        Program.main_admin.Show();
                    }
                    else
                    {
                        check_CV = 0;
                        Program.main = new FrmMain();
                        Program.main.IsMdiContainer = true;
                        Program.main.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập sai!", "Error???");
                }

            }
        }
        int CheckLogin(string _name, string _pass)
        {
            int check = 0;
            List<NguoiDung> list = new List<NguoiDung>();
            list = Program.ndSql.SelectAll();
            foreach (var value in list)
            {

                if (value.MaDangNhapNguoiDung == _name && UserUtilizes.GetHashString(_pass) == value.MatKhau)
                {
                    check = 1;
                    this.userLogin = new NguoiDung();
                    this.userLogin.MaDangNhapNguoiDung = value.MaDangNhapNguoiDung;
                    this.userLogin.MatKhau = UserUtilizes.GetHashString(_pass);
                    list_Q = Program.quyenSql.Select_Quyen_chucvu(UserLogin.MaDangNhapNguoiDung);
                    break;
                }
            }
            return check;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.UserName != string.Empty)
            {
                txtUser.Text = Properties.Settings.Default.UserName;
                txtPass.Text = Properties.Settings.Default.Password;
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkEditHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEditHienMatKhau.Checked == true)
               
                txtPass.Properties.UseSystemPasswordChar = false;
            else
            {
               txtPass.Properties.UseSystemPasswordChar = true;
              
            }
        }

        private void checkEditNhoMatKhau_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}