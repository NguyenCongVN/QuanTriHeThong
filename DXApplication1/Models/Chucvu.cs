using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    class Chucvu: ConnectionDatabase
    {
        public enum ChucVuFeilds
        {
            TenChucVu
        }

        string _tenChucVu;
        public Chucvu()
        {

        }

        public string TenChucVu { get => _tenChucVu; set => _tenChucVu = value; }
    }
}
