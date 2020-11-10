using DevExpress.XtraEditors;
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
    class FileDemSql : ConnectionDatabase
    {

        enum FileDemField
        {
            TenFile,
            DuongDan,
            MaFile
        }

        public bool Insert_FileDem(Dem fdem)
        {
            string query = "Insert_FileDem";
            string[] para;
            para = new string[2];
            para[0] = "@TenFile";
            para[1] = "@DuongDan";

            object[] values;
            values = new object[2];
            values[0] = fdem.TenFile;
            values[1] = fdem.DuongDan;


            try
            {
                connection connect = new connection();
                int a = connect.Excute_Sql(query, CommandType.StoredProcedure, para, values);
                if (a != 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                DialogResult d;
                d = MessageBox.Show("Thông tin thêm không hợp lệ!");
                return false;
            }
            finally
            {

            }
        }
        public bool UpdateDem(Dem fdem)
        {
            string query = "Update_FileDem";
            string[] para;
            para = new string[3];
            para[0] = "@MaFile";
            para[1] = "@DuongDan";
            para[2] = "@TenFile";
            object[] values;
            values = new object[3];
            values[2] = fdem.TenFile;
            values[1] = fdem.DuongDan;
            values[0] = fdem.MaFile;
            try
            {
                connection connect = new connection();
                int a = connect.Excute_Sql(query, CommandType.StoredProcedure, para, values);
                if (a != 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                DialogResult d;
                d = MessageBox.Show("Thông tin sửa không hợp lệ!");
                return false;
            }
            finally
            {

            }

        }
        public bool DeleteDem(Dem fdem)
        {
            string query = "Delete_FileDem";
            string[] para;
            para = new string[1];
            para[0] = "@MaFile";


            object[] values;
            values = new object[1];
            values[0] = fdem.MaFile;

            try
            {
                connection connect = new connection();
                int a = connect.Excute_Sql(query, CommandType.StoredProcedure, para, values);
                if (a != 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                DialogResult d;
                d = MessageBox.Show("Thông tin xóa không hợp lệ!");
                return false;
            }
            finally
            {

            }

        }
        public void SelectAllFileDem(DataGridView dataGridView, SearchLookUpEdit searchLookUpEdit)
        {
            connection connect;

            string query = "SelectAllFile";
            DataSet dataSet = new DataSet();
            connect = new connection();
            dataSet = connect.FillDataSet(query, CommandType.StoredProcedure);
            dataGridView.DataSource = dataSet.Tables[0];
            searchLookUpEdit.Properties.DataSource = dataSet.Tables[0];
        }


        public List<Dem> SelectAllFileDem()
        {
            connection connect;

            string query = "SelectAllFile";
            DataSet dataSet = new DataSet();
            connect = new connection();
            dataSet = connect.FillDataSet(query, CommandType.StoredProcedure);
            List<Dem> list = new List<Dem>();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                list.Add(new Dem()
                {
                    MaFile = row.Field<int>((int)FileDemField.MaFile),
                    TenFile = row.Field<string>((int)FileDemField.TenFile),
                    DuongDan = row.Field<string>((int)FileDemField.DuongDan)
                });
            }
            return list;
        }
    }
}
