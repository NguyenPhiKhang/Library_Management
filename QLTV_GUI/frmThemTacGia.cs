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
using DevExpress.XtraEditors.DXErrorProvider;
using System.Text.RegularExpressions;
using QLTV_DTO;

namespace QLTV_GUI
{
    public partial class frmThemTacGia : DevExpress.XtraEditors.XtraForm
    {
        List<TACGIA> listinfoTG = TACGIABUS.Instance.GetListTacGia().ToList();
        string IdLast;
        
        public frmThemTacGia()
        {
            InitializeComponent();
        }

        bool CheckNull()
        {
            if (txbTenTacGia.EditValue == null)
                return true;
            return false;
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            if (!dxErrorProvider1.HasErrors && !CheckNull())
            {
                if (XtraMessageBox.Show("Bạn có muốn thêm tác giả?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    TACGIABUS.Instance.AddInfoTacgia(txbMaTacGia.Text, txbTenTacGia.Text);
                    this.Close();
                }
            }
            else
            { XtraMessageBox.Show("Nhập thông tin bị lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemTacGia_Load(object sender, EventArgs e)
        {
            //txbTenTacGia.DataBindings.Add("Text", txbTenTacGia, "Text");
            try
            {
                TACGIA ttg = TACGIABUS.Instance.GetListTacGia()[TACGIABUS.Instance.GetListTacGia().Count - 1];
                IdLast = ttg.MaTacGia;
            }
            catch { IdLast = ""; }
            txbMaTacGia.Text = HelpGUI.AutoIncreaseID.Load_AutoIncreaseID("TG", IdLast,6);
        }

        private void txbTenTacGia_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbTenTacGia, HelpGUI.KiemTraDieuKien.isTenSach(txbTenTacGia.Text.Trim()), "Không hợp lệ!");
        }
    }
}