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

namespace DXApplication1.ThamSoDauVao
{
    public partial class SuaTDV : DevExpress.XtraEditors.XtraForm
    {
        public SuaTDV()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void SuaTDV_Load(object sender, EventArgs e)
        {
            tbmathamso.Text = Program.arr[0];
            //tbdrift_x.Text = 
            //tbdrift_y.Text = 
            //tbx_water.Text = 
            //tby_water.Text =
            //tbluongdau.Text = 
            //tbsalinity.Text = 
            //tbsign_height.Text = 
            //tbtemperature.Text = 
            //tbupward_sea.Text = 
            //tbvitrithatthoat_x.Text = 
            //tbvitrithatthoat_y.Text = 
            //tbx_wind.Text = 
            //tby_wind.Text = 
        }
    }
}