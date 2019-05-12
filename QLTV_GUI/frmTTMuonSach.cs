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
    public partial class frmTTMuonSach : DevExpress.XtraEditors.XtraForm
    {
        public frmTTMuonSach()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemPhieuMuon addPhieuMuon = new frmThemPhieuMuon();
            addPhieuMuon.ShowDialog();
        }
    }
}