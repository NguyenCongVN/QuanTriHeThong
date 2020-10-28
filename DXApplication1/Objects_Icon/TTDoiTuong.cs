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

namespace DXApplication1.Objects_Icon
{
    public partial class TTDoiTuong : DevExpress.XtraEditors.XtraForm
    {
        public TTDoiTuong()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }

        private void lbSao_Click(object sender, EventArgs e)
        {

        }
    }
}