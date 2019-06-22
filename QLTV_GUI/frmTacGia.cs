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
        BindingSource listbdtacgia = new BindingSource();
        int _index = 0;
        
        string keycolunm = "";

        public frmTacGia()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemTacGia addTacGia = new frmThemTacGia();
            addTacGia.ShowDialog();
        }

        void Binding_TacGia()
        {
            try
            {
                txbMaTacGia.DataBindings.Add("Text", listbdtacgia, "MaTacGia", true, DataSourceUpdateMode.Never);
                txbTenTacGia.DataBindings.Add("Text", listbdtacgia, "TenTacGia",true, DataSourceUpdateMode.Never);
            }
            catch
            { }
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            LoadTacGiaInfo();
            Binding_TacGia();
            lo_btnHuy.ContentVisible = false;
            lo_btnLuu.ContentVisible = false;
        }

        void ReadOnly_SuaThongTin()
        {
            lo_btnLuu.ContentVisible = false;
            lo_btnHuy.ContentVisible = false;
            txbMaTacGia.ReadOnly = true;
            txbTenTacGia.ReadOnly = true;
            btnSua.ItemAppearance.Normal.Reset();
        }

        void UnReadOnly_SuaThongTin()
        {
            lo_btnLuu.ContentVisible = true;
            lo_btnHuy.ContentVisible = true;
            txbMaTacGia.ReadOnly = true;
            txbTenTacGia.ReadOnly = false;
            btnSua.ItemAppearance.Normal.BackColor = Color.Silver;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(!dxErrorProvider1.HasErrors)
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

        private void ck_TatCa_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ck_TatCa.Checked==true)
            {
                ck_MaTacGia.Checked = false;
                ck_TenTacGia.Checked = false;
                bandedGridView1.OptionsFind.FindFilterColumns = "*";
                Show_FindGrid();
                keycolunm = "*";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolunm;
            }
            else
            {
                keycolunm = "";
                Hide_FindGrid();
            }
        }

        private void ck_MaTacGia_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ck_MaTacGia.Checked==true)
            {
                if(ck_MaTacGia.Checked==true)
                {
                    KiemTra_Tatca_Check();
                    Show_FindGrid();
                    keycolunm += "MaTacGia";
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolunm;
                }
                else
                if (ck_MaTacGia.Checked == false)
                {
                    Hide_FindGrid();
                    keycolunm = "";
                }
                else
                {
                    keycolunm = keycolunm.Replace("MaTacGia;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolunm;
                }
            }
        }

        private void ck_TenTacGia_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_TenTacGia.Checked == true)
            {
                if (ck_TenTacGia.Checked == true)
                {
                    KiemTra_Tatca_Check();
                    Show_FindGrid();
                    keycolunm += "TenTacGia";
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolunm;
                }
                else
                if (ck_TenTacGia.Checked == false)
                {
                    Hide_FindGrid();
                    keycolunm = "";
                }
                else
                {
                    keycolunm = keycolunm.Replace("TenTacGia;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolunm;
                }
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.Focus();
            ReadOnly_SuaThongTin();
            LoadTacGiaInfo();
            _index = 0;

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnReadOnly_SuaThongTin();
            gridControl1.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ReadOnly_SuaThongTin();
            gridControl1.Focus();
            txbMaTacGia.Text = bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString();
            txbTenTacGia.Text = bandedGridView1.GetFocusedRowCellValue(colTenTacGia).ToString();

        }

        private void txbMaTacGia_EditValueChanged(object sender, EventArgs e)
        {
            if(lo_btnLuu.ContentVisible)
            {
                
            }
        }

        private void txbTenTacGia_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbTenTacGia, HelpGUI.KiemTraDieuKien.isTen(txbTenTacGia.Text.Trim()), "Tên không hợp lệ!");
        }
    }
}