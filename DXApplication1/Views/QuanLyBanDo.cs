using DXApplication1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DXApplication1.Views
{
    public partial class QuanLyBanDo : DevExpress.XtraEditors.XtraForm
    {
        int opt = 0;
        public QuanLyBanDo()
        {
            InitializeComponent();
            QuanLyBanDo_Load();
            dataGridViewDSBanDo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            simpleButtonChonDuongDan.Visible = true;
            simpleButtonHuy.Visible = true;
            simpleButtonXN.Visible = true;
            txtDuongDan.ReadOnly = false;
            txtTenBanDo.ReadOnly = false;
            textEditMaBanDo.Text = "";
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
            txtTenBanDo.ReadOnly = false;
            simpleButtonChonDuongDan.Visible = true;
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
            simpleButtonChonDuongDan.Visible = false;
        }

        private void simpleButtonXN_Click(object sender, EventArgs e)
        {
            if (opt == 1)
            {
                if (txtDuongDan.Text == null || txtTenBanDo.Text == null)
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
                    try
                    {
                        BanDo banDo = new BanDo()
                        {
                            MaBanDo = Int32.Parse(textEditMaBanDo.Text),
                            DuongDanAnh = txtDuongDan.Text,
                            TenBanDo = txtTenBanDo.Text
                        };
                        Program.banDoSql.UpdateMap(banDo);
                        MessageBox.Show("Sửa thành công!");
                        simpleButtonHuy.Visible = false;
                        simpleButtonXN.Visible = false;
                        txtDuongDan.ReadOnly = true;
                        MessageBox.Show("Cập nhật thành công");
                        loadTable();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
            }
            else if (opt == 3)
            {
                try
                {
                    Program.banDoSql.DeleteMap(Int32.Parse(textEditMaBanDo.Text));
                    {
                        MessageBox.Show("Xóa thành công!");
                        simpleButtonHuy.Visible = false;
                        simpleButtonXN.Visible = false;
                        loadTable();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            simpleButtonChonDuongDan.Visible = false;
        }

        public void loadTable()
        {
            int i = 1;
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã Bản Đò");
            dt.Columns.Add("Tên Bản Đồ");
            dt.Columns.Add("Đường Dẫn Ảnh");
            foreach (var item in Program.banDoSql.Select_All_Map())
            {
                dt.Rows.Add(new object[]
                {
                    i.ToString(), item.MaBanDo,
                    item.TenBanDo,
                    item.DuongDanAnh
                });
                i++;
            }
            dataGridViewDSBanDo.DataSource = dt;
            
        }

        private void QuanLyBanDo_Load()
        {
            loadTable();
        }

        private void dataGridViewDSDem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textEditMaBanDo.Text = dataGridViewDSBanDo.CurrentRow.Cells[1].Value.ToString();
            txtTenBanDo.Text = dataGridViewDSBanDo.CurrentRow.Cells[2].Value.ToString();
            txtDuongDan.Text = dataGridViewDSBanDo.CurrentRow.Cells[3].Value.ToString();
        }

        private void simpleButtonChonDuongDan_Click(object sender, EventArgs e)
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

        private void labelDanhSachBanDo_Click(object sender, EventArgs e)
        {

        }
    }
}