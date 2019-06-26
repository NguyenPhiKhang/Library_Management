using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class BCTKMUONSACHDAO
    {
        private static BCTKMUONSACHDAO instance;

        public static BCTKMUONSACHDAO Instance
        {
            get { if (instance == null) instance = new BCTKMUONSACHDAO(); return instance; }
            set => instance = value;
        }
        private BCTKMUONSACHDAO() { }
        public List<BCTKMUONSACH> GetListBCTKmuon()
        {
            List<BCTKMUONSACH> listbc = new List<BCTKMUONSACH>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                var list = db.BCTKMUONSACHes.Select(x => x).ToList();
                foreach (var item in list)
                {
                    BCTKMUONSACH bc = new BCTKMUONSACH
                    {
                        MaBCTKMuonSach = item.MaBCTKMuonSach,
                        Thang = item.Thang,
                        TongSoLuotMuon = item.TongSoLuotMuon
                    };
                    listbc.Add(bc);
                }
            }
            return listbc;
        }
        public void AddBaoCaoTKMuonSach(string MaBC, DateTime Thang, int total)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                BCTKMUONSACH bc = new BCTKMUONSACH();
                bc.MaBCTKMuonSach = MaBC;
                bc.Thang = Thang;
                bc.TongSoLuotMuon = total;
                db.BCTKMUONSACHes.Add(bc);
                db.SaveChanges();
            }
        }
    }
}
