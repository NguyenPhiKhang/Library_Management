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
using DevExpress.XtraReports.UI;
using QLTV_DTO;
using QLTV_BUS;

namespace QLTV_GUI
{
    public partial class frmBCTKTraTre : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        public frmBCTKTraTre()
        {
            InitializeComponent();
        }
        List<CHITIETPHIEUTRADTO> listpt = new List<CHITIETPHIEUTRADTO>();
        string IdLast = "";
        string MaPhieuBC;
        #endregion
        #region Methods
        void SaveData()
        {
            BCTKTRATREBUS.Instance.AddBCTKTraTre(MaPhieuBC, Convert.ToDateTime(cbbNgayBC.EditValue));
            var a = listpt.Where(x => x.GhiChu != null && DateTime.Compare(Convert.ToDateTime(x.NgayTra), Convert.ToDateTime(cbbNgayBC.EditValue)) == 0)
            .Select(x => new { MaBCTKTraTre = MaPhieuBC, x.MaPhieuMS, x.MaSach, x.TenSach, x.NgayMuon, x.NgayTra, x.HanTra, SoNgayTraTre = (Convert.ToDateTime(x.NgayTra) - Convert.ToDateTime(x.HanTra)).Days }).ToList();
            foreach (var item in a)
            {
                CTBCTKTRATREBUS.Instance.AddCTBCTKTraTre(item.MaBCTKTraTre, item.MaPhieuMS, item.MaSach, item.SoNgayTraTre);
            }
        }
        string doingay(string x)
        {
            string ngay = "";
            string[] a = x.Split('/');
            string temp;
            temp = a[0];
            a[0] = a[1];
            a[1] = temp;
            ngay = a[0] + "/" + a[1] + "/" + a[2];
            return ngay;
        }
        string Thaydoingay(string x)
        {
            string ngay = "";
            string[] a = x.Split(' ');
            ngay = doingay(a[0]);
            return ngay;
        }
        void Load_DataSource()
        {
            var a = listpt.Where(x => x.GhiChu != null && DateTime.Compare(Convert.ToDateTime(x.NgayTra), Convert.ToDateTime(cbbNgayBC.EditValue)) == 0)
            .Select(x => new { MaBCTKTraTre = MaPhieuBC, x.MaPhieuMS, x.MaSach, x.TenSach, NgayMuon = Thaydoingay(x.NgayMuon.ToString()), NgayTra = Thaydoingay(x.NgayTra.ToString()), x.HanTra, SoNgayTraTre = (Convert.ToDateTime(x.NgayTra) - Convert.ToDateTime(x.HanTra)).Days }).ToList();
            gridControl1.DataSource = a;
        }
        #endregion
        #region Event_Load
        private void frmBCTKTraTre_Load(object sender, EventArgs e)
        {
            cbbNgayBC.Properties.Items.Clear();
            listpt = CHITIETPHIEUTRABUS.Instance.GetListPhieuTra();
            cbbNgayBC.Properties.Items.AddRange(listpt.Where(x => x.GhiChu != null).Select(x => x.NgayTra).Distinct().ToList());
            try
            {
                BCTKTRATRE bctt = BCTKTRATREBUS.Instance.GetListBCTKTraTre().ToList()[BCTKTRATREBUS.Instance.GetListBCTKTraTre().Count - 1];
                IdLast = bctt.MaBCTKTraTre;
            }
            catch { IdLast = ""; }
            MaPhieuBC = HelpGUI.AutoIncreaseID.Load_AutoIncreaseID("BCTT", IdLast, 5);
        }
        #endregion
        #region Event_Click
        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn tạo báo cáo không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SaveData();
                ReportBCTKTraTre rp = new ReportBCTKTraTre();
                rp.DataSource = gridControl1.DataSource;
                rp.ShowPreviewDialog();
                frmBCTKTraTre_Load(sender, e);
            }

        }
        #endregion
        #region Event_Changed
        private void cbbNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNgayBC.EditValue != null)
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
    }
}