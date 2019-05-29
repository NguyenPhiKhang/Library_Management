using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DTO;

namespace QLTV_DAO
{
    public class LOAIDOCGIADAO
    {
        private static LOAIDOCGIADAO instance;
        public static LOAIDOCGIADAO Instance
        {
            get { if (instance == null) instance = new LOAIDOCGIADAO(); return instance; }
            set => instance = value;
        }
        private LOAIDOCGIADAO() { }
        public List<LOAIDOCGIA> GetLoaiDocGia(string MaLDG)
        {
            List<LOAIDOCGIA> Listldg = new List<LOAIDOCGIA>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                var getldg = (from u in db.LOAIDOCGIAs where u.MaLoaiDocGia == MaLDG select new { u.MaLoaiDocGia, u.TenLoaiDocGia }).SingleOrDefault();
                LOAIDOCGIA ldg = new LOAIDOCGIA();
                ldg.MaLoaiDocGia = getldg.MaLoaiDocGia;
                ldg.TenLoaiDocGia = getldg.TenLoaiDocGia;
                Listldg.Add(ldg);
            }
            return Listldg;
        }
    }
}
