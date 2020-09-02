using System;

namespace DXApplication1.Models
{
    class ThongTinNguoiDung : ConnectionDatabase
    {
        private string maDangNhapNguoiDung;

        public string MaDangNhapNguoiDung
        {
            get { return maDangNhapNguoiDung; }
            set { maDangNhapNguoiDung = value; }
        }

        private string soDienThoai;

        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private DateTime ngayTao;

        public DateTime NgayTao
        {
            get { return ngayTao; }
            set { ngayTao = value; }
        }

        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }


        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
    }
}
