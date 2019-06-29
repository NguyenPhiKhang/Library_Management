using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using QLTV_BUS;
using QLTV_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLTV_GUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Declare
        string idaccount = "";
        ACCOUNT account = new ACCOUNT();
        FrmLogin frmLogin;
        List<string> listper = new List<string>();
        int flag = 0;
        DevExpress.Utils.ToolTipItem toolTipItem = new DevExpress.Utils.ToolTipItem();
        DevExpress.Utils.SuperToolTip superToolTip = new DevExpress.Utils.SuperToolTip();
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(FrmLogin frmlogin, string iduser) : this()
        {
            idaccount = iduser;
            frmLogin = frmlogin;
        }
        #endregion
        #region Methods
        //Kiểm tra sự tồn tại của form con
        private Form KiemTraTonTai(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType) //Neu Form duoc truyen vao da duoc mo
                    return f;
            }
            return null;
        }
        void ShowNameAccount()
        {
            if (account.TypeOfAccount == "USER")
                subitemAccount.Caption = DOCGIABUS.Instance.GetInfoDocGia(account.IDAccount).ToList()[0].HoTen.ToString();
            else subitemAccount.Caption = ADMINBUS.Instance.GetInfoAdmin(account.IDAccount).ToList()[0].NameAdmin.ToString();
            toolTipItem.Text = subitemAccount.Caption;
            superToolTip.Items.Add(toolTipItem);
            this.bsitem_Account.SuperTip = superToolTip;
        }
        void VisibleTab()
        {
            rbpageQLadmin.Visible = false;
            tab_docgia.Visible = false;
            tab_sach.Visible = false;
            tab_muontra.Visible = false;
            tab_baocao.Visible = false;
            tab_quydinh.Visible = false;
        }
        void ShowTab()
        {
            rbpageQLadmin.Visible = true;
            tab_docgia.Visible = true;
            tab_sach.Visible = true;
            tab_muontra.Visible = true;
            tab_baocao.Visible = true;
            tab_quydinh.Visible = true;
        }
        void KiemTraPermisson()
        {
            account = ACCOUNTBUS.Instance.GetInfoAccount(idaccount).ToList()[0];
            ShowNameAccount();
            List<string> list = new List<string>();
            list = CHITIETPHANQUYENBUS.Instance.GetListPerOfAccount(idaccount).ToList();
            foreach (var item in list)
            {
                listper.Add(PERMISSIONBUS.Instance.GetInfoPermission(item)[0].CodeAction.ToString());
            }
            VisibleTab();
            foreach (var item in listper)
            {
                switch (item)
                {
                    case "DG":
                        VisibleTab();
                        return;
                    case "QL":
                        ShowTab();
                        return;
                    case "QLDG":
                        tab_docgia.Visible = true;
                        break;
                    case "QLS":
                        tab_sach.Visible = true;
                        break;
                    case "QLMT":
                        tab_muontra.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }
        void DangXuat()
        {
            flag = 1;
            //for (int i = xtraTabbedMdiManager1.Pages.Count - 1; i >= 0; i--)
            //{
            //    xtraTabbedMdiManager1.Pages[i].MdiChild.Close();
            //}
            Close();
            frmLogin.Visible = true;
        }
        #endregion
        #region Event_Load
        private void FrmMain_Load(object sender, EventArgs e)
        {
            KiemTraPermisson();
        }
        #endregion
        #region Event_Click_MDIChildren
        private void btnDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDocGia));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                frmDocGia f = new frmDocGia
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }
        private void btnLoaiDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmLoaiDocGia));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                frmLoaiDocGia f = new frmLoaiDocGia
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }
        private void btnSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmSach));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                frmSach f = new frmSach
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }
        private void btnTheLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTheLoai));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                frmTheLoai f = new frmTheLoai
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }
        private void btnTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTacGia));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                frmTacGia f = new frmTacGia
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }

        private void btnMuonSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTTMuonSach));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                frmTTMuonSach f = new frmTTMuonSach
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }

        private void btnTraSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmTTTraSach));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                frmTTTraSach f = new frmTTTraSach
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }

        private void btnBCSachTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmBCTKTraTre));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                frmBCTKTraTre f = new frmBCTKTraTre
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }

        private void btnBCSachMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmBCTKSachMuonTL));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                frmBCTKSachMuonTL f = new frmBCTKSachMuonTL
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }
        private void btnTDQuyDinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmThayDoiQuiDinh));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                frmThayDoiQuiDinh f = new frmThayDoiQuiDinh
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }
        private void btnTienPhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(frmDSPhieuPhat));
            if (frm != null)
                frm.Activate();
            else
            {
                SplashScreenManager.ShowDefaultWaitForm();
                frmDSPhieuPhat f = new frmDSPhieuPhat
                {
                    MdiParent = this
                };
                f.Show();
                SplashScreenManager.CloseDefaultSplashScreen();
            }
        }
        private void btnTTaccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (account.TypeOfAccount == "USER")
            {
                Form frm = this.KiemTraTonTai(typeof(frmTTCaNhan));
                if (frm != null)
                    frm.Activate();
                else
                {
                    SplashScreenManager.ShowDefaultWaitForm();
                    frmTTCaNhan f = new frmTTCaNhan(account.IDAccount)
                    {
                        MdiParent = this
                    };
                    f.Show();
                    SplashScreenManager.CloseDefaultSplashScreen();
                }
            }
            else XtraMessageBox.Show("Chưa có dữ liệu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnInfoAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (account.TypeOfAccount == "USER")
            {
                Form frm = this.KiemTraTonTai(typeof(frmTTCaNhan));
                if (frm != null)
                    frm.Activate();
                else
                {
                    SplashScreenManager.ShowDefaultWaitForm();
                    frmTTCaNhan f = new frmTTCaNhan(account.IDAccount)
                    {
                        MdiParent = this
                    };
                    f.Show();
                    SplashScreenManager.CloseDefaultSplashScreen();
                }
            }
            else XtraMessageBox.Show("Chưa có dữ liệu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region Event_Click
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChiTietPM ctpm = new frmChiTietPM();
            ctpm.ShowDialog();
        }
        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangXuat();
        }
        private void btn_bsitemLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangXuat();
        }

        private void btn_Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangXuat();
        }

        private void btnQuanLiAdmin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Chưa có dữ liệu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region Event_Closing
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == 0)
                Application.Exit();
        }
        #endregion
    }
}
