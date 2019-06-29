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
        #region Declare & Load
        int _index = 0;
        string keycolumn = "";
        BindingSource ListBDSach = new BindingSource();
        public frmSach()
        {
            InitializeComponent();
        
            
            //layoutControlGroup2.Visible = false;
        }
        void LoadDataSourceLDG(string theloai = "", string tacgia = "", string tinhtrang = "")
        {
            var list = QLTV_BUS.THELOAIBUS.Instance.GetTheLoai(theloai);

            glued_TheLoai.Properties.DataSource = list;

            glued_TheLoai.Properties.ValueMember = "MaTheLoai";
            glued_TheLoai.Properties.DisplayMember = "TenTheLoai";

            var list2 = QLTV_BUS.TACGIABUS.Instance.GetTacGia(tacgia);
            glued_TacGia.Properties.DataSource = list2;

            glued_TacGia.Properties.ValueMember = "MaTacGia";
            glued_TacGia.Properties.DisplayMember = "TenTacGia";
            var list3 = QLTV_BUS.TINHTRANGBUS.Instance.GetTinhTrang(tinhtrang);
            glued_TinhTrang.Properties.DataSource = list3;

            glued_TinhTrang.Properties.ValueMember = "MaTinhTrang";
            glued_TinhTrang.Properties.DisplayMember = "TenTinhTrang";
        }
        
        private void frmSach_Load(object sender, EventArgs e)
        {
            LoadSachInfo();
            Binding_Sach();
            if (bandedGridView1.RowCount > 0)
            {
                LoadDataSourceLDG(bandedGridView1.GetFocusedRowCellValue(colMatheloai).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTinhTrang).ToString());
            }

            lo_btnLuuLai.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            Readonly();
            gridControl1.Focus();
        }
        void LoadSachInfo()
        {
            List<SACH> list = QLTV_BUS.SACHBUS.Instance.GetListSachInfo();
            //gridControl.DataSource = list.ToList();
            //bindingSource1.DataSource = list.ToList();
            ListBDSach.DataSource = list.ToList();
            gridControl1.DataSource = ListBDSach;
        }
        #endregion
        #region Methods
        void Binding_Sach()
        {
            try
            {
                txbMaSach.DataBindings.Add("Text", ListBDSach, "MaSach", true, DataSourceUpdateMode.Never);
                txbTenSach.DataBindings.Add("Text", ListBDSach, "TenSach", true, DataSourceUpdateMode.Never);
                dateNgayNhap.DataBindings.Add("EditValue", ListBDSach, "NgayNhap", true, DataSourceUpdateMode.Never);
                dateNamSX.DataBindings.Add("EditValue", ListBDSach, "NamXuatBan", true, DataSourceUpdateMode.Never);
                glued_TheLoai.DataBindings.Add("EditValue", ListBDSach, "MaTheLoai", true, DataSourceUpdateMode.Never);
                txbNhaSX.DataBindings.Add("Text", ListBDSach, "NhaXuatBan",true, DataSourceUpdateMode.Never);
                glued_TacGia.DataBindings.Add("EditValue", ListBDSach, "MaTacGia", true, DataSourceUpdateMode.Never);
                txbTriGia.DataBindings.Add("Text", ListBDSach, "TriGia", true, DataSourceUpdateMode.Never);

                glued_TinhTrang.DataBindings.Add("EditValue", ListBDSach, "MaTinhTrang", true, DataSourceUpdateMode.Never);

            }
            catch
            {

            }

        }

        void UnReadonly()
        {

            txbNhaSX.Properties.ReadOnly = false;
            txbTenSach.Properties.ReadOnly = false;
            txbTriGia.Properties.ReadOnly = false;
            dateNamSX.Properties.ReadOnly = false;
            glued_TacGia.Properties.ReadOnly = false;
            glued_TheLoai.Properties.ReadOnly = false;
            glued_TinhTrang.Properties.ReadOnly = false;
        }
        void Readonly()
        {

            txbNhaSX.Properties.ReadOnly = true;
            txbTenSach.Properties.ReadOnly = true;
            txbTriGia.Properties.ReadOnly = true;
            dateNamSX.Properties.ReadOnly = true;
            glued_TacGia.Properties.ReadOnly = true;
            glued_TheLoai.Properties.ReadOnly = true;
            glued_TinhTrang.Properties.ReadOnly = true;
        }
        private void bandedGridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int a = bandedGridView1.GetFocusedDataSourceRowIndex();
            if (_index == a && lo_btnHuy.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {

                txbMaSach.Text = bandedGridView1.GetFocusedRowCellValue(colMaSach).ToString();
                txbNhaSX.Text = bandedGridView1.GetFocusedRowCellValue(colNhaXuatBan).ToString();
                txbTenSach.Text = bandedGridView1.GetFocusedRowCellValue(coltensach).ToString();
                txbTriGia.EditValue = bandedGridView1.GetFocusedRowCellValue(colTriGia).ToString();
                dateNamSX.EditValue = bandedGridView1.GetFocusedRowCellValue(colNamXuatBan).ToString();
                dateNgayNhap.EditValue = bandedGridView1.GetFocusedRowCellValue(colNgayNhap).ToString();
                glued_TacGia.EditValue = bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString();
                glued_TheLoai.EditValue = bandedGridView1.GetFocusedRowCellValue(colMatheloai).ToString();
                glued_TinhTrang.EditValue = bandedGridView1.GetFocusedRowCellValue(colMaTinhTrang).ToString();

            }

        }
        #endregion
        #region Event_Click
        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemSach themsach = new frmThemSach();
            themsach.ShowDialog();
            btnLamMoi_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);
        }

       
        

       

        

       

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {if (bandedGridView1.RowCount > 0)
            {
                lo_btnLuuLai.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                UnReadonly();
                LoadDataSourceLDG();
            }
        }

        private void btn_LuuLai_Click(object sender, EventArgs e)
        {
            if (!dxErrorProvider1.HasErrors)
            {
                if (XtraMessageBox.Show("Ban có muốn lưu chỉnh sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    QLTV_BUS.SACHBUS.Instance.UpdateInfoSach(txbMaSach.Text, txbTenSach.Text, glued_TheLoai.EditValue.ToString(), (int)Convert.ToInt32(dateNamSX.EditValue), txbNhaSX.Text, glued_TacGia.EditValue.ToString(), (int)Convert.ToInt32(txbTriGia.EditValue), glued_TinhTrang.EditValue.ToString());
                    lo_btnLuuLai.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    Readonly();
                    btnLamMoi_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);
                    gridControl1.Focus();
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            lo_btnLuuLai.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;


            Readonly();

            btnLamMoi_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);
            gridControl1.Focus();
            
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {if (bandedGridView1.RowCount > 0)
            {
                if (gridControl1.IsFocused == true)
                {
                    if (XtraMessageBox.Show("Bạn có muốn xóa thông tin độc giả đã chọn không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {  try
                        {
                            QLTV_BUS.SACHBUS.Instance.RemoveInfoSach(bandedGridView1.GetFocusedRowCellValue(colMaSach).ToString());
                            btnLamMoi_ItemClick(sender, e);
                        }
                        catch
                        {
                            XtraMessageBox.Show("Không thể xóa Sách vì vẫn còn sử dụng trong các phiếu mượn, trả.");
                        }
                        
                        
                    }
                    else gridControl1.Focus();
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn thông tin độc giả muốn xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.DataSource = null;
            LoadSachInfo();
            gridControl1.Focus();
            try
            {
                LoadDataSourceLDG(bandedGridView1.GetFocusedRowCellValue(colMatheloai).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTinhTrang).ToString());
            }
            catch { }
            bandedGridView1.FindFilterText = "";
            lo_btnLuuLai.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            Readonly();
            gridControl1.Focus();
        }
        #endregion
        #region Check_Find

        private void ck_TatCa_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_TatCa.Checked == true)
            {
                ck_MaSach.Checked = false;
                ck_NamXuatBan.Checked = false;
                ck_NgayNhap.Checked = false;
                ck_NhaXB.Checked = false;
                ck_TacGia.Checked = false;
                ck_TenSach.Checked = false;
                ck_TheLoai.Checked = false;
                ck_TinhTrang.Checked = false;
                ck_TriGia.Checked = false;
                bandedGridView1.OptionsFind.FindFilterColumns = "*";
                //Show_FindGrid();
                keycolumn = "*";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                ck_TatCa.Enabled = false;
            }
            else
            {
                ck_TatCa.Enabled = true;
                keycolumn = "";
            }
        }

        private void ck_MaSach_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_MaSach.Checked == true)
            {
                if (ck_TatCa.Checked == true)
                    ck_TatCa.Checked = false;
               
                keycolumn += "MaSach;";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_NamXuatBan.Checked == false&&
                ck_NgayNhap.Checked == false&&
                ck_NhaXB.Checked == false&&
                ck_TacGia.Checked == false&&
                ck_TenSach.Checked == false&&
                ck_TheLoai.Checked == false&&
                ck_TinhTrang.Checked == false&&
                ck_TriGia.Checked == false
                    )
                {
                    
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("MaSach;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_TenSach_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_TenSach.Checked == true)
            {
                if (ck_TatCa.Checked == true)
                    ck_TatCa.Checked = false;
               
                keycolumn += "TenSach;";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_NamXuatBan.Checked == false &&
                ck_NgayNhap.Checked == false &&
                ck_NhaXB.Checked == false &&
                ck_TacGia.Checked == false &&
                ck_MaSach.Checked == false &&
                ck_TheLoai.Checked == false &&
                ck_TinhTrang.Checked == false &&
                ck_TriGia.Checked == false
                    )
                {
                    
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("TenSach;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_TheLoai_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_TheLoai.Checked == true)
            {
                if (ck_TatCa.Checked == true)
                    ck_TatCa.Checked = false;
                
                keycolumn += "MaTheLoai;";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_NamXuatBan.Checked == false &&
                ck_NgayNhap.Checked == false &&
                ck_NhaXB.Checked == false &&
                ck_TacGia.Checked == false &&
                ck_TenSach.Checked == false &&
                ck_MaSach.Checked == false &&
                ck_TinhTrang.Checked == false &&
                ck_TriGia.Checked == false
                    )
                {
                    
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("MaTheLoai;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_TacGia_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_TacGia.Checked == true)
            {
                if (ck_TatCa.Checked == true)
                    ck_TatCa.Checked = false;
                
                keycolumn += "MaTacGia;";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_NamXuatBan.Checked == false &&
                ck_NgayNhap.Checked == false &&
                ck_NhaXB.Checked == false &&
                ck_MaSach.Checked == false &&
                ck_TenSach.Checked == false &&
                ck_TheLoai.Checked == false &&
                ck_TinhTrang.Checked == false &&
                ck_TriGia.Checked == false
                    )
                {
                    
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("MaTacGia;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_NhaXB_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (ck_NhaXB.Checked == true)
            {
                if (ck_TatCa.Checked == true)
                    ck_TatCa.Checked = false;

                keycolumn += "NhaXuatBan;";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_NamXuatBan.Checked == false &&
                ck_NgayNhap.Checked == false &&
                ck_MaSach.Checked == false &&
                ck_TacGia.Checked == false &&
                ck_TenSach.Checked == false &&
                ck_TheLoai.Checked == false &&
                ck_TinhTrang.Checked == false &&
                ck_TriGia.Checked == false
                    )
                {

                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("NhaXuatBan;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_NamXuatBan_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (ck_NamXuatBan.Checked == true)
            {
                if (ck_TatCa.Checked == true)
                    ck_TatCa.Checked = false;

                keycolumn += "NamXuatBan;";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_MaSach.Checked == false &&
                ck_NgayNhap.Checked == false &&
                ck_NhaXB.Checked == false &&
                ck_TacGia.Checked == false &&
                ck_TenSach.Checked == false &&
                ck_TheLoai.Checked == false &&
                ck_TinhTrang.Checked == false &&
                ck_TriGia.Checked == false
                    )
                {

                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("NamXuatBan;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_TinhTrang_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (ck_TinhTrang.Checked == true)
            {
                if (ck_TatCa.Checked == true)
                    ck_TatCa.Checked = false;

                keycolumn += "MaTinhTrang;";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_NamXuatBan.Checked == false &&
                ck_NgayNhap.Checked == false &&
                ck_NhaXB.Checked == false &&
                ck_TacGia.Checked == false &&
                ck_TenSach.Checked == false &&
                ck_TheLoai.Checked == false &&
                ck_MaSach.Checked == false &&
                ck_TriGia.Checked == false
                    )
                {

                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("MaTinhTrang;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_TriGia_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (ck_TriGia.Checked == true)
            {
                if (ck_TatCa.Checked == true)
                    ck_TatCa.Checked = false;

                keycolumn += "TriGia;";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_NamXuatBan.Checked == false &&
                ck_NgayNhap.Checked == false &&
                ck_NhaXB.Checked == false &&
                ck_TacGia.Checked == false &&
                ck_TenSach.Checked == false &&
                ck_TheLoai.Checked == false &&
                ck_TinhTrang.Checked == false &&
                ck_MaSach.Checked == false
                    )
                {

                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("TriGia;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_NgayNhap_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (ck_NgayNhap.Checked == true)
            {
                if (ck_TatCa.Checked == true)
                    ck_TatCa.Checked = false;

                keycolumn += "NgayNhap;";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (
                    ck_TatCa.Checked == false &&
                    ck_NamXuatBan.Checked == false &&
                ck_MaSach.Checked == false &&
                ck_NhaXB.Checked == false &&
                ck_TacGia.Checked == false &&
                ck_TenSach.Checked == false &&
                ck_TheLoai.Checked == false &&
                ck_TinhTrang.Checked == false &&
                ck_TriGia.Checked == false
                    )
                {

                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("NgayNhap;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }
        #endregion
        #region Event_Changed
        private void bandedGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bandedGridView1.RowCount > 0)
            {
                _index = bandedGridView1.GetFocusedDataSourceRowIndex();
                if (lo_btnLuuLai.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Never)
                {
                    if (e != null)
                        LoadDataSourceLDG(bandedGridView1.GetFocusedRowCellValue(colMatheloai).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTinhTrang).ToString());
                }
                else
                {
                    LoadDataSourceLDG();
                }
            }
            else
            {
                Readonly();
                lo_btnLuuLai.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void bandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (bandedGridView1.RowCount > 0)
            {
                bandedGridView1_FocusedRowChanged(sender, e as DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs);
                try
                {
                    txbMaSach.Text = bandedGridView1.GetFocusedRowCellValue(colMaSach).ToString();
                    txbNhaSX.Text = bandedGridView1.GetFocusedRowCellValue(colNhaXuatBan).ToString();
                    txbTenSach.Text = bandedGridView1.GetFocusedRowCellValue(coltensach).ToString();
                    txbTriGia.EditValue = bandedGridView1.GetFocusedRowCellValue(colTriGia).ToString();
                    dateNamSX.EditValue = bandedGridView1.GetFocusedRowCellValue(colNamXuatBan).ToString();
                    dateNgayNhap.EditValue = bandedGridView1.GetFocusedRowCellValue(colNgayNhap).ToString();
                    glued_TacGia.EditValue = bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString();
                    glued_TheLoai.EditValue = bandedGridView1.GetFocusedRowCellValue(colMatheloai).ToString();
                    glued_TinhTrang.EditValue = bandedGridView1.GetFocusedRowCellValue(colMaTinhTrang).ToString();
                }
                catch { }



            }
            else
            {

                txbNhaSX.Text = "";
                txbMaSach.Text = "";
                txbTenSach.Text = "";
                txbTriGia.EditValue = null;
                dateNamSX.EditValue = null;
                dateNgayNhap.EditValue = null;
                glued_TacGia.Properties.DataSource = null;
                glued_TheLoai.Properties.DataSource = null;
                glued_TinhTrang.Properties.DataSource = null;

                Readonly();
                dxErrorProvider1.SetError(txbTenSach, null);
                dxErrorProvider1.SetError(txbNhaSX, null);
                dxErrorProvider1.SetError(dateNamSX, null);
                dxErrorProvider1.SetError(txbTriGia, null);
            }
        }

        private void txbTenSach_EditValueChanged(object sender, EventArgs e)
        {
            //if (bandedGridView1.RowCount > 0)
                //HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbTenSach, HelpGUI.KiemTraDieuKien.isTenSach(txbTenSach.Text.Trim()), "Tên Sách không hợp lệ!");
        }
        private void txbNhaSX_EditValueChanged(object sender, EventArgs e)
        {
            if (bandedGridView1.RowCount > 0)
                HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbNhaSX, HelpGUI.KiemTraDieuKien.isDiaChi(txbNhaSX.Text.Trim()), "Tên NXB không hợp lệ!");
        }

        private void dateNamSX_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider1.SetIconAlignment(dateNamSX, ErrorIconAlignment.BottomRight);
            if (bandedGridView1.RowCount > 0)
            {
                if (Convert.ToInt32(dateNamSX.EditValue.ToString()) > DateTime.Now.Year)
                    dxErrorProvider1.SetError(dateNamSX, "Năm Xuất Bản không hợp lệ !");
                else if (Convert.ToInt32(dateNamSX.EditValue.ToString()) < DateTime.Now.Year - THAMSOBUS.Instance.GetDSQuiDinh()[0].KhoangCachXB)
                    dxErrorProvider1.SetError(dateNamSX, "Sai Quy Định Chỉ nhận sách xuất bản trong vòng " + THAMSOBUS.Instance.GetDSQuiDinh()[0].KhoangCachXB + " năm.");
                else dxErrorProvider1.SetError(dateNamSX, null);
            }
        }
        #endregion
    }
}