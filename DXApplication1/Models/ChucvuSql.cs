using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DXApplication1.Models
{
    class ChucvuSql:ConnectionDatabase
    {
        SqlInfoMessageEventHandler showResultFromSql = (sender, e) =>
        {
            if (int.Parse(e.Message) == 1)
            {
                DialogResult result = MessageBox.Show("Thêm chức vụ thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Program.phanquyen.AddChucVuVaoCombobox();
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        };

        public List<Chucvu> LayCacChucVu(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            List<Chucvu> chucvus = new List<Chucvu>();
            // Use connection object of base class

            try
            {
                Connection.Open();
                using(SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    foreach(DataRow row in table.Rows)
                    {
                        chucvus.Add(new Chucvu(row[0].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ChucVu::GetName::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                sqlCommand.Dispose();
            }
            return chucvus;
        }


        // Lấy Tên Chức Vụ Theo Mã Chức Vụ

        public string GetNameById(string Id)
        {
            SqlCommand sqlCommand = new SqlCommand("LayTenChucVuTheoMaChucVu", Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@maChucVu", Id);
            string name = string.Empty;
            try
            {
                Connection.Open();
                name = sqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("ChucVu::GetName::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                sqlCommand.Dispose();
            }
            return name;
        }

        public string GetIdByName(string name)
        {
            SqlCommand sqlCommand = new SqlCommand("LayMaChucVuTheoTen", Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@tenChucVu", name);
            string id = string.Empty;
            try
            {
                Connection.Open();
                name = sqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("ChucVu::GetName::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                sqlCommand.Dispose();
            }
            return name;
        }


        /// Lấy mã các quyền theo chức vụ
        /// 

        public List<string> LayCacQuyenBangId(string Id)
        {
            SqlCommand sqlCommand = new SqlCommand("LayQuyenTheoMaChucVu", Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@maChucVu", Id);
            List<string> maQuyens = new List<string>();
            try
            {
                Connection.Open();
                using(SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    foreach(DataRow row in table.Rows)
                    {
                        maQuyens.Add(row[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ChucVu::GetName::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                sqlCommand.Dispose();
            }
            return maQuyens;
        }

        public bool ThemChucVu(string maChucVu, string tenChucVu)
        {
            SqlCommand cmd = new SqlCommand("ThemChucVu", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.Add(new SqlParameter("@maChucVu",  maChucVu));
                cmd.Parameters.Add(new SqlParameter("@tenChucVu", tenChucVu));
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

        public void SuaTenChucVu(string tenCu, string tenMoi)
        {
            string query = "SuaTenChucVu";
            string[] para = { "@tenChucVu_Cu", "@tenChucVu_Moi" };
            string[] value = { tenCu, tenMoi };
            connection connect = new connection();
            int result = connect.Excute_Sql(query, CommandType.StoredProcedure, para, value);
            if (result > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Thay đổi tên chức vụ thành công", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Program.phanquyen.AddChucVuVaoCombobox();
                }
            }
            else
            {
                MessageBox.Show("Thay đổi không thành công", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void XoaChucVu(string tenChucVu)
        {
            string query = "XoaChucVu";
            string[] para = { "@tenChucVu" };
            string[] value = { tenChucVu };
            connection connect = new connection();
            int result = connect.Excute_Sql(query, CommandType.StoredProcedure, para, value);
            if (result > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xoá chức vụ thành công", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Program.phanquyen.AddChucVuVaoCombobox();
                }
            }
        }

    }
}
