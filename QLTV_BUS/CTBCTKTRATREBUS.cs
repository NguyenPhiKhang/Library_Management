using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAO;

namespace QLTV_BUS
{
    public class CTBCTKTRATREBUS
    {
        private static CTBCTKTRATREBUS instance;

        public static CTBCTKTRATREBUS Instance
        {
            get { if (instance == null) instance = new CTBCTKTRATREBUS(); return instance; }
            set => instance = value;
        }
        private CTBCTKTRATREBUS() { }
        public void AddCTBCTKTraTre(string mabc, string maphieu, string masach, int songaytt)
        {
            CTBCTKTRATREDAO.Instance.AddCTBCTKTraTre(mabc, maphieu, masach, songaytt);
        }
    }
}
