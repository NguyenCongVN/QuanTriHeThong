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
    class NguoiDungSql : ConnectionDatabase
    {
        
        public bool UpdatePass(NguoiDung user, string new_pass)
        {
            SqlCommand command = new SqlCommand("UPDATE_PASS", Connection);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.Add(new SqlParameter("@MA", SqlDbType.Char, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, user.MaDangNhapNguoiDung));
                command.Parameters.Add(new SqlParameter("@PASS", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, new_pass));

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

        public List<NguoiDung> SelectAll()
        {
            SqlCommand command = new SqlCommand("SELECT_ALL", Connection);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                Connection.Open();
                IDataReader data = command.ExecuteReader();
                return PopulateObjectFromReader(data);
            }
            catch (Exception ex)
            {
                Connection.Close();
                command.Dispose();
                throw new Exception("user::SelectAll::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                command.Dispose();
            }

        }
        internal void PopulatePlayerFromReader(NguoiDung user, IDataReader data)
        {
            user.MaDangNhapNguoiDung = data.GetString(data.GetOrdinal(NguoiDung.UserFields.MaDangNhapNguoiDung.ToString()));

            if (!data.IsDBNull(data.GetOrdinal(NguoiDung.UserFields.MatKhau.ToString())))
            {
                user.MatKhau = data.GetString(data.GetOrdinal(NguoiDung.UserFields.MatKhau.ToString()));
            }
        }


        internal List<NguoiDung> PopulateObjectFromReader(IDataReader data)
        {
            List<NguoiDung> list = new List<NguoiDung>();
            while (data.Read())
            {
                NguoiDung user = new NguoiDung();
                PopulatePlayerFromReader(user, data);
                list.Add(user);
            }
            return list;
        }

    }
}
