using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLTV_DAO;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class SACHBUS
    {
        private static SACHBUS instance;

        public static SACHBUS Instance
        {
            get { if (instance == null) instance = new SACHBUS(); return instance; }
            set => instance = value;
        }
        private SACHBUS() { }
        public List<SACH> GetListSachInfo()
        {
            return QLTV_DAO.SACHDAO.Instance.GetListSachInfo();
        }
        public void UpdateInfoSach(string MaS, string TenS, string MaTL, int NamXB, string NhaXB, string MaTG, int TriGia, string MaTT)
        {
            QLTV_DAO.SACHDAO.Instance.UpdateInfoSach(MaS, TenS, MaTL, NamXB, NhaXB, MaTG, TriGia, MaTT);
        }
        public void RemoveInfoSach(string MaS)
        {
            SACHDAO.Instance.RemoveInfoSach(MaS);
        }
        public void AddInfoSach(string MaS, string TenS, string MaTL, int NamXB, string NhaXB, string MaTG, DateTime NgayNhap, int TriGia, string MaTT)
        {
            SACHDAO.Instance.AddInfoSach(MaS, TenS, MaTL, NamXB, NhaXB, MaTG, TriGia, MaTT);
        }
        public void UpdateTinhtrangSach(string masach, string matinhtrang)
        {
            SACHDAO.Instance.UpdateTinhtrangSach(masach, matinhtrang);
        }
    }
}
