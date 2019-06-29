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
using DevExpress.XtraEditors.Repository;

namespace QLTV_GUI
{
    public partial class frmThemTraSach : DevExpress.XtraEditors.XtraForm
    {
        List<CHITIETPHIEUMUONDTO> listtra = new List<CHITIETPHIEUMUONDTO>();
        List<CHITIETPHIEUMUONDTO> listpm = new List<CHITIETPHIEUMUONDTO>();
        List<CHITIETPHIEUMUONDTO> listpmchuatra = new List<CHITIETPHIEUMUONDTO>();
        
       
        public frmThemTraSach()
        {
            InitializeComponent();
        }

        private void frmThemTraSach_Load(object sender, EventArgs e)
        {
            listpm = CHITIETPHIEUMUONBUS.Instance.GetListPhieuMuon();
            gridControl2.DataSource = new BindingList <CHITIETPHIEUMUONDTO>(listtra);
            glued_MaDocGia.Properties.DataSource = listpm.Where(x => x.TinhTrangMuon == "Còn hạn" || x.TinhTrangMuon == "Quá hạn").Select(x =>  new {x.MaDocGia, x.HoTen }).Distinct().ToList();
            glued_MaDocGia.Properties.ValueMember = "MaDocGia";
            glued_MaDocGia.Properties.DisplayMember = "MaDocGia";
            dateEdit1.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        

        private void glued_MaDocGia_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listpmchuatra = listpm.Where(x =>( x.TinhTrangMuon == "Còn hạn" || x.TinhTrangMuon == "Quá hạn") && x.MaDocGia == glued_MaDocGia.EditValue.ToString()).Select(x => x).ToList();
                listtra.Clear();
                gridControl2.DataSource = null;
                gridControl1.DataSource = null;
                gridControl1.DataSource = listpmchuatra;
                txb_TenDocGia.EditValue = listpm.Where(x => x.MaDocGia == glued_MaDocGia.EditValue.ToString()).Select(x => x.HoTen).Distinct().ToList()[0];

            }
            catch
            {
                txb_TenDocGia.EditValue = null;
            }
        }
        List<CHITIETPHIEUTRADTO> list1 = new List<CHITIETPHIEUTRADTO>();
        private void btn_next_Click(object sender, EventArgs e)
        { string GhiChu="";decimal TienPhat = 0;
           
            if (bandedGridView0.RowCount >0 && bandedGridView0.FocusedRowHandle >=0)
            { //bandedGridView1.Focus();
                listtra.Add(listpmchuatra[bandedGridView0.FocusedRowHandle]);
                //TimeSpan interval_SoNgayTre = DateTime.Now.Subtract(listtra[0].HanTra);
                
                //if (interval_SoNgayTre.Days>0)
                //{
                //    GhiChu += "Quá Hạn " + interval_SoNgayTre.Days + " Ngày";
                //    TienPhat = (decimal)interval_SoNgayTre.Days * THAMSOBUS.Instance.GetDSQuiDinh()[0].TPTraTreMotNgay;

                //}

                list1 = new List<CHITIETPHIEUTRADTO>();
               
                var list2 = listtra.Select(x => new { x.MaPhieuMS, NgayTra = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),SoNgayMuon=0, TienPhat = 0, TinhTrangTraSach = "Bình thường", x.MaSach, x.TenSach, x.HanTra,x.MaTinhTrang,x.TinhTrangMuon,x.MaDocGia , x.HoTen, x.NgayMuon, GhiChu = "" }).ToList();
                foreach (var item in list2)
                {
                    TienPhat = 0;GhiChu = "";
                    TimeSpan interval_SoNgayTre = DateTime.Now.Subtract(item.HanTra);
                    if (interval_SoNgayTre.Days > 0)
                    {
                        GhiChu += "Quá Hạn " + interval_SoNgayTre.Days + " Ngày";
                        TienPhat = (decimal)interval_SoNgayTre.Days * THAMSOBUS.Instance.GetDSQuiDinh()[0].TPTraTreMotNgay;

                    }

                    CHITIETPHIEUTRADTO ct = new CHITIETPHIEUTRADTO
                    {
                        MaPhieuMS = item.MaPhieuMS,
                        NgayTra = item.NgayTra,
                        SoNgayMuon = DateTime.Now.Subtract(item.NgayMuon).Days,
                        TienPhat = TienPhat,
                        TinhTrangTraSach = item.TinhTrangTraSach,
                        MaSach = item.MaSach,
                        TenSach = item.TenSach,
                        MaTinhTrang = item.MaTinhTrang,
                        HanTra = item.HanTra,
                        TinhTrangMuon = item.TinhTrangMuon,
                        MaDocGia = item.MaDocGia,
                        HoTen = item.HoTen,
                        NgayMuon = item.NgayMuon,
                        GhiChu = GhiChu
                    };
                    list1.Add(ct);
                }

                gridControl2.DataSource = null;
                gridControl2.DataSource = list1;
                
                bandedGridView0.DeleteRow(bandedGridView0.FocusedRowHandle);

                bandedGridView1.MoveLast();


                

                   
            }
            else XtraMessageBox.Show("Vui Lòng Chọn Thông Tin muốn trả");
           
            
        }

        private void btn_nextall_Click(object sender, EventArgs e)
        {
            if (bandedGridView0.RowCount >0)
            {  while (bandedGridView0.RowCount > 0)
                    
                    btn_next_Click(sender, e as EventArgs);
            }

        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            if(bandedGridView1.RowCount>0 && bandedGridView1.FocusedRowHandle>=0)
            {
                
                listpmchuatra.Add(listtra[bandedGridView1.FocusedRowHandle]);
                
                gridControl1.DataSource = null;
                gridControl1.DataSource = listpmchuatra;
                int i = bandedGridView1.FocusedRowHandle;
                bandedGridView1.DeleteRow(bandedGridView1.FocusedRowHandle);
                listtra.Remove(listtra[i]);
                bandedGridView0.MoveLast();
            }
            else XtraMessageBox.Show("Vui Lòng Chọn Thông Tin Trả!");
        }

        private void btn_preAll_Click(object sender, EventArgs e)
        {
            if (bandedGridView1.RowCount > 0)
            {   while (bandedGridView1.RowCount > 0)
                    btn_pre_Click(sender, e as EventArgs);
            }
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        { bandedGridView1.MoveFirst();
            decimal TienPhat = 0;
            foreach (CHITIETPHIEUTRADTO item in list1)
            {
                TienPhat = 0;
                if (DateTime.Now.Subtract(item.HanTra).Days > 0)
                {
                    TienPhat = (decimal)DateTime.Now.Subtract(item.HanTra).Days * THAMSOBUS.Instance.GetDSQuiDinh()[0].TPTraTreMotNgay;
                }
               
                CHITIETPHIEUTRABUS.Instance.AddPhieuTra(item.MaPhieuMS, item.MaSach, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), DateTime.Now.Subtract(item.NgayMuon).Days, (decimal)DateTime.Now.Subtract(item.HanTra).Days * THAMSOBUS.Instance.GetDSQuiDinh()[0].TPTraTreMotNgay, item.TinhTrangTraSach);
                DOCGIABUS.Instance.UpdateTongNoDG(item.MaDocGia, TienPhat);
                CTPHIEUMUONBUS.Instance.UpdateTinhTrangMuon(item.MaPhieuMS, item.MaSach, "Đã trả");
                if (item.TinhTrangTraSach == "Hỏng")
                { SACHBUS.Instance.UpdateTinhtrangSach(item.MaSach, "TT003"); }
                if (item.TinhTrangTraSach == "Mất")
                { SACHBUS.Instance.UpdateTinhtrangSach(item.MaSach, "TT004"); }
                if (item.TinhTrangTraSach == "Bình thường")
                { SACHBUS.Instance.UpdateTinhtrangSach(item.MaSach, "TT001"); }


            }
            listtra.Clear();
            listtra = new List<CHITIETPHIEUMUONDTO>();
                //Load
                listpm = CHITIETPHIEUMUONBUS.Instance.GetListPhieuMuon();
                gridControl2.DataSource = new BindingList<CHITIETPHIEUMUONDTO>(listtra);
                glued_MaDocGia.Properties.DataSource = listpm.Where(x => x.TinhTrangMuon == "Còn hạn" || x.TinhTrangMuon == "Quá hạn").Select(x => new { x.MaDocGia, x.HoTen }).Distinct().ToList();
                glued_MaDocGia.Properties.ValueMember = "MaDocGia";
                glued_MaDocGia.Properties.DisplayMember = "MaDocGia";
                dateEdit1.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            
        }

       

        private void bandedGridView1_RowCountChanged_1(object sender, EventArgs e)
        {
            if(bandedGridView1.RowCount>0)
            {
                btn_pre.Enabled = true;
                btn_preAll.Enabled = true;
                btn_Apply.Enabled = true;
            }
            else
            {
                btn_pre.Enabled = false ;
                btn_preAll.Enabled = false;
                btn_Apply.Enabled = false;
            }
        }

        private void bandedGridView0_RowCountChanged(object sender, EventArgs e)
        {
          if(  bandedGridView0.RowCount >0)
            {
                btn_next.Enabled = true;
                btn_nextall.Enabled = true;
            }
            else
            {
                btn_next.Enabled = false;
                btn_nextall.Enabled = false;
            }
        }

        private void repositoryItemComboBox1_EditValueChanged(object sender, EventArgs e)
        {
            ComboBoxEdit editor = sender as ComboBoxEdit;
            if (editor != null)
            {
                string value = editor.SelectedItem.ToString();
                if (value == "Hỏng" || value == "Mất")
                {
                    var list = SACHBUS.Instance.GetListSachInfo();
                    decimal trigia = list.Where(x => x.MaSach == bandedGridView1.GetFocusedRowCellValue(col_grid2_MaSach).ToString()).Select(x => x.TriGia).ToList()[0];
                    bandedGridView1.SetFocusedRowCellValue(col_grid2_TienPhat, trigia * 3);
                }
                else
                {
                    if (DateTime.Now.Subtract(listtra[bandedGridView1.FocusedRowHandle].HanTra).Days > 0)
                    {
                        bandedGridView1.SetFocusedRowCellValue(col_grid2_TienPhat, DateTime.Now.Subtract(listtra[bandedGridView1.FocusedRowHandle].HanTra).Days * THAMSOBUS.Instance.GetDSQuiDinh()[0].TPTraTreMotNgay);
                    }
                    else bandedGridView1.SetFocusedRowCellValue(col_grid2_TienPhat, 0);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}