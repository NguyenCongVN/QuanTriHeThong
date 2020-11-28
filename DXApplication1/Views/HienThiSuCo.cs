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

namespace DXApplication1.Views
{
    public partial class HienThiSuCo : DevExpress.XtraEditors.XtraForm
    {
        SuCosql cosql = new SuCosql();
        int opt = 0;
        public HienThiSuCo()
        {
            InitializeComponent();
        }
        public void loadTable()
        {
            cosql.SelectAllSuCo(dataGridViewDSDem, searchLookUpEditDSNV);
        }
        private void dataGridViewDSDem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewDSDem.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void simpleButtonXN_Click(object sender, EventArgs e)
        {
            if (opt == 1)
            {
                if (txtMaKH.Text == "" || txtMaSC.Text == "" || txtDD.Text == "" || txtDT.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin", "Error???");
                }
                else
                {
                    SuCo su = new SuCo(Convert.ToInt32(txtMaSC.Text), Convert.ToInt32(txtMaKH.Text), txtDD.Text, Convert.ToInt32(txtDT.Text) );
                    if (cosql.Insert_SuCo(su) == true)
                    {
                        MessageBox.Show("Thêm thành công!");
                        simpleButtonHuy.Visible = false;
                        simpleButtonXN.Visible = false;
                        txtMaKH.ReadOnly = false;
                        txtMaSC.ReadOnly = false;
                        txtDT.ReadOnly = false;
                        txtDD.ReadOnly = false;
                        loadTable();
                    }
                }
            }
            else if (opt == 2)
            {
                if (txtMaKH.Text == "" || txtMaSC.Text == "" || txtDD.Text == "" || txtDT.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin", "Error???");
                }
                else
                {
                    SuCo su = new SuCo(Convert.ToInt32(txtMaSC.Text), Convert.ToInt32(txtMaKH.Text), txtDD.Text, Convert.ToInt32(txtDT.Text));
                    if (cosql.UpdateSuCo(su) == true)
                    {
                        MessageBox.Show("Sửa thành công!");
                        simpleButtonHuy.Visible = false;
                        simpleButtonXN.Visible = false;
                        txtMaKH.ReadOnly = true;
                        txtMaSC.ReadOnly = true;
                        txtDT.ReadOnly = true;
                        txtDD.ReadOnly = true;
                        loadTable();
                    }
                    
                }
            }
            else if (opt == 3)
            {
                if (txtMaSC.Text == "")
                {
                    MessageBox.Show("Bạn phải chọn 1 sự cố trong bảng", "Error???");
                }
                else
                {
                    SuCo su = new SuCo(Convert.ToInt32(txtMaSC.Text), Convert.ToInt32(txtMaKH.Text), txtDD.Text, Convert.ToInt32(txtDT.Text));
                    if (cosql.DeleteSuCo(su) == true)
                    {
                        MessageBox.Show("Xóa thành công!");
                        simpleButtonHuy.Visible = false;
                        simpleButtonXN.Visible = false;
                        loadTable();
                    }
                    
                }

            }
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            opt = 1;
            simpleButtonHuy.Visible = true;
            simpleButtonXN.Visible = true;
            txtMaKH.ReadOnly = false;
            txtDT.ReadOnly = false;
            txtDD.ReadOnly = false;
            txtMaSC.ReadOnly = false;
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            opt = 2;
            simpleButtonHuy.Visible = true;
            simpleButtonXN.Visible = true;
            txtMaKH.ReadOnly = false;
            txtDT.ReadOnly = false;
            txtDD.ReadOnly = false;
            
        }

        private void HienThiSuCo_Load(object sender, EventArgs e)
        {
            loadTable();
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
            txtMaKH.ReadOnly = true;
            txtDT.ReadOnly = true;
            txtDD.ReadOnly = true;
            txtMaSC.ReadOnly = true;
        }

        private void dataGridViewDSDem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
                txtMaKH.Text = dataGridViewDSDem.CurrentRow.Cells[1].Value.ToString();
                txtMaSC.Text = dataGridViewDSDem.CurrentRow.Cells[2].Value.ToString();
                txtDD.Text = dataGridViewDSDem.CurrentRow.Cells[3].Value.ToString();
                txtDT.Text = dataGridViewDSDem.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void searchLookUpEditDSNV_EditValueChanged(object sender, EventArgs e)
        {
            searchLookUpEditDSNV.Text = "";
            var view = searchLookUpEditDSNV.Properties.View;
            int row = view.FocusedRowHandle;
            string fieldMakh = "MaKeHoach";
            string fieldMaSC = "MaSC";
            string fieldDiaDanh = "DiaDanh";
            string fieldDienTich = "DienTich";



            object valueMaKH = view.GetRowCellValue(row, fieldMakh);
            object valueMaSC = view.GetRowCellValue(row, fieldMaSC);
            object valueDiaDanh = view.GetRowCellValue(row, fieldDiaDanh);
            object valueDienTich = view.GetRowCellValue(row, fieldDienTich);


            txtMaKH.Text = valueMaKH.ToString();
            txtMaSC.Text = valueMaSC.ToString();
            txtDD.Text = valueDiaDanh.ToString();
            txtDT.Text = valueDienTich.ToString();
        }
    }
}