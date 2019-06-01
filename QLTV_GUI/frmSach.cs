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
using QLTV_DAO;
using QLTV_BUS;
using QLTV_DTO;

namespace QLTV_GUI
{
    public partial class frmSach : DevExpress.XtraEditors.XtraForm
    {
        int _index = 0;
        BindingSource ListBDSach = new BindingSource();
        public frmSach()
        {
            InitializeComponent();
        
            
            //layoutControlGroup2.Visible = false;
        }
        private void frmSach_Load(object sender, EventArgs e)
        {
            LoadSachInfo();
            Binding_Sach();
            LoadDataSourceLDG(bandedGridView1.GetFocusedRowCellValue(colMatheloai).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTinhTrang).ToString());
            lo_btnLuuLai.ContentVisible = false;
            lo_btnHuy.ContentVisible = false;
            gridControl1.Focus();
        }
        #region Methods

        #endregion
        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemSach themsach = new frmThemSach();
            themsach.ShowDialog();
        }

        void LoadSachInfo()
        {
            List<SACH> list = QLTV_BUS.SACHBUS.Instance.GetListSachInfo();
            //gridControl.DataSource = list.ToList();
            //bindingSource1.DataSource = list.ToList();
            ListBDSach.DataSource = list.ToList();
            gridControl1.DataSource = ListBDSach;
        }
        void LoadDataSourceLDG(string theloai="",string tacgia="",string tinhtrang="")
        {
            var list =QLTV_BUS.THELOAIBUS.Instance.GetTheLoai(theloai);

            glued_TheLoai.Properties.DataSource = list;
            
            glued_TheLoai.Properties.ValueMember = "MaTheLoai";
            glued_TheLoai.Properties.DisplayMember = "TenTheLoai";

            var list2= QLTV_BUS.TACGIABUS.Instance.GetTacGia(tacgia);
            glued_TacGia.Properties.DataSource = list2;
            
            glued_TacGia.Properties.ValueMember = "MaTacGia";
            glued_TacGia.Properties.DisplayMember = "TenTacGia";
            var list3 = QLTV_BUS.TINHTRANGBUS.Instance.GetTinhTrang(tinhtrang);
            glued_TinhTrang.Properties.DataSource = list3;
            
            glued_TinhTrang.Properties.ValueMember = "MaTinhTrang";
            glued_TinhTrang.Properties.DisplayMember = "TenTinhTrang";
        }
        void Binding_Sach()
        {
            try
            {
                txbMaSach.DataBindings.Add("Text", ListBDSach, "MaSach");
                txbTenSach.DataBindings.Add("Text", ListBDSach, "TenSach");
                dateNgayNhap.DataBindings.Add("EditValue", ListBDSach, "NgayNhap", true, DataSourceUpdateMode.OnPropertyChanged);
                dateNamSX.DataBindings.Add("EditValue", ListBDSach, "NamXuatBan", true, DataSourceUpdateMode.OnPropertyChanged);
                glued_TheLoai.DataBindings.Add("EditValue", ListBDSach, "MaTheLoai", true,DataSourceUpdateMode.Never);
                txbNhaSX.DataBindings.Add("Text", ListBDSach, "NhaXuatBan");      
                glued_TacGia.DataBindings.Add("EditValue", ListBDSach,"MaTacGia", true, DataSourceUpdateMode.Never);
                txbTriGia.DataBindings.Add("Text", ListBDSach, "TriGia");

                glued_TinhTrang.DataBindings.Add("EditValue", ListBDSach, "MaTinhTrang", true, DataSourceUpdateMode.Never);

        }
            catch
            {

            }
        }

       

        

        private void bandedGridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int a = bandedGridView1.GetFocusedDataSourceRowIndex();
            if (a != _index)
            {
                
                
                
                _index = a;
            }
            else
            {

                
            }
            if(lo_btnLuuLai.ContentVisible==false)
            {
                LoadDataSourceLDG(bandedGridView1.GetFocusedRowCellValue(colMatheloai).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTinhTrang).ToString());
            }
            else
            {
                LoadDataSourceLDG();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lo_btnLuuLai.ContentVisible = true;
            lo_btnHuy.ContentVisible = true;
            glued_TacGia.Properties.ReadOnly = false;
            glued_TheLoai.Properties.ReadOnly = false;
            glued_TinhTrang.Properties.ReadOnly = false;
            LoadDataSourceLDG();
        }

        private void btn_LuuLai_Click(object sender, EventArgs e)
        {
            //xử lí




            lo_btnLuuLai.ContentVisible = false;
            lo_btnHuy.ContentVisible = false;



            gridControl1.Focus();
            LoadSachInfo();
            Binding_Sach();
            LoadDataSourceLDG();
            glued_TacGia.Properties.ReadOnly = true;
            glued_TheLoai.Properties.ReadOnly = true;
            glued_TinhTrang.Properties.ReadOnly = true;

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {


            //Xử lý



            lo_btnLuuLai.ContentVisible = true;
            lo_btnHuy.ContentVisible = true;



            gridControl1.Focus();
            LoadSachInfo();
            Binding_Sach();
            LoadDataSourceLDG();
            glued_TacGia.Properties.ReadOnly = true;
            glued_TheLoai.Properties.ReadOnly = true;
            glued_TinhTrang.Properties.ReadOnly = true;
        }
    }

}