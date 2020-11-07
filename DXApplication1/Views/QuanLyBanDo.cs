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
using Braincase.USGS.DEM;

namespace DXApplication1.Views
{
    public partial class QuanLyBanDo : DevExpress.XtraEditors.XtraForm
    {
        int opt = 0;
        FileDemSql demSql = new FileDemSql();
        public QuanLyBanDo()
        {
            InitializeComponent();
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            txtMKH.ReadOnly = false;
            simpleButtonHuy.Visible = true;
            simpleButtonXN.Visible = true;
            txtDuongDan.ReadOnly = false;
            txtTenFile.ReadOnly = false;
            opt = 1;
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (System.IO.File.Exists(dialog.FileName))
                {
                    txtDuongDan.Text = dialog.FileName;
                }
            }

        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            simpleButtonHuy.Visible = true;
            simpleButtonXN.Visible = true;
            txtDuongDan.ReadOnly = false;
            txtMKH.ReadOnly = false;
            opt = 2;
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            simpleButtonHuy.Visible = true;
            simpleButtonXN.Visible = true;
            opt = 3;
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            simpleButtonHuy.Visible = false;
            simpleButtonXN.Visible = false;
            txtDuongDan.ReadOnly = true;
            txtTenFile.ReadOnly = true;
        }

        private void simpleButtonXN_Click(object sender, EventArgs e)
        {
            if(opt == 1)
            {
                if(txtDuongDan.Text == null || txtTenFile.Text == null || txtMKH.Text == null)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin", "Error???");
                }    
                else
                {
                    Dem fdem = new Dem(txtTenFile.Text, txtDuongDan.Text, Convert.ToInt32(txtMKH.Text));
                    if(demSql.Insert_FileDem(fdem) == true)
                    {
                        MessageBox.Show("Thêm thành công!");
                        simpleButtonHuy.Visible = false;
                        simpleButtonXN.Visible = false;
                        txtDuongDan.ReadOnly = true;
                        txtTenFile.ReadOnly = true;
                        txtMKH.ReadOnly = true;
                        loadTable();
                    }    
                }    
            }  
            else if(opt == 2)
            {
                if (txtDuongDan.Text == null || txtTenFile.Text == null)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin", "Error???");
                }
                else
                {
                    Dem fdem = new Dem(txtTenFile.Text, txtDuongDan.Text, Convert.ToInt32(txtMKH.Text));
                    if (demSql.UpdateDem(fdem) == true)
                    {
                        MessageBox.Show("Sửa thành công!");
                        simpleButtonHuy.Visible = false;
                        simpleButtonXN.Visible = false;
                        txtDuongDan.ReadOnly = true;
                        txtMKH.ReadOnly = true;
                        loadTable();
                    }
                }    
            }
            else if (opt == 3)
            {
                    Dem fdem = new Dem(txtTenFile.Text, txtDuongDan.Text, Convert.ToInt32(txtMKH.Text));
                    if (demSql.DeleteDem(fdem) == true)
                    {
                        MessageBox.Show("Xóa thành công!");
                        simpleButtonHuy.Visible = false;
                        simpleButtonXN.Visible = false;
                        loadTable();


                    }
            }

        }

        private void simpleButtonMo_Click(object sender, EventArgs e)
        {
            if (dataGridViewDSDem.SelectedRows == null)
            {
                MessageBox.Show("Hãy chọn kế hoạch để mở");
            }
            else
            {
                Program.frm_Map.path = txtDuongDan.Text;

                Frm_test1._mDem = new DemDocument();
                Frm_test1._mDem.Read(txtDuongDan.Text);
                Program.frm_Map.txtOutput.Text = string.Empty;
                Program.frm_Map.txtOutput.Text += "DEM Name: " + new string(Frm_test1._mDem.ARecord.file_name) + Environment.NewLine;
                Program.frm_Map.txtOutput.Text += "SE Coord: " + new string(Frm_test1._mDem.ARecord.SE_geographic_corner_S) + ", " +
                                  new string(Frm_test1._mDem.ARecord.SE_geographic_corner_E) + Environment.NewLine;
                Program.frm_Map.txtOutput.Text += "DEM Level Code: " + Frm_test1._mDem.ARecord.dem_level_code + Environment.NewLine;
                Program.frm_Map.txtOutput.Text += "Ground Reference System: " +
                                  (GROUND_REF_SYSTEM)Frm_test1._mDem.ARecord.ground_ref_system + Environment.NewLine;
                Program.frm_Map.txtOutput.Text += "Ground Reference Zone: " + Frm_test1._mDem.ARecord.ground_ref_zone + Environment.NewLine;
                Program.frm_Map.txtOutput.Text += "Ground Unit: " + (GROUND_UNIT)Frm_test1._mDem.ARecord.ground_unit + Environment.NewLine;
                Program.frm_Map.txtOutput.Text += "Elevation Unit: " + (ELEVATION_UNIT)Frm_test1._mDem.ARecord.elevation_unit +
                                  Environment.NewLine;
                Program.frm_Map.txtOutput.Text += "Ground Resolution (lat, lng, elev): " + Frm_test1._mDem.ARecord.xyz_resolution[0] + ", " +
                                  Frm_test1._mDem.ARecord.xyz_resolution[1] + ", " + Frm_test1._mDem.ARecord.xyz_resolution[2] +
                                  Environment.NewLine;
                Program.frm_Map.txtOutput.Text += "Elavation Array Szie: " + Frm_test1._mDem.ARecord.northings_rows + " x " +
                                  Frm_test1._mDem.ARecord.eastings_cols + Environment.NewLine;
                Program.frm_Map.txtOutput.Text += "Percentage void: " + Frm_test1._mDem.ARecord.percent_void + Environment.NewLine;
                Program.frm_Map.txtOutput.Text += "SW Coord: " + Frm_test1._mDem.ARecord.sw_coord[0] + ", " + Frm_test1._mDem.ARecord.sw_coord[1] +
                                  Environment.NewLine;
                Program.frm_Map.txtOutput.Text += "NW Coord: " + Frm_test1._mDem.ARecord.nw_coord[0] + ", " + Frm_test1._mDem.ARecord.nw_coord[1] +
                                  Environment.NewLine;
                Program.frm_Map.txtOutput.Text += "NE Coord: " + Frm_test1._mDem.ARecord.ne_coord[0] + ", " + Frm_test1._mDem.ARecord.ne_coord[1] +
                                  Environment.NewLine;
                Program.frm_Map.txtOutput.Text += "SE Coord: " + Frm_test1._mDem.ARecord.se_coord[0] + ", " + Frm_test1._mDem.ARecord.se_coord[1] +
                                  Environment.NewLine;

            }
        }
        public void loadTable()
        {
            demSql.SelectAllFileDem(dataGridViewDSDem, searchLookUpEditDSNV);
        }
        private void FileDem_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void dataGridViewDSDem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtTenFile.Text = dataGridViewDSDem.CurrentRow.Cells[1].Value.ToString();
            txtDuongDan.Text = dataGridViewDSDem.CurrentRow.Cells[2].Value.ToString();
            txtMKH.Text = dataGridViewDSDem.CurrentRow.Cells[3].Value.ToString();

        }

        private void dataGridViewDSDem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewDSDem.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}