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
    public partial class frmDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmDocGia()
        {
            InitializeComponent();
        }

        //Hiện thanh tìm kiếm trên grid
        private void VisibleFindGrid()
        {
            if (!gridView1.IsFindPanelVisible)
                gridView1.ShowFindPanel();
        }
        
        private void ck_TatCa_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ck_TatCa.Checked==true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                VisibleFindGrid();
            }
        }

        private void ck_MaDocGia_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_MaDocGia.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                VisibleFindGrid();
            }
        }

        private void ck_HoTen_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_HoTen.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                VisibleFindGrid();
            }
        }

        private void ck_NgaySinh_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_NgaySinh.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                VisibleFindGrid();
            }
        }

        private void ck_DiaChi_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_DiaChi.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                VisibleFindGrid();
            }
        }

        private void ck_Email_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_Email.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                VisibleFindGrid();
            }
        }

        private void ck_Username_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_Username.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                VisibleFindGrid();
            }
        }

        private void ck_LoaiDocGia_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_LoaiDocGia.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                VisibleFindGrid();
            }
        }

        private void ck_NgayLapThe_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_NgayLapThe.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                VisibleFindGrid();
            }
        }

        private void ck_NgayHetHan_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_NgayHetHan.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                VisibleFindGrid();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemDocGia themdocgia = new frmThemDocGia();
            themdocgia.ShowDialog();
        }
        
    }
}