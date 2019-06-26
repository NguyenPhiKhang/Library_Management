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
        public TACGIADAO() { }
        public List<TACGIA> GetTacGia(string MaLDG="")
        {
            List<TACGIA> Listltg = new List<TACGIA>();
            if (MaLDG != "")
            {
                using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
                {
                    var getltg = (from u in db.TACGIAs where u.MaTacGia == MaLDG select new { u.MaTacGia, u.TenTacGia }).SingleOrDefault();
                    TACGIA ltg = new TACGIA();
                    ltg.MaTacGia = getltg.MaTacGia;
                    ltg.TenTacGia = getltg.TenTacGia;
                    Listltg.Add(ltg);
                }
                return Listltg;
            }
            else
            {
                using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
                {
                    var getltg = (from u in db.TACGIAs  select new { u.MaTacGia, u.TenTacGia });
                    foreach (var item in getltg)
                    {
                        TACGIA ltg = new TACGIA();
                        ltg.MaTacGia = item.MaTacGia;
                        ltg.TenTacGia = item.TenTacGia;
                        Listltg.Add(ltg);
                    }
                }
                return Listltg;
            }
        }

        public void UpdateInfoTacgia(string MaTG, string TenTG)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                TACGIA tg = db.TACGIAs.Find(MaTG);
                tg.MaTacGia = MaTG;
                tg.TenTacGia = TenTG;
                db.SaveChanges();
            }
        }

        public void RemoveInfoTacgia(string MaTG)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                TACGIA tg = db.TACGIAs.Find(MaTG);
                db.TACGIAs.Remove(tg);
                db.SaveChanges();
            }
        }

        public void AddInfoTacgia(string MaTG, string TenTG)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                TACGIA tg = new TACGIA
                {
                    MaTacGia = MaTG,
                    TenTacGia = TenTG

                };
                db.TACGIAs.Add(tg);
                db.SaveChanges();
            }
        }

        public List<TACGIA> GetListTacGia()
        {
            List<TACGIA> listTacgia = new List<TACGIA>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {

                var listtg = db.TACGIAs.Select(p => p).ToList();
                foreach (var item in listtg)
                {
                    TACGIA tg = new TACGIA();
                    tg.MaTacGia = item.MaTacGia;
                    tg.TenTacGia = item.TenTacGia;
                    listTacgia.Add(tg);
                }
            }
            return listTacgia;
        }
    }
}
