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

namespace QLTV_GUI
{
    public partial class frmThemLoaiDocGia : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        string idLast;
        public frmThemLoaiDocGia()
        {
            InitializeComponent();
        }
        #endregion
        #region Event_Load
        private void frmThemLoaiDocGia_Load(object sender, EventArgs e)
        {
            try
            {
                LOAIDOCGIA ldg = LOAIDOCGIABUS.Instance.GetLoaiDocGia()[LOAIDOCGIABUS.Instance.GetLoaiDocGia().Count - 1];
                idLast = ldg.MaLoaiDocGia.ToString();
            }
            catch
            {
                idLast = "";
            }
            txbMaLoaiDocGia.Text = HelpGUI.AutoIncreaseID.Load_AutoIncreaseID("LDG", idLast, 3);
        }
        #endregion
        #region Event_Click
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!dxErrorProvider1.HasErrors && txbTenLoaiDocGia.EditValue != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn thêm thông tin loại độc giả?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    LOAIDOCGIABUS.Instance.AddLoaiDocGia(txbMaLoaiDocGia.Text.ToString(), txbTenLoaiDocGia.Text.ToString());
                    Close();
                }
            }
            else
            {
                XtraMessageBox.Show("Tên loại độc giả không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTenLoaiDocGia.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Event_Changed
        private void txbTenLoaiDocGia_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbTenLoaiDocGia, HelpGUI.KiemTraDieuKien.isTen(txbTenLoaiDocGia.Text), "Tên loại độc giả không hợp lệ!");
        }
        #endregion
    }
}