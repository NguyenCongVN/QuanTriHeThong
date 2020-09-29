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
    public partial class SuaChucVu : DevExpress.XtraEditors.XtraForm
    {
        public SuaChucVu()
        {
            InitializeComponent();
        }

        private void buttonLuuthaydoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTenChucVuMoi.Text == "")
                    throw new Exception("Bạn phải nhập đầy đủ thông tin!");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }

           
            Program.chucvuSql.SuaTenChucVu(textBoxTenChucVuCu.Text, textBoxTenChucVuMoi.Text);
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaChucVu_Load(object sender, EventArgs e)
        {
            
            textBoxTenChucVuCu.Text = Program.cvu.TenChucVu;
        }
    }
}