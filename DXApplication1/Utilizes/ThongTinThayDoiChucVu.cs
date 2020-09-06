using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Utilizes
{
    public class ThongTinThayDoiChucVu
    {
        public string maChucVu { get; set; }
        public string maQuyen { get; set; }

        public override bool Equals(object tt)
        {
            if (tt == null) return false;
            ThongTinThayDoiChucVu compareItem = tt as ThongTinThayDoiChucVu;
            if (this.maChucVu == compareItem.maChucVu && this.maQuyen == compareItem.maQuyen)
                return true;
            return false;
        }
    }
    
}
