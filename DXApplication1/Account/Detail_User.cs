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
using DXApplication1.Utilizes;

namespace DXApplication1.Account
{
    public partial class Detail_User : DevExpress.XtraEditors.XtraForm
    {
        List<Chucvu> chucvus = new List<Chucvu>();
        ChucvuSql chucVuSql = new ChucvuSql();
        public Detail_User()
        {
            InitializeComponent();
            comboBoxEditChucVu.Properties.Items.Clear();
            chucvus = chucVuSql.LayCacChucVu("LayTatCaMaChucVuTruAdmin");
            foreach (Chucvu chucvu in chucvus)
            {
                ComboBoxItemPhanQuyen item = new ComboBoxItemPhanQuyen { ChucVu = chucvu };
                comboBoxEditChucVu.Properties.Items.Add(item);
            }
        }

        public void SetQuyenSua()
        {
            btnChange.Visible = false;
            txtDiaChi.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtHoTen.ReadOnly = false;
            txtSoDienThoai.ReadOnly = false;
            dateNgaySinh.ReadOnly = false;
            comboBoxEditChucVu.ReadOnly = false;
            btnXacnhan.Visible = true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int kt = 0;
            foreach (var q in Program.lg.List_Q)
            {
                if (q.QuyenId == "QNSUATTCN")
                {
                    txtDiaChi.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                    txtHoTen.ReadOnly = false;
                    txtSoDienThoai.ReadOnly = false;
                    dateNgaySinh.ReadOnly = false;
                    btnXacnhan.Visible = true;
                    kt = 1;
                    break;
                }
            }
            if (kt == 0)
                XtraMessageBox.Show("Bạn không có quyền sửa thông tin!!!", "Thông báo");
        }

        private void grpCtrl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Detail_User_Load(object sender, EventArgs e)
        {
            txtUser.Text = Program.detail_user.MaDangNhapNguoiDung;
            txtHoTen.Text = Program.detail_user.HoTen;
            txtEmail.Text = Program.detail_user.Email;
            txtDiaChi.Text = Program.detail_user.DiaChi;
            txtSoDienThoai.Text = Program.detail_user.SoDienThoai;
            comboBoxEditChucVu.Text = Program.detail_user.ChucVu;
            dateNgaySinh.DateTime = Program.detail_user.NgaySinh;
            dateNgayTao.DateTime = Program.detail_user.NgayTao;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtSoDienThoai.Text == ""|| comboBoxEditChucVu.Text == null)
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin!!!", "ERROR???");
            }
            else
            {
                Program.detail_user = new Models.ThongTinNguoiDung();
                Program.detail_user.MaDangNhapNguoiDung = txtUser.Text;
                Program.detail_user.HoTen = txtHoTen.Text;
                Program.detail_user.NgaySinh = dateNgaySinh.DateTime.Date;
                Program.detail_user.SoDienThoai = txtSoDienThoai.Text;
                Program.detail_user.DiaChi = txtDiaChi.Text;
                Program.detail_user.ChucVu = comboBoxEditChucVu.Text;
                Program.detail_user.NgayTao = dateNgayTao.DateTime;
                Program.detail_user.Email = txtEmail.Text;
                if (Program.detail_userSql.Update_Detail(Program.detail_user) == true)
                {
                    DialogResult result = MessageBox.Show("Cập nhật thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(result == DialogResult.OK)
                    {
                        Program.quanLyNhanVien.QuanLyNhanVien_Load(sender, e);
                    }
                }    

                else
                    MessageBox.Show("Thông tin không hợp lệ!!!");
            }
        }
    }
}