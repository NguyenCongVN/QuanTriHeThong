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
using DXApplication1.Utilizes;
using System.Data.SqlClient;
using DXApplication1.Models;

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
            try
            {
                if (txtUser.Text == "" || txtPass.Text == "" || txtRePass.Text == "" || txtDiaChi.Text == ""
                    || txtEmail.Text == "" || txtHoTen.Text == "" || txtSoDienThoai.Text == "")
                 throw new Exception("Bạn phải nhập đầy đủ thông tin!");
                if(txtRePass.Text != txtPass.Text)
                 throw new Exception("Mật khẩu xác nhận không đúng!");
                if(!UserUtilizes.IsValidEmail(txtEmail.Text))
                {
                    throw new Exception("Hãy nhập một email hợp lệ");
                }

                if(!UserUtilizes.IsPhoneNumber(txtSoDienThoai.Text))
                {
                    throw new Exception("Hãy nhập vào số điện thoại đúng");
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}