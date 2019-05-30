using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    class TACGIABUS
    {
        private static TACGIABUS instance;

        private static TACGIABUS instance1;

        internal static TACGIABUS Instance {
            get => instance1;
            set => instance1 = value; }
    }
}
