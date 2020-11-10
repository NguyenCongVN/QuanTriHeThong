using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Utilizes
{
    public class ComboBoxItemFileDem
    {
        public int MaFile { get; set; }
        public string TenFile { get; set; }
        public bool checkComboBox { get; set; } // true = ma , false = ten
        public string DuongDan { get; set; }
        public override string ToString()
        {
            if (checkComboBox == true)
            {
                return this.MaFile.ToString();
            }
            else
            {
                return this.TenFile;
            }
        }
    }
}
