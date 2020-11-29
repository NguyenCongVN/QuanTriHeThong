using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace DXApplication1.Models
{
    class connection: ConnectionDatabase
    {
        public static string sqlcon = ConfigurationManager.AppSettings["MainConnection"];
        public static SqlConnection Getconnection()
        {
            SqlConnection con = new SqlConnection(sqlcon);
            return con;
        }

        public static void open()
        {
            try
            {
                if (Getconnection().State == ConnectionState.Closed)
                    Getconnection().Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        public static void close()
        {
            try
            {
                if (Getconnection().State == ConnectionState.Open)
                    Getconnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
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
        public static int Excute_Sql(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            int efftectRecord = 0;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = strQuery;
            sqlcmd.Connection = conn;
            sqlcmd.CommandType = cmdtype;

            SqlParameter sqlpara;
            for (int i = 0; i < para.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = para[i];
                sqlpara.SqlValue = values[i];
                sqlcmd.Parameters.Add(sqlpara);
            }
            try
            {
                efftectRecord = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
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
