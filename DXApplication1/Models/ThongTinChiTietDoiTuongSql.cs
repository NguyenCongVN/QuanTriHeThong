using DXApplication1.Utilizes;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DXApplication1.Models
{
    public class ThongTinChiTietDoiTuongSql : ConnectionDatabase
    {
        enum DoiTuong
        {
            MaDoiTuong,
            MaDonVi,
            MoTa,
            ToaDoX,
            ToaDoY,
            MaKeHoach,
            ChieuRongAnh,
            ChieuDaiAnh,
            TenDoiTuong,
            ChieuNgang,
            ChieuDoc
        }

        public void AddDoiTuong(List<ThongTinChiTietDoiTuong> list)
        {
            Connection.Open();
            foreach (var doiTuong in list)
            {
                SqlCommand command = new SqlCommand("ThemDoiTuongVaoKeHoach", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maDonVi", doiTuong.MaDonVi);
                if (doiTuong.MoTa == null)
                {
                    command.Parameters.AddWithValue("@moTa", string.Empty);
                }
                else
                {
                    command.Parameters.AddWithValue("@moTa", doiTuong.MoTa);
                }
                command.Parameters.AddWithValue("@toaDoX", doiTuong.ToaDoX);
                command.Parameters.AddWithValue("@toaDoY", doiTuong.ToaDoY);
                command.Parameters.AddWithValue("@maKeHoach", doiTuong.MaKeHoach);
                command.Parameters.AddWithValue("@chieuRongAnh", doiTuong.ChieuRongAnh);
                command.Parameters.AddWithValue("@chieuDaiAnh", doiTuong.ChieuDaiAnh);
                command.Parameters.AddWithValue("@chieuNgang", doiTuong.ChieuNgang);
                command.Parameters.AddWithValue("@chieuDoc", doiTuong.ChieuDoc);
                if (doiTuong.TenDoiTuong != null)
                    command.Parameters.AddWithValue("@tenDoiTuong", doiTuong.TenDoiTuong);
                else
                {
                    command.Parameters.AddWithValue("@tenDoiTuong", string.Empty);
                }
                command.ExecuteScalar();
            }
            Connection.Close();
        }

        //public List<ThongTinChiTietDoiTuong> LayCacThongTinDoiTuongTuKeHoach(int MaKeHoach)
        //{
        //    List<ThongTinChiTietDoiTuong> doiTuongs = new List<ThongTinChiTietDoiTuong>();
        //    Connection.Open();
        //    SqlCommand command = new SqlCommand("LayDoiTuongTuKeHoach", Connection);
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.AddWithValue("@maKeHoach", MaKeHoach);
        //    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //    {
        //        DataTable table = new DataTable();
        //        adapter.Fill(table);
        //        foreach (DataRow doiTuong in table.Rows)
        //        {
        //            doiTuongs.Add(new ThongTinChiTietDoiTuong()
        //            {
        //                MaKeHoach = doiTuong.Field<int>((int)DoiTuong.MaKeHoach),
        //                MoTa = doiTuong.Field<string>((int)DoiTuong.MoTa),
        //                MaDonVi = doiTuong.Field<string>((int)DoiTuong.MaDonVi),
        //                ToaDoX = doiTuong.Field<int>((int)DoiTuong.ToaDoX),
        //                ToaDoY = doiTuong.Field<int>((int)DoiTuong.ToaDoY),
        //                ChieuDaiAnh = doiTuong.Field<int>((int)DoiTuong.ChieuDaiAnh),
        //                ChieuRongAnh = doiTuong.Field<int>((int)DoiTuong.ChieuRongAnh)
        //            });
        //        }
        //    }
        //    Connection.Close();
        //    return doiTuongs;
        //}

        public List<Models.DoiTuong> LayCacDoiTuongTuKeHoach(int MaKeHoach, TreeView treeView, ImageList imageList, IntClass count)
        {
            List<Models.DoiTuong> doiTuongs = new List<Models.DoiTuong>();
            Connection.Open();
            SqlCommand command = new SqlCommand("LayDoiTuongTuKeHoach", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maKeHoach", MaKeHoach);
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                count.IntVar = table.Rows.Count;
                foreach (DataRow doiTuong in table.Rows)
                {
                    int maDoiTuong = doiTuong.Field<int>((int)DoiTuong.MaDoiTuong);
                    int maKeHoach = doiTuong.Field<int>((int)DoiTuong.MaKeHoach);
                    string moTa = doiTuong.Field<string>((int)DoiTuong.MoTa);
                    string maDonVi = doiTuong.Field<string>((int)DoiTuong.MaDonVi);
                    int toaDoX = doiTuong.Field<int>((int)DoiTuong.ToaDoX);
                    int toaDoY = doiTuong.Field<int>((int)DoiTuong.ToaDoY);
                    int chieuDaiAnh = doiTuong.Field<int>((int)DoiTuong.ChieuDaiAnh);
                    int chieuRongAnh = doiTuong.Field<int>((int)DoiTuong.ChieuRongAnh);
                    string tenDoiTuong = doiTuong.Field<string>((int)DoiTuong.TenDoiTuong);
                    int chieuNgang = doiTuong.Field<int>((int)DoiTuong.ChieuNgang);
                    int chieuDoc = doiTuong.Field<int>((int)DoiTuong.ChieuDoc);
                    Models.DoiTuong anh = new Models.DoiTuong()
                    {
                        ThongTinChiTietDoiTuong = new ThongTinChiTietDoiTuong()
                        {
                            MaDoiTuong = maDoiTuong,
                            ChieuDaiAnh = chieuDaiAnh,
                            ChieuRongAnh = chieuRongAnh,
                            ToaDoX = toaDoX,
                            ToaDoY = toaDoY,
                            MaDonVi = maDonVi,
                            MaKeHoach = maKeHoach,
                            MoTa = moTa,
                            ChieuDoc = chieuDoc,
                            ChieuNgang = chieuNgang,
                            TenDoiTuong = tenDoiTuong
                        }
                    };
                    anh.InitImage = imageList.Images[maDonVi];
                    // Thiết lập chiều ngang và chiều dọc của đối tượng
                    // Thiết lập ảnh cho đối tượng
                    anh.Picture.Image = new Bitmap(anh.InitImage, anh.ThongTinChiTietDoiTuong.ChieuNgang,
                     anh.ThongTinChiTietDoiTuong.ChieuDoc);
                    doiTuongs.Add(anh);
                }
            }
            Connection.Close();
            return doiTuongs;
        }

        // Xóa list đối tượng
        public void XoaDoiTuong(List<Models.DoiTuong> doiTuongs)
        {
            Connection.Open();
            foreach (Models.DoiTuong doiTuong in doiTuongs)
            {
                SqlCommand command = new SqlCommand("XoaDoiTuong", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@maDoiTuong", doiTuong.ThongTinChiTietDoiTuong.MaDoiTuong);
                command.ExecuteScalar();
            }
            Connection.Close();
        }

        // Sửa List đối tượng
        public void SuaDoiTuong(List<Models.DoiTuong> doiTuongs)
        {
            Connection.Open();
            foreach (Models.DoiTuong doiTuong in doiTuongs)
            {
                SqlCommand command = new SqlCommand("CapNhatThongTinDoiTuong", Connection);
                command.CommandType = CommandType.StoredProcedure;
                if (doiTuong.ThongTinChiTietDoiTuong.MoTa == null)
                {
                    command.Parameters.AddWithValue("@moTa", string.Empty);
                }
                else
                {
                    command.Parameters.AddWithValue("@moTa", doiTuong.ThongTinChiTietDoiTuong.MoTa);
                }
                command.Parameters.AddWithValue("@toaDoX", doiTuong.ThongTinChiTietDoiTuong.ToaDoX);
                command.Parameters.AddWithValue("@toaDoY", doiTuong.ThongTinChiTietDoiTuong.ToaDoY);
                command.Parameters.AddWithValue("@chieuNgang", doiTuong.ThongTinChiTietDoiTuong.ChieuNgang);
                command.Parameters.AddWithValue("@chieuDoc", doiTuong.ThongTinChiTietDoiTuong.ChieuDoc);
                command.Parameters.AddWithValue("@tenDoiTuong", doiTuong.ThongTinChiTietDoiTuong.TenDoiTuong);
                command.Parameters.AddWithValue("@maDoiTuong", doiTuong.ThongTinChiTietDoiTuong.MaDoiTuong);
                command.ExecuteScalar();
            }
            Connection.Close();
        }

        // lấy thông tin tên đơn vị
        public string LayTenDonViTuMa(string maDonVi)
        {
            Connection.Open();
            var query = "SELECT TenDonVi FROM dbo.DonVi WHERE MaDonVi = @maDonVi";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@maDonVi", maDonVi);
            string tenDonVi = command.ExecuteScalar().ToString();
            Connection.Close();
            return tenDonVi;
        }
    }


}