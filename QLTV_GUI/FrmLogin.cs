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
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace QLTV_GUI
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        List<ACCOUNT> listaccount = new List<ACCOUNT>();
        string iDUser = "";
        public string IDUser { get => iDUser; set => iDUser = value; }

        public FrmLogin()
        {
            InitializeComponent();
        }
        #endregion
        #region Methods
        private void ReadSettings()
        {
            if (Properties.Settings.Default.remember == "true")
            {
                txbUsername.Text = Properties.Settings.Default.user;
                txbPassword.Text = Properties.Settings.Default.pass;
                ck_remember.Checked = true;
            }
            else
            {
                txbUsername.Text = "";
                txbPassword.Text = "";
                ck_remember.Checked = false;
            }
        }
        private void SaveSettings()
        {
            if (ck_remember.Checked)
            {
                Properties.Settings.Default.user = txbUsername.Text;
                Properties.Settings.Default.pass = txbPassword.Text;
                Properties.Settings.Default.remember = "true";
            }
            else
            {
                Properties.Settings.Default.user = "";
                Properties.Settings.Default.pass = "";
                Properties.Settings.Default.remember = "false";
            }
            Properties.Settings.Default.Save();
        }
        #endregion
        #region Event_Load

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ReadSettings();
        }
        #endregion
        #region Event_Enter_Leave
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            pnUser.BackColor = Color.DodgerBlue;
            if(txbUsername.Text == "Username")
            {
                txbUsername.Text = "";
                txbUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            pnUser.BackColor = Color.Gray;
            if (txbUsername.Text == "")
            {
                txbUsername.Text = "Username";
                txbUsername.ForeColor = Color.DarkGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            pnPass.BackColor = Color.DodgerBlue;
            if (txbPassword.Text == "Password")
            {
                txbPassword.Text = "";
                txbPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            pnPass.BackColor = Color.Gray;
            if (txbPassword.Text == "")
            {
                txbPassword.Text = "Password";
                txbPassword.ForeColor = Color.DarkGray;
            }
        }
        #endregion

        private /*async*/ void btnDangNhap_Click(object sender, EventArgs e)
        {
            SaveSettings();
            if (listaccount.Count == 0)
            {
                IOverlaySplashScreenHandle handle = SplashScreenManager.ShowOverlayForm(pl_GiaoDien);
                listaccount = /*await*/ ACCOUNTBUS.Instance.GetInfoAccount();
                handle.Close();
            }
            for(int i=0;i<listaccount.Count;i++)
            {
                if(txbUsername.Text == listaccount[i].IDAccount && txbPassword.Text == listaccount[i].PasswordAccount)
                {
                    IDUser = listaccount[i].IDAccount;
                    listaccount.Clear();
                    txbUsername.Select();
                    Hide();
                    SplashScreenManager.ShowDefaultSplashScreen("Đang mở...", "Phần Mềm Quản Lý Thư Viện");
                    Thread.Sleep(500);
                    FrmMain frmMain = new FrmMain(this, IDUser);
                    frmMain.Show();
                    SplashScreenManager.CloseDefaultSplashScreen();
                    return;
                }
            }
            XtraMessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }
        private void txbUsername_EditValueChanged(object sender, EventArgs e)
        {
            //HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbUsername, HelpGUI.KiemTraDieuKien.isUsername(txbUsername.Text), "Username không hợp lệ!");
        }

        private void txbPassword_EditValueChanged(object sender, EventArgs e)
        {
            //HelpGUI.ErrorProvider.Event_ErrorProvider(dxErrorProvider1, txbPassword, HelpGUI.KiemTraDieuKien.isPassword(txbPassword.Text), "Password không hợp lệ!");
        }
    }
}