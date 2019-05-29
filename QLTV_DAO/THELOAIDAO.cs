using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAO
{
   public class THELOAIDAO
    {
        private static THELOAIDAO instance;

        public static THELOAIDAO Instance
        {
            get { if (instance == null) instance = new THELOAIDAO(); return instance; }
            set => instance = value;
        }
        private THELOAIDAO() { }
        public List<THELOAI> GetListTheLoai()
        {
            List<THELOAI> listTheloai = new List<THELOAI>();
            using (QuanLyThuVienEntities db = new QuanLyThuVienEntities())
            {
                
                var listtl = db.THELOAIs.Select(p=>p).ToList();
                foreach (var item in listtl)
                {
                    THELOAI tl = new THELOAI();
                    tl.MaTheLoai = item.MaTheLoai;
                    tl.TenTheLoai = item.TenTheLoai;
                    listTheloai.Add(tl);
                }
            }
            return listTheloai;
        }
    }
}
