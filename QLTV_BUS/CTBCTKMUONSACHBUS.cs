using QLTV_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class CTBCTKMUONSACHBUS
    {
        private static CTBCTKMUONSACHBUS instance;

        public static CTBCTKMUONSACHBUS Instance
        {
            get { if (instance == null) instance = new CTBCTKMUONSACHBUS(); return instance; }
            set => instance = value;
        }
        private CTBCTKMUONSACHBUS() { }
        public void AddCTBCMuonSach(string mabc, string matl, int soluotmuon, double tile)
        {
            CTBCTKMUONSACHDAO.Instance.AddCTBCMuonSach(mabc, matl, soluotmuon, tile);
        }
    }
}
