using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DXApplication1.Models
{
    class LoaiQuyenSql : ConnectionDatabase
    {
        #region Methods public
        public List<LoaiQuyen> SelectAll()
        {
            SqlCommand sqlCommand = new SqlCommand("LayThongTinCacLoaiQuyen", Connection);       
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
                throw new Exception("LoaiQuyen::SelectAll::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                sqlCommand.Dispose();
            }

        }
        #endregion

        #region Methods private

        internal void PopulatePlayerFromReader(LoaiQuyen loaiQuyen, IDataReader dataReader)
        {


            loaiQuyen.LoaiQuyenId = dataReader.GetString(dataReader.GetOrdinal(LoaiQuyen.LoaiQuyenFields.LoaiQuyenId.ToString()));

            if (!dataReader.IsDBNull(dataReader.GetOrdinal(LoaiQuyen.LoaiQuyenFields.MoTa.ToString())))
            {
                loaiQuyen.MoTa = dataReader.GetString(dataReader.GetOrdinal(LoaiQuyen.LoaiQuyenFields.MoTa.ToString()));
            }
        }

        internal List<LoaiQuyen> PopulateObjectFromReader(IDataReader data)
        {
            List<LoaiQuyen> list = new List<LoaiQuyen>();
            while (data.Read())
            {
                LoaiQuyen loaiQuyen = new LoaiQuyen();
                PopulatePlayerFromReader(loaiQuyen, data);
                list.Add(loaiQuyen);
            }
            return list;
        }
        #endregion

    }
}
