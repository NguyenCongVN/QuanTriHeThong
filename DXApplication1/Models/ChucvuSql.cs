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
        #region Methods public
        public List<Chucvu> GetName()
        {
            SqlCommand sqlCommand = new SqlCommand("LayTatCaTenChucVu", Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            // Use connection object of base class

            try
            {

                Connection.Open();

                IDataReader dataReader = sqlCommand.ExecuteReader();

                return PopulateObjectFromReader(dataReader);

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

        }

        //public 
        #endregion

        #region Methods private

        internal void PopulatePlayerFromReader(Chucvu chucVu, IDataReader dataReader)
        {
            chucVu.TenChucVu = dataReader.GetString(dataReader.GetOrdinal(Chucvu.ChucVuFeilds.TenChucVu.ToString()));
        }

        internal List<Chucvu> PopulateObjectFromReader(IDataReader data)
        {
            List<Chucvu> list = new List<Chucvu>();
            while (data.Read())
            {
                Chucvu chucVu = new Chucvu();
                PopulatePlayerFromReader(chucVu, data);
                list.Add(chucVu);
            }
            return list;
        }
        #endregion
    }
}
