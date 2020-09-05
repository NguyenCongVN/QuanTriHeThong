using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    public class Chucvu: ConnectionDatabase
    {
        public enum ChucVuFields
        {
            MaChucVu,
            TenChucVu,
            MaQuyens
        }


        public Chucvu(string maChucVu)
        {
            ChucvuSql helper = new ChucvuSql();
            MaChucVu = maChucVu;
            TenChucVu = helper.GetNameById(maChucVu);
            MaQuyens = helper.LayCacQuyenBangId(maChucVu);
        }

        public Chucvu()
        {

        }

        string _tenChucVu;

        public string TenChucVu { get => _tenChucVu; set => _tenChucVu = value; }

        private string maChucVu;

        public string MaChucVu
        {
            get { return maChucVu; }
            set { maChucVu = value; }
        }


        private List<string> maQuyens;

        public List<string> MaQuyens
        {
            get { return maQuyens; }
            set { maQuyens = value; }
        }
    }
}
