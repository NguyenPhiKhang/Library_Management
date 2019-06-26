using QLTV_DAO;
using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class CHITIETPHIEUMUONBUS
    {
        private static CHITIETPHIEUMUONBUS instance;
        public static CHITIETPHIEUMUONBUS Instance
        {
            get { if (instance == null) instance = new CHITIETPHIEUMUONBUS(); return instance; }
            set => instance = value;
        }
        private CHITIETPHIEUMUONBUS() { }
        public List<CHITIETPHIEUMUONDTO> GetListPhieuMuon()
        {
            return CHITIETPHIEUMUONDAO.Instance.GetListPhieuMuon();
        }
        public void AddCTPhieuMuon(string Maphieu, string madg, DateTime ngaymuon, string masach, DateTime hantra, string tinhtrang)
        {
            CHITIETPHIEUMUONDAO.Instance.AddCTPhieuMuon(Maphieu, madg, ngaymuon, masach, hantra, tinhtrang);
        }
    }
}
