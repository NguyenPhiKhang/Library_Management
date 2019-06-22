using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAO;
using QLTV_DTO;

namespace QLTV_BUS
{
    public class ACCOUNTBUS
    {
        private static ACCOUNTBUS instance;
        public static ACCOUNTBUS Instance
        {
            get { if (instance == null) instance = new ACCOUNTBUS(); return instance; }
            set => instance = value;
        }
        private ACCOUNTBUS() { }
        public /*async Task<*/List<ACCOUNT>/*>*/ GetInfoAccount(string idaccount = "")
        {
            return /*await*/ ACCOUNTDAO.Instance.GetInfoAccount(idaccount);
        }
        public void UpdateInfoAccount(string username, string password)
        {
            QLTV_DAO.ACCOUNTDAO.Instance.UpdateInfoAccount(username, password);
        }
        public void RemoveInfoAccount(string IdUser)
        {
            ACCOUNTDAO.Instance.RemoveInfoAccount(IdUser);
        }
        public void AddInfoAccount(string username, string password, string typeofacc)
        {
            ACCOUNTDAO.Instance.AddInfoAccount(username, password, typeofacc);
        }
    }
}
