using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DTO;

namespace QLTV_DAO
{
    public class USERDAO
    {
        private static USERDAO instance;
        public static USERDAO Instance
        {
            get { if (instance == null) instance = new USERDAO();return instance; }
            set => instance = value;
        }
        private USERDAO() { }
        public void UpdateInfoUser(string username, string password)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                USER user = db.USERs.Find(username);
                user.PasswordUser = password;
                db.SaveChanges();
            }
        }
        public void RemoveInfoUser(string IdUser)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                USER user = db.USERs.Find(IdUser);
                db.USERs.Remove(user);
                db.SaveChanges();
            }
        }
        public void AddInfoUser(string username, string password)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                USER user = new USER { IDUser = username, PasswordUser = password };
                db.USERs.Add(user);
                db.SaveChanges();
            }
        }
    }
}
