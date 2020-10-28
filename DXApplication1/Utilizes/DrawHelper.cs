using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.MVVM.Services;
using DXApplication1.Views;
using Control = System.Windows.Forms.Control;

namespace DXApplication1.Utilizes
{
    public static class DrawHelper
    {
        public static Color GetGreenYellowRedByPropotion(double value, double max)
        {
            const int Space = 255 * 2;
            double propotion = value / max;
            if (propotion <= 0.5)
            {
                return Color.FromArgb((int)(propotion * Space), 255, 0);
            }
            else
            {
                return Color.FromArgb(255, (int)(propotion * Space) - 255, 0);
            }
        }

        public static Point ScaleImage(Point point , Size initSize , PictureBox pictureBox)
        {
            int y =(int)(((float)point.Y / initSize.Height) * pictureBox.Height);
            int x = (int)(((float)point.X / initSize.Width) * pictureBox.Width);
            return  new Point(x, y);
        }

        public static void ScrollToMouseInPictureBox(this CustomScrollPanel p 
            , Point newPoint , PictureBox picture)
        {
            Point currentPoint = picture.PointToClient(Control.MousePosition);
            int yDiff = newPoint.Y - currentPoint.Y;
            if (yDiff > 0)
            {
                //pos passed in should be positive
                using (Control c = new Control()
                {
                    Parent = p,
                    Height = 1,
                    Top = p.ClientSize.Height + yDiff,
                })
                {
                    p.ScrollControlIntoView(c);
                }
            }

            if (yDiff < 0)
            {
                //pos passed in should be negative
                using (Control c = new Control()
                {
                    Parent = p,
                    Height = 1,
                    Top = yDiff,
                })
                {
                    p.ScrollControlIntoView(c);
                }
            }

            int xDiff = newPoint.X - currentPoint.X;
            if (xDiff > 0)
            {
                //pos passed in should be positive
                using (Control c = new Control()
                {
                    Parent = p,
                    Width = 1,
                    Left = p.ClientSize.Width + xDiff,
                })
                {
                    p.ScrollControlIntoView(c);
                }
            }

            if (xDiff < 0)
            {
                //pos passed in should be negative
                using (Control c = new Control()
                {
                    Parent = p,
                    Width = 1,
                    Left = xDiff,
                })
                {
                    p.ScrollControlIntoView(c);
                }
            }
        }
    }
}
