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



    }
}
