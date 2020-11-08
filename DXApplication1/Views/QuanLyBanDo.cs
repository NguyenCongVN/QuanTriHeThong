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
        public QuanLyBanDo()
        {
            InitializeComponent();
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            //comboBoxMaKeHoach. = false;
            simpleButtonHuy.Visible = true;
            simpleButtonXN.Visible = true;
            txtDuongDan.ReadOnly = false;
            txtTenBanDo.ReadOnly = false;
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
            //txtMKH.ReadOnly = false;
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
            txtTenBanDo.ReadOnly = true;
        }

        private void simpleButtonXN_Click(object sender, EventArgs e)
        {
            if (opt == 1)
            {
                if (txtDuongDan.Text == null || txtTenBanDo.Text == null /*|| txtMKH.Text == null*/)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin", "Lỗi");
                }
                else
                {
                    BanDo banDo = new BanDo()
                    {
                        DuongDanAnh = txtDuongDan.Text,
                        TenBanDo = txtTenBanDo.Text
                    };
                    try
                    {
                        Program.banDoSql.CreateMap(banDo);
                        MessageBox.Show("Thêm Thành Công");
                        simpleButtonHuy.Visible = false;
                        simpleButtonXN.Visible = false;
                        txtDuongDan.ReadOnly = true;
                        txtTenBanDo.ReadOnly = true;
                        //txtMKH.ReadOnly = true;
                        loadTable();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                        throw;
                    }
                }
            }
            else if (opt == 2)
            {
                if (txtDuongDan.Text == null || txtTenBanDo.Text == null)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin", "Error???");
                }
                else
                {
                    //BanDo banDo = new BanDo()
                    //{
                    //    MaBanDo = 
                    //};
                    //if (demSql.UpdateDem(fdem) == true)
                    //{
                    //    MessageBox.Show("Sửa thành công!");
                    //    simpleButtonHuy.Visible = false;
                    //    simpleButtonXN.Visible = false;
                    //    txtDuongDan.ReadOnly = true;
                    //    txtMKH.ReadOnly = true;
                    //    loadTable();
                    //}
                }
            }
            else if (opt == 3)
            {
                //Dem fdem = new Dem(txtTenBanDo.Text, txtDuongDan.Text, Convert.ToInt32(txtMKH.Text));
                //if (demSql.DeleteDem(fdem) == true)
                //{
                //    MessageBox.Show("Xóa thành công!");
                //    simpleButtonHuy.Visible = false;
                //    simpleButtonXN.Visible = false;
                //    loadTable();


                //}
            }

        }

        public void loadTable()
        {
            Program.banDoSql.Select_All_Map();
        }
        private void FileDem_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void dataGridViewDSDem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtTenBanDo.Text = dataGridViewDSDem.CurrentRow.Cells[1].Value.ToString();
            txtDuongDan.Text = dataGridViewDSDem.CurrentRow.Cells[2].Value.ToString();
            //txtMKH.Text = dataGridViewDSDem.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridViewDSDem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewDSDem.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}