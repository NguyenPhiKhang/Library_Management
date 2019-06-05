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
        public List<LOAIDOCGIA> GetLoaiDocGia(string MaLDG = "")
        {
            List<LOAIDOCGIA> Listldg = new List<LOAIDOCGIA>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                if (MaLDG != "")
                {
                    var getldg = (from u in db.LOAIDOCGIAs where u.MaLoaiDocGia == MaLDG select new { u.MaLoaiDocGia, u.TenLoaiDocGia }).SingleOrDefault();
                    LOAIDOCGIA ldg = new LOAIDOCGIA
                    {
                        MaLoaiDocGia = getldg.MaLoaiDocGia,
                        TenLoaiDocGia = getldg.TenLoaiDocGia
                    };
                    Listldg.Add(ldg);
                }
                else
                {
                    var getldg = (from u in db.LOAIDOCGIAs select new { u.MaLoaiDocGia, u.TenLoaiDocGia });
                    foreach (var item in getldg)
                    {
                        LOAIDOCGIA ldg = new LOAIDOCGIA
                        {
                            MaLoaiDocGia = item.MaLoaiDocGia,
                            TenLoaiDocGia = item.TenLoaiDocGia
                        };
                        Listldg.Add(ldg);
                    }
                }
            }
            return Listldg;
        }
        public void UpdateLoaiDocGia(string MaLDG, string TenLDG)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                LOAIDOCGIA ldg = db.LOAIDOCGIAs.Find(MaLDG);
                ldg.TenLoaiDocGia = TenLDG;
                db.SaveChanges();
            }
        }
        public void RemoveLoaiDocGia(string MaLDG)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                LOAIDOCGIA ldg = db.LOAIDOCGIAs.Find(MaLDG);
                db.LOAIDOCGIAs.Remove(ldg);
                db.SaveChanges();
            }
        }
        public void AddLoaiDocGia(string MaLDG, string TenLDG)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                LOAIDOCGIA ldg = new LOAIDOCGIA() { MaLoaiDocGia = MaLDG, TenLoaiDocGia = TenLDG };
                db.LOAIDOCGIAs.Add(ldg);
                db.SaveChanges();
            }
        }
    }
}
