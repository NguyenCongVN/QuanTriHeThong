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
    public partial class TTDoiTuong : DevExpress.XtraEditors.XtraForm
    {
        public TTDoiTuong()
        {
            InitializeComponent();
           // this.FormBorderStyle = FormBorderStyle.None;
        }
        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (Program.flag) // them don vi
            {
                try
                {
                    if (textboxToaDoX.Text == "" || textBoxToaDoY.Text == "" || textBoxChieuDaiAnh.Text == "" || textBoxChieuRongAnh.Text == "")
                    {
                        throw new Exception("Bạn phải nhập đầy đủ thông tin");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    return;
                }
                Program.nodeOnMap.TaoTTDoiTuong(textBoxMaDonVi.Text, textBoxMoTa.Text, int.Parse(textBoxMaKeHoach.Text), int.Parse(textboxToaDoX.Text)
                    ,int.Parse(textBoxToaDoY.Text),int.Parse(textBoxChieuRongAnh.Text),int.Parse(textBoxChieuDaiAnh.Text));
            }
            else // chinh sua don vi
            {
                try
                {
                    if (textBoxMoTa.Text == "" || textboxToaDoX.Text == "")
                    {
                        throw new Exception("Bạn phải nhập đầy đủ thông tin");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    return;
                }
              //  Program.nodeOnMap.ChinhSuaTTDoiTuong(textBoxMaDonVi.Text, textBoxMoTa.Text, textboxToaDoX.Text);
            }
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}