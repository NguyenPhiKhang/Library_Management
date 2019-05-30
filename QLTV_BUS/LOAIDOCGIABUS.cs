using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DTO;
using QLTV_DAO;
using System.Data;

namespace QLTV_BUS
{
    public class LOAIDOCGIABUS
    {
        private static LOAIDOCGIABUS instance;
        public static LOAIDOCGIABUS Instance
        {
            get { if (instance == null) instance = new LOAIDOCGIABUS(); return instance; }
            set => instance = value;
        }
        private LOAIDOCGIABUS() { }
        public List<LOAIDOCGIA> GetLoaiDocGia(string MaLDG = "")
        {
            return QLTV_DAO.LOAIDOCGIADAO.Instance.GetLoaiDocGia(MaLDG);
        }

    }
}
