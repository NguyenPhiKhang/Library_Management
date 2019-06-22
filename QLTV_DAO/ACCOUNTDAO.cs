using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DTO;

namespace QLTV_DAO
{
    public class ACCOUNTDAO
    {
        private static ACCOUNTDAO instance;
        public static ACCOUNTDAO Instance
        {
            get { if (instance == null) instance = new ACCOUNTDAO();return instance; }
            set => instance = value;
        }
        private ACCOUNTDAO() { }
        public /*async*/ /*Task<*/List<ACCOUNT>/*>*/ GetInfoAccount(string idaccount = "")
        {
            List<ACCOUNT> listaccount = new List<ACCOUNT>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                List<ACCOUNT> list = new List<ACCOUNT>();
                if (idaccount == "")
                {
                    list = /*await*/ (from u in db.ACCOUNTs select u).ToList/*Async*/();
                }
                else list = (from u in db.ACCOUNTs where u.IDAccount == idaccount select u).ToList();
                foreach (var item in list)
                {
                    ACCOUNT ac = new ACCOUNT
                    {
                        IDAccount = item.IDAccount,
                        PasswordAccount = item.PasswordAccount,
                        TypeOfAccount = item.TypeOfAccount
                    };
                    listaccount.Add(ac);
                }
            }
            return listaccount;
        }
        public void UpdateInfoAccount(string username, string password)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                ACCOUNT ACCOUNT = db.ACCOUNTs.Find(username);
                ACCOUNT.PasswordAccount = password;
                db.SaveChanges();
            }
        }
        public void RemoveInfoAccount(string IdACCOUNT)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                ACCOUNT ACCOUNT = db.ACCOUNTs.Find(IdACCOUNT);
                db.ACCOUNTs.Remove(ACCOUNT);
                db.SaveChanges();
            }
        }
        public void AddInfoAccount(string username, string password, string typeofacc)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                ACCOUNT ACCOUNT = new ACCOUNT { IDAccount = username, PasswordAccount = password, TypeOfAccount = typeofacc };
                db.ACCOUNTs.Add(ACCOUNT);
                db.SaveChanges();
            }
        }
    }
}
