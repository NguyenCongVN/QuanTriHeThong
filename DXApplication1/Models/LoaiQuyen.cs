using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    class LoaiQuyen : ConnectionDatabase
    {
        #region Inner Class
        public enum LoaiQuyenFields
        {
            LoaiQuyenId,
            MoTa
        }

        #endregion

        string _loaiQuyenId;
        string _moTa;

        public LoaiQuyen() {

        }

        #region Properties
        public string LoaiQuyenId
        {
            get { return _loaiQuyenId; }
            set
            {
                if (_loaiQuyenId != value)
                {
                    _loaiQuyenId = value;
                }
            }
        }

        public string MoTa
        {
            get { return _moTa; }
            set
            {
                if(_moTa != value)
                {
                    _moTa = value;
                }    
            }
        }
        #endregion

    }
}
