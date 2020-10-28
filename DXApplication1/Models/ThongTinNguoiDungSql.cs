using System;
using System.Data;
using System.Data.SqlClient;

namespace DXApplication1.Models
{
    class ThongTinNguoiDungSql : ConnectionDatabase
    {

        public ThongTinNguoiDung Select_Detail(ThongTinNguoiDung detail_user, string ma)
        {
            SqlCommand command = new SqlCommand("Detail_User @MA", Connection);
            command.Parameters.Add(new SqlParameter("@MA", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ma));
            command.CommandType = CommandType.Text;
            try
            {

                Connection.Open();
                IDataReader data = command.ExecuteReader();

                data.Read();
                PopulatePlayerFromReader(detail_user, data);

                return detail_user;
            }
            catch (Exception ex)
            {
                Connection.Close();
                command.Dispose();
                throw new Exception("user::Select Detail User::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                command.Dispose();
            }

        }

        public bool Update_Detail(ThongTinNguoiDung detail_user)
        {
            string maChucVu = Program.chucvuSql.GetIdByName(detail_user.ChucVu);
            SqlCommand command = new SqlCommand("Update_Detail_User", Connection);
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.Parameters.Add(new SqlParameter("@EMAIL", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, detail_user.Email));
                command.Parameters.Add(new SqlParameter("@MA", SqlDbType.VarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, detail_user.MaDangNhapNguoiDung));
                command.Parameters.Add(new SqlParameter("@SDT", SqlDbType.Char, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, detail_user.SoDienThoai));
                command.Parameters.Add(new SqlParameter("@HOTEN", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, detail_user.HoTen));
                command.Parameters.Add(new SqlParameter("@NGAYTAO", SqlDbType.DateTime, 15, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, detail_user.NgayTao));
                command.Parameters.Add(new SqlParameter("@DC", SqlDbType.NVarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, detail_user.DiaChi));
                command.Parameters.Add(new SqlParameter("@CHUCVU", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, maChucVu));
                command.Parameters.Add(new SqlParameter("@NS", SqlDbType.Date, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, detail_user.NgaySinh));

                Connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Connection.Close();
                command.Dispose();
                throw new Exception("Player::UpdatePass::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                command.Dispose();
            }
        }
        public void PopulatePlayerFromReader(ThongTinNguoiDung detail_user, IDataReader data)
        {
            //MessageBox.Show(data.GetString(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.MaDangNhapNguoiDung.ToString())));
            detail_user.MaDangNhapNguoiDung = data.GetString(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.MaDangNhapNguoiDung.ToString()));

            if (!data.IsDBNull(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.HoTen.ToString())))
            {
                detail_user.HoTen = data.GetString(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.HoTen.ToString()));

            }
            if (!data.IsDBNull(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.Email.ToString())))
            {
                detail_user.Email = data.GetString(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.Email.ToString()));

            }
            if (!data.IsDBNull(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.SoDienThoai.ToString())))
            {
                detail_user.SoDienThoai = data.GetString(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.SoDienThoai.ToString()));

            }
            if (!data.IsDBNull(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.DiaChi.ToString())))
            {
                detail_user.DiaChi = data.GetString(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.DiaChi.ToString()));

            }
            if (!data.IsDBNull(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.NgaySinh.ToString())))
            {
                detail_user.NgaySinh = data.GetDateTime(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.NgaySinh.ToString()));

            }
            if (!data.IsDBNull(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.NgayTao.ToString())))
            {
                detail_user.NgayTao = data.GetDateTime(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.NgayTao.ToString()));

            }
            if (!data.IsDBNull(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.MaChucVu.ToString())))
            {
                detail_user.ChucVu = Program.chucvuSql.GetNameById(data.GetString(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.MaChucVu.ToString())));
                //  detail_user.ChucVu = data.GetString(data.GetOrdinal(ThongTinNguoiDung.DetailUserFields.MaChucVu.ToString()));

            }
        }
    }
}
