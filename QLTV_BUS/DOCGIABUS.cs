using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAO;
using QLTV_DTO;

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
        public List<DOCGIA> GetInfoDocGia(string idaccount = "")
        {
            return DOCGIADAO.Instance.GetInforDocGia(idaccount);
        }
        public void UpdateInfoDocGia(string MaDG, string TenDG, string DiaChi, DateTime NgaySinh,string email, string MaLDG, DateTime Ngayhethan, string sdt, string gioithieu="")
        {
            QLTV_DAO.DOCGIADAO.Instance.UpdateInfoDocGia(MaDG, TenDG, DiaChi, NgaySinh, email, MaLDG, Ngayhethan, sdt, gioithieu);
        }
        public void UpdateTongNoDG(string MaDG, decimal TongNo)
        {
            DOCGIADAO.Instance.UpdateTongNoDG(MaDG, TongNo);
        }
        public void RemoveInfoDocGia(string MaDG)
        {
            DOCGIADAO.Instance.RemoveInfoDocGia(MaDG);
        }
        public void AddInfoDocGia(string MaDG, string hoten, DateTime ngaysinh, string email, string diachi, string MaLDG, DateTime ngaylapthe, DateTime ngayhethan, string iduser, string sdt/*, decimal TongNo=0*/)
        {
            DOCGIADAO.Instance.AddInfoDocGia(MaDG, hoten, ngaysinh, email, diachi, MaLDG, ngaylapthe, ngayhethan, iduser, sdt/*, TongNo*/);
        }
    }
}
