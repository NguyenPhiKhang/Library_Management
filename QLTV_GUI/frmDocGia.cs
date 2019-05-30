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
    public partial class frmDocGia : DevExpress.XtraEditors.XtraForm
    {
        BindingSource ListBDDocGia = new BindingSource(); //tạo bindingsource để load dữ liệu gridcontrol lên textbox không bị đơ khi thay đổi gridcontrol
        int _index = 0;
        public frmDocGia()
        {
            InitializeComponent();
            gridControl.Focus();
        }
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            LoadDocGiaInfo();
            Binding_DocGia();
            LoadDataSourceLDG(gluedLoaiDocGia.EditValue.ToString());
            lo_btnLuu.ContentVisible = false;
            lo_btnHuy.ContentVisible = false;
        }
        #region Methods
        //Hiện thanh tìm kiếm trên grid
        private void VisibleFindGrid()
        {
            if (!bandedGridView.IsFindPanelVisible)
                bandedGridView.ShowFindPanel();
        }
        void LoadDocGiaInfo()
        {
            List<TTDOCGIADTO> list = QLTV_BUS.TTDOCGIABUS.Instance.GetListDocGiaInfo();
            ListBDDocGia.DataSource = list.ToList();
            gridControl.DataSource = ListBDDocGia;
        }
        void Binding_DocGia()
        {
            try
            {
                txbMaDocGia.DataBindings.Add("Text", ListBDDocGia, "MaDocGia");
                txbHoTen.DataBindings.Add("Text", ListBDDocGia, "HoTen");
                dateNgaySinh.DataBindings.Add("EditValue", ListBDDocGia, "NgaySinh", true, DataSourceUpdateMode.OnPropertyChanged);
                txbDiaChi.DataBindings.Add("Text", ListBDDocGia, "DiaChi");
                txbEmail.DataBindings.Add("Text", ListBDDocGia, "Email");
                txbUserName.DataBindings.Add("Text", ListBDDocGia, "IDUser");
                txbPassword.DataBindings.Add("Text", ListBDDocGia, "PasswordUser");
                gluedLoaiDocGia.DataBindings.Add("Text", ListBDDocGia, "MaLoaiDocGia", true, DataSourceUpdateMode.Never);
                dateNgayLapThe.DataBindings.Add("EditValue", ListBDDocGia, "NgayLapThe", true, DataSourceUpdateMode.OnValidation);
                dateNgayHetHan.DataBindings.Add("EditValue", ListBDDocGia, "NgayHetHan", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            catch
            {

            }
        }
        void LoadDataSourceLDG(string IdMaLDG = "")
        {
            gluedLoaiDocGia.Properties.DataSource = QLTV_BUS.LOAIDOCGIABUS.Instance.GetLoaiDocGia(IdMaLDG);
            gluedLoaiDocGia.Properties.DisplayMember = "MaLoaiDocGia";
            gluedLoaiDocGia.Properties.ValueMember = "MaLoaiDocGia";
        }
        void ReadOnly_SuaThongTin()
        {
            lo_btnLuu.ContentVisible = false;
            lo_btnHuy.ContentVisible = false;
            txbHoTen.ReadOnly = true;
            dateNgaySinh.ReadOnly = true;
            txbDiaChi.ReadOnly = true;
            gluedLoaiDocGia.Properties.AllowFocused = false;
            btnSua.ItemAppearance.Normal.Reset();
        }
        void UnReadOnly_SuaThongTin()
        {
            lo_btnLuu.ContentVisible = true;
            lo_btnHuy.ContentVisible = true;
            txbHoTen.ReadOnly = false;
            dateNgaySinh.ReadOnly = false;
            txbDiaChi.ReadOnly = false;
            gluedLoaiDocGia.Properties.AllowFocused = true;
            btnSua.ItemAppearance.Normal.BackColor = Color.Silver;
        }
        #endregion
        #region Event_CheckFind
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
        #endregion
        #region Event_Click
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemDocGia themdocgia = new frmThemDocGia();
            themdocgia.ShowDialog();
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnReadOnly_SuaThongTin();
            gluedLoaiDocGia.Properties.DataSource = null;
            LoadDataSourceLDG();
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDocGiaInfo();
            LoadDataSourceLDG();
            _index = 0;
        }
        
        private void bandGridview_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int a = bandedGridView.GetFocusedDataSourceRowIndex();
            if (a != _index)
            {
                //if (lo_btnHuy.ContentVisible == true)
                //{
                LoadDataSourceLDG();
                //}
                //else
                //{

                //}
                _index = a;
            }
            else
            {
                gluedLoaiDocGia.Text = bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString();
            }
        }
        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn lưu lại dữ liệu đã sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string IdDG = bandedGridView.GetFocusedRowCellValue(colMaDocGia).ToString();
                QLTV_BUS.DOCGIABUS.Instance.UpdateInfoDocGia(IdDG, txbHoTen.Text, txbDiaChi.Text, (DateTime)dateNgaySinh.EditValue, gluedLoaiDocGia.Text);
                ReadOnly_SuaThongTin();
                gridControl.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ReadOnly_SuaThongTin();
            gridControl.Focus();
        }
        #endregion
    }
}