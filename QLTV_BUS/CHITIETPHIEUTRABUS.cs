using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAO;

namespace QLTV_BUS
{
   public  class CHITIETPHIEUTRABUS
    {
        private static CHITIETPHIEUTRABUS instance;
        public static CHITIETPHIEUTRABUS Instance
        {
            get { if (instance == null) instance = new CHITIETPHIEUTRABUS(); return instance; }
            set => instance = value;
        }
        private CHITIETPHIEUTRABUS() { }
        public List<CHITIETPHIEUTRADTO> GetListPhieuTra()
        {
            return CHITIETPHIEUTRADAO.Instance.GetListPhieuTra();
        }
        public void AddPhieuTra(string MaPm, string Masach, DateTime Ngaytra, int SoNgayMuon, decimal TienPhat, string TinhTrangTraSach)
        {
            CHITIETPHIEUTRADAO.Instance.AddPhieuTra(MaPm, Masach, Ngaytra, SoNgayMuon, TienPhat, TinhTrangTraSach);
        }
    }
}
