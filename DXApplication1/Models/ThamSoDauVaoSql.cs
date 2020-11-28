using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace DXApplication1.Models
{
    class ThamSoDauVaoSql: ConnectionDatabase
    {
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
            int result = connect.Excute_Sql(query, CommandType.StoredProcedure, para, value);
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
    }
}
