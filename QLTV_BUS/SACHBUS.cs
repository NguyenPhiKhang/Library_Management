using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLTV_DAO;
using System.Threading.Tasks;

namespace QLTV_BUS
{
   public class SACHBUS
    {
        private static SACHBUS instance;

        public static SACHBUS Instance
        {
            get { if (instance == null) instance = new SACHBUS(); return instance; }
            set => instance = value;
        }
        private SACHBUS() { }
        public List<SACH> GetListSachInfo()
        {
            return QLTV_DAO.SACHDAO.Instance.GetListSachInfo();
        }
    }
}
