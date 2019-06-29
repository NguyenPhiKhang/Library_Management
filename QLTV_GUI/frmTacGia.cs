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
    public partial class frmTacGia : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        BindingSource listbdtacgia = new BindingSource();
        string keycolunm = "";
        public frmTacGia()
        {
            InitializeComponent();
        }
        #endregion
        #region Event_Load
        private void frmTacGia_Load(object sender, EventArgs e)
        {
            LoadTacGiaInfo();
            Binding_TacGia();
            Show_FindGrid();
            lo_btnLuu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }
        #endregion
        #region Event_Click
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bandedGridView1.RowCount < THAMSOBUS.Instance.GetDSQuiDinh().ToList()[0].SoLuongTacGia)
            {
                frmThemTacGia addTacGia = new frmThemTacGia();
                addTacGia.ShowDialog();
            }
            else XtraMessageBox.Show("Vượt quá số lượng tác giả quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!dxErrorProvider1.HasErrors)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu thông tin độc giả đã sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string IdTG = bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString();
                    QLTV_BUS.TACGIABUS.Instance.UpdateInfoTacgia(txbMaTacGia.Text, txbTenTacGia.Text);
                    ReadOnly_SuaThongTin();
                    XtraMessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);

                    gridControl1.Focus();

                }
            }
            else
            { XtraMessageBox.Show("Không hợp lệ!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.DataSource = null;
            bandedGridView1.FindFilterText = "";
            ReadOnly_SuaThongTin();
            LoadTacGiaInfo();
            bandedGridView1.Focus();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bandedGridView1.RowCount > 0)
            {
                UnReadOnly_SuaThongTin();
                gridControl1.Focus();
                btnSua.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ReadOnly_SuaThongTin();
            gridControl1.Focus();
            txbMaTacGia.Text = bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString();
            txbTenTacGia.Text = bandedGridView1.GetFocusedRowCellValue(colTenTacGia).ToString();
            FormatBD_TacGia();
        }
        private void bandedGridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (lo_btnHuy.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                txbTenTacGia.Text = bandedGridView1.GetFocusedRowCellValue(colTenTacGia).ToString();
            }
        }
        #endregion
        #region Methods
        void Binding_TacGia()
        {
            try
            {
                txbMaTacGia.DataBindings.Add("Text", listbdtacgia, "MaTacGia", true, DataSourceUpdateMode.Never);
                txbTenTacGia.DataBindings.Add("Text", listbdtacgia, "TenTacGia", true, DataSourceUpdateMode.Never);
            }
            catch
            { }
        }
        void ReadOnly_SuaThongTin()
        {
            lo_btnLuu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            txbMaTacGia.ReadOnly = true;
            txbTenTacGia.ReadOnly = true;
            btnSua.Enabled = true;
        }

        void UnReadOnly_SuaThongTin()
        {
            lo_btnLuu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            txbMaTacGia.ReadOnly = true;
            txbTenTacGia.ReadOnly = false;

        }

        private void Show_FindGrid()
        {
            if (!bandedGridView1.IsFindPanelVisible)
                bandedGridView1.ShowFindPanel();
        }

        private void Hide_FindGrid()
        {
            if (bandedGridView1.IsFindPanelVisible)
                bandedGridView1.HideFindPanel();
        }

        void KiemTra_Tatca_Check()
        {
            if (ck_TatCa.Checked == true)
                ck_TatCa.Checked = false;
        }

        void LoadTacGiaInfo()
        {
            List<TACGIA> list = QLTV_BUS.TACGIABUS.Instance.GetListTacGia();
            listbdtacgia.DataSource = list.ToList();
            gridControl1.DataSource = listbdtacgia;
        }
        void Uncheck_ck_TatCa()
        {
            if (ck_TatCa.Checked == true)
                ck_TatCa.Checked = false;
        }

        bool KiemTraTatCaUnCheck()
        {
            if (
                    ck_TatCa.Checked == false &&
                    ck_MaTacGia.Checked == false &&
                    ck_TatCa.Checked == false
                    )
                return true;
            return false;
        }
        void FormatBD_TacGia()
        {
            txbTenTacGia.Text = bandedGridView1.GetFocusedRowCellValue(colTenTacGia).ToString();
        }
        #endregion
        #region Event_CheckFind
        private void ck_TatCa_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_TatCa.Checked == true)
            {
                ck_MaTacGia.Checked = false;
                ck_TenTacGia.Checked = false;
                bandedGridView1.OptionsFind.FindFilterColumns = "*";
                //Show_FindGrid();
                keycolunm = "*";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolunm;
                ck_TatCa.Enabled = false;
            }
            else
            {
                keycolunm = "";
                //Hide_FindGrid();
            }
        }
        private void ck_MaTacGia_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_MaTacGia.Checked == true)
            {
                if (ck_MaTacGia.Checked == true)
                {
                    Uncheck_ck_TatCa();
                    keycolunm += "MaTacGia";
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolunm;
                }
                else
                {
                    if (KiemTraTatCaUnCheck())
                    {
                        ck_TatCa.Checked = true;
                    }
                    else
                    {
                        keycolunm = keycolunm.Replace("MaTacGia;", "");
                        bandedGridView1.OptionsFind.FindFilterColumns = keycolunm;
                    }
                }
            }
        }

        private void ck_TenTacGia_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_TenTacGia.Checked == true)
            {
                if (ck_TenTacGia.Checked == true)
                {
                    Uncheck_ck_TatCa();
                    keycolunm += "TenTacGia";
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolunm;
                }
                else
                {
                    if (KiemTraTatCaUnCheck())
                    {
                        ck_TatCa.Checked = true;
                    }
                    else
                    {
                        keycolunm = keycolunm.Replace("TenTacGia;", "");
                        bandedGridView1.OptionsFind.FindFilterColumns = keycolunm;
                    }
                }
            }
        }
        #endregion
        #region Event_Changed
        private void txbMaTacGia_EditValueChanged(object sender, EventArgs e)
        {
            if (lo_btnLuu.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {

            }
        }
        private void txbTenTacGia_EditValueChanged(object sender, EventArgs e)
        {
            if (lo_btnLuu.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                //HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbTenTacGia, HelpGUI.KiemTraDieuKien.isTenSach(txbTenTacGia.Text.Trim()), "Tên không hợp lệ!");
            }
            else
            {
                dxErrorProvider1.SetError(txbTenTacGia, null);
            }
        }

        private void bandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (bandedGridView1.RowCount <= 0)
            {
                txbMaTacGia.Text = "";
                txbTenTacGia.Text = "";
                dxErrorProvider1.SetError(txbTenTacGia, null);
                ReadOnly_SuaThongTin();
            }
            else
            {
                bandedGridView1_FocusedRowChanged(sender, e as DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs);

                FormatBD_TacGia();
            }
        }

        private void bandedGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }
        #endregion
    }
}