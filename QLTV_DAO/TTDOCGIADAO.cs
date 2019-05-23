using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class TTDOCGIADAO
    {
        private static TTDOCGIADAO instance;

        public static TTDOCGIADAO Instance
        {
            get { if (instance == null) instance = new TTDOCGIADAO(); return instance; }
            set => instance = value;
        }
        private TTDOCGIADAO() { }
        QuanLyThuVienEntities db = new QuanLyThuVienEntities();
        public List<TTDOCGIADTO> GetListDocGiaInfo()
        {
            List<TTDOCGIADTO> listDocGiaInfo = new List<TTDOCGIADTO>();
            //using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                var data = ((from u in db.DOCGIAs
                           join n in db.USERs on u.IDUser equals n.IDUser
                           select new {MaDocGia = u.MaDocGia, HoTen=u.HoTen, NgaySinh=u.NgaySinh, DiaChi=u.DiaChi, Email=u.Email, NgayLapThe=u.NgayLapThe, NgayHetHan=u.NgayHetHan, MaLoaiDocGia=u.MaLoaiDocGia, IDUser=u.IDUser, PasswordUser=n.PasswordUser})).ToList();
                foreach (var item in data)
                {
                    TTDOCGIADTO ttdg = new TTDOCGIADTO();
                    ttdg.MaDocGia = item.MaDocGia;
                    ttdg.HoTen = item.HoTen;
                    ttdg.NgaySinh = item.NgaySinh;
                    ttdg.DiaChi = item.DiaChi;
                    ttdg.Email = item.Email;
                    ttdg.NgayLapThe = item.NgayLapThe;
                    ttdg.NgayHetHan = item.NgayHetHan;
                    ttdg.MaLoaiDocGia = item.MaLoaiDocGia;
                    ttdg.IDUser = item.IDUser;
                    ttdg.PasswordUser = item.PasswordUser;
                    listDocGiaInfo.Add(ttdg);
                }
            }
            return listDocGiaInfo;
        }
    }
}
