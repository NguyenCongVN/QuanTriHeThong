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
    class NodeOnMap:ConnectionDatabase
    {
      

        SqlInfoMessageEventHandler showResultAddBCFromSql = (sender, e) =>
        {
            if (int.Parse(e.Message) == 1)
            {
                DialogResult result = MessageBox.Show("Thêm binh chủng thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Program.frm_Map.Frm_test1_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Mã binh chủng đã tồn tại", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        };

        SqlInfoMessageEventHandler showResultChangeBCFromSql = (sender, e) =>
        {
            if (int.Parse(e.Message) == 1)
            {
                DialogResult result = MessageBox.Show("Chỉnh sửa thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Program.frm_Map.Frm_test1_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại binh chủng", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        };

        SqlInfoMessageEventHandler showResultDeleteFromSql = (sender, e) =>
        {
            if (int.Parse(e.Message) == 1)
            {
                DialogResult result = MessageBox.Show("Xoá thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Program.frm_Map.Frm_test1_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã cần xoá", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        };

        SqlInfoMessageEventHandler showResultFromSql = (sender, e) =>
        {
            if (int.Parse(e.Message) == 1)
            {
                DialogResult result = MessageBox.Show("Thêm đơn vị thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Program.frm_Map.Frm_test1_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Mã đơn vị đã tồn tại", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        };

        SqlInfoMessageEventHandler showResultChangeDVFromSql = (sender, e) =>
        {
            if (int.Parse(e.Message) == 1)
            {
                DialogResult result = MessageBox.Show("Chỉnh sửa thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Program.frm_Map.Frm_test1_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại đơn vị", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        };

        
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


        public void AddBinhChung(string s1, string s2)
        {
            string query = "ThemBinhChung";
            string[] para = { "@maBinhChung", "@tenBinhChung" };
            string[] value = { s1,s2 };
            connection Connection = new connection();
            Connection.Excute_Sql_Node(query, CommandType.StoredProcedure, para, value, showResultAddBCFromSql);
        }

        public void ChinhSuaBinhChung(string s1, string s2)
        {
            string query = "ChinhSuaBinhChung";
            string[] para = { "@maBinhChung", "@tenBinhChung" };
            string[] value = { s1, s2 };
            connection Connection = new connection();
            Connection.Excute_Sql_Node(query, CommandType.StoredProcedure, para, value, showResultChangeBCFromSql);
        }


        public void XoaBinhChung(string mabinhchung)
        {
            string query = "XoaBinhChung";
            string[] para = { "@maBinhChung"};
            string[] value = {mabinhchung};
            connection Connection = new connection();
            Connection.Excute_Sql_Node(query, CommandType.StoredProcedure, para, value, showResultDeleteFromSql);
        }

        public void AddDonVi(string madonvi, string tendonvi, string duongdananh, string mabinhchung)
        {
            string query = "ThemDonVi";
            string[] para = { "@maDonVi", "@tenDonVi", "@duongDanAnh", "@maBinhChung" };
            string[] value = { madonvi, tendonvi , duongdananh , mabinhchung };
            connection Connection = new connection();
            Connection.Excute_Sql_Node(query, CommandType.StoredProcedure, para, value, showResultFromSql);
        }


        public void ChinhSuaDonVi(string madonvi, string tendonvi, string duongdananh)
        {
            string query = "ChinhSuaDonVi";
            string[] para = { "@maDonVi", "@tenDonVi", "@duongDanAnh" };
            string[] value = { madonvi, tendonvi, duongdananh};
            connection Connection = new connection();
            Connection.Excute_Sql_Node(query, CommandType.StoredProcedure, para, value, showResultChangeDVFromSql);
        }

        public void XoaDonVi(string madonvi)
        {
            string query = "XoaDonVi";
            string[] para = { "@maDonVi" };
            string[] value = { madonvi };
            connection Connection = new connection();
            Connection.Excute_Sql_Node(query, CommandType.StoredProcedure, para, value, showResultDeleteFromSql);
        }

    }
}
