using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication1.Models;

namespace DXApplication1.ThamSoDauVao
{
    public partial class ThemTSDV : DevExpress.XtraEditors.XtraForm
    {
        int flag_ktathongtindau = 0;
        public ThemTSDV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbmathamso.Text == "" || tbdrift_x.Text == "" || tbdrift_y.Text == "" || tbx_water.Text == "" 
                    || tby_water.Text == "" || tbx_wind.Text == "" || tby_wind.Text == ""|| tbthoigian.Text == ""
                   || tbsign_height.Text == "" || tbsalinity.Text == "" || tbupward_sea.Text == "" || tbtemperature.Text == "" || tbvitrithatthoat_x.Text == ""
                   || tbvitrithatthoat_y.Text == "" || tbluongdau.Text == ""  || flag_ktathongtindau == 0 )
                    throw new Exception("Bạn phải nhập đầy đủ thông tin!");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }

           
            ThemThamSo(tbmathamso.Text, tbdrift_x.Text, tbdrift_y.Text,
               tbx_water.Text, tby_water.Text, tbx_wind.Text, tby_wind.Text, tbthoigian.Text, tbsign_height.Text, tbsalinity.Text, tbupward_sea.Text, tbtemperature.Text, tbvitrithatthoat_x.Text,
               tbvitrithatthoat_y.Text,tbluongdau.Text);
        }

        public bool ThemThamSo(string mathamso,string drift_x,string drift_y,string x_water,string y_water,string x_wind,string y_wind,string thoigian,string sign_height,string salinity,string upward_sea,string temperature,
            string vitri_x,string vitri_y,string luongdau)
        {
            ThamSoDauVao_class thamSoDauVao = new ThamSoDauVao_class
            {
                Mathamso = Convert.ToInt32(mathamso),
                Drift_x = float.Parse(drift_x),
                Drift_y = float.Parse(drift_y),
                X_water = float.Parse(x_water),
                Y_water = float.Parse(y_water),
                X_wind = float.Parse(x_wind),
                Y_wind = float.Parse(y_wind),
                Sign_height = float.Parse(sign_height),
                Salinity = float.Parse(salinity),
                Upward_sea = float.Parse(upward_sea),
                Temperature = float.Parse(temperature),
                Luongdau = float.Parse(luongdau),
                Vitri_x = Convert.ToInt32(vitri_x),
                Vitr_y = Convert.ToInt32(vitri_y),
                IdLoaiDau = Convert.ToInt32(Program.maLoaiDau),
                Thoigian = DateTime.ParseExact(thoigian, "yyyy-MM-dd HH:mm:ss,fff",
                                       null)
        };
            if (Program.thamSoDauVaoSql.ThemThamSo(thamSoDauVao))
                return true;
            else
                return false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridLookUpEditDau_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as GridLookUpEdit;
            DataRow dr = (edit.Properties.GetRowByKeyValue(edit.EditValue) as DataRowView).Row;
            Program.maLoaiDau = dr["idLoaiDau"].ToString();
            flag_ktathongtindau = 1;

        }

        private void ThemTSDV_Load(object sender, EventArgs e)
        {
            tbthoigian.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,fff");
            LayTatCaThongTinLoaiDau(gridLookUpEditDau);
        }

        public void LayTatCaThongTinLoaiDau(GridLookUpEdit grid)
        {
            DataSet data = new DataSet();
            string sql = "LayTatCaDau";
            connection connect = new connection();
            data = connect.FillDataSet(sql, CommandType.StoredProcedure);
            string field = "idLoaiDau";
            grid.Properties.DataSource = null;
            grid.Properties.DataSource = data.Tables[0];
            grid.Properties.DisplayMember = field;
        }
    }
}