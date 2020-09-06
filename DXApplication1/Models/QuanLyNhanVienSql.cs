using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace DXApplication1.Models
{
    class QuanLyNhanVienSql: ConnectionDatabase
    {
        public void getDataDSNV(DataGridView dataGridView)
        {
            
            string query = "LayThongTinNhanVien";
            DataSet dataSet = new DataSet();
            connection connect = new connection();
            dataSet = connect.FillDataSet(query, CommandType.StoredProcedure);
            dataGridView.DataSource = dataSet.Tables[0];

        }

        public void XoaNhanVien()
        {

        }
    }
}
