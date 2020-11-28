using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.Models
{
    class SuCosql : connection
    {
        public SuCosql()
        {

        }
        public bool Insert_SuCo(SuCo su)
        {
            string query = "Insert_SuCo";
            string[] para;
            para = new string[4];
            para[0] = "@MaKH";
            para[1] = "@MaSC";
            para[2] = "@DiaDanh";
            para[3] = "@DienTich";

            object[] values;
            values = new object[4];
            values[0] = su.MaKeHoach;
            values[1] = su.MaSC;
            values[2] = su.DiaDanh;
            values[3] = su.DienTich;


            try
            {
                
                int a = Excute_Sql(query, CommandType.StoredProcedure, para, values);
                if (a != 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                DialogResult d;
                d = MessageBox.Show("Thông tin thêm không hợp lệ!");
                return false;
            }
            finally
            {

            }
        }
       
        public bool UpdateSuCo(SuCo su)
        {
            SqlCommand command = new SqlCommand("Update_SuCo", Connection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                command.Parameters.Add(new SqlParameter("@MaKH", SqlDbType.Int, 32, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, su.MaKeHoach));
                command.Parameters.Add(new SqlParameter("@MaSC", SqlDbType.Int, 32, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, su.MaSC));
                command.Parameters.Add(new SqlParameter("@DiaDanh", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, su.DiaDanh));
                command.Parameters.Add(new SqlParameter("@DienTich", SqlDbType.Int, 64, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, su.DienTich));
                Connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Connection.Close();
                command.Dispose();
                throw new Exception("User::UpdatePass::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                command.Dispose();
            }

        }
        public bool DeleteSuCo(SuCo su)
        {
            string query = "Delete_SuCo";
            string[] para;
            para = new string[1];
            para[0] = "@maSC";


            object[] values;
            values = new object[1];
            values[0] = su.MaSC;

            try
            {
                connection connect = new connection();
                int a = Excute_Sql(query, CommandType.StoredProcedure, para, values);
                if (a != 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                DialogResult d;
                d = MessageBox.Show("Thông tin xóa không hợp lệ!");
                return false;
            }
            finally
            {

            }

        }
        public void SelectAllSuCo(DataGridView dataGridView, SearchLookUpEdit searchLookUpEdit)
        {
            connection connect;

            string query = "SelectAllSuCo";
            DataSet dataSet = new DataSet();
            connect = new connection();
            dataSet = connect.FillDataSet(query, CommandType.StoredProcedure);
            dataGridView.DataSource = dataSet.Tables[0];
            searchLookUpEdit.Properties.DataSource = dataSet.Tables[0];
        }


        
    
}
}
