using QLTV_DTO;
using QLTV_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class TTDOCGIABUS
    {
        private static TTDOCGIABUS instance;

        public static TTDOCGIABUS Instance
        {
            get { if (instance == null) instance = new TTDOCGIABUS(); return instance; }
            set => instance = value;
        }
        private TTDOCGIABUS() { }
        public List<TTDOCGIADTO> GetListDocGiaInfo()
        {
            return QLTV_DAO.TTDOCGIADAO.Instance.GetListDocGiaInfo();
        }
    }
}
