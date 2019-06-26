using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class SACHDAO
    {

        private static SACHDAO instance;

        public static SACHDAO Instance
        {
            get { if (instance == null) instance = new SACHDAO(); return instance; }
            set => instance = value;
        }
        private SACHDAO() { }

        public List<SACH> GetListSachInfo()
        {
            List<SACH> listSachInfo = new List<SACH>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                var data = ((from u in db.SACHes

                             select new { u.MaSach, u.MaTacGia, u.MaTheLoai, u.MaTinhTrang, u.NamXuatBan, u.NgayNhap, u.NhaXuatBan, u.TenSach, u.TriGia })).ToList();
                foreach (var item in data)
                {
                    SACH tts = new SACH();
                    tts.MaSach = item.MaSach;
                    tts.MaTacGia = item.MaTacGia;
                    tts.MaTheLoai = item.MaTheLoai;
                    tts.MaTinhTrang = item.MaTinhTrang;
                    tts.NamXuatBan = item.NamXuatBan;
                    tts.NgayNhap = item.NgayNhap;
                    tts.NhaXuatBan = item.NhaXuatBan;
                    tts.TriGia = item.TriGia;
                    tts.TenSach = item.TenSach;

                    listSachInfo.Add(tts);
                }
            }
            return listSachInfo;
        }
        public void UpdateInfoSach(string MaS, string TenS, string MaTL, int NamXB, string NhaXB, string MaTG, int TriGia, string MaTT)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                SACH s = db.SACHes.Find(MaS);
                s.TenSach = TenS;
                s.MaTheLoai = MaTL;
                s.NamXuatBan = NamXB;
                s.NhaXuatBan = NhaXB;
                s.MaTacGia = MaTG;

                s.TriGia = TriGia;
                s.MaTinhTrang = MaTT;
                db.SaveChanges();
            }
        }
        public void UpdateTinhtrangSach(string masach, string matinhtrang)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                var sach = db.SACHes.Find(masach);
                sach.MaTinhTrang = matinhtrang;
                db.SaveChanges();
            }
        }
        public void AddInfoSach(string MaS, string TenS, string MaTL, int NamXB, string NhaXB, string MaTG, int TriGia, string MaTT)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                SACH s = new SACH
                {
                    MaSach = MaS,
                    TenSach = TenS,
                    MaTheLoai = MaTL,
                    NamXuatBan = NamXB,
                    NhaXuatBan = NhaXB,
                    MaTacGia = MaTG,
                    
                    TriGia = TriGia,
                    MaTinhTrang = MaTT
                };
                db.SACHes.Add(s);
                db.SaveChanges();
            }
        }
        public void RemoveInfoSach(string MaS)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                SACH s = db.SACHes.Find(MaS);
                db.SACHes.Remove(s);
                db.SaveChanges();
            }
        }







    }
}
