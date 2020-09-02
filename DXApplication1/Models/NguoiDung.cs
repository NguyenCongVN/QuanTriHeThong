namespace DXApplication1.Models
{
    class NguoiDung : ConnectionDatabase
    {
        string _name;
        string _pass;
        string _chucVu;
        ThongTinNguoiDung _thongTinNguoiDung;

        public NguoiDung()
        {

        }
        public enum UserFields
        {
            MaDangNhapNguoiDung,
            MatKhau,
            ThongTinNguoiDung
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


        public ThongTinNguoiDung ThongTinNguoiDung
        {
            get { return _thongTinNguoiDung; }
            set
            {
                if (_thongTinNguoiDung != value)
                {
                    _thongTinNguoiDung = value;
                }
            }
        }

    }
}
