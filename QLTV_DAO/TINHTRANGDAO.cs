using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
   public class TINHTRANGDAO
    {
        private static TINHTRANGDAO instance;

        public static TINHTRANGDAO Instance { get { if (instance == null) instance = new TINHTRANGDAO(); return instance; }
            set => instance = value; }
        private TINHTRANGDAO() { }
        public List<TINHTRANG> GetTinhTrang(string MaTT="")
        {
            List<TINHTRANG> Listltt = new List<TINHTRANG>();
            if (MaTT!="")
            {
                using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
                {
                    var getltt = (from u in db.TINHTRANGs where u.MaTinhTrang == MaTT select new { u.MaTinhTrang, u.TenTinhTrang }).SingleOrDefault();
                    TINHTRANG ltt = new TINHTRANG();
                    ltt.MaTinhTrang = getltt.MaTinhTrang;
                    ltt.TenTinhTrang = getltt.TenTinhTrang;
                    Listltt.Add(ltt);
                }
                return Listltt;
            }
            else
            {
                using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
                {
                    var getltt = (from u in db.TINHTRANGs  select new { u.MaTinhTrang, u.TenTinhTrang });
                    foreach (var item in getltt)
                    {
                        TINHTRANG ltt = new TINHTRANG();
                        ltt.MaTinhTrang = item.MaTinhTrang;
                        ltt.TenTinhTrang = item.TenTinhTrang;
                        Listltt.Add(ltt);
                    }
                }
                return Listltt;
            }
        }
    }
}
