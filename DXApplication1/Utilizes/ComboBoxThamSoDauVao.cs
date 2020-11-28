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
        public string TenThamSo { get; set; }
        public bool IsID { get; set; }

        public override string ToString()
        {
            if (IsID)
            {
                return MaThamSo.ToString();
            }
            else
            {
                return TenThamSo;
            }
        }
    }
}
