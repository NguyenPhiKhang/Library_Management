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
        public List<THELOAI> GetTheLoai(string MaTL)
        {
            List<THELOAI> Listtl = new List<THELOAI>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                var getldg = (from u in db.THELOAIs where u.MaTheLoai == MaTL select new { u.MaTheLoai, u.TenTheLoai }).SingleOrDefault();
                THELOAI ltl = new THELOAI();
                ltl.MaTheLoai = getldg.MaTheLoai;
                ltl.TenTheLoai = getldg.TenTheLoai;
                Listtl.Add(ltl);
            }
            return Listtl;
        }
    }
}
