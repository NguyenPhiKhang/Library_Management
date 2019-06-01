using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class THELOAIDAO
    {
        private static THELOAIDAO instance;

        public static THELOAIDAO Instance {
            get { if (instance == null) instance = new THELOAIDAO(); return instance; }

            set => instance = value; }
        private THELOAIDAO() { }
        public List<THELOAI> GetTheLoai(string MaTL = "")
        {
            List<THELOAI> Listtl = new List<THELOAI>();

            if (MaTL != "")
            {
                using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
                {
                    var getltl = (from u in db.THELOAIs where u.MaTheLoai == MaTL select new { u.MaTheLoai, u.TenTheLoai }).SingleOrDefault();
                    THELOAI ltl = new THELOAI();
                    ltl.MaTheLoai = getltl.MaTheLoai;
                    ltl.TenTheLoai = getltl.TenTheLoai;
                    Listtl.Add(ltl);
                }
                return Listtl;
            }
            else
            {
                using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
                {
                    var getltl = (from u in db.THELOAIs  select new { u.MaTheLoai, u.TenTheLoai });
                    foreach (var item in getltl)
                    {
                        THELOAI ltl = new THELOAI();
                        ltl.MaTheLoai = item.MaTheLoai;
                        ltl.TenTheLoai = item.TenTheLoai;
                        Listtl.Add(ltl);
                    }
                }
                return Listtl;
            }
        }
    }
}
