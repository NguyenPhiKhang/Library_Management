using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class CTBCTKMUONSACHDAO
    {
        private static CTBCTKMUONSACHDAO instance;

        public static CTBCTKMUONSACHDAO Instance
        {
            get { if (instance == null) instance = new CTBCTKMUONSACHDAO(); return instance; }
            set => instance = value;
        }
        private CTBCTKMUONSACHDAO() { }
        public void AddCTBCMuonSach(string mabc, string matl, int soluotmuon, double tile)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                CTBCTKMUONSACH ct = new CTBCTKMUONSACH();
                ct.MaBCTKMuonSach = mabc;
                ct.MaTheLoai = matl;
                ct.SoLuotMuon = soluotmuon;
                ct.TiLe = tile;
                db.CTBCTKMUONSACHes.Add(ct);
                db.SaveChanges();
            }
        }
    }
}
