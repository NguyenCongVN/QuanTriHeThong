using DXApplication1.Utilizes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    public class PhanQuyenSql:ConnectionDatabase
    {

        // Thêm quyền vào chức vụ
        public void ThemQuyenVaoChucVu(ThongTinThayDoiChucVu thongTin)
        {
            try
            {
                SqlCommand command = new SqlCommand("dbo.ThemQuyenVaoChucVu", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@QuyenId", thongTin.maQuyen);
                command.Parameters.AddWithValue("@MaChucVu", thongTin.maChucVu);
                Connection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

        }

        /// Xóa quyền khỏi chức vụ

        public void XoaQuyenKhoiChucVu(ThongTinThayDoiChucVu thongTin)
        {
            try
            {
                SqlCommand command = new SqlCommand("dbo.XoaQuyenKhoiChucVu", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@QuyenId", thongTin.maQuyen);
                command.Parameters.AddWithValue("@MaChucVu", thongTin.maChucVu);
                Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
