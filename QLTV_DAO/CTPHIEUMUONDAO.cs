using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class CTPHIEUMUONDAO
    {
        private static CTPHIEUMUONDAO instance;

        public static CTPHIEUMUONDAO Instance
        {
            get { if (instance == null) instance = new CTPHIEUMUONDAO(); return instance; }
            set => instance = value;
        }
        private CTPHIEUMUONDAO() { }
        public void AddCTPhieuMuon(string Mapm, string masach, DateTime hantra, string tinhtrang)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                CTPHIEUMUON ct = new CTPHIEUMUON();
                ct.MaPhieuMS = Mapm;
                ct.MaSach = masach;
                ct.HanTra = hantra;
                ct.TinhTrangMuon = tinhtrang;
                db.CTPHIEUMUONs.Add(ct);
                db.SaveChanges();
            }
        }
        public void UpdateTinhTrangMuon(string Mapm, string masach, string tinhtrangmuon)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                CTPHIEUMUON ct = db.CTPHIEUMUONs.Find(Mapm, masach);
                ct.TinhTrangMuon = tinhtrangmuon;
                db.SaveChanges();
            }
        }
    }
}
