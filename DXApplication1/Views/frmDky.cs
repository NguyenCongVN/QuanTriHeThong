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
            if (txtUser.Text == "" || txtPass.Text == "" || txtRePass.Text == "")
                XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
            else if (txtRePass.Text != txtPass.Text)
                XtraMessageBox.Show("Mật khẩu xác nhận không đúng!");
        }
    }
}