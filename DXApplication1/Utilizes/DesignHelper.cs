using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.Utilizes
{
    public class DesignHelper
    {
        public static void CenterControl(Control control)
        {
            control.Location = new Point((control.Parent.ClientSize.Width / 2) - (control.Width / 2),
                (control.Parent.ClientSize.Height / 2) - (control.Height / 2));
        }


        public static void AlignControlLocationX(Control control)
        {
            control.Location = new Point((control.Parent.ClientSize.Width / 2) - (control.Width / 2),
                control.Location.Y);
        }

        public static void AlignControlLocationY(Control control)
        {
            control.Location = new Point(control.Location.X,
                (control.Parent.ClientSize.Height / 2) - (control.Height / 2));
        }
    }
}
