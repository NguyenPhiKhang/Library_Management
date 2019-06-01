using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class TINHTRANGBUS
    {
        private static TINHTRANGBUS instance;

        public static TINHTRANGBUS Instance { get { if (instance == null) instance = new TINHTRANGBUS(); return instance; }
            set => instance = value; }
        private TINHTRANGBUS() { }
        public List<TINHTRANG> GetTinhTrang(string MaTT="")
        {
            return QLTV_DAO.TINHTRANGDAO.Instance.GetTinhTrang(MaTT);
        }
    }
}
