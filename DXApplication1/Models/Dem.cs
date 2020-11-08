using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    class Dem
    {
        string _TenFile;
        string _Duongdan;
        int maKH;

        public Dem()
        {

        }
        public Dem(string ten, string duongdan, int mkh)
        {
            this._TenFile = ten;
            this._Duongdan = duongdan;
            this.maKH = mkh;
        }
        public enum FileFields
        {
            TenFile,
            DuongDan,
            MaKeHoach
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
        public int MaKeHoach
        {
            get { return maKH; }
            set
            {
                if (maKH != value)
                {
                    maKH = value;
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
