using QLTV_DAO;
using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class THELOAIBUS
    {
        private static THELOAIBUS instance;

        public static THELOAIBUS Instance {
            get { if (instance == null) instance = new THELOAIBUS(); return instance; }
           
            set => instance = value; }
        private THELOAIBUS() :base() { }
        public List<THELOAI> GetTheLoai( string MaTL="")
        {
            return QLTV_DAO.THELOAIDAO.Instance.GetTheLoai(MaTL);
        }

        public List<THELOAI> GetListTheLoai()
        {
            return QLTV_DAO.THELOAIDAO.Instance.GetListTheLoai();
        }

        public void UpdateInfoTheloai(string MaTL, string TenTL)
        {
            QLTV_DAO.THELOAIDAO.Instance.UpdateInfoTheloai(MaTL, TenTL);
        }

        public void RemoveInfoTheloai(string MaTL)
        {
            THELOAIDAO.Instance.RemoveInfoTheloai(MaTL);
        }

        public void AddInfoTheloai(string MaTL, string TenTL)
        {
            THELOAIDAO.Instance.AddInfoTheLoai(MaTL, TenTL);
        }
    }
}
