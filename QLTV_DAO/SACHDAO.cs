using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class SACHDAO
    {
        
        private static SACHDAO instance;

        public static SACHDAO Instance
        {
            get { if (instance == null) instance = new SACHDAO(); return instance; }
            set => instance = value;
        }
        private SACHDAO() { }

        public List<SACH> GetListSachInfo()
        {
            List<SACH> listSachInfo = new List<SACH>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                var data = ((from u in db.SACHes
                             
                             select new { u.MaSach, u.MaTacGia, u.MaTheLoai, u.MaTinhTrang, u.NamXuatBan, u.NgayNhap, u.NhaXuatBan, u.TenSach,u.TriGia})).ToList();
                foreach (var item in data)
                {
                    SACH tts = new SACH();
                    tts.MaSach = item.MaSach;
                    tts.MaTacGia = item.MaTacGia;
                    tts.MaTheLoai = item.MaTheLoai;
                    tts.MaTinhTrang = item.MaTinhTrang;
                    tts.NamXuatBan = item.NamXuatBan;
                    tts.NgayNhap = item.NgayNhap;
                    tts.NhaXuatBan = item.NhaXuatBan;
                    tts.TriGia = item.TriGia;
                    tts.TenSach = item.TenSach;
                  
                    listSachInfo.Add(tts);
                }
            }




            return listSachInfo;
        }
    }
}
