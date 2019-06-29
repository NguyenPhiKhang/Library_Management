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
    public partial class frmTheLoai : DevExpress.XtraEditors.XtraForm
    {
        BindingSource listbdtheloai = new BindingSource();
        int SoTLmax;
        string keycolumn = "";

        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SoTLmax = THAMSOBUS.Instance.GetDSQuiDinh()[0].SoLuongTheLoaiMax;
            if (bandedGridView1.RowCount < SoTLmax)
            {
                frmThemTheLoai addTheLoai = new frmThemTheLoai();
                addTheLoai.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Đã vượt quá số lượng thể loại cho phép!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Binding_theLoai()
        {
            try
            {
                txbMaTheLoai.DataBindings.Add("Text", listbdtheloai, "MaTheLoai", true, DataSourceUpdateMode.Never);
                txbTenTheLoai.DataBindings.Add("Text", listbdtheloai, "TenTheLoai", true, DataSourceUpdateMode.Never);
            }
            catch
            {

            }

        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            LoadTheLoaiInfo();
            Binding_theLoai();
            Show_FindGrid();
            lo_btnLuu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            //gridControl1.DataSource = QLTV_BUS.THELOAIBUS.Instance.GetListTheLoai();
        }

        void ReadOnly_SuaThongTin()
        {
            lo_btnLuu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            txbTenTheLoai.ReadOnly = true;
            txbMaTheLoai.ReadOnly = true;
            btnSua.Enabled = true;
        }

        void UnReadOnly_SuaThongTin()
        {
            lo_btnLuu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            txbTenTheLoai.ReadOnly = false;
            txbMaTheLoai.ReadOnly = true;
            
        }

        void KiemTra_Tatca_Check()
        {
            if (ck_TatCa.Checked == true)
                ck_TatCa.Checked = false;
        }

        //Hiện thanh tìm kiếm trên grid
        private void Show_FindGrid()
        {
            if (!bandedGridView1.IsFindPanelVisible)
                bandedGridView1.ShowFindPanel();
        }
        //Ẩn Thanh tìm kiếm
        private void Hide_FindGrid()
        {
            if (bandedGridView1.IsFindPanelVisible)
                bandedGridView1.HideFindPanel();
        }

        void LoadTheLoaiInfo()
        {
            List<THELOAI> list = QLTV_BUS.THELOAIBUS.Instance.GetListTheLoai();
            listbdtheloai.DataSource = list.ToList();
            gridControl1.DataSource = listbdtheloai;
        }
        

        private void btnLamLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.DataSource = null;
            bandedGridView1.FindFilterText = "";
            ReadOnly_SuaThongTin();
            LoadTheLoaiInfo();
            
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
                    ck_MaTheLoai.Checked == false &&
                    ck_TatCa.Checked == false
                    )
                return true;
            return false;
        }

        private void ck_TatCa_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_TatCa.Checked == true)
            {
                ck_MaTheLoai.Checked = false;
                ck_TenTheLoai.Checked = false;
                bandedGridView1.OptionsFind.FindFilterColumns = "*";
                //Show_FindGrid();
                keycolumn = "*";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                ck_TatCa.Enabled = false;
            }
            else
            {
                keycolumn = "";
                //Hide_FindGrid();
            }
        }

        void Kiemtra_TatCa_Check()
        {
            if (ck_TatCa.Checked == true)
                ck_TatCa.Checked = false;
        }

        private void ck_MaTheLoai_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_MaTheLoai.Checked == true)
            {
                if (ck_MaTheLoai.Checked == true)
                {
                    Uncheck_ck_TatCa();
                    keycolumn += "MaTheLoai";
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
                else
                {
                    if (KiemTraTatCaUnCheck())
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
        }

        private void ck_TenTheLoai_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_TenTheLoai.Checked == true)
            {
                if (ck_TenTheLoai.Checked == true)
                {
                    Uncheck_ck_TatCa();
                    keycolumn += "TenTheLoai";
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
                else
                {
                    if (KiemTraTatCaUnCheck())
                    {
                        ck_TatCa.Checked = true;
                    }
                    else
                    {
                        keycolumn = keycolumn.Replace("TenTheLoai;", "");
                        bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                    }
                }
            }

            //private void bandedGridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
            //{

            //}
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!dxErrorProvider1.HasErrors)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu thông tin thể loại đã sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string IdTG = bandedGridView1.GetFocusedRowCellValue(colMaTheLoai).ToString();
                    QLTV_BUS.TACGIABUS.Instance.UpdateInfoTacgia(txbMaTheLoai.Text, txbTenTheLoai.Text);
                    ReadOnly_SuaThongTin();
                    XtraMessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamLai_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);

                    gridControl1.Focus();

                }
            }
            else
            { XtraMessageBox.Show("Không hợp lệ!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ReadOnly_SuaThongTin();
            gridControl1.Focus();
            txbMaTheLoai.Text = bandedGridView1.GetFocusedRowCellValue(colMaTheLoai).ToString();
            txbTenTheLoai.Text = bandedGridView1.GetFocusedRowCellValue(colTenTheLoai).ToString();

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

        void FormatBD_TheLoai()
        {
            txbTenTheLoai.Text = bandedGridView1.GetFocusedRowCellValue(colTenTheLoai).ToString();
        }

        private void txbTenTheLoai_EditValueChanged(object sender, EventArgs e)
        {
            if (lo_btnLuu.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                //HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbTenTheLoai, HelpGUI.KiemTraDieuKien.isTenSach(txbTenTheLoai.Text.Trim()), "Tên không hợp lệ!");
            }
            else
            {
                dxErrorProvider1.SetError(txbTenTheLoai, null);
            }
        }

        private void bandedGridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (lo_btnHuy.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always)
            {
                txbTenTheLoai.Text = bandedGridView1.GetFocusedRowCellValue(colTenTheLoai).ToString();
            }
        }

        private void bandedGridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (bandedGridView1.RowCount <= 0)
            {
                txbMaTheLoai.Text = "";
                txbTenTheLoai.Text = "";
                dxErrorProvider1.SetError(txbTenTheLoai, null);
                ReadOnly_SuaThongTin();
            }
            else
            {
                bandedGridView1_FocusedRowChanged(sender, e as DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs);
                FormatBD_TheLoai();
            }
        }

        private void bandedGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        //private void bandedgridview1_focusedrowchanged(object sender, devexpress.xtragrid.views.base.focusedrowchangedeventargs e)
        //{
        //    int a = bandedgridview1.getfocuseddatasourcerowindex();
        //    if (_index == a)
        //    {

        //    }
        //}
    }
}
   
