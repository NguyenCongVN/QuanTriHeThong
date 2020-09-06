using DXApplication1.Models;
using System.Windows.Forms;
using DXApplication1.Account;

namespace DXApplication1.Admin
{
    public partial class QuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
           
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
            Program.quanLyNhanVienSql.getDataDSNV(dataGridViewDSNV, searchLookUpEditDSNV);
          
        }
        private void getDataFromDgvIntoTextBox(TextBox tb, int row, string column)
        {
            tb.Text = dataGridViewDSNV.Rows[row].Cells[column].Value.ToString();  
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
                Program.quanLyNhanVienSql = new QuanLyNhanVienSql();
                Program.quanLyNhanVienSql.XoaNhanVien(textBoxMaDangNhap.Text);
            }    

        }

        private void searchLookUpEditDSNV_EditValueChanged(object sender, System.EventArgs e)
        {
            searchLookUpEditDSNV.Text = "";
            var view = searchLookUpEditDSNV.Properties.View;
            int row = view.FocusedRowHandle;
            string fieldNamemaNhanVien = "MaDangNhapNguoiDung";
            string fieldNamehoTen = "HoTen";
            string fieldNamengaySinh = "NgaySinh";
            string fieldNamesoDienThoai = "SoDienThoai";
            string fieldNameEmail = "Email";
            string fieldNamediaChi = "DiaChi";
            string fieldNamechucVu = "MaChucVu";
            string fieldNamengayTao = "NgayTao";

            object valuemaNhanVien = view.GetRowCellValue(row, fieldNamemaNhanVien);
            object valuehoTen = view.GetRowCellValue(row, fieldNamehoTen);
            object valuengaySinh = view.GetRowCellValue(row, fieldNamengaySinh);
            object valuesoDienThoai = view.GetRowCellValue(row, fieldNamesoDienThoai);
            object valueEmail = view.GetRowCellValue(row, fieldNameEmail);
            object valuediaChi = view.GetRowCellValue(row, fieldNamediaChi);
            object valuechucVu = view.GetRowCellValue(row, fieldNamechucVu);
            object valuengayTao = view.GetRowCellValue(row, fieldNamengayTao);

            textBoxMaDangNhap.Text = valuemaNhanVien.ToString();
            textBoxHoTen.Text = valuehoTen.ToString();
            textBoxNgaySinh.Text = valuengaySinh.ToString();
            textBoxSoDienThoai.Text = valuesoDienThoai.ToString();
            textBoxEmail.Text = valueEmail.ToString();
            textBoxDiaChi.Text = valuediaChi.ToString();
            textBoxChucVu.Text = valuechucVu.ToString();
            textBoxNgayTao.Text = valuengayTao.ToString();
        }
    }
}