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
using DevExpress.XtraReports.UI;

namespace QLTV_GUI
{
    public partial class frmBCTKSachMuonTL : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        public frmBCTKSachMuonTL()
        {
            InitializeComponent();
        }
        List<CHITIETPHIEUMUONDTO> listpm = new List<CHITIETPHIEUMUONDTO>();
        string IdLast = "";
        string MaPhieuBC;
        #endregion
        #region Methods
        void Load_DataSource()
        {
            int b = listpm.Where(x => Convert.ToDateTime(x.NgayMuon).Month == Convert.ToInt32(cbbThang.SelectedItem)
               && Convert.ToDateTime(x.NgayMuon).Year == Convert.ToInt32(cbbNam.SelectedItem)).Count();
            var a = listpm.Where(x => Convert.ToDateTime(x.NgayMuon).Month == Convert.ToInt32(cbbThang.SelectedItem)
            && Convert.ToDateTime(x.NgayMuon).Year == Convert.ToInt32(cbbNam.SelectedItem)).GroupBy(x => x.TenTheLoai)
            .Select(p => new { MaBCTKMuonSach = MaPhieuBC, Thang = Convert.ToInt32(cbbThang.EditValue), Nam = Convert.ToInt32(cbbNam.EditValue), TenTheLoai = p.Key, SoLuotMuon = p.Count(), TiLe = Convert.ToSingle((float)p.Count() / b) }).ToList();
            gridControl1.DataSource = a;
        }
        #endregion
        #region Event_Load
        private void frmBCTKSachMuonTL_Load(object sender, EventArgs e)
        {
            cbbNam.Properties.Items.Clear();
            var list = Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1).ToList();
            cbbNam.Properties.Items.AddRange(list);
            listpm = CHITIETPHIEUMUONBUS.Instance.GetListPhieuMuon();
            try
            {
                BCTKMUONSACH bcms = BCTKMUONSACHBUS.Instance.GetListBCTKmuon().ToList()[BCTKMUONSACHBUS.Instance.GetListBCTKmuon().Count - 1];
                IdLast = bcms.MaBCTKMuonSach;
            }
            catch { IdLast = ""; }
            MaPhieuBC = HelpGUI.AutoIncreaseID.Load_AutoIncreaseID("BCMS", IdLast, 5);
        }
        #endregion
        #region Event_Changed
        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNam.EditValue != null)
            {
                Load_DataSource();
            }
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbThang.EditValue != null)
            {
                Load_DataSource();
            }
        }
        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {           
            if (gridView1.RowCount > 0)
                lo_btnTaoBaoCao.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else lo_btnTaoBaoCao.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }
        #endregion
        #region Event_Press
        private void cbbThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelpGUI.KiemTraDieuKien.NhapSo(e);
        }

        private void cbbNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelpGUI.KiemTraDieuKien.NhapSo(e);
        }
        #endregion
        #region Event_Click
        void SaveData()
        {
                BCTKMUONSACHBUS.Instance.AddBaoCaoTKMuonSach(MaPhieuBC, new DateTime(Convert.ToInt32(cbbNam.EditValue), Convert.ToInt32(cbbThang.EditValue), DateTime.DaysInMonth(Convert.ToInt32(cbbNam.EditValue), Convert.ToInt32(cbbThang.EditValue))),
                Convert.ToInt32(gridView1.Columns["TiLe"].SummaryItem.SummaryValue));
            int b = listpm.Where(x => Convert.ToDateTime(x.NgayMuon).Month == Convert.ToInt32(cbbThang.SelectedItem)
               && Convert.ToDateTime(x.NgayMuon).Year == Convert.ToInt32(cbbNam.SelectedItem)).Count();
            var a = listpm.Where(x => Convert.ToDateTime(x.NgayMuon).Month == Convert.ToInt32(cbbThang.SelectedItem)
            && Convert.ToDateTime(x.NgayMuon).Year == Convert.ToInt32(cbbNam.SelectedItem)).GroupBy(x => x.TenTheLoai)
            .Select(p => new { MaBCTKMuonSach = MaPhieuBC, Thang = Convert.ToInt32(cbbThang.EditValue), Nam = Convert.ToInt32(cbbNam.EditValue), TenTheLoai = p.Key, SoLuotMuon = p.Count(), TiLe = Convert.ToSingle((float)p.Count() / b) }).ToList();

            foreach (var item in a)
            {
                CTBCTKMUONSACHBUS.Instance.AddCTBCMuonSach(MaPhieuBC, THELOAIBUS.Instance.GetListTheLoai().Where(x => x.TenTheLoai == item.TenTheLoai).Select(x=>x.MaTheLoai).ToList()[0].ToString(), item.SoLuotMuon, Convert.ToDouble(item.TiLe));
            }
        }
        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn tạo báo cáo không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SaveData();
                ReportMuonTL rp = new ReportMuonTL();
                rp.DataSource = gridControl1.DataSource;
                rp.ShowPreviewDialog();
                frmBCTKSachMuonTL_Load(sender, e);
            }
        }
        #endregion
    }
}