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
        string keycolumn = "";
        List<TTDOCGIADTO> listdg = new List<TTDOCGIADTO>();
        int tuoimin;
        int tuoimax;
        List<string> listemail = new List<string>();
        List<string> listsdt = new List<string>();
        List<ADMIN> listad = new List<ADMIN>();
        public frmDocGia()
        {
            InitializeComponent();
        }
        #endregion
        #region Event_Load
        private void frmDocGia_Load(object sender, EventArgs e)
        {
            lo_btnLuu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnReset.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            LoadDocGiaInfo();
            Binding_DocGia();
            LoadAdminInfo();
            if (bandedGridView.RowCount > 0)
            {
                LoadDataSourceLDG(bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString());
            }
            gridControl.Focus();
        }
        #endregion
        #region Methods
        void LoadAdminInfo()
        {
            listad = ADMINBUS.Instance.GetInfoAdmin().ToList();
        }
        void LoadDocGiaInfo()
        {
            listdg.Clear();
            listdg = QLTV_BUS.TTDOCGIABUS.Instance.GetListDocGiaInfo();
            ListBDDocGia.DataSource = listdg.ToList();
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
                txbUserName.DataBindings.Add("Text", ListBDDocGia, "IDAccount",true, DataSourceUpdateMode.Never);
                txbPassword.DataBindings.Add("Text", ListBDDocGia, "PasswordAccount",true, DataSourceUpdateMode.Never);
                gluedLoaiDocGia.DataBindings.Add("EditValue", ListBDDocGia, "MaLoaiDocGia", true, DataSourceUpdateMode.Never);
                dateNgayLapThe.DataBindings.Add("EditValue", ListBDDocGia, "NgayLapThe", true, DataSourceUpdateMode.Never);
                dateNgayHetHan.DataBindings.Add("EditValue", ListBDDocGia, "NgayHetHan", true, DataSourceUpdateMode.Never);
                txbSDT.DataBindings.Add("Text", ListBDDocGia, "SDT", true, DataSourceUpdateMode.Never);
                txbTongNo.DataBindings.Add("Text", ListBDDocGia, "TongNo", true, DataSourceUpdateMode.Never);
            }
            catch
            {

            }
        }
        void LoadDataSourceLDG(string IdMaLDG = "")
        {
            var listDG = QLTV_BUS.LOAIDOCGIABUS.Instance.GetLoaiDocGia(IdMaLDG);
            gluedLoaiDocGia.Properties.DataSource = listDG;
            gluedLoaiDocGia.Properties.ValueMember = "MaLoaiDocGia";
            gluedLoaiDocGia.Properties.DisplayMember = "TenLoaiDocGia";
        }
        void ReadOnly_SuaThongTin()
        {
            lo_btnLuu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnReset.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnGiaHan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnOK.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_seGiaHan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            txbEmail.ReadOnly = true;
            txbHoTen.ReadOnly = true;
            gluedLoaiDocGia.ReadOnly = true;
            dateNgaySinh.ReadOnly = true;
            txbDiaChi.ReadOnly = true;
            gluedLoaiDocGia.Properties.AllowFocused = false;
            btnSua.Enabled = true;
            txbSDT.ReadOnly = true;
        }
        void UnReadOnly_SuaThongTin()
        {
            lo_btnLuu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            lo_btnReset.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            lo_btnGiaHan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            txbEmail.ReadOnly = false;
            txbHoTen.ReadOnly = false;
            gluedLoaiDocGia.ReadOnly = false;
            dateNgaySinh.ReadOnly = false;
            txbDiaChi.ReadOnly = false;
            gluedLoaiDocGia.Properties.AllowFocused = true;
            txbSDT.ReadOnly = false;
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
            txbSDT.Text = bandedGridView.GetFocusedRowCellValue(colSDT).ToString();
            txbTongNo.Text = bandedGridView.GetFocusedRowCellValue(colTongNo).ToString();
        }
        //lấy danh sách email 
        List<string> ListEmail()
        {
            listemail.Clear();
            foreach (var item in listdg)
            {
                listemail.Add(item.Email);
            }
            foreach(var item in listad)
            {
                listemail.Add(item.Email);
            }
            return listemail;
        }
        List<string> ListSDT()
        {
            listsdt.Clear();
            foreach (var item in listdg)
            {
                listsdt.Add(item.SDT);
            }
            foreach (var item in listad)
            {
                listsdt.Add(item.NumberPhone);
            }
            return listsdt;
        }
        bool KiemTraTatCaUnCheck()
        {
            if (
                    ck_TatCa.Checked == false &&
                    ck_DiaChi.Checked == false &&
                    ck_Email.Checked == false &&
                    ck_HoTen.Checked == false &&
                    ck_LoaiDocGia.Checked == false &&
                    ck_NgayHetHan.Checked == false &&
                    ck_NgayLapThe.Checked == false &&
                    ck_NgaySinh.Checked == false &&
                    ck_Username.Checked == false &&
                    ck_MaDocGia.Checked == false &&
                    ck_SDT.Checked == false
                    )
                return true;
            return false;
        }
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
                ck_SDT.Checked = false;
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
        private void ck_SDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_SDT.Checked == true)
            {
                Uncheck_ck_TatCa();
                keycolumn += "SDT;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (KiemTraTatCaUnCheck())
                {
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("SDT;", "");
                    bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }
        private void ck_MaDocGia_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_MaDocGia.Checked == true)
            {
                Uncheck_ck_TatCa();
                keycolumn += "MaDocGia;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (KiemTraTatCaUnCheck())
                {
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
                Uncheck_ck_TatCa();
                keycolumn += "HoTen;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (KiemTraTatCaUnCheck())
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
                Uncheck_ck_TatCa();
                keycolumn += "NgaySinh;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (KiemTraTatCaUnCheck())
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
                Uncheck_ck_TatCa();
                keycolumn += "DiaChi;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (KiemTraTatCaUnCheck())
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
                Uncheck_ck_TatCa();
                keycolumn += "Email;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (KiemTraTatCaUnCheck())
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
                Uncheck_ck_TatCa();
                keycolumn += "IDAccount;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (KiemTraTatCaUnCheck())
                {
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("IDAccount;", "");
                    bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_LoaiDocGia_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_LoaiDocGia.Checked == true)
            {
                Uncheck_ck_TatCa();
                keycolumn += "MaLoaiDocGia;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (KiemTraTatCaUnCheck())
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
                Uncheck_ck_TatCa();
                keycolumn += "NgayLapThe;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (KiemTraTatCaUnCheck())
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
                Uncheck_ck_TatCa();
                keycolumn += "NgayHetHan;";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (KiemTraTatCaUnCheck())
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
                btnSua.Enabled = false;
            }
            
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl.DataSource = null;
            bandedGridView.FindFilterText = "";
            ReadOnly_SuaThongTin();
            LoadDocGiaInfo();
            LoadAdminInfo();
            if (bandedGridView.RowCount > 0)
            {
                LoadDataSourceLDG(bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString());
            }
            bandedGridView.Focus();
        }
        private void bandedGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (lo_btnHuy.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                FormatBD_TTDocGia();
                dxErrorProvider1.SetError(txbEmail, null);
                dxErrorProvider1.SetError(txbSDT, null);
            }
        }
        //private void bandGridview_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        //{
        //    Thread.Sleep(100);
        //    //int a = bandedGridView.GetFocusedDataSourceRowIndex();
        //    if (lo_btnHuy.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Never)
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
        //    //    //if (lo_btnHuy.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Never)
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
            if (!dxErrorProvider1.HasErrors)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu thông tin độc giả đã thay đổi không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string IdDG = bandedGridView.GetFocusedRowCellValue(colMaDocGia).ToString();
                    QLTV_BUS.DOCGIABUS.Instance.UpdateInfoDocGia(IdDG, txbHoTen.Text, txbDiaChi.Text, Convert.ToDateTime(dateNgaySinh.EditValue), txbEmail.Text, gluedLoaiDocGia.EditValue.ToString(), Convert.ToDateTime(dateNgayHetHan.EditValue), txbSDT.Text);
                    QLTV_BUS.ACCOUNTBUS.Instance.UpdateInfoAccount(txbUserName.Text, txbPassword.Text);
                    XtraMessageBox.Show("Thay đổi đã lưu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);
                    gridControl.Focus();
                }
            }
            else
            {
                XtraMessageBox.Show("Thông tin độc giả đã sửa không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        try
                        {
                            DOCGIABUS.Instance.RemoveInfoDocGia(bandedGridView.GetFocusedRowCellValue(colMaDocGia).ToString());
                            ACCOUNTBUS.Instance.RemoveInfoAccount(bandedGridView.GetFocusedRowCellValue(colUsername).ToString());
                            btnLamMoi_ItemClick(sender, e);
                        }
                        catch { XtraMessageBox.Show("Không thể xóa độc giả này", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            lo_btnGiaHan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnOK.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            lo_seGiaHan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            dateNgayHetHan.EditValue = Convert.ToDateTime(dateNgayHetHan.EditValue).AddMonths(Convert.ToInt32(seGiaHan.EditValue)).ToString();
            lo_btnGiaHan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            lo_btnOK.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_seGiaHan.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            btnLuuLai.Focus();
        }
        #endregion
        #region Envent_Changed
        private void bandedGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bandedGridView.RowCount > 0)
            {
                if (lo_btnHuy.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
                {
                    LoadDataSourceLDG();
                    dxErrorProvider1.SetError(txbEmail, null);
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
                txbSDT.Text = "";
                txbTongNo.Text = "";
                dateNgaySinh.EditValue = null;
                dateNgayLapThe.EditValue = null;
                dateNgayHetHan.EditValue = null;
                gluedLoaiDocGia.Properties.DataSource = null;
                ReadOnly_SuaThongTin();
                dxErrorProvider1.SetError(txbHoTen, null);
                dxErrorProvider1.SetError(dateNgaySinh, null);
                dxErrorProvider1.SetError(txbEmail, null);
                dxErrorProvider1.SetError(txbDiaChi, null);
                dxErrorProvider1.SetError(txbSDT, null);
            }
        }
        private void txbHoTen_EditValueChanged(object sender, EventArgs e)
        {
            if(lo_btnLuu.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbHoTen, HelpGUI.KiemTraDieuKien.isTen(txbHoTen.Text.Trim()), "Tên độc giả không hợp lệ!");
            }
            else
            {
                dxErrorProvider1.SetError(txbHoTen, null);
            }
        }

        private void dateNgaySinh_EditValueChanged(object sender, EventArgs e)
        {
            tuoimin = THAMSOBUS.Instance.GetDSQuiDinh()[0].TuoiToiThieu;
            tuoimax = THAMSOBUS.Instance.GetDSQuiDinh()[0].TuoiToiDa;
            if (lo_btnLuu.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, dateNgaySinh, HelpGUI.KiemTraDieuKien.Check_Tuoi(dateNgaySinh.EditValue), $"Ngày sinh không hợp lệ!\r\nTuổi phải từ {tuoimin} đến {tuoimax}");
            }
            else
            {
                dxErrorProvider1.SetError(dateNgaySinh, null);
            }
        }

        private void txbDiaChi_EditValueChanged(object sender, EventArgs e)
        {
            if (lo_btnLuu.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbDiaChi, HelpGUI.KiemTraDieuKien.isDiaChi(txbDiaChi.Text.Trim()), "Địa chỉ không hợp lệ!");
            }
            else
            {
                dxErrorProvider1.SetError(txbDiaChi, null);
            }
        }

        private void txbEmail_EditValueChanged(object sender, EventArgs e)
        {
            ListEmail();
            if (lo_btnLuu.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                try
                {
                    if (txbEmail.Text != bandedGridView.GetFocusedRowCellValue(colEmail).ToString())
                    {
                        HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbEmail, HelpGUI.KiemTraDieuKien.isEmail(txbEmail.Text.Trim()), "Email không hợp lệ!", HelpGUI.KiemTraDieuKien.Check_Trung(listemail, txbEmail.Text), "Email này đã được sử dụng!");
                    }
                    else dxErrorProvider1.SetError(txbEmail, null);
                }
                catch { }
            }
            else
            {
                dxErrorProvider1.SetError(txbEmail, null);
            }
        }
        private void txbSDT_EditValueChanged(object sender, EventArgs e)
        {
            ListSDT();
            if (lo_btnLuu.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                try
                {
                    if (txbSDT.Text != bandedGridView.GetFocusedRowCellValue(colSDT).ToString())
                    {
                        HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbSDT, HelpGUI.KiemTraDieuKien.isNumPhone(txbSDT.Text.Trim()), "Số điện thoại không hợp lệ!\r\nPhải có 9 đến 11 số", HelpGUI.KiemTraDieuKien.Check_Trung(listsdt, txbSDT.Text), "Số điện thoại này đã được sử dụng!");
                    }
                    else dxErrorProvider1.SetError(txbSDT, null);
                }
                catch { }
            }
            else
            {
                dxErrorProvider1.SetError(txbSDT, null);
            }
        }
        #endregion
        #region Event_KeyPress
        private void txbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelpGUI.KiemTraDieuKien.NhapSo(e);
        }
        #endregion
    }
}