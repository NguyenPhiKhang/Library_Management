using QLTV_DAO;
using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class ADMINBUS
    {
        private static ADMINBUS instance;

        public static ADMINBUS Instance
        {
            get { if (instance == null) instance = new ADMINBUS(); return instance; }
            set => instance = value;
        }
        private ADMINBUS() { }
        public List<ADMIN> GetInfoAdmin(string idaccount="")
        {
            return ADMINDAO.Instance.GetInfoAdmin(idaccount);
        }
    }
}
