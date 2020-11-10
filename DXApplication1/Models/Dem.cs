using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    public class Dem
    {
        string _TenFile;
        string _Duongdan;

        public Dem()
        {

        }
        public Dem(string ten, string duongdan)
        {
            this._TenFile = ten;
            this._Duongdan = duongdan;
        }
        public string TenFile
        {
            get { return _TenFile; }
            set
            {
                if (_TenFile != value)
                {
                    _TenFile = value;
                }
            }
        }
        public string DuongDan
        {
            get { return _Duongdan; }
            set
            {
                if (_Duongdan != value)
                {
                    _Duongdan = value;
                }
            }
        }

        public int MaFile { get; set; }

    }
}
