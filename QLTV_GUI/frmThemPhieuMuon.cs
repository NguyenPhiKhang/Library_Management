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

namespace QLTV_GUI
{
    public partial class frmThemPhieuMuon : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        public frmThemPhieuMuon()
        {
            InitializeComponent();
        }
        List<CHITIETPHIEUMUONDTO> listpm = new List<CHITIETPHIEUMUONDTO>();
        List<CHITIETSACHDTO> listctsach = new List<CHITIETSACHDTO>();
        List<DOCGIA> listdg = new List<DOCGIA>();
        List<string> dstinhtrang = new List<string>();
        List<CHITIETSACHDTO> dssachmuon = new List<CHITIETSACHDTO>();
        int sosachmuontrongngay = 0;
        string IdLast;
        #endregion
        #region Methods
        void LoadData()
        {
            listpm = CHITIETPHIEUMUONBUS.Instance.GetListPhieuMuon().ToList();
            try
            {
                CHITIETPHIEUMUONDTO a = CHITIETPHIEUMUONBUS.Instance.GetListPhieuMuon()[CHITIETPHIEUMUONBUS.Instance.GetListPhieuMuon().Count - 1];
                IdLast = a.MaPhieuMS.ToString();
            }
            catch { IdLast = ""; }
            txbMaPhieu.EditValue = HelpGUI.AutoIncreaseID.Load_AutoIncreaseID("PM", IdLast, 6);
            listctsach = CHITIETSACHBUS.Instance.GetListCTSach().Where(x => x.MaTinhTrang == "TT001").Select(x => x).ToList();
            glued_MaSach.Properties.DataSource = listctsach;
            glued_MaSach.Properties.DisplayMember = "MaSach";
            glued_MaSach.Properties.ValueMember = "MaSach";
            listdg = DOCGIABUS.Instance.GetInfoDocGia().ToList();
            glued_MaDocGia.Properties.DataSource = listdg;
            glued_MaDocGia.Properties.DisplayMember = "MaDocGia";
            glued_MaDocGia.Properties.ValueMember = "MaDocGia";
            txbNgayMuon.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
        bool KTSachQuaHan()
        {
            dstinhtrang = listpm.Where(x => x.MaDocGia == glued_MaDocGia.EditValue.ToString()).Select(x => x.TinhTrangMuon).Distinct().ToList();
            foreach (var item in dstinhtrang)
            {
                if (item == "Quá hạn")
                    return true;//có sách mượn quá hạn
            }
            return false;//không có sách mượn quá hạn
        }
        void KiemTraHanThe()
        {
            if (DateTime.Compare(Convert.ToDateTime(txbHanThe.EditValue), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)) < 0)
            {
                dxErrorProvider1.SetError(txbHanThe, "Thẻ độc giả đã hết hạn! Vui lòng gia hạn thẻ!");
                btnNhap.Enabled = false;
            }
            else
            {
                dxErrorProvider1.SetError(txbHanThe, null);
                btnNhap.Enabled = true;
            }
        }
        void KiemtraDGMSQuaHan()
        {
            if (KTSachQuaHan())
            {
                dxErrorProvider1.SetError(txbTenDocGia, "Độc giả có mượn sách quá hạn! Vui lòng trả sách nếu muốn mượn thêm sách!");
                btnNhap.Enabled = false;
            }
            else
            {
                dxErrorProvider1.SetError(txbTenDocGia, null);
                btnNhap.Enabled = true;
            }
        }
        bool KiemTraSoSachMuon(int songay, int sosachtoida)
        {
            sosachmuontrongngay = 0;
            for (int i = songay - 1; i > 0; i--)
            {
                DateTime ngaymuon = DateTime.Now.AddDays(-i);
                sosachmuontrongngay += listpm.Where(x => x.MaDocGia == glued_MaDocGia.EditValue.ToString()
                && DateTime.Compare(x.NgayMuon, new DateTime(ngaymuon.Year, ngaymuon.Month, ngaymuon.Day)) == 0 && x.TinhTrangMuon == "Còn hạn").Select(x => x).Count();
            }
            sosachmuontrongngay += gridView2.RowCount;
            if (sosachmuontrongngay > sosachtoida)
                return false;//không thỏa mãn số sách mượn
            return true;// thỏa mãn số sách mượn
        }
        void LuuCTPHieuMuon()
        {
            foreach (var item in dssachmuon)
            {
                CTPHIEUMUONBUS.Instance.AddCTPhieuMuon(txbMaPhieu.EditValue.ToString(), item.MaSach, Convert.ToDateTime(Convert.ToDateTime(txbNgayMuon.EditValue).AddMonths(Convert.ToInt32(seHanTra.EditValue))), "Còn hạn");
                SACHBUS.Instance.UpdateTinhtrangSach(item.MaSach, "TT002");
            }
        }
        bool KiemTraSachMuonTrung()
        {
            foreach (var item in dssachmuon)
            {
                if (item.MaSach == glued_MaSach.EditValue.ToString())
                    return true;//sách được thêm vào trùng
            }
            return false;
        }
        #endregion
        #region Event_Load
        private void frmThemPhieuMuon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
        #region Event_Click
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if(!dxErrorProvider1.HasErrors&&txbTenDocGia.EditValue!=null&&gridView2.RowCount>0)
            {
                if (Convert.ToInt32(seHanTra.EditValue) == 0)
                { XtraMessageBox.Show("Vui lòng chọn hạn trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop); }
                else
                {
                    if (XtraMessageBox.Show("Bạn đồng ý cho mượn sách", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        int songaymuonmax = THAMSOBUS.Instance.GetDSQuiDinh().ToList()[0].SoNgayMuonMax;
                        int sosachmuonmax = THAMSOBUS.Instance.GetDSQuiDinh().ToList()[0].SoSachMuonMax;
                        if (KiemTraSoSachMuon(songaymuonmax, sosachmuonmax))
                        {
                            PHIEUMUONSACHBUS.Instance.AddPhieuMuon(txbMaPhieu.EditValue.ToString(), glued_MaDocGia.EditValue.ToString(), Convert.ToDateTime(txbNgayMuon.EditValue));
                            LuuCTPHieuMuon();
                            this.Close();
                        }
                        else
                        {
                            XtraMessageBox.Show($"Bạn mượn tổng cộng {sosachmuontrongngay} sách trong {songaymuonmax} ngày\n\rKhông thỏa qui định: có {sosachmuonmax} sách mượn tối đa trong {songaymuonmax} ngày!",
                                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            gridControl1.Focus();
                        }
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Có lỗi xảy ra! Vui lòng kiểm tra lại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                glued_MaDocGia.Focus();
            }
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (!KiemTraSachMuonTrung())
            {
                gridControl1.DataSource = null;
                dssachmuon.Add(listctsach.Where(x => x.MaSach == glued_MaSach.EditValue.ToString()).ToList()[0]);
                gridControl1.DataSource = dssachmuon;
            }
            else XtraMessageBox.Show("Sách này đã được thêm vào mượn!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            gridView2.DeleteRow(gridView2.FocusedRowHandle);
        }
        #endregion
        #region Event_Changed
        private void glued_MaSach_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txbTenSach.EditValue = listctsach.Where(x => x.MaSach == glued_MaSach.EditValue.ToString()).Select(x => x.TenSach).ToList()[0];
            }
            catch
            {
                txbTenSach.EditValue = null;
            }
        }

        private void glued_MaDocGia_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                seHanTra.ReadOnly = false;
                txbTenDocGia.EditValue = listdg.Where(x => x.MaDocGia == glued_MaDocGia.EditValue.ToString()).Select(x => x.HoTen).ToList()[0];
                txbHanThe.EditValue = listdg.Where(x => x.MaDocGia == glued_MaDocGia.EditValue.ToString()).Select(x => x.NgayHetHan).ToList()[0];
                KiemTraHanThe();
                KiemtraDGMSQuaHan();
            }
            catch
            {
                dxErrorProvider1.SetError(txbHanThe, null);
                dxErrorProvider1.SetError(txbTenDocGia, null);
                seHanTra.ReadOnly = true;
                txbTenDocGia.EditValue = null;
                txbHanThe.EditValue = null;
            }
        }
        private void seHanTra_EditValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(Convert.ToDateTime(txbNgayMuon.EditValue).AddMonths(Convert.ToInt32(seHanTra.EditValue)), Convert.ToDateTime(txbHanThe.EditValue)) > 0)
            {
                HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, seHanTra, false, "Hạn trả lớn hơn hạn thẻ độc giả");
            }
            else
            {
                dxErrorProvider1.SetError(seHanTra, null);
            }
        }
        #endregion
    }
}