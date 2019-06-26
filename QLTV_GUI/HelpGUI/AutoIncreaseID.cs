using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_GUI.HelpGUI
{
    public static class AutoIncreaseID
    {
        //Tự động tăng mã độc giả
        public static string Load_AutoIncreaseID(string maten, string IdLast, int TotalnumberOfId)
        {
            int flag = 0;
            string Id_New = maten;
            if (TotalnumberOfId <= 0) TotalnumberOfId = 1;
            if (IdLast != "")
            {
                string IdDocGia_Last = IdLast;
                int maso = Convert.ToInt32(IdDocGia_Last.Replace(maten, ""));
                string MaxId="";
                for(int i = 0; i < TotalnumberOfId; i++) { MaxId += "9"; }
                if (maso < Convert.ToInt32(MaxId))
                {
                    for (int n = 10; maso >= n-1; flag++, n *= 10) { }
                    for (int i = 0; i < TotalnumberOfId - flag - 1; i++) { Id_New += "0"; }
                }
                Id_New += maso + 1;
                return Id_New;
            }
            else
            {
                for (int i = 0; i < TotalnumberOfId - 1; i++)
                    Id_New += "0";
                return Id_New + "1";
            }
        }
    }
}
