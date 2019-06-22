using QLTV_DAO;
using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class PERMISSIONBUS
    {
        private static PERMISSIONBUS instance;

        public static PERMISSIONBUS Instance
        {
            get { if (instance == null) instance = new PERMISSIONBUS(); return instance; }
            set => instance = value;
        }
        private PERMISSIONBUS() { }
        public List<PERMISSION> GetInfoPermission(string idper = "")
        {
            return PERMISSIONDAO.Instance.GetInfoPermission(idper);
        }
    }
}
