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
using QLTV_BUS;

namespace QLTV_GUI
{
    public partial class frmThemLoaiDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmThemLoaiDocGia()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            LOAIDOCGIABUS.Instance.AddLoaiDocGia(txbMaLoaiDocGia.Text.ToString(), txbTenLoaiDocGia.Text.ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}