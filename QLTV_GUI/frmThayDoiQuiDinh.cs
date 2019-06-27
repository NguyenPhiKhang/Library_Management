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
    public partial class frmThayDoiQuiDinh : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        public frmThayDoiQuiDinh()
        {
            InitializeComponent();
        }
        #endregion
        #region Methods
        //void Binding_QuiDinh()
        //{
        //    seTuoiMin.DataBindings.Add("EditValue", gridControl1.DataSource, "TuoiToiThieu", true, DataSourceUpdateMode.Never);
        //    seTuoiMax.DataBindings.Add("EditValue", gridControl1.DataSource, "TuoiToiDa", true, DataSourceUpdateMode.Never);
        //    seHanThe.DataBindings.Add("EditValue", gridControl1.DataSource, "ThoiHanThe", true, DataSourceUpdateMode.Never);
        //    seKhoangCachXB.DataBindings.Add("EditValue", gridControl1.DataSource, "KhoangCachXB", true, DataSourceUpdateMode.Never);
        //    seTheLoaiMax.DataBindings.Add("EditValue", gridControl1.DataSource, "SoLuongTheLoaiMax", true, DataSourceUpdateMode.Never);
        //    seSachMuonMax.DataBindings.Add("EditValue", gridControl1.DataSource, "SoSachMuonMax", true, DataSourceUpdateMode.Never);
        //    seNgayMuonMax.DataBindings.Add("EditValue", gridControl1.DataSource, "SoNgayMuonMax", true, DataSourceUpdateMode.Never);
        //    seTienPhat.DataBindings.Add("EditValue", gridControl1.DataSource, "TPTraTreMotNgay", true, DataSourceUpdateMode.Never);
        //}
        bool Check_Changed()
        {
            if (Convert.ToInt32(seTuoiMax.EditValue) == Convert.ToInt32(layoutView1.GetFocusedRowCellValue(colTuoiMax)) &&
                Convert.ToInt32(seTuoiMin.EditValue )== Convert.ToInt32(layoutView1.GetFocusedRowCellValue(colTuoiMin)) &&
                Convert.ToInt32(seHanThe.EditValue) == Convert.ToInt32(layoutView1.GetFocusedRowCellValue(colHanThe)) &&
                Convert.ToInt32(seKhoangCachXB.EditValue) == Convert.ToInt32(layoutView1.GetFocusedRowCellValue(colKhoangCachXB)) &&
                Convert.ToInt32(seTheLoaiMax.EditValue) == Convert.ToInt32(layoutView1.GetFocusedRowCellValue(colTheLoaiMax)) &&
                Convert.ToInt32(seNgayMuonMax.EditValue) == Convert.ToInt32(layoutView1.GetFocusedRowCellValue(colNgayMuonMax)) &&
                Convert.ToInt32(seSachMuonMax.EditValue) == Convert.ToInt32(layoutView1.GetFocusedRowCellValue(colSachMuonMax)) &&
                Convert.ToInt32(seTienPhat.EditValue) == Convert.ToInt32(layoutView1.GetFocusedRowCellValue(colTienPhatTre))&&
                Convert.ToInt32(se_SLtacgia.EditValue) == Convert.ToInt32(layoutView1.GetFocusedRowCellValue(colSoLuongTG))
                )
            {
                return false;
            }
            else return true;
        }
        void check_btnLuu()
        {
            if (Check_Changed())
                btnLuu.Enabled = true;
            else btnLuu.Enabled = false;
        }
        bool LuuThongTin()
        {
            if (XtraMessageBox.Show("Bạn có muốn lưu thay đổi?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                THAMSOBUS.Instance.UpdateQuiDinh(Convert.ToInt32(seTuoiMin.EditValue), Convert.ToInt32(seTuoiMax.EditValue), Convert.ToInt32(seHanThe.EditValue),
                    Convert.ToInt32(seKhoangCachXB.EditValue), Convert.ToInt32(seTheLoaiMax.EditValue),
                    Convert.ToInt32(seNgayMuonMax.EditValue), Convert.ToInt32(seSachMuonMax.EditValue), Convert.ToInt32(seTienPhat.EditValue), Convert.ToInt32(se_SLtacgia.EditValue));
                return true;
            }
            return false;
        }
        void declare_editvalue_se()
        {
            seTuoiMax.EditValue = layoutView1.GetFocusedRowCellValue(colTuoiMax);
            seTuoiMin.EditValue = layoutView1.GetFocusedRowCellValue(colTuoiMin);
            seHanThe.EditValue = layoutView1.GetFocusedRowCellValue(colHanThe);
            seKhoangCachXB.EditValue = layoutView1.GetFocusedRowCellValue(colKhoangCachXB);
            seTheLoaiMax.EditValue = layoutView1.GetFocusedRowCellValue(colTheLoaiMax);
            seNgayMuonMax.EditValue = layoutView1.GetFocusedRowCellValue(colNgayMuonMax);
            seSachMuonMax.EditValue = layoutView1.GetFocusedRowCellValue(colSachMuonMax);
            seTienPhat.EditValue = layoutView1.GetFocusedRowCellValue(colTienPhatTre);
            se_SLtacgia.EditValue = layoutView1.GetFocusedRowCellValue(colSoLuongTG);
        }
        #endregion
        #region Event_Load
        private void frmThayDoiQuiDinh_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = THAMSOBUS.Instance.GetDSQuiDinh().ToList();
            declare_editvalue_se();
            layoutView1.Focus();
        }
        #endregion
        #region Event_Closed
        private void frmThayDoiQuiDinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Check_Changed())
            {
                LuuThongTin();
            }
        }
        #endregion
        #region Event_Click
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (LuuThongTin())
            {
                XtraMessageBox.Show("Thay đổi đã lưu thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = THAMSOBUS.Instance.GetDSQuiDinh().ToList();
                declare_editvalue_se();
                layoutView1.Focus();
                btnHuy1_Click(sender, e);
                btnHuy2_Click(sender, e);
                btnHuy3_Click(sender, e);
            }
        }
        private void btnSua1_Click(object sender, EventArgs e)
        {
            btnSua1.Visible = false;
            btnHuy1.Visible = true;
            seTuoiMax.ReadOnly = false;
            seTuoiMin.ReadOnly = false;
            seHanThe.ReadOnly = false;
        }

        private void btnHuy1_Click(object sender, EventArgs e)
        {
            btnSua1.Visible = true;
            btnHuy1.Visible = false;
            seTuoiMax.ReadOnly = true;
            seTuoiMin.ReadOnly = true;
            seHanThe.ReadOnly = true;
            declare_editvalue_se();
        }
        private void btnSua2_Click(object sender, EventArgs e)
        {
            btnSua2.Visible = false;
            btnHuy2.Visible = true;
            se_SLtacgia.ReadOnly = false;
            seKhoangCachXB.ReadOnly = false;
            seTheLoaiMax.ReadOnly = false;
        }

        private void btnHuy2_Click(object sender, EventArgs e)
        {
            btnSua2.Visible = true;
            btnHuy2.Visible = false;
            se_SLtacgia.ReadOnly = true;
            seKhoangCachXB.ReadOnly = true;
            seTheLoaiMax.ReadOnly = true;
            declare_editvalue_se();
        }

        private void btnSua3_Click(object sender, EventArgs e)
        {
            btnSua3.Visible = false;
            btnHuy3.Visible = true;
            seSachMuonMax.ReadOnly = false;
            seNgayMuonMax.ReadOnly = false;
            seTienPhat.ReadOnly = false;
        }
        private void btnHuy3_Click(object sender, EventArgs e)
        {
            btnSua3.Visible = true;
            btnHuy3.Visible = false;
            seSachMuonMax.ReadOnly = true;
            seNgayMuonMax.ReadOnly = true;
            seTienPhat.ReadOnly = true;
            declare_editvalue_se();
        }
        #endregion
        #region EditValue_Changed
        private void seTuoiMin_EditValueChanged(object sender, EventArgs e)
        {
            check_btnLuu();
        }

        private void seTuoiMax_EditValueChanged(object sender, EventArgs e)
        {
            check_btnLuu();
        }

        private void seHanThe_EditValueChanged(object sender, EventArgs e)
        {
            check_btnLuu();
        }

        private void seKhoangCachXB_EditValueChanged(object sender, EventArgs e)
        {
            check_btnLuu();
        }

        private void seTheLoaiMax_EditValueChanged(object sender, EventArgs e)
        {
            check_btnLuu();
        }

        private void seNgayMuonMax_EditValueChanged(object sender, EventArgs e)
        {
            check_btnLuu();
        }

        private void seTienPhat_EditValueChanged(object sender, EventArgs e)
        {
            check_btnLuu();
        }

        private void seSachMuonMax_EditValueChanged(object sender, EventArgs e)
        {
            check_btnLuu();
        }
        private void se_SLtacgia_EditValueChanged(object sender, EventArgs e)
        {
            check_btnLuu();
        }
        #endregion
    }
}