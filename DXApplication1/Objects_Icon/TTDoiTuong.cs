using DevExpress.XtraEditors;
using DXApplication1.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DXApplication1.Objects_Icon
{
    public partial class TTDoiTuong : DevExpress.XtraEditors.XtraForm
    {
        public DoiTuong DoiTuong { get; set; }
        public TTDoiTuong(DoiTuong doiTuong)
        {
            InitializeComponent();
            this.DoiTuong = doiTuong;
            this.textBoxTenDoiTuong.Text = DoiTuong.ThongTinChiTietDoiTuong.TenDoiTuong;
            this.textBoxTenDonVi.Text = Program.ThongTinChiTietDoiTuongSql.LayTenDonViTuMa(DoiTuong.ThongTinChiTietDoiTuong.MaDonVi);
            this.textBoxMoTa.Text = DoiTuong.ThongTinChiTietDoiTuong.MoTa;
            this.textboxToaDoX.Text = DoiTuong.ThongTinChiTietDoiTuong.ToaDoX.ToString();
            this.textBoxToaDoY.Text = DoiTuong.ThongTinChiTietDoiTuong.ToaDoY.ToString();
            this.textBoxChieuNgang.Text = DoiTuong.ThongTinChiTietDoiTuong.ChieuNgang.ToString();
            this.textBoxChieuDoc.Text = DoiTuong.ThongTinChiTietDoiTuong.ChieuDoc.ToString();
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
            int toaDoX, toaDoY, chieuNgang, chieuDoc;
            try
            {
                if (textboxToaDoX.Text == "" || textBoxToaDoY.Text == ""
                    || textboxToaDoX.Text == "" || textBoxToaDoY.Text == ""
                    || textBoxTenDoiTuong.Text == "" || textBoxChieuNgang.Text == "" || textBoxChieuDoc.Text == "")
                {
                    throw new Exception("Bạn phải nhập đầy đủ thông tin");
                }

                if (!int.TryParse(textboxToaDoX.Text, out toaDoX) || !int.TryParse(textBoxToaDoY.Text, out toaDoY) || !int.TryParse(textBoxChieuNgang.Text, out chieuNgang)
                    || !int.TryParse(textBoxChieuDoc.Text, out chieuDoc))
                {
                    throw new Exception("Hãy nhập vào thông tin chính xác");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }
            DoiTuong.ThongTinChiTietDoiTuong.ToaDoX = toaDoX;
            DoiTuong.ThongTinChiTietDoiTuong.ToaDoY = toaDoY;
            DoiTuong.ThongTinChiTietDoiTuong.ChieuDoc = chieuDoc;
            DoiTuong.ThongTinChiTietDoiTuong.ChieuNgang = chieuNgang;
            DoiTuong.Picture.Image = new Bitmap(DoiTuong.InitImage ,DoiTuong.ThongTinChiTietDoiTuong.ChieuNgang ,
                     DoiTuong.ThongTinChiTietDoiTuong.ChieuDoc);
            DoiTuong.ThongTinChiTietDoiTuong.TenDoiTuong = textBoxTenDoiTuong.Text;
            DoiTuong.ThongTinChiTietDoiTuong.MoTa = textBoxMoTa.Text;
            var list = Program.frm_Map.listUpdate.FindAll(c => c.ThongTinChiTietDoiTuong.MaDoiTuong == this.DoiTuong.ThongTinChiTietDoiTuong.MaDoiTuong);
            if (list.Count != 0)
            {
                foreach (var doiTuong in list)
                {
                    doiTuong.ThongTinChiTietDoiTuong.ToaDoX = toaDoX;
                    doiTuong.ThongTinChiTietDoiTuong.ToaDoY = toaDoY;
                    doiTuong.ThongTinChiTietDoiTuong.ChieuDoc = chieuDoc;
                    doiTuong.ThongTinChiTietDoiTuong.ChieuNgang = chieuNgang;
                    doiTuong.ThongTinChiTietDoiTuong.MoTa = textBoxMoTa.Text;
                    doiTuong.ThongTinChiTietDoiTuong.TenDoiTuong = textBoxTenDoiTuong.Text;
                }
            }
            else
            {
                Program.frm_Map.listUpdate.Add(DoiTuong);
            }
            XtraMessageBox.Show("Sửa Thành Công");
        }
        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void simpleButtonChinhSua_Click(object sender, EventArgs e)
        {
            textBoxTenDoiTuong.ReadOnly = false;
            textBoxMoTa.ReadOnly = false;
            textBoxToaDoY.ReadOnly = false;
            textboxToaDoX.ReadOnly = false;
            textBoxChieuDoc.ReadOnly = false;
            textBoxChieuNgang.ReadOnly = false;
        }
    }
}