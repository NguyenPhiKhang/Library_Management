using QLTV_DAO;
using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class DSPHIEUPHATBUS
    {
        private static DSPHIEUPHATBUS instance;

        public static DSPHIEUPHATBUS Instance
        {
            get { if (instance == null) instance = new DSPHIEUPHATBUS(); return instance; }
            set => instance = value;
        }

        private DSPHIEUPHATBUS() { }
        public List<PHIEUTHUTIENPHAT> GetDSPhieuPhat()
        {
            return QLTV_DAO.DSPHIEUPHATDAO.Instance.GetDSPhieuPhat();
        }

        public void AddPhieuPhat(string MaPP, string MaDG, decimal TNo, decimal TienThu, DateTime NgayT,decimal ConL)
        {
            DSPHIEUPHATDAO.Instance.AddPhieuPhat(MaPP, MaDG, TNo, TienThu, NgayT, ConL);
        }
    }
}
