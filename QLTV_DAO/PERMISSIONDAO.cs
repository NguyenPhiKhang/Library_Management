using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class PERMISSIONDAO
    {
        private static PERMISSIONDAO instance;

        public static PERMISSIONDAO Instance
        {
            get { if (instance == null) instance = new PERMISSIONDAO(); return instance; }
            set => instance = value;
        }
        private PERMISSIONDAO() { }
        public List<PERMISSION> GetInfoPermission(string idper = "")
        {
            List<PERMISSION> listper = new List<PERMISSION>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                List<PERMISSION> list = new List<PERMISSION>();
                if (idper == "")
                    list = (from u in db.PERMISSIONs select u).ToList();
                else list = (from u in db.PERMISSIONs where u.IDPer == idper select u).ToList();
                foreach (var item in list)
                {
                    PERMISSION per = new PERMISSION
                    {
                        IDPer = item.IDPer,
                        NamePer = item.NamePer,
                        CodeAction = item.CodeAction,
                        Description = item.Description
                    };
                    listper.Add(per);
                }
            }
            return listper;
        }

    }
}
