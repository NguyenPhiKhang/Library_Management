using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_GUI.HelpGUI
{
    public static class ErrorProvider
    {
        public static void Event_ErrorProvider(DXErrorProvider dxErrorProvider, Control x, bool isCheck, string errorText, bool CheckTrung = false, string errorTrung = "")
        {
            if (!isCheck || string.IsNullOrEmpty(x.Text) || CheckTrung)
            {
                x.Focus();
                dxErrorProvider.SetIconAlignment(x, ErrorIconAlignment.BottomRight);
                if (CheckTrung)
                {
                    dxErrorProvider.SetError(x, errorTrung);
                }
                else
                {
                    dxErrorProvider.SetError(x, errorText);
                }
            }
            else
            {
                dxErrorProvider.SetError(x, null);
            }
        }
    }
}
