using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Utilizes
{
    public class ComboBoxThamSoDauVao
    {
        public int MaThamSo { get; set; }

        public override string ToString()
        {
            return MaThamSo.ToString();
        }
    }
}
