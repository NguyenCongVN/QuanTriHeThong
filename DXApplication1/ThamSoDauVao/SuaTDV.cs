using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.Utils.OAuth;
using DevExpress.XtraEditors;
using DXApplication1.Models;

namespace DXApplication1.ThamSoDauVao
{
    public partial class SuaTDV : DevExpress.XtraEditors.XtraForm
    {
        public ThamSoDauVao_class ThamSoDauVaoClass { get; set; }
        public SuaTDV(ThamSoDauVao_class thamSoDauVao)
        {
            ThamSoDauVaoClass = thamSoDauVao;
            InitializeComponent();
            gridLookUpEditDau.Properties.DataSource = Program.thamSoDauVaoSql.GetLoaiDau();
            gridLookUpEditDau.Properties.ValueMember = "idLoaiDau";
            gridLookUpEditDau.Properties.DisplayMember = "TenLoaiDau";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ThamSoDauVao_class thamSoDauVao = new ThamSoDauVao_class()
                {
                    Drift_x = double.Parse(tbdrift_x.Text),
                    Drift_y = double.Parse(tbdrift_y.Text),
                    IdLoaiDau = gridLookUpEditDau.EditValue.CastTo<int>(),
                    Luongdau = double.Parse(tbluongdau.Text),
                    Salinity = double.Parse(tbsalinity.Text),
                    Sign_height = double.Parse(tbsign_height.Text),
                    Temperature = double.Parse(tbtemperature.Text),
                    Thoigian = DateTime.Parse(tbthoigian.Text),
                    Upward_sea = double.Parse(tbupward_sea.Text),
                    Vitr_y = int.Parse(tbvitrithatthoat_y.Text),
                    Vitri_x = int.Parse(tbvitrithatthoat_x.Text),
                    X_water = double.Parse(tbx_water.Text),
                    Y_water = double.Parse(tby_water.Text),
                    X_wind = double.Parse(tbx_wind.Text),
                    Y_wind = double.Parse(tby_wind.Text),
                    Mathamso = int.Parse(tbmathamso.Text)
                };
                Program.thamSoDauVaoSql.UpdateThamSoDauVao(thamSoDauVao);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Có Lỗi Xảy Ra");
            }
            
        }

        private void SuaTDV_Load(object sender, EventArgs e)
        {
            if (ThamSoDauVaoClass != null)
            {
                tbmathamso.Text = ThamSoDauVaoClass.Mathamso.ToString();
                tbdrift_x.Text = ThamSoDauVaoClass.Drift_x.ToString();
                tbdrift_y.Text = ThamSoDauVaoClass.Drift_y.ToString();
                tbx_water.Text = ThamSoDauVaoClass.X_water.ToString();
                tby_water.Text = ThamSoDauVaoClass.Y_water.ToString();
                tbluongdau.Text = ThamSoDauVaoClass.Luongdau.ToString();
                tbsalinity.Text = ThamSoDauVaoClass.Salinity.ToString();
                tbsign_height.Text = ThamSoDauVaoClass.Sign_height.ToString();
                tbtemperature.Text = ThamSoDauVaoClass.Temperature.ToString();
                tbupward_sea.Text = ThamSoDauVaoClass.Upward_sea.ToString();
                tbvitrithatthoat_x.Text = ThamSoDauVaoClass.Vitri_x.ToString();
                tbvitrithatthoat_y.Text = ThamSoDauVaoClass.Vitr_y.ToString();
                tbx_wind.Text = ThamSoDauVaoClass.X_wind.ToString();
                tby_wind.Text = ThamSoDauVaoClass.Y_wind.ToString();
                tbthoigian.Text = ThamSoDauVaoClass.Thoigian.ToString("hh:mm:ss dd/MM/yyyy");
                gridLookUpEditDau.EditValue = ThamSoDauVaoClass.IdLoaiDau;
            }
        }
    }
}