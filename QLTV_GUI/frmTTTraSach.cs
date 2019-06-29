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

namespace QLTV_GUI
{
    public partial class frmTTTraSach : DevExpress.XtraEditors.XtraForm
    {
        List<CHITIETPHIEUTRADTO> listpt = new List<CHITIETPHIEUTRADTO>();
        List<CHITIETPHIEUMUONDTO> listpm = new List<CHITIETPHIEUMUONDTO>();
        public frmTTTraSach()
        {
            InitializeComponent();
        }
        private void frmTTTraSach_Load(object sender, EventArgs e)
        {
            Update_TinhTrangMuon();
            LoadData();
        }
        void LoadData()
        {
            listpt = CHITIETPHIEUTRABUS.Instance.GetListPhieuTra();
            List<CHITIETPHIEUTRADTO> list = new List<CHITIETPHIEUTRADTO>(listpt);
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i].NgayTra == list[j].NgayTra && list[i].MaDocGia == list[j].MaDocGia)
                    {
                        list.Remove(list[j]);
                        j--;
                    }
                }
            }
            gridControl1.DataSource = list;

            glued_MaPhieuMuon.Properties.DataSource = listpt.Select(x => new { x.MaPhieuMS, x.MaDocGia, x.HoTen }).Distinct().ToList();
            glued_MaPhieuMuon.Properties.DisplayMember = "MaPhieuMS";
            glued_MaPhieuMuon.Properties.ValueMember = "MaPhieuMS";
        }
        void Update_TinhTrangMuon()
        {
            listpm = CHITIETPHIEUMUONBUS.Instance.GetListPhieuMuon().Where(x => x.TinhTrangMuon == "Còn hạn").ToList();
            foreach (var item in listpm)
            {
                if (DateTime.Compare(item.HanTra, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)) < 0)
                {
                    CTPHIEUMUONBUS.Instance.UpdateTinhTrangMuon(item.MaPhieuMS, item.MaSach, "Quá hạn");
                }
            }
        }
        void Fomart_New()
        {
            txb_TenDocGia.EditValue = null;
            txb_NgayTra.EditValue = null;
            txt_TienPhatKiNay.EditValue = null;
            txt_TongNo.EditValue = null;
            glued_MaPhieuMuon.Properties.DataSource = null;
            glued_MaPhieuMuon.EditValue = null;
            gridControl1.DataSource = null;
            gridControl2.DataSource = null;
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemTraSach addTraSach = new frmThemTraSach();
            addTraSach.ShowDialog();
            btnLamMoi_ItemClick(sender, e);
        }

        private void bandedGridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            e.IsEmpty = false;
        }

        private void bandedGridView1_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "SachTraView";
        }

        private void bandedGridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void bandedGridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            BandedGridView bandgv = sender as BandedGridView;
            CHITIETPHIEUTRADTO ct = bandgv.GetRow(e.RowHandle) as CHITIETPHIEUTRADTO;
            if (ct != null)
                e.ChildList = listpt.Where(p => p.NgayTra == ct.NgayTra && p.MaDocGia == ct.MaDocGia).Select(p => p).ToList();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fomart_New();
            Update_TinhTrangMuon();
            LoadData();
        }

        private void glued_MaPhieuMuon_EditValueChanged(object sender, EventArgs e)
        {
            decimal TienPhatKiNay= 0;
            try

            { List<CHITIETPHIEUTRADTO> list = new List<CHITIETPHIEUTRADTO>();
                list= listpt.Where(x => x.MaPhieuMS == glued_MaPhieuMuon.EditValue.ToString()).ToList();
                txb_NgayTra.EditValue= listpt.Where(x => x.MaPhieuMS == glued_MaPhieuMuon.EditValue.ToString()).Select(x => x.NgayTra).ToList()[0];
                gridControl2.DataSource = listpt.Where(x => x.MaPhieuMS == glued_MaPhieuMuon.EditValue.ToString()).ToList();
                txb_TenDocGia.EditValue = listpt.Where(x => x.MaPhieuMS == glued_MaPhieuMuon.EditValue.ToString()).Select(x => x.HoTen).Distinct().ToList()[0];
                for(int i=0;i< list.Count;i++)
                {
                    TienPhatKiNay += Convert.ToDecimal(list[i].TienPhat);
                }
                txt_TienPhatKiNay.EditValue = TienPhatKiNay;
                List<DOCGIA> listdg = DOCGIABUS.Instance.GetInfoDocGia();
               string madg= listpt.Where(x => x.MaPhieuMS == glued_MaPhieuMuon.EditValue.ToString()).Select(x => x).ToList()[0].MaDocGia;
                txt_TongNo.EditValue = listdg.Where(x => x.MaDocGia == madg).Select(x=>x).ToList()[0].TongNo;



            }

            catch { txb_NgayTra.EditValue = null;txb_TenDocGia.EditValue = null; }
        }

        private void bandedGridView1_GroupLevelStyle(object sender, DevExpress.XtraGrid.Views.Grid.GroupLevelStyleEventArgs e)
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
    }
}