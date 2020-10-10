using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DXApplication1.Models
{
    class NodeOnMap:ConnectionDatabase
    {
        connection connect;
        public DataSet getDataParentNode()
        {

            string query = "SELECT * FROM dbo.BinhChung";
            DataSet dataSet = new DataSet();
            connect = new connection();
            dataSet = connect.FillDataSet(query, CommandType.Text);
            return dataSet;
        }

        public DataSet getDataChildNode(string mabinhchung)
        {
            string query = "LayTTDonViTheoBinhChung";
            string[] para = { "@mabinhchung"};
            string[] value = { mabinhchung };
            DataSet dataSet = new DataSet();
            connection connect = new connection();
            dataSet = connect.FillDataSet(query, CommandType.StoredProcedure, para, value);
            return dataSet;
        }

        public DataSet getIconChild()
        {
            string query = "SELECT DuongDanAnh, MaDonVi FROM dbo.DonVi";
            DataSet dataSet = new DataSet();
            connect = new connection();
            dataSet = connect.FillDataSet(query, CommandType.Text);
            return dataSet;
        }
    }
}
