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
        int _index = 0;
        string keycolumn = "";

        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemTheLoai addTheLoai = new frmThemTheLoai();
            addTheLoai.ShowDialog();
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
            lo_btnLuu.ContentVisible = false;
            lo_btnHuy.ContentVisible = false;

            //gridControl1.DataSource = QLTV_BUS.THELOAIBUS.Instance.GetListTheLoai();
        }

        void ReadOnly_SuaThongTin()
        {
            lo_btnLuu.ContentVisible = false;
            lo_btnHuy.ContentVisible = false;
            txbTenTheLoai.ReadOnly = true;
            txbMaTheLoai.ReadOnly = true;
            btnSua.ItemAppearance.Normal.Reset();
        }

        void UnReadOnly_SuaThongTin()
        {
            lo_btnLuu.ContentVisible = true;
            lo_btnHuy.ContentVisible = true;
            txbTenTheLoai.ReadOnly = false;
            txbMaTheLoai.ReadOnly = true;
            btnSua.ItemAppearance.Normal.BackColor = Color.Silver;
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

        //void LoadDataSourceTL(string IdMaTL = "")
        //{
        //    gluedMaTheLoai.Properties.DataSource = QLTV_BUS.THELOAIBUS.Instance.GetListTheLoai(IdMaTL);
        //    gluedMaTheLoai.Properties.DisplayMember = "MaTheLoai";
        //    gluedMaTheLoai.Properties.ValueMember = "MaTheLoai";
        //}

        //private void btnLuuLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{

        //}

        private void btnLamLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.Focus();
            ReadOnly_SuaThongTin();
            LoadTheLoaiInfo();
            _index = 0;
        }

        private void ck_TatCa_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_TatCa.Checked == true)
            {
                //gridView1.OptionsFind.FindFilterColumns = "dgfdgd";
                ck_MaTheLoai.Checked = false;
                ck_TenTheLoai.Checked = false;
                bandedGridView1.OptionsFind.FindFilterColumns = "*";
                Show_FindGrid();
                keycolumn = "*";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                keycolumn = "";
                Hide_FindGrid();
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
                Kiemtra_TatCa_Check();
                Show_FindGrid();
                keycolumn += "MaTheLoai";
                bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;


            }
            else
            {
                if (ck_TenTheLoai.Checked == false)
                {
                    Hide_FindGrid();
                    keycolumn = "";
                }
                else
                {
                    keycolumn = keycolumn.Replace("MaTheLoai;", "");
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;
                }
            }
        }

        private void ck_TenTheLoai_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_TenTheLoai.Checked == true)
            {
                if (ck_TenTheLoai.Checked == true)
                {
                    Kiemtra_TatCa_Check();
                    Show_FindGrid();
                    keycolumn += "TenTheLoai";
                    bandedGridView1.OptionsFind.FindFilterColumns = keycolumn;


                }
                else
                {
                    if (ck_TenTheLoai.Checked == false)
                    {
                        Hide_FindGrid();
                        keycolumn = "";
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
                    string IdTL = bandedGridView1.GetFocusedRowCellValue(colMaTheLoai).ToString();
                    QLTV_BUS.THELOAIBUS.Instance.UpdateInfoTheloai(txbMaTheLoai.Text, txbTenTheLoai.Text);
                    ReadOnly_SuaThongTin();
                    XtraMessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamLai_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);
                    gridControl1.Focus();

                } }
            else
            {
                XtraMessageBox.Show("Không hợp lệ!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            UnReadOnly_SuaThongTin();
            gridControl1.Focus();
        }

        private void txbTenTheLoai_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbTenTheLoai, HelpGUI.KiemTraDieuKien.isTen(txbTenTheLoai.Text.Trim()), "Tên không hợp lệ!");
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
   
