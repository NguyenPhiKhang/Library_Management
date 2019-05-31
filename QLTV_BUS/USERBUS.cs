using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAO;

namespace QLTV_BUS
{
    public class USERBUS
    {
        private static USERBUS instance;
        public static USERBUS Instance
        {
            get { if (instance == null) instance = new USERBUS(); return instance; }
            set => instance = value;
        }
        private USERBUS() { }
        public void UpdateInfoUser(string username, string password)
        {
            QLTV_DAO.USERDAO.Instance.UpdateInfoUser(username, password);
        }
        public void RemoveInfoUser(string IdUser)
        {
            USERDAO.Instance.RemoveInfoUser(IdUser);
        }
        public void AddInfoUser(string username, string password)
        {
            USERDAO.Instance.AddInfoUser(username, password);
        }
    }
}
