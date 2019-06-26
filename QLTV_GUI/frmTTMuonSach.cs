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
using QLTV_DTO;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace QLTV_GUI
{
    public partial class frmTTMuonSach : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        List<CHITIETPHIEUMUONDTO> listpm = new List<CHITIETPHIEUMUONDTO>();
        List<CHITIETPHIEUMUONDTO> list = new List<CHITIETPHIEUMUONDTO>();
        public frmTTMuonSach()
        {
            InitializeComponent();
        }
        #endregion
        #region Methods
        void LoadData()
        {
            listpm = CHITIETPHIEUMUONBUS.Instance.GetListPhieuMuon();
            list = new List<CHITIETPHIEUMUONDTO>(listpm.Where(x => x.TinhTrangMuon == "Còn hạn"|| x.TinhTrangMuon == "Quá hạn").Select(x => x).ToList());
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].NgayMuon == list[j].NgayMuon && list[i].MaDocGia == list[j].MaDocGia)
                    {
                        list.Remove(list[j]);
                        j--;
                    }
                }
            }
            gridControl1.DataSource = list;
            glued_MaPhieu.Properties.DataSource = listpm.Select(x => new { x.MaPhieuMS, x.MaDocGia, x.HoTen }).Distinct().ToList();
            glued_MaPhieu.Properties.DisplayMember = "MaPhieuMS";
            glued_MaPhieu.Properties.ValueMember = "MaPhieuMS";
        }
        void Update_TinhTrangMuon()
        {
            listpm = CHITIETPHIEUMUONBUS.Instance.GetListPhieuMuon().Where(x => x.TinhTrangMuon == "Còn hạn").ToList();
            foreach (var item in listpm)
            {
                if(DateTime.Compare(item.HanTra, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day))<0)
                {
                    CTPHIEUMUONBUS.Instance.UpdateTinhTrangMuon(item.MaPhieuMS, item.MaSach, "Quá hạn");
                }
            }
        }
        void Fomart_New()
        {
            txbNgayMuon.EditValue = null;
            txbTenDocGia.EditValue = null;
            glued_MaPhieu.Properties.DataSource = null;
            glued_MaPhieu.EditValue = null;
            gridControl1.DataSource = null;
            gridControl2.DataSource = null;
        }
        #endregion
        #region Event_Load
        private void frmTTMuonSach_Load(object sender, EventArgs e)
        {
            Update_TinhTrangMuon();
            LoadData();
            gridControl1.Focus();
        }
        #endregion
        #region Event_Click
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemPhieuMuon addPhieuMuon = new frmThemPhieuMuon();
            addPhieuMuon.ShowDialog();
            btnLamMoi_ItemClick(sender, e);
        }
        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fomart_New();
            Update_TinhTrangMuon();
            LoadData();
        }
        #endregion
        #region Event_Changed
        private void lued_MaPhieu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txbNgayMuon.EditValue = listpm.Where(x => x.MaPhieuMS == glued_MaPhieu.EditValue.ToString()).Select(x => x.NgayMuon).ToList()[0];
                gridControl2.DataSource = listpm.Where(x => x.MaPhieuMS == glued_MaPhieu.EditValue.ToString()).ToList();
                txbTenDocGia.EditValue = listpm.Where(x => x.MaPhieuMS == glued_MaPhieu.EditValue.ToString()).Select(x => x.HoTen).Distinct().ToList()[0];

            }
            catch
            {
                txbNgayMuon.EditValue = null;
                txbTenDocGia.EditValue = null;
            }
        }
        #endregion
        #region Event
        private void bandedGridView2_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            e.IsEmpty = false;
        }

        private void bandedGridView2_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            BandedGridView bandgv = sender as BandedGridView;
            CHITIETPHIEUMUONDTO ct = bandgv.GetRow(e.RowHandle) as CHITIETPHIEUMUONDTO;
            if (ct != null)
                e.ChildList = listpm.Where(p => (p.NgayMuon == ct.NgayMuon && p.MaDocGia == ct.MaDocGia) && (p.TinhTrangMuon == "Còn hạn" || p.TinhTrangMuon == "Quá hạn")).Select(p => p).ToList();
        }

        private void bandedGridView2_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "SachMuonView";
        }

        private void bandedGridView2_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void bandedGridView2_GroupLevelStyle(object sender, DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs e)
        {
            if (e.Level == 0)
            {
                e.LevelAppearance.ForeColor = Color.WhiteSmoke;
                e.LevelAppearance.BackColor = Color.FromArgb(134, 95, 197);
            }
            else
            {
                e.LevelAppearance.ForeColor = Color.FromArgb(50, 50, 50);
                e.LevelAppearance.BackColor = Color.Salmon;
            }
        }
        #endregion
    }
}
