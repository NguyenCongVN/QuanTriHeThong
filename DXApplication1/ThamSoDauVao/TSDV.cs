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
using DXApplication1.Utilizes;
using DXApplication1.Models;
using DXApplication1.ThamSoDauVao;

namespace DXApplication1.Views
{
    public partial class TSDV : DevExpress.XtraEditors.XtraForm
    {
        public TSDV()
        {
            InitializeComponent();
            DesignHelper.CenterControl(sidePanelThamSoDauVao);
        }

      
        public void ThamSoDauVao_Load(object sender, EventArgs e)
        {
            Program.thamSoDauVaoSql = new Models.ThamSoDauVaoSql();
            Program.thamSoDauVaoSql.getDataTSDV(dataGridViewTSDV, searchLookUpEditTSDV);
        }
        private void getDataFromDgvIntoTextBox(TextBox tb, int row, string column)
        {
            //tb = new TextBox();
            tb.Text = dataGridViewTSDV.Rows[row].Cells[column].Value.ToString();
        }

        private void dataGridViewTSDV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            getDataFromDgvIntoTextBox(tbmathamso, numrow, "idThamSo");
            Program.arr[0] = tbmathamso.Text;
            getDataFromDgvIntoTextBox(tbx_water, numrow, "x_water_velocity");
            Program.arr[1] = tbx_water.Text;
            getDataFromDgvIntoTextBox(tby_water, numrow, "y_water_velocity");
            Program.arr[2] = tby_water.Text;
            getDataFromDgvIntoTextBox(tbx_wind, numrow, "x_wind");
            Program.arr[3] = tbx_wind.Text;
            getDataFromDgvIntoTextBox(tby_wind, numrow, "y_wind");
            Program.arr[4] = tby_wind.Text;
            getDataFromDgvIntoTextBox(tbupward_sea, numrow, "upward_velocity");
            Program.arr[5] = tbupward_sea.Text;
            getDataFromDgvIntoTextBox(tbsign_height, numrow, "significant_height");
            Program.arr[6] = tbsign_height.Text;
            getDataFromDgvIntoTextBox(tbdrift_x, numrow, "stokes_drift_x");
            Program.arr[7] = tbdrift_x.Text;
            getDataFromDgvIntoTextBox(tbdrift_y, numrow, "stokes_drift_y");
            Program.arr[8] = tbdrift_y.Text;
            getDataFromDgvIntoTextBox(tbtemperature, numrow, "temperature");
            Program.arr[9] = tbtemperature.Text;
            getDataFromDgvIntoTextBox(tbsalinity, numrow, "salinity");
            Program.arr[10] = tbsalinity.Text;
            getDataFromDgvIntoTextBox(tbmaloaidau, numrow, "idLoaiDau");
            //Program.arr[11] = tbmaloaidau.Text;
            getDataFromDgvIntoTextBox(tbvitrithatthoat_x, numrow, "vitridauthatthoat_x");
            Program.arr[12] = tbvitrithatthoat_x.Text;
            getDataFromDgvIntoTextBox(tbvitrithatthoat_y, numrow, "vitridauthatthoat_y");
            Program.arr[13] = tbvitrithatthoat_y.Text;
            getDataFromDgvIntoTextBox(tbluongdau, numrow, "khoiluongdau");
            Program.arr[14] = tbluongdau.Text;
            getDataFromDgvIntoTextBox(tbthoigian, numrow, "thoigianmophong");
            Program.arr[15] = tbthoigian.Text;
        }

       
        private void buttonThem_Click(object sender, EventArgs e)
        {
            Program.themTSDV = new ThamSoDauVao.ThemTSDV();
            Program.themTSDV.ShowDialog();

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá tham số này", "Question Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Program.thamSoDauVaoSql = new ThamSoDauVaoSql();
                Program.thamSoDauVaoSql.XoaThamSo(Convert.ToInt32(tbmathamso.Text));
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SuaTDV suaTdv = new SuaTDV();
        }

        private void searchLookUpEditTSDV_EditValueChanged(object sender, EventArgs e)
        {
            searchLookUpEditTSDV.Text = "";
            var view = searchLookUpEditTSDV.Properties.View;
            int row = view.FocusedRowHandle;
            string fieldNamemathamso = "idThamSo";
            string fieldNamex_water = "x_water_velocity";
            string fieldNamey_water = "y_water_velocity";
            string fieldNamesox_wind = "x_wind";
            string fieldNamesoy_wind = "y_wind";
            string fieldNameupward = "upward_velocity";
            string fieldNamesign_height = "significant_height";
            string fieldNamedrift_x = "stokes_drift_x";
            string fieldNamedrift_y = "stokes_drift_y";
            string fieldNametemperature = "temperature";
            string fieldNamesalinity = "salinity";
            string fieldNameidLoaiDau = "idLoaiDau";
            string fieldNamekhoiluongdau = "khoiluongdau";
            string fieldNamethoigianmophong = "thoigianmophong";
            string fieldNamevitri_x = "vitridauthatthoat_x";
            string fieldNamevitri_y = "vitridauthatthoat_y";

            object valuemaidThamSo = view.GetRowCellValue(row, fieldNamemathamso);
            object valuex_water_velocity = view.GetRowCellValue(row, fieldNamex_water);
            object valuey_water_velocity = view.GetRowCellValue(row, fieldNamey_water);
            object valuex_wind = view.GetRowCellValue(row, fieldNamesox_wind);
            object valuey_wind = view.GetRowCellValue(row, fieldNamesoy_wind);
            object valueupward_velocity = view.GetRowCellValue(row, fieldNameupward);
            object valuesignificant_height = view.GetRowCellValue(row, fieldNamesign_height);
            object valuedrift_x = view.GetRowCellValue(row, fieldNamedrift_x);
            object valuedrift_y = view.GetRowCellValue(row, fieldNamedrift_y);
            object valuetemperature = view.GetRowCellValue(row, fieldNametemperature);
            object valuesalinity = view.GetRowCellValue(row, fieldNamesalinity);
            object valueidLoaiDau = view.GetRowCellValue(row, fieldNameidLoaiDau);
            object valuekhoiluongdau = view.GetRowCellValue(row, fieldNamekhoiluongdau);
            object valuethoigianmophong = view.GetRowCellValue(row, fieldNamethoigianmophong);
            object valuevitri_x = view.GetRowCellValue(row, fieldNamevitri_x);
            object valuevitri_y = view.GetRowCellValue(row, fieldNamevitri_y);

            tbmathamso.Text = valuemaidThamSo.ToString();
            tbx_water.Text = valuex_water_velocity.ToString();
            tby_water.Text = valuey_water_velocity.ToString();
            tbx_wind.Text = valuex_wind.ToString();
            tby_wind.Text = valuey_wind.ToString();
            tbupward_sea.Text = valueupward_velocity.ToString();
            tbsign_height.Text = valuesignificant_height.ToString();
            tbdrift_x.Text = valuedrift_x.ToString();
            tbdrift_y.Text = valuedrift_y.ToString();
            tbtemperature.Text = valuetemperature.ToString();
            tbsalinity.Text = valuesalinity.ToString();
            tbmaloaidau.Text = valueidLoaiDau.ToString();
            tbluongdau.Text = valuekhoiluongdau.ToString();
            tbthoigian.Text = valuethoigianmophong.ToString();
            tbvitrithatthoat_x.Text = valuevitri_x.ToString();
            tbvitrithatthoat_y.Text = valuevitri_y.ToString();
        }
    }
}