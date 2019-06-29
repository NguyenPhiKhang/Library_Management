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
    public partial class frmDSPhieuPhat : DevExpress.XtraEditors.XtraForm
    {
        string IdLast;
        List<DOCGIA> listtnDG = new List<DOCGIA>();
        BindingSource listTongNoDG = new BindingSource();
        void LoadTongNoDG ()
        {
            //listtnDG.Clear();
            //listtnDG = QLTV_BUS.DOCGIABUS.Instance.GetInfoDocGia();
            //listTongNoDG.DataSource = listtnDG.ToList();
            
            //QLTV_BUS.DOCGIABUS.Instance.UpdateTongNoDG(glued_DocGia.EditValue.ToString(), Convert.ToDecimal(txb_TongNo.EditValue));
        }
        public frmDSPhieuPhat()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            btnThem.Enabled = false;
            layoutControl1.Visible = true;
            listtnDG = QLTV_BUS.DOCGIABUS.Instance.GetInfoDocGia().Where(x=>x.TongNo>0).ToList();
            glued_DocGia.Properties.DataSource = listtnDG;
            glued_DocGia.Properties.ValueMember = "MaDocGia";
            glued_DocGia.Properties.DisplayMember = "HoTen";
            txb_TongNo.ReadOnly = true;
            txb_ConLai.ReadOnly = true;
            btn_OK.Enabled = false;
        }

        private void frmDSPhieuPhat_Load(object sender, EventArgs e)
        {

            //QLTV_BUS.DOCGIABUS.Instance.UpdateTongNoDG(glued_DocGia.EditValue.ToString(), Convert.ToDecimal(txb_TongNo));
            LoadTongNoDG();
            LoadDSPP();
            dateNgayThu.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            gridControl1.Focus();
            try
            {
                PHIEUTHUTIENPHAT pttp = DSPHIEUPHATBUS.Instance.GetDSPhieuPhat()[DSPHIEUPHATBUS.Instance.GetDSPhieuPhat().Count - 1];
                IdLast = pttp.MaPhieuThuTP;
            }
            catch { IdLast = ""; }
            txb_MaPhieuThu.Text = HelpGUI.AutoIncreaseID.Load_AutoIncreaseID("PT", IdLast, 6);
        }

        void LoadDSPP()
        {
            layoutControl1.Visible = false;
            btnThem.Enabled = true;
            List <PHIEUTHUTIENPHAT> list = QLTV_BUS.DSPHIEUPHATBUS.Instance.GetDSPhieuPhat();
            gridControl1.DataSource = list.ToList();
            try
            {
                PHIEUTHUTIENPHAT pttp = DSPHIEUPHATBUS.Instance.GetDSPhieuPhat()[DSPHIEUPHATBUS.Instance.GetDSPhieuPhat().Count - 1];
                IdLast = pttp.MaPhieuThuTP;
            }
            catch { IdLast = ""; }
            txb_MaPhieuThu.Text = HelpGUI.AutoIncreaseID.Load_AutoIncreaseID("PT", IdLast, 6);
            glued_DocGia.Properties.DataSource = null;
            glued_DocGia.EditValue = null;
            btn_OK.Enabled = false;
            txb_ConLai.EditValue = null;
            txb_TongNo.EditValue = null;
            txb_SoTienThu.EditValue = 500;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            if(!dxErrorProvider1.HasErrors)
            {
                if (XtraMessageBox.Show("Bạn có chắc chắn thêm phiếu thu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    QLTV_BUS.DSPHIEUPHATBUS.Instance.AddPhieuPhat(txb_MaPhieuThu.Text, glued_DocGia.EditValue.ToString(), Convert.ToDecimal(txb_TongNo.EditValue), Convert.ToDecimal(txb_SoTienThu.EditValue), (DateTime)dateNgayThu.EditValue, Convert.ToDecimal(txb_ConLai.EditValue));
                    XtraMessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QLTV_BUS.DOCGIABUS.Instance.UpdateTongNoDG(glued_DocGia.EditValue.ToString(), -Convert.ToDecimal(txb_SoTienThu.EditValue));
                    btnLamMoi_ItemClick(sender, e as DevExpress.XtraBars.ItemClickEventArgs);
                    gridControl1.Focus();
                }
            }
            else
            { XtraMessageBox.Show("Không hợp lệ!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            LoadDSPP();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDSPP();
            gridControl1.Focus();
            //_index = 0;
            //lo_btnOK.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            //lo_btnHuy.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            //lo_PhieuThu.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void btn_Indu_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txb_TongNo.EditValue) == 0)
            {
                XtraMessageBox.Show("Độc giả này không có nợ để thu .Vui lòng chọn độc giả khác hoặc nhấn Hủy để kết thúc!)", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (Convert.ToDecimal(txb_TongNo.EditValue) >= Convert.ToDecimal(txb_SoTienThu.EditValue))
                {
                    txb_ConLai.EditValue = Convert.ToDecimal(txb_TongNo.EditValue) - Convert.ToDecimal(txb_SoTienThu.EditValue);
                    btn_OK.Enabled = true;
                }
                else
                {
                    XtraMessageBox.Show("\t            Vui lòng nhập lại số tiền thu!!!\n (Số tiền thu không được vượt quá số tiền nợ)", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txb_SoTienThu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txb_TongNo_EditValueChanged(object sender, EventArgs e)
        {

        }

        
        void Binding_TongNoDG()
        {
            try
            {
                txb_TongNo.DataBindings.Add("Text", listTongNoDG, "TongNo", true, DataSourceUpdateMode.Never);
                glued_DocGia.DataBindings.Add("EditValue", listTongNoDG, "DocGia", true, DataSourceUpdateMode.Never);
            }
            catch { }
        }
            

        private void glued_DocGia_EditValueChanged(object sender, EventArgs e)
        {
            if (glued_DocGia.EditValue != null)
            {
                txb_TongNo.EditValue = listtnDG.Where(x => x.MaDocGia == glued_DocGia.EditValue.ToString()).Select(x => x.TongNo).ToList()[0];
            }

            //QLTV_BUS.DOCGIABUS.Instance.UpdateTongNoDG(glued_DocGia.EditValue.ToString(), Convert.ToDecimal(txb_TongNo));
        }

        private void bandedGridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        //private void btn_Sua_Click(object sender, EventArgs e)
        //{
        //    int flag = 0;
        //    txb_TongNo.ReadOnly = false;
        //    flag = Convert.ToInt32(txb_TongNo.EditValue);
        //    if (Convert.ToInt32(txb_TongNo.EditValue)<flag)
        //    {
        //        XtraMessageBox.Show("Không hợp lệ!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


    }


}