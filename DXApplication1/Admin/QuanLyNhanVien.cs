using DXApplication1.Models;
using System.Windows.Forms;
using DXApplication1.Account;
using DevExpress.XtraEditors;

namespace DXApplication1.Admin
{
    public partial class QuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();

        }
        public void QuanLyNhanVien_Load(object sender, System.EventArgs e)
        {
            Program.quanLyNhanVienSql = new QuanLyNhanVienSql();
            Program.quanLyNhanVienSql.getDataDSNV(dataGridViewDSNV, searchLookUpEditDSNV);

        }

        private void buttonThem_Click(object sender, System.EventArgs e)
        {
            int kt = 0;
            foreach (var q in Program.lg.List_Q)
            {
                if (q.QuyenId == "QNTHEMNV")
                {
                    kt = 1;
                    break;
                }
            }
            if (kt == 0)
                XtraMessageBox.Show("Bạn không có quyền thêm nhân viên!!!", "Thông báo");
            else
            {
                Program.dky = new Views.frmDky();
                Program.dky.ShowDialog();
            }    
           
        }

        private void buttonSua_Click(object sender, System.EventArgs e)
        {
            int kt = 0;
            foreach (var q in Program.lg.List_Q)
            {
                if (q.QuyenId == "QNSUANV")
                {
                    kt = 1;
                    break;
                }
            }
            if (kt == 0)
                XtraMessageBox.Show("Bạn không có quyền sửa thông tin!!!", "Thông báo");
            else
            {
                Program.detail_user = new ThongTinNguoiDung();
                Program.detail_userSql.Select_Detail(Program.detail_user, textBoxMaDangNhap.Text);
                Detail_User detail_form = new Detail_User();
                detail_form.SetQuyenSua();
                detail_form.ShowDialog();
            }    
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
            getDataFromDgvIntoTextBox(textBoxChucVu, numrow, "TenChucVu");
            getDataFromDgvIntoTextBox(textBoxDiaChi, numrow, "DiaChi");
            getDataFromDgvIntoTextBox(textBoxEmail, numrow, "Email");
            getDataFromDgvIntoTextBox(textBoxSoDienThoai, numrow, "SoDienThoai");
            // getDataFromDgvIntoTextBox(textBoxNgaySinh, numrow, "NgaySinh");
            
            textBoxNgaySinh.DataBindings.Clear();
            textBoxNgaySinh.DataBindings.Add("Text", dataGridViewDSNV.DataSource, "NgaySinh");
            getDataFromDgvIntoTextBox(textBoxNgayTao, numrow, "NgayTao");
        }

        private void dataGridViewDSNV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewDSNV.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void buttonXoa_Click(object sender, System.EventArgs e)
        {
            int kt = 0;
            foreach (var q in Program.lg.List_Q)
            {
                if (q.QuyenId == "QNXOANV")
                {
                    kt = 1;
                    break;
                }
            }
            if (kt == 0)
                XtraMessageBox.Show("Bạn không có quyền xoá nhân viên!!!", "Thông báo");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá nhân viên này", "Question Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Program.quanLyNhanVienSql = new QuanLyNhanVienSql();
                    Program.quanLyNhanVienSql.XoaNhanVien(textBoxMaDangNhap.Text);
                }
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
            string fieldNamechucVu = "TenChucVu";
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

        private void buttonThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}