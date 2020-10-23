using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    class KeHoachSql:ConnectionDatabase
    {
        public void ThemKeHoach(KeHoach keHoach)
        {
            SqlCommand sqlCommand = new SqlCommand("ThemKeHoach", Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            using (Connection)
            {
                sqlCommand.Parameters.AddWithValue("@name", keHoach.TenKeHoach);
                sqlCommand.Parameters.AddWithValue("@maNguoiLapKeHoach", keHoach.MaNguoiLap);
                keHoach.MaKeHoach = (int)sqlCommand.ExecuteScalar();
            }
        }
    }
}
