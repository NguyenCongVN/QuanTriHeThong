using DXApplication1.Models;
using System.Windows.Forms;
using DXApplication1.Account;

namespace DXApplication1.Admin
{
    public partial class QuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public BindingSource bindingSource = new BindingSource();
        public QuanLyNhanVien()
        {
          //  ThongTinNguoiDung thongTinNguoiDung = Program.detail_user;
            InitializeComponent();
            //textBoxMaDangNhap.Text = thongTinNguoiDung.MaDangNhapNguoiDung;
            //textBoxHoTen.Text = thongTinNguoiDung.HoTen;
            //textBoxEmail.Text = thongTinNguoiDung.Email;
            //textBoxDiaChi.Text = thongTinNguoiDung.DiaChi;
            //textBoxSoDienThoai.Text = thongTinNguoiDung.SoDienThoai;
            //textBoxChucVu.Text = thongTinNguoiDung.ChucVu;
            //dateEditNgaySinh.DateTime = thongTinNguoiDung.NgaySinh;
            //dateEditNgayTaoTaiKhoan.DateTime = thongTinNguoiDung.NgayTao;
        }

        private void buttonThem_Click(object sender, System.EventArgs e)
        {
            Program.dky = new Views.frmDky();
            Program.dky.Show();
        }

        private void buttonSua_Click(object sender, System.EventArgs e)
        {
            Program.detail_user = new ThongTinNguoiDung();
            Program.detail_userSql.Select_Detail(Program.detail_user, textBoxMaDangNhap.Text);
            Detail_User detail_form = new Detail_User();
            detail_form.Show();
        }

        public void QuanLyNhanVien_Load(object sender, System.EventArgs e)
        {
            Program.quanLyNhanVienSql = new QuanLyNhanVienSql();
            Program.quanLyNhanVienSql.getDataDSNV(dataGridViewDSNV);
           // int s = dataGridViewDSNV.Rows.Count;
        }

        public void update_DatagridDSNV()
        {
            
            //Program.quanLyNhanVienSql = new QuanLyNhanVienSql();
            //Program.quanLyNhanVienSql.getDataDSNV(dataGridViewDSNV);
            //int s = dataGridViewDSNV.Rows.Count;
        }

        private void getDataFromDgvIntoTextBox(TextBox tb, int row, string column)
        {
            tb.Text = dataGridViewDSNV.Rows[row].Cells[column].Value.ToString(); //doi cho nay thanh curren row xem sao 
        }

        private void dataGridViewDSNV_CellEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            getDataFromDgvIntoTextBox(textBoxMaDangNhap, numrow, "MaDangNhapNguoiDung");
            getDataFromDgvIntoTextBox(textBoxHoTen, numrow, "HoTen");
            getDataFromDgvIntoTextBox(textBoxChucVu, numrow, "MaChucVu");
            getDataFromDgvIntoTextBox(textBoxDiaChi, numrow, "DiaChi");
            getDataFromDgvIntoTextBox(textBoxEmail, numrow, "Email");
            getDataFromDgvIntoTextBox(textBoxSoDienThoai, numrow, "SoDienThoai");
            getDataFromDgvIntoTextBox(textBoxNgaySinh, numrow, "NgaySinh");
            getDataFromDgvIntoTextBox(textBoxNgayTao, numrow, "NgayTao");
        }

        private void dataGridViewDSNV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewDSNV.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void buttonXoa_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá nhân viên này", "Question Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {

            }    

        }
    }
}