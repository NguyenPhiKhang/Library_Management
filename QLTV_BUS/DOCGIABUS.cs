using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAO;

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
        private DOCGIABUS(): base() { }
        public void UpdateInfoDocGia(string MaDG, string TenDG, string DiaChi, DateTime NgaySinh,string email, string MaLDG)
        {
            QLTV_DAO.DOCGIADAO.Instance.UpdateInfoDocGia(MaDG, TenDG, DiaChi, NgaySinh, email, MaLDG);
        }
        public void RemoveInfoDocGia(string MaDG)
        {
            DOCGIADAO.Instance.RemoveInfoDocGia(MaDG);
        }
        public void AddInfoDocGia(string MaDG, string hoten, DateTime ngaysinh, string email, string diachi, string MaLDG, DateTime ngaylapthe, DateTime ngayhethan, string iduser)
        {
            DOCGIADAO.Instance.AddInfoDocGia(MaDG, hoten, ngaysinh, email, diachi, MaLDG, ngaylapthe, ngayhethan, iduser);
        }
    }
}
