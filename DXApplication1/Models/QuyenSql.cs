using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DXApplication1.Models
{
    class QuyenSql: ConnectionDatabase
    {
        #region Methods public
        public List<Quyen> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand("LayThongTinCacQuyen", Connection);
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
                throw new Exception("Quyen::SelectAll::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                sqlCommand.Dispose();
            }

        }
        #endregion

        #region Methods private

        internal void PopulatePlayerFromReader(Quyen quyen, IDataReader dataReader)
        {
            quyen.QuyenId = dataReader.GetString(dataReader.GetOrdinal(Quyen.QuyenFields.QuyenId.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Quyen.QuyenFields.MoTa.ToString())))
            {
                quyen.MoTa = dataReader.GetString(dataReader.GetOrdinal(Quyen.QuyenFields.MoTa.ToString()));
            }
            if (!dataReader.IsDBNull(dataReader.GetOrdinal(Quyen.QuyenFields.LoaiQuyenId.ToString())))
            {
                quyen.LoaiQuyenId = dataReader.GetString(dataReader.GetOrdinal(Quyen.QuyenFields.LoaiQuyenId.ToString()));
            }
        }

        internal List<Quyen> PopulateObjectFromReader(IDataReader data)
        {
            List<Quyen> list = new List<Quyen>();
            while (data.Read())
            {
                Quyen quyen = new Quyen();
                PopulatePlayerFromReader(quyen, data);
                list.Add(quyen);
            }
            return list;
        }
        #endregion
    }
}
