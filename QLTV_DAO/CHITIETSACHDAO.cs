using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
    public class CHITIETSACHDAO
    {
        private static CHITIETSACHDAO instance;

        public static CHITIETSACHDAO Instance
        {
            get { if (instance == null) instance = new CHITIETSACHDAO(); return instance; }
            set => instance = value;
        }
        private CHITIETSACHDAO() { }
        public List<CHITIETSACHDTO> GetListCTSach(string masach ="")
        {
            List<CHITIETSACHDTO> listctsach = new List<CHITIETSACHDTO>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                if (masach != "")
                {
                    var list = (from u in db.SACHes
                                join n in db.TACGIAs on u.MaTacGia equals n.MaTacGia
                                join m in db.THELOAIs on u.MaTheLoai equals m.MaTheLoai
                                where u.MaSach == masach
                                select new { u.MaSach, u.TenSach, u.MaTheLoai, u.NamXuatBan, u.NhaXuatBan, u.MaTacGia, u.NgayNhap, u.TriGia, u.MaTinhTrang, m.TenTheLoai, n.TenTacGia }).ToList();
                    foreach (var item in list)
                    {
                        CHITIETSACHDTO ct = new CHITIETSACHDTO();
                        ct.MaSach = item.MaSach;
                        ct.TenSach = item.TenSach;
                        ct.MaTheLoai = item.MaTheLoai;
                        ct.NamXuatBan = item.NamXuatBan;
                        ct.NhaXuatBan = item.NhaXuatBan;
                        ct.MaTacGia = item.MaTacGia;
                        ct.NgayNhap = item.NgayNhap;
                        ct.TriGia = item.TriGia;
                        ct.MaTinhTrang = item.MaTinhTrang;
                        ct.TenTheLoai = item.TenTheLoai;
                        ct.TenTacGia = item.TenTacGia;
                        listctsach.Add(ct);
                    }
                }
                else
                {
                    var list = (from u in db.SACHes
                                join n in db.TACGIAs on u.MaTacGia equals n.MaTacGia
                                join m in db.THELOAIs on u.MaTheLoai equals m.MaTheLoai
                                select new { u.MaSach, u.TenSach, u.MaTheLoai, u.NamXuatBan, u.NhaXuatBan, u.MaTacGia, u.NgayNhap, u.TriGia, u.MaTinhTrang, m.TenTheLoai, n.TenTacGia }).ToList();
                    foreach (var item in list)
                    {
                        CHITIETSACHDTO ct = new CHITIETSACHDTO();
                        ct.MaSach = item.MaSach;
                        ct.TenSach = item.TenSach;
                        ct.MaTheLoai = item.MaTheLoai;
                        ct.NamXuatBan = item.NamXuatBan;
                        ct.NhaXuatBan = item.NhaXuatBan;
                        ct.MaTacGia = item.MaTacGia;
                        ct.NgayNhap = item.NgayNhap;
                        ct.TriGia = item.TriGia;
                        ct.MaTinhTrang = item.MaTinhTrang;
                        ct.TenTheLoai = item.TenTheLoai;
                        ct.TenTacGia = item.TenTacGia;
                        listctsach.Add(ct);
                    }
                }
            }
            return listctsach;
        }
    }
}
