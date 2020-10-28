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
    class connection: ConnectionDatabase
    {
        public DataSet FillDataSet(string strQuery, CommandType cmdtype)
        {
            DataSet ds = new DataSet();
            SqlCommand sqlCommand = new SqlCommand(strQuery,Connection);
            sqlCommand.CommandType = cmdtype;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                da.Fill(ds);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ds;
        }
        public int Excute_Sql(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            Connection.Open();
            SqlCommand sqlCommand = new SqlCommand(strQuery, Connection);
            int efftectRecord = 0;
            sqlCommand.CommandType = cmdtype;
            SqlParameter sqlpara;
            for (int i = 0; i < para.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = para[i];
                sqlpara.SqlValue = values[i];
                sqlCommand.Parameters.Add(sqlpara);
            }
            try
            {
                efftectRecord = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            Connection.Close();
            return efftectRecord;
        }

        public bool Excute_Sql_Node(string strQuery, CommandType cmdtype, string[] para, object[] values, SqlInfoMessageEventHandler result)
        {
           
            SqlCommand sqlCommand = new SqlCommand(strQuery, Connection);
            sqlCommand.CommandType = cmdtype;
            SqlParameter sqlpara;
            try
            {   
                for (int i = 0; i < para.Length; i++)
                {
                    sqlpara = new SqlParameter();
                    sqlpara.ParameterName = para[i];
                    sqlpara.SqlValue = values[i];
                    sqlCommand.Parameters.Add(sqlpara);
                }
                Connection.Open();
                Connection.InfoMessage += result;
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra");
                return false;
            }
            finally
            {
                Connection.InfoMessage -= result;
                Connection.Close();
                sqlCommand.Dispose();
            }
        }




        public DataSet FillDataSet(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            DataSet ds = new DataSet();
            SqlCommand sqlCommand = new SqlCommand(strQuery,Connection);
            sqlCommand.CommandType = cmdtype;

            try
            {
                SqlParameter sqlpara;
                for (int i = 0; i < para.Length; i++)
                {
                    sqlpara = new SqlParameter();
                    sqlpara.ParameterName = para[i];
                    sqlpara.SqlValue = values[i];

                    sqlCommand.Parameters.Add(sqlpara);
                }

                SqlDataAdapter sqlda = new SqlDataAdapter(sqlCommand);
                sqlda.Fill(ds);
                sqlda.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ds;
        }






    }
}
