using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
