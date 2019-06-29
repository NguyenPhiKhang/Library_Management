using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class CHITIETPHANQUYENDAO
    {
        private static CHITIETPHANQUYENDAO instance;
        public static CHITIETPHANQUYENDAO Instance {
            get { if (instance == null) instance = new CHITIETPHANQUYENDAO(); return instance; }
            set => instance = value;
        }
        private CHITIETPHANQUYENDAO() { }
        public List<string> GetListPerOfAccount(string idAccount)
        {
            List<string> listPer = new List<string>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                List<string> list = db.CHITIETPHANQUYENs.Where(p => p.IDAccount == idAccount && p.suspended == true).Select(p => p.IDPer).ToList();
                listPer = list;
            }
            return listPer;
        }
        public void AddCTPhanQuyen(string idAccount, string idper, bool suspended)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                CHITIETPHANQUYEN ct = new CHITIETPHANQUYEN();
                ct.IDAccount = idAccount;
                ct.IDPer = idper;
                ct.suspended = suspended;
            }
        }
    }
}
