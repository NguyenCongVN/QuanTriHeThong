using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1.Utilizes
{
    public class DrawHelper
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
    }
}
