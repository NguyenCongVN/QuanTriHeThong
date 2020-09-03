using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    class Quyen:ConnectionDatabase
    {
        public enum QuyenFields
        {
            QuyenId,
            MoTa,
            LoaiQuyenId
        }

        string _quyenId;
        string _moTa;
        string _loaiQuyenId;

        public Quyen()
        {

        }

        #region Properties
        public string QuyenId
        {
            get { return _quyenId; }
            set
            {
                if (_quyenId != value)
                {
                    _quyenId = value;
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

        public string LoaiQuyenId
        {
            get { return _loaiQuyenId; }
            set
            {
                if(_loaiQuyenId != value)
                {
                    _loaiQuyenId = value;
                }    
            }
        }
        #endregion
    }
}
