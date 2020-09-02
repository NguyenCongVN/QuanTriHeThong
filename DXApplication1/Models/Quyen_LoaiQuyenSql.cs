using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DXApplication1.Models
{
    class Quyen_LoaiQuyenSql:ConnectionDatabase
    {
        public List<Quyen_LoaiQuyen> GetQuyen_LoaiQuyen(string chucVu)
        {
            SqlCommand command = new SqlCommand("dbo.LayQuyenTheoChucVu", Connection);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
              
                command.Parameters.Add(new SqlParameter("@chucvu", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, chucVu));
                Connection.Open();

                IDataReader dataReader = command.ExecuteReader();
                return PopulateObjectFromReader(dataReader);
              
            }
            catch (SqlException ex)
            {
                Connection.Close();
                command.Dispose();
                throw new Exception("Quyen_LoaiQuyen::GetInfo::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                command.Dispose();
            }
        }
        internal void PopulatePlayerFromReader(Quyen_LoaiQuyen q_lq, IDataReader data)
        {
            q_lq.LoaiQuyen = data.GetString(data.GetOrdinal(Quyen_LoaiQuyen.Quyen_LoaiQuyenFeilds.LoaiQuyen.ToString()));
            if(!data.IsDBNull(data.GetOrdinal(Quyen_LoaiQuyen.Quyen_LoaiQuyenFeilds.Quyen.ToString())))
            {
                q_lq.Quyen = data.GetString(data.GetOrdinal(Quyen_LoaiQuyen.Quyen_LoaiQuyenFeilds.Quyen.ToString()));
            }
          
        }


        internal List<Quyen_LoaiQuyen> PopulateObjectFromReader(IDataReader data)
        {
            List<Quyen_LoaiQuyen> list = new List<Quyen_LoaiQuyen>();
            while (data.Read())
            {
                Quyen_LoaiQuyen q_lq = new Quyen_LoaiQuyen();
                PopulatePlayerFromReader(q_lq, data);
                list.Add(q_lq);
            }
            return list;
        }


    }
}
