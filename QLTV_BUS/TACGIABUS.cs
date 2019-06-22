using QLTV_DAO;
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
        private TACGIABUS() : base() { }
        public List<TACGIA> GetTacGia(string MaTacGia="")
        {
            return QLTV_DAO.TACGIADAO.Instance.GetTacGia(MaTacGia);
        }

        public List<TACGIA> GetListTacGia()
        {
            return QLTV_DAO.TACGIADAO.Instance.GetListTacGia();
        }

        public void UpdateInfoTacgia(string MaTG, string TenTG)
        {
            QLTV_DAO.TACGIADAO.Instance.UpdateInfoTacgia(MaTG, TenTG);
        }

        public void RemoveInfoTacgia(string MaTG)
        {
            TACGIADAO.Instance.RemoveInfoTacgia(MaTG);
        }

        public void AddInfoTacgia(string MaTG, string TenTG)
        {
            TACGIADAO.Instance.AddInfoTacgia(MaTG, TenTG);
        }
    }
}
