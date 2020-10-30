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
using DXApplication1.Models;

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
            if(Program.flag_Doituong)
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
                    , int.Parse(textBoxToaDoY.Text), int.Parse(textBoxChieuRongAnh.Text), int.Parse(textBoxChieuDaiAnh.Text));
            }    
            //if (Program.flag) // them don vi
            //{
               
            //}
            //else // chinh sua don vi
            //{
            //    try
            //    {
            //        if (textBoxMoTa.Text == "" || textboxToaDoX.Text == "")
            //        {
            //            throw new Exception("Bạn phải nhập đầy đủ thông tin");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        XtraMessageBox.Show(ex.Message);
            //        return;
            //    }
            //  //  Program.nodeOnMap.ChinhSuaTTDoiTuong(textBoxMaDonVi.Text, textBoxMoTa.Text, textboxToaDoX.Text);
            //}
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadDataInToForm (ThongTinChiTietDoiTuong thongTinChiTietDoiTuong)
        {
            if(thongTinChiTietDoiTuong.MaDoiTuong == 0)
            {
                thongTinChiTietDoiTuong.MaDoiTuong = Program.ThongTinChiTietDoiTuongSql.LayMaDoiTuongLonNhat() + 1;
                Program.flag_Doituong = true;
            }    
            else
            {
                Program.flag_Doituong = false;
            }    
            textBoxMaDoiTuong.Text = thongTinChiTietDoiTuong.MaDoiTuong.ToString();
            textBoxMaDonVi.Text = thongTinChiTietDoiTuong.MaDonVi;
            textBoxMoTa.Text = thongTinChiTietDoiTuong.MoTa;
            textBoxMaKeHoach.Text = thongTinChiTietDoiTuong.MaKeHoach.ToString();
            textboxToaDoX.Text = thongTinChiTietDoiTuong.ToaDoX.ToString();
            textBoxToaDoY.Text = thongTinChiTietDoiTuong.ToaDoY.ToString();
            textBoxChieuRongAnh.Text = thongTinChiTietDoiTuong.ChieuRongAnh.ToString();
            textBoxChieuDaiAnh.Text = thongTinChiTietDoiTuong.ChieuDaiAnh.ToString();
        }

        private void textBoxMaDoiTuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}