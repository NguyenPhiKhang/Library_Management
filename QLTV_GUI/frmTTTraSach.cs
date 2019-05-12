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
    public partial class frmTTTraSach : DevExpress.XtraEditors.XtraForm
    {
        public frmTTTraSach()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemTraSach addTraSach = new frmThemTraSach();
            addTraSach.ShowDialog();
        }
    }
}