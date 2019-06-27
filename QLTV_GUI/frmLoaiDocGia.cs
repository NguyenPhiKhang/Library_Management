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
using QLTV_BUS;

namespace QLTV_GUI
{
    public partial class frmLoaiDocGia : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        BindingSource listBDLDG = new BindingSource();
        string keycolumn = "";
        public frmLoaiDocGia()
        {
            InitializeComponent();
            bandedGridView1.Focus();
        }
        #endregion
        #region Event_Load
        private void frmLoaiDocGia_Load(object sender, EventArgs e)
        {
            LoadDSLoaiDG();
            Binding_LDG();
            ReadOnly_LDG();
            bandedGridView1.Focus();
        }
        #endregion
        #region Methods
        void LoadDSLoaiDG()
        {
            listBDLDG.DataSource = QLTV_BUS.LOAIDOCGIABUS.Instance.GetLoaiDocGia().ToList();
            gridControl1.DataSource = listBDLDG;
        }
        void Binding_LDG()
        {
            txbMaLoaiDocGia.DataBindings.Add("Text", listBDLDG, "MaLoaiDocGia", true, DataSourceUpdateMode.Never);
            txbTenLoaiDocGia.DataBindings.Add("Text", listBDLDG, "TenLoaiDocGia", true, DataSourceUpdateMode.Never);
        }
        void ReadOnly_LDG()
        {
            txbTenLoaiDocGia.ReadOnly = true;
            btnLuuLai.Enabled = false;
            btnHuy.Enabled = false;
            btnSua.ItemAppearance.Normal.Reset();

        }
        void UnReadOnly_LDG()
        {
            txbTenLoaiDocGia.ReadOnly = false;
            btnLuuLai.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.ItemAppearance.Normal.BackColor = Color.Silver;
        }
        void UnCheck_ckTatCa()
        {
            if (ck_TatCa.Checked == true)
                ck_TatCa.Checked = false;
        }
        #endregion
        #region Check_Find
        private void btnTatCa_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_TatCa.Checked == true)
            {
                ck_MaLoaiDG.Checked = false;
                ck_TenLoaiDG.Checked = false;
                keycolumn = "*";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                ck_TatCa.Enabled = false;
            }
            else
            {
                keycolumn = "";
                ck_TatCa.Enabled = true;
            }
        }

        private void btnMaLoaiDG_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_MaLoaiDG.Checked == true)
            {
                UnCheck_ckTatCa();
                keycolumn += "MaLoaiDocGia;";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if(ck_TenLoaiDG.Checked == false)
                {
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("MaLoaiDocGia;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void btnTenLoaiDG_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_TenLoaiDG.Checked == true)
            {
                UnCheck_ckTatCa();
                keycolumn += "TenLoaiDocGia;";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                if (ck_MaLoaiDG.Checked == false)
                {
                    ck_TatCa.Checked = true;
                }
                else
                {
                    keycolumn = keycolumn.Replace("TenLoaiDocGia;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }
        #endregion
        #region Event_Click
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemLoaiDocGia addLDG = new frmThemLoaiDocGia();
            addLDG.ShowDialog();
            btnLamMoi_ItemClick(sender, e);
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bandedGridView1.RowCount > 0)
            {
                UnReadOnly_LDG();
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.DataSource = null;
            bandedGridView1.FindFilterText = "";
            LoadDSLoaiDG();
            ReadOnly_LDG();
            bandedGridView1.Focus();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (!dxErrorProvider1.HasErrors)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu lại thông tin loại độc giả đã thay đổi không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    LOAIDOCGIABUS.Instance.UpdateLoaiDocGia(txbMaLoaiDocGia.Text, txbTenLoaiDocGia.Text);
                    XtraMessageBox.Show("Thay đổi đã lưu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);
                    bandedGridView1.Focus();
                }
            }
            else
            {
                XtraMessageBox.Show("Tên loại độc giả không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTenLoaiDocGia.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ReadOnly_LDG();
            bandedGridView1.Focus();
            txbTenLoaiDocGia.Text = bandedGridView1.GetFocusedRowCellValue(colTenLoaiDocGia).ToString();
        }
        private void bandedGridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (btnLuuLai.Enabled == true)
            {
                txbTenLoaiDocGia.Text = bandedGridView1.GetFocusedRowCellValue(colTenLoaiDocGia).ToString();
            }
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bandedGridView1.RowCount > 0)
            {
                if (gridControl1.IsFocused)
                {
                    try
                    {   if (XtraMessageBox.Show("Bạn có muốn xóa thông tin loại độc giả đã chọn không?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            LOAIDOCGIABUS.Instance.RemoveLoaiDocGia(bandedGridView1.GetFocusedRowCellValue(colMaLoaiDocGia).ToString());
                            btnLamMoi_ItemClick(sender, e);
                        }
                        else bandedGridView1.Focus();
                    }
                    catch
                    {
                        XtraMessageBox.Show("Không thể xóa loại độc giả này!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn loại chọn độc giả muốn xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion
        #region Event_Changed
        private void bandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            if(bandedGridView1.RowCount > 0)
            {
                txbMaLoaiDocGia.Text = bandedGridView1.GetFocusedRowCellValue(colMaLoaiDocGia).ToString();
                txbTenLoaiDocGia.Text = bandedGridView1.GetFocusedRowCellValue(colTenLoaiDocGia).ToString();
            }
            else
            {
                txbMaLoaiDocGia.Text = "";
                txbTenLoaiDocGia.Text = "";
                ReadOnly_LDG();
                dxErrorProvider1.SetError(txbTenLoaiDocGia, null);
            }
        }
        private void txbTenLoaiDocGia_EditValueChanged(object sender, EventArgs e)
        {
            if (btnLuuLai.Enabled)
            {
                HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbTenLoaiDocGia, HelpGUI.KiemTraDieuKien.isTen(txbTenLoaiDocGia.Text), "Tên loại độc giả không hợp lệ!");
            }
            else
            {
                dxErrorProvider1.SetError(txbTenLoaiDocGia, null);
            }
        }
        #endregion
        
    }
}