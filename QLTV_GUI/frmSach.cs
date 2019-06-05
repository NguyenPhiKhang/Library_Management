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
        int _index = 0;
        string keycolumn = "";
        BindingSource ListBDSach = new BindingSource();
        public frmSach()
        {
            InitializeComponent();
        
            
            //layoutControlGroup2.Visible = false;
        }
        private void frmSach_Load(object sender, EventArgs e)
        {
            LoadSachInfo();
            Binding_Sach();
            LoadDataSourceLDG(bandedGridView1.GetFocusedRowCellValue(colMatheloai).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTinhTrang).ToString());
            lo_btnLuuLai.ContentVisible = false;
            lo_btnHuy.ContentVisible = false;
            gridControl1.Focus();
        }
        #region Methods

        #endregion
        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemSach themsach = new frmThemSach();
            themsach.ShowDialog();
            btnLamMoi_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);
        }

        void LoadSachInfo()
        {
            List<SACH> list = QLTV_BUS.SACHBUS.Instance.GetListSachInfo();
            //gridControl.DataSource = list.ToList();
            //bindingSource1.DataSource = list.ToList();
            ListBDSach.DataSource = list.ToList();
            gridControl1.DataSource = ListBDSach;
        }
        void LoadDataSourceLDG(string theloai="",string tacgia="",string tinhtrang="")
        {
            var list =QLTV_BUS.THELOAIBUS.Instance.GetTheLoai(theloai);

            glued_TheLoai.Properties.DataSource = list;
            
            glued_TheLoai.Properties.ValueMember = "MaTheLoai";
            glued_TheLoai.Properties.DisplayMember = "TenTheLoai";

            var list2= QLTV_BUS.TACGIABUS.Instance.GetTacGia(tacgia);
            glued_TacGia.Properties.DataSource = list2;
            
            glued_TacGia.Properties.ValueMember = "MaTacGia";
            glued_TacGia.Properties.DisplayMember = "TenTacGia";
            var list3 = QLTV_BUS.TINHTRANGBUS.Instance.GetTinhTrang(tinhtrang);
            glued_TinhTrang.Properties.DataSource = list3;
            
            glued_TinhTrang.Properties.ValueMember = "MaTinhTrang";
            glued_TinhTrang.Properties.DisplayMember = "TenTinhTrang";
        }
        void Binding_Sach()
        {
            try
            {
                txbMaSach.DataBindings.Add("Text", ListBDSach, "MaSach");
                txbTenSach.DataBindings.Add("Text", ListBDSach, "TenSach");
                dateNgayNhap.DataBindings.Add("EditValue", ListBDSach, "NgayNhap", true, DataSourceUpdateMode.OnPropertyChanged);
                dateNamSX.DataBindings.Add("EditValue", ListBDSach, "NamXuatBan", true, DataSourceUpdateMode.OnPropertyChanged);
                glued_TheLoai.DataBindings.Add("EditValue", ListBDSach, "MaTheLoai", true,DataSourceUpdateMode.Never);
                txbNhaSX.DataBindings.Add("Text", ListBDSach, "NhaXuatBan");      
                glued_TacGia.DataBindings.Add("EditValue", ListBDSach,"MaTacGia", true, DataSourceUpdateMode.Never);
                txbTriGia.DataBindings.Add("Text", ListBDSach, "TriGia");

                glued_TinhTrang.DataBindings.Add("EditValue", ListBDSach, "MaTinhTrang", true, DataSourceUpdateMode.Never);

        }
            catch
            {

            }
        }

       

        

        private void bandedGridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int a = bandedGridView1.GetFocusedDataSourceRowIndex();
            if (a != _index)
            {
                
                
                
                _index = a;
            }
            else
            {

                
            }
            if(lo_btnLuuLai.ContentVisible==false)
            {
                LoadDataSourceLDG(bandedGridView1.GetFocusedRowCellValue(colMatheloai).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTinhTrang).ToString());
            }
            else
            {
                LoadDataSourceLDG();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lo_btnLuuLai.ContentVisible = true;
            lo_btnHuy.ContentVisible = true;
            glued_TacGia.Properties.ReadOnly = false;
            glued_TheLoai.Properties.ReadOnly = false;
            glued_TinhTrang.Properties.ReadOnly = false;
            LoadDataSourceLDG();
        }

        private void btn_LuuLai_Click(object sender, EventArgs e)
        {
            QLTV_BUS.SACHBUS.Instance.UpdateInfoSach(txbMaSach.Text, txbTenSach.Text, glued_TheLoai.EditValue.ToString(), (int)Convert.ToInt32(dateNamSX.EditValue), txbNhaSX.Text, glued_TacGia.EditValue.ToString(), (int)Convert.ToInt32(txbTriGia.EditValue), glued_TinhTrang.EditValue.ToString());



            lo_btnLuuLai.ContentVisible = false;
            lo_btnHuy.ContentVisible = false;


            
           
            glued_TacGia.Properties.ReadOnly = true;
            glued_TheLoai.Properties.ReadOnly = true;
            glued_TinhTrang.Properties.ReadOnly = true;
            btnLamMoi_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);
            gridControl1.Focus();

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {


            //Xử lý



            lo_btnLuuLai.ContentVisible = true;
            lo_btnHuy.ContentVisible = true;


            glued_TacGia.Properties.ReadOnly = true;
            glued_TheLoai.Properties.ReadOnly = true;
            glued_TinhTrang.Properties.ReadOnly = true;

            btnLamMoi_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);
            gridControl1.Focus();
            
        }

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

        

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridControl1.IsFocused == true)
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa thông tin độc giả đã chọn không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    QLTV_BUS.SACHBUS.Instance.RemoveInfoSach(bandedGridView1.GetFocusedRowCellValue(colMaSach).ToString());
                    btnLamMoi_ItemClick(sender, e);
                }
                else gridControl1.Focus();
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn thông tin độc giả muốn xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadSachInfo();
           
            LoadDataSourceLDG(bandedGridView1.GetFocusedRowCellValue(colMatheloai).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTacGia).ToString(), bandedGridView1.GetFocusedRowCellValue(colMaTinhTrang).ToString());
            lo_btnLuuLai.ContentVisible = false;
            lo_btnHuy.ContentVisible = false;
            gridControl1.Focus();
        }
    }

}