using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace DXApplication1.Views
{
    public class CustomScrollPanel : ScrollableControl
    {
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (!Keyboard.IsKeyDown(Key.LeftCtrl))
            {
                base.OnMouseWheel(e);
            }
        }
    }
}
