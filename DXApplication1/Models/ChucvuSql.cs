using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DXApplication1.Models
{
    class ChucvuSql:ConnectionDatabase
    {
        public List<Chucvu> LayCacChucVu()
        {
            SqlCommand sqlCommand = new SqlCommand("LayTatCaMaChucVu", Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            List<Chucvu> chucvus = new List<Chucvu>();
            // Use connection object of base class

            try
            {
                Connection.Open();
                using(SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    foreach(DataRow row in table.Rows)
                    {
                        chucvus.Add(new Chucvu(row[0].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ChucVu::GetName::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                sqlCommand.Dispose();
            }
            return chucvus;
        }


        // Lấy Tên Chức Vụ Theo Mã Chức Vụ

        public string GetNameById(string Id)
        {
            SqlCommand sqlCommand = new SqlCommand("LayTenChucVuTheoMaChucVu", Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@maChucVu", Id);
            string name = string.Empty;
            try
            {
                Connection.Open();
                name = sqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("ChucVu::GetName::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                sqlCommand.Dispose();
            }
            return name;
        }


        /// Lấy mã các quyền theo chức vụ
        /// 

        public List<string> LayCacQuyenBangId(string Id)
        {
            SqlCommand sqlCommand = new SqlCommand("LayQuyenTheoMaChucVu", Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@maChucVu", Id);
            List<string> maQuyens = new List<string>();
            try
            {
                Connection.Open();
                using(SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    foreach(DataRow row in table.Rows)
                    {
                        maQuyens.Add(row[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ChucVu::GetName::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                sqlCommand.Dispose();
            }
            return maQuyens;
        }


        //


        //public 
       

    }
}
