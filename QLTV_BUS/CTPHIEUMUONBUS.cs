using QLTV_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class CTPHIEUMUONBUS
    {
        private static CTPHIEUMUONBUS instance;

        public static CTPHIEUMUONBUS Instance
        {
            get { if (instance == null) instance = new CTPHIEUMUONBUS(); return instance; }
            set => instance = value;
        }
        private CTPHIEUMUONBUS() { }
        public void AddCTPhieuMuon(string Mapm, string masach, DateTime hantra, string tinhtrang)
        {
            CTPHIEUMUONDAO.Instance.AddCTPhieuMuon(Mapm, masach, hantra, tinhtrang);
        }
        public void UpdateTinhTrangMuon(string Mapm, string masach, string tinhtrangmuon)
        {
            CTPHIEUMUONDAO.Instance.UpdateTinhTrangMuon(Mapm, masach, tinhtrangmuon);
        }
    }
}
