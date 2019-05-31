using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class TACGIABUS
    {
        private static TACGIABUS instance;

        public static TACGIABUS Instance { get { if (instance == null) instance = new TACGIABUS(); return instance; } 
            set => instance = value; }
        private TACGIABUS()  { }
        public List<TACGIA> GetTacGia(string MaTacGia)
        {
            return QLTV_DAO.TACGIADAO.Instance.GetTacGia(MaTacGia);
        }
    }
}
