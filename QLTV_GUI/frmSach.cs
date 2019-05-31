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
            gridControl1.Focus();
            
            //layoutControlGroup2.Visible = false;
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
        void LoadDataSourceLDG()
        {   
            
            glued_TheLoai.Properties.DataSource = QLTV_BUS.THELOAIBUS.Instance.GetTheLoai(glued_TheLoai.EditValue.ToString());
            
            glued_TheLoai.Properties.ValueMember = "MaTheLoai";
            glued_TheLoai.Properties.DisplayMember = "TenTheLoai";

            glued_TacGia.Properties.DataSource = QLTV_BUS.TACGIABUS.Instance.GetTacGia(glued_TacGia.EditValue.ToString());
            
            glued_TacGia.Properties.ValueMember = "MaTacGia";
            glued_TacGia.Properties.DisplayMember = "TenTacGia";

            glued_TinhTrang.Properties.DataSource = QLTV_BUS.TINHTRANGBUS.Instance.GetTinhTrang(glued_TinhTrang.EditValue.ToString());
            
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

        private void frmSach_Load(object sender, EventArgs e)
        {
            LoadSachInfo();
            Binding_Sach();
            LoadDataSourceLDG();
        }

        

        private void bandedGridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int a = bandedGridView1.GetFocusedDataSourceRowIndex();
            if (a != _index)
            {
                LoadDataSourceLDG();
                
                glued_TheLoai.Text = QLTV_BUS.THELOAIBUS.Instance.GetTheLoai(bandedGridView1.GetFocusedRowCellValue(colMatheloai).ToString())[0].TenTheLoai.ToString();
                glued_TinhTrang.Text = QLTV_BUS.TINHTRANGBUS.Instance.GetTinhTrang(bandedGridView1.GetFocusedRowCellValue(colMaTinhTrang).ToString())[0].TenTinhTrang.ToString();
                glued_TacGia.Text = QLTV_BUS.TACGIABUS.Instance.GetTacGia(bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString())[0].TenTacGia.ToString();
                _index = a;
            }
            else
            {

                glued_TheLoai.Text = QLTV_BUS.THELOAIBUS.Instance.GetTheLoai(bandedGridView1.GetFocusedRowCellValue(colMatheloai).ToString())[0].TenTheLoai.ToString();
                glued_TinhTrang.Text =QLTV_BUS.TINHTRANGBUS.Instance.GetTinhTrang(  bandedGridView1.GetFocusedRowCellValue(colMaTinhTrang).ToString())[0].TenTinhTrang.ToString();
                glued_TacGia.Text = QLTV_BUS.TACGIABUS.Instance.GetTacGia( bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString())[0].TenTacGia.ToString();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lo_btnLuuLai.ContentVisible = true;
            lo_btnHuy.ContentVisible = true;
            glued_TacGia.Properties.ReadOnly = false;
            glued_TheLoai.Properties.ReadOnly = false;
            glued_TinhTrang.Properties.ReadOnly = false;
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