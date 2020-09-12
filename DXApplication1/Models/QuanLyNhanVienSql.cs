using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace DXApplication1.Models
{
    class QuanLyNhanVienSql: ConnectionDatabase
    {
        connection connect;
        public void getDataDSNV(DataGridView dataGridView, SearchLookUpEdit searchLookUpEdit)
        {
            
            string query = "LayThongTinNhanVien";
            DataSet dataSet = new DataSet();
            connect = new connection();
            dataSet = connect.FillDataSet(query, CommandType.StoredProcedure);
            dataGridView.DataSource = dataSet.Tables[0];
            searchLookUpEdit.Properties.DataSource = dataSet.Tables[0];

        }

        public void XoaNhanVien(string madangnhap)
        {
            string query = "XoaNhanVien";
            string[] para = { "@maDangNhap" };
            string[] value = { madangnhap };
            connect = new connection();
            int result = connect.Excute_Sql(query, CommandType.StoredProcedure, para, value);
            if (result > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xoa nhan vien thanh cong", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Program.quanLyNhanVien.QuanLyNhanVien_Load(null,null);
                }
            }
        }
    }
}
