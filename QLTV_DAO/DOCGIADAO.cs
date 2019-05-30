using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DTO;

namespace QLTV_DAO
{
    public class DOCGIADAO
    {
        private static DOCGIADAO instance;
        public static DOCGIADAO Instance
        {
            get { if (instance == null) instance = new DOCGIADAO(); return instance; }
            set => instance = value;
        }
        private DOCGIADAO() { }
        public void UpdateInfoDocGia(string MaDG, string TenDG, string DiaChi, DateTime NgaySinh, string MaLDG)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                DOCGIA dg = db.DOCGIAs.Find(MaDG);
                dg.HoTen = TenDG;
                dg.DiaChi = DiaChi;
                dg.NgaySinh = NgaySinh;
                dg.MaLoaiDocGia = MaLDG;
                db.SaveChanges();
            }
        }
    }
}
