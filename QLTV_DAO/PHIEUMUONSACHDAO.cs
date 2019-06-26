using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class PHIEUMUONSACHDAO
    {
        private static PHIEUMUONSACHDAO instance;
        public static PHIEUMUONSACHDAO Instance
        {
            get { if (instance == null) instance = new PHIEUMUONSACHDAO(); return instance; }
            set => instance = value;
        }
        private PHIEUMUONSACHDAO() { }
        public void AddPhieuMuon(string maphieu, string madocgia, DateTime ngaymuon)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                PHIEUMUONSACH pm = new PHIEUMUONSACH();
                pm.MaPhieuMS = maphieu;
                pm.MaDocGia = madocgia;
                pm.NgayMuon = ngaymuon;
                db.PHIEUMUONSACHes.Add(pm);
                db.SaveChanges();
            }
        }
    }
}
