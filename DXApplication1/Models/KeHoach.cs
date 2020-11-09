using System;

namespace DXApplication1.Models
{
    public class KeHoach
    {
        public int MaKeHoach { get; set; }
        public string TenKeHoach { get; set; }
        public string MaNguoiLap { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public string TenNguoiLap { get; set; }

        public BanDo BanDo { get; set; }

        public Dem FileDem { get; set; }
    }
}
