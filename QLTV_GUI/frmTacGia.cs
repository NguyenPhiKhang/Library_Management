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
using QLTV_DTO;
using QLTV_BUS;
using System.Threading;

namespace QLTV_GUI
{
    public partial class frmTacGia : DevExpress.XtraEditors.XtraForm
    {
        BindingSource listbdTacGia = new BindingSource();
        int index = 0;

        public frmTacGia()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemTacGia addTacGia = new frmThemTacGia();
            addTacGia.ShowDialog();
        }

        void Binding_tacgia()
        {
            txbMaTacGia.DataBindings.Add("Text", listbdTacGia, "MaTacGia");
            txbTenTacGia.DataBindings.Add("Text", listbdTacGia,"TenTacGia")
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = QLTV_BUS.
        }
    }
}