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
            ChucVu
        }

        string _chucVu;
        public Chucvu()
        {

        }

        public string ChucVu
        {
            get { return _chucVu; }
            set
            {
                if (_chucVu != value)
                {
                    _chucVu = value;
                }
            }
        }
    }
}
