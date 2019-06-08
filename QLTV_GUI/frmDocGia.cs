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
        #region Declare
        BindingSource ListBDDocGia = new BindingSource(); //tạo bindingsource để load dữ liệu gridcontrol lên textbox không bị đơ khi thay đổi gridcontrol
        int _index = 0;
        string keycolumn = "";
        public frmDocGia()
        {
            InitializeComponent();
        }
        #endregion
        #region Event_Load
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            lo_btnLuu.ContentVisible = false;
            lo_btnHuy.ContentVisible = false;
            btnReset.Enabled = false;
            LoadDocGiaInfo();
            Binding_DocGia();
            if (bandedGridView.RowCount > 0)
            {
                LoadDataSourceLDG(bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString());
            }
            //Show_FindGrid();
            gridControl.Focus();
        }
        #endregion
        #region Methods
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
                txbMaDocGia.DataBindings.Add("Text", ListBDDocGia, "MaDocGia", true, DataSourceUpdateMode.Never);
                txbHoTen.DataBindings.Add("Text", ListBDDocGia, "HoTen", true, DataSourceUpdateMode.Never);
                dateNgaySinh.DataBindings.Add("EditValue", ListBDDocGia, "NgaySinh", true, DataSourceUpdateMode.Never);
                txbDiaChi.DataBindings.Add("Text", ListBDDocGia, "DiaChi",true, DataSourceUpdateMode.Never);
                txbEmail.DataBindings.Add("Text", ListBDDocGia, "Email", true, DataSourceUpdateMode.Never);
                txbUserName.DataBindings.Add("Text", ListBDDocGia, "IDUser",true, DataSourceUpdateMode.Never);
                txbPassword.DataBindings.Add("Text", ListBDDocGia, "PasswordUser",true, DataSourceUpdateMode.Never);
                gluedLoaiDocGia.DataBindings.Add("EditValue", ListBDDocGia, "MaLoaiDocGia", true, DataSourceUpdateMode.Never);
                dateNgayLapThe.DataBindings.Add("EditValue", ListBDDocGia, "NgayLapThe", true, DataSourceUpdateMode.Never);
                dateNgayHetHan.DataBindings.Add("EditValue", ListBDDocGia, "NgayHetHan", true, DataSourceUpdateMode.Never);
            }
            catch
            {

            }
        }
        void LoadDataSourceLDG(string IdMaLDG = "")
        {
            var listDG = QLTV_BUS.LOAIDOCGIABUS.Instance.GetLoaiDocGia(IdMaLDG);
            gluedLoaiDocGia.Properties.DataSource = listDG;
            //foreach (var item in listDG)
            //{
            //    if (item.MaLoaiDocGia == bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString())
            //    {
            //        gluedLoaiDocGia.Text = item.TenLoaiDocGia.ToString();
            //        break;
            //    }
            //}
            gluedLoaiDocGia.Properties.ValueMember = "MaLoaiDocGia";
            gluedLoaiDocGia.Properties.DisplayMember = "TenLoaiDocGia";
            //gluedLoaiDocGia.Text = gluedLoaiDocGia.EditValue.ToString();
        }
        void ReadOnly_SuaThongTin()
        {
            lo_btnLuu.ContentVisible = false;
            lo_btnHuy.ContentVisible = false;
            btnReset.Enabled = false;
            txbEmail.ReadOnly = true;
            txbHoTen.ReadOnly = true;
            gluedLoaiDocGia.ReadOnly = true;
            dateNgaySinh.ReadOnly = true;
            txbDiaChi.ReadOnly = true;
            gluedLoaiDocGia.Properties.AllowFocused = false;
            btnSua.ItemAppearance.Normal.Reset();
        }
        void UnReadOnly_SuaThongTin()
        {
            lo_btnLuu.ContentVisible = true;
            lo_btnHuy.ContentVisible = true;
            btnReset.Enabled = true;
            txbEmail.ReadOnly = false;
            txbHoTen.ReadOnly = false;
            gluedLoaiDocGia.ReadOnly = false;
            dateNgaySinh.ReadOnly = false;
            txbDiaChi.ReadOnly = false;
            gluedLoaiDocGia.Properties.AllowFocused = true;
            btnSua.ItemAppearance.Normal.BackColor = Color.Silver;
        }
        void Uncheck_ck_TatCa()
        {
            if (ck_TatCa.Checked == true)
                ck_TatCa.Checked = false;
        }
        void FormatBD_TTDocGia()
        {
            txbHoTen.Text = bandedGridView.GetFocusedRowCellValue(colHoTen).ToString();
            dateNgaySinh.EditValue = bandedGridView.GetFocusedRowCellValue(colNgaySinh);
            txbDiaChi.Text = bandedGridView.GetFocusedRowCellValue(colDiaChi).ToString();
            txbEmail.Text = bandedGridView.GetFocusedRowCellValue(colEmail).ToString();
            txbPassword.Text = bandedGridView.GetFocusedRowCellValue(colPassword).ToString();
            gluedLoaiDocGia.EditValue = bandedGridView.GetFocusedRowCellValue(colLoaiDocGia);
            txbMaDocGia.Text = bandedGridView.GetFocusedRowCellValue(colMaDocGia).ToString();
            dateNgayLapThe.EditValue = bandedGridView.GetFocusedRowCellValue(colNgayLapThe);
            dateNgayHetHan.EditValue = bandedGridView.GetFocusedRowCellValue(colNgayHetHan);
            txbUserName.Text = bandedGridView.GetFocusedRowCellValue(colUsername).ToString();
        }
        //Hiện thanh tìm kiếm trên grid
        //private void Show_FindGrid()
        //{
        //    if (!bandedGridView.IsFindPanelVisible)
        //        bandedGridView.ShowFindPanel();
        //}
        ////Ẩn Thanh tìm kiếm
        //private void Hide_FindGrid()
        //{
        //    if (bandedGridView.IsFindPanelVisible)
        //        bandedGridView.HideFindPanel();
        //}
        #endregion
        #region Event_CheckFind
        private void ck_TatCa_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ck_TatCa.Checked==true)
            {
                ck_DiaChi.Checked = false;
                ck_Email.Checked = false;
                ck_HoTen.Checked = false;
                ck_LoaiDocGia.Checked = false;
                ck_MaDocGia.Checked = false;
                ck_NgayHetHan.Checked = false;
                ck_NgayLapThe.Checked = false;
                ck_NgaySinh.Checked = false;
                ck_Username.Checked = false;
                //Show_FindGrid();
                keycolumn = "*";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
                ck_TatCa.Enabled = false;
            }
            else
            {
                ck_TatCa.Enabled = true;
                keycolumn = "";
            }
        }
        
        private void ck_MaDocGia_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_MaDocGia.Checked == true)
            {
                Uncheck_ck_TatCa();
                //Show_FindGrid();
                keycolumn += "MaDocGia;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked==false&&
                    ck_DiaChi.Checked == false &&
                    ck_Email.Checked == false &&
                    ck_HoTen.Checked == false &&
                    ck_LoaiDocGia.Checked == false &&
                    ck_NgayHetHan.Checked == false &&
                    ck_NgayLapThe.Checked == false &&
                    ck_NgaySinh.Checked == false &&
                    ck_Username.Checked == false
                    )
                {
                    //Hide_FindGrid();
                    //keycolumn = "";
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("MaDocGia;", "");
                    bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_HoTen_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_HoTen.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                Uncheck_ck_TatCa();
                //Show_FindGrid();
                keycolumn += "HoTen;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_DiaChi.Checked == false &&
                    ck_Email.Checked == false &&
                    ck_MaDocGia.Checked == false &&
                    ck_LoaiDocGia.Checked == false &&
                    ck_NgayHetHan.Checked == false &&
                    ck_NgayLapThe.Checked == false &&
                    ck_NgaySinh.Checked == false &&
                    ck_Username.Checked == false
                    )
                {
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("HoTen;", "");
                    bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
                }
            }

        }

        private void ck_NgaySinh_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_NgaySinh.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                Uncheck_ck_TatCa();
                //Show_FindGrid();
                keycolumn += "NgaySinh;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_DiaChi.Checked == false &&
                    ck_Email.Checked == false &&
                    ck_MaDocGia.Checked == false &&
                    ck_LoaiDocGia.Checked == false &&
                    ck_NgayHetHan.Checked == false &&
                    ck_NgayLapThe.Checked == false &&
                    ck_HoTen.Checked == false &&
                    ck_Username.Checked == false
                    )
                {
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("NgaySinh;", "");
                    bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_DiaChi_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_DiaChi.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                Uncheck_ck_TatCa();
                //Show_FindGrid();
                keycolumn += "DiaChi;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_HoTen.Checked == false &&
                    ck_Email.Checked == false &&
                    ck_MaDocGia.Checked == false &&
                    ck_LoaiDocGia.Checked == false &&
                    ck_NgayHetHan.Checked == false &&
                    ck_NgayLapThe.Checked == false &&
                    ck_NgaySinh.Checked == false &&
                    ck_Username.Checked == false
                    )
                {
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("DiaChi;", "");
                    bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_Email_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_Email.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                Uncheck_ck_TatCa();
                //Show_FindGrid();
                keycolumn += "Email;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_HoTen.Checked == false &&
                    ck_DiaChi.Checked == false &&
                    ck_MaDocGia.Checked == false &&
                    ck_LoaiDocGia.Checked == false &&
                    ck_NgayHetHan.Checked == false &&
                    ck_NgayLapThe.Checked == false &&
                    ck_NgaySinh.Checked == false &&
                    ck_Username.Checked == false
                    )
                {
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("Email;", "");
                    bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_Username_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_Username.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                Uncheck_ck_TatCa();
                //Show_FindGrid();
                keycolumn += "IDUser;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_HoTen.Checked == false &&
                    ck_DiaChi.Checked == false &&
                    ck_MaDocGia.Checked == false &&
                    ck_LoaiDocGia.Checked == false &&
                    ck_NgayHetHan.Checked == false &&
                    ck_NgayLapThe.Checked == false &&
                    ck_NgaySinh.Checked == false &&
                    ck_Email.Checked == false
                    )
                {
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("IDUser;", "");
                    bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_LoaiDocGia_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_LoaiDocGia.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                Uncheck_ck_TatCa();
                //Show_FindGrid();
                keycolumn += "MaLoaiDocGia;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_HoTen.Checked == false &&
                    ck_DiaChi.Checked == false &&
                    ck_MaDocGia.Checked == false &&
                    ck_Username.Checked == false &&
                    ck_NgayHetHan.Checked == false &&
                    ck_NgayLapThe.Checked == false &&
                    ck_NgaySinh.Checked == false &&
                    ck_Email.Checked == false
                    )
                {
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("MaLoaiDocGia;", "");
                    bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_NgayLapThe_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_NgayLapThe.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                Uncheck_ck_TatCa();
                //Show_FindGrid();
                keycolumn += "NgayLapThe;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_HoTen.Checked == false &&
                    ck_DiaChi.Checked == false &&
                    ck_MaDocGia.Checked == false &&
                    ck_Username.Checked == false &&
                    ck_NgayHetHan.Checked == false &&
                    ck_LoaiDocGia.Checked == false &&
                    ck_NgaySinh.Checked == false &&
                    ck_Email.Checked == false
                    )
                {
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("NgayLapThe;", "");
                    bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_NgayHetHan_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_NgayHetHan.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                Uncheck_ck_TatCa();
                //Show_FindGrid();
                keycolumn += "NgayHetHan;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_HoTen.Checked == false &&
                    ck_DiaChi.Checked == false &&
                    ck_MaDocGia.Checked == false &&
                    ck_Username.Checked == false &&
                    ck_NgayLapThe.Checked == false &&
                    ck_LoaiDocGia.Checked == false &&
                    ck_NgaySinh.Checked == false &&
                    ck_Email.Checked == false
                    )
                {
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("NgayHetHan;", "");
                    bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }
        #endregion
        #region Event_Click
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemDocGia themdocgia = new frmThemDocGia();
            themdocgia.ShowDialog();
            btnLamMoi_ItemClick(sender, e);
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bandedGridView.RowCount > 0)
            {
                UnReadOnly_SuaThongTin();
                gridControl.Focus();
                LoadDataSourceLDG();
            }
            
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _index = 0;
            gridControl.DataSource = null;
            bandedGridView.FindFilterText = "";
            ReadOnly_SuaThongTin();
            LoadDocGiaInfo();
            if (bandedGridView.RowCount > 0)
            {
                LoadDataSourceLDG(bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString());
            }
            bandedGridView.Focus();
            //_index = 0;
        }
        private void bandedGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int a = bandedGridView.GetFocusedDataSourceRowIndex();
            if (_index == a && lo_btnHuy.ContentVisible == true)
            {
                FormatBD_TTDocGia();
                //gluedLoaiDocGia.EditValue = bandedGridView.GetFocusedRowCellValue(colLoaiDocGia);
                //LoadDataSourceLDG();
            }
        }
        //private void bandGridview_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        //{
        //    Thread.Sleep(100);
        //    //int a = bandedGridView.GetFocusedDataSourceRowIndex();
        //    if (lo_btnHuy.ContentVisible == false)
        //    {
        //        LoadDataSourceLDG(bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString());
        //    }
        //    else
        //    {
        //        LoadDataSourceLDG();
        //    }

        //    //if (a != _index)
        //    //{
        //    //    _index = a;
        //    //}
        //    //else
        //    //{
        //    //    //gluedLoaiDocGia.Text = bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString();
        //    //    //if (lo_btnHuy.ContentVisible == false)
        //    //    //{
        //    //    //    LoadDataSourceLDG(gluedLoaiDocGia.EditValue.ToString());
        //    //    //}
        //    //    //else
        //    //    //{
        //    //    //    LoadDataSourceLDG();
        //    //    //}
        //    //}
        //}
        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn lưu thông tin độc giả đã thay đổi không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string IdDG = bandedGridView.GetFocusedRowCellValue(colMaDocGia).ToString();
                QLTV_BUS.DOCGIABUS.Instance.UpdateInfoDocGia(IdDG, txbHoTen.Text, txbDiaChi.Text, (DateTime)dateNgaySinh.EditValue, txbEmail.Text, gluedLoaiDocGia.EditValue.ToString());
                QLTV_BUS.USERBUS.Instance.UpdateInfoUser(txbUserName.Text, txbPassword.Text);
                btnLamMoi_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);
                gridControl.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ReadOnly_SuaThongTin();
            gridControl.Focus();
            LoadDataSourceLDG(bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString());
            FormatBD_TTDocGia();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txbPassword.Text = "12345678";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bandedGridView.RowCount > 0)
            {
                if (gridControl.IsFocused == true)
                {
                    if (XtraMessageBox.Show("Bạn có muốn xóa thông tin độc giả đã chọn không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        DOCGIABUS.Instance.RemoveInfoDocGia(bandedGridView.GetFocusedRowCellValue(colMaDocGia).ToString());
                        USERBUS.Instance.RemoveInfoUser(bandedGridView.GetFocusedRowCellValue(colUsername).ToString());
                        btnLamMoi_ItemClick(sender, e);
                    }
                    else gridControl.Focus();
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn thông tin độc giả muốn xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { }

        }
        #endregion
        #region Envent_Changed
        private void bandedGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bandedGridView.RowCount > 0)
            {
                _index = bandedGridView.GetFocusedDataSourceRowIndex();
                if (lo_btnHuy.ContentVisible == true)
                {
                    LoadDataSourceLDG();
                }
                else
                {
                    LoadDataSourceLDG(bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString());
                }
            }
        }
        private void bandedGridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (bandedGridView.RowCount > 0)
            {
                bandedGridView_FocusedRowChanged(sender, e as DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs);
                FormatBD_TTDocGia();
            }
            else
            {
                txbMaDocGia.Text = "";
                txbHoTen.Text = "";
                txbDiaChi.Text = "";
                txbEmail.Text = "";
                txbPassword.Text = "";
                txbUserName.Text = "";
                dateNgaySinh.EditValue = null;
                dateNgayLapThe.EditValue = null;
                dateNgayHetHan.EditValue = null;
                gluedLoaiDocGia.Properties.DataSource = null;
                ReadOnly_SuaThongTin();
            }
        }
        #endregion 
    }
}