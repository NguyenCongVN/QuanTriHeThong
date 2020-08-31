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
    public partial class UpdatePass : DevExpress.XtraEditors.XtraForm
    {
        public UpdatePass()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtReNewPass.Text == "")
                XtraMessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
            else if (txtReNewPass.Text != txtNewPass.Text)
                XtraMessageBox.Show("Mật khẩu xác nhận không đúng!");

        }
    }
}