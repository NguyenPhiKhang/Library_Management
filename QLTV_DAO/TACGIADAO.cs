using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
   public class TACGIADAO
    {
        private static TACGIADAO instance;

        public static TACGIADAO Instance { get { if (instance == null) instance = new TACGIADAO(); return instance; }
            set => instance = value; }
        private TACGIADAO() { }
        public List<TACGIA> GetTacGia(string MaLDG)
        {
            List<TACGIA> Listltg = new List<TACGIA>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                var getldg = (from u in db.TACGIAs where u.MaTacGia == MaLDG select new { u.MaTacGia, u.TenTacGia }).SingleOrDefault();
                TACGIA ltg = new TACGIA();
                ltg.MaTacGia = getldg.MaTacGia;
                ltg.TenTacGia = getldg.TenTacGia;
                Listltg.Add(ltg);
            }
            return Listltg;
        }
    }
}
