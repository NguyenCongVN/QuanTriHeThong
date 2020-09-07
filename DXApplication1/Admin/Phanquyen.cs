using DevExpress.XtraGrid.Views.Grid;
using DXApplication1.Models;
using DXApplication1.Utilizes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
namespace DXApplication1.Admin

{
    public partial class Phanquyen : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        List<LoaiQuyen> loaiQuyens;
        List<Quyen> quyens;
        List<Chucvu> chucvus;
        LoaiQuyenSql LoaiQuyenSql;
        QuyenSql QuyenSql;
        ChucvuSql chucvuSql;
        PhanQuyenSql phanQuyenSql;
       /// List include checkbox changed list
       /// 

       List<ThongTinThayDoiChucVu> removed = new List<ThongTinThayDoiChucVu>();
        List<ThongTinThayDoiChucVu> added = new List<ThongTinThayDoiChucVu>();

        ///
        #endregion

        #region Contructor
        public Phanquyen()
        {
            InitializeComponent();
            chucvuSql = new ChucvuSql();
            phanQuyenSql = new PhanQuyenSql();
            AddChucVuVaoCombobox();
            gridViewMain.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gridViewDetail.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
        }
        #endregion

        #region Methods

        public void AddChucVuVaoCombobox()
        {
            comboBoxChucVu.Text = null;
            comboBoxChucVu.Items.Clear();
            chucvus = chucvuSql.LayCacChucVu();
            foreach (Chucvu chucvu in chucvus)
            {
                ComboBoxItemPhanQuyen item = new ComboBoxItemPhanQuyen { ChucVu = chucvu };
                comboBoxChucVu.Items.Add(item);
            }

            foreach (object s in comboBoxChucVu.Items)
            {
                Console.WriteLine(s.ToString());
            }    
            
        }
        private void loadData()
        {
            loaiQuyens = new List<LoaiQuyen>();
            quyens = new List<Quyen>();
            chucvus = new List<Chucvu>();

            LoaiQuyenSql = new LoaiQuyenSql();
            QuyenSql = new QuyenSql();

            loaiQuyens = LoaiQuyenSql.SelectAll();
            quyens = QuyenSql.SelectAll();
            gridControlMainPhanQuyen.DataSource = loaiQuyens;
        }
        #endregion

        #region Events
        private void gridControlDetaiPhanQuyen_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void gridViewMain_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            // neu loai quyen khong co quyen thi dau cong khong xuat hien
            GridView view = sender as GridView;
            LoaiQuyen loaiQuyen = view.GetRow(e.RowHandle) as LoaiQuyen;

            if (loaiQuyen != null)
            {
                e.IsEmpty = !quyens.Any(x => x.LoaiQuyenId == loaiQuyen.LoaiQuyenId);
            }
        }

        private void gridViewMain_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            // load data đen grid detail
            GridView view = sender as GridView;
            LoaiQuyen loaiQuyen = view.GetRow(e.RowHandle) as LoaiQuyen;
            if (loaiQuyen != null)
            {
                if (comboBoxChucVu.SelectedItem != null)
                {
                    List<string> maQuyenTheoChucVu =
               (comboBoxChucVu.SelectedItem as ComboBoxItemPhanQuyen).ChucVu.MaQuyens;

                    quyens.ForEach((quyen) =>
                    {
                        if(maQuyenTheoChucVu.Contains(quyen.QuyenId))
                        {
                            quyen.Check = true;
                        }
                        else
                        {
                            quyen.Check = false;
                        }
                    });
                }
                e.ChildList = quyens;
            }
        }

        private void gridViewMain_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            // set 1: detail
            e.RelationCount = 1;
        }

        private void gridViewMain_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }

        private void comboBoxChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.cvu.TenChucVu = comboBoxChucVu.Text;
            gridControlDetaiPhanQuyen_Load(sender, e);
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if(comboBoxChucVu.SelectedItem == null)
            {
                MessageBox.Show("Bạn phải chọn chức vụ", "Notice Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
            else
            {
                try
                {
                    if (added.Count != 0)
                    {
                        foreach (var item in added)
                        {
                            phanQuyenSql.ThemQuyenVaoChucVu(item);
                            (comboBoxChucVu.SelectedItem as ComboBoxItemPhanQuyen).ChucVu.MaQuyens.Add(item.maQuyen);
                        }
                    }


                    if (removed.Count != 0)
                    {
                        foreach (var item in removed)
                        {
                            phanQuyenSql.XoaQuyenKhoiChucVu(item);
                            (comboBoxChucVu.SelectedItem as ComboBoxItemPhanQuyen).ChucVu.MaQuyens.Remove(item.maQuyen);
                        }
                    }

                    if (added.Count != 0 || removed.Count != 0)
                    {
                        loadData();
                        added.Clear();
                        removed.Clear();
                    }
                    MessageBox.Show("Lưu thành công", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    throw new Exception("Lưu không thành công", ex);

                }
            }    
            
        
        }

        private void gridViewMain_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            //GridView dView = gridViewMain.GetDetailView(e.RowHandle, (sender as GridView).GetVisibleDetailRelationIndex(e.RowHandle)) as GridView;
            //string cellValue = dView.GetRowCellValue(0, "QuyenId").ToString();
            //Console.WriteLine(cellValue);
            //Console.WriteLine(gridViewMain.GetRowCellDisplayText(e.RowHandle, "MoTa"));
            //dView.SetRowCellValue(0, "Check", false);
            //Console.WriteLine(dView.GetRowCellValue(0, "Check"));
        }

        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            GridView dView = gridViewMain.GetDetailView(gridViewMain.GetSelectedRows()[0], gridViewMain.GetVisibleDetailRelationIndex(gridViewMain.GetSelectedRows()[0])) as GridView;
            Quyen quyen = dView.GetFocusedRow() as Quyen;

            string maChucVu = (comboBoxChucVu.SelectedItem as ComboBoxItemPhanQuyen).ChucVu.MaChucVu;
            string maQuyen = quyen.QuyenId;
            ThongTinThayDoiChucVu item = new ThongTinThayDoiChucVu { maChucVu = maChucVu, maQuyen = maQuyen };

            if (quyen.Check)
            {
                if (added.Contains(item))
                {
                    added.Remove(item);
                }

                if (removed.Contains(item))
                    return;
                else
                {
                    removed.Add(item);
                }
            }
            else
            {
                if (removed.Contains(item))
                {
                    removed.Remove(item);
                }

                if (added.Contains(item))
                {
                    return;
                }
                else
                {
                    added.Add(item);
                }
            }
        }

        #endregion

        private void buttonThemChucVu_Click(object sender, EventArgs e)
        {
            AddChucVu chucVuForm = new AddChucVu();
            chucVuForm.ShowDialog();
        }

        private void buttonSuaChucVu_Click(object sender, EventArgs e)
        {
            if(comboBoxChucVu.SelectedItem == null)
            {
                MessageBox.Show("Bạn phải chọn chức vụ cần sửa", "Notice Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {
                SuaChucVu suaChucVu = new SuaChucVu();
                suaChucVu.ShowDialog();
            }    
        }

        private void buttonXoaChucVu_Click(object sender, EventArgs e)
        {
            if (comboBoxChucVu.SelectedItem == null)
            {
                MessageBox.Show("Bạn phải chọn chức vụ cần xoá", "Notice Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá chức vụ này", "Question message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Program.chucvuSql.XoaChucVu(Program.cvu.TenChucVu);
                }
            }
        }
    }
}