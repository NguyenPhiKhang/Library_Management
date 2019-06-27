using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class BCTKTRATREDAO
    {
        private static BCTKTRATREDAO instance;

        public static BCTKTRATREDAO Instance
        {
            get { if (instance == null) instance = new BCTKTRATREDAO(); return instance; }
            set => instance = value;
        }
        private BCTKTRATREDAO() { }
        public List<BCTKTRATRE> GetListBCTKTraTre()
        {
            List<BCTKTRATRE> listbc = new List<BCTKTRATRE>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                var list = db.BCTKTRATREs.Select(x => x).ToList();
                foreach (var item in list)
                {
                    BCTKTRATRE bc = new BCTKTRATRE
                    {
                        MaBCTKTraTre = item.MaBCTKTraTre,
                        Ngay = item.Ngay
                    };
                    listbc.Add(bc);
                }
            }
            return listbc;
        }
        public void AddBCTKTraTre(string mapt, DateTime ngay)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                BCTKTRATRE bc = new BCTKTRATRE();
                bc.MaBCTKTraTre = mapt;
                bc.Ngay = ngay;
                db.BCTKTRATREs.Add(bc);
                db.SaveChanges();
            }
        }
    }
}
