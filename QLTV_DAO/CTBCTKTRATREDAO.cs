using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DTO;

namespace QLTV_DAO
{
    public class CTBCTKTRATREDAO
    {
        private static CTBCTKTRATREDAO instance;

        public static CTBCTKTRATREDAO Instance
        {
            get { if (instance == null) instance = new CTBCTKTRATREDAO(); return instance; }
            set => instance = value;
        }
        private CTBCTKTRATREDAO() { }
        public void AddCTBCTKTraTre(string mabc, string maphieu, string masach, int songaytt)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                CTBCTKTRATRE ct = new CTBCTKTRATRE()
                {
                    MaBCTKTraTre = mabc,
                    MaPhieuMS = maphieu,
                    MaSach = masach,
                    SoNgayTraTre = songaytt
                };
                db.CTBCTKTRATREs.Add(ct);
                db.SaveChanges();
            }
        }
    }
}
