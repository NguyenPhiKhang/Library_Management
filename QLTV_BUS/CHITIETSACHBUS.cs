using QLTV_DAO;
using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class CHITIETSACHBUS
    {
        private static CHITIETSACHBUS instance;

        public static CHITIETSACHBUS Instance
        {
            get { if (instance == null) instance = new CHITIETSACHBUS(); return instance; }
            set => instance = value;
        }
        private CHITIETSACHBUS() { }
        public List<CHITIETSACHDTO> GetListCTSach(string masach = "")
        {
            return CHITIETSACHDAO.Instance.GetListCTSach(masach);
        }
    }
}
