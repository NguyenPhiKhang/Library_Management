using QLTV_DAO;
using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class BCTKTRATREBUS
    {
        private static BCTKTRATREBUS instance;

        public static BCTKTRATREBUS Instance
        {
            get { if (instance == null) instance = new BCTKTRATREBUS(); return instance; }
            set => instance = value;
        }
        private BCTKTRATREBUS() { }
        public List<BCTKTRATRE> GetListBCTKTraTre()
        {
            return BCTKTRATREDAO.Instance.GetListBCTKTraTre();
        }
        public void AddBCTKTraTre(string mapt, DateTime ngay)
        {
            BCTKTRATREDAO.Instance.AddBCTKTraTre(mapt, ngay);
        }
    }
}
