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
    public class ThongTinFileDemKeHoachSql : ConnectionDatabase
    {
        enum ThongTinBanDoKeHoachFields
        {
            MaThongTinDuLieu,
            MaFile,
            MaKeHoach,
        }

        public void AddThongTinFileDemKeHoach(ThongTinFileDemKeHoach thongTin)
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand("ThemThongTinFileDemKeHoach", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maFile", thongTin.MaFile);
                command.Parameters.AddWithValue("@maKeHoach", thongTin.MaKeHoach);
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


        public void RemoveThongTinFileDemKeHoach(int maThongTin)
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand("XoaThongTinFileDemKeHoach", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maThongTin", maThongTin);
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


        public void LayThongTinFileDemKeHoachBangKeHoach(int maKeHoach)
        {
            try
            {
                Connection.Open();
                SqlCommand command = new SqlCommand("ThemThongTinFileDemKeHoach", Connection);
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.AddWithValue("@maFile", thongTin.MaFile);
                //command.Parameters.AddWithValue("@maKeHoach", thongTin.MaKeHoach);
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
    }
}
