using DevExpress.XtraEditors;
using DXApplication1.Models;
using System;

namespace DXApplication1.Account
{
    public partial class UpdatePass : DevExpress.XtraEditors.XtraForm
    {
        NguoiDung nd = new NguoiDung();


        public UpdatePass()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtReNewPass.Text == "")
                XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!", "Error???");
            else if (txtReNewPass.Text != txtNewPass.Text)
                XtraMessageBox.Show("Mật khẩu xác nhận không đúng!", "Error???");
            else if (Program.lg.UserLogin.MatKhau != txtOldPass.Text)
            {
                XtraMessageBox.Show("Mật khẩu cũ không đúng!", "Error???");

            }
            else
            {
                if (Program.ndSql.UpdatePass(Program.lg.UserLogin, txtNewPass.Text) == true)
                    XtraMessageBox.Show("Đổi mật khẩu thành công!");

            }
        }

        private void UpdatePass_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}