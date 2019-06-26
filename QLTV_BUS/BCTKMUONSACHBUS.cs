using QLTV_DAO;
using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class BCTKMUONSACHBUS
    {
        private static BCTKMUONSACHBUS instance;

        public static BCTKMUONSACHBUS Instance
        {
            get { if (instance == null) instance = new BCTKMUONSACHBUS(); return instance; }
            set => instance = value;
        }
        private BCTKMUONSACHBUS() { }
        public List<BCTKMUONSACH> GetListBCTKmuon()
        {
            return BCTKMUONSACHDAO.Instance.GetListBCTKmuon();
        }
        public void AddBaoCaoTKMuonSach(string MaBC, DateTime Thang, int total)
        {
            BCTKMUONSACHDAO.Instance.AddBaoCaoTKMuonSach(MaBC, Thang, total);
        }
    }
}
