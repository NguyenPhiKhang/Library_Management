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
        public List<DOCGIA> GetInforDocGia(string idaccount = "" )
        {
            List<DOCGIA> listDocGia = new List<DOCGIA>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                List<DOCGIA> list = new List<DOCGIA>();
                if (idaccount == "")
                    list = db.DOCGIAs.ToList();
                else list = db.DOCGIAs.Where(p => p.IDAccount == idaccount).Select(p => p).ToList();
                listDocGia = list;
            }
            return listDocGia;
        }
        public void UpdateInfoDocGia(string MaDG, string TenDG, string DiaChi, DateTime NgaySinh,string email, string MaLDG, DateTime Ngayhethan, string sdt, string gioithieu="")
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                DOCGIA dg = db.DOCGIAs.Find(MaDG);
                dg.HoTen = TenDG;
                dg.DiaChi = DiaChi;
                dg.NgaySinh = NgaySinh;
                dg.Email = email;
                dg.MaLoaiDocGia = MaLDG;
                dg.NgayHetHan = Ngayhethan;
                dg.SDT = sdt;
                if (!string.IsNullOrEmpty(gioithieu))
                    dg.GioiThieu = gioithieu;
                db.SaveChanges();
            }
        }
        public void UpdateTongNoDG(string MaDG, decimal TongNo)
        {
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                DOCGIA dg = db.DOCGIAs.Find(MaDG);
                dg.TongNo += TongNo;
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
        public void AddInfoDocGia(string MaDG, string hoten, DateTime ngaysinh, string email, string diachi, string MaLDG, DateTime ngaylapthe, DateTime ngayhethan, string idaccount, string sdt/*, decimal TongNo=0*/)
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
                    IDAccount = idaccount,
                    SDT = sdt,
                    //TongNo = TongNo
                };
                db.DOCGIAs.Add(dg);
                db.SaveChanges();
            }
        }
    }
}
