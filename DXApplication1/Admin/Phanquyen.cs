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
using DevExpress.XtraGrid.Views.Grid;
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
        #endregion
        public Phanquyen()
        {
            InitializeComponent();
            chucvuSql = new ChucvuSql();
            chucvus = chucvuSql.GetName();
            foreach (Chucvu i in chucvus)
            {
                comboBoxChucVu.Items.Add(i.TenChucVu);
               

            }

        }
        #region Methods
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
          //  gridControlChucVu_NguoiDung.DataSource = chucvus;
            
          
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
                e.ChildList = quyens.Where(x => x.LoaiQuyenId == loaiQuyen.LoaiQuyenId).ToList();
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
            string tenChucVu = comboBoxChucVu.SelectedItem.ToString();
            gridControlDetaiPhanQuyen_Load(sender, e);
            Quyen_LoaiQuyenSql quyen_LoaiQuyenSql = new Quyen_LoaiQuyenSql();
            List<Quyen_LoaiQuyen> quyen_LoaiQuyens = new List<Quyen_LoaiQuyen>();
            quyen_LoaiQuyens = quyen_LoaiQuyenSql.GetQuyen_LoaiQuyen(tenChucVu);
            foreach(Quyen_LoaiQuyen i in quyen_LoaiQuyens)
            {
               // gridViewDetail.OptionsSelection.CheckBoxSelectorField
            }    
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}