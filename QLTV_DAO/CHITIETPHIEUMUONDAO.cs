using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class CHITIETPHIEUMUONDAO
    {
        private static CHITIETPHIEUMUONDAO instance;
        public static CHITIETPHIEUMUONDAO Instance
        {
            get { if (instance == null) instance = new CHITIETPHIEUMUONDAO(); return instance; }
            set => instance = value;
        }
        private CHITIETPHIEUMUONDAO() { }
        public List<CHITIETPHIEUMUONDTO> GetListPhieuMuon()
        {
            List<CHITIETPHIEUMUONDTO> listphieumuon = new List<CHITIETPHIEUMUONDTO>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                var list = (from u in db.PHIEUMUONSACHes
                           join m in db.DOCGIAs on u.MaDocGia equals m.MaDocGia
                           join n in db.CTPHIEUMUONs on u.MaPhieuMS equals n.MaPhieuMS
                           join h in db.SACHes on n.MaSach equals h.MaSach
                           join p in db.THELOAIs on h.MaTheLoai equals p.MaTheLoai
                           join q in db.TACGIAs on h.MaTacGia equals q.MaTacGia
                           select new { u.MaPhieuMS, u.MaDocGia, m.HoTen, n.MaSach, h.TenSach, p.TenTheLoai, q.TenTacGia, h.MaTinhTrang, n.HanTra, n.TinhTrangMuon, m.NgayHetHan, u.NgayMuon }).ToList();
                foreach (var item in list)
                {
                    CHITIETPHIEUMUONDTO ct = new CHITIETPHIEUMUONDTO
                    {
                        MaPhieuMS = item.MaPhieuMS,
                        MaDocGia = item.MaDocGia,
                        HoTen = item.HoTen,
                        MaSach = item.MaSach,
                        TenSach = item.TenSach,
                        TenTheLoai = item.TenTheLoai,
                        TenTacGia = item.TenTacGia,
                        MaTinhTrang = item.MaTinhTrang,
                        HanTra = item.HanTra,
                        TinhTrangMuon = item.TinhTrangMuon,
                        NgayMuon = item.NgayMuon,
                        NgayHetHan = item.NgayHetHan,
                    };
                    listphieumuon.Add(ct);
                }
            }
            return listphieumuon;
        }
        public void AddCTPhieuMuon(string Maphieu, string madg, DateTime ngaymuon, string masach, DateTime hantra, string tinhtrang)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                PHIEUMUONSACH pm = new PHIEUMUONSACH { MaPhieuMS = Maphieu, MaDocGia = madg, NgayMuon = ngaymuon };
                CTPHIEUMUON ct = new CTPHIEUMUON {MaPhieuMS = Maphieu, MaSach = masach, HanTra = hantra, TinhTrangMuon = tinhtrang };
                db.PHIEUMUONSACHes.Add(pm);
                db.CTPHIEUMUONs.Add(ct);
                db.SaveChanges();
            }
        }
    }
}
