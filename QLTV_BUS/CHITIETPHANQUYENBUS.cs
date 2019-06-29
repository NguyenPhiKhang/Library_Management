using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAO;

namespace QLTV_BUS
{
    public class CHITIETPHANQUYENBUS
    {
        private static CHITIETPHANQUYENBUS instance;
        public static CHITIETPHANQUYENBUS Instance
        {
            get { if (instance == null) instance = new CHITIETPHANQUYENBUS(); return instance; }
            set => instance = value;
        }
        private CHITIETPHANQUYENBUS() { }
        public List<string> GetListPerOfAccount(string idAccount)
        {
            return CHITIETPHANQUYENDAO.Instance.GetListPerOfAccount(idAccount);
        }
        public void AddCTPhanQuyen(string idAccount, string idper, bool suspended)
        {
            CHITIETPHANQUYENDAO.Instance.AddCTPhanQuyen(idAccount, idper, suspended);
        }
    }
}
