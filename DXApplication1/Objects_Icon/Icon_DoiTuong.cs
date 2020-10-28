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
    public partial class Icon_DoiTuong : DevExpress.XtraEditors.XtraForm
    {
        public Icon_DoiTuong()
        {
            InitializeComponent();
        }

        private void simpleButtonChonAnh_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                textBoxAnh.Text = fileName;
                
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if(Program.flag) // them don vi
            {
                try
                {
                    if (textBoxMaDonVi.Text == "" || textBoxTenDonVi.Text == "" || textBoxAnh.Text == "")
                    {
                        throw new Exception("Bạn phải nhập đầy đủ thông tin");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    return;
                }
                Program.nodeOnMap.AddDonVi(textBoxMaDonVi.Text, textBoxTenDonVi.Text, textBoxAnh.Text, Program.getMa);
            }   
            else // chinh sua don vi
            {
                try
                {
                    if (textBoxTenDonVi.Text == "" || textBoxAnh.Text == "")
                    {
                        throw new Exception("Bạn phải nhập đầy đủ thông tin");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    return;
                }
                Program.nodeOnMap.ChinhSuaDonVi(textBoxMaDonVi.Text, textBoxTenDonVi.Text, textBoxAnh.Text);
            }    
           
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Icon_DoiTuong_Load(object sender, EventArgs e)
        {
            if(Program.flag) // them don vị
            {
                buttonLuu.Text = "Thêm";
                textBoxMaDonVi.ReadOnly = false;
            }   
            else // chinh sua don vi
            {
                buttonLuu.Text = "Lưu";
                textBoxMaDonVi.ReadOnly = true;

            }    
        }
    }
}