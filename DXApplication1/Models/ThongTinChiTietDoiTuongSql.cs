using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    public class ThongTinChiTietDoiTuongSql:ConnectionDatabase
    {
        public void AddDoiTuong(List<ThongTinChiTietDoiTuong> list)
        {
            using (Connection)
            {
                foreach (var doiTuong in list)
                {
                    SqlCommand command = new SqlCommand("ThemDoiTuongVaoKeHoach" , Connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@maDonVi", doiTuong.MaDonVi);
                    command.Parameters.AddWithValue("@moTa", doiTuong.MoTa);
                    command.Parameters.AddWithValue("@toaDoX", doiTuong.ToaDoX);
                    command.Parameters.AddWithValue("@toaDoY", doiTuong.ToaDoY);
                    command.Parameters.AddWithValue("@maKeHoach", doiTuong.MaKeHoach);
                    command.Parameters.AddWithValue("@chieuRongAnh", doiTuong.ChieuRongAnh);
                    command.Parameters.AddWithValue("@chieuDaiAnh", doiTuong.ChieuDaiAnh);
                    command.ExecuteScalar();
                }
            }
        }
    }
}
