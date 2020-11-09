using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    public class ThongTinChiTietDoiTuong
    {
        public int MaDoiTuong { get; set; }
        public string MaDonVi { get; set; }
        public string MoTa { get; set; }
        public int ToaDoX { get; set; }
        public int ToaDoY { get; set; }
        public int MaKeHoach { get; set; }
        public int ChieuRongAnh { get; set; }
        public int ChieuDaiAnh { get; set; }
        public int ChieuNgang { get; set; }
        public int ChieuDoc { get; set; }
        public string TenDoiTuong { get; set; }
    }
}