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
    public partial class frmTheLoai : DevExpress.XtraEditors.XtraForm
    {
        BindingSource listbdtheloai = new BindingSource();
        int index = 0;

        public frmTheLoai()
        {
            InitializeComponent();
            gridControl1.Focus();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemTheLoai addTheLoai = new frmThemTheLoai();
            addTheLoai.ShowDialog();
        }
        void Binding_theLoai()
        {
            txbMaTheLoai.DataBindings.Add("Text", listbdtheloai, "MaTheLoai");
            txbTenTheLoai.DataBindings.Add("Text", listbdtheloai, "TenTheLoai");
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = QLTV_BUS.THELOAIBUS.Instance.GetListTheLoai();
        }
    }
}