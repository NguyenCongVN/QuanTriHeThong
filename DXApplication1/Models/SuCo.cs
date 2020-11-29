using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    class SuCo
    {
        int masc;
        int makh;
        string diadanh;
        int dientich;
        public SuCo()
        {

        }
        public SuCo(int _masc, int makh, string diadanh, int dientich)
        {
            this.masc = _masc;
            this.makh = makh;
            this.diadanh = diadanh;
            this.dientich = dientich;
        }
        public enum SuCoFields
        {
            MaSC,
            
            MaKeHoach,
            DiaDanh,
            DienTich
        }
        public int MaSC
        {
            get { return masc; }
            set
            {
                if (masc != value)
                {
                    masc = value;
                }
            }
        }
        public int MaKeHoach
        {
            get { return makh; }
            set
            {
                if (makh != value)
                {
                    makh = value;
                }
            }
        }
        public string DiaDanh
        {
            get { return diadanh; }
            set
            {
                if (diadanh != value)
                {
                    diadanh = value;
                }
            }
        }
        public int DienTich
        {
            get { return dientich; }
            set
            {
                if (dientich != value)
                {
                    dientich = value;
                }
            }
        }
    }
}
