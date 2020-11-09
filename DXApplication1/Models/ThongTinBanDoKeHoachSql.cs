using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DXApplication1.Models
{
    public class ThongTinBanDoKeHoachSql : ConnectionDatabase
    {
        enum ThongTinBanDoKeHoachFields
        {
            MaThongTin,
            MaBanDo,
            MaKeHoach,
            ChieuRong,
            ChieuDai
        }

        public void AddThongTinBanDoKeHoach(ThongTinBanDoKeHoach thongTin)
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand("ThemThongTinBanDoKeHoach", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maBanDo", thongTin.MaBanDo);
                command.Parameters.AddWithValue("@maKeHoach", thongTin.MaKeHoach);
                command.ExecuteScalar();
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
            finally
            {
                Connection.Close();
            }
        }


        public void RemoveThongTinBanDoKeHoach(int maThongTin)
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand("XoaThongTinBanDoKeHoach", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ma", maThongTin);
                command.ExecuteScalar();
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra");
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }

        public int GetIdThongTinBanDoKeHoach(int maKeHoach, int maBanDo)
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand("GetIdThongTinBanDoKeHoach", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maBanDo", maBanDo);
                command.Parameters.AddWithValue("@maKeHoach", maKeHoach);
                int ma = (int)command.ExecuteScalar();
                Connection.Close();
                return ma;
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra");
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }

        public int GetIdThongTinFileDemKeHoach(int maKeHoach, int maFileDem)
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand("GetIdThongTinFileDemKeHoach", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maFileDem", maFileDem);
                command.Parameters.AddWithValue("@maKeHoach", maKeHoach);
                int ma = (int)command.ExecuteScalar();
                Connection.Close();
                return ma;
            }
            catch (Exception e)
            {
                MessageBox.Show("Có lỗi xảy ra");
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
