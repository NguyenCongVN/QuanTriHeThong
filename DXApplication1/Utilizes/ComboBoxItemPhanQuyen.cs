using DXApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Utilizes
{
    public class ComboBoxItemPhanQuyen
    {
        public Chucvu ChucVu { get; set; }

        public override string ToString()
        {
            return ChucVu.TenChucVu;
        }
    }
}
