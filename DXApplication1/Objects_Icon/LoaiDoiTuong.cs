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

namespace DXApplication1.Objects_Icon
{
    public partial class LoaiDoiTuong : DevExpress.XtraEditors.XtraForm
    {
        public LoaiDoiTuong()
        {
            InitializeComponent();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if(Program.flag) // them binh chung
            {
                try
                {
                    if (textBoxMaBinhChung.Text == "" || textBoxTenBinhChung.Text == "")
                    {
                        throw new Exception("Bạn phải nhập đầy đủ thông tin");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    return;
                }
                Program.nodeOnMap.AddBinhChung(textBoxMaBinhChung.Text, textBoxTenBinhChung.Text);
            }    
            else // chinh sua binh chung
            {
                try
                {
                    if (textBoxTenBinhChung.Text == "")
                    {
                        throw new Exception("Bạn phải nhập đầy đủ thông tin");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    return;
                }
                Program.nodeOnMap.ChinhSuaBinhChung(textBoxMaBinhChung.Text, textBoxTenBinhChung.Text);

            }    
                      
        }
        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoaiDoiTuong_Load(object sender, EventArgs e)
        {
            if(Program.flag)
            {
                buttonLuu.Text = "Thêm";
                textBoxMaBinhChung.ReadOnly = false;
            }    
            else
            {
                buttonLuu.Text = "Lưu";
                textBoxMaBinhChung.ReadOnly = true;
            }
        }
    }
}