using QLTV_DAO;
using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class THAMSOBUS
    {
        private static THAMSOBUS instance;
        public static THAMSOBUS Instance
        {
            get { if (instance == null) instance = new THAMSOBUS(); return instance; }
            set => instance = value;
        }
        private THAMSOBUS() { }
        public List<THAMSO> GetDSQuiDinh()
        {
            return THAMSODAO.Instance.GetDSQuiDinh();
        }
        public void UpdateQuiDinh(int TuoiMin, int TuoiMax, int HanThe, int KhoangCachXB, int SLTheLoai, int SoNgayMuon, int SoSachMuon, int TienPhat, int SLtacgia)
        {
            THAMSODAO.Instance.UpdateQuiDinh(TuoiMin, TuoiMax, HanThe, KhoangCachXB, SLTheLoai, SoNgayMuon, SoSachMuon, TienPhat, SLtacgia);
        }
    }
}
