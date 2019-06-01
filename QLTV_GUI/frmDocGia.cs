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
        string keycolumn = "";
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            LoadDocGiaInfo();
            Binding_DocGia();
            LoadDataSourceLDG(bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString());
            lo_btnLuu.ContentVisible = false;
            lo_btnHuy.ContentVisible = false;
            btnReset.Enabled = false;
            gridControl.Focus();
        }
        #region Methods
        void LoadDocGiaInfo()
        {
            gridControl.DataSource = null;
            List<TTDOCGIADTO> list = QLTV_BUS.TTDOCGIABUS.Instance.GetListDocGiaInfo();
            ListBDDocGia.DataSource = list.ToList();
            gridControl.DataSource = ListBDDocGia;
        }
        void Binding_DocGia()
        {
            try
            {
                txbMaDocGia.DataBindings.Add("Text", ListBDDocGia, "MaDocGia");
                txbHoTen.DataBindings.Add("Text", ListBDDocGia, "HoTen", true, DataSourceUpdateMode.Never);
                dateNgaySinh.DataBindings.Add("EditValue", ListBDDocGia, "NgaySinh", true, DataSourceUpdateMode.Never);
                txbDiaChi.DataBindings.Add("Text", ListBDDocGia, "DiaChi",true, DataSourceUpdateMode.Never);
                txbEmail.DataBindings.Add("Text", ListBDDocGia, "Email", true, DataSourceUpdateMode.Never);
                txbUserName.DataBindings.Add("Text", ListBDDocGia, "IDUser");
                txbPassword.DataBindings.Add("Text", ListBDDocGia, "PasswordUser",true, DataSourceUpdateMode.Never);
                gluedLoaiDocGia.DataBindings.Add("EditValue", ListBDDocGia, "MaLoaiDocGia", true, DataSourceUpdateMode.Never);
                dateNgayLapThe.DataBindings.Add("EditValue", ListBDDocGia, "NgayLapThe", true, DataSourceUpdateMode.OnValidation);
                dateNgayHetHan.DataBindings.Add("EditValue", ListBDDocGia, "NgayHetHan", true, DataSourceUpdateMode.OnPropertyChanged);
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
        void Kiemtra_TatCa_Check()
        {
            if (ck_TatCa.Checked == true)
                ck_TatCa.Checked = false;
        }
        //Hiện thanh tìm kiếm trên grid
        private void Show_FindGrid()
        {
            if (!bandedGridView.IsFindPanelVisible)
                bandedGridView.ShowFindPanel();
        }
        //Ẩn Thanh tìm kiếm
        private void Hide_FindGrid()
        {
            if (bandedGridView.IsFindPanelVisible)
                bandedGridView.HideFindPanel();
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
                bandedGridView.OptionsFind.FindFilterColumns = "*";
                Show_FindGrid();
                keycolumn = "*";
                bandedGridView.OptionsFind.FindFilterColumns = keycolumn;
            }
            else
            {
                keycolumn = "";
                Hide_FindGrid();
            }
        }

        private void ck_MaDocGia_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ck_MaDocGia.Checked == true)
            {
                Kiemtra_TatCa_Check();
                Show_FindGrid();
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
                    Hide_FindGrid();
                    keycolumn = "";
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
                Kiemtra_TatCa_Check();
                Show_FindGrid();
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
                    Hide_FindGrid();
                    keycolumn = "";
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
                Kiemtra_TatCa_Check();
                Show_FindGrid();
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
                    Hide_FindGrid();
                    keycolumn = "";
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
                Kiemtra_TatCa_Check();
                Show_FindGrid();
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
                    Hide_FindGrid();
                    keycolumn = "";
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
                Kiemtra_TatCa_Check();
                Show_FindGrid();
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
                    Hide_FindGrid();
                    keycolumn = "";
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
                Kiemtra_TatCa_Check();
                Show_FindGrid();
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
                    Hide_FindGrid();
                    keycolumn = "";
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
                Kiemtra_TatCa_Check();
                Show_FindGrid();
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
                    Hide_FindGrid();
                    keycolumn = "";
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
                Kiemtra_TatCa_Check();
                Show_FindGrid();
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
                    Hide_FindGrid();
                    keycolumn = "";
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
                Kiemtra_TatCa_Check();
                Show_FindGrid();
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
                    Hide_FindGrid();
                    keycolumn = "";
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
            UnReadOnly_SuaThongTin();
            gridControl.Focus();
            LoadDataSourceLDG();
            
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl.Focus();
            ReadOnly_SuaThongTin();
            LoadDocGiaInfo();
            LoadDataSourceLDG(bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString());
            _index = 0;
        }
        //private void bandedGridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        //{
        //    int a = bandedGridView.GetFocusedDataSourceRowIndex();
        //    if (_index == a)
        //    {
        //        txbHoTen.Text = bandedGridView.GetFocusedRowCellValue(colHoTen).ToString();
        //        dateNgaySinh.EditValue = bandedGridView.GetFocusedRowCellValue(colNgaySinh);
        //        txbDiaChi.Text = bandedGridView.GetFocusedRowCellValue(colDiaChi).ToString();
        //        txbEmail.Text = bandedGridView.GetFocusedRowCellValue(colEmail).ToString();
        //        txbPassword.Text = bandedGridView.GetFocusedRowCellValue(colPassword).ToString();
        //    }
        //    else _index = a;

        //    if (lo_btnHuy.ContentVisible == false)
        //    {
        //        LoadDataSourceLDG(bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString());
        //    }
        //    else
        //    {
        //        LoadDataSourceLDG();
        //    }
        //}
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
            if (XtraMessageBox.Show("Bạn có muốn lưu thông tin độc giả đã sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string IdDG = bandedGridView.GetFocusedRowCellValue(colMaDocGia).ToString();
                QLTV_BUS.DOCGIABUS.Instance.UpdateInfoDocGia(IdDG, txbHoTen.Text, txbDiaChi.Text, (DateTime)dateNgaySinh.EditValue, txbEmail.Text, gluedLoaiDocGia.EditValue.ToString());
                QLTV_BUS.USERBUS.Instance.UpdateInfoUser(txbUserName.Text, txbPassword.Text);
                ReadOnly_SuaThongTin();
                btnLamMoi_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);
                gridControl.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ReadOnly_SuaThongTin();
            gridControl.Focus();
            LoadDataSourceLDG(bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString());
            txbHoTen.Text = bandedGridView.GetFocusedRowCellValue(colHoTen).ToString();
            dateNgaySinh.EditValue = bandedGridView.GetFocusedRowCellValue(colNgaySinh);
            txbEmail.Text = bandedGridView.GetFocusedRowCellValue(colEmail).ToString();
            txbDiaChi.Text = bandedGridView.GetFocusedRowCellValue(colDiaChi).ToString();
            txbPassword.Text = bandedGridView.GetFocusedRowCellValue(colPassword).ToString();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txbPassword.Text = "1";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
        #endregion
        #region Envent_Changed
        private void bandedGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int a = bandedGridView.GetFocusedDataSourceRowIndex();
            if (_index == a)
            {
                txbHoTen.Text = bandedGridView.GetFocusedRowCellValue(colHoTen).ToString();
                dateNgaySinh.EditValue = bandedGridView.GetFocusedRowCellValue(colNgaySinh);
                txbDiaChi.Text = bandedGridView.GetFocusedRowCellValue(colDiaChi).ToString();
                txbEmail.Text = bandedGridView.GetFocusedRowCellValue(colEmail).ToString();
                txbPassword.Text = bandedGridView.GetFocusedRowCellValue(colPassword).ToString();
            }
            else _index = a;

            if (lo_btnHuy.ContentVisible == false)
            {
                LoadDataSourceLDG(bandedGridView.GetFocusedRowCellValue(colLoaiDocGia).ToString());
            }
            else
            {
                LoadDataSourceLDG();
            }
        }
        #endregion
    }
}