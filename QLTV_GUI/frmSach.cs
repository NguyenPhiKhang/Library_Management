using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLTV_GUI
{
    public partial class frmSach : DevExpress.XtraEditors.XtraForm
    {
        public frmSach()
        {
            InitializeComponent();
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemSach themsach = new frmThemSach();
            themsach.ShowDialog();
        }
    }
}