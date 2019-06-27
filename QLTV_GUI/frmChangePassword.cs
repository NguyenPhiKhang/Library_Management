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

namespace QLTV_GUI
{
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        string currentpass = "";
        public frmChangePassword()
        {
            InitializeComponent();
        }
        public string PassWord { get => currentpass; set => value = currentpass; }
        public frmChangePassword(string pass):this()
        {
            currentpass = pass;
        }
        #endregion
        #region Methods
        #endregion
        #region Event_Changed
        private void txbnewpass_EditValueChanged(object sender, EventArgs e)
        {
            HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbnewpass, HelpGUI.KiemTraDieuKien.isPassword(txbnewpass.Text), "Password không hợp lệ!\r\nPhải có 8 ký tự trở lên");
        }

        private void txbRenewpass_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider1.SetIconAlignment(txbRenewpass, ErrorIconAlignment.BottomRight);
            if (txbRenewpass.Text != txbnewpass.Text)
            {
                dxErrorProvider1.SetError(txbRenewpass, "Nhập lại password không đúng!");
            }
            else
            {
                dxErrorProvider1.SetError(txbRenewpass, null);
                if (dxErrorProvider1.HasErrors)
                    dxErrorProvider1.SetError(txbRenewpass, "Nhập lại password không hợp lệ!");
            }
        }
        private void txbPass_EditValueChanged(object sender, EventArgs e)
        {
            dxErrorProvider1.SetIconAlignment(txbPass, ErrorIconAlignment.BottomRight);
            if (txbPass.Text != currentpass)
            {
                dxErrorProvider1.SetError(txbPass, "Mật khẩu hiện tại không đúng!");
                txbnewpass.Enabled = false;
                txbRenewpass.Enabled = false;
            }
            else
            {
                dxErrorProvider1.SetError(txbPass, null);
                txbnewpass.Enabled = true;
                txbRenewpass.Enabled = true;
            }
        }
        #endregion
        #region Event_Click
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnthaydoi_Click(object sender, EventArgs e)
        {
            if(!dxErrorProvider1.HasErrors&&!string.IsNullOrEmpty(txbPass.Text)&& !string.IsNullOrEmpty(txbnewpass.Text)&&!string.IsNullOrEmpty(txbRenewpass.Text))
            {
                if(XtraMessageBox.Show("Bạn có muốn thay đổi mật khẩu?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    currentpass = txbnewpass.Text;
                    Close();
                }
            }
            else
            {
                if (!dxErrorProvider1.HasErrors)
                    XtraMessageBox.Show("Không được để trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else XtraMessageBox.Show("Nhập không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}