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

namespace DXApplication1.Admin
{
    public partial class AddChucVu : DevExpress.XtraEditors.XtraForm
    {
        public AddChucVu()
        {
            InitializeComponent();
        }

        #region Events
        private void btnNew_Click(object sender, EventArgs e)
        {
            textBoxTenChucVu.Text = null;
            textBoxMaChucVu.Text = null;
           
        }
      
        private void buttonThem_Click(object sender, EventArgs e)
        {
            //bat loi nhap thong tin
            try
            {
                if (textBoxMaChucVu.Text == "" || textBoxTenChucVu.Text == "")
                    throw new Exception("Bạn phải nhập đầy đủ thông tin!");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }

            //// Them chuc vu
            ///
            Program.chucvuSql.ThemChucVu(textBoxMaChucVu.Text, textBoxTenChucVu.Text);
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}