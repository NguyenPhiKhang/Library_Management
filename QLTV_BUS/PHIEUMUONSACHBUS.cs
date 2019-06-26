using QLTV_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class PHIEUMUONSACHBUS
    {
        private static PHIEUMUONSACHBUS instance;
        public static PHIEUMUONSACHBUS Instance
        {
            get { if (instance == null) instance = new PHIEUMUONSACHBUS(); return instance; }
            set => instance = value;
        }
        private PHIEUMUONSACHBUS() { }
        public void AddPhieuMuon(string maphieu, string madocgia, DateTime ngaymuon)
        {
            PHIEUMUONSACHDAO.Instance.AddPhieuMuon(maphieu, madocgia, ngaymuon);
        }
    }
}
