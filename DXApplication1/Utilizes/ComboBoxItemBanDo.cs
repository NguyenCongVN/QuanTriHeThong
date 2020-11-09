using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Utilizes
{
    public class ComboBoxItemBanDo
    {
        public int MaBanDo { get; set; }
        public string TenBanDo { get; set; }
        public bool checkComboBox { get; set; } // true = ma , false = ten

        public override string ToString()
        {
            if(checkComboBox == true)
            return this.MaBanDo.ToString();
            else
            {
                return this.TenBanDo;
            }
        }
    }
}
