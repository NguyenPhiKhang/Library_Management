using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DTO;

namespace QLTV_DAO
{
  public  class CHITIETPHIEUTRADAO
    {
        private static CHITIETPHIEUTRADAO instance;

        public static CHITIETPHIEUTRADAO Instance
        {
            get { if (instance == null) instance = new CHITIETPHIEUTRADAO(); return instance; }
            set => instance = value;
        }
        private CHITIETPHIEUTRADAO() { }
        public List<CHITIETPHIEUTRADTO> GetListPhieuTra()
        {
            List<CHITIETPHIEUTRADTO> listpt = new List<CHITIETPHIEUTRADTO>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                var list = (from t in db.PHIEUTRASACHes
                            join n in db.CTPHIEUMUONs on new { t.MaPhieuMS,t.MaSach } equals new { n.MaPhieuMS,n.MaSach }
                            join u in db.PHIEUMUONSACHes on n.MaPhieuMS equals u.MaPhieuMS
                            join m in db.DOCGIAs on u.MaDocGia equals m.MaDocGia
                            join h in db.SACHes on n.MaSach equals h.MaSach
                            select new { t.MaPhieuMS, t.NgayTra, t.SoNgayMuon, t.TienPhat,t.TinhTrangTraSach, u.MaDocGia, m.HoTen, n.MaSach, h.TenSach, h.MaTinhTrang, n.HanTra, n.TinhTrangMuon, u.NgayMuon, t.GhiChu}).ToList();
                foreach (var item in list)
                {
                    CHITIETPHIEUTRADTO ct = new CHITIETPHIEUTRADTO
                    {
                        MaPhieuMS = item.MaPhieuMS,
                        NgayTra = item.NgayTra,
                        SoNgayMuon = item.SoNgayMuon,
                        TienPhat = item.TienPhat,
                        TinhTrangTraSach =item.TinhTrangTraSach,
                        MaDocGia = item.MaDocGia,
                        HoTen = item.HoTen,
                        MaSach = item.MaSach,
                        TenSach = item.TenSach, 
                        MaTinhTrang = item.MaTinhTrang,
                        HanTra = item.HanTra,
                        TinhTrangMuon = item.TinhTrangMuon,
                        NgayMuon = item.NgayMuon,
                        GhiChu = item.GhiChu
                    };
                    listpt.Add(ct);
                }
            }
            return listpt;


        }
        public void AddPhieuTra(string MaPm,string Masach,DateTime Ngaytra,int SoNgayMuon,decimal TienPhat,string TinhTrangTraSach)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                PHIEUTRASACH ct = new PHIEUTRASACH
                {
                    MaPhieuMS = MaPm,
                    NgayTra = Ngaytra,
                    MaSach = Masach,
                    SoNgayMuon = SoNgayMuon,
                    TienPhat = TienPhat,
                    TinhTrangTraSach = TinhTrangTraSach
                };
                db.PHIEUTRASACHes.Add(ct);
                db.SaveChanges();
            }


        }
    }
}
