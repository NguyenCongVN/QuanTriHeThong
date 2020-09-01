using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    class NguoiDung : ConnectionDatabase
    {
        string _name;
        string _pass;

        public NguoiDung()
        {

        }
        public enum UserFields
        {
            MaDangNhapNguoiDung,
            MatKhau
        }
        public string MaDangNhapNguoiDung
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                }
            }
        }
        public string MatKhau
        {
            get { return _pass; }
            set
            {
                if (_pass != value)
                {
                    _pass = value;
                }
            }
        }
    }
   
}
