using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DTO;

namespace QLTV_DAO
{
    public class THAMSODAO
    {
        private static THAMSODAO instance;
        public static THAMSODAO Instance
        {
            get { if (instance == null) instance = new THAMSODAO(); return instance; }
            set => instance = value;
        }
        private THAMSODAO() { }
        public List<THAMSO> GetDSQuiDinh()
        {
            List<THAMSO> listqd = new List<THAMSO>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                var list = db.THAMSOes.ToList();
                foreach (var item in list)
                {
                    THAMSO ts = new THAMSO()
                    {
                        TuoiToiThieu = item.TuoiToiThieu,
                        TuoiToiDa = item.TuoiToiDa,
                        ThoiHanThe = item.ThoiHanThe,
                        KhoangCachXB = item.KhoangCachXB,
                        SoLuongTheLoaiMax = item.SoLuongTheLoaiMax,
                        SoNgayMuonMax = item.SoNgayMuonMax,
                        SoSachMuonMax= item.SoSachMuonMax,
                        TPTraTreMotNgay = item.TPTraTreMotNgay,
                        SoLuongTacGia = item.SoLuongTacGia
                    };
                    listqd.Add(ts);
                }
            }
            return listqd;
        }
        public void UpdateQuiDinh(int TuoiMin, int TuoiMax, int HanThe, int KhoangCachXB, int SLTheLoai, int SoNgayMuon, int SoSachMuon, int TienPhat, int SLtacgia)
        {
            using(QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                THAMSO tsqd = db.THAMSOes.Find(1);
                tsqd.TuoiToiDa = TuoiMax;
                tsqd.TuoiToiThieu = TuoiMin;
                tsqd.ThoiHanThe = HanThe;
                tsqd.KhoangCachXB = KhoangCachXB;
                tsqd.SoLuongTheLoaiMax = SLTheLoai;
                tsqd.SoNgayMuonMax = SoNgayMuon;
                tsqd.SoSachMuonMax = SoSachMuon;
                tsqd.TPTraTreMotNgay = TienPhat;
                tsqd.SoLuongTacGia = SLtacgia;
                db.SaveChanges();
            }
        }

    }
}
