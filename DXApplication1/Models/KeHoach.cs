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

        public int MaThongTinBanDoKeHoach
        {
            get
            {
                if (BanDo != null)
                   return Program.ThongTinBanDoKeHoachSql.GetIdThongTinBanDoKeHoach(MaKeHoach, BanDo.MaBanDo);
                else
                {
                    return -1;
                }
            }
            set { MaThongTinBanDoKeHoach = value; }
        }

        public int MaThongTinFileDemKeHoach {
            get
            {
                if (FileDem != null)
                {
                    return Program.ThongTinFileDemKeHoachSql.GetIdThongTinFileDemKeHoach(MaKeHoach, FileDem.MaFile);
                }
                else
                {
                    return -1;
                }
            }
            set { MaThongTinFileDemKeHoach = value; }
        }
    }
}
