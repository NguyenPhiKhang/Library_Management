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
        private THELOAIBUS() { }
        public List<THELOAI> GetTheLoai( string MaTL)
        {
            return QLTV_DAO.THELOAIDAO.Instance.GetTheLoai(MaTL);
        }
    }
}
