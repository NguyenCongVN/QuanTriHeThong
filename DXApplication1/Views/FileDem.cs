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
    public partial class FileDem : DevExpress.XtraEditors.XtraForm
    {
        int opt = 0;
        FileDemSql demSql = new FileDemSql();
        public FileDem()
        {
            InitializeComponent();
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            simpleButtonHuy.Visible = true;
            simpleButtonXN.Visible = true;
            txtDuongDan.ReadOnly = false;
            txtTenFile.ReadOnly = false;
            opt = 1;
            var dialog = new OpenFileDialog();
            dialog.Filter = "Dem File (*.dem)|*.dem|All Files (*.*)|*.*";
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
            txtTenFile.ReadOnly = false;
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
                if(txtDuongDan.Text == null || txtTenFile.Text == null)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin", "Error???");
                }    
                else
                {
                    Dem fdem = new Dem(txtTenFile.Text, txtDuongDan.Text);
                    if(demSql.Insert_FileDem(fdem) == true)
                    {
                        MessageBox.Show("Thêm thành công!");
                        simpleButtonHuy.Visible = false;
                        simpleButtonXN.Visible = false;
                        txtDuongDan.ReadOnly = true;
                        txtTenFile.ReadOnly = true;
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
                    Dem fdem = new Dem(){TenFile = txtTenFile.Text,DuongDan = txtDuongDan.Text , MaFile = Int32.Parse(textEditMaFile.Text) };
                    if (demSql.UpdateDem(fdem) == true)
                    {
                        MessageBox.Show("Sửa thành công!");
                        simpleButtonHuy.Visible = false;
                        simpleButtonXN.Visible = false;
                        txtDuongDan.ReadOnly = true;
                        loadTable();
                    }
                }
            }
            else if (opt == 3)
            {
                if (txtTenFile.Text == null)
                {
                    MessageBox.Show("Bạn phải chọn 1 file trong bảng", "Error???");
                }
                else
                {
                    Dem fdem = new Dem(){TenFile = txtTenFile.Text,DuongDan = txtDuongDan.Text , MaFile = Int32.Parse(textEditMaFile.Text)};
                    if (demSql.DeleteDem(fdem) == true)
                    {
                        MessageBox.Show("Xóa thành công!");
                        simpleButtonHuy.Visible = false;
                        simpleButtonXN.Visible = false;
                        loadTable();
                    }
                }    
                
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
            if(dataGridViewDSDem.SelectedRows.Count > 0)
            {
                txtTenFile.Text = dataGridViewDSDem.SelectedRows[0].Cells["TenFile"].Value.ToString();
                txtDuongDan.Text = dataGridViewDSDem.SelectedRows[0].Cells["DuongDan"].Value.ToString();
                textEditMaFile.Text = dataGridViewDSDem.SelectedRows[0].Cells["MaFile"].Value.ToString();
            }
        }

        private void dataGridViewDSDem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewDSDem.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void simpleButtonMo_Click(object sender, EventArgs e)
        {
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

        private void searchLookUpEditDSNV_EditValueChanged(object sender, EventArgs e)
        {
            searchLookUpEditDSNV.Text = "";
            var view = searchLookUpEditDSNV.Properties.View;
            int row = view.FocusedRowHandle;
            string fieldTenFile = "TenFile";
            string fieldDuongDan = "DuongDan";
            string fieldMaKeHoach = "MaKeHoach";
            

            object valueTenFile = view.GetRowCellValue(row, fieldTenFile);
            object valueDuongDan = view.GetRowCellValue(row, fieldDuongDan);
            object valueMaKeHoach = view.GetRowCellValue(row, fieldMaKeHoach);
            

            txtTenFile.Text = valueTenFile.ToString();
            txtDuongDan.Text = valueDuongDan.ToString();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}