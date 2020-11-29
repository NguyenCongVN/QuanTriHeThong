using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace DXApplication1.Models
{
    class ThamSoDauVaoSql : connection
    {

        enum ThamSoDauVaoEnum
        {
            idThamSo,
            x_water_velocity,
            y_water_velocity,
            x_wind,
            y_wind,
            upward_sea_water_velocity,
            sea_surface_wave_significant_height,
            sea_surface_wave_stokes_drift_x_velocity,
            sea_surface_wave_stokes_drift_y_velocity,
            sea_water_temperature,
            sea_water_salinity,
            idLoaiDau,
            vitridauthatthoat_x,
            vitridauthatthoat_y,
            khoiluongdau,
            thoigianmophong
        }


        connection connect;
        SqlInfoMessageEventHandler showResultFromSql = (sender, e) =>
        {
            if (int.Parse(e.Message) == 1)
            {
                DialogResult result = MessageBox.Show("Thêm tham số thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Program.thamSoDauVao.ThamSoDauVao_Load(null, null);
                }
            }
            else
            {
                MessageBox.Show("Mã tham số đã tồn tại", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        };
        public void getDataTSDV(DataGridView dataGridView, SearchLookUpEdit searchLookUpEdit)
        {

            string query = "LayThongTinThamSoDauVao";
            DataSet dataSet = new DataSet();
            connect = new connection();
            dataSet = connect.FillDataSet(query, CommandType.StoredProcedure);
            dataGridView.DataSource = dataSet.Tables[0];
            searchLookUpEdit.Properties.DataSource = dataSet.Tables[0];

        }

        public void XoaNhanVien(string madangnhap)
        {
            string query = "XoaNhanVien";
            string[] para = { "@maDangNhap" };
            string[] value = { madangnhap };
            connect = new connection();
            int result = connection.Excute_Sql(query, CommandType.StoredProcedure, para, value);
            if (result > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xoa nhan vien thanh cong", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Program.quanLyNhanVien.QuanLyNhanVien_Load(null, null);
                }
            }
        }

        public bool ThemThamSo(ThamSoDauVao_class input)
        {
            SqlCommand cmd = new SqlCommand("ThemThamSo", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {

                cmd.Parameters.Add(new SqlParameter("@mathamso", input.Mathamso));
                cmd.Parameters.Add(new SqlParameter("@x_water", input.X_water));
                cmd.Parameters.Add(new SqlParameter("@y_water", input.Y_water));
                cmd.Parameters.Add(new SqlParameter("@x_wind", input.X_wind));
                cmd.Parameters.Add(new SqlParameter("@y_wind", input.Y_wind));
                cmd.Parameters.Add(new SqlParameter("@upward_sea", input.Upward_sea));
                cmd.Parameters.Add(new SqlParameter("@sign_height", input.Sign_height));
                cmd.Parameters.Add(new SqlParameter("@drift_x", input.Drift_x));
                cmd.Parameters.Add(new SqlParameter("@drift_y", input.Drift_y));
                cmd.Parameters.Add(new SqlParameter("@temperature", input.Temperature));
                cmd.Parameters.Add(new SqlParameter("@salinity", input.Salinity));
                cmd.Parameters.Add(new SqlParameter("@idLoaiDau", input.IdLoaiDau));
                cmd.Parameters.Add(new SqlParameter("@vitri_x", input.Vitri_x));
                cmd.Parameters.Add(new SqlParameter("@vitri_y", input.Vitr_y));
                cmd.Parameters.Add(new SqlParameter("@luongdau", input.Luongdau));
                cmd.Parameters.Add(new SqlParameter("@thoigian", input.Thoigian));


                Connection.Open();
                Connection.InfoMessage += showResultFromSql;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra");
                return false;
            }
            finally
            {
                Connection.InfoMessage -= showResultFromSql;
                Connection.Close();
                cmd.Dispose();
            }
        }

        public List<ThamSoDauVao_class> LayThamSoDauVao()
        {
            SqlCommand cmd = new SqlCommand("LayThongTinThamSoDauVao", Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                List<ThamSoDauVao_class> thamSoDauVaos = new List<ThamSoDauVao_class>();
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    thamSoDauVaos.Add(new ThamSoDauVao_class()
                    {
                        Drift_x = row.Field<double>((int)ThamSoDauVaoEnum.sea_surface_wave_stokes_drift_x_velocity),
                        Drift_y = row.Field<double>((int)ThamSoDauVaoEnum.sea_surface_wave_stokes_drift_y_velocity),
                        IdLoaiDau = row.Field<int>((int)ThamSoDauVaoEnum.idLoaiDau),
                        Luongdau = row.Field<double>((int)ThamSoDauVaoEnum.khoiluongdau),
                        Mathamso = row.Field<int>((int)ThamSoDauVaoEnum.idThamSo),
                        Salinity = row.Field<double>((int)ThamSoDauVaoEnum.sea_water_salinity),
                        Sign_height = row.Field<double>((int)ThamSoDauVaoEnum.sea_surface_wave_significant_height),
                        Temperature = row.Field<double>((int)ThamSoDauVaoEnum.sea_water_temperature),
                        Thoigian = row.Field<DateTime>((int)ThamSoDauVaoEnum.thoigianmophong),
                        Upward_sea = row.Field<double>((int)ThamSoDauVaoEnum.upward_sea_water_velocity),
                        Vitri_x = row.Field<int>((int)ThamSoDauVaoEnum.vitridauthatthoat_x),
                        Vitr_y = row.Field<int>((int)ThamSoDauVaoEnum.vitridauthatthoat_y),
                        X_water = row.Field<double>((int)ThamSoDauVaoEnum.x_water_velocity),
                        X_wind = row.Field<double>((int)ThamSoDauVaoEnum.x_wind),
                        Y_water = row.Field<double>((int)ThamSoDauVaoEnum.y_water_velocity),
                        Y_wind = row.Field<double>((int)ThamSoDauVaoEnum.y_wind)
                    });
                }
                return thamSoDauVaos;
            }
        }

        public ThamSoDauVao_class LayThamSoDauVaoVoiMaKeHoach(int maKeHoach)
        {
            SqlCommand cmd = new SqlCommand("LayThamSoDauVaoVoiMaKeHoach", Connection);
            cmd.Parameters.AddWithValue("maKeHoach", maKeHoach);
            cmd.CommandType = CommandType.StoredProcedure;
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    ThamSoDauVao_class thamSoDauVao = new ThamSoDauVao_class()
                    {
                        Drift_x = table.Rows[0].Field<double>((int)ThamSoDauVaoEnum.sea_surface_wave_stokes_drift_x_velocity),
                        Drift_y = table.Rows[0].Field<double>((int)ThamSoDauVaoEnum.sea_surface_wave_stokes_drift_y_velocity),
                        IdLoaiDau = table.Rows[0].Field<int>((int)ThamSoDauVaoEnum.idLoaiDau),
                        Luongdau = table.Rows[0].Field<double>((int)ThamSoDauVaoEnum.khoiluongdau),
                        Mathamso = table.Rows[0].Field<int>((int)ThamSoDauVaoEnum.idThamSo),
                        Salinity = table.Rows[0].Field<double>((int)ThamSoDauVaoEnum.sea_water_salinity),
                        Sign_height = table.Rows[0].Field<double>((int)ThamSoDauVaoEnum.sea_surface_wave_significant_height),
                        Temperature = table.Rows[0].Field<double>((int)ThamSoDauVaoEnum.sea_water_temperature),
                        Thoigian = table.Rows[0].Field<DateTime>((int)ThamSoDauVaoEnum.thoigianmophong),
                        Upward_sea = table.Rows[0].Field<double>((int)ThamSoDauVaoEnum.upward_sea_water_velocity),
                        Vitri_x = table.Rows[0].Field<int>((int)ThamSoDauVaoEnum.vitridauthatthoat_x),
                        Vitr_y = table.Rows[0].Field<int>((int)ThamSoDauVaoEnum.vitridauthatthoat_y),
                        X_water = table.Rows[0].Field<double>((int)ThamSoDauVaoEnum.x_water_velocity),
                        X_wind = table.Rows[0].Field<double>((int)ThamSoDauVaoEnum.x_wind),
                        Y_water = table.Rows[0].Field<double>((int)ThamSoDauVaoEnum.y_water_velocity),
                        Y_wind = table.Rows[0].Field<double>((int)ThamSoDauVaoEnum.y_wind)
                    };
                    return thamSoDauVao;
                }
                return null;
            }
        }

        public void UpdateThamSo(int MaKeHoach , int MaThamSo)
        {
            SqlCommand cmd = new SqlCommand("UpdateMaThamSoKeHoach", Connection);
            cmd.Parameters.AddWithValue("idThamSo", MaThamSo);
            cmd.Parameters.AddWithValue("maKeHoach", MaKeHoach);
            cmd.CommandType = CommandType.StoredProcedure;
            Connection.Open();
            cmd.ExecuteScalar();
            Connection.Close();
        }

         public void XoaThamSo(int mathamso)
        {
            string query = "XoaThamSo";
            string[] para = { "@mathamso" };
            int[] value = new int[] { mathamso };
            object[] obj = (from i in value select i).Cast<object>().ToArray();
            connect = new connection();
            int result = Excute_Sql(query, CommandType.StoredProcedure, para, obj);
            if (result > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xoa tham so thanh cong", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Program.thamSoDauVao.ThamSoDauVao_Load(null,null);
                }
            }
        }
    }
}
