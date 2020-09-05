using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Utilizes
{
    public class PhanQuyenHelper
    {

        // Kiểm tra xem quyền đã có ở trong List add?
        public static bool CheckInListAdd(List<ThongTinThayDoiChucVu> addList , ThongTinThayDoiChucVu tt )
        {
            if (addList.Contains(tt))
                return true;
            return false;
        }

        //

        /// Kiểm tra xem quyền đã có ở trong List remove?
        /// 

        public static bool CheckInListRemove(List<ThongTinThayDoiChucVu> removeList, ThongTinThayDoiChucVu tt)
        {
            if (removeList.Contains(tt))
                return true;
            return false;
        }

        //
    }
}
