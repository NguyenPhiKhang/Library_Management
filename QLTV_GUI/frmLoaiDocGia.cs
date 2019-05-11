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
    public partial class frmLoaiDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiDocGia()
        {
            InitializeComponent();
        }
        //Xuất hiện thanh tìm kiếm trên Grid
        private void VisibleFindGrid()
        {
            if (!gridView1.IsFindPanelVisible)
                gridView1.ShowFindPanel();
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemLoaiDocGia addLDG = new frmThemLoaiDocGia();
            addLDG.ShowDialog();
        }

        private void btnTatCa_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnTatCa.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                VisibleFindGrid();
            }
        }

        private void btnMaLoaiDG_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnMaLoaiDG.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                VisibleFindGrid();
            }
        }

        private void btnTenLoaiDG_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnTenLoaiDG.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                VisibleFindGrid();
            }
        }
    }
}