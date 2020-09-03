using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    class Quyen_LoaiQuyen:ConnectionDatabase
    {
        string _loaiQuyen;
        string _quyen;

        public string LoaiQuyen { get => _loaiQuyen; set => _loaiQuyen = value; }
        public string Quyen { get => _quyen; set => _quyen = value; }

        public enum Quyen_LoaiQuyenFeilds
        {
            LoaiQuyen,
            Quyen
        }

        public Quyen_LoaiQuyen()
        {

        }

    }
}
