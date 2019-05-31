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
        public DOCGIADAO() { }
        public void UpdateInfoDocGia(string MaDG, string TenDG, string DiaChi, DateTime NgaySinh,string email, string MaLDG)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                DOCGIA dg = db.DOCGIAs.Find(MaDG);
                dg.HoTen = TenDG;
                dg.DiaChi = DiaChi;
                dg.NgaySinh = NgaySinh;
                dg.Email = email;
                dg.MaLoaiDocGia = MaLDG;
                db.SaveChanges();
            }
        }
        public void RemoveInfoDocGia(string MaDG)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                DOCGIA dg = db.DOCGIAs.Find(MaDG);
                db.DOCGIAs.Remove(dg);
                db.SaveChanges();
            }
        }
        public void AddInfoDocGia(string MaDG, string hoten, DateTime ngaysinh, string email, string diachi, string MaLDG, DateTime ngaylapthe, DateTime ngayhethan, string iduser)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                DOCGIA dg = new DOCGIA
                {
                    MaDocGia = MaDG,
                    HoTen = hoten,
                    NgaySinh = ngaysinh,
                    Email = email,
                    DiaChi = diachi,
                    MaLoaiDocGia = MaLDG,
                    NgayLapThe = ngaylapthe,
                    NgayHetHan = ngayhethan,
                    IDUser = iduser
                };
                db.DOCGIAs.Add(dg);
                db.SaveChanges();
            }
        }
    }
}
