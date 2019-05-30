using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class DOCGIABUS
    {
        private static DOCGIABUS instance;

        public static DOCGIABUS Instance
        {
            get { if (instance == null) instance = new DOCGIABUS(); return instance; }
            set => instance = value;
        }
        private DOCGIABUS() { }
        public void UpdateInfoDocGia(string MaDG, string TenDG, string DiaChi, DateTime NgaySinh, string MaLDG)
        {
            QLTV_DAO.DOCGIADAO.Instance.UpdateInfoDocGia(MaDG, TenDG, DiaChi, NgaySinh, MaLDG);
        }
    }
}
