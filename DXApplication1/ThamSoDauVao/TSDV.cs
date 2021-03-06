﻿using System;
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
            ThamSoDauVao_class thamSoDauVao = Program.thamSoDauVaoSql.LayThamSoDauVaoVoiMaKeHoach(Int32.Parse(dataGridViewTSDV.Rows[e.RowIndex].Cells["idThamSo"].Value.ToString()));
            if (thamSoDauVao != null)
            {
                tbthoigian.Text = thamSoDauVao.Thoigian.ToString("hh:mm:ss dd/MM/yyyy");
            }
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
            
            ThamSoDauVao_class thamSoDauVao = Program.thamSoDauVaoSql.LayThamSoDauVaoVoiMaThamSo(Int32.Parse(dataGridViewTSDV.Rows[dataGridViewTSDV.SelectedRows[0].Index].Cells["idThamSo"].Value.ToString()));
            if (thamSoDauVao != null)
            {
                SuaTDV suaTdv = new SuaTDV(thamSoDauVao);
                suaTdv.ShowDialog();
                Program.thamSoDauVaoSql.getDataTSDV(dataGridViewTSDV, searchLookUpEditTSDV);
            }
            else
            {
                MessageBox.Show("Có Lỗi Xảy Ra");
            }
        }
    }
}