using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class DSPHIEUPHATDAO
    {
        private static DSPHIEUPHATDAO instance;
        

        public static DSPHIEUPHATDAO Instance
        {
            get { if (instance == null) instance = new DSPHIEUPHATDAO(); return instance; }
            set => instance = value;
        }

        private DSPHIEUPHATDAO() { }

        public List<PHIEUTHUTIENPHAT> GetDSPhieuPhat()
        {
            List<PHIEUTHUTIENPHAT> listPhieuInfo = new List<PHIEUTHUTIENPHAT>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                //var data = ((from u in db.PHIEUTHUTIENPHATs
                //             select new { u.MaPhieuThuTP, u.MaDocGia, u.TongNo, u.SoTienThu, u.NgayThu, u.ConLai })).ToList();
                var data = db.PHIEUTHUTIENPHATs.Select(p => p).ToList();
                foreach (var item in data)
                {
                    PHIEUTHUTIENPHAT dspp = new PHIEUTHUTIENPHAT();
                    dspp.MaPhieuThuTP = item.MaPhieuThuTP;
                    dspp.MaDocGia = item.MaDocGia;
                    dspp.TongNo = item.TongNo;
                    dspp.SoTienThu = item.SoTienThu;
                    dspp.NgayThu = item.NgayThu;
                    dspp.ConLai = item.ConLai;

                   listPhieuInfo.Add(dspp);
                }
            }
            return listPhieuInfo;

        }

        public void AddPhieuPhat(string MaPP, string MaDG, decimal TNo, decimal TienThu, DateTime NgayT, decimal ConL)
        {
            ConL = TNo - TienThu;
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                PHIEUTHUTIENPHAT PP = new PHIEUTHUTIENPHAT
                {
                    MaPhieuThuTP = MaPP,
                    MaDocGia = MaDG,
                    TongNo = TNo,
                    SoTienThu = TienThu,
                    NgayThu = NgayT,
                    ConLai = ConL
                };
                db.PHIEUTHUTIENPHATs.Add(PP);
                db.SaveChanges();
            }
        }
    }
}
